#pragma checksum "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_showGroups), @"mvc.1.0.view", @"/Views/Home/showGroups.cshtml")]
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
#line 1 "D:\foxminded\learn_csharp\MVCApps\Views\_ViewImports.cshtml"
using MVCApps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\foxminded\learn_csharp\MVCApps\Views\_ViewImports.cshtml"
using MVCApps.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d", @"/Views/Home/showGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7601f375a7a0d404c010144d67f44d4f7074e5a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCApps.Models.Group>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
  
    //  ViewData["Title"] = "Course list";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d3635", async() => {
                WriteLiteral("\r\n        <title>University</title>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d4646", async() => {
                WriteLiteral("\r\n        <h3>Groups</h3>\r\n        <table>\r\n            <tr>\r\n                <td>GROUP ID</td>\r\n                <td>COURSE_ID</td>\r\n                <td>NAME</td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
             if (ViewBag.StatusRemoveGroup == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h><font color=\"red\">ГРУППА УДАЛЕНА!</font></h>\r\n");
#nullable restore
#line 25 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
             foreach (var group in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
                 if (group.Course.course_ID == ViewBag.group_ID)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d6140", async() => {
#nullable restore
#line 31 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
                                                                     Write(group.group_ID);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 777, "~/Home/showStudents/", 777, 20, true);
#nullable restore
#line 31 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
AddHtmlAttributeValue("", 797, group.group_ID, 797, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
                       Write(group.Course.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td style=\"padding-right: 20px\">");
#nullable restore
#line 33 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
                                                   Write(group.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d8536", async() => {
                    WriteLiteral("Изменить имя группы");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1004, "~/Home/changeNameOfGroup/?groupName=", 1004, 36, true);
#nullable restore
#line 34 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
AddHtmlAttributeValue("", 1040, group.name, 1040, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1051, "&mGroup=", 1051, 8, true);
#nullable restore
#line 34 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
AddHtmlAttributeValue("", 1059, group.group_ID, 1059, 15, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1074, "&mCourse=", 1074, 9, true);
#nullable restore
#line 34 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
AddHtmlAttributeValue("", 1083, group.Course.name, 1083, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8bfb7f659d848b87c4dd9eafef90bad3ab7e34d10766", async() => {
                    WriteLiteral("Удалить группу");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1170, "~/Home/removeGroup/?groupId=", 1170, 28, true);
#nullable restore
#line 35 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
AddHtmlAttributeValue("", 1198, group.group_ID, 1198, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showGroups.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCApps.Models.Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
