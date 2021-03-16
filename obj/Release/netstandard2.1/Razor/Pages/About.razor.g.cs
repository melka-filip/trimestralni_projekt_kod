#pragma checksum "C:\Users\Filip\source\repos\TrimestralniProjektMelka\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0425b46a18d6b8bb360876f8440875a0e915d7d5"
// <auto-generated/>
#pragma warning disable 1591
namespace TrimestralniProjektMelka.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#line 6 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using TrimestralniProjektMelka;

#line default
#line hidden
#line 8 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using TrimestralniProjektMelka.Shared;

#line default
#line hidden
#line 9 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using TrimestralniProjektMelka.Pages;

#line default
#line hidden
#line 10 "C:\Users\Filip\source\repos\TrimestralniProjektMelka\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"about-container\">\r\n    <div class=\"about-content\">\r\n        <h1>Trimestrální projekt z programování <i class=\"fas fa-code\"></i></h1>\r\n        <span class=\"hashtag\">#NO JAVASCRIPT</span>\r\n        \r\n        <h2>Cíl projektu</h2>\r\n        <p>Neboť se při hodinách programování nyní věnujeme konzolovým apkikacím v jazyce C#, chtěl jsem pro svůj trimestrální projekt zkusit najít i jiné využití tohoto programovacího jazyka. Zjistil jsem, že tento jazyk je poměrně oblíbený pro vývoj her (v herních enginech jako například Unity). Zároveň jsem ovšem zjistil, že C# lze použít pro tvorbu webů a webových aplikací, kde může nahradit JavaScript. Neboť jsme se tvorbě webu věnovali v kvintě (ačkoli pouze naprostým základům HTML, CSS a JavaScriptu), rozhodl jsem se, že si zkusím tvorbu jednoduchých webových stránek připomenout a vytvořím web na téma Rezistory, kde místo JavaScriptu využiji právě jazyk C#.</p>\r\n        \r\n        <div class=\"callout\">\r\n            <i class=\"fab fa-html5\"></i>\r\n            <i class=\"fab fa-css3-alt\"></i>\r\n            <span> + C#</span>\r\n        </div>\r\n\r\n        <p>Pro vytvoření tohoto webu, použiji Blazor, což (dle <a href=\"https://en.wikipedia.org/wiki/Blazor\">wikipedie</a>) je otevřený webový rámec, který vývojářům umožňuje vytvážet webové aplikace pomocí C# a HTML. Z časových důvodů se nebudu snažit Blazor pochopit více do hloubky, pouze se rychle zkusím naučit nezbytné základy pro chod mé aplikace.</p>\r\n        \r\n        <h3>Mé studijní zdroje <i class=\"fas fa-book\"></i></h3>\r\n        <p>Pro získání potřebných znalostí, jsem se rozhodl využít především <a href=\"https://blazor-university.com/\">Blazor University</a>. Našel jsem zde většinu toho, co jsem potřeboval, a lekce, kterým jsem se věnoval mi přisly snadno srozumitelné. Zároveň jsem se podíval na několik <i>follow-along</i> tutoriálů na YouTubu. Při frustrujících chvílích, kdy jsem narazil na problém, se kterým jsem si již nevěděl rady, jsem se také obrátil na <a href=\"https://stackoverflow.com/\">Stack Overlow</a>.</p>\r\n        <p>Pro připomenutí jazyka HTML a CSS jsem využil online kurzy <a href=\"https://scrimba.com/\">Scrimba</a>, neboť se mi velmi líbí jejich zpracování (ve formě “videonahrávky”, do které ovšem mohu také kdykoliv zasahovat a <i>hrát si</i> s kódem).</p>\r\n        \r\n        <h2>Můj projekt</h2>\r\n        <p>Můj samotný projekt na téma Rezistory se skládá ze dvou částí:</p>\r\n        <h3>Aplikace na výpočet celkového odporu a proudu</h3>\r\n        <p>Nejprve jsem vytvořil jednoduchou <a href=\"Rezistory\">“kalkulačku”</a> na výpočet celkového odporu. Uživatel může přidat až pět rezistorů, u kterých určuje jejich odpor a zda jsou zapojené sériově či paralelně. Dále má uživatel možnost měnit napětí obvodu, dle kterého aplikace dopočítá protékající elektrický proud.</p>\r\n        <h3>Procvičování</h3>\r\n        <p>Zároveň jsem se rozhodl vytvořit <a href=\"Exercise\">aplikaci</a> na procvičování slovních úloh na téma rezistorů (ve stylu UmimeMatiku). Bohužel jsem z časových důvodů stihl vymyslet pouze jeden typ zadání, ale díky náhodnému <i>ladění</i> otázky je “rozdílních” zadání i přesto dost. Věřím, že až typy úloh rozšířím, mohla by mi tato aplikace reálně sloužit pro přípravu na testy z fyziky (či spíše mé sestře, neboť já mám již téma rezistorů za sebou <i class=\"fab fa-angellist\"></i>).</p>\r\n        \r\n        <h2>Nedostatky mého projektu <i class=\"fas fa-bug\"></i></h2>\r\n        <p>Můj projekt v tuto chvíli zdaleka není hotový (ale termín odevzdání, mě zase ňák doběhl). Původně mě nadchla myšlenka “kalkulačky” rezistorů, ve které by se dalo kombinovat sériové a paralelní zapojení. Bohužel uživatel v současné verzi se musí rozhodnout zda-li chce rezistory zapojit pouze sériově či pouze paralelně. Zároveň mi chybí vizuální znázornění rezistorů, které by mělo zaujímat poměrně velkou část stránky. S tím přichází i problém celkové vizuální stránky, na které by se dalo ještě hodně zapracovat. </p>\r\n        <p>Bohužel jsem tuto webovou aplikaci nestihl ani přizpůsobit pro mobilní telefony (což vím, že v dnešní době je vpodstatě hřích).</p>\r\n        \r\n        <div class=\"callout\">Všechny tyto a další nedostatky se ovšem chystám ve svém volném čase napravit <i class=\"fas fa-grin-wink\"></i></div>\r\n\r\n        <h2>Závěr <i class=\"fas fa-stream\"></i></h2>\r\n        <p>Věřím, že jsem si tímto projektem nejen prohloubil mé znalosti programování v jazyce C#, ale také jsem se dozvěděl o trochu jiném využití tohoto jazyka a velmi okrajově jsem se seznámil s pojmem WebAssembly.</p>\r\n    </div>    \r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
