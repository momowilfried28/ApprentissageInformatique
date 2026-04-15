using Microsoft.AspNetCore.Mvc;
using ApprentissageInformatique.Models;
using ApprentissageInformatique.Data;

namespace ApprentissageInformatique.Controllers;

public class ModulesController : Controller
{
    public IActionResult Index()
    {
        var modules = SeedData.GetModules();
        return View(modules);
    }

    public IActionResult Quiz(int id)
    {
        var modules = SeedData.GetModules();
        var module = modules.FirstOrDefault(m => m.Id == id);

        if (module == null)
        {
            return NotFound();
        }

        return View(module);
    }

    [HttpPost]
    public IActionResult SubmitQuiz(int moduleId, Dictionary<int, int> reponses)
    {
        var modules = SeedData.GetModules();
        var module = modules.FirstOrDefault(m => m.Id == moduleId);

        if (module == null)
        {
            return NotFound();
        }

        int score = 0;
        int total = module.Questions.Count;

        foreach (var question in module.Questions)
        {
            if (reponses.ContainsKey(question.Id) && reponses[question.Id] == question.ReponseCorrecte)
            {
                score++;
            }
        }

        ViewBag.Score = score;
        ViewBag.Total = total;
        ViewBag.ModuleId = moduleId;
        ViewBag.ReponsesUser = reponses;

        return View("QuizResult", module);
    }
}