#pragma checksum "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62e4260617c76920aea85554026ad02fc771da3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_OrderSuccess), @"mvc.1.0.view", @"/Views/ShoppingCart/OrderSuccess.cshtml")]
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
#line 1 "D:\MultiKartt\MultiKartt\Views\_ViewImports.cshtml"
using MultiKartt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MultiKartt\MultiKartt\Views\_ViewImports.cshtml"
using MultiKartt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MultiKartt\MultiKartt\Views\_ViewImports.cshtml"
using Domains;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e4260617c76920aea85554026ad02fc771da3e", @"/Views/ShoppingCart/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25edcd0fdda20074ff8f69922b4dd3b63d5fc380", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_OrderSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopingCart>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e4260617c76920aea85554026ad02fc771da3e3257", async() => {
                WriteLiteral(@"



    <!-- thank-you section start -->
    <section class=""section-b-space light-layout"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""success-text"">
                        <i class=""fa fa-check-circle"" aria-hidden=""true""></i>
                        <h2>thank you ");
#nullable restore
#line 18 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                 Write(ViewBag.first);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                        <p>Payment is successfully processsed and your order is on the way</p>
                        <p>Transaction ID:267676GHERT105467</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Section ends -->
    <!-- order-detail section start -->
    <section class=""section-b-space"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""product-order"">
                        <h3>your order details</h3>
                        <div class=""row product-order-detail"">
");
#nullable restore
#line 35 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                             foreach (var item in Model.ListItems)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-3\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1290, "\"", 1341, 1);
#nullable restore
#line 38 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
WriteAttributeValue("", 1296, string.Format("/Uploads/{0}",item.ImageName), 1296, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1342, "\"", 1348, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                         class=""img-fluid blur-up lazyload"">
                                </div>
                                <div class=""col-3 order_detail"">
                                    <div>
                                        <h4>product name </h4>
                                        <h5>");
#nullable restore
#line 44 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                       Write(item.ItemName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                    </div>
                                </div>
                                <div class=""col-3 order_detail"">
                                    <div>
                                        <h4>quantity</h4>
                                        <h5>");
#nullable restore
#line 50 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                       Write(item.Qty);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                    </div>
                                </div>
                                <div class=""col-3 order_detail"">
                                    <div>
                                        <h4>price</h4>
                                        <h5>");
#nullable restore
#line 56 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                       Write(item.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</h5>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 59 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n                        <div class=\"total-sec\">\r\n                            <ul>\r\n                                <li>subtotal <span>");
#nullable restore
#line 64 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                              Write(Model.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"$</span></li>
                                <li>shipping <span>$0.00</span></li>
                                <li>tax(GST) <span>$0.00</span></li>
                            </ul>
                        </div>
                        <div class=""final-total"">
                            <h3>total <span>");
#nullable restore
#line 70 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                       Write(Model.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"$</span></h3>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""row order-success-sec"">
                        <div class=""col-sm-6"">
                            <h4>summery</h4>
                            <ul class=""order-detail"">
                                <li>order ID: 5563853658932</li>
                                <li>Order Date: October 15, 2021</li>
");
                WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""col-sm-6"">
                            <h4>shipping address</h4>
                            <ul class=""order-detail"">
                                <li>");
#nullable restore
#line 87 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                               Write(ViewBag.first);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 87 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                              Write(ViewBag.last);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li> ");
#nullable restore
#line 88 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                Write(ViewBag.address);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\r\n                                <li>");
#nullable restore
#line 89 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                               Write(ViewBag.country);

#line default
#line hidden
#nullable disable
                WriteLiteral(" , ");
#nullable restore
#line 89 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                                  Write(ViewBag.postcode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li>Contact No. ");
#nullable restore
#line 90 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\OrderSuccess.cshtml"
                                           Write(ViewBag.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                            </ul>
                        </div>
                        <div class=""col-sm-12 payment-mode"">
                            <h4>payment method</h4>
                            <p>
                                Pay on Delivery (Cash/Card). Cash on delivery (COD) available. Card/Net banking
                                acceptance subject to device availability.
                            </p>
                        </div>
                        <div class=""col-md-12"">
                            <div class=""delivery-sec"">
                                <h3>expected date of delivery</h3>
                                <h2>october 22, 2021</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Section ends -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591