#pragma checksum "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c93e319d5961c928763ab395c3187b8441e5edb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_About_UpdateAbout), @"mvc.1.0.view", @"/Areas/Admin/Views/About/UpdateAbout.cshtml")]
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
#line 1 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
using CRNProject_CoreMVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c93e319d5961c928763ab395c3187b8441e5edb5", @"/Areas/Admin/Views/About/UpdateAbout.cshtml")]
    public class Areas_Admin_Views_About_UpdateAbout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
  
    ViewData["Title"] = "UpdateAbout";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pd-20 card-box mb-30"">
    <div class=""clearfix"">
        <div class=""pull-left"">
            <h4 class=""text-blue h4"">Hakkında Güncelle</h4>
            <p class=""mb-30"">Güncellenecek Bilgileri Giriniz.</p>
        </div>
    </div>
    <form href=""/Admin/About/UpdateAbout"" method=""post"" role=""form"" enctype=""multipart/form-data"">
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Dil</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"" name=""LangId"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 786, "\"", 797, 0);
            EndWriteAttribute();
            WriteLiteral(">Seçiniz...</option>\r\n");
#nullable restore
#line 21 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                     foreach (var lang in Model.LangTables)
                    {
                        if (lang.Id == ViewBag.Language)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option selected");
            BeginWriteAttribute("value", " value=\"", 1033, "\"", 1049, 1);
#nullable restore
#line 25 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 1041, lang.Id, 1041, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                                                         Write(lang.LangName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 26 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1195, "\"", 1211, 1);
#nullable restore
#line 29 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 1203, lang.Id, 1203, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                                                Write(lang.LangName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 30 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Title</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1569, "\"", 1595, 1);
#nullable restore
#line 39 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 1577, Model.About.Title, 1577, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Title"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Content</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1866, "\"", 1894, 1);
#nullable restore
#line 45 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 1874, Model.About.Content, 1874, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Content"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Resim/Video URL</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""file""");
            BeginWriteAttribute("value", " value=\"", 2175, "\"", 2209, 1);
#nullable restore
#line 51 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 2183, Model.About.ImageVideoURL, 2183, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"formFile\">\r\n            </div>\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2281, "\"", 2315, 1);
#nullable restore
#line 53 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 2289, Model.About.ImageVideoURL, 2289, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""ImageVideoURL"" />
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Resim/Video Alt</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 2584, "\"", 2618, 1);
#nullable restore
#line 58 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 2592, Model.About.ImageVideoAlt, 2592, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"ImageVideoAlt\">\r\n            </div>\r\n        </div>\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2707, "\"", 2730, 1);
#nullable restore
#line 61 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
WriteAttributeValue("", 2715, Model.About.Id, 2715, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Id""/>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Aktif Durumu</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"" name=""IsActive"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 3011, "\"", 3022, 0);
            EndWriteAttribute();
            WriteLiteral(">Seçiniz...</option>\r\n");
#nullable restore
#line 67 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                     if (Model.About.IsActive == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option selected value=\"true\">Aktif</option>\r\n                        <option value=\"false\">Pasif</option>\r\n");
#nullable restore
#line 71 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option value=\"true\">Aktif</option>\r\n                        <option selected value=\"false\">Pasif</option>\r\n");
#nullable restore
#line 76 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\UpdateAbout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <button type=\"submit\" class=\"btn btn-primary btn-lg\">Güncelle</button>\r\n        </div>\r\n    </form>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
