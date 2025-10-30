using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint3.Task7.V5.Lib;

namespace Tyuiu.BubenkoLG.Sprint3.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;


            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 68.29, 54.53, 42.49, 30.00, 16.30, 2.20, -11.70, -26.00, -41.51, -57.47, -71.71 };

            CollectionAssert.AreEqual(wait, valueArray);

        }
    }
}