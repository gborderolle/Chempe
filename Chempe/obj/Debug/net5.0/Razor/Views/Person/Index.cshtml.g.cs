#pragma checksum "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d79f31e93d9b6be0d828436c3fc5f13f8ece298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "D:\GitHub\Chempe\Chempe\Views\_ViewImports.cshtml"
using Chempe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Chempe\Chempe\Views\_ViewImports.cshtml"
using Chempe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
using Services.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d79f31e93d9b6be0d828436c3fc5f13f8ece298", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.DTOs.DTO_Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Listado de personas";
    Layout = "/Views/Shared/_Layout_chempe.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Listado de personas</h2>\r\n\r\n<p>");
#nullable restore
#line 12 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
Write(Html.ActionLink("Crear nuevo", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Person_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Full_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_born));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 38 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 41 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Person_client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 44 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Person_investor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 47 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Person_chempe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>Acciones</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 52 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.ActionLink(item.Person_ID.ToString(), "Details", new { id = item.Person_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Full_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date_born));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Person_client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Person_investor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Person_chempe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n\r\n            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 98 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.ActionLink("Modificar", "Edit", new { id = item.Person_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 99 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Details", new { id = item.Person_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
                 using (Html.BeginForm("Delete", "Person", new { id = item.Person_ID }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" class=\"btn btn-sm btn-outline-dark me-1\" value=\"Borrar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3667, "\"", 3742, 9);
            WriteAttributeValue("", 3677, "return", 3677, 6, true);
            WriteAttributeValue(" ", 3683, "confirm(\'Está", 3684, 14, true);
            WriteAttributeValue(" ", 3697, "seguro", 3698, 7, true);
            WriteAttributeValue(" ", 3704, "que", 3705, 4, true);
            WriteAttributeValue(" ", 3708, "desea", 3709, 6, true);
            WriteAttributeValue(" ", 3714, "borrar", 3715, 7, true);
            WriteAttributeValue(" ", 3721, "a", 3722, 2, true);
#nullable restore
#line 102 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
WriteAttributeValue(" ", 3723, item.Full_name, 3724, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3739, "?\')", 3739, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 103 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 107 "D:\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.DTOs.DTO_Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
