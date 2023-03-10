using JsonPaser;
using System;

namespace GenData
{
    public class ExportFBDataa
    {
        static public void Export()
        {
            var args = Environment.GetCommandLineArgs();
            FBBinaryExport.TxtRoot = args[1];
            FBBinaryExport.BinaryRoot = args[2];
            Console.WriteLine($"TxtRoot:{FBBinaryExport.TxtRoot}\nBinaryRoot:{FBBinaryExport.BinaryRoot}");
            FBBinaryExport.Export();
        }
    }
}
