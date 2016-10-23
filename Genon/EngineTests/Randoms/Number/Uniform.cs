using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EngineTests
{
    [TestClass]
    public class Uniform
    {
        [TestMethod]
        public void GenerateAFew()
        {
            Random r = new Random(45);

            Engine.Randoms.Number.Uniform u = new Engine.Randoms.Number.Uniform();
            u.MinValue = -253;
            u.MaxValue = 462;
            u.Generate(r);
            Assert.AreEqual("-85", u.AsString());
            u.Generate(r);
            Assert.AreEqual("-238", u.AsString());
        }

        [TestMethod]
        public void MakeLots()
        {
            Random r = new Random(45);

            Engine.Randoms.Number.Uniform u = new Engine.Randoms.Number.Uniform();
            u.MinValue = -4;
            u.MaxValue = 4;

            for (int i = 0; i < 100; i++)
            {
                u.Generate(r);
                Console.WriteLine(u.AsString());
                Assert.IsTrue(int.Parse(u.AsString())  < 4);
                Assert.IsTrue(int.Parse(u.AsString()) >= -4);
            }

        }


    }
}
