using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSAutomationProject
{
    public class Class1
    {
        //4 yra lyginis skaicius
        //dabar 18 valanda
        //Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        //Testas “žalias” jeigu šiandien pirmadienis(DayOfWeek.Monday)
        //Testas “žalias” po to kai “palaukia” 5 sekundes


        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, $"{leftOver} is not even!");
        }

        [Test]
        public static void TestNowIs18()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(18, currentTime.Hour, "Dabar ne 18 valanda");
        }
        [Test]
        public static void TestIf995DalinasiIs3()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "995 nesidalina is 3 be liekanos");
        }
        [Test]
        public static void TestIsItWednesday()
        {
            DateTime currentDay = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Wednesday, currentDay.DayOfWeek, "dabar ne treciadienis");
        }
        [Test]
        public static void TestIfWaiting()
        {
            Thread.Sleep(5000);
        }
    }
}
