using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace JsonPaser
{
    static public class Util
    {
		/// <summary>
		/// 判断该是否为数组列
		/// </summary>
		/// <param name="fieldName"></param>
		/// <returns></returns>
		static public bool IsListCol(string fieldName)
		{
			return Regex.IsMatch(fieldName, "^\\D+\\d+$");
		}
		/// <summary>
		/// 获取
		/// </summary>
		/// <param name="cols"></param>
		/// <param name="fieldName"></param>
		/// <returns></returns>
		static public string GetPrefixAndMarkColumnDisable(string fieldName)
		{
			string text = string.Empty;
			Match match = Regex.Match(fieldName, "^\\D+");
			if (match.Success)
			{
				text = match.Value;
			
			}
			return text;
		}
		static public int RunProcess(string fileName, string appParam)
		{
			int returnValue = -1;
			try
			{
				Process myProcess = new Process();
				ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(fileName, appParam);
				myProcessStartInfo.CreateNoWindow = true;
				myProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				myProcess.StartInfo = myProcessStartInfo;
				myProcess.Start();

				while (!myProcess.HasExited)
				{
					myProcess.WaitForExit();
				}

				returnValue = myProcess.ExitCode;
				myProcess.Dispose();
				myProcess.Close();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message.ToString());
			}
			return returnValue;
		}
        /// <summary>
        /// 加载表结构json文件
        /// </summary>
        /// <param name="fbSavePath"></param>
        /// <param name="jsonPath"></param>
        public static List<TemplateCls> LoadClsJson(string jsonPath)
		{
			string jsonContent = File.ReadAllText(jsonPath);

			var jd = JsonMapper.ToObject(jsonContent);
			IDictionary dict = jd as IDictionary;
			if (!dict.Contains("root"))
				return null;
			var jdArray = dict["root"] as JsonData;
			string className = string.Empty;
			string relativePath = string.Empty;
			StringBuilder fieldsBuilder = new StringBuilder();
			List<TemplateCls> classDataList = new List<TemplateCls>();
			for (int index = 0; index < jdArray.Count; index++)
			{
				className = string.Empty;
				IDictionary classDict = jdArray[index] as IDictionary;
				fieldsBuilder.Clear();
				if (classDict.Contains("class_name"))
				{
					className = (string)jdArray[index]["class_name"];
				}
				if (classDict.Contains("reltaive_path"))
				{
					relativePath = (string)jdArray[index]["reltaive_path"];
				}
				if (relativePath.StartsWith("Server/"))
				{
					continue;
				}
				TemplateCls tmpCls = new TemplateCls(className, relativePath);
				classDataList.Add(tmpCls);
				if (classDict.Contains("fields"))
				{
					var fieldArray = classDict["fields"] as JsonData;
					for (int i = 0; i < fieldArray.Count; i++)
					{
						string name = (string)fieldArray[i]["name"];
						string type = (string)fieldArray[i]["type"];
						string defVal = (string)fieldArray[i]["value"];

						tmpCls.AddField(new ClsField(name, type, defVal));
					}
				}
			}
			return classDataList;
		}
		/// <summary>
		/// 导出FlatBuffer需要的table表
		/// </summary>
		/// <param name="clsDataList"></param>
		public static void ExportFlatBufferTable(List<TemplateCls> clsDataList, string fbSavePath)
		{
            StringBuilder fieldsBuilder = new StringBuilder();
			foreach (var cls in clsDataList)
			{
				fieldsBuilder.Clear();
				for (int index = 0; index < cls.mFields.Count; index++) 
				{
					var curField = cls.mFields[index];
					string name = curField.Name;
					string type = curField.Type;
					string defVal = curField.DefVal;
					name = name.Trim();
					type = type.Trim();
					defVal = defVal.Trim();
					if (Util.IsListCol(name))
					{
						string prefixAndMarkColumnDisable = Util.GetPrefixAndMarkColumnDisable(name);
						string strNum = name.Substring(prefixAndMarkColumnDisable.Length, name.Length - prefixAndMarkColumnDisable.Length);
						int nNum = int.Parse(strNum);
						if (nNum == 0)
						{
							if (index > 0)
							{
								fieldsBuilder.Append("\n\t");
							}
							fieldsBuilder.Append($"{prefixAndMarkColumnDisable}List:[{type}];");
						}
					}
					else
					{
						#region 默认值检查
						if (type == "int")
						{
							if (!int.TryParse(defVal, out var intVal))
							{
								defVal = "0";
							}
						}
						else if (type == "float")
						{
							if (!float.TryParse(defVal, out var intVal))
							{
								defVal = "0";
							}
						}
						else if (type == "long")
						{
							if (!long.TryParse(defVal, out var intVal))
							{
								defVal = "0";
							}
						}
						else if (type == "bool")
						{
							if (!bool.TryParse(defVal, out var intVal))
							{
								defVal = "false";
							}
							else
							{
								defVal = defVal.ToLower();
							}
						}
						#endregion

						if (index > 0)
						{
							fieldsBuilder.Append("\n\t");
						}
						if (string.IsNullOrEmpty(defVal) || type == "string")
						{
							fieldsBuilder.Append($"{name}:{type};");
						}
						else
						{
							fieldsBuilder.Append($"{name}:{type} = {defVal};");
						}
					}
				}
				#region 导出表结构
				if (!Directory.Exists(Path.GetDirectoryName(fbSavePath)))
				{
					Directory.CreateDirectory(fbSavePath);
				}
				string dtPath = System.IO.Path.Combine(fbSavePath, $"{cls.mClassName}.txt");
				string dtName = Path.GetFileName(dtPath);
				dtName = dtName.Substring(0, dtName.IndexOf('.'));
				var tmplateStr = Consts.DTTemplate;
				tmplateStr = tmplateStr.Replace("@{class_name_tag}", dtName);
				tmplateStr = tmplateStr.Replace("@{class_field_tag}", fieldsBuilder.ToString());
				var dir = Path.GetDirectoryName(dtPath);
				if (!Directory.Exists(dir))
				{
					Directory.CreateDirectory(dir);
				}
				Console.WriteLine(dtPath);
				File.WriteAllText(dtPath, tmplateStr);
				#endregion
			}
		}
		/// <summary>
		/// 导出Table对应的Providerder
		/// </summary>
		/// <param name="clsDataList"></param>
		/// <param name="providerSavePath"></param>
		internal static void GenFBProveider(List<TemplateCls> clsDataList, string providerSavePath)
		{
			if (!Directory.Exists(providerSavePath))
			{
				Directory.CreateDirectory(providerSavePath);
			}
			foreach (var cls in clsDataList)
			{
                var tmplateStr = Consts.FB_PROVIDER_TT;
                tmplateStr = tmplateStr.Replace("@{class_name_tag}", cls.mClassName);
                tmplateStr = tmplateStr.Replace("@{field_id_name}", cls.mFields[0].Name);
                tmplateStr = tmplateStr.Replace("@{class_relative_path}", cls.mRelativePath);
                string csFilePath = System.IO.Path.Combine(providerSavePath, $"{cls.mClassName}Provider.cs");

                Console.WriteLine(csFilePath);
                File.WriteAllText(csFilePath, tmplateStr);
            }
		}
		/// <summary>
		/// 生成cs代码用于将txt二进制文件供FB使用
		/// </summary>
		public static void GenFBCsFile(string fbPath, string savePath)
		{
			string EXE = @"flatc.exe";
			var tbFiles = Directory.GetFiles(fbPath, "*.txt");
			foreach (var file in tbFiles)
			{
				Console.WriteLine($"Parse Table To CS File:{file}");

				string appParm = $"-n {file} --gen-onefile";
				Util.RunProcess(EXE, appParm);
			}

			var csFiles = Directory.GetFiles(Environment.CurrentDirectory, "*.cs");
			foreach (var file in csFiles)
			{
				var saveFilePath = savePath + "/" + Path.GetFileName(file);
				File.Move(file, saveFilePath);
			}
		}
		/// <summary>
		/// 把数值表导出为FB支持的二进制文件
		/// </summary>
		/// <param name="clsDataList"></param>
		/// <param name="csSavePath"></param>
		public static void ExportBinaryData(List<TemplateCls> clsDataList, string csSavePath)
		{
			var tmplateStr = Consts.FB_PROVIDER_EXPROT_TT;
			//生成加载数值表代码
			{
				StringBuilder loadDataBuilder = new StringBuilder();
				string template = "Tab_@{class_name_tag}Provider.Instance.Load(ReadTxtTable(\"@{table_relateive_path}\"));";
				int iCount = 0;
				foreach (var cls in clsDataList)
				{
					if (iCount > 0)
					{
						loadDataBuilder.Append("\t\t\t");
					}
					loadDataBuilder.AppendLine(template.Replace("@{class_name_tag}", cls.mClassName).Replace("@{table_relateive_path}", cls.mRelativePath));
					iCount += 1;
					if (0 == iCount % 5)
					{
						//loadDataBuilder.AppendLine("\t\t\tyield return new WaitForEndOfFrame();");
					}
				}
				tmplateStr = tmplateStr.Replace("@{provider_load_data}", loadDataBuilder.ToString());
			}
			//生成FlatBuffer加载二进制文件代码
			{
				StringBuilder loadDataBuilder = new StringBuilder();
				string template = "FB_@{class_name_tag}Provider.Instance.LoadFromFile(GetFlatBufferPath(\"@{table_relateive_path}\"));";
				int iCount = 0;
				foreach (var cls in clsDataList)
				{
					if (iCount > 0)
					{
						loadDataBuilder.Append("\t\t\t");
					}
					loadDataBuilder.AppendLine(template.Replace("@{class_name_tag}", cls.mClassName).Replace("@{table_relateive_path}", cls.mRelativePath));
					iCount += 1;
					if (0 == iCount % 20)
					{
						loadDataBuilder.AppendLine("\t\t\tyield return new WaitForEndOfFrame();");
					}
				}
				tmplateStr = tmplateStr.Replace("@{load_binary_data_from_file_func}", loadDataBuilder.ToString());
			}
			//生成FlatBuffer加载二进制文件代码
			{
				StringBuilder loadDataBuilder = new StringBuilder();
				string template = "FB_@{class_name_tag}Provider.Instance.LoadFromMemory(ReadFlatBufferDTBytes(\"@{table_relateive_path}\"));";
				int iCount = 0;
				foreach (var cls in clsDataList)
				{
					if (iCount > 0)
					{
						loadDataBuilder.Append("\t\t\t");
					}
					loadDataBuilder.AppendLine(template.Replace("@{class_name_tag}", cls.mClassName).Replace("@{table_relateive_path}", cls.mRelativePath));
					iCount += 1;
					if (0 == iCount % 20)
					{
						loadDataBuilder.AppendLine("\t\t\tyield return new WaitForEndOfFrame();");
					}
				}
				tmplateStr = tmplateStr.Replace("@{load_binary_data_form_memory_func}", loadDataBuilder.ToString());
			}
			//清理FlatBuffer表中数据
			{
				StringBuilder loadDataBuilder = new StringBuilder();
				string template = "FB_@{class_name_tag}Provider.Instance.Clear();";
				int iCount = 0;
				foreach (var cls in clsDataList)
				{
					if (iCount > 0)
					{
						loadDataBuilder.Append("\t\t\t");
					}
					loadDataBuilder.AppendLine(template.Replace("@{class_name_tag}", cls.mClassName));
                    iCount += 1;
                    if (0 == iCount % 5)
                    {
                        //loadDataBuilder.AppendLine("\t\t\tyield return new WaitForEndOfFrame();");
                    }
                }
				tmplateStr = tmplateStr.Replace("@{clear_flatbuffer_data}", loadDataBuilder.ToString());
			}
			//生成导出二进制文件代码
			{
				StringBuilder newFuncBuilder = new StringBuilder();
				StringBuilder funcsBuilder = new StringBuilder();
				string strLstToArrayTT = @"StringOffset[] @{offset_name} = new StringOffset[curData." + "@{field_name}" + @".Count];
				for (var i = 0; i < curData." + "@{field_name}" + @".Count; i++)
				{
					@{offset_name}[i] = fbb.CreateString(curData." + "@{field_name}" + @"[i]);
				}";

				string template = "\n\t\t" + @"static void Exprot@{class_name_tag}()
		{
			FlatBufferBuilder fbb = new FlatBufferBuilder(1);
			var data = Tab_@{class_name_tag}Provider.Instance.ListData;
	
			Offset<FB_@{class_name_tag}>[] offsetArray = new Offset<FB_@{class_name_tag}>[data.Count];
			for (int index = 0; index < data.Count; index++)
			{
				var curData = data[index];
				@{string_list_to_array}
				offsetArray[index] = FB_@{class_name_tag}.CreateFB_@{class_name_tag}(fbb, " + "@{fields_name}" + @");
			}
			var dataVector = FB_@{class_name_tag}Container.CreateItemsVector(fbb, offsetArray);
	
			FB_@{class_name_tag}Container.StartFB_@{class_name_tag}Container(fbb);
			FB_@{class_name_tag}Container.AddItems(fbb, dataVector);
			var provider = FB_@{class_name_tag}Container.EndFB_@{class_name_tag}Container(fbb);
			FB_@{class_name_tag}Container.FinishFB_@{class_name_tag}ContainerBuffer(fbb, provider);
	
			using (var ms = new MemoryStream(fbb.DataBuffer.Data, fbb.DataBuffer.Position, fbb.Offset))
			{
				WriteToFile(" + "\"@{relative_path_file}\"" + @", ms.ToArray());
			}
		}" + "";
				StringBuilder fieldsBuilder = new StringBuilder();
				StringBuilder codeStrBuilder = new StringBuilder();
				string field_template = "curData.@{field_name}";
				int iCount = 0;
				foreach (var cls in clsDataList)
				{
					fieldsBuilder.Clear();
					if (iCount > 0)
					{
						funcsBuilder.AppendLine($"\t\t\tExprot{cls.mClassName}();");
					}
					else
					{
						funcsBuilder.AppendLine($"Exprot{cls.mClassName}();");
					}
					iCount += 1;
					if (0 == iCount % 5)
					{
						//funcsBuilder.AppendLine("\t\t\tyield return new WaitForEndOfFrame();");
					}
					codeStrBuilder.Clear();
					for (int index = 0; index < cls.mFields.Count; index++)
					{
						var curField = cls.mFields[index];

						string pbFieldName = curField.Name;
						bool IsListField = false;
						if (Util.IsListCol(curField.Name))
						{
							string prefixAndMarkColumnDisable = Util.GetPrefixAndMarkColumnDisable(pbFieldName);
							string strNum = pbFieldName.Substring(prefixAndMarkColumnDisable.Length, pbFieldName.Length - prefixAndMarkColumnDisable.Length);
							int nNum = int.Parse(strNum);
							if (nNum == 0)
							{
								pbFieldName = prefixAndMarkColumnDisable;
								pbFieldName += "List";
								IsListField = true;
							}
							else
							{
								continue;
							}
						}
						if (index > 0)
						{
							fieldsBuilder.Append(",");
						}
						if (IsListField)
						{
							string fieldCreatePargma = pbFieldName.Substring(0, 1).ToUpper() + pbFieldName.Substring(1);
							if (curField.Type == "string")
							{
								codeStrBuilder.AppendLine(strLstToArrayTT.Replace("@{offset_name}", $"{pbFieldName}offSet").Replace("@{field_name}", pbFieldName));
								fieldsBuilder.Append($"FB_{cls.mClassName}.Create{fieldCreatePargma.Replace("_", "")}Vector(fbb,").Append($"{pbFieldName}offSet").Append(")");
							}
							else
							{
								fieldsBuilder.Append($"FB_{cls.mClassName}.Create{fieldCreatePargma.Replace("_","")}Vector(fbb,").Append($"curData.{pbFieldName}.ToArray()").Append(")");
							}

						}
						else if (curField.Type == "string")
						{
							fieldsBuilder.Append("fbb.CreateString(").Append(field_template.Replace("@{field_name}", pbFieldName)).Append(")");
						}
						else
						{
							fieldsBuilder.Append(field_template.Replace("@{field_name}", pbFieldName));
						}


					}
				
					newFuncBuilder.AppendLine(template.Replace("@{class_name_tag}", cls.mClassName).Replace("@{relative_path_file}", cls.mRelativePath))
						;
					newFuncBuilder.Replace("@{fields_name}", fieldsBuilder.ToString()).Replace("@{string_list_to_array}", codeStrBuilder.ToString());

				}
				tmplateStr = tmplateStr.Replace("@{export_binary_data}", newFuncBuilder.ToString());
				tmplateStr = tmplateStr.Replace("@{export_binary_data_func}", funcsBuilder.ToString());
				File.WriteAllText(Path.Combine(csSavePath, "FBBinaryExport.cs"), tmplateStr);
			}
		}

		/// <summary>
		/// Tab_表代码替换为FB_表代码
		/// </summary>
		/// <param name="clsDataList"></param>
		/// <param name="hotfixPath"></param>
		internal static void ReplaceDBCodeWithFBCode(List<TemplateCls> clsDataList, string hotfixPath)
		{
			HashSet<string> filterTb = new HashSet<string>(new string[] { "fwqlist", "gonggao" });
			var csFiles = Directory.GetFiles(hotfixPath, "*.cs", SearchOption.AllDirectories);
			Dictionary<string, string> newCodeDict = new Dictionary<string, string>();
			HashSet<string> codeMarkSet = new HashSet<string>();
			foreach(var file in csFiles)
			{
				var content = File.ReadAllText(file);
				foreach (var cls in clsDataList)
				{
					if (filterTb.Contains(cls.mClassName))
						continue;
					string srcCls = $"Tab_{cls.mClassName}";
					string tarCls = $"FB_{cls.mClassName}";
					if (content.Contains(srcCls))
					{
						content = content.Replace(srcCls, tarCls);
						if (!codeMarkSet.Contains(file))
						{
							codeMarkSet.Add(file);
						}
					}
				}
				if (codeMarkSet.Contains(file))
				{
					newCodeDict[file] = content;
				}
			}
			
			var iter = newCodeDict.GetEnumerator();
			while (iter.MoveNext())
			{
				File.WriteAllText(iter.Current.Key, iter.Current.Value, Encoding.ASCII);
			}
		}
	}
}
