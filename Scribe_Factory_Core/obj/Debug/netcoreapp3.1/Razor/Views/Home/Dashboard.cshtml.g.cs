#pragma checksum "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8698610bcfce468a83601225f72ec168265be03e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\_ViewImports.cshtml"
using Scribe_Factory_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\_ViewImports.cshtml"
using Scribe_Factory_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8698610bcfce468a83601225f72ec168265be03e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aeda2b8c910eadfd65a20b3f1fab49fa5454ca3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Scribe_Factory_Core.Models.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"" id=""my-prject"">
    <div class=""row mt-5"">
        <div class=""col-md-10"">
            <div class=""row mb-4 pb-5 "">
                <div class=""col-md-12"">
                    <div class=""prject-date-div pb-4"">
                        <p>June 14 , 2022</p>
                    </div>
                </div>
");
#nullable restore
#line 17 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Home\Dashboard.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                        <div class=""projects-main-div"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""img-div""></div>
                                </div>
                                <div class=""col-10 my-auto prjctFlex"">
                                    <div class=""prjct-name"">
                                        <div>
                                            <p>
                                                ");
#nullable restore
#line 29 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Home\Dashboard.cshtml"
                                           Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                <!-- <span>
                                                    <svg xmlns=""http://www.w3.org/2000/svg""
                                                        width=""5"" height=""17""
                                                        viewBox=""0 0 5 17"" fill=""none"">
                                                        <path fill-rule=""evenodd""
                                                            clip-rule=""evenodd""
                                                            d=""M2.50977 4.72241C3.60977 4.72241 4.50977 3.82241 4.50977 2.72241C4.50977 1.62241 3.60977 0.722412 2.50977 0.722412C1.40977 0.722412 0.509766 1.62241 0.509766 2.72241C0.509766 3.82241 1.40977 4.72241 2.50977 4.72241ZM2.50977 6.72241C1.40977 6.72241 0.509766 7.62241 0.509766 8.72241C0.509766 9.82241 1.40977 10.7224 2.50977 10.7224C3.60977 10.7224 4.50977 9.82241 4.50977 8.72241C4.50977 7.62241 3.60977 6.72241 2.50977 6.72241ZM2.50977 12.7224C1.40977 12.7224 0.509766 13.6");
            WriteLiteral(@"224 0.509766 14.7224C0.509766 15.8224 1.40977 16.7224 2.50977 16.7224C3.60977 16.7224 4.50977 15.8224 4.50977 14.7224C4.50977 13.6224 3.60977 12.7224 2.50977 12.7224Z""
                                                            fill=""#9A9AB0"" />
                                                    </svg>

                                                </span> -->
                                            </p>
                                            <p>");
#nullable restore
#line 42 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Home\Dashboard.cshtml"
                                          Write(item.ProjectType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>

                                    </div>
                                    <div class=""nav-item dropdown language-dropdown more-dropdown"">
                                        <div class=""dropdown custom-dropdown-icon"">
                                            <a class=""dropdown-toggle btn"" href=""#"" role=""button"" id=""customDropdown"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""5"" height=""17"" viewBox=""0 0 5 17"" fill=""none"">
                                                    <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M2.50977 4.72241C3.60977 4.72241 4.50977 3.82241 4.50977 2.72241C4.50977 1.62241 3.60977 0.722412 2.50977 0.722412C1.40977 0.722412 0.509766 1.62241 0.509766 2.72241C0.509766 3.82241 1.40977 4.72241 2.50977 4.72241ZM2.50977 6.72241C1.40977 6.72241 0.509766 7.62241 0.509766 8.72241C0.509766 9.82241 1.40977 1");
            WriteLiteral(@"0.7224 2.50977 10.7224C3.60977 10.7224 4.50977 9.82241 4.50977 8.72241C4.50977 7.62241 3.60977 6.72241 2.50977 6.72241ZM2.50977 12.7224C1.40977 12.7224 0.509766 13.6224 0.509766 14.7224C0.509766 15.8224 1.40977 16.7224 2.50977 16.7224C3.60977 16.7224 4.50977 15.8224 4.50977 14.7224C4.50977 13.6224 3.60977 12.7224 2.50977 12.7224Z"" fill=""#9A9AB0""></path>
                                                </svg>
                                            </a>

                                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""customDropdown"">
                                                <a class=""dropdown-item"" data-img-value=""flag-de3"" data-value=""German"" href=""javascript:void(0);"">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-fill"" viewBox=""0 0 16 16"">
                                                        <path d=""M12.854.146a.5.5 0 0 0-.707 0L10.5 1.");
            WriteLiteral(@"793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z"" />
                                                    </svg>
                                                    Edit
                                                </a>
                                                <a class=""dropdown-item"" data-img-value=""flag-sp"" data-value=""Spanish"" href=""javascript:void(0);"">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash-fill"" viewBox=""0 0 16 16"">
                                                        <path d=""M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0");
            WriteLiteral(@" 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"" />
                                                    </svg>
                                                    Delete
                                                </a>
                                                <a class=""dropdown-item"" data-img-value=""flag-fr3"" data-value=""French"" href=""javascript:void(0);"">
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-upload"" viewBox=""0 0 16 16"">
                                                        <path d=""M.5 9.9a.5.5 0 0 1 .5.5v2.5a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-2.5a.5.5 0 0 1 1 0v2.5a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2v-2.5a.5.5 0 0 1 .5-.5z"" />
                                                        <path d=");
            WriteLiteral(@"""M7.646 1.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1-.708.708L8.5 2.707V11.5a.5.5 0 0 1-1 0V2.707L5.354 4.854a.5.5 0 1 1-.708-.708l3-3z"" />
                                                    </svg>Upload Image
                                                </a>

                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>

                    </div>
");
#nullable restore
#line 83 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Scribe_Factory_Core.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591