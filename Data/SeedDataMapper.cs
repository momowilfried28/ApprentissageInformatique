using ApprentissageInformatique.Data.SeedModels;
using ApprentissageInformatique.Models;

namespace ApprentissageInformatique.Data;

public static class SeedDataMapper
{
    public static Module ToModule(ModuleSeed seed, List<QuestionSeed> questions)
    {
        return new Module
        {
            Id = seed.Id,
            Titre = seed.Titre,
            Description = seed.Description,
            Image = seed.Image,
            Couleur = seed.Couleur,
            PdfPath = seed.PdfPath,
            Questions = questions.Select(ToQuestion).ToList()
        };
    }

    public static Question ToQuestion(QuestionSeed seed)
    {
        return new Question
        {
            Id = seed.Id,
            ModuleId = seed.ModuleId,
            Texte = seed.Texte,
            Options = [.. seed.Options],
            ReponseCorrecte = seed.ReponseCorrecte
        };
    }
}