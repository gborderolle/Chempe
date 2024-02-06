#pragma checksum "D:\GitHub\Chempe\Chempe\Views\Person\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f5ccab9ef0b2398aaf5d3058c72d8c4c8de994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Create), @"mvc.1.0.view", @"/Views/Person/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f5ccab9ef0b2398aaf5d3058c72d8c4c8de994", @"/Views/Person/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Person_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTOs.DTO_Person>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pages/person/create.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/auxiliar_functions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GitHub\Chempe\Chempe\Views\Person\Create.cshtml"
  
    ViewData["Title"] = "Crear una persona";
    Layout = "/Views/Shared/_Layout_chempe.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\GitHub\Chempe\Chempe\Views\Person\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\Chempe\Chempe\Views\Person\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <fieldset>


        <section id=""sec_6"" class=""hk-section"">
            <div class=""hk-sec-title"">
                <h5>Registro de usuario</h5>
                <p>Ingrese sus datos básicos, por favor. Más adelante se le pedirá validar su identidad para mantener la seguridad del servicio.</p>
            </div>
            <div class=""hk-example card card-shadow card-wth-tabs"">
                <div class=""card-header"">
                    <ul class=""nav nav-line nav-tabs nav-sm nav-light card-header-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-bs-toggle=""tab"" href=""#prev_tab_5"">
                                <span class=""nav-link-text"">Información</span>
                            </a>
                        </li>
                    </ul>
                </div>




                <div class=""card-body p-0"">
                    <div class=""tab-content m-0"">
                        <div class=""tab-pane fade sho");
            WriteLiteral("w active\" id=\"prev_tab_5\">\r\n                            <div class=\"container py-3\">\r\n                                <div class=\"row\">\r\n                                    <div class=\"col\">\r\n\r\n\r\n");
            WriteLiteral(@"                                        <div class=""form-group"">
                                            <label class=""form-label"" for=""input_name"">Nombre completo</label>
                                            <div class=""input-group"">
                                                <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                                <input type=""text"" class=""form-control"" id=""input_name"" placeholder=""Nombre completo"" name=""full_name"">
                                                &nbsp;
                                                <span class=""form-text text-muted"">Como figura en su Cédula de identidad</span>
                                            </div>
                                        </div>

");
            WriteLiteral(@"                                        <div class=""form-group row"">
                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_email"">Cédula de identidad</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa fa-id-card""></i></span>
                                                    <input type=""text"" class=""form-control"" id=""input_email""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2921, "\"", 2935, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-mask=""9.999.999-9"" name=""identification"">
                                                    &nbsp;
                                                    <span class=""form-text text-muted"">Ejemplo ""1.234.567-8""</span>

                                                </div>
                                            </div>

                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Fecha de nacimiento</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa fa-calendar""></i></span>
                                                    <input type=""text"" class=""form-control datepicker"" id=""input_borndate"" placeholder=""Fecha de nacimiento"" name=""date_born"">
                                                </div>
                                            </div>
         ");
            WriteLiteral("                               </div>\r\n\r\n");
            WriteLiteral(@"                                        <div class=""form-group row"">
                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_email"">Correo electrónico</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa fa-inbox""></i></span>
                                                    <input type=""email"" class=""form-control"" id=""input_email"" placeholder=""Correo electrónico"" name=""email"">
                                                </div>
                                            </div>

                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Teléfono móvil</label>
                                                <div class=""input-group"">
                               ");
            WriteLiteral("                     <span class=\"input-group-text\"><i class=\"fa fa-phone\"></i></span>\r\n                                                    <input type=\"text\" class=\"form-control\" id=\"input_phone\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 5282, "\"", 5296, 0);
            EndWriteAttribute();
            WriteLiteral(" data-mask=\"099 999 999\" name=\"phone\">\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n\r\n");
            WriteLiteral(@"                                        <div class=""form-group row"">
                                            <div class=""form-group col"">
                                                <label class=""form-label"" for=""input_password1"">Contraseña</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa fa-lock""></i></span>
                                                    <input type=""password"" class=""form-control"" id=""input_password1"" placeholder=""Contraseña"" name=""password"">
                                                </div>
                                            </div>
                                            <div class=""form-group col"">
                                                <label class=""form-label"" for=""input_password2"">Confirmar contraseña</label>
                                                <div class=""input-group"">
                            ");
            WriteLiteral(@"                        <span class=""input-group-text""><i class=""fa fa-lock""></i></span>
                                                    <input type=""password"" class=""form-control"" id=""input_password2"" placeholder=""Confirmar contraseña"">
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <div class=""form-check"">
                                                <input class=""form-check-input pointer"" id=""input_checkTerms"" type=""checkbox"">
                                                <label class=""form-check-label pointer"" for=""input_checkTerms"">He leído y acepto los términos y condiciones de uso.</label>
                                            </div>
                                        </div>

");
            WriteLiteral("                                        <input type=\"submit\" class=\"btn btn-primary me-1\" onclick=\"btn_submit()\" value=\"Registrarme\">\r\n                                        ");
#nullable restore
#line 119 "D:\GitHub\Chempe\Chempe\Views\Person\Create.cshtml"
                                   Write(Html.ActionLink("Volver", "Index", new { role = "button" }, new { @class = "btn btn-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



            </div>
        </section>

    </fieldset>
");
#nullable restore
#line 135 "D:\GitHub\Chempe\Chempe\Views\Person\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- Jasny-bootstrap JS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5ccab9ef0b2398aaf5d3058c72d8c4c8de99413735", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Page JS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5ccab9ef0b2398aaf5d3058c72d8c4c8de99414863", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f5ccab9ef0b2398aaf5d3058c72d8c4c8de99415963", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTOs.DTO_Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
