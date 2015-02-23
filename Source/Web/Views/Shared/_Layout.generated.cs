﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using JSM.Web;
    using QuantumConcepts.Common.Extensions;
    using QuantumConcepts.Common.Mvc.Extensions;
    using QuantumConcepts.Common.Mvc.Utils;
    using QuantumConcepts.Common.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    <head>\r\n        <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral("/>\r\n        <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral("/>\r\n        <meta");

WriteLiteral(" name=\"author\"");

WriteLiteral(" content=\"Josh McCullough\"");

WriteLiteral("/>\r\n        <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"I\'m a highly skilled software engineer who prides himself on completing" +
" tasks on time while maintaining high quality standards and adhering to software" +
" development best practices.\"");

WriteLiteral(" />\r\n        <meta");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" content=\"software,development,engineering,engineer,c#,.NET,coding,coder,for hire" +
"\"");

WriteLiteral("/>\r\n        <title>Josh McCullough - A top-quality, full-stack software engineer." +
"</title>\r\n        <link");

WriteLiteral(" href=\"http://fonts.googleapis.com/css?family=Lato:300,400,700,300italic,400itali" +
"c,700italic\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral("/>\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Shared\_Layout.cshtml"
   Write(Styles.Render("~/Content/Stylesheets/Site"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Shared\_Layout.cshtml"
   Write(Styles.RenderFormat("<link href=\"{0}\" rel=\"stylesheet\" media=\"print\" />", "~/Content/Stylesheets/Print"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Views\Shared\_Layout.cshtml"
   Write(Scripts.Render("~/Content/Scripts/3rdParty"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Shared\_Layout.cshtml"
   Write(Scripts.Render("~/Content/Scripts/Site"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Head", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </head>\r\n    <body");

WriteAttribute("class", Tuple.Create(" class=\"", 1116), Tuple.Create("\"", 1229)
, Tuple.Create(Tuple.Create("", 1124), Tuple.Create("Controller-", 1124), true)
            
            #line 17 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 1135), Tuple.Create<System.Object, System.Int32>(ViewContext.RouteData.Values["controller"]
            
            #line default
            #line hidden
, 1135), false)
, Tuple.Create(Tuple.Create(" ", 1180), Tuple.Create("Action-", 1181), true)
            
            #line 17 "..\..\Views\Shared\_Layout.cshtml"
  , Tuple.Create(Tuple.Create("", 1188), Tuple.Create<System.Object, System.Int32>(ViewContext.RouteData.Values["action"]
            
            #line default
            #line hidden
, 1188), false)
);

WriteLiteral(">\r\n        <header>\r\n            <div");

WriteLiteral(" class=\"row About\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col col-sm-12 col-md-4 Name\"");

WriteLiteral(">Josh McCullough</div>\r\n                <ul");

WriteLiteral(" class=\"col col-sm-12 col-md-8 Roles\"");

WriteLiteral(@">
                    <li>software engineer</li>
                    <li>leader</li>
                    <li>database developer</li>
                    <li>mentor</li>
                    <li>ui/ux designer</li>
                </ul>
            </div>
            <nav");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 30 "..\..\Views\Shared\_Layout.cshtml"
                
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Shared\_Layout.cshtml"
                  Html.RenderPartial("_Menu");
            
            #line default
            #line hidden
WriteLiteral("\r\n            </nav>\r\n        </header>\r\n\r\n        <div");

WriteLiteral(" id=\"Content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"PageContent\"");

WriteLiteral(">\r\n");

            
            #line 36 "..\..\Views\Shared\_Layout.cshtml"
                
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\_Layout.cshtml"
                 if (ViewBag.PageTitle != null) {

            
            #line default
            #line hidden
WriteLiteral("                    <h1><span>");

            
            #line 37 "..\..\Views\Shared\_Layout.cshtml"
                         Write(ViewBag.PageTitle);

            
            #line default
            #line hidden
WriteLiteral("</span></h1>\r\n");

            
            #line 38 "..\..\Views\Shared\_Layout.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n\r\n        <footer>\r\n            <div" +
"");

WriteLiteral(" id=\"FooterContent\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"left-menu hidden-print\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2254), Tuple.Create("\"", 2288)
            
            #line 49 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2261), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "All")
            
            #line default
            #line hidden
, 2261), false)
);

WriteLiteral(">view as a single page</a>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2339), Tuple.Create("\"", 2374)
            
            #line 50 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2346), Tuple.Create<System.Object, System.Int32>(Url.Action("PDF", "Export")
            
            #line default
            #line hidden
, 2346), false)
);

WriteLiteral(">download as a PDF</a>\r\n                    <a");

WriteLiteral(" href=\"https://github.com/JoshMcCullough/jsm-web\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">view source on GitHub</a>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"visible-print Web\"");

WriteLiteral(">For a more <em>interactive</em> experience, please visit <a");

WriteLiteral(" href=\"http://joshmccullough.me\"");

WriteLiteral(">http://JoshMcCullough.me</a>.</div>\r\n            </div>\r\n        </footer>\r\n\r\n  " +
"      <div");

WriteLiteral(" id=\"PrintModal\"");

WriteLiteral(" class=\"modal fade hidden-print\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                        <h2");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(">download complete resume</h2>\r\n                    </div>\r\n                    <" +
"div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                        <p>You just printed this page, or at least thought abo" +
"ut it.</p>\r\n                        <p>Would you like to download a PDF version " +
"of my resume?</p>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" id=\"DownloadPDFButton\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Download PDF</button>\r\n                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Close</button>\r\n                    </div>\r\n                </div>\r\n            " +
"</div>\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 76 "..\..\Views\Shared\_Layout.cshtml"
   Write(Scripts.Render("~/Content/Scripts/3rdParty"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 77 "..\..\Views\Shared\_Layout.cshtml"
   Write(Scripts.Render("~/Content/Scripts/Site"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 78 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(document).ready(function () {\r\n                Site.initialize(\"" +
"");

            
            #line 82 "..\..\Views\Shared\_Layout.cshtml"
                            Write(Url.Content("~/"));

            
            #line default
            #line hidden
WriteLiteral("\");\r\n            });\r\n        </script>\r\n    </body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
