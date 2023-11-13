using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.FaizullinDR.Sprint5.Task0.V20.Lib;

namespace Tyuiu.FaizullinDR.Sprint5.Task0.V20.Test
{
    [TestClass] 
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\toxen\source\repos\Tyuiu.FaizullinDR.Sprint5\Tyuiu.FaizullinDR.Sprint5.Task0.V20\bin\debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
