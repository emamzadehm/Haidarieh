#pragma checksum "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\Shared\Components\UpComming\_UpComming.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26022f8aa693c5d676c6bc99d0181e670dec165"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UpComming__UpComming), @"mvc.1.0.view", @"/Views/Shared/Components/UpComming/_UpComming.cshtml")]
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
#line 1 "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\_ViewImports.cshtml"
using WebApplicationEFCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\_ViewImports.cshtml"
using WebApplicationEFCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26022f8aa693c5d676c6bc99d0181e670dec165", @"/Views/Shared/Components/UpComming/_UpComming.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3f425e4f52dfa347cf6089dafd4621d942de35", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UpComming__UpComming : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CeremonyGuest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CeremonyGuest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <div class=""gap thm-layer opc95"">
            <div class=""fixed-bg ptrn-bg"" style=""background-image: url(assets/images/pattern-bg.jpg);""></div>
            <div class=""container"">
                <div class=""sec-title2 text-center"">
                    <div class=""sec-title-inner2"">
                        <span>مراسم</span>
                        <h3>مراسم پیش رو</h3>
                    </div>
                </div>
                <div class=""team-wrap text-center remove-ext3"">
                    <div class=""row"">
");
#nullable restore
#line 13 "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\Shared\Components\UpComming\_UpComming.cshtml"
                         foreach (var ceremony in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-3 col-sm-6 col-lg-3 fadeIn"" data-wow-duration="".8s"" data-wow-delay="".2s"">
                                <div class=""team-box2"">
                                    <img class=""rounded-pill mx-auto d-block""");
            BeginWriteAttribute("src", " src=", 913, "", 933, 1);
#nullable restore
#line 17 "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\Shared\Components\UpComming\_UpComming.cshtml"
WriteAttributeValue("", 918, ceremony.Image, 918, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\">\r\n                                    <div class=\"team-info2\">\r\n                                        <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f26022f8aa693c5d676c6bc99d0181e670dec1655443", async() => {
#nullable restore
#line 19 "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\Shared\Components\UpComming\_UpComming.cshtml"
                                                                                            Write(ceremony.Ceremony.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h4>
                                        <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است.</p>
                                        <div class=""team-scl"">
                                            <a href=""index.html#"" title=""توییتر"" target=""_blank""><i class=""fa fa-twitter""></i></a>
                                            <a href=""index.html#"" title=""اینستاگرام"" target=""_blank""><i class=""fa fa-instagram""></i></a>
                                            <a href=""index.html#"" title=""گوگل پلاس"" target=""_blank""><i class=""fa fa-google-plus""></i></a>
                                            <a href=""index.html#"" title=""فیسبوک"" target=""_blank""><i class=""fa fa-facebook""></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 30 "F:\NetCoreProjects\repos\WebApplicationEFCore\Views\Shared\Components\UpComming\_UpComming.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div><!-- Team Wrap -->\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CeremonyGuest>> Html { get; private set; }
    }
}
#pragma warning restore 1591