#pragma checksum "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa98b9b2e6f2583e2225eeb66a7a040678e44bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
#line 1 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/_ViewImports.cshtml"
using MMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/_ViewImports.cshtml"
using MMS.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/_ViewImports.cshtml"
using MMS.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa98b9b2e6f2583e2225eeb66a7a040678e44bd", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0506793228845158aa31be8aed1f7fa5f22dd091", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-light mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<nav aria-label=\"breadcrumb\">\n    <ol class=\"breadcrumb\">\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa98b9b2e6f2583e2225eeb66a7a040678e44bd6422", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa98b9b2e6f2583e2225eeb66a7a040678e44bd7804", async() => {
                WriteLiteral("Movies");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n        <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 7 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
    </ol>
</nav>

<h1>Details</h1>

<div class=""card rounded shadow p-3"">
   <div class=""row pl-3"">
        <!-- Details -->
        <div class=""col-8 mt-4"">
            <h3 class=""mb-4"">Movie Details</h3>
            <dl class=""row"">       
                <dt class=""col-5"">Title</dt>
                <dd class=""col-7"">");
#nullable restore
#line 20 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n                <dt class=\"col-5\">Director</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 23 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                \n                <dt class=\"col-5\">Year</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 26 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n                <dt class=\"col-5\">Duration (Minutes)</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 29 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                \n                <dt class=\"col-5\">Budget</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 32 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n                <dt class=\"col-5\">Genre</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 35 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n                <dt class=\"col-5\">Cast</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 38 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Cast);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>

                <dt class=""col-5"">Rating</dt>
                <dd class=""col-7"">
                <!-- Add icon library -->
                <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
#nullable restore
#line 44 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                 if(Model.Rating >= 100)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
");
#nullable restore
#line 51 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                } else if (Model.Rating >= 80)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star""></span>
");
#nullable restore
#line 58 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                } else if (Model.Rating >= 60)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
");
#nullable restore
#line 65 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                } else if (Model.Rating >= 40)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
");
#nullable restore
#line 72 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                } else if (Model.Rating >= 20)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
");
#nullable restore
#line 79 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                } else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
");
#nullable restore
#line 86 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </dd>\n\n                <dt class=\"col-5\">Plot</dt>\n                <dd class=\"col-7\">");
#nullable restore
#line 90 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                             Write(Model.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n            </dl>               \n        </div>\n\n        <!-- Photo -->\n        <div class=\"col-4\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 3899, "\"", 3921, 1);
#nullable restore
#line 96 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
WriteAttributeValue("", 3905, Model.PosterUrl, 3905, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\n\n            <div class=\"container\">\n            <div class=\"row justify-content-center pt-3 pb-3\">\n\n    \n            <!-- Edit Button -->\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa98b9b2e6f2583e2225eeb66a7a040678e44bd18837", async() => {
                WriteLiteral("\n                Edit Movie\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n\n            <!-- Back Button --> \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa98b9b2e6f2583e2225eeb66a7a040678e44bd21467", async() => {
                WriteLiteral("\n                Back to list\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/Details.cshtml"
                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n            \n           </div>\n        </div>  \n        </div>\n   <!--Display reviews for current movie-->\n   \n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "baa98b9b2e6f2583e2225eeb66a7a040678e44bd24171", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "baa98b9b2e6f2583e2225eeb66a7a040678e44bd25274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
