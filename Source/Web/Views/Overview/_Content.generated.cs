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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Overview/_Content.cshtml")]
    public partial class _Views_Overview__Content_cshtml : System.Web.Mvc.WebViewPage<JSM.Web.Models.Shared.Resume.Section>
    {
        public _Views_Overview__Content_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("id", Tuple.Create(" id=\"", 51), Tuple.Create("\"", 79)
, Tuple.Create(Tuple.Create("", 56), Tuple.Create("section_", 56), true)
            
            #line 3 "..\..\Views\Overview\_Content.cshtml"
, Tuple.Create(Tuple.Create("", 64), Tuple.Create<System.Object, System.Int32>(this.Model.Key
            
            #line default
            #line hidden
, 64), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 80), Tuple.Create("\"", 154)
, Tuple.Create(Tuple.Create("", 88), Tuple.Create("section", 88), true)
            
            #line 3 "..\..\Views\Overview\_Content.cshtml"
, Tuple.Create(Tuple.Create("", 95), Tuple.Create<System.Object, System.Int32>(this.Model.Class.IsNullOrEmpty() ? "" : this.Model.Class
            
            #line default
            #line hidden
, 95), false)
);

WriteLiteral(">\r\n    <h1><span>");

            
            #line 4 "..\..\Views\Overview\_Content.cshtml"
         Write(this.Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></h1>\r\n\r\n");

            
            #line 6 "..\..\Views\Overview\_Content.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Overview\_Content.cshtml"
      Html.RenderPartial("DisplayTemplates/Content", this.Model.Content);
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" id=\"subsection_self-rankings\"");

WriteLiteral(" class=\"subsection\"");

WriteLiteral(">\r\n        <h2><span>Self-rankings</span></h2>\r\n        <p>I\'ve compiled a list o" +
"f the technologies with which I most often work. The relative size of each item " +
"indicates my level of expertise.</p>\r\n        <p");

WriteLiteral(" class=\"warning visible-xs\"");

WriteLiteral(">This works much better on a larger screen &mdash; trust me.</p>\r\n        <ul");

WriteLiteral(" class=\"expertise clearfix\"");

WriteLiteral("></ul>\r\n        <div");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" id=\"toggle-expertise\"");

WriteLiteral(" class=\"visible-xs expertise-btn\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-chevron-down\"");

WriteLiteral("></span> <span");

WriteLiteral(" class=\"text\"");

WriteLiteral(">show all</span> <span");

WriteLiteral(" class=\"glyphicon glyphicon-chevron-down\"");

WriteLiteral("></span></a>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" id=\"subsection_projects\"");

WriteLiteral(" class=\"subsection\"");

WriteLiteral(">\r\n        <h2><span>Projects</span></h2>\r\n        <p>Please find below a <em>sma" +
"ll collection</em> of my work. I\'ve highlighted my involvement on each project.<" +
"/p>\r\n        <ul");

WriteLiteral(" class=\"blocks\"");

WriteLiteral(">\r\n            <li>\r\n                <h3>ARMATURE Fabric<a");

WriteLiteral(" class=\"visit\"");

WriteLiteral(" href=\"http://armaturecorp.com\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span></a></h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Accreditation, certification, and quality management software.</div>\r\n          " +
"      <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>Built using cutting-edge Javascript frameworks and tools, this SAAS package utilizes a complex set of microservices, CouchDB to store aggregated data, and Elasticsearch to provide instant search results across the entire platform.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"microservices cs webapi2 mssql couchdb elasticsearch aurelia\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>Federal Event " +
"Management Portal<a");

WriteLiteral(" class=\"visit\"");

WriteLiteral(" href=\"http://fed-events.com\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span></a></h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Custom-built event management system.</div>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>This event management portal allows for the quick and easy setup of completely customizable Federal event-related websites. Includes complete CMS functionality, event registration, and more.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"cs mvc mssql html css typescript uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>Health Indicat" +
"ors Warehouse (HIW)</h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Data Warehouse of health-related indicators - CDC/NCHS.</div>\r\n                <" +
"div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <p>The HIW contains data from 125+ sources across 1,200+ h" +
"ealth indicators. This project is part of the <a");

WriteLiteral(" href=\"http://www.data.gov\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Data.gov</a>\'s <a");

WriteLiteral(" href=\"http://www.whitehouse.gov/open\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Open Data Initiative</a> and exposes massive amounts of publicly-consumable heal" +
"th-related data.</p>\r\n                </div>\r\n                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"cs mssql html css js uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>HIW Developers" +
" &amp; Services</h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Over 1,000 RESTful (and SOAP) service methods.</div>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>Exposes data from the HIW. Custom CodeGenerator templates were used to generate the service methods and documentation. The system includes a real-time URL builder/service tester and API key registration/verification.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"cs mssql html css bs js ko uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>CodeGenerator<" +
"a");

WriteLiteral(" class=\"visit\"");

WriteLiteral(" href=\"http://quantumconceptscorp.com/Products/CodeGenerator.aspx\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span></a></h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Develop stable, robust and highly versatile software, faster!</div>\r\n           " +
"     <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>This tool allows you and your team to get the nuts and bolts of any project up and running amazingly fast. The backbone of CodeGenerator relies on XML and XSLT. You design an XSL Template once and CodeGenerator handles the rest.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"cs winforms mssql mysql uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>Platform Liber" +
"ty</h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Empowering candidates in the fight for liberty.</div>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>The goal of this project is to provide an inexpensive, easy-to-use web application for liberty candidates. This platform will be available to any candidate who is on the side of liberty - regardless of party their party affiliation. 10+ instances.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"rails mysql html css bs js ko uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>Carson for Con" +
"gress</h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral("></div>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <p>Built atop Platform Liberty and customized to fit the n" +
"eeds of Jeffrey Carson\'s 2014 Congressional campaign.</p>\r\n                </div" +
">\r\n                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"rails mysql html css bs js ko uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>AeroBazaar<a");

WriteLiteral(" class=\"visit\"");

WriteLiteral(" href=\"http://aerobazaar.com\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span></a></h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">The most beautiful place to buy and sell aircraft online.</div>\r\n               " +
" <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>A robust aircraft listing engine allows potential aircraft buyers to easily find what they're looking for. Sellers can manage their inventory and add detailed information for each of their aircraft.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"php mysql html css bs js ko uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>7Flix<a");

WriteLiteral(" class=\"visit\"");

WriteLiteral(" href=\"http://quantumconceptscorp.com/Products/7Flix.aspx\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-new-window\"");

WriteLiteral("></span></a></h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">A full-featured Netflix client for Windows Phones.</div>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>Although this app is no longer available, since Netflix ditched their public API, it was the most complete Netflix client on the platform at the time. It included queue management features and the ability to search and browse the entire Netflix library.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"cs wp sl uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n\r\n            <li>\r\n                <h3>SuperTrition</" +
"h3>\r\n                <div");

WriteLiteral(" class=\"tagline\"");

WriteLiteral(">Online nutritional supplement and fitness store.</div>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(@">
                    <p>A custom e-commerce backend including a full-featured shopping cart with Paypal, Google Checkout, VeriSign Payment Services (now Paypal), UPS and USPS integration. Custom order processor to monitor fulfillment and shipment status.</p>
                </div>
                <ul");

WriteLiteral(" class=\"features tags\"");

WriteLiteral(" data-tags-keys=\"cs mssql html css js uiux\"");

WriteLiteral("></ul>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $document.ready(function () {
        $(""ul.tags"").tags();

        $(""ul.expertise"").expertise({
            minSize: 30,
            maxSize: 150,
            fixedHeight: 60,
            layouts: function () {
                var layouts = {};

                layouts[ExpertiseLayoutMode.Linear] = {
                    options: new LinearLayoutOptions({
                        linePerLevel: false
                    })
                };

                return layouts;
            }()
        });

        $(""#toggle-expertise"").click(function () {
            var $togglExpertise = $(this);
            var $togglExpertiseText = $togglExpertise.children("".text"");
            var $togglExpertiseIcon = $togglExpertise.children("".glyphicon"");
            var $expertise = $(""ul.expertise"");
            var show = !$expertise.hasClass(""all"");

            $togglExpertiseText.text(show ? ""show less"" : ""show all"");
            $togglExpertiseIcon.toggleClass(""glyphicon-chevron-down"", !show);
            $togglExpertiseIcon.toggleClass(""glyphicon-chevron-up"", show);
            $expertise.toggleClass(""all"", show);
        });
    });
</script>
");

        }
    }
}
#pragma warning restore 1591
