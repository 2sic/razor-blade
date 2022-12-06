using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToSic.Razor.Blade;
using ToSic.Razor.Html5;
using ToSic.Razor.Markup;
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;


namespace ToSic.RazorBladeTests.TagTests
{
    public class TagTestBase
    {

        public void Is(string expected, TagBase result, string message = null)
        {
            Is(expected, result.ToString(), message);
            //Assert.AreEqual(expected, result.ToString(), message);
        }

        public void Is(string expected, IHtmlString result, string message = null)
        {
            //var resultStr = result.ToString();
            //int index = expected.Zip(resultStr, (c1, c2) => c1 == c2).TakeWhile(b => b).Count() + 1;

            //Assert.AreEqual(expected, resultStr, message + $"(pos: {index}");
            Is(expected, result.ToString(), message);
        }

        private void Is(string expected, string result, string message = null)
        {
            var resultStr = result;
            var index = expected.Zip(resultStr, (c1, c2) => c1 == c2).TakeWhile(b => b).Count() + 1;

            // if we found a deviation, include that in the message
            if (index <= resultStr.Length)
            {
                var startErrorText = index - 25;
                if (startErrorText < 0) startErrorText = 0;
                var before = expected.Substring(startErrorText, index - startErrorText);

                message = message + $"(pos: {index}, before: '{before}')";
            }

            Assert.AreEqual(expected, resultStr, message);

        }

        /// <summary>
        /// Helper to reduce access to Tag.Div, so the use count is more realistic
        /// </summary>
        /// <returns></returns>
        internal Div TestDiv() => Tag.Div();

        internal TagCustom Custom(string name) => new(name);
        internal TagCustom Custom(string name, TagOptions options) => new(name, options);
    }
}
