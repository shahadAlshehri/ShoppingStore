#pragma checksum "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae054a4784fe75568fa43413cb7f7cfbfa3369ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\_ViewImports.cshtml"
using ShoppingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\_ViewImports.cshtml"
using ShoppingProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae054a4784fe75568fa43413cb7f7cfbfa3369ca", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9ef12efd708238457a5a8766dd1c899ce41b61", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\Products\Details.cshtml"
  
    var Product = (ProductModel)ViewData["products"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-hover"" style=""background-color:white; box-shadow: 3px 5px #7c9473; "">
    <thead>
        <tr>
            <th scope=""col""style=""color: #064420; font-size:40px"">Product</th>
            <th scope=""col""style=""color: #064420; font-size:40px"">Price</th>
        </tr>
    </thead>

    <tbody>
        
            <tr>
               
                <td style=""color: #064420; font-size: 30px ""> ");
#nullable restore
#line 17 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\Products\Details.cshtml"
                                                         Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td style=\" color: #064420;font-size:30px\">");
#nullable restore
#line 18 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\Products\Details.cshtml"
                                                      Write(Product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SR</td>\r\n                <td><img style=\"width:300px; height:300px\"");
            BeginWriteAttribute("src", " src=", 659, "", 678, 1);
#nullable restore
#line 19 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\Products\Details.cshtml"
WriteAttributeValue("", 664, Product.Image, 664, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 678, "\"", 699, 2);
#nullable restore
#line 19 "C:\Users\Shaha\source\repos\ShoppingProject\ShoppingProject\Views\Products\Details.cshtml"
WriteAttributeValue("", 684, Product.Image, 684, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 698, "", 699, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n\r\n       \r\n\r\n\r\n    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
