#pragma checksum "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c8923e028b9ee3d4bd1c85ce69f8ca7670e4681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FavoritePartial), @"mvc.1.0.view", @"/Views/Shared/_FavoritePartial.cshtml")]
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
#line 1 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\_ViewImports.cshtml"
using Dot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\_ViewImports.cshtml"
using Dot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c8923e028b9ee3d4bd1c85ce69f8ca7670e4681", @"/Views/Shared/_FavoritePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056b31fd52cc3d80272d078dc123f41d2bf2ea0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FavoritePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dot.Services.Models.UserVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml"
   
    var user = Model;
    var userId = user.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml"
 if (Model.IsFavorite)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <i class=\"fa fa-star\"");
            BeginWriteAttribute("onclick", " onclick=\"", 140, "\"", 174, 3);
            WriteAttributeValue("", 150, "ToggleFavorite(", 150, 15, true);
#nullable restore
#line 10 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml"
WriteAttributeValue("", 165, userId, 165, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 172, ");", 172, 2, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n");
#nullable restore
#line 11 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <i class=\"fa fa-star opacity25\"");
            BeginWriteAttribute("onclick", " onclick=\"", 225, "\"", 259, 3);
            WriteAttributeValue("", 235, "ToggleFavorite(", 235, 15, true);
#nullable restore
#line 14 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml"
WriteAttributeValue("", 250, userId, 250, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 257, ");", 257, 2, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n");
#nullable restore
#line 15 "C:\Users\priya\source\repos\Priu\Assignment\dotnet-webapp\Dot\Views\Shared\_FavoritePartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">

    function ToggleFavorite(userId) {
        $.ajax({
            method: 'GET',
            url: ""/Home/ToggleFavorite?id="" + userId,
            success: function () {
                window.location.reload();
            },
            error: function () {
                alert(""Sorry! An error occourred when attempting to set favorite for this user"");
            }
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dot.Services.Models.UserVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
