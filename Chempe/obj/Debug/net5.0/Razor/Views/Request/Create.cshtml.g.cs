#pragma checksum "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e672b9d5bc201248892b75ef76f2864729cd7ea6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Create), @"mvc.1.0.view", @"/Views/Request/Create.cshtml")]
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
#line 6 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
using Services.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e672b9d5bc201248892b75ef76f2864729cd7ea6", @"/Views/Request/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTOs.DTO_Request_create>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pages/request/create.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
  
    ViewData["Title"] = "Nueva solicitud de crédito";
    Layout = "/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<style>\r\n    .alert.alert-info {\r\n        color: #11a5b2;\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 16 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <fieldset>


        <section id=""sec_6"" class=""hk-section"">
            <div class=""hk-sec-title"">
                <h5>Inicio de nueva solicitud de crédito</h5>
                <p>Ingrese sus datos básicos, por favor. Más adelante se le pedirá validar su identidad para mantener la seguridad del servicio.</p>
            </div>


            <div class=""col-12"">
                <div class=""alert alert-info card card-border card-int mb-4"" role=""alert"">
                    <h4 class=""alert-heading mb-2"">Metodología</h4>
                    <p>Asegurarse de tener la documentación requerida para dar garantía al crédito, la plataforma y el sustento de la operativa.</p>
                    <div class=""card-footer justify-content-between border-0"" style=""padding: 0;"">
                        <span class=""d-flex align-items-center fs-8""><i class=""ri-information-fill fs-7 me-2""></i>Importante</span>
                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">Entendido</a>
        ");
            WriteLiteral("            </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"hk-example card card-shadow card-wth-tabs\">\r\n\r\n");
            WriteLiteral(@"                <div class=""card-header"">
                    <ul class=""nav nav-line nav-tabs nav-sm nav-light card-header-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-bs-toggle=""tab"" href=""#prev_tab_5"">
                                <span class=""nav-link-text"">Información general</span>
                            </a>
                        </li>
                    </ul>
                </div>


                <div class=""card-body p-0"">
                    <div class=""tab-content m-0"">
                        <div class=""tab-pane fade show active"" id=""prev_tab_5"">
                            <div class=""container py-3"">
                                <div class=""row"">
                                    <div class=""col"">

");
            WriteLiteral("\r\n                                        <div class=\"form-group row\">\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Clasificación</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa-solid ri-folder-add-fill""></i></span>

                                                    ");
#nullable restore
#line 73 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
                                               Write(Html.DropDownList("List_DTO_List_warrants_type", "-- Seleccione la clasificación --"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Comprobante de compra</label>
                                                <div class=""input-group"">
                                                    <input type=""file"" accept=""images/*"" class=""form-control"" aria-label=""file example"" placeholder=""Foto del frente"" id=""file_document1"" name=""full_name"">
                                                    <div class=""invalid-feedback"">Example invalid form file feedback</div>
                                                </div>
                                            </div>

                                        </div>

");
            WriteLiteral("\r\n                                        <div class=\"form-group row\">\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_borndate"">Fecha de compra</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa fa-calendar""></i></span>
                                                    <input type=""text"" class=""form-control datepicker"" id=""input_borndate"" placeholder=""Fecha de compra"" name=""Datetime_purchase"">
                                                </div>
                                            </div>

");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Precio de compra</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa fa-money-bill""></i></span>
                                                    <input type=""number"" class=""form-control"" id=""input_price""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 7487, "\"", 7501, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""Purchase_import"">
                                                </div>
                                            </div>

                                        </div>


                                        <div class=""alert alert-warning card card-border card-int mb-4"" role=""alert"">
                                            <div class=""card-footer justify-content-between border-0"" style=""padding: 0;"">
                                                <span class=""d-flex align-items-center fs-8""><i class=""ri-information-fill fs-7 me-2""></i>Como figura en la boleta de compra.</span>
                                            </div>
                                        </div>



                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

");
            WriteLiteral(@"                <div class=""card-header panel_tv"" style=""display:none"">
                    <ul class=""nav nav-line nav-tabs nav-sm nav-light card-header-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-bs-toggle=""tab"" href=""#prev_tab_5"">
                                <span class=""nav-link-text"">Información específica</span>
                            </a>
                        </li>
                    </ul>
                </div>

                <div class=""card-body p-0 panel_tv"" style=""display:none"">
                    <div class=""tab-content m-0"">
                        <div class=""tab-pane fade show active"" id=""prev_tab_5"">
                            <div class=""container py-3"">
                                <div class=""row"">
                                    <div class=""col"">


");
            WriteLiteral("                                        <div class=\"form-group row\">\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Marca</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa-solid ri-folder-add-fill""></i></span>

                                                    ");
#nullable restore
#line 180 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
                                               Write(Html.DropDownList("List_DTO_List_TV_brands", "-- Seleccione la marca --"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Modelo</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa-solid ri-folder-add-fill""></i></span>

                                                    ");
#nullable restore
#line 215 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
                                               Write(Html.DropDownList("List_DTO_List_TV_brand_models", "-- Seleccione el modelo --"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n\r\n\r\n\r\n\r\n\r\n                                        </div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("                                        <div class=\"form-group row\" style=\"margin-bottom:0;\">\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <label class=""form-label"" for=""input_phone"">Tecnología</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-text""><i class=""fa-solid ri-folder-add-fill""></i></span>

                                                    ");
#nullable restore
#line 261 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
                                               Write(Html.DropDownList("List_DTO_List_TV_technologies", "-- Seleccione la tecnología --"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"                                            <div class=""input-group col"">
                                                <div class=""form-check"">
                                                    <input class=""form-check-input pointer"" id=""input_checkIsSmart"" type=""checkbox"" name=""IsSmart"">
                                                    <label class=""form-check-label pointer"" for=""input_checkIsSmart"">¿Es smart TV?</label>
                                                </div>
                                            </div>






                                        </div>


                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>










                <div class=""card-header"">
                    <ul class=""nav nav-line nav-tabs nav-sm nav-light card-header-tabs"">
                        <li class=""nav-item"">
          ");
            WriteLiteral(@"                  <a class=""nav-link active"" data-bs-toggle=""tab"" href=""#prev_tab_5"">
                                <span class=""nav-link-text"">Estado del bien</span>
                            </a>
                        </li>
                    </ul>
                </div>

                <div class=""card-body p-0"">
                    <div class=""tab-content m-0"">
                        <div class=""tab-pane fade show active"" id=""prev_tab_5"">
                            <div class=""container py-3"">
                                <div class=""row"">
                                    <div class=""col"">


                                        <div class=""input-group"">
                                            <label class=""form-label"" for=""input_phone"">Fotos del bien</label>
                                            <div class=""input-group"">
                                                <input type=""file"" accept=""images/*"" class=""form-control"" aria-label=""file example"" placehol");
            WriteLiteral(@"der=""Foto del bien"" id=""file_document1"">
                                                <div class=""invalid-feedback"">Example invalid form file feedback</div>
                                            </div>
                                        </div>

                                        <div class=""form-group"">
                                            <label class=""form-label"" for=""input_name"">Comentarios</label>
                                            <div class=""input-group"">
                                                <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                                <textarea class=""form-control"" id=""input_name"" placeholder=""Comentarios que quiera incluir"" name=""Comments""></textarea>
                                            </div>
                                        </div>


                                        <div class=""form-group row-short"" style=""display: flex;"">
                             ");
            WriteLiteral(@"               <div class=""form-check col"">
                                                <input class=""form-check-input pointer"" id=""input_checkTerms"" type=""checkbox"">
                                                <label class=""form-check-label pointer"" for=""input_checkTerms"">El bien declarado funciona 100%</label>
                                            </div>
                                            <div class=""form-check col"">
                                                <input class=""form-check-input pointer"" id=""input_checkTerms"" type=""checkbox"">
                                                <label class=""form-check-label pointer"" for=""input_checkTerms"">Los valores declarados corresponden a la realidad del bien.</label>
                                            </div>
                                        </div>


                                        <hr style=""border-bottom: 1px solid rgb(64 62 62)"" />

                                        <div class=""form-group"">");
            WriteLiteral(@"
                                            <div class=""form-check"">
                                                <input class=""form-check-input pointer"" id=""input_checkTerms"" type=""checkbox"">
                                                <label class=""form-check-label pointer"" for=""input_checkTerms"">He leído y acepto los términos y condiciones de uso.</label>
                                            </div>
                                        </div>
");
            WriteLiteral("\r\n\r\n                                        ");
#nullable restore
#line 386 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
                                   Write(Html.HiddenFor(m => m.DTO_Person.Person_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("                                        <input type=\"submit\" class=\"btn btn-primary me-1\" onclick=\"btn_submit()\" value=\"Iniciar solicitud\">\r\n                                        ");
#nullable restore
#line 391 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
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
#line 407 "D:\Documents\GitHub\Chempe\Chempe\Views\Request\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- Jasny-bootstrap JS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e672b9d5bc201248892b75ef76f2864729cd7ea622366", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e672b9d5bc201248892b75ef76f2864729cd7ea623494", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e672b9d5bc201248892b75ef76f2864729cd7ea624594", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTOs.DTO_Request_create> Html { get; private set; }
    }
}
#pragma warning restore 1591
