using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorSplitter
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "BlazorSplitter.ExampleJsInterop.Prompt",
                message);
        }
    }
}
