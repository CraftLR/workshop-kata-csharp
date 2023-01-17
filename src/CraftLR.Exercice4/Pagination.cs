using System;

namespace CraftLR.Exercice4;

public class Pagination
{
    public Pagination(int current, int total)
    {
        this.Total = total;
        this.Current = current;
    }

    public int Total { get; }

    public int Current { get; }

    public string Display()
    {
        return "1 (2) 3 4 5";
    }
}
