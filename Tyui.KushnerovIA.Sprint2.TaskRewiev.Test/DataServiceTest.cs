using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyui.KushnerovIA.Sprint2.TaskRewiev.Lib;

namespace Tyui.KushnerovIA.Sprint2.TaskRewiev.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
