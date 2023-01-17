using System;

namespace CraftLR.Exercice2;
public interface ITennisGame
{
    void WonPoint(string playerName);

    string GetScore();
}
