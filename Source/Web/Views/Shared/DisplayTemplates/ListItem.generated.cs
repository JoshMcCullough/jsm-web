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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/ListItem.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_ListItem_cshtml_ : System.Web.Mvc.WebViewPage<JSM.Web.Models.Shared.Resume.ListItem>
    {
        public _Views_Shared_DisplayTemplates_ListItem_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<li ");

            
            #line 3 "..\..\Views\Shared\DisplayTemplates\ListItem.cshtml"
Write(new MvcHtmlString(this.Model.Class.IsNullOrEmpty() ? "" : "class=\"{0}\"".FormatString(this.Model.Class)));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 3 "..\..\Views\Shared\DisplayTemplates\ListItem.cshtml"
                                                                                                                   Html.RenderPartial("DisplayTemplates/Content", this.Model.Content);
            
            #line default
            #line hidden
WriteLiteral("</li>");

        }
    }
}
#pragma warning restore 1591
