#pragma checksum "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133e1d3ab216222f1d214e9315a8dce5febe515e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emps_Index), @"mvc.1.0.view", @"/Views/Emps/Index.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\_ViewImports.cshtml"
using Question2_03_04_2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\_ViewImports.cshtml"
using Question2_03_04_2020.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133e1d3ab216222f1d214e9315a8dce5febe515e", @"/Views/Emps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1840e31162b2a4fd1ee0afcaf16cb3c0673439b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Emps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1>Index</h1>\r\n<title>");
#nullable restore
#line 5 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("    <table class=\"table-bordered col-md-3 \" style=\"border-color:black;border-width:thick\">\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Name</td>\r\n            <td>Salary</td>\r\n        </tr>\r\n        \r\n");
#nullable restore
#line 14 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml"
         foreach (var emp in @ViewBag.EmpData)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml"
               Write(emp.EId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml"
               Write(emp.EName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml"
               Write(emp.ESalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\hp\source\repos\Question2-03-04-2020\Question2-03-04-2020\Views\Emps\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
