#pragma checksum "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b861f78007ce91b2f52dbe7c4786ff9b2210ce28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_Details), @"mvc.1.0.view", @"/Views/Character/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b861f78007ce91b2f52dbe7c4786ff9b2210ce28", @"/Views/Character/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848bcf379998312e9b842aebe906d6fb184a3807", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DnDCharacterCreator.Models.Character>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
   Write(Html.DisplayFor(model => model.CharacterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            Character Name\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.CharacterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Class));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Max HP\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxHp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Current HP\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentHp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Hit Dice\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.HitDice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Armor Class\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.ArmorClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dexterity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dexterity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 85 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Intelligence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Intelligence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Wisdom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Wisdom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Charisma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Charisma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Proficiency Bonus\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 106 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProficiencyBounus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 109 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Spells));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 112 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Spells));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 115 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Inventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 118 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Inventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 121 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Proficiencies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 124 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Proficiencies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 127 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 130 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Saving Throws\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 136 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.SavingThrows));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 139 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Skills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 142 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
       Write(Html.DisplayFor(model => model.Skills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 147 "C:\Users\gilde\workspace\csharp\DnDCharacterCreator\Views\Character\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b861f78007ce91b2f52dbe7c4786ff9b2210ce2816905", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DnDCharacterCreator.Models.Character> Html { get; private set; }
    }
}
#pragma warning restore 1591
