#pragma checksum "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\_ViewImports.cshtml"
using Progra1BD;

#line default
#line hidden
#line 2 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\_ViewImports.cshtml"
using Progra1BD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70057b8e3bc89ee12b5dbc958d301adcebf8ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Beneficiaries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewSavings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
            BeginContext(39, 34, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            EndContext();
            BeginContext(73, 476, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d47563", async() => {
                BeginContext(79, 463, true);
                WriteLiteral(@"

  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
  <meta name=""description"" content="""">
  <meta name=""author"" content="""">

  <title>Business Frontpage - Start Bootstrap Template</title>

  <!-- Bootstrap core CSS -->
  <link href=""vendor/bootstrap/css/bootstrap-super.css"" rel=""stylesheet"">

  <!-- Custom styles for this template -->
  <link href=""css/business-frontpage.css"" rel=""stylesheet"">

");
                EndContext();
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
            EndContext();
            BeginContext(549, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(551, 7555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d49228", async() => {
                BeginContext(557, 128, true);
                WriteLiteral("\n\n  <!-- Navigation -->\n  <nav class=\"navbar navbar-expand-lg navbar-dark bg-dark fixed-top\">\n    <div class=\"container\">\n      ");
                EndContext();
                BeginContext(685, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d49744", async() => {
                    BeginContext(750, 12, true);
                    WriteLiteral("Banco Verdun");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(766, 409, true);
                WriteLiteral(@"
      <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
      </button>
      <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
      <ul class=""navbar-nav ml-auto"">
          <li class=""nav-item"">
            ");
                EndContext();
                BeginContext(1175, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d411942", async() => {
                    BeginContext(1236, 6, true);
                    WriteLiteral("Inicio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1246, 369, true);
                WriteLiteral(@"
          </li>
          <div class=""dropdown show"">
            <a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Transacciones
            </a>
          
            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
              ");
                EndContext();
                BeginContext(1615, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d414092", async() => {
                    BeginContext(1693, 16, true);
                    WriteLiteral("Estado de Cuenta");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1713, 15, true);
                WriteLiteral("\n              ");
                EndContext();
                BeginContext(1728, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d416087", async() => {
                    BeginContext(1821, 13, true);
                    WriteLiteral("Beneficiarios");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1838, 15, true);
                WriteLiteral("\n              ");
                EndContext();
                BeginContext(1853, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d418079", async() => {
                    BeginContext(1943, 12, true);
                    WriteLiteral("Crear Ahorro");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1959, 79, true);
                WriteLiteral("\n            </div>\n          </div>\n        <li class=\"nav-item\">\n            ");
                EndContext();
                BeginContext(2038, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d420138", async() => {
                    BeginContext(2100, 5, true);
                    WriteLiteral("About");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2109, 857, true);
                WriteLiteral(@"
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""#"">Salir</a>
          </li>
      </ul>
      </div>
    </div>
  </nav>

  <!-- Header -->
<header class=""bg-primary py-5 mb-5"">
  <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
      <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
      <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
      <!-- Slide One - Set the background image for this slide in the line below -->
      <div class=""carousel-item active"" style=""background-image: url('https://source.unsplash.com/RCAhiGJsUUE/1920x1080')"">
        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2966, "\"", 3016, 1);
#line 71 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
WriteAttributeValue("", 2972, Url.Content("~/img/piggy-3608365_1280.jpg"), 2972, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3017, 344, true);
                WriteLiteral(@" alt=""""/>
        <div class=""carousel-caption d-none d-md-block"">
          <h3 class=""display-4"">Ahorra ya!!</h3>
          <p class=""lead"">Ahorrar en Banco Verdun ni se siente.</p>
        </div>
      </div>
      <!-- Slide Two - Set the background image for this slide in the line below -->
      <div class=""carousel-item"" >
        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3361, "\"", 3410, 1);
#line 79 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
WriteAttributeValue("", 3367, Url.Content("~/img/blur-1853262_1280.jpg"), 3367, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3411, 439, true);
                WriteLiteral(@" alt=""""/>
        <div class=""carousel-caption d-none d-md-block"">
          <h3 class=""display-4"">Second Slide</h3>
          <p class=""lead"">Sus datos se encuentran en el lugar más seguro.</p>
        </div>
      </div>
      <!-- Slide Three - Set the background image for this slide in the line below -->
      <div class=""carousel-item"" style=""background-image: url('https://source.unsplash.com/O7fzqFEfLlo/1920x1080')"">
        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3850, "\"", 3899, 1);
#line 87 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
WriteAttributeValue("", 3856, Url.Content("~/img/desk-3139127_1280.jpg"), 3856, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3900, 2410, true);
                WriteLiteral(@" alt=""""/>
        <div class=""carousel-caption d-none d-md-block"">
          <h3 class=""display-4"">Third Slide</h3>
          <p class=""lead"">This is a description for the third slide.</p>
        </div>
      </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
      <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
      <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Next</span>
    </a>
  </div>
</header>

  <!-- Page Content -->
  <div class=""container"">

    <div class=""row"">
      <div class=""col-md-8 mb-5"">
        <h2>Proximamente</h2>
        <hr>
        <p>Todos sus movimientos al alcancer de su mano, multiples clientes, tasas de interes y mucho más</p>
        <p>En Banco Verdun trabajamos de una manera ágil, ");
                WriteLiteral(@"simple e innovadora cultivando relaciones leales y duraderas con nuestros clientes, de manera sostenible a través de todos los productos y servicios digitales, dejando una huella positiva en cada uno de los países donde operamos. Siempre tratando de llevarle lo mejor a sus clientes, nuestra visión es hacía las personas. Por eso trabajamos y pensamos por y hacia ustedes.</p>
        <a class=""btn btn-primary btn-lg"" href=""#"">Call to Action &raquo;</a>
      </div>
      <div class=""col-md-4 mb-5"">
        <h2>Contactanos </h2>
        <hr>
        <address>
          <strong>Verdun S.A</strong>
          <br>Apartamento #8
          <br>Cartago, Costa Rica
          <br>
        </address>
        <address>
          <abbr title=""Telefono Gerente General"">Telefono Gerente General:</abbr>
          (506) 8433-4298
          <br>
          <abbr title=""Telefono Conserje"">Telefono Conserje:</abbr>
                    (506) 8535-0233
                    <br>
          <abbr title=""Email"">Email:</abbr>
          <a");
                WriteLiteral(@" href=""mailto:#"">emacf23@gmail.com</a>
          <br>
          <abbr title=""Email"">Email:</abbr>
          <a href=""mailto:#"">edgari@gmail.com</a>
          <br/>
          
        </address>
      </div>
    </div>
    <!-- /.row -->

    <div class=""row"">
      <div class=""col-md-4 mb-5"">
        <div class=""card h-100"">
          <img class=""card-img-top""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6310, "\"", 6363, 1);
#line 147 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
WriteAttributeValue("", 6316, Url.Content("~/img/workplace-1245776_640.jpg"), 6316, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6364, 274, true);
                WriteLiteral(@"alt="""">
          <div class=""card-body"">
            <h4 class=""card-title"">Proyectos</h4>
            <p class=""card-text"">Proyectos al alcance de tu mano, tu nos expones tus ideas nosotros te ayudamos.</p>
          </div>
          <div class=""card-footer"">
            ");
                EndContext();
                BeginContext(6638, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d428309", async() => {
                    BeginContext(6706, 5, true);
                    WriteLiteral("Dale!");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6715, 148, true);
                WriteLiteral("\n          </div>\n        </div>\n      </div>\n      <div class=\"col-md-4 mb-5\">\n        <div class=\"card h-100\">\n          <img class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6863, "\"", 6915, 1);
#line 159 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
WriteAttributeValue("", 6869, Url.Content("~/img/beverage-3157395_640.jpg"), 6869, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6916, 244, true);
                WriteLiteral(" alt=\"\">\n          <div class=\"card-body\">\n            <h4 class=\"card-title\">Ahorrar es un sueño</h4>\n            <p class=\"card-text\">En Banco Verdun ahorrar, no se siente.</p>\n          </div>\n          <div class=\"card-footer\">\n            ");
                EndContext();
                BeginContext(7160, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d430959", async() => {
                    BeginContext(7240, 14, true);
                    WriteLiteral("Ahorrar ahora!");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7258, 148, true);
                WriteLiteral("\n          </div>\n        </div>\n      </div>\n      <div class=\"col-md-4 mb-5\">\n        <div class=\"card h-100\">\n          <img class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 7406, "\"", 7458, 1);
#line 171 "C:\Users\Emmanuel Castro\RiderProjects\Progra1 Bases\Progra1-Bases\Progra1BD\Views\Home\Index.cshtml"
WriteAttributeValue("", 7412, Url.Content("~/img/business-3152586_640.jpg"), 7412, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7459, 283, true);
                WriteLiteral(@"alt="""">
          <div class=""card-body"">
            <h4 class=""card-title"">Hipoteca</h4>
            <p class=""card-text"">Hipotecar tu casa para pagar el marchamo, nunca había sido tan fácil.Qatar 2022 te espera</p>
          </div>
          <div class=""card-footer"">
            ");
                EndContext();
                BeginContext(7742, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2135bef0e4b5cf8d7bc48206e82d6b6c5cdd51d433653", async() => {
                    BeginContext(7809, 13, true);
                    WriteLiteral("Hipotecar ya!");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7826, 273, true);
                WriteLiteral(@"
          </div>
        </div>
      </div>
    </div>
    <!-- /.row -->

  </div>
  <!-- /.container -->


  <!-- Bootstrap core JavaScript -->
  <script src=""vendor/jquery/jquery.min.js""></script>
  <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

");
                EndContext();
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
            EndContext();
            BeginContext(8106, 10, true);
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
