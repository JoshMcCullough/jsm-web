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

namespace JSM.Web.Views.Shared.DisplayTemplates
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/DisplayTemplates/List.cshtml")]
    public partial class List_ : System.Web.Mvc.WebViewPage<JSM.Web.Models.Shared.Resume.List>
    {
        public List_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
  
    string element = (this.Model.Type == JSM.Web.Models.Shared.Resume.ListType.Ordered ? "ol" : "ul");

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<");

            
            #line 7 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
Write(element);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 7 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
      Write(new MvcHtmlString(this.Model.Class.IsNullOrEmpty() ? "" : "class=\"{0}\"".FormatString(this.Model.Class)));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 8 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
     foreach (var item in this.Model.Items) {
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
   Write(Html.DisplayFor(m => item));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
                                   
    }

            
            #line default
            #line hidden
WriteLiteral("</");

            
            #line 11 "..\..\Views\Shared\DisplayTemplates\List.cshtml"
Write(element);

            
            #line default
            #line hidden
WriteLiteral(">");

        }
    }
}
#pragma warning restore 1591