﻿//using System.Collections;
//using System.IO;
//using System.Text;
//using Shark;
//using UnityEngine;
//using System;
//using FlatBuffers;
//namespace JsonPaser
//{
//    public sealed class FBBinaryExport
//    {
//        public static string BinaryRoot = "datables/";
//        public static string TxtRoot = "";
//        public static StringBuilder builder = new StringBuilder();
//        public static Func<string, byte[]> ReadBytesHandler;
//        public static Func<string, string> ReDirectFilePathHandler;
//        public static Action OnLoadFBTableFinish;
//        static public string ReadTxtTable(string strPath)
//        {
//            builder.Clear();
//            string tablePath = TxtRoot;
//            builder.Append(tablePath).Append("/").Append(strPath);
//            string strData = null;
//            var localPath = builder.ToString();
//            if (File.Exists(localPath))
//            {
//                using (StreamReader sr = File.OpenText(localPath))
//                {
//                    strData = sr.ReadToEnd();
//                }
//            }
//            return strData;
//        }
//        /// <summary>
//        /// 将FlatBufer导出的二进制写入文件
//        /// </summary>
//        /// <param name="relFilePath"></param>
//        /// <param name="bytes"></param>
//        static public void WriteToFile(string relFilePath, byte[] bytes)
//        {
//            builder.Clear();
//            builder.Append(BinaryRoot).Append("/").Append(relFilePath);
//            string newFilePath = builder.ToString();
//            string dirPath = Path.GetDirectoryName(newFilePath);
//            if (!Directory.Exists(dirPath))
//            {
//                Directory.CreateDirectory(dirPath);
//            }
//            File.WriteAllBytes(newFilePath, bytes);
//        }
//        /// <summary>
//        /// 读取FlatBuffer二进制文件
//        /// </summary>
//        /// <param name="strPath"></param>
//        /// <returns></returns>
//        public static string GetFlatBufferPath(string relFilePath)
//        {
//            if (null != ReDirectFilePathHandler)
//            {
//                return ReDirectFilePathHandler(relFilePath);
//            }
//            builder.Clear();
//            builder.Append(BinaryRoot).Append(relFilePath);
//            return builder.ToString();
//        }
//        public static byte[] ReadFlatBufferDTBytes(string relFilePath)
//        {
//            if (null != ReadBytesHandler)
//            {
//                return ReadBytesHandler(relFilePath);
//            }
//            return File.ReadAllBytes(BinaryRoot + relFilePath);
//        }
//        /// <summary>
//        /// 加载TXT和导出FlatBuffer二进制文件
//        /// </summary>
//        /// <returns></returns>
//        static public void Export()
//        {
//            LoadData();
//            ExportBinaryData();
//        }
//        /// <summary>
//        /// 将TXT文件加载到内存
//        /// </summary>
//        /// <returns></returns>
//        static public void LoadData()
//        {
//            //Debug.Log("<color=green>LoadData Begin.</color>");
//            //@{provider_load_data}
//            //Debug.Log("<color=green>LoadData End.</color>");
//        }
//        /// <summary>
//        /// 加载FlatBuffer二进制文件
//        /// </summary>
//        /// <returns></returns>
//        static public IEnumerator LoadFBDataFromFile()
//        {
//            //Debug.Log("<color=green>LoadFBDataFromFile Begin.</color>");
//            //@{load_binary_data_from_file_func}
//            //Debug.Log("<color=green>LoadFBDataFromFile End.</color>");
//            if (null != OnLoadFBTableFinish)
//            {
//                OnLoadFBTableFinish();
//            }
//        }
//        /// <summary>
//        /// 加载FlatBuffer二进制文件
//        /// </summary>
//        /// <returns></returns>
//        static public IEnumerator LoadFBDataFromMemory()
//        {
//            //Debug.Log("<color=green>LoadFBDataFromMemory Begin.</color>");
//            //@{load_binary_data_form_memory_func}
//            //Debug.Log("<color=green>LoadFBDataFromMemory End.</color>");
//            if (null != OnLoadFBTableFinish)
//            {
//                OnLoadFBTableFinish();
//            }
//        }
//        /// <summary>
//        /// 清空FlatBuffer表
//        /// </summary>
//        /// <returns></returns>
//        static public void ClearFBData()
//        {
//            //Debug.Log("<color=green>ClearFBData Begin.</color>");
//            //@{clear_flatbuffer_data}
//            //Debug.Log("<color=green>ClearFBData End.</color>");
//        }
//        /// <summary>
//        /// 使用FlatBuffet将TXT导出成二进制文件
//        /// </summary>
//        /// <returns></returns>
//        static public void ExportBinaryData()
//        {
//            //Debug.Log("<color=green>ExportBinaryData Begin.</color>");
//            //@{export_binary_data_func}
//            //Debug.Log("<color=green>ExportBinaryData End.</color>");
//        }
//        #region load flatbuffer binary data
//        //@{export_binary_data}
//        #endregion
//    }
//}
