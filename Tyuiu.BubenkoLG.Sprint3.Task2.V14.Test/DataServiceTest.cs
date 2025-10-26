using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint3.Task2.V14.Lib;

namespace Tyuiu.BubenkoLG.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 6;
            int x = 5;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            double wait = 10220.275;

            Assert.AreEqual(wait, res);

        }
    }
}