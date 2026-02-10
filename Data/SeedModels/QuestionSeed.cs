namespace ApprentissageInformatique.Data.SeedModels
{
    public class QuestionSeed
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Texte { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public int ReponseCorrecte { get; set; }
    }
}