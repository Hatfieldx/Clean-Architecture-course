#pragma checksum "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f50822e1a6bd0be00add1bae08bc01c84ee20c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\_ViewImports.cshtml"
using CleanArch.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\_ViewImports.cshtml"
using CleanArch.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f50822e1a6bd0be00add1bae08bc01c84ee20c51", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c84940eabab308cdd477509d0422d4ea855b75", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CleanArch.Application.ViewModels.CourseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row course-content\">\r\n\r\n");
#nullable restore
#line 6 "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\Course\Index.cshtml"
         foreach (var item in Model.Courses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"course-image-container\">\r\n                <div class=\"course-image\"");
            BeginWriteAttribute("style", " style=\"", 285, "\"", 329, 3);
            WriteAttributeValue("", 293, "background-image:url(", 293, 21, true);
#nullable restore
#line 9 "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\Course\Index.cshtml"
WriteAttributeValue("", 314, item.ImageUrl, 314, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 328, ")", 328, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                </div>\r\n                <span>");
#nullable restore
#line 12 "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\Course\Index.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
#nullable restore
#line 14 "D:\repo\Clean-Architecture-course\CleanArch\CleanArch.MVC\Views\Course\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CleanArch.Application.ViewModels.CourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
