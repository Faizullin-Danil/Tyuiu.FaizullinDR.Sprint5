using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FaizullinDR.Sprint5.Task4.V24.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint5.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
