#pragma checksum "C:\Users\kadirari\Desktop\Freelance\CRNProject\CRNProject_CoreMVC_UI\Areas\Admin\Views\Dashboard\AltIndustry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f1f2b48c0cb6f0b7dfb7753af130bf5c570f5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_AltIndustry), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/AltIndustry.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f1f2b48c0cb6f0b7dfb7753af130bf5c570f5ab", @"/Areas/Admin/Views/Dashboard/AltIndustry.cshtml")]
    public class Areas_Admin_Views_Dashboard_AltIndustry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kadirari\Desktop\Freelance\CRNProject\CRNProject_CoreMVC_UI\Areas\Admin\Views\Dashboard\AltIndustry.cshtml"
  
    ViewBag.Title = "AltIndustry";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-box mb-30"">
    <h2 class=""h4 pd-20"">Alt Endüstri Detayları</h2>
    <table class=""data-table table nowrap"">
        <thead>
            <tr>
                <th>Dil</th>
                <th>Ana Ürün</th>
                <th>Title</th>
                <th>Content1</th>
                <th>Content2</th>
                <th>Content3</th>
                <th>Content4</th>
                <th>Aktif Durumu</th>
                <th class=""datatable-nosort"">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>İngilizce</td>
                <td>AnaÜrünAdı</td>
                <td>TitleBilgisi</td>
                <td>Content1Bilgisi</td>
                <td>Content2Bilgisi</td>
                <td>Content3Bilgisi</td>
                <td>Content4Bilgisi</td>
                <td><span class=""badge badge-danger"">Pasif</span></td>
                <td>
                    <div class=""dropdown"">
                        <a class");
            WriteLiteral(@"=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                            <i class=""dw dw-more""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Düzenle</a>
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Sil</a>
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td>İngilizce</td>
                <td>AnaÜrünAdı</td>
                <td>TitleBilgisi</td>
                <td>Content1Bilgisi</td>
                <td>Content2Bilgisi</td>
                <td>Content3Bilgisi</td>
                <td>Content4Bilgisi</td>
                <td><span class=""badge badge-primary"">Aktif</span></td>
                <td>
                    <div c");
            WriteLiteral(@"lass=""dropdown"">
                        <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                            <i class=""dw dw-more""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Düzenle</a>
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Sil</a>
                        </div>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</div>
");
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
