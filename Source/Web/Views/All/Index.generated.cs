﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/All/Index.cshtml")]
    public partial class _Views_All_Index_cshtml : System.Web.Mvc.WebViewPage<JSM.Web.Models.Shared.Resume.Resume>
    {
        public _Views_All_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\All\Index.cshtml"
  
    ViewBag.Title = "Résumé of {0}".FormatString(this.Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 7 "..\..\Views\All\Index.cshtml"
  Html.RenderPartial("~/Views/Overview/_Content.cshtml", this.Model.FindSection("overview"));
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\All\Index.cshtml"
 foreach (var section in this.Model.Sections.Where(o => o.Key != "overview")) {
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\All\Index.cshtml"
Write(Html.DisplayFor(m => section));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\All\Index.cshtml"
                                  
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"section_contact-me\"");

WriteLiteral(" class=\"section\"");

WriteLiteral(">\r\n    <h1><span>Contact Me</span></h1>\r\n");

            
            #line 15 "..\..\Views\All\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\All\Index.cshtml"
      Html.RenderPartial("~/Views/ContactMe/_ContactInfo.cshtml");
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
