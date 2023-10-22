using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint3.Task3.V29.Lib;

namespace Tyuiu.NikolaevaAN.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hnht";
            char item = 'h';
            string res = ds.DeleteCharInString(value, item);
            string wait = "cgr vtg nt";
            Assert.AreEqual(wait, res);
        }
    }
}
