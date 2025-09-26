using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Radios.Tests;

[Collection("Collection")]
public sealed class RadioTests : FixturedUnitTest
{
    public RadioTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
