#pragma checksum "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Functions\TextToSpeech.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab6cd5d78f4e447a3199a71f5b8117b8badcc04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Functions_TextToSpeech), @"mvc.1.0.view", @"/Views/Functions/TextToSpeech.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab6cd5d78f4e447a3199a71f5b8117b8badcc04", @"/Views/Functions/TextToSpeech.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aeda2b8c910eadfd65a20b3f1fab49fa5454ca3", @"/Views/_ViewImports.cshtml")]
    public class Views_Functions_TextToSpeech : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Male", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Female", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AvoloxPC-11\source\repos\Scribe_Factory_Core\Scribe_Factory_Core\Views\Functions\TextToSpeech.cshtml"
  
    ViewData["Title"] = "TextToSpeech";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"" id=""functions"">
    <div class=""row"">
        <div class=""col-md-12"">

            <h5>Give us your choice by selecting filters below.</h5>

            <div class=""txt-speech-div-selct"">
                <div style=""margin-bottom:20px"">
                    <input type=""text"" name=""ProjectName"" id=""ProjectName"" placeholder=""Any name on your mind for the project? "" style=""        width: 50%;
        padding: 8px;
        border-radius: 10px;
        border: 1px solid rgba(0, 0, 0, .1) !important;"" required>
                </div>
                <select name=""Gender"" id=""Gender"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab6cd5d78f4e447a3199a71f5b8117b8badcc045020", async() => {
                WriteLiteral("Gender");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab6cd5d78f4e447a3199a71f5b8117b8badcc046199", async() => {
                WriteLiteral("Male");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab6cd5d78f4e447a3199a71f5b8117b8badcc047376", async() => {
                WriteLiteral("Female");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n                <select name=\"Language\" id=\"Language\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab6cd5d78f4e447a3199a71f5b8117b8badcc048646", async() => {
                WriteLiteral("Languages");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n                <select name=\"Voice\" id=\"Voice\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab6cd5d78f4e447a3199a71f5b8117b8badcc049913", async() => {
                WriteLiteral("Voice");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n");
            WriteLiteral(@"            </div>

        </div>
        <div class=""col-md-12"">
            <div class=""row mt-5"">
                <div class=""col-11"">
                    <div class=""txt-to-spech-div"">
                        <div class=""txt-spch-txtbox"">
                            <textarea class=""form-control "" style=""height:100px;"" id=""validationTextarea"" disabled placeholder=""Enter Text here"" required></textarea>

                        </div>
                        <div class=""str-bin"">
                            <ul>
                                <li>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star"" viewBox=""0 0 16 16"">
                                        <path d=""M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.522-3.356c.33-.314.16-.888-.282-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.8");
            WriteLiteral(@"3 4.73zm4.905-2.767-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288L8 2.223l1.847 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.565.565 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z"" />
                                    </svg>
                                </li>
                                <li>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
                                        <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                                        <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.8");
            WriteLiteral(@"82 4H4.118zM2.5 3V2h11v1h-11z"" />
                                    </svg>
                                </li>
                            </ul>
                        </div>
                        <div class=""btn-span"">
                            <button id=""play"" class=""ply-btn"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-play-circle"" viewBox=""0 0 16 16"">
                                    <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                                    <path d=""M6.271 5.055a.5.5 0 0 1 .52.038l3.5 2.5a.5.5 0 0 1 0 .814l-3.5 2.5A.5.5 0 0 1 6 10.5v-5a.5.5 0 0 1 .271-.445z"" />
                                </svg>
                            </button>
                            <span class=""ply-span""><small>350 / 250</small></span>
                        </div>

                    </div>
                </div>
                <div class=""col-1"">");
            WriteLiteral(@"
                    <div class=""txt-spch-plus"">
                        <span>
                            <a href=""#"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-plus"" viewBox=""0 0 16 16"">
                                    <path d=""M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"" />
                                </svg>
                            </a>
                        </span>
                    </div>
                </div>
            </div>



        </div>
        <div class=""col-md-10""></div>
        <div class=""col-md-2"">
            <div class=""xport-main-div"">
                <div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 6525, "\"", 6532, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <button>Export</button>
                        <label id=""HiddenProjectId"" hidden></label>
                    </a>
                </div>
            </div>
        </div>

        <script src=""/js/notify-combined.min.js""></script>
        <script type=""text/javascript"">

            //jQuery.notify.notify(""Click me!"", { position: ""bottom right"", className: ""success"" });
            $(document).ready(function () {


                //function will be called on button click having id btnsave
                $(""#Gender"").change(function () {
                    debugger;
                    var gender = this.value;
                    if (gender == """") {

                        //jQuery.notify.notify.defaults({ globalPosition: 'bottom right' });
                        jQuery.notify(""Please Select a valid Gender"", { position: ""bottom right"", className: ""warn"" });
                    }
                    if (gender != """") {
                        $.ajax(
 ");
            WriteLiteral(@"                           {
                                type: ""Get"", //HTTP POST Method
                                url: ""GetLanguagesAgainstGender"", // Controller/View
                                data: { gender: gender },
                                dataType: ""json"",
                                success: function (response) {
                                    if (response) {
                                        debugger;
                                        for (var i = 0; i < response.length; i++) {
                                            var opt = document.createElement('option');
                                            opt.value = response[i].languageCode;
                                            opt.innerHTML = response[i].languageName;
                                            document.getElementById('Language').appendChild(opt);
                                        }
                                    }
                                    else");
            WriteLiteral(@" {
                                        document.getElementById('LoginError').style.display = 'block';
                                    }
                                }
                            });
                    }
                });
                $(""#Language"").change(function () {
                    debugger;
                    var Language = this.value;
                    var gender = $('#Gender').find("":selected"").val();
                    if (Language == """") {
                        jQuery.notify(""Please Select a valid Language"", { position: ""bottom right"", className: ""warn"" });
                    }
                    if (gender == """") {
                        jQuery.notify(""Please Select a valid Gender"", { position: ""bottom right"", className: ""warn"" });
                    }
                    if (gender != """" && Language != """") {
                        $.ajax(
                            {
                                type: ""Get"", //HTTP POST Method
            WriteLiteral(@"
                                url: ""getVoicesAgainstLangugae"", // Controller/View
                                data: { LanguageCode: Language, gender: gender },
                                dataType: ""json"",
                                success: function (response) {
                                    if (response) {
                                        debugger;
                                        for (var i = 0; i < response.length; i++) {
                                            var opt = document.createElement('option');
                                            opt.value = response[i].id;
                                            opt.innerHTML = response[i].name;
                                            document.getElementById('Voice').appendChild(opt);
                                        }
                                    }
                                    else {
                                        document.getElementById('LoginError').style.disp");
            WriteLiteral(@"lay = 'block';
                                    }
                                }
                            });
                    }
                });

                $(""#Voice"").change(function () {
                    debugger;
                    var Voice = this.value;
                    if (Voice != """") {
                        $('#validationTextarea')[0].disbaled = false;
                    }
                });
                $(""#play"").click(function () {
                    debugger;
                    var text = $('#validationTextarea')[0].value;
                    var ProjectName = $('#ProjectName')[0].value;
                    var voiceId = $('#Voice').find("":selected"").val();
                    if (ProjectName == """") {
                        jQuery.notify(""Provide a name please"", { position: ""bottom right"", className: ""warn"" });
                    }
                    else if (text != """" && VoiceId != """") {
                        $.ajax(
            ");
            WriteLiteral(@"                {
                                type: ""Post"", //HTTP POST Method
                                url: ""ConvertTextToSpeech"", // Controller/View
                                dataType: ""json"",
                                data: {
                                    text: text,
                                    VoiceId: voiceId
                                },
                                success: function (response) {
                                    debugger;
                                    if (response != false) {
                                        $('#HiddenProjectId').val(response);
                                        debugger;
                                    }
                                    else {
                                        document.getElementById('LoginError').style.display = 'block';
                                    }
                                }
                            });
                    }
         ");
            WriteLiteral(@"       });

                //$.ajax(
                //    {
                //        type: ""Get"", //HTTP POST Method
                //        url: ""getVoicesDetails"", // Controller/View
                //        dataType: ""json"",
                //        success: function (response) {
                //            debugger;
                //            if (response) {

                //                debugger;
                //            }
                //            else {
                //                document.getElementById('LoginError').style.display = 'block';
                //            }
                //        }
                //    });

            });
        </script>
    </div>
</div>

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