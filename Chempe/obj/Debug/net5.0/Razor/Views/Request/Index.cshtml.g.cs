#pragma checksum "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93733dc95a1d272e4aea4315be76a343e3e6a5c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Index), @"mvc.1.0.view", @"/Views/Request/Index.cshtml")]
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
#line 1 "D:\Documents\GitHub\Chempe\Chempe\Views\_ViewImports.cshtml"
using Chempe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\Chempe\Chempe\Views\_ViewImports.cshtml"
using Chempe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
using Services.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93733dc95a1d272e4aea4315be76a343e3e6a5c1", @"/Views/Request/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.DTOs.DTO_Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
  
    ViewData["Title"] = "Listado de solicitudes";
    Layout = "/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Listado de solicitudes</h2>\r\n\r\n<p>");
#nullable restore
#line 12 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
Write(Html.ActionLink("Crear nuevo", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Request_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Datetime_request));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.User_request));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Pledge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 32 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.ActionLink(item.Request_ID.ToString(), "Details", new { id = item.Request_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Datetime_request));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User_request));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pledge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Request_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                ");
#nullable restore
#line 51 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Request_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n                ");
#nullable restore
#line 52 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Request_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.DTOs.DTO_Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
