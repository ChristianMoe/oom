using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    class Tests
    {
        [Test]

        public void Test1_NegativeDay ()
        {
            Assert.Catch(() =>
            {
                var termin = new Termin(-2, 10, 2016, "Salzburg", "Projekt Zentaurus",1001);
            });
        }
        [Test]

        public void Test2_NegativeMonth()
        {
            Assert.Catch(() =>
            {
                var termin = new Termin(10, -3, 2016, "Salzburg", "Projekt Zentaurus",1001);
            });
        }
        [Test]

        public void Test3_YearBefore2016()
        {
            Assert.Catch(() =>
            {
                var termin = new Termin(10, 10, 2015, "Salzburg", "Projekt Zentaurus",1001);
            });
        }
        [Test]

        public void Test4_RückgabewertThemaBeiTermin()
        {
            var termin = new Termin(10, 10, 2016, "Salzburg", "Projekt Zentaurus",1001);
            Assert.IsTrue(String.Equals(termin.GetThema(),"Projekt Zentaurus", StringComparison.Ordinal));
        }
        [Test]

        public void Test5_RückgabewertConsultantName()
        {
            var con1 = new Consultant("Horst", "Maier", new DateTime(1980, 04, 15), "horst.maier@conpro.at", "+43 664 2380032","Horsti", "Initial01", 0001);
            Assert.IsTrue(String.Equals(con1.Vorname+con1.Nachname, "HorstMaier", StringComparison.Ordinal));

        }
        [Test]

        public void Test6_RückgabewertGeburtsdatum()
        {
            var con1 = new Consultant("Horst", "Maier", new DateTime(1980, 04, 15), "horst.maier@conpro.at", "+43 664 2380032", "Horsti", "Initial01", 0001);
            var birthdate = new DateTime(1980, 04, 15);
            Assert.IsTrue(con1.Geburtstag == birthdate);
        }
        [Test]
        
        public void Test7_NegativesGeburtsdatum()
        {
            Assert.Catch(() =>
            {
                var con1 = new Consultant("Horst", "Maier", new DateTime(1980, -4, 15), "horst.maier@conpro.at", "+43 664 2380032", "Horsti", "Initial01", 0001);
            });
        }
        [Test]

        public void Test8_KeinOrtBeiTermin()
        {
            var termin = new Termin(1,1,2016,null,null,1001);
            Assert.IsTrue(String.Equals(termin.GetOrt(), null, StringComparison.Ordinal));
        }




    }
}
