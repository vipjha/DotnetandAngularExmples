#pragma checksum "E:\ProjectsWorks\Practices\DotnetandAngularExmples\Dotnet5ExamplesOnGit\vroom\Views\Make\Bikes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20f2d42017e707ae81d30b80cc50d792ef73840b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Make_Bikes), @"mvc.1.0.view", @"/Views/Make/Bikes.cshtml")]
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
#line 1 "E:\ProjectsWorks\Practices\DotnetandAngularExmples\Dotnet5ExamplesOnGit\vroom\Views\_ViewImports.cshtml"
using vroom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ProjectsWorks\Practices\DotnetandAngularExmples\Dotnet5ExamplesOnGit\vroom\Views\_ViewImports.cshtml"
using vroom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f2d42017e707ae81d30b80cc50d792ef73840b", @"/Views/Make/Bikes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ed6b5db9ad501af2cfbc4ddb284bb7ad745248", @"/Views/_ViewImports.cshtml")]
    public class Views_Make_Bikes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vroom.Models.Make>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ProjectsWorks\Practices\DotnetandAngularExmples\Dotnet5ExamplesOnGit\vroom\Views\Make\Bikes.cshtml"
  
    ViewData["Title"] = "Bikes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "E:\ProjectsWorks\Practices\DotnetandAngularExmples\Dotnet5ExamplesOnGit\vroom\Views\Make\Bikes.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vroom.Models.Make> Html { get; private set; }
    }
}
#pragma warning restore 1591