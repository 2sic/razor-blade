using System;
using System.Collections.Generic;
using System.Text;

namespace ToSic.Razor.Internals
{
    /// <summary>
    /// Special helper class to register startup stuff from the hosting application
    ///
    /// ATM just important because .net standard 2 doesn't have a built in ToJson method
    /// so the environment must provide it at startup.
    /// </summary>
    public class StartUp
    {
        public static void RegisterToJson(Func<object, string> toJsonFunc)
        {
            Html.ObjToJsonString = toJsonFunc;
        }
    }
}
