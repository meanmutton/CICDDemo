#pragma checksum "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9216d7f6ce9943cc5e7ac2211a8cc4013899b5aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CICDDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(CICDDemo.Pages.Pages_Index), null)]
namespace CICDDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\_ViewImports.cshtml"
using CICDDemo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9216d7f6ce9943cc5e7ac2211a8cc4013899b5aa", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9003143256895e79ba8d067e6e81a00289738d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 29, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 8 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
      
        ViewData["Title"] = "Courses";
    

#line default
#line hidden
            BeginContext(155, 357, true);
            WriteLiteral(@"    <h2>Courses</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Number
                </th>
                <th>
                    Title
                </th>
                <th>
                    Credits
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 27 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
               int i = 0;

#line default
#line hidden
            BeginContext(540, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 28 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
             foreach (var item in Model.Data.Courses)
            {

#line default
#line hidden
            BeginContext(610, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(683, 7, false);
#line 32 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(690, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(770, 9, false);
#line 35 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(779, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(859, 12, false);
#line 38 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
                   Write(item.Credits);

#line default
#line hidden
            EndContext();
            BeginContext(871, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Code\CICDDemo\CICDDemo\CICDDemo\Pages\Index.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(960, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
