using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ToSic.Razor.Internals;

namespace ToSic.RazorBladeTests
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
