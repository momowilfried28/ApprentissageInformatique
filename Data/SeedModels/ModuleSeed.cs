namespace ApprentissageInformatique.Data.SeedModels
{
    public class ModuleSeed
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Couleur { get; set; } = string.Empty;
        public string? PdfPath { get; set; }
        public List<QuestionSeed> Questions { get; set; } = new();
    }
}