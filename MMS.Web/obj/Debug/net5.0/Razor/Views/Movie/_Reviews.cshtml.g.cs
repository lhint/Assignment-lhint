#pragma checksum "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2dc959bff8088a0d662329f624ee33d3ca1d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie__Reviews), @"mvc.1.0.view", @"/Views/Movie/_Reviews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2dc959bff8088a0d662329f624ee33d3ca1d14", @"/Views/Movie/_Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0506793228845158aa31be8aed1f7fa5f22dd091", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie__Reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-sm"">
          <thead>
              <tr>
                  <th>Created</th>
                  <th>Name</th>
                  <th>Comment</th>
                  <th>Rating</th>
                  <th></th>
              </tr>
          </thead>
          <tbody>
");
#nullable restore
#line 12 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml"
               foreach(var m in Model.Reviews)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\n                      <td>");
#nullable restore
#line 15 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml"
                     Write(m.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                      <td>");
#nullable restore
#line 16 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml"
                     Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                      <td>");
#nullable restore
#line 17 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml"
                     Write(m.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                      <td>");
#nullable restore
#line 18 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml"
                     Write(m.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                  </tr>\n");
#nullable restore
#line 20 "/Users/lukehinton/Library/Mobile Documents/com~apple~CloudDocs/Postgraduate Degree/6. COM741 - Web Based Application Development/Assignment/Project/Assignment-lhint/MMS.Web/Views/Movie/_Reviews.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tbody>\n      </table>\n      ");
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