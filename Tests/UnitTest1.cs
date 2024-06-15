using Console.Services;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var poetryService = new PoetryService();
        var faal = await poetryService.GetRandomPoetFromHafez();

        Assert.NotNull(faal);
    }
}