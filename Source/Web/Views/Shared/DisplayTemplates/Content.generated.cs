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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/Content.cshtml")]
    public partial class _Views_Shared_DisplayTemplates_Content_cshtml_ : System.Web.Mvc.WebViewPage<List<object>>
    {
        public _Views_Shared_DisplayTemplates_Content_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\DisplayTemplates\Content.cshtml"
 foreach (object o in this.Model) {
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Shared\DisplayTemplates\Content.cshtml"
Write(Html.DisplayFor(m => o));

            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Shared\DisplayTemplates\Content.cshtml"
                            
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
