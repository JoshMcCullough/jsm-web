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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Menu.cshtml")]
    public partial class _Views_Shared__Menu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Menu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Menu.cshtml"
Write(NavUtil.WriteMenuLink(Html, "overview", "Index", "Overview", null, "Overview"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\Shared\_Menu.cshtml"
Write(NavUtil.WriteMenuLink(Html, "skills & tech", "Index", "SkillsAndTech", null, "SkillsAndTech"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Shared\_Menu.cshtml"
Write(NavUtil.WriteMenuLink(Html, "work history", "Index", "WorkHistory", null, "WorkHistory"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\Shared\_Menu.cshtml"
Write(NavUtil.WriteMenuLink(Html, "education", "Index", "Education", null, "Education"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Shared\_Menu.cshtml"
Write(NavUtil.WriteMenuLink(Html, "contact me", "Index", "ContactMe", null, "ContactMe"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
