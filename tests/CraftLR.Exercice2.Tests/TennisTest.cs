using FluentAssertions;

using Xunit;

namespace CraftLR.Exercice2;

public class TennisTest
{
    [Fact]
    public void Test_an_new_tennis_game_should_have_a_zero_zero_score()
    {
        TennisGame game = new("player1", "player2");
        game.GetScore().Should().Be("0 - 0");
    }
}
