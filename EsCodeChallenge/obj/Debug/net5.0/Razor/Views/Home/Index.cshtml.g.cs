#pragma checksum "/Users/jakeellefson/Projects/EsCodeChallenge/EsCodeChallenge/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d667e021d36e170bc45f590be4ebcb9440f39e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/jakeellefson/Projects/EsCodeChallenge/EsCodeChallenge/Views/_ViewImports.cshtml"
using EsCodeChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jakeellefson/Projects/EsCodeChallenge/EsCodeChallenge/Views/_ViewImports.cshtml"
using EsCodeChallenge.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jakeellefson/Projects/EsCodeChallenge/EsCodeChallenge/Views/_ViewImports.cshtml"
using EsCodeChallenge.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d667e021d36e170bc45f590be4ebcb9440f39e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2568dc9d292cea5a83d8633eded54e4971881e8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jakeellefson/Projects/EsCodeChallenge/EsCodeChallenge/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "EsCodeChallenge Rules";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "/Users/jakeellefson/Projects/EsCodeChallenge/EsCodeChallenge/Views/Home/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<pre>
    <code>
# Hi #
Thanks for applying to Emergent Software! We have a small code challenge for you to complete before your interview.
We’ll review it and use it as a source of conversation about coding, so be prepared to talk about why you approached
the problem the way you did and how you could have done it differently. 

Our goal with giving you homework is to allow you to write code in a low stress environment on your own computer. We
realize we’re asking you to do this in your personal time, but we prefer this format over a long session of
whiteboarding code in an interview.

You should not spend more than 4 hours on this challenge. If you reach the 4-hour mark and are not finished, just turn
it in as-is and let us know what you would have done with more time.

# The Challenge #
An imaginary company stores a list of software products they use. They have stored the name and version of each
product. They have asked us to create a simple website where users can type in a version number and recei");
            WriteLiteral(@"ve a list of
software products that are greater than the version they entered.

The software versions are stored as a string in the format [major version].[minor version].[patch]. You may see
versions like “2”, “1.5”, or “2.12.4” (these are all valid inputs from the user as well). The period is only used as a
separator and does not represent a decimal point – 1.5 does not mean one and a half. 

""2"" == ""2.0"" == ""2.0.0""
""2"" < ""2.0.1""
""2"" < ""2.1""
""2.0.1"" < ""2.1.0""

Lucky for you, they stored the software list as a C# object (provided below) that you can simply drop into your code –
no need to call a database or REST service.

This site will be publicly available, so user authentication will not be required.

# Software Product List #

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }

    public static class SoftwareManager
    {
        public static IEnumerable<Software> GetAllSoftware()
        {
            return new List<Software>
   ");
            WriteLiteral(@"         {
                new Software
                {
                    Name = ""MS Word"",
                    Version = ""13.2.1.""
                },
                new Software
                {
                    Name = ""AngularJS"",
                    Version = ""1.7.1""
                },
                new Software
                {
                    Name = ""Angular"",
                    Version = ""8.1.13""
                },
                new Software
                {
                    Name = ""React"",
                    Version = ""0.0.5""
                },
                new Software
                {
                    Name = ""Vue.js"",
                    Version = ""2.6""
                },
                new Software
                {
                    Name = ""Visual Studio"",
                    Version = ""2017.0.1""
                },
                new Software
                {
                    Name = ""Visual Studio"",
                    Version = ""2019.1""
                },
   ");
            WriteLiteral(@"             new Software
                {
                    Name = ""Visual Studio Code"",
                    Version = ""1.35""
                },
                new Software
                {
                    Name = ""Blazor"",
                    Version = ""0.7""
                }
            };
        }
    }
    </code>
</pre>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
