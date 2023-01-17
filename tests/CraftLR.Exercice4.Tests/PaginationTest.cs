using System;
using System.Collections.Generic;

using FluentAssertions;

using Xunit;

namespace CraftLR.Exercice4;

public class PaginationTest
{
    [Fact]
    public void ShouldGetPageTwoOfFive()
    {
        Pagination pagination = new(2, 5);
        pagination.Display().Should().Be("1 (2) 3 4 5");
    }

}
