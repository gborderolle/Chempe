#pragma checksum "D:\Documents\GitHub\Chempe\Chempe\Views\User_client\New_client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82767256fbe4c4b2acb72b3398f4907dcfbd959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_client_New_client), @"mvc.1.0.view", @"/Views/User_client/New_client.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82767256fbe4c4b2acb72b3398f4907dcfbd959", @"/Views/User_client/New_client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_User_client_New_client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\GitHub\Chempe\Chempe\Views\User_client\New_client.cshtml"
  
    ViewData["Title"] = "Nuevo usuario";
    Layout = "/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""sec_6"" class=""hk-section"">
    <div class=""hk-sec-title"">
        <h5>Registro de usuario nuevo</h5>
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
                <div class=""tab-pane fade show active"" id=""prev_tab_5"">
                    <div class=""container py-3"">
                        <div class=""row"">
                            <div cl");
            WriteLiteral("ass=\"col\">\r\n\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82767256fbe4c4b2acb72b3398f4907dcfbd9595146", async() => {
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label class=""form-label"" for=""exampleInputuname_1"">Nombre completo</label>
                                        <div class=""input-group"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                            <input type=""text"" class=""form-control"" id=""exampleInputuname_1"" placeholder=""Nombre completo"">
                                            &nbsp;
                                            <span class=""form-text text-muted"">Como figura en su Cédula de identidad</span>
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <div class=""input-group col"">
                                            <label class=""form-label"" for=""exampleInputuname_1"">Teléfono móvil</label>");
                WriteLiteral(@"
                                            <div class=""input-group"">
                                                <span class=""input-group-text""><i class=""fa fa-phone""></i></span>
                                                <input type=""text"" class=""form-control"" id=""exampleInputuname_1""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2503, "\"", 2517, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-mask=""099 999 999"">
                                            </div>
                                        </div>
                                        <div class=""input-group col"">
                                            <label class=""form-label"" for=""exampleInputuname_1"">Fecha de nacimiento</label>
                                            <div class=""input-group"">
                                                <span class=""input-group-text""><i class=""fa fa-calendar""></i></span>
                                                <input type=""text"" class=""form-control"" id=""datepicker"" placeholder=""Fecha de nacimiento"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""form-label"" for=""exampleInputEmail_1"">Correo electrónico</label>
                                        <div c");
                WriteLiteral(@"lass=""input-group"">
                                            <span class=""input-group-text""><i class=""fa fa-inbox""></i></span>
                                            <input type=""email"" class=""form-control"" id=""exampleInputEmail_1"" placeholder=""Correo electrónico"">
                                        </div>
                                    </div>
                                    <div class=""form-group"">
                                        <label class=""form-label"" for=""exampleInputpwd_1"">Contraseña</label>
                                        <div class=""input-group"">
                                            <span class=""input-group-text""><i class=""fa fa-lock""></i></span>
                                            <input type=""password"" class=""form-control"" id=""exampleInputpwd_1"" placeholder=""Contraseña"">
                                        </div>
                                    </div>
                                    <div class=""form-group"">
              ");
                WriteLiteral(@"                          <label class=""form-label"" for=""exampleInputpwd_2"">Confirmar contraseña</label>
                                        <div class=""input-group"">
                                            <span class=""input-group-text""><i class=""fa fa-lock""></i></span>
                                            <input type=""password"" class=""form-control"" id=""exampleInputpwd_2"" placeholder=""Confirmar contraseña"">
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <div class=""input-group col"">
                                            <label class=""form-label"">Género</label>
                                            <div style=""padding: 5px;"">
                                                <div class=""form-check mb-1"">
                                                    <input id=""radio_1"" name=""radio1"" class=""form-check-input""");
                BeginWriteAttribute("checked", " checked=\"", 5574, "\"", 5584, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"">
                                                    <label class=""form-check-label"" for=""radio_1"">Masculino</label>
                                                </div>
                                                <div class=""form-check"">
                                                    <input id=""radio_2"" name=""radio1"" class=""form-check-input""");
                BeginWriteAttribute("checked", " checked=\"", 5958, "\"", 5968, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"">
                                                    <label class=""form-check-label"" for=""radio_1"">Femenino</label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""input-group col"">
                                            <label class=""form-label"" for=""exampleInputuname_1"">Cédula de identidad</label>
                                            <div class=""input-group"">
                                                <span class=""input-group-text""><i class=""fa fa-id-card""></i></span>
                                                <input type=""text"" class=""form-control"" id=""exampleInputuname_1""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6753, "\"", 6767, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-mask=""9.999.999-9"">
                                                &nbsp;
                                                <span class=""form-text text-muted"">Ejemplo ""1.234.567-8""</span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""form-group"">
                                        <div class=""form-check"">
                                            <input class=""form-check-input"" id=""checkbox_1"" type=""checkbox"">
                                            <label class=""form-check-label"" for=""checkbox_1"">He leído y acepto los términos y condiciones de uso.</label>
                                        </div>
                                    </div>
                                    <button type=""submit"" class=""btn btn-primary me-1"">Registrarme</button>
");
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- Jasny-bootstrap  JavaScript -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82767256fbe4c4b2acb72b3398f4907dcfbd95914233", async() => {
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
                WriteLiteral("\r\n\r\n    <script>\r\n        $(function () {\r\n            $(\"#datepicker\").datepicker();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
