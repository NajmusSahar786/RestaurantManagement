#pragma checksum "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\Shared\Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b9acb6349264c6b394356cb1a08a812183f5794f5c1f52b820d974a2ad9254b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\_ViewImports.cshtml"
using RestaurantManagement.ViewModels;

#nullable disable
#nullable restore
#line 2 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\_ViewImports.cshtml"
using RestaurantManagement.Models;

#nullable disable
#nullable restore
#line 3 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b9acb6349264c6b394356cb1a08a812183f5794f5c1f52b820d974a2ad9254b8", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1cb1b4d55f24336a358247f316f0459c43efbd82d3d3b7cf3f5f82d750274ed8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\Shared\Error.cshtml"
 if (ViewBag.ErrorTitle == null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("<h3>\r\n    An occured while processing your request. The support\r\n    team is notified and we are working on the fix\r\n</h3>\r\n<h5>Please contact us on pragim@pragimtech.com</h5>\r\n<hr />\r\n");
#nullable restore
#line 27 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\Shared\Error.cshtml"
            

}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h1 class=\"text-danger\">");
            Write(
#nullable restore
#line 32 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\Shared\Error.cshtml"
                             ViewBag.ErrorTitle

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n    <h6 class=\"text-danger\">");
            Write(
#nullable restore
#line 33 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\Shared\Error.cshtml"
                             ViewBag.ErrorMessage

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 34 "D:\Projects\netCore\RestaurantManagement\RestaurantManagement\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable

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
