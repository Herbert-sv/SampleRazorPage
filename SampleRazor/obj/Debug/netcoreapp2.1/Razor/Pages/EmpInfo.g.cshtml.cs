#pragma checksum "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d812d94450c040759522892ac455de39b0858866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SampleRazor.Pages.Pages_EmpInfo), @"mvc.1.0.razor-page", @"/Pages/EmpInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmpInfo.cshtml", typeof(SampleRazor.Pages.Pages_EmpInfo), null)]
namespace SampleRazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\_ViewImports.cshtml"
using SampleRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d812d94450c040759522892ac455de39b0858866", @"/Pages/EmpInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f6168e2d0a553e6b070b0151ebbedceb9599e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmpInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/User.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:325px;height:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Herbert-sv/SampleRazorPages";

#line default
#line hidden
            BeginContext(115, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(125, 17, false);
#line 10 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(142, 12, true);
            WriteLiteral("</title>\r\n\r\n");
            EndContext();
            BeginContext(154, 332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "427234032ac34709a15f226406de2960", async() => {
                BeginContext(160, 319, true);
                WriteLiteral(@"

        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"" />
        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
        <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    ");
                EndContext();
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
            EndContext();
            BeginContext(486, 680, true);
            WriteLiteral(@"
<nav class=""navbar navbar-inverse navbar-fixed-top"">
    <div class=""container"">
        <div class=""nav navbar-nav navbar-right"" style=""font-size:15px; padding-top:15px;"">
            <a href=""/_"" style=""text-decoration-line:none;color:cyan"" target=""_blank"">Go back to List</a> |
            <a href=""/blank"" style=""text-decoration-line:none;color:cyan "" target=""_blank"">Log Out</a>
        </div>
    </div>
</nav>
<br />
<br />

<h2 class=""text-info"">Employee personal Information</h2>
<br />

<div class=""container"">
    <div class=""row "" style=""float:left"">
        <div class=""col-md-4"">
            <h6 class=""text-info"">Employee Id</h6>
            <p>");
            EndContext();
            BeginContext(1167, 19, false);
#line 36 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.EmpId);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 79, true);
            WriteLiteral("</p>\r\n            <h6 class=\"text-info\">Employee FirsName</h6>\r\n            <p>");
            EndContext();
            BeginContext(1266, 23, false);
#line 38 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1289, 79, true);
            WriteLiteral("</p>\r\n            <h6 class=\"text-info\">Employee LastName</h6>\r\n            <p>");
            EndContext();
            BeginContext(1369, 22, false);
#line 40 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 80, true);
            WriteLiteral("</p>\r\n            <h6 class=\"text-info\">Employees Position</h6>\r\n            <p>");
            EndContext();
            BeginContext(1472, 22, false);
#line 42 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 79, true);
            WriteLiteral("</p>\r\n            <h6 class=\"text-info\">Employee Superior</h6>\r\n            <p>");
            EndContext();
            BeginContext(1574, 22, false);
#line 44 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.Superior);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 82, true);
            WriteLiteral("</p>\r\n            <h6 class=\"text-info\">Employee PhoneNumber</h6>\r\n            <p>");
            EndContext();
            BeginContext(1679, 25, false);
#line 46 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1704, 84, true);
            WriteLiteral("</p>\r\n            <h6 class=\"text-info\">Employees EmailAddress</h6>\r\n            <p>");
            EndContext();
            BeginContext(1789, 26, false);
#line 48 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpInfo.cshtml"
          Write(Model.EmpPage.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1815, 157, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"row \" style=\"float:left; padding-left:90px;padding-top:30px\">\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(1972, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "139bd72eefc24927b4eb8e0803b6a74b", async() => {
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
            EndContext();
            BeginContext(2059, 241, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<footer>\r\n    <p class=\"well text-primary\">\r\n        &copy; 2020 <a href=\"https://github.com/herbert-sv\" target=\"_blank\">Herbert-sv/SampleRazorPages</a>\r\n    </p>\r\n</footer>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmpinfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmpinfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmpinfoModel>)PageContext?.ViewData;
        public EmpinfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
