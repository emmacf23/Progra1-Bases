#pragma checksum "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbe38038df67d49161095a927ea35c4eb38e5b15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_ObjetiveAccount), @"mvc.1.0.view", @"/Views/Transaction/ObjetiveAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/ObjetiveAccount.cshtml", typeof(AspNetCore.Views_Transaction_ObjetiveAccount))]
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
#line 1 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/_ViewImports.cshtml"
using Progra1BD;

#line default
#line hidden
#line 2 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/_ViewImports.cshtml"
using Progra1BD.Models;

#line default
#line hidden
#line 1 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe38038df67d49161095a927ea35c4eb38e5b15", @"/Views/Transaction/ObjetiveAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70057b8e3bc89ee12b5dbc958d301adcebf8ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_ObjetiveAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Progra1BD.Models.ObjetiveAccount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StateAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Beneficiaries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ObjetiveAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddObjetiveAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateBeneficiarie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBeneficiarie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(97, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
  
    ViewData["Title"] = "Cuentas Objetivo";

#line default
#line hidden
            BeginContext(147, 141, true);
            WriteLiteral("\n<div class=\"container\">\n    <nav class=\"navbar navbar-expand-lg navbar-dark bg-dark fixed-top\">\n        <div class=\"container\">\n            ");
            EndContext();
            BeginContext(288, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b159772", async() => {
                BeginContext(353, 12, true);
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
            BeginContext(369, 467, true);
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item"">
                        ");
            EndContext();
            BeginContext(836, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1511902", async() => {
                BeginContext(897, 6, true);
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
            BeginContext(907, 443, true);
            WriteLiteral(@"
                    </li>
                    <div class=""dropdown show"">
                        <a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Transacciones
                        </a>

                        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                            ");
            EndContext();
            BeginContext(1350, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1514000", async() => {
                BeginContext(1442, 16, true);
                WriteLiteral("Estado de Cuenta");
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
            BeginContext(1462, 29, true);
            WriteLiteral("\n                            ");
            EndContext();
            BeginContext(1491, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1515874", async() => {
                BeginContext(1584, 13, true);
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
            BeginContext(1601, 29, true);
            WriteLiteral("\n                            ");
            EndContext();
            BeginContext(1630, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1517745", async() => {
                BeginContext(1725, 15, true);
                WriteLiteral("Cuenta Objetivo");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1744, 125, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                    <li class=\"nav-item\">\n                        ");
            EndContext();
            BeginContext(1869, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1519719", async() => {
                BeginContext(1931, 5, true);
                WriteLiteral("About");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1940, 93, true);
            WriteLiteral("\n                    </li>\n                    <li class=\"nav-item\">\n                        ");
            EndContext();
            BeginContext(2033, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1521454", async() => {
                BeginContext(2095, 5, true);
                WriteLiteral("Salir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2104, 99, true);
            WriteLiteral("\n                    </li>\n                </ul>\n            </div>\n        </div>\n    </nav>\n    \n");
            EndContext();
#line 42 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
     if (!ViewData.ModelState.IsValid && ViewData.ModelState["Error"].Errors.Count > 0)
    {

#line default
#line hidden
            BeginContext(2297, 51, true);
            WriteLiteral("        <div class=\"alert alert-info\">\n            ");
            EndContext();
            BeginContext(2349, 56, false);
#line 45 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
       Write(ViewData.ModelState["Error"].Errors.First().ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(2405, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 47 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
    }

#line default
#line hidden
            BeginContext(2427, 461, true);
            WriteLiteral(@"    <br/>
    <br/>
    <br/>
    <h3>Cuentas Objetivo</h3>
    <br/>
    
    <table class=""table table-bordered table-responsive"" style=""border: 0px; padding-left: 175px"">
        <thead class=""table-primary"">
        <tr>
            <th>ID</th>
            <th>Id de la Cuenta</th>
            <th>Fecha Inicio</th>
            <th>Fecha Final</th>
            <th>Saldo</th>
            <th>Monto Ahorro</th>
        </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 66 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2935, 82, true);
            WriteLiteral("            <tr class=\"table-secondary\">\n                <td>\n                    ");
            EndContext();
            BeginContext(3018, 37, false);
#line 70 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3120, 43, false);
#line 73 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.idCuenta));

#line default
#line hidden
            EndContext();
            BeginContext(3163, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3228, 46, false);
#line 76 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.fechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(3274, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3339, 45, false);
#line 79 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.fechaFinal));

#line default
#line hidden
            EndContext();
            BeginContext(3384, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3449, 40, false);
#line 82 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.saldo));

#line default
#line hidden
            EndContext();
            BeginContext(3489, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3554, 46, false);
#line 85 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.montoAhorro));

#line default
#line hidden
            EndContext();
            BeginContext(3600, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 88 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
        }

#line default
#line hidden
            BeginContext(3651, 241, true);
            WriteLiteral("        </tbody>\n    </table>\n    \n    <br/>\n    <br/>\n\n    <!-- Page Features -->\n    <div class=\"row text-center\">\n\n        <div class=\"col-lg-4 col-md-6 mb-4\">\n            <div class=\"card h-100\">\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3892, "\"", 3934, 1);
#line 100 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
WriteAttributeValue("", 3898, Url.Content("~/img/laptop-640.jpg"), 3898, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3935, 352, true);
            WriteLiteral(@" alt="""">
                <div class=""card-body"">
                    <h4 class=""card-title"">Agregar Cuenta Objetivo</h4>
                    <p class=""card-text"">Agrega objetivos a tu cuenta para que puedas lograr todos tus sueños, tu dilo nosotros lo ahorramos.</p>
                </div>
                <div class=""card-footer"">
                    ");
            EndContext();
            BeginContext(4287, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1529457", async() => {
                BeginContext(4375, 14, true);
                WriteLiteral("Agregar Ahora!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4393, 182, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n        <div class=\"col-lg-4 col-md-6 mb-4\">\n            <div class=\"card h-100\">\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4575, "\"", 4615, 1);
#line 113 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
WriteAttributeValue("", 4581, Url.Content("~/img/desk-640.jpg"), 4581, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4616, 337, true);
            WriteLiteral(@" alt="""">
                <div class=""card-body"">
                    <h4 class=""card-title"">Actualizar Cuenta Objetivo</h4>
                    <p class=""card-text"">Si deseas modificar lo que deseas ahorrar o el motivo, puedes hacerlo desde aqui. </p>
                </div>
                <div class=""card-footer"">
                    ");
            EndContext();
            BeginContext(4953, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1532115", async() => {
                BeginContext(5041, 17, true);
                WriteLiteral("Actualizar Ahora!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5062, 182, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n        <div class=\"col-lg-4 col-md-6 mb-4\">\n            <div class=\"card h-100\">\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5244, "\"", 5284, 1);
#line 126 "/Users/edgarpa12/OneDrive - Estudiantes ITCR/TEC/Semestre 4/Bases de Datos/Progra1-Bases/Progra1BD/Views/Transaction/ObjetiveAccount.cshtml"
WriteAttributeValue("", 5250, Url.Content("~/img/team-640.jpg"), 5250, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5285, 299, true);
            WriteLiteral(@" alt="""">
                <div class=""card-body"">
                    <h4 class=""card-title"">Eliminar Cuenta Objetivo</h4>
                    <p class=""card-text"">Aqui puedes eliminar un objetivo de tu cuenta.</p>
                </div>
                <div class=""card-footer"">
                    ");
            EndContext();
            BeginContext(5584, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe38038df67d49161095a927ea35c4eb38e5b1534738", async() => {
                BeginContext(5672, 15, true);
                WriteLiteral("Eliminar ahora!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5691, 254, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n\n    </div>\n    <!-- /.row -->\n\n</div>\n\n\n<!-- Bootstrap core JavaScript -->\n<script src=\"vendor/jquery/jquery.min.js\"></script>\n<script src=\"vendor/bootstrap/js/bootstrap.bundle.min.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Progra1BD.Models.ObjetiveAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
