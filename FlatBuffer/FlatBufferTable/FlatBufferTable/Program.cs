using JsonPaser;
using System;

namespace GenData
{
    public class ExportFBDataa
    {
        static PargmaTypeCheck mPargmaTypeCheck = new PargmaTypeCheck();
        static private void Main()
        {
            Export();
        }
        static public void Export()
        {
            mPargmaTypeCheck.Init(Environment.GetCommandLineArgs());
            FBBinaryExport.TxtRoot = mPargmaTypeCheck.GetValue(PargmaType.TxtRoot);
            FBBinaryExport.BinaryRoot = mPargmaTypeCheck.GetValue(PargmaType.BinaryRoot);
            FBBinaryExport.csSavePath = mPargmaTypeCheck.GetValue(PargmaType.csSavePath);
            Console.WriteLine($"TxtRoot:{FBBinaryExport.TxtRoot}\nBinaryRoot:{FBBinaryExport.BinaryRoot} \ncsSavePath:{FBBinaryExport.csSavePath}");
            FBBinaryExport.Export();
        }
    }
}
