#pragma checksum "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\Dashboard\Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e0d0e68224c29d47845246e3e1d8e15864ba85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Slider), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Slider.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e0d0e68224c29d47845246e3e1d8e15864ba85", @"/Areas/Admin/Views/Dashboard/Slider.cshtml")]
    public class Areas_Admin_Views_Dashboard_Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\Dashboard\Slider.cshtml"
  
    ViewBag.Title = "Slider";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-box mb-30"">
    <h2 class=""h4 pd-20"">Slider Detayları</h2>
    <table class=""data-table table nowrap"">
        <thead>
            <tr>
                <th class=""table-plus datatable-nosort"">Slider Önizleme</th>
                <th>Dil</th>
                <th>Slider URL</th>
                <th>Slider ALT</th>
                <th>Title</th>
                <th>Content</th>
                <th>Sayfa URL</th>
                <th>Aktif Durumu</th>
                <th class=""datatable-nosort"">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class=""table-plus"">
                    <img src=""/Context/Admin/vendors/images/product-1.jpg"" width=""70"" height=""70""");
            BeginWriteAttribute("alt", " alt=\"", 857, "\"", 863, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
                <td>İngilizce</td>
                <td>SliderLinki</td>
                <td>SliderAltMetni</td>
                <td>TitleBilgisi</td>
                <td>ContentBilgisi</td>
                <td>SayfaUrl</td>
                <td><span class=""badge badge-danger"">Pasif</span></td>
                <td>
                    <div class=""dropdown"">
                        <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                            <i class=""dw dw-more""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Düzenle</a>
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Sil</a>
                        </div>
                    </div>
                </td>
            ");
            WriteLiteral("</tr>\r\n            <tr>\r\n                <td class=\"table-plus\">\r\n                    <img src=\"/Context/Admin/vendors/images/product-2.jpg\" width=\"70\" height=\"70\"");
            BeginWriteAttribute("alt", " alt=\"", 2051, "\"", 2057, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </td>
                <td>Türkçe</td>
                <td>SliderLinki</td>
                <td>SliderAltMetni</td>
                <td>TitleBilgisi</td>
                <td>ContentBilgisi</td>
                <td>SayfaUrl</td>
                <td><span class=""badge badge-primary"">Aktif</span></td>
                <td>
                    <div class=""dropdown"">
                        <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                            <i class=""dw dw-more""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Düzenle</a>
                            <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Sil</a>
                        </div>
                    </div>
                </td>
            </");
            WriteLiteral("tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
