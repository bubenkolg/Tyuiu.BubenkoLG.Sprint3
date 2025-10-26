using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint3.Task3.V27.Lib;

namespace Tyuiu.BubenkoLG.Sprint3.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string str = "!bt, g567kid f!";

            int res = ds.ConvertStringToInt(str);

            int wait = 567;

            Assert.AreEqual(wait, res);

        }
    }
}