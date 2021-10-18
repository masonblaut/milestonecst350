#pragma checksum "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db72f2359ef11a70c86c1f115096df8c8f4361b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
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
#line 1 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\_ViewImports.cshtml"
using Milestone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\_ViewImports.cshtml"
using Milestone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db72f2359ef11a70c86c1f115096df8c8f4361b8", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c56186b46366aee57c914ee133d6bf1029d996", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Milestone.Models.CellModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("game-button-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/field.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/bomb3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/hole3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    .game-button {
        width: 85px;
        height: 85px;
        border: none;
        white-space: nowrap;
        text-align: center;
        background-color: transparent;
        background-repeat: no-repeat;
        overflow: hidden;
        outline: 1px solid black;
        color: white;
        text-align: center;
        position: relative;
    }

    .game-button-image {
        width: 85px;
        height: 85px;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }

   

    .line-break {
        flex-basis: 100%;
        height: 0;
    }

    .button-label {
        font-size: 8px;
        text-align: center;
    }

    .cell-zone {
        background-image: url(""/Images/bigField.png"");
        background-repeat: no-repeat;
        background-size: contain;
        resize: both;
        display: flex;
        flex-wrap: wrap;
    }

    .centered {
        position: absolute;
  ");
            WriteLiteral("      top: 50%;\r\n        left: 50%;\r\n        transform: translate(-50%, -50%);\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
  
    //Add image names for game pieces here!
    string[] gamePieces = { "", "", "" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Current Time: ");
#nullable restore
#line 62 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
            Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db72f2359ef11a70c86c1f115096df8c8f4361b86810", async() => {
                WriteLiteral("\r\n    <div class=\"cell-zone\">\r\n   \r\n");
#nullable restore
#line 66 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
         for (int i = 0; i < Model.Count(); i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                 if (i % Math.Sqrt(Model.Count) == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"line-break\"></div>\r\n");
#nullable restore
#line 71 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"oneButton\",");
                BeginWriteAttribute("id", " id=", 1584, "", 1590, 1);
#nullable restore
#line 72 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
WriteAttributeValue("", 1588, i, 1588, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <button class=\"game-button\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1650, "\"", 1660, 1);
#nullable restore
#line 73 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
WriteAttributeValue("", 1658, i, 1658, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"tileNumber\">\r\n");
#nullable restore
#line 74 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                     if (!Model.ElementAt(i).Visited)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db72f2359ef11a70c86c1f115096df8c8f4361b89017", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                    }
                    else
                    {
                        if (Model[i].State > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <!--script>alert(\"Game Over!!!\");</!--script-->\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db72f2359ef11a70c86c1f115096df8c8f4361b810639", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db72f2359ef11a70c86c1f115096df8c8f4361b812117", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"centered\">");
#nullable restore
#line 88 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                                             Write(Model[i].Neighbors);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 89 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!--<div class=\"button-label\">\r\n                        ");
#nullable restore
#line 93 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                   Write(Model.ElementAt(i).State);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        ");
#nullable restore
#line 94 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                   Write(Model.ElementAt(i).Neighbors);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        ");
#nullable restore
#line 95 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
                   Write(Model.ElementAt(i).Visited);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>-->\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 99 "C:\Users\Dell User\Documents\GitHub\milestonecst350\Views\Game\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db72f2359ef11a70c86c1f115096df8c8f4361b816030", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Save Game\" class=\"btn btn-primary\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Milestone.Models.CellModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
