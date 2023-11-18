using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint5.Task3.V9.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\toxen\source\repos\Tyuiu.FaizullinDR.Sprint5\Tyuiu.FaizullinDR.Sprint5.Task3.V9\bin\debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
