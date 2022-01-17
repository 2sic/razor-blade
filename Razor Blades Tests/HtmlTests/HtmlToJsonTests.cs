using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Internals;

namespace ToSic.RazorBladeTests.HtmlTests
{
    [TestClass]
    public class HtmlToJsonTests
    {
        [TestMethod]
        public void Basic()
        {
            Assert.AreEqual("null", Html.ToJson(null));
            Assert.AreEqual("45", Html.ToJson(45));
            Assert.AreEqual("{\"Name\":\"Daniel\"}", Html.ToJson(new { Name = "Daniel"}));
        }

        public HtmlToJsonTests BadPropertyToPreventSerialization;

        [TestMethod]
        [ExpectedException(typeof(Newtonsoft.Json.JsonSerializationException))]
        public void InvalidObject()
        {
            BadPropertyToPreventSerialization = this;
            Assert.AreEqual("should-throw-error", Html.ToJson(this));
        }

        [TestMethod]
        public void InvalidObjectReturningString()
        {
            BadPropertyToPreventSerialization = this;
            Assert.IsTrue(Html.ToJsonOrErrorMessage(this).StartsWith(Html.SerializationErrorIntro));
        }
    }
}
