using ApprentissageInformatique.Data.ModeleSeedData;
using ApprentissageInformatique.Data.SeedModels;
using ApprentissageInformatique.Models;

namespace ApprentissageInformatique.Data;

public static class SeedData
{
    public static List<Module> GetModules()
    {
        var moduleSeeds = ModuleSeedData.GetModuleSeeds();
        var result = new List<Module>();

        foreach (var seed in moduleSeeds)
        {
            var questions = GetQuestionsForModule(seed.Id);
            result.Add(SeedDataMapper.ToModule(seed, questions));
        }

        return result;
    }

    private static List<QuestionSeed> GetQuestionsForModule(int moduleId)
    {
        return moduleId switch
        {
            1 => QuestionsSeedData.GetQuestionsOrdinateur(),
            2 => QuestionsSeedData.GetQuestionsInternet(),
            3 => QuestionsSeedData.GetQuestionsMessagerie(),
            4 => QuestionsSeedData.GetQuestionsProtection(),
            _ => new List<QuestionSeed>()
        };
    }
}
