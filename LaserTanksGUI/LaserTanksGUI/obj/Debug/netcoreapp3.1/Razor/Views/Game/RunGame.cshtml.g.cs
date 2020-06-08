#pragma checksum "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6f2165ee1ca0ab81962d48f1350177b58cc156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_RunGame), @"mvc.1.0.view", @"/Views/Game/RunGame.cshtml")]
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
#line 1 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\_ViewImports.cshtml"
using LaserTanksGUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\_ViewImports.cshtml"
using LaserTanksGUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6f2165ee1ca0ab81962d48f1350177b58cc156", @"/Views/Game/RunGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a6aa23a9600f9d196100b5cc485f8bfee759a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_RunGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LaserTanksGUI.Models.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
  
    ViewData["Title"] = "Game Setup";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n    <table class=\"gameView\">\r\n        <tr>\r\n            <th class=\"column\"><b>");
#nullable restore
#line 11 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                             Write(ViewData["NumPlayers"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Player Game</b></th>\r\n");
#nullable restore
#line 12 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
             foreach(var playerName in (string[])ViewData["PlayerNames"])
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th class=\"column\"><b>");
#nullable restore
#line 14 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                                 Write(playerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></th>\r\n");
#nullable restore
#line 15 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th class=\"column\"><p>Health</p></th>\r\n");
#nullable restore
#line 19 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
             foreach(var p in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"column\"><p>");
#nullable restore
#line 21 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                                 Write(p.Health);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 22 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th class=\"column\"><p>Score</p></th>\r\n");
#nullable restore
#line 26 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
             foreach(var p in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><p>");
#nullable restore
#line 28 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                  Write(p.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 29 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th class=\"column\"><p>Health</p></th>\r\n");
#nullable restore
#line 33 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
             foreach(var p in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"column\"><p>");
#nullable restore
#line 35 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                                 Write(p.Health);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 35 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                                             Write(p.MaxHealth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 36 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th class=\"column\"><p>Kills</p></th>\r\n");
#nullable restore
#line 40 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
             foreach(var p in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"column\"><p>");
#nullable restore
#line 42 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                                 Write(p.Kills);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 43 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th class=\"column\"><p>Deaths</p></th>\r\n");
#nullable restore
#line 47 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
             foreach(var p in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"column\"><p>");
#nullable restore
#line 49 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
                                 Write(p.Deaths);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 50 "C:\Users\Gamer\source\repos\LaserTanksGUI\LaserTanksGUI\LaserTanksGUI\Views\Game\RunGame.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LaserTanksGUI.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
