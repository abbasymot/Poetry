using Console.Services;

var poetryService = new PoetryService();
var faal = await poetryService.GetRandomPoetFromHafez();

System.Console.WriteLine(faal);