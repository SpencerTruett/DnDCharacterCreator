#pragma checksum "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c690dc167fbdaa981761ae206edb93ac53bf45c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Index), @"mvc.1.0.view", @"/Views/Character/Index.cshtml")]
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
#line 1 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\_ViewImports.cshtml"
using DnDCharacterCreator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\_ViewImports.cshtml"
using DnDCharacterCreator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c690dc167fbdaa981761ae206edb93ac53bf45c", @"/Views/Character/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848bcf379998312e9b842aebe906d6fb184a3807", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DnDCharacterCreator.Models.Character>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Characters</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c690dc167fbdaa981761ae206edb93ac53bf45c3716", async() => {
                WriteLiteral("Create a New Character");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Character Name\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Exp.
            </th>
            <th>
                Max HP
            </th>
            <th>
                Current HP
            </th>
            <th>
                Hit Dice
            </th>
            <th>
                AC
            </th>
            <th>
                STR
            </th>
            <th>
                DEX
            </th>
            <th>
                CON
            </th>
            <th>
                INT
            </th>
            <th>
                WIS
            </th>
            <th>
                CHA
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 64 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.ActionLink(item.CharacterName, "Details", "Character", new { id = item.Id }, new { area = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxHp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurrentHp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HitDice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArmorClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Strength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dexterity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Intelligence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Wisdom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Charisma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 112 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DnDCharacterCreator.Models.Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
