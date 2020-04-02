using Microsoft.VisualStudio.TestTools.UnitTesting;
using Galaxism.TimeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxism.TimeExtension.Tests
{
    [TestClass()]
    public class TimeExtensionsTests
    {
        public static IEnumerable<object[]> OfferData()
        {
            Random random = new Random();
            DateTime baseTime = new DateTime(2020, 4, 2);
            for (int i = 0; i < 10; i++)
            {
                yield return new object[] { baseTime, random.NextDouble() };
                yield return new object[] { baseTime, -random.NextDouble() };
            }
        }

        [TestMethod()]
        [DynamicData(nameof(OfferData), DynamicDataSourceType.Method)]
        public void AddPreciseDaysTest(DateTime date, double day)
        {
            DateTime date1 = date.AddPreciseDays(day);
            DateTime date2 = date.AddDays(day);
            Assert.AreNotEqual(0, date1.Ticks % 10000);
            Assert.AreEqual(0, date2.Ticks % 10000);
            Assert.IsTrue(Math.Abs(date1.Ticks / 10000 - date2.Ticks / 10000) <= 1);
        }

        [TestMethod()]
        [DynamicData(nameof(OfferData), DynamicDataSourceType.Method)]
        public void AddPreciseHoursTest(DateTime date, double hours)
        {
            DateTime date1 = date.AddPreciseHours(hours);
            DateTime date2 = date.AddHours(hours);
            Assert.AreNotEqual(0, date1.Ticks % 10000);
            Assert.AreEqual(0, date2.Ticks % 10000);
            Assert.IsTrue(Math.Abs(date1.Ticks / 10000 - date2.Ticks / 10000) <= 1);
        }

        [TestMethod()]
        [DynamicData(nameof(OfferData), DynamicDataSourceType.Method)]
        public void AddPreciseMinutesTest(DateTime date, double minutes)
        {
            DateTime date1 = date.AddPreciseMinutes(minutes);
            DateTime date2 = date.AddMinutes(minutes);
            Assert.AreNotEqual(0, date1.Ticks % 10000);
            Assert.AreEqual(0, date2.Ticks % 10000);
            Assert.IsTrue(Math.Abs(date1.Ticks / 10000 - date2.Ticks / 10000) <= 1);
        }

        [TestMethod()]
        [DynamicData(nameof(OfferData), DynamicDataSourceType.Method)]
        public void AddPreciseSecondsTest(DateTime date, double seconds)
        {
            DateTime date1 = date.AddPreciseSeconds(seconds);
            DateTime date2 = date.AddSeconds(seconds);
            Assert.AreNotEqual(0, date1.Ticks % 10000);
            Assert.AreEqual(0, date2.Ticks % 10000);
            Assert.IsTrue(Math.Abs(date1.Ticks / 10000 - date2.Ticks / 10000) <= 1);
        }

        [TestMethod()]
        [DynamicData(nameof(OfferData), DynamicDataSourceType.Method)]
        public void AddPreciseMillisecondsTest(DateTime date, double milliseconds)
        {
            DateTime date1 = date.AddPreciseMilliseconds(milliseconds);
            DateTime date2 = date.AddMilliseconds(milliseconds);
            Assert.AreNotEqual(0, date1.Ticks % 10000);
            Assert.AreEqual(0, date2.Ticks % 10000);
            Assert.IsTrue(Math.Abs(date1.Ticks / 10000 - date2.Ticks / 10000) <= 1);
        }

        public static IEnumerable<object[]> AddMicrosecondsTestData()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                yield return new object[] { DateTime.Now, 100000000 * random.NextDouble() };
            }
        }

        [TestMethod()]
        [DynamicData(nameof(AddMicrosecondsTestData), DynamicDataSourceType.Method)]
        public void AddMicrosecondsTest(DateTime dateTime, double diff)
        {
            DateTime date = dateTime.AddMicroseconds(diff);
            Assert.AreEqual((long)(diff * 10), date.Ticks - dateTime.Ticks);
        }

        [TestMethod()]
        public void GetMicrosecondsTest()
        {
            
        }

        [TestMethod()]
        public void MicrosecondsTest()
        {
            
        }

        [TestMethod()]
        public void TotalMicrosecondsTest()
        {
            
        }
    }
}