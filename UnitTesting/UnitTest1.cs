using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Us us =  new Us();
            Person p = new Person();
            p.name = "Saman";
            Assert.AreEqual(us.m().name, p.name);
            
            
        }
    }
}
