#pragma checksum "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90b1d7a4f46344128f0283b6ca1fae852a090d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Cart), @"mvc.1.0.view", @"/Views/ShoppingCart/Cart.cshtml")]
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
#nullable restore
#line 3 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b1d7a4f46344128f0283b6ca1fae852a090d4", @"/Views/ShoppingCart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25edcd0fdda20074ff8f69922b4dd3b63d5fc380", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90b1d7a4f46344128f0283b6ca1fae852a090d45817", async() => {
                WriteLiteral(@"


    <!-- breadcrumb start -->
    <div class=""breadcrumb-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""page-title"">
                        <h2>cart</h2>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <nav aria-label=""breadcrumb"" class=""theme-breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">cart</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb End -->
");
#nullable restore
#line 36 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
     if (Model.ListItems.Count > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!--section start-->
        <section class=""cart-section section-b-space"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <table class=""table cart-table table-responsive-xs"">
                            <thead>
                                <tr class=""table-head"">
                                    <th scope=""col"">image</th>
                                    <th scope=""col"">product name</th>
                                    <th scope=""col"">price</th>
                                    <th scope=""col"">Remove</th>
                                    <th scope=""col"">Quantity</th>
                                    <th scope=""col"">total</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 56 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                 foreach (var item in Model.ListItems)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90b1d7a4f46344128f0283b6ca1fae852a090d48445", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 2264, "\"", 2316, 1);
#nullable restore
#line 60 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
WriteAttributeValue("", 2270, string.Format("/Uploads/{0}", item.ImageName), 2270, 46, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", " alt=\"", 2317, "\"", 2323, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                                                               WriteLiteral(item.ItemId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90b1d7a4f46344128f0283b6ca1fae852a090d411598", async() => {
#nullable restore
#line 63 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                                                                                    Write(item.ItemName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                                                               WriteLiteral(item.ItemId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <div class=\"mobile-cart-content row\">\r\n");
                WriteLiteral("                                                <div class=\"col-xs-3\">\r\n                                                    <h2 class=\"td-color\">");
#nullable restore
#line 74 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"$</h2>
                                                </div>


                                            </div>
                                        </td>
                                        <td>
                                            <h2>");
#nullable restore
#line 81 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</h2>\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90b1d7a4f46344128f0283b6ca1fae852a090d415550", async() => {
                    WriteLiteral("  <i class=\"ti-close\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                                                      WriteLiteral(item.ItemId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </td>
                                        <td>
                                            <div class=""qty-box"">
                                                <div class=""input-group"">
                                                    <input type=""number"" name=""quantity"" class=""cartInput""
                                                           data-price=""");
#nullable restore
#line 91 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" onkeyup=\"ChangeQty(this);\"");
                BeginWriteAttribute("value", " value=\"", 4488, "\"", 4505, 1);
#nullable restore
#line 91 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
WriteAttributeValue("", 4496, item.Qty, 4496, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                </div>
                                            </div>
                                        </td>

                                        <td>
                                            <h2 class=""td-color"">");
#nullable restore
#line 97 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                                            Write(item.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</h2>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 100 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>

                        </table>
                        <table class=""table cart-table table-responsive-md"">
                            <tfoot>
                                <tr>
                                    <td>total price :</td>
                                    <td id=""total1"">

                                        <h2> ");
#nullable restore
#line 110 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                                        Write(Model.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"$</h2>
                                    </td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                </div>
                <div class=""row cart-buttons"">
                    <div class=""col-6""><a href=""/Home/All"" class=""btn btn-solid"">continue shopping</a></div>
                    <div class=""col-6"">
");
#nullable restore
#line 120 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90b1d7a4f46344128f0283b6ca1fae852a090d421173", async() => {
                    WriteLiteral("check out");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 123 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/Identity/Account/Login\" class=\"btn btn-solid\">check out</a>\r\n");
#nullable restore
#line 127 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n        <!--section end-->\r\n");
#nullable restore
#line 135 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <section class=""p-0"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""error-section"">
                            <h2>Cart Is Empty</h2>
                            <a href=""/Home/All"" class=""btn btn-solid"">Go Shopping</a>
                            <a href=""/Home/Index"" class=""btn btn-solid"">back to home</a>

                        </div>
                    </div>
                </div>
            </div>
        </section>
");
#nullable restore
#line 152 "D:\MultiKartt\MultiKartt\Views\ShoppingCart\Cart.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function ChangeQty(input) {
            console.log(""enter functiom"");
            let price = parseFloat($(input).data(""price""));
            console.log(price);
            $(input).closest(""td"").next(""td"").html(price * parseFloat($(input).val()));
            UpdateTotals();
        }
        function UpdateTotals() {
            let total = 0;
            $("".cartInput"").each(function (index, element) {
                total = total + parseFloat($(element).val()) * parseFloat($(element).data(""price""));
            });
            $(""#total1"").html(total);
            // $(""#total2"").html(total);
            // $(""#total3"").html(total);
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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