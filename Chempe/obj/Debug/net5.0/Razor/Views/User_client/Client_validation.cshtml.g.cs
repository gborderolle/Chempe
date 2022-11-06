#pragma checksum "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\User_client\Client_validation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff13ceedbab35828edaadc7044c58c8f42a4a01f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_client_Client_validation), @"mvc.1.0.view", @"/Views/User_client/Client_validation.cshtml")]
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
#line 6 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\User_client\Client_validation.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff13ceedbab35828edaadc7044c58c8f42a4a01f", @"/Views/User_client/Client_validation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_User_client_Client_validation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Services.DTOs.DTO_Document>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendors/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pages/client_validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\User_client\Client_validation.cshtml"
  
    ViewData["Title"] = "Nuevo usuario";
    Layout = "/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n        var model = ");
#nullable restore
#line 11 "C:\Users\Gonzalo\Documents\GitHub\Chempe\Chempe\Views\User_client\Client_validation.cshtml"
               Write(Html.Raw(JsonConvert.SerializeObject(Model, Formatting.None,
     new JsonSerializerSettings()
     {
         ReferenceLoopHandling = ReferenceLoopHandling.Ignore
     })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

</script>


<section id=""sec_6"" class=""hk-section"">
    <div class=""hk-sec-title"">
        <h5>Validación de usuario</h5>
        <p>Para comenzar a operar en Chempeño, es necesario validar la identidad de los usuarios.</p>
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
                            <div class=""col"">


           ");
            WriteLiteral(@"                     <div class=""form-group"">
                                    <label class=""form-label"" for=""input_name"">Nombre completo</label>
                                    <div class=""input-group"">
                                        <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        <input type=""text"" class=""form-control"" id=""input_name"" disabled>
                                        &nbsp;
                                        <span class=""form-text text-muted"">Como figura en su Cédula de identidad</span>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""input-group row"">
                                        <div class=""col"">
                                            <label class=""form-label"" for=""input_name"">Cédula de identidad (frente)</label>
                                 ");
            WriteLiteral(@"           <input type=""file"" class=""form-control"" aria-label=""file example"" placeholder=""Foto del frente"" required>
                                            <div class=""invalid-feedback"">Example invalid form file feedback</div>
                                        </div>
                                        <div class=""col"">
                                            <label class=""form-label"" for=""input_name"">Cédula de identidad (dorso)</label>
                                            <input type=""file"" class=""form-control"" aria-label=""file example"" placeholder=""Foto del dorso"" required>
                                            <div class=""invalid-feedback"">Example invalid form file feedback</div>
                                        </div>

                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""form-check"">
                                     ");
            WriteLiteral(@"   <input class=""form-check-input pointer"" id=""input_checkTerms"" type=""checkbox"">
                                        <label class=""form-check-label pointer"" for=""input_checkTerms"">La Cédula de identidad está vigente.</label>
                                    </div>
                                </div>

                                <br />
                                <hr style=""border-bottom: 1px solid rgb(64 62 62)"" />

                                <div class=""form-group"">
                                    <div class=""form-check"">
                                        <input class=""form-check-input pointer"" id=""input_checkTerms"" type=""checkbox"">
                                        <label class=""form-check-label pointer"" for=""input_checkTerms"">He leído y acepto los términos y condiciones de uso.</label>
                                    </div>
                                </div>
                                <input type=""button"" class=""btn btn-primary me-1"" onclic");
            WriteLiteral(@"k=""btn_submit()"" value=""Validar"">
                                <input type=""button"" class=""btn btn-light"" value=""Cancelar"">





                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>





    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <!-- Jasny-bootstrap JS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff13ceedbab35828edaadc7044c58c8f42a4a01f9734", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff13ceedbab35828edaadc7044c58c8f42a4a01f10861", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Services.DTOs.DTO_Document>> Html { get; private set; }
    }
}
#pragma warning restore 1591
