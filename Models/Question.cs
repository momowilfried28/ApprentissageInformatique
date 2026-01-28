namespace ApprentissageInformatique.Models;

public class Question
{
    public int Id { get; set; }
    public string Texte { get; set; } = string.Empty;
    public List<string> Options { get; set; } = new();
    public int ReponseCorrecte { get; set; }
    public int ModuleId { get; set; }
}
