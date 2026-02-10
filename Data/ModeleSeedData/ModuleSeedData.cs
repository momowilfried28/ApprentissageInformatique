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
                PdfPath = "/pdfs/MODULE 1_INITIATION A L'ORDINATEU1R.pdf.pdf"
            },
            new ModuleSeed
            {
                Id = 2,
                Titre = "Navigation sur Internet",
                Description = "Apprendre à naviguer sur le web",
                Image = "~/images/site-web.gif",
                Couleur = "#50C878",
                PdfPath = "/pdfs/MODULE 2_NAVIGATION SUR INTERNET2.pdf"
            },
            new ModuleSeed
            {
                Id = 3,
                Titre = "Messagerie et communication en ligne",
                Description = "Envoyer et recevoir des courriels",
                Image = "~/images/chat.gif",
                Couleur = "#FF6B6B",
                PdfPath = "/pdfs/MODULE 3_Communication et Messagerie.pdf"
            },
            new ModuleSeed
            {
                Id = 4,
                Titre = "Nettoyage et protection du PC",
                Description = "Protéger son ordinateur contre les virus",
                Image = "~/images/bouclier.gif",
                Couleur = "#FFA500",
                PdfPath = "/pdfs/MODULE 4  NETTOYAGE ET PROTECTION DU PC.pdf"
            }
        };
    }
}
