#pragma checksum "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232a13cd447c7230c2ca91d6c55a18bdb5d15b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SampleRazor.Pages.Pages_EmpList), @"mvc.1.0.razor-page", @"/Pages/EmpList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmpList.cshtml", typeof(SampleRazor.Pages.Pages_EmpList), @"/_")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/_")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232a13cd447c7230c2ca91d6c55a18bdb5d15b35", @"/Pages/EmpList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f6168e2d0a553e6b070b0151ebbedceb9599e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmpList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet_Emp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/EmpInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Emp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("glyphicon glyphicon-user "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("See Profile !"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Herbert-sv/SampleRazorPages";

#line default
#line hidden
            BeginContext(119, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(129, 17, false);
#line 10 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(146, 12, true);
            WriteLiteral("</title>\r\n\r\n");
            EndContext();
            BeginContext(158, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39815eec3bdb4ce79174604ce89fa94a", async() => {
                BeginContext(164, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(170, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36543606245b4b1bbf12b291d4e97f60", async() => {
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
                EndContext();
                BeginContext(227, 301, true);
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
            BeginContext(535, 776, true);
            WriteLiteral(@"

<nav class=""navbar navbar-inverse navbar-fixed-top"">
    <div class=""container"">
         <div class=""nav navbar-nav navbar-right"" style=""font-size:15px; padding-top:15px;"">
             <a href=""/blank"" style=""text-decoration-line:none;color:cyan;""target=""_blank"">Log Out</a></div>
     </div>
</nav>
<br/>

<h2 class=""text-primary"">Directory Employees</h2>
<br />


<div class=""table-responsive"">
    <table class=""table"">
        <tr class=""text-primary"">
            <th>Emplyee id</th>
            <th>Employee FirstName</th>
            <th>Employee LastName</th>
            <th>Employee Position</th>
            <th>Employee Supervisor</th>
            <th>Employee PhoneNumber</th>
            <th>Employee EmailAddress</th>
        </tr>
");
            EndContext();
#line 42 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
         foreach (var Emp in Model.Emp_)
        {

#line default
#line hidden
            BeginContext(1364, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1403, 9, false);
#line 45 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.EmpId);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1440, 13, false);
#line 46 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1453, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1481, 12, false);
#line 47 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1521, 12, false);
#line 48 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1533, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1561, 12, false);
#line 49 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.Superior);

#line default
#line hidden
            EndContext();
            BeginContext(1573, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1601, 15, false);
#line 50 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1616, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1644, 16, false);
#line 51 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
               Write(Emp.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1660, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1687, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13120bffaa994dbc8ebbd355c2d2a76e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"
                                                                    WriteLiteral(Emp.EmpId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1878, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 56 "C:\Users\tiger\Desktop\SampleRazorWebpage\SampleRazor\Pages\EmpList.cshtml"


        }

#line default
#line hidden
            BeginContext(1921, 333, true);
            WriteLiteral(@"
    </table>
</div>
<br/>
<br/>

<footer>
    <p class=""well text-primary"">
        &copy; 2020 <a href=""https://github.com/herbert-sv"" target=""_blank"">Herbert-sv/SampleRazorPages</a>
    </p>
</footer>

<script>
    $(document).ready(function () {
        $('[data-toggle=""tooltip""]').tooltip();
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591