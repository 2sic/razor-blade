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

        // 2022-02-01 As tests were moved to .net 6, the standard .net json serializer ignores bad properties so these tests don't throw errors any more
        //[TestMethod]
        //[ExpectedException(typeof(Newtonsoft.Json.JsonSerializationException))]
        //public void InvalidObject()
        //{
        //    BadPropertyToPreventSerialization = this;
        //    Assert.AreEqual("should-throw-error", Html.ToJson(this));
        //}

        //[TestMethod]
        //public void InvalidObjectReturningString()
        //{
        //    BadPropertyToPreventSerialization = this;
        //    Assert.IsTrue(Html.ToJsonOrErrorMessage(this).StartsWith(Html.SerializationErrorIntro));
        //}
    }
}
