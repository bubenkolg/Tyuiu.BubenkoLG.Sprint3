using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint3.Task1.V19.Lib;

namespace Tyuiu.BubenkoLG.Sprint3.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;
            int x = 1;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            double wait = 96.895;

            Assert.AreEqual(wait, res);

        }
    }
}