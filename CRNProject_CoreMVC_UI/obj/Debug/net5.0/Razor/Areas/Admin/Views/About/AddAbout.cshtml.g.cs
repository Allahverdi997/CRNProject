#pragma checksum "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b778203ea130da6b255fcbf79a313f09f0c94012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_About_AddAbout), @"mvc.1.0.view", @"/Areas/Admin/Views/About/AddAbout.cshtml")]
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
#line 1 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml"
using CRNProject_CoreMVC_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b778203ea130da6b255fcbf79a313f09f0c94012", @"/Areas/Admin/Views/About/AddAbout.cshtml")]
    public class Areas_Admin_Views_About_AddAbout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml"
  
    ViewData["Title"] = "AddAbout";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pd-20 card-box mb-30"">
    <div class=""clearfix"">
        <div class=""pull-left"">
            <h4 class=""text-blue h4"">Hakkında Ekle</h4>
            <p class=""mb-30"">Eklenecek Bilgileri Giriniz.</p>
        </div>
    </div>
    <form href=""/Admin/About/AddAbout"" method=""post"" role=""form"" enctype=""multipart/form-data"">
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Dil</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"" name=""LangId"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 772, "\"", 783, 0);
            EndWriteAttribute();
            WriteLiteral(">Seçiniz...</option>\r\n");
#nullable restore
#line 21 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml"
                     foreach (var lang in Model.LangTables)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 921, "\"", 937, 1);
#nullable restore
#line 23 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml"
WriteAttributeValue("", 929, lang.Id, 929, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml"
                                            Write(lang.LangName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "C:\Users\Es-Selamun Aleykum\Desktop\Turkiye Bunyamin Hoca\CRNProject_Github_3\CRNProject_CoreMVC_UI\Areas\Admin\Views\About\AddAbout.cshtml"
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
                <input class=""form-control"" type=""text"" placeholder=""Title Giriniz..."" name=""Title"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Content</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Content Giriniz..."" name=""Content"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Resim/Video URL</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""file"" placeholder=""URL Giriniz..."" name=""formFile"">
            </div>
        </div>
        <div class=""form-group row"">
         ");
            WriteLiteral(@"   <label class=""col-sm-12 col-md-2 col-form-label"">Resim/Video Alt</label>
            <div class=""col-sm-12 col-md-10"">
                <input class=""form-control"" type=""text"" placeholder=""Alt Giriniz..."" name=""ImageVideoAlt"">
            </div>
        </div>
        <div class=""form-group row"">
            <label class=""col-sm-12 col-md-2 col-form-label"">Aktif Durumu</label>
            <div class=""col-sm-12 col-md-10"">
                <select class=""custom-select col-12"" name=""IsActive"">
                    <option");
            BeginWriteAttribute("selected", " selected=\"", 2545, "\"", 2556, 0);
            EndWriteAttribute();
            WriteLiteral(@">Seçiniz...</option>
                    <option value=""1"">Aktif</option>
                    <option value=""2"">Pasif</option>
                </select>
            </div>
        </div>
        <div>
            <button type=""submit"" class=""btn btn-primary btn-lg"">Ekle</button>
        </div>
    </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
