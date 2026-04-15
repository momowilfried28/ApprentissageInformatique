using ApprentissageInformatique.Data.SeedModels;

namespace ApprentissageInformatique.Data.ModeleSeedData;

public static class ModuleSeedData
{
    public static List<ModuleSeed> GetModuleSeeds()
    {
        return new List<ModuleSeed>
        {
            new ModuleSeed
            {
                Id = 1,
                Titre = "Initiation à l'ordinateur",
                Description = "Découvrir les éléments essentiels d'un ordinateur",
                Image = "~/images/ordinateur.gif",
                Couleur = "#4A90E2",
                PdfPath = "/pdfs/MODULE_1.pdf"
            },
            new ModuleSeed
            {
                Id = 2,
                Titre = "Navigation sur Internet",
                Description = "Apprendre à naviguer sur le web",
                Image = "~/images/site-web.gif",
                Couleur = "#50C878",
                PdfPath = "/pdfs/MODULE_2.pdf"
            },
            new ModuleSeed
            {
                Id = 3,
                Titre = "Messagerie et communication en ligne",
                Description = "Envoyer et recevoir des courriels",
                Image = "~/images/chat.gif",
                Couleur = "#FF6B6B",
                PdfPath = "/pdfs/MODULE_3.pdf"
            },
            new ModuleSeed
            {
                Id = 4,
                Titre = "Nettoyage et protection du PC",
                Description = "Protéger son ordinateur contre les virus",
                Image = "~/images/bouclier.gif",
                Couleur = "#FFA500",
                PdfPath = "/pdfs/MODULE_4.pdf"
            },
               new ModuleSeed
            {
                Id = 5,
                Titre = "Dépannage de base",
                Description = "résoudre les problèmes informatiques les plus courants.",
                Image = "~/images/reglages.gif",
                Couleur = "#ddff04",
                PdfPath = "/pdfs/MODULE_5.pdf"
            },
                    new ModuleSeed
            {
                Id = 6,
                Titre = "Transaction en ligne",
                Description = "apprendre à utiliser Internet de façon sécuritaire",
                Image = "~/images/acheter.gif",
                Couleur = "#99a2be",
                PdfPath = "/pdfs/MODULE_6.pdf"
            }
        };
    }
}