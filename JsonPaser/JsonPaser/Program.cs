using LitJson;
using System;
using System.Collections;
using System.IO;
using System.Text;

namespace JsonPaser
{
    public partial class Program
    {
        static PargmaTypeCheck mPargmaTypeCheck = new PargmaTypeCheck();
        /// <summary>
        /// 参数1：Excel表结构文件，参数2：fb表存放目录，参数3：cs文件存放目录
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            mPargmaTypeCheck.Init(Environment.GetCommandLineArgs());
            var jsonPath = mPargmaTypeCheck.GetValue(PargmaType.jsonPath);
            var clsDataList = Util.LoadClsJson(jsonPath);

            var fbSavePath = mPargmaTypeCheck.GetValue(PargmaType.fbSavePath);
            if (mPargmaTypeCheck.IsTrue(PargmaType.GenFB))
            {
                if (!Directory.Exists(fbSavePath))
                {
                    Directory.CreateDirectory(fbSavePath);
                }
                Util.ExportFlatBufferTable(clsDataList, fbSavePath);
            }

            if (mPargmaTypeCheck.IsTrue(PargmaType.GenCls))
            {
                var csSavePath = mPargmaTypeCheck.GetValue(PargmaType.csSavePath);
                Consts.FB_PROVIDER_TT = File.ReadAllText(mPargmaTypeCheck.GetValue(PargmaType.FBProviderTT));
                Consts.FB_PROVIDER_EXPROT_TT = File.ReadAllText(mPargmaTypeCheck.GetValue(PargmaType.FBInitTT));
                if (Directory.Exists(csSavePath))
                {
                    Directory.Delete(csSavePath, true);
                }
                if (!Directory.Exists(csSavePath))
                {
                    Directory.CreateDirectory(csSavePath);
                }
                Util.GenFBCsFile(fbSavePath, csSavePath);
                Util.GenFBProveider(clsDataList, csSavePath + "/Providder");
                Util.ExportBinaryData(clsDataList, csSavePath + "/Providder");
            }

            if (mPargmaTypeCheck.IsTrue(PargmaType.RelCode))
            {
                var hotfixPath = mPargmaTypeCheck.GetValue(PargmaType.hotfixPath);
                Util.ReplaceDBCodeWithFBCode(clsDataList, hotfixPath);
            }
        }
    }
}
