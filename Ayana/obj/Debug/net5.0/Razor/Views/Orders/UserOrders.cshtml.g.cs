#pragma checksum "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb63f53c2cd36b804a2a6ce7ca0331062b31838e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_UserOrders), @"mvc.1.0.view", @"/Views/Orders/UserOrders.cshtml")]
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
#line 1 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\_ViewImports.cshtml"
using Ayana;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\_ViewImports.cshtml"
using Ayana.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb63f53c2cd36b804a2a6ce7ca0331062b31838e", @"/Views/Orders/UserOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173c1fb09878f2d54cb847bb1f18422e0ceac569", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_UserOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
  
    ViewData["Title"] = "User Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-bottom: 100px;"">
    <style>
        .order {
            background-color: #dee0ab;
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
            margin-bottom: 20px;
            padding: 10px;
        }

        .order-info {
            margin-bottom: 10px;
        }

        .product-container {
            display: flex;
            flex-wrap: wrap;
        }

        .product-box {
            padding: 10px;
            margin: 10px;
            text-align: center;
        }

        .product-image {
            width: 150px;
            height: 150px;
            object-fit: contain;
        }

        .product-name {
            margin-top: 5px;
        }
    </style>

    <div style=""background-color:#FFE4E1; margin-left:-30px; margin-right:-30px; margin-top:10px; height:300px; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode'");
            WriteLiteral(@", Geneva, Verdana, sans-serif;"">
        <br>
        <div style=""display:flex;align-items:center;"">
            <div style=""flex-basis: 60%; margin-left:30px; margin-right:10px;"">
                <p style=""margin-top:-10px; font-size: 30px; font-weight: bold;"">Dear Valued Customer</p>
                <br>
                <p style=""margin-top:-10px; margin-right:100px;"">
                    We hope this message finds you well. We wanted to take a moment to express how important your feedback is to us as a flower shop. Your opinion matters, and we would greatly appreciate it if you could take a few moments to rate your recent order. By doing so, you'll be making a significant impact on our business and helping us serve you and other customers even better.
                </p>
            </div>
            <div style=""flex-basis: 40%; text-align: right;align-items:center;"">
                <img src=""https://assets.bigcartel.com/assets/194010/Beige+Pale+Pink+Modern+Client+Review+Instagram+Post.jpg?w=");
            WriteLiteral("2400&h=2400&fit=clip\" style=\"width: auto; height:260px;margin-right:30px;\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n    <div class=\"order-container\">\r\n");
#nullable restore
#line 61 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
         for (var i = 0; i < ViewBag.UserOrders.Count; i++)
        {
            var order = ViewBag.UserOrders[i];
            var products = ViewBag.OrderProducts[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"order\">\r\n                <div class=\"order-info\">\r\n                    <p><strong>Total Amount Paid:</strong> ");
#nullable restore
#line 68 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
                                                      Write(order.TotalAmountToPay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BAM</p>\r\n                    <p><strong>Delivery Date:</strong> ");
#nullable restore
#line 69 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
                                                  Write(order.DeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>\r\n                        <strong>Delivery Address:</strong> ");
#nullable restore
#line 71 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
                                                      Write(order.Payment.DeliveryAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p><strong>Products:</strong></p>\r\n                    <div class=\"product-container\">\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
                         foreach (var product in products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"product-box\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3140, "\"", 3163, 1);
#nullable restore
#line 78 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
WriteAttributeValue("", 3146, product.ImageUrl, 3146, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3164, "\"", 3183, 1);
#nullable restore
#line 78 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
WriteAttributeValue("", 3170, product.Name, 3170, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image\">\r\n                                <p class=\"product-name\">");
#nullable restore
#line 79 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
                                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 81 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 85 "C:\Users\User\Desktop\FAKULTET\OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Projekat-OOAD\Ayana\Views\Orders\UserOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <div style=\"height:20px;\"></div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
