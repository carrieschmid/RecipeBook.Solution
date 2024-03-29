#pragma checksum "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540cd4ddc7a1e08e7e8d2e1127c7c6d220110028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Index), @"mvc.1.0.view", @"/Views/Recipe/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/Index.cshtml", typeof(AspNetCore.Views_Recipe_Index))]
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
#line 1 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/_ViewImports.cshtml"
using RecipeBook;

#line default
#line hidden
#line 5 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
using RecipeBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540cd4ddc7a1e08e7e8d2e1127c7c6d220110028", @"/Views/Recipe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f55e906a5633bee239e13d6bf3a32417c57e856", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(75, 20, true);
            WriteLiteral("\n<h2>Recipes</h2>\n\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(115, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
     foreach (Recipe recipe in Model)
    {

#line default
#line hidden
            BeginContext(166, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(177, 92, false);
#line 16 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
     Write(Html.ActionLink($"{recipe.Name} |{recipe.Rating}" , "Details", new { id = recipe.RecipeId }));

#line default
#line hidden
            EndContext();
            BeginContext(269, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(281, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
  
}
else
{

#line default
#line hidden
            BeginContext(301, 41, true);
            WriteLiteral("  <h3>No items have been added yet!</h3>\n");
            EndContext();
#line 24 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
}

#line default
#line hidden
            BeginContext(344, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(349, 43, false);
#line 26 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
Write(Html.ActionLink("Add new recipe", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(392, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(402, 40, false);
#line 28 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Recipe/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(442, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
