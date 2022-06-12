#pragma checksum "/Users/elif/Downloads/TSEasyStockManager-master/TS.EasyStockManager.Web/Views/Shared/_SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3559478130c67a0ecf332bf92a12cffb0244b4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/_SidebarPartial.cshtml")]
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
#line 1 "/Users/elif/Downloads/TSEasyStockManager-master/TS.EasyStockManager.Web/Views/_ViewImports.cshtml"
using TS.EasyStockManager.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/elif/Downloads/TSEasyStockManager-master/TS.EasyStockManager.Web/Views/_ViewImports.cshtml"
using TS.EasyStockManager.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3559478130c67a0ecf332bf92a12cffb0244b4d", @"/Views/Shared/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0c103975936d0c3d5e68c7f4cc24b25708f6c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""mt-2"">
    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">

        <li class=""nav-header"">Stock</li>
        <li class=""nav-item"">
            <a href=""/Transaction"" class=""nav-link"">
                <i class=""nav-icon fas fa-truck""></i>
                <p>Transactions</p>
            </a>
        </li>
        <li class=""nav-header"">Report</li>
        <li class=""nav-item"">
            <a href=""/Report/StoreStockReport"" class=""nav-link"">
                <i class=""nav-icon fas fa-building""></i>
                <p>Store Stock</p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/Report/TransactionDetailReport"" class=""nav-link"">
                <i class=""nav-icon fas fa-list-alt""></i>
                <p>Transaction Detail</p>
            </a>
        </li>

        <li class=""nav-header"">Definitions</li>
        <li class=""nav-item"">
            <a href=""/Category"" class=""nav-link"">
                <i clas");
            WriteLiteral(@"s=""nav-icon fas fa-folder""></i>
                <p>
                    Category
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/UnitOfMeasure"" class=""nav-link"">
                <i class=""nav-icon fas fa-box-open""></i>
                <p>
                    Units
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/Product"" class=""nav-link"">
                <i class=""nav-icon fas fa-barcode""></i>
                <p>
                    Product
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/Store"" class=""nav-link"">
                <i class=""nav-icon fas fa-building""></i>
                <p>
                    Store
                </p>
            </a>
        </li>
        <li class=""nav-item"">
            <a href=""/User"" class=""nav-link"">
                <i class=""nav-icon fas fa-user""></i>
                <p>
                    User
          ");
            WriteLiteral(@"      </p>
            </a>
        </li>
        <li class=""nav-header""></li>
        <li class=""nav-item"">
            <a href=""/Auth/Logout"" class=""nav-link"">
                <i class=""nav-icon fas fa-sign-out-alt""></i>
                <p>
                    Logout
                </p>
            </a>
        </li>

    </ul>
</nav>");
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
