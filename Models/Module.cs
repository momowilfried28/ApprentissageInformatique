namespace ApprentissageInformatique.Models;

public class Module
{
    public int Id { get; set; }
    public string Titre { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icone { get; set; } = string.Empty;
    public string Couleur { get; set; } = string.Empty;
    public string? PdfPath { get; set; }
    public List<Question> Questions { get; set; } = new();
}
