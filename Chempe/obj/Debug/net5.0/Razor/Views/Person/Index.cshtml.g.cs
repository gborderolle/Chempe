#pragma checksum "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461355b5e2ce61fa76f26478464110601a619ff1"
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
#line 6 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
using Services.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"461355b5e2ce61fa76f26478464110601a619ff1", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.DTOs.DTO_Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Listado de personas";
    Layout = "/Views/Shared/_Layout_chempe.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Listado de personas</h2>\r\n\r\n<p>");
#nullable restore
#line 12 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
Write(Html.ActionLink("Crear nuevo", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Person_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Full_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_born));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 38 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 41 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.User_client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 44 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.User_investor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 47 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.User_chempe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>Acciones</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 52 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.ActionLink(item.Person_ID.ToString(), "Details", new { id = item.Person_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Full_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date_born));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User_client));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User_investor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User_chempe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n\r\n            <td>\r\n");
#nullable restore
#line 94 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
                 using (Html.BeginForm("Edit", "Person", new { id = item.Person_ID }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" class=\"btn btn-sm btn-outline-dark me-1\" value=\"Modificar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3199, "\"", 3277, 9);
            WriteAttributeValue("", 3209, "return", 3209, 6, true);
            WriteAttributeValue(" ", 3215, "confirm(\'Está", 3216, 14, true);
            WriteAttributeValue(" ", 3229, "seguro", 3230, 7, true);
            WriteAttributeValue(" ", 3236, "que", 3237, 4, true);
            WriteAttributeValue(" ", 3240, "desea", 3241, 6, true);
            WriteAttributeValue(" ", 3246, "modificar", 3247, 10, true);
            WriteAttributeValue(" ", 3256, "a", 3257, 2, true);
#nullable restore
#line 96 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
WriteAttributeValue(" ", 3258, item.Full_name, 3259, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3274, "?\')", 3274, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 97 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 98 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Details", new { id = item.Person_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n");
#nullable restore
#line 99 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
                 using (Html.BeginForm("Delete", "Person", new { id = item.Person_ID }))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" class=\"btn btn-sm btn-outline-dark me-1\" value=\"Borrar\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3592, "\"", 3667, 9);
            WriteAttributeValue("", 3602, "return", 3602, 6, true);
            WriteAttributeValue(" ", 3608, "confirm(\'Está", 3609, 14, true);
            WriteAttributeValue(" ", 3622, "seguro", 3623, 7, true);
            WriteAttributeValue(" ", 3629, "que", 3630, 4, true);
            WriteAttributeValue(" ", 3633, "desea", 3634, 6, true);
            WriteAttributeValue(" ", 3639, "borrar", 3640, 7, true);
            WriteAttributeValue(" ", 3646, "a", 3647, 2, true);
#nullable restore
#line 101 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
WriteAttributeValue(" ", 3648, item.Full_name, 3649, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3664, "?\')", 3664, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 102 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 106 "D:\Documents\GitHub\Chempe\Chempe\Views\Person\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.DTOs.DTO_Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591