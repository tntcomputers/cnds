﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.DocumentVisualizers.Views {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using Lpp;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Dns;
    using Lpp.Dns.DocumentVisualizers;
    using Lpp.Dns.DocumentVisualizers.Models;
    
    
    public partial class Error : System.Web.Mvc.WebViewPage<Exception> {
        
#line hidden

        
        public Error() {
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

WriteLiteral("\r\n<div class=\"DocumentVisual Error\">\r\n    ");


            
            #line 4 "C:\work\DNS\trunk\Lpp.Dns.DocumentVisualizers\Views\Error.cshtml"
Write(Model.Message);

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");


        }
    }
}