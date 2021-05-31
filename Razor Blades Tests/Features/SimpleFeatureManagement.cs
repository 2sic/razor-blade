using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Page;


namespace Razor_Blades_Tests.Features
{
    [TestClass]
    public class SimpleFeatureManagement
    {
        [TestMethod]
        public void AddFeatures()
        {
            var fm = new PageFeatures();

            fm.Register(new PageFeature("turnOn", "turnOn JS"));
            
            Assert.IsTrue(fm.Features["turnOn"] != null);
            Assert.IsTrue(fm.Features["Turnon"] != null);
        }
    }
}
