#pragma checksum "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ccd6d3438324bd13eb631fbb52d69d24c9674d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ccd6d3438324bd13eb631fbb52d69d24c9674d", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0016b6767730c936e45b5440b0aea7bd14cb65d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("details-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 8, true);
            WriteLiteral("\r\n<h1>\r\n");
            EndContext();
#line 8 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
      
        ViewData["PageName"] = "פרטים נוספים";
    

#line default
#line hidden
            BeginContext(152, 11, true);
            WriteLiteral("</h1>\r\n\r\n\r\n");
            EndContext();
            BeginContext(163, 3208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f9c852f9a8748a0b1f7fa096a8b67b4", async() => {
                BeginContext(190, 22, true);
                WriteLiteral("\r\n\r\n    <h3>\r\n        ");
                EndContext();
                BeginContext(213, 45, false);
#line 17 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.Title));

#line default
#line hidden
                EndContext();
                BeginContext(258, 64, true);
                WriteLiteral("\r\n    </h3>\r\n    <br />\r\n\r\n    <h6>מחיר:</h6>\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(323, 45, false);
#line 23 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.Price));

#line default
#line hidden
                EndContext();
                BeginContext(368, 59, true);
                WriteLiteral("\r\n    </p>\r\n\r\n    <h6>פורסם בתאריך:</h6>\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(428, 48, false);
#line 28 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.PostDate));

#line default
#line hidden
                EndContext();
                BeginContext(476, 54, true);
                WriteLiteral("\r\n    </p>\r\n\r\n    <h6>על הרכב:</h6>\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(531, 56, false);
#line 33 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.ShortDescription));

#line default
#line hidden
                EndContext();
                BeginContext(587, 31, true);
                WriteLiteral("\r\n    </p>\r\n\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(619, 55, false);
#line 37 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.LongDescription));

#line default
#line hidden
                EndContext();
                BeginContext(674, 26, true);
                WriteLiteral("\r\n    </p>\r\n    <br />\r\n\r\n");
                EndContext();
#line 41 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
     if (Model.ImageName1 != null)
    {

#line default
#line hidden
                BeginContext(743, 88, true);
                WriteLiteral("        <span class=\"photo-display\">\r\n            <img class=\"img-thumbnail image-style\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 831, "\"", 915, 1);
#line 44 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
WriteAttributeValue("", 837, Url.Action("GetImage", "Product", new { Id = Model.ProductId, imageNum = 1 }), 837, 78, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(916, 23, true);
                WriteLiteral(" /> \r\n        </span>\r\n");
                EndContext();
#line 46 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(946, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
     if (Model.ImageName2 != null)
    {

#line default
#line hidden
                BeginContext(991, 88, true);
                WriteLiteral("        <span class=\"photo-display\">\r\n            <img class=\"img-thumbnail image-style\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1079, "\"", 1163, 1);
#line 51 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
WriteAttributeValue("", 1085, Url.Action("GetImage", "Product", new { Id = Model.ProductId, imageNum = 2 }), 1085, 78, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1164, 22, true);
                WriteLiteral(" />\r\n        </span>\r\n");
                EndContext();
#line 53 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(1193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 55 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
     if (Model.ImageName3 != null)
    {

#line default
#line hidden
                BeginContext(1238, 88, true);
                WriteLiteral("        <span class=\"photo-display\">\r\n            <img class=\"img-thumbnail image-style\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1326, "\"", 1410, 1);
#line 58 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
WriteAttributeValue("", 1332, Url.Action("GetImage", "Product", new { Id = Model.ProductId, imageNum = 3 }), 1332, 78, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1411, 22, true);
                WriteLiteral(" />\r\n        </span>\r\n");
                EndContext();
#line 60 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(1440, 14, true);
                WriteLiteral("\r\n    <br />\r\n");
                EndContext();
#line 63 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
                BeginContext(1502, 28, true);
                WriteLiteral("        <span>\r\n            ");
                EndContext();
                BeginContext(1530, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5957f0b5d63b41ecbf539ae3f98719cb", async() => {
                    BeginContext(1648, 8, true);
                    WriteLiteral("הוסך לסל");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 66 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
                                                                                                    WriteLiteral(Model.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1660, 19, true);
                WriteLiteral("\r\n        </span>\r\n");
                EndContext();
#line 68 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1703, 149, true);
                WriteLiteral("        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalLong\">\r\n            הוסף לסל\r\n        </button>\r\n");
                EndContext();
                BeginContext(1854, 840, true);
                WriteLiteral(@"        <div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">

            <div class=""modal-dialog"" role=""document"">

                <div class=""modal-content"">

                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">הודעה התחברות</h5> 
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>

                    <div class=""modal-body"">
                        עלייך להתחבר על מנת להוסיף פרטים לסל
                    </div>

                    <div class=""modal-footer"">
                        ");
                EndContext();
                BeginContext(2694, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "891689dd82a64536a005979d16f7d9f9", async() => {
                    BeginContext(2769, 5, true);
                    WriteLiteral("אישור");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2778, 90, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 98 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(2875, 22, true);
                WriteLiteral("\r\n    <span>\r\n        ");
                EndContext();
                BeginContext(2897, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3695b83d15e74319bb70fea3e80ddde8", async() => {
                    BeginContext(2943, 8, true);
                    WriteLiteral("מסך ראשי");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2955, 49, true);
                WriteLiteral("\r\n    </span>\r\n    <br />\r\n\r\n    <span>\r\n        ");
                EndContext();
                BeginContext(3005, 54, false);
#line 106 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.User.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(3059, 37, true);
                WriteLiteral("\r\n    </span>\r\n\r\n    <span>\r\n        ");
                EndContext();
                BeginContext(3097, 53, false);
#line 110 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.User.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(3150, 44, true);
                WriteLiteral("\r\n    </span>\r\n\r\n    <span>\r\n        נולד ב ");
                EndContext();
                BeginContext(3195, 54, false);
#line 114 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
          Write(Html.DisplayFor(modelItem => modelItem.User.BirthDate));

#line default
#line hidden
                EndContext();
                BeginContext(3249, 49, true);
                WriteLiteral("\r\n    </span>\r\n\r\n    <span>\r\n        כתובת מייל: ");
                EndContext();
                BeginContext(3299, 50, false);
#line 118 "C:\Users\amith\source\repos\ShoppingCart\ShoppingCart\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(modelItem => modelItem.User.Email));

#line default
#line hidden
                EndContext();
                BeginContext(3349, 15, true);
                WriteLiteral("\r\n    </span>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3371, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
