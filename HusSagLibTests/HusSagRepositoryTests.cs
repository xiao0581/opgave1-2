using Microsoft.VisualStudio.TestTools.UnitTesting;
using HusSagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusSagLib.Tests
{
    [TestClass()]
    public class HusSagRepositoryTests
    {
       

        [TestMethod()]
        public void GetAllTest()
        {
           HusSagRepository husSagRepository = new HusSagRepository();
            List<HusSag> husSager = husSagRepository.GetAll();
            Assert.AreEqual(5, husSager.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
           HusSagRepository husSagRepository = new HusSagRepository();
            HusSag husSag = husSagRepository.GetById(1);
            Assert.AreEqual("Askvangen", husSag.Vej);

            husSagRepository = new HusSagRepository();
            husSag = husSagRepository.GetById(7);
            Assert.IsNull(husSag);
        }
        [TestMethod()]
        public void AddTest()
        {
           HusSagRepository husSagRepository = new HusSagRepository();
            HusSag husSag = new HusSag() { Vej = "Husumvej", HusNr = 10, By = "København", Pris = 5000000 };
            husSagRepository.Add(husSag);
            Assert.AreEqual(6, husSag.Id);
        }
    }
}