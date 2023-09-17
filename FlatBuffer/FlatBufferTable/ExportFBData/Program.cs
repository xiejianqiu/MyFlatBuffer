using JsonPaser;
using System;
using System.Diagnostics;

namespace ExportFBData
{
    class Program
    {
        static PargmaTypeCheck mPargmaTypeCheck = new PargmaTypeCheck();
        static void Main(string[] args)
        {
            mPargmaTypeCheck.Init(Environment.GetCommandLineArgs());
            FBBinaryExport.TxtRoot = mPargmaTypeCheck.GetValue(PargmaType.TxtRoot);
            FBBinaryExport.BinaryRoot = mPargmaTypeCheck.GetValue(PargmaType.BinaryRoot);
            Console.WriteLine($"TxtRoot:{FBBinaryExport.TxtRoot}\nBinaryRoot:{FBBinaryExport.BinaryRoot}");
            Stopwatch dog = new Stopwatch();
            dog.Start();
            FBBinaryExport.Export();
            Console.WriteLine($"UseTime: {dog.ElapsedMilliseconds / 1000}");
        }
    }
}
