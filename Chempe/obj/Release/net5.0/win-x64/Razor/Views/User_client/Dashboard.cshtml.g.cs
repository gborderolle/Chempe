#pragma checksum "D:\Documents\GitHub\Chempe\Chempe\Views\User_client\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f687fbf6949a47407034f796f25cf70779c501c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_client_Dashboard), @"mvc.1.0.view", @"/Views/User_client/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f687fbf6949a47407034f796f25cf70779c501c", @"/Views/User_client/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd67a7ead66f9aa8573e0048af7487f36571972", @"/Views/_ViewImports.cshtml")]
    public class Views_User_client_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-avatar-3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-avatar-5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-avatar-1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-avatar-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo-avatar-4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Documents\GitHub\Chempe\Chempe\Views\User_client\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "/Views/Shared/_Layout_client.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Header -->
<div class=""hk-pg-header"">
    <div class=""d-flex"">
        <div class=""d-flex flex-wrap justify-content-between flex-1"">
            <div class=""mb-lg-0 mb-2 me-8"">
                <h1 class=""pg-title"">Bienvenido</h1>
                <p>Aquí puedes visualizar los créditos aprobados y las solicitudes en proceso</p>
            </div>
            <div class=""pg-header-action-wrap"">
                <div class=""input-group w-300p"">
                    <span class=""input-affix-wrapper"">
                        <span class=""input-prefix""><span class=""feather-icon""><i data-feather=""calendar""></i></span></span>
                        <input class=""form-control form-wth-icon"" name=""datetimes"" value=""Aug 18,2020 - Aug 19, 2020"">
                    </span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /Page Header -->
<!-- Page Body -->
<div class=""hk-pg-body"">
    <div class=""tab-content"">
        <div class=""tab-pane fade show active""");
            WriteLiteral(" id=\"tab_block_1\">\r\n\r\n\r\n\r\n\r\n\r\n            <div class=\"row\"");
            BeginWriteAttribute("id", " id=\"", 1180, "\"", 1185, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-md-12 mb-md-4 mb-3\"");
            BeginWriteAttribute("id", " id=\"", 1240, "\"", 1245, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card card-shadow mb-0 h-100\"");
            BeginWriteAttribute("id", " id=\"", 1309, "\"", 1314, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-header card-header-action pointer"" onclick=""accordionOnClick(1)"">
                            <h6>
                                Créditos en proceso de aprobación
                                <span class=""badge badge-sm badge-light ms-1""");
            BeginWriteAttribute("id", " id=\"", 1604, "\"", 1609, 0);
            EndWriteAttribute();
            WriteLiteral(@">240</span>
                            </h6>
                            <div class=""card-action-wrap"">
                                <button class=""btn btn-sm btn-primary ms-3""><span><span class=""icon""><span class=""feather-icon""><i data-feather=""plus""></i></span></span><span class=""btn-text"">Nuevo</span></span></button>
                            </div>
                        </div>
                        <div class=""card-body"" id=""accordion1"">
                            <div class=""contact-list-view"">
                                <table id=""datable_1"" class=""table nowrap w-100 mb-5"">
                                    <thead>
                                        <tr>
                                            <th>
                                                <span class=""form-check fs-6 mb-0"">
                                                    <input type=""checkbox"" class=""form-check-input check-select-all"" id=""customCheck1"">
                                                 ");
            WriteLiteral(@"   <label class=""form-check-label"" for=""customCheck1""></label>
                                                </span>
                                            </th>
                                            <th>Name</th>
                                            <th class=""w-25"">Usage</th>
                                            <th>Last Update</th>
                                            <th>Tags</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                                <div class=""media align-items-center"">
                                                    <div class=""media-head me-2"">
                                  ");
            WriteLiteral("                      <div class=\"avatar avatar-xs avatar-rounded\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f687fbf6949a47407034f796f25cf70779c501c10225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""media-body"">
                                                        <div class=""text-high-em"">Coursera</div>
                                                        <div class=""fs-7""><a href=""#"" class=""table-link-text link-medium-em"">coursera.com</a></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>
                                                <div class=""progress-lb-wrap"">
                                                    <div class=""d-flex align-items-center"">
                                                        <div class=""progress progress-bar-rounded progress-bar-xs flex-1"">
                                                           ");
            WriteLiteral(@" <div class=""progress-bar bg-primary w-50"" role=""progressbar"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                        </div>
                                                        <div class=""fs-8 ms-3"">50%</div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>24 Aug, 2022</td>
                                            <td>
                                                <span class=""badge badge-soft-secondary my-1  me-2"">education</span>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">admin</span>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">+3</span>
                                            </td>
                                            <td>
             ");
            WriteLiteral("                                   <div class=\"d-flex align-items-center\">\r\n                                                    <a class=\"btn btn-icon btn-flush-dark btn-rounded flush-soft-hover\" data-bs-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 6141, "\"", 6149, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Edit"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""edit-2""></i></span></span></a>
                                                    <a class=""btn btn-icon btn-flush-dark btn-rounded flush-soft-hover del-button"" data-bs-toggle=""tooltip"" data-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 6461, "\"", 6469, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Delete"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""trash""></i></span></span></a>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                                <div class=""media align-items-center"">
                                                    <div class=""media-head me-2"">
                                                        <div class=""avatar avatar-xs avatar-rounded"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f687fbf6949a47407034f796f25cf70779c501c15266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""media-body"">
                                                        <div class=""text-high-em"">PCD</div>
                                                        <div class=""fs-7""><a href=""#"" class=""table-link-text link-medium-em"">pcdeals.com</a></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>
                                                <div class=""progress-lb-wrap"">
                                                    <div class=""d-flex align-items-center"">
                                                        <div class=""progress progress-bar-rounded progress-bar-xs flex-1"">
                                                            <div ");
            WriteLiteral(@"class=""progress-bar bg-grey w-30"" role=""progressbar"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                        </div>
                                                        <div class=""fs-8 ms-3"">30%</div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>13 July, 2022</td>
                                            <td>
                                                <span class=""badge badge-soft-secondary my-1  me-2"">Portal</span>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">admin</span>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">+3</span>
                                            </td>
                                            <td>
                        ");
            WriteLiteral("                        <div class=\"d-flex align-items-center\">\r\n                                                    <a class=\"btn btn-icon btn-flush-dark btn-rounded flush-soft-hover\" data-bs-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 9634, "\"", 9642, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Edit"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""edit-2""></i></span></span></a>
                                                    <a class=""btn btn-icon btn-flush-dark btn-rounded flush-soft-hover del-button"" data-bs-toggle=""tooltip"" data-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 9954, "\"", 9962, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Delete"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""trash""></i></span></span></a>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row""");
            BeginWriteAttribute("id", " id=\"", 10509, "\"", 10514, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-md-12 mb-md-4 mb-3\"");
            BeginWriteAttribute("id", " id=\"", 10569, "\"", 10574, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card card-shadow mb-0 h-100\"");
            BeginWriteAttribute("id", " id=\"", 10638, "\"", 10643, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-header card-header-action pointer"" onclick=""accordionOnClick(2)"">
                            <h6>
                                Créditos ya aprobados
                                <span class=""badge badge-sm badge-light ms-1""");
            BeginWriteAttribute("id", " id=\"", 10921, "\"", 10926, 0);
            EndWriteAttribute();
            WriteLiteral(@">240</span>
                            </h6>
                            <div class=""card-action-wrap"">
                                <button class=""btn btn-sm btn-primary ms-3""><span><span class=""icon""><span class=""feather-icon""><i data-feather=""plus""></i></span></span><span class=""btn-text"">Nuevo</span></span></button>
                            </div>
                        </div>
                        <div class=""card-body"" id=""accordion2"">
                            <div class=""contact-list-view"">
                                <table id=""datable_2"" class=""table nowrap w-100 mb-5"">
                                    <thead>
                                        <tr>
                                            <th>
                                                <span class=""form-check fs-6 mb-0"">
                                                    <input type=""checkbox"" class=""form-check-input check-select-all"" id=""customCheck2"">
                                                 ");
            WriteLiteral(@"   <label class=""form-check-label"" for=""customCheck2""></label>
                                                </span>
                                            </th>
                                            <th>Name</th>
                                            <th class=""w-25"">Usage</th>
                                            <th>Last Update</th>
                                            <th>Tags</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                                <div class=""media align-items-center"">
                                                    <div class=""media-head me-2"">
                                  ");
            WriteLiteral("                      <div class=\"avatar avatar-xs avatar-rounded\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f687fbf6949a47407034f796f25cf70779c501c23263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""media-body"">
                                                        <div class=""text-high-em"">Phone Pay</div>
                                                        <div class=""fs-7""><a href=""#"" class=""table-link-text link-medium-em"">phonepay.in</a></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>
                                                <div class=""progress-lb-wrap"">
                                                    <div class=""d-flex align-items-center"">
                                                        <div class=""progress progress-bar-rounded progress-bar-xs flex-1"">
                                                           ");
            WriteLiteral(@" <div class=""progress-bar bg-blue-dark-3 w-90"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                        </div>
                                                        <div class=""fs-8 ms-3"">90%</div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>10 June, 2022</td>
                                            <td>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">admin</span>
                                                <span class=""badge badge-soft-secondary my-1  me-2"">Finance</span>
                                            </td>
                                            <td>
                                                <div class=""d-flex align-items-center"">
                                 ");
            WriteLiteral("                   <a class=\"btn btn-icon btn-flush-dark btn-rounded flush-soft-hover\" data-bs-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 15349, "\"", 15357, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Edit"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""edit-2""></i></span></span></a>
                                                    <a class=""btn btn-icon btn-flush-dark btn-rounded flush-soft-hover del-button"" data-bs-toggle=""tooltip"" data-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 15669, "\"", 15677, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Delete"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""trash""></i></span></span></a>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                                <div class=""media align-items-center"">
                                                    <div class=""media-head me-2"">
                                                        <div class=""avatar avatar-xs avatar-rounded"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f687fbf6949a47407034f796f25cf70779c501c28195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""media-body"">
                                                        <div class=""text-high-em"">Swiggy</div>
                                                        <div class=""fs-7""><a href=""#"" class=""table-link-text link-medium-em"">swiggy.com</a></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>
                                                <div class=""progress-lb-wrap"">
                                                    <div class=""d-flex align-items-center"">
                                                        <div class=""progress progress-bar-rounded progress-bar-xs flex-1"">
                                                            <di");
            WriteLiteral(@"v class=""progress-bar bg-blue w-75"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                        </div>
                                                        <div class=""fs-8 ms-3"">75%</div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>09 July, 2022</td>
                                            <td>
                                                <span class=""badge badge-soft-secondary my-1  me-2"">customer data</span>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">admin</span>
                                                <span class=""badge badge-soft-secondary  my-1  me-2"">+4</span>
                                            </td>
                                            <td>
               ");
            WriteLiteral("                                 <div class=\"d-flex align-items-center\">\r\n                                                    <a class=\"btn btn-icon btn-flush-dark btn-rounded flush-soft-hover\" data-bs-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 18851, "\"", 18859, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Edit"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""edit-2""></i></span></span></a>
                                                    <a class=""btn btn-icon btn-flush-dark btn-rounded flush-soft-hover del-button"" data-bs-toggle=""tooltip"" data-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 19171, "\"", 19179, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Delete"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""trash""></i></span></span></a>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                                <div class=""media align-items-center"">
                                                    <div class=""media-head me-2"">
                                                        <div class=""avatar avatar-xs avatar-rounded"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f687fbf6949a47407034f796f25cf70779c501c33238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""media-body"">
                                                        <div class=""text-high-em"">Tinder</div>
                                                        <div class=""fs-7""><a href=""#"" class=""table-link-text link-medium-em"">tinder.com</a></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>
                                                <div class=""progress-lb-wrap"">
                                                    <div class=""d-flex align-items-center"">
                                                        <div class=""progress progress-bar-rounded progress-bar-xs flex-1"">
                                                            <di");
            WriteLiteral(@"v class=""progress-bar bg-primary-dark-2 w-60"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                                        </div>
                                                        <div class=""fs-8 ms-3"">60%</div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td>17 May, 2022</td>
                                            <td>
                                                <span class=""badge badge-soft-secondary my-1  me-2"">Social</span>
                                            </td>
                                            <td>
                                                <div class=""d-flex align-items-center"">
                                                    <a class=""btn btn-icon btn-flush-dark btn-rounded flush-soft-hover"" data-bs-toggle=""tooltip"" data-p");
            WriteLiteral("lacement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 22128, "\"", 22136, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Edit"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""edit-2""></i></span></span></a>
                                                    <a class=""btn btn-icon btn-flush-dark btn-rounded flush-soft-hover del-button"" data-bs-toggle=""tooltip"" data-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 22448, "\"", 22456, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-original-title=""Delete"" href=""#""><span class=""icon""><span class=""feather-icon""><i data-feather=""trash""></i></span></span></a>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>




        </div>
    </div>
</div>
<!-- /Page Body -->
");
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
