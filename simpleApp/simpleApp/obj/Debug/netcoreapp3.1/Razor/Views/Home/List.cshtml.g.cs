#pragma checksum "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695e50ab44d32f3caa1ea86448981dc935f22173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\_ViewImports.cshtml"
using simpleApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\_ViewImports.cshtml"
using simpleApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695e50ab44d32f3caa1ea86448981dc935f22173", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75529b0e528bcedf4d032d238c6bfd32b5c3f2e2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<simpleApp.Models.CustomerViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 9 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n              <tbody>\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
      foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            <td>\r\n\r\n                        ");
#nullable restore
#line 44 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
                   Write(Html.ActionLink("Details", "Details", new {  id=item.CustomerId  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n          </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n    </table>\r\n");
#nullable restore
#line 51 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"


} else{


#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"text-center\">\r\n\r\n      <h1 class=\"text-danger\">Ooops!!!! The records are not available</h1>\r\n  </div>\r\n");
#nullable restore
#line 59 "C:\Users\vuyiswa.mkhwanazi\source\repos\simpleApp\simpleApp\Views\Home\List.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<simpleApp.Models.CustomerViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591