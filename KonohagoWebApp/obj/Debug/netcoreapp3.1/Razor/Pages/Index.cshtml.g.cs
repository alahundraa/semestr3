#pragma checksum "C:\Users\Workstation\Desktop\WebProject\Project_404\KonohagoWebApp\KonohagoWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198b64d7300d176531f03e65b6ce080e865fe2c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KonohagoWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace KonohagoWebApp.Pages
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
#line 1 "C:\Users\Workstation\Desktop\WebProject\Project_404\KonohagoWebApp\KonohagoWebApp\Pages\_ViewImports.cshtml"
using KonohagoWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Workstation\Desktop\WebProject\Project_404\KonohagoWebApp\KonohagoWebApp\Pages\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198b64d7300d176531f03e65b6ce080e865fe2c5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5677f98e61f3f07d3913f1bdc6dcd37fddbcb129", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Workstation\Desktop\WebProject\Project_404\KonohagoWebApp\KonohagoWebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "MainPage";
    var name = ViewData["name"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198b64d7300d176531f03e65b6ce080e865fe2c53511", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/mainPage.css\" type=\"text/css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198b64d7300d176531f03e65b6ce080e865fe2c54557", async() => {
                WriteLiteral("\r\n    <h1 class=\"display-4\">Добро пожаловать, ");
#nullable restore
#line 12 "C:\Users\Workstation\Desktop\WebProject\Project_404\KonohagoWebApp\KonohagoWebApp\Pages\Index.cshtml"
                                       Write(name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </h1>
    <section class=""hero-area"">
        <div class=""hero-padding"">
            <div class=""container"">
                <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img src=""https://sun9-67.userapi.com/yXOtXGNgNiKESaP4sPjoCBTqSQ3J58rKY_qWcg/ZRdwg47anCk.jpg"" class=""d-block w-100"" alt=""..."">
                        </div>
                        <div class=""carousel-item"">
                            <img src=""https://www.cinepremiere.com.mx/wp-content/uploads/2019/06/danmachi2.jpg"" class=""d-block w-100"" alt=""..."">
                        </div>
                        <div class=""carousel-item"">
                            <img src=""https://www.cinepremiere.com.mx/wp-content/uploads/2019/05/Made-in-Abyss.jpg"" class=""d-block w-100"" alt=""..."">
                        </div>
                    </div>
                    <a");
                WriteLiteral(@" class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>
    </section>
    <section class=""out-services"">
        <div class=""service-padding"">
            <div class=""container"">
                <div class=""all-title"">
                    <h2>Konohago -</h2>
                </div>
                <div class=""row"">
                    <div class=""col-md-3 col-sm-6"">
                        <div class=""service-item"">
              ");
                WriteLiteral("              <img class=\"img-fluid\" src=\"https://img.icons8.com/dusk/2x/1-circle.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2419, "\"", 2425, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <h4>Уникальность</h4>
                            <p>Ресурс, на котором контент создаётся, а не ""заимствуется""</p>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-12"">
                        <div class=""service-item"">
                            <img class=""img-fluid"" src=""https://img.icons8.com/dusk/2x/money.png""");
                BeginWriteAttribute("alt", " alt=\"", 2843, "\"", 2849, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <h4>Доступность</h4>
                            <p>""Всё в одном месте"" - все самые интересные новости, возможность оценки, комментирования тайтлов и прочий читабельный хлам</p>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-12"">
                        <div class=""service-item"">
                            <img class=""img-fluid"" src=""https://img.icons8.com/dusk/2x/old-woman-skin-type-1-2.png""");
                BeginWriteAttribute("alt", " alt=\"", 3348, "\"", 3354, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <h4>Практичность</h4>
                            <p>Разеберется даже твоя бабушка</p>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-12"">
                        <div class=""service-item"">
                            <img class=""img-fluid"" src=""https://img.icons8.com/dusk/2x/heart-with-mouse.png""");
                BeginWriteAttribute("alt", " alt=\"", 3755, "\"", 3761, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <h4>Душевность</h4>\r\n                            <p>Всё делается с любовью</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
