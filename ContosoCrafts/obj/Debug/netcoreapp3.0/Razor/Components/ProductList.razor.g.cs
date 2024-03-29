#pragma checksum "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2758deb6db4395b87a3bcccd49904ae4c9faa93c"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
using ContosoCrafts.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
using ContosoCrafts.Services;

#line default
#line hidden
#nullable disable
    public class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:url(\'" + (
#nullable restore
#line 12 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                                product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 14 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                             product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", " card-footer");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "small");
            __builder.AddAttribute(25, "class", "text-muted");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                      (e=> SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "data-target", "#productModal");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddMarkupContent(32, "\r\n                        More Info\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 28 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n");
#nullable restore
#line 34 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal fade");
            __builder.AddAttribute(42, "id", "productModal");
            __builder.AddAttribute(43, "tabindex", "-1");
            __builder.AddAttribute(44, "role", "dialog");
            __builder.AddAttribute(45, "aria-labelledby", "productTitle");
            __builder.AddAttribute(46, "aria-hidden", "true");
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(50, "role", "document");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal-content");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-header");
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "h5");
            __builder.AddAttribute(59, "class", "modal-title");
            __builder.AddAttribute(60, "id", "productTitle");
            __builder.AddContent(61, 
#nullable restore
#line 40 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.AddMarkupContent(63, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-body");
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card");
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "card-img");
            __builder.AddAttribute(73, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 47 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "card-body");
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "p");
            __builder.AddAttribute(80, "class", "card-text");
            __builder.AddContent(81, 
#nullable restore
#line 50 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "modal-footer");
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 55 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                     if (voteCount == 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                            ");
            __builder.AddMarkupContent(90, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 58 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "                            ");
            __builder.OpenElement(92, "span");
            __builder.AddContent(93, 
#nullable restore
#line 61 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                   voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " ");
            __builder.AddContent(95, 
#nullable restore
#line 61 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                              voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 62 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                         for (int i = 1; i < 6; i++)
                        {
                            var currentStar = i;
                            if (i <= currentRating)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                                ");
            __builder.OpenElement(98, "span");
            __builder.AddAttribute(99, "class", "fa fa-star checked");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                                           (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 69 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "                                ");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "class", "fa fa-star");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                                                                   (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 73 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 79 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\peter.LINCOLN\source\repos\ContosoCrafts\ContosoCrafts\Components\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string ProductId)
    {
        selectedProductId = ProductId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == ProductId);
        GetCurrentRating();
    }
    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if(selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }
        System.Console.WriteLine($"Current rating for {selectedProduct.Id}:{currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Current received for {selectedProduct.Id}:{rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
