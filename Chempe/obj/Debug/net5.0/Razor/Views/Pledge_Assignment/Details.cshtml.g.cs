#pragma checksum "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bba33d6186313cbd784ddcbcc53aca49ad2333e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pledge_Assignment_Details), @"mvc.1.0.view", @"/Views/Pledge_Assignment/Details.cshtml")]
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
#line 1 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\_ViewImports.cshtml"
using Chempe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\_ViewImports.cshtml"
using Chempe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml"
using Services.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bba33d6186313cbd784ddcbcc53aca49ad2333e", @"/Views/Pledge_Assignment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_Pledge_Assignment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTOs.DTO_Pledge_Assignment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml"
  
    ViewData["Title"] = "Detalle de la asignación";
    Layout = "/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Detalle de la asignación</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <td>Solicitud ID:</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml"
       Write(Model.Pledge_Assignment_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Fecha de solicitud:</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml"
       Write(Model.Datetime_assignment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 22 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\Pledge_Assignment\Details.cshtml"
Write(Html.ActionLink("Volver", "Index"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTOs.DTO_Pledge_Assignment> Html { get; private set; }
    }
}
#pragma warning restore 1591
