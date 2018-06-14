﻿// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

Blazor.registerFunction('BlazorSplitter.ExampleJsInterop.Prompt', function (message) {
    return prompt(message, 'Type anything here');
});
