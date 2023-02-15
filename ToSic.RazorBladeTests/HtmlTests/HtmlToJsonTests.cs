using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Internals;

namespace ToSic.RazorBladeTests.HtmlTests
{
    [TestClass]
    public class HtmlToJsonTests
    {
        public Func<object, string> ToJson = Html.ToJson;

        [TestMethod]
        public void Basic()
        {
            Assert.AreEqual("null", ToJson(null));
            Assert.AreEqual("45", ToJson(45));
            Assert.AreEqual("{\"Name\":\"Daniel\"}", ToJson(new { Name = "Daniel"}));
        }

        [TestMethod]
        public void DateTimeSerialization()
        {
            Assert.AreEqual("\"2023-02-15T18:26:15Z\"", ToJson(new DateTime(2023,2,15, 18, 26, 15)));
            Assert.AreEqual("{\"datePosted\":\"2023-02-15T00:00:00Z\"}", ToJson(new { datePosted = new DateTime(2023, 2, 15) }));
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
