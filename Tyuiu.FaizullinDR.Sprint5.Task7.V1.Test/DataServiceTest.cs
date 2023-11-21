using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint5.Task7.V1.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\toxen\source\repos\Tyuiu.FaizullinDR.Sprint5\Tyuiu.FaizullinDR.Sprint5.Task7.V1\bin\debug\OutPutDataFileTask7V1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
