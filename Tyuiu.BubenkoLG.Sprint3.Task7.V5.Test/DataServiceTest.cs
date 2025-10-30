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
            double[] wait = { 70.14, 55.21, 41.05, 27.96, 15.48, 1.00, -13.06, -28.16, -42.96, -56.77, -69.83 };

            CollectionAssert.AreEqual(wait, valueArray);

        }
    }
}