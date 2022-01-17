using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using ToSic.Razor.Internals;

namespace Razor_Blades_Tests
{
    [TestClass]
    public class Initialize
    {
        [AssemblyInitialize]
        public static void InitToJson(TestContext context)
        {
            StartUp.RegisterToJson(JsonConvert.SerializeObject);
        }
    }
}
