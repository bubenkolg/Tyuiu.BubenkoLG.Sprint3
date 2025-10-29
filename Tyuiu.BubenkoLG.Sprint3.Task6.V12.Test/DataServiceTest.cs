﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint3.Task6.V12.Lib;

namespace Tyuiu.BubenkoLG.Sprint3.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 9;
            int stopValue = 18;
            
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 221;

            Assert.AreEqual(wait, res);

        }
    }
}