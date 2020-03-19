#pragma checksum "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c61509f31788ba585c69ba2d1238d54e88a7d613"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BingoRoom.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
using Bingo75;

#line default
#line hidden
#nullable disable
    public partial class Bingo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
       
    private Bingo75.Game MyGame;
    private int _numberToCheck = 1;
    private string _checkMessage = String.Empty;
    private string _winMessage = String.Empty;

    private void CallBall()
    {
        try
        {
            MyGame.CallBall();
            foreach (var card in MyGame.Cards)
            {
                card.Check(MyGame.CalledNumbers.Last());
            }
        }
        catch (Exception e)
        {
        }
    }

    private void RestartGame()
    {
        MyGame.Restart();
        _winMessage = String.Empty;
    }

    private void HandCard()
    {
        MyGame.HandCard();
    }

    private void CallBingo(IGame.ICard card)
    {
        var winner = MyGame.CallBingo(card);
        _winMessage = winner ? "You won!" : "Try again...";
    }

    private void CheckNumber()
    {
        _checkMessage = MyGame.CalledNumbers.Contains(_numberToCheck) ? "Number Found!" : "Number Not Found.";
    }

    private void SetNumberToCheck(string number)
    {
        int.TryParse(number, out _numberToCheck);
    }

    protected override void OnInitialized()
    {
        MyGame = (Bingo75.Game)Game;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGame Game { get; set; }
    }
}
#pragma warning restore 1591
