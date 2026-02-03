using ApprentissageInformatique.Models;

namespace ApprentissageInformatique.Data;

public static class SeedData
{
    public static List<Module> GetModules()
    {
        return new List<Module>
        {
            new Module
            {
                Id = 1,
                Titre = "Initiation à l'ordinateur",
                Description = "Découvrir les éléments essentiels d'un ordinateur",
                Image= "~/images/ordinateur.gif",
                Couleur = "#4A90E2",
                PdfPath = "/pdfs/MODULE 1_INITIATION A L'ORDINATEU1R.pdf.pdf",
                Questions = GetQuestionsOrdinateur()
            },
            new Module
            {
                Id = 2,
                Titre = "Navigation sur Internet",
                Description = "Apprendre à naviguer sur le web",
                Image = "~/images/site-web.gif",
                Couleur = "#50C878",
                PdfPath = "/pdfs/MODULE 2_NAVIGATION SUR INTERNET2.pdf",
                Questions = GetQuestionsInternet()
            },
            new Module
            {
                Id = 3,
                Titre = "Messagerie et communication en ligne",
                Description = "Envoyer et recevoir des courriels",
                Image = "~/images/chat.gif",
                Couleur = "#FF6B6B",
                PdfPath = "/pdfs/module3/module3.pdf",
                Questions = GetQuestionsMessagerie()
            },
            new Module
            {
                Id = 4,
                Titre = "Nettoyage et protection du PC",
                Description = "Protéger son ordinateur contre les virus",
                Image = "~/images/bouclier.gif",
                Couleur = "#FFA500",
                PdfPath = "/pdfs/module4/module4.pdf",
                Questions = GetQuestionsProtection()
            }
        };
    }

    private static List<Question> GetQuestionsOrdinateur()
    {
        return new List<Question>
        {
            new Question
            {
                Id = 1,
                ModuleId = 1,
                Texte = "Quel est le rôle de l'écran d'un ordinateur?",
                Options = new List<string> { "Pour écrire des mots", "Pour voir les images", "Pour déplacer la flèche", "Pour brancher une clé USB" },
                ReponseCorrecte = 1
            },
            new Question
            {
                Id = 2,
                ModuleId = 1,
                Texte = "Quelle est la fonction principale de la souris?",
                Options = new List<string> { "Pour voir les images", "Pour écrire des mots", "Pour déplacer la flèche sur l'écran", "Pour allumer l'ordinateur" },
                ReponseCorrecte = 2
            },
            new Question
            {
                Id = 3,
                ModuleId = 1,
                Texte = "Que permet de faire un double-clic avec la souris?",
                Options = new List<string> { "Sélectionner", "Ouvrir un fichier ou un programme", "Fermer un programme", "Faire de l'espace" },
                ReponseCorrecte = 1
            },
            new Question
            {
                Id = 4,
                ModuleId = 1,
                Texte = "À quoi sert la roulette (molette) de la souris?",
                Options = new List<string> { "Pour sélectionner", "Pour ouvrir un programme", "Pour descendre ou monter dans une page", "Pour fermer une fenêtre" },
                ReponseCorrecte = 2
            },
            new Question
            {
                Id = 5,
                ModuleId = 1,
                Texte = "Quelle touche du clavier permet de faire de l'espace entre les mots?",
                Options = new List<string> { "La touche Entrée", "La barre d'espace", "La touche Majuscule", "Les flèches de direction" },
                ReponseCorrecte = 1
            },
            new Question
            {
                Id = 6,
                ModuleId = 1,
                Texte = "Quelle touche permet de mettre les lettres en majuscule?",
                Options = new List<string> { "La barre d'espace", "La touche Entrée", "La touche Majuscule (Shift)", "La touche Retour arrière" },
                ReponseCorrecte = 2
            },
            new Question
            {
                Id = 7,
                ModuleId = 1,
                Texte = "Que sont les icônes sur le bureau Windows?",
                Options = new List<string> { "Des programmes ouverts", "Des fichiers", "Des raccourcis vers des programmes", "Des dossiers vides" },
                ReponseCorrecte = 2
            },
            new Question
            {
                Id = 8,
                ModuleId = 1,
                Texte = "Comment fermer un programme sous Windows?",
                Options = new List<string> { "Avec un double-clic", "Avec le X en haut à droite", "Avec la barre d'espace", "Avec la touche Entrée" },
                ReponseCorrecte = 1
            },
            new Question
            {
                Id = 9,
                ModuleId = 1,
                Texte = "Quelle est la différence principale entre un ordinateur bureau et un ordinateur portable?",
                Options = new List<string> { "Le portable est plus cher", "Le bureau a un écran plus grand", "Le portable regroupe tout dans un seul appareil", "Le bureau n'a pas de clavier" },
                ReponseCorrecte = 2
            },
            new Question
            {
                Id = 10,
                ModuleId = 1,
                Texte = "À quoi servent les prises USB?",
                Options = new List<string> { "Pour allumer l'ordinateur", "Pour voir les images", "Pour brancher une clé ou un téléphone", "Pour écrire des mots" },
                ReponseCorrecte = 2
            }
        };
    }

    private static List<Question> GetQuestionsInternet()
    {
        return new List<Question>
    {
        new Question {
            Id = 1,
            ModuleId = 2,
            Texte = "À quoi sert un navigateur Internet?",
            Options = new List<string> {
                "À écrire des documents",
                "À aller sur Internet",
                "À installer des logiciels",
                "À envoyer des textos"
            },
            ReponseCorrecte = 1
        },

        new Question {
            Id = 2,
            ModuleId = 2,
            Texte = "Quel exemple est un navigateur?",
            Options = new List<string> {
                "Microsoft Word",
                "Google Chrome",
                "Adobe Reader",
                "Skype"
            },
            ReponseCorrecte = 1
        },

        new Question {
            Id = 3,
            ModuleId = 2,
            Texte = "Que doit-on écrire dans la barre de recherche?",
            Options = new List<string> {
                "Des mots-clés",
                "Des phrases complètes obligatoires",
                "Seulement des chiffres",
                "Le nom de son ordinateur"
            },
            ReponseCorrecte = 0
        },

        new Question {
            Id = 4,
            ModuleId = 2,
            Texte = "Quel signe indique qu’un site est sécurisé?",
            Options = new List<string> {
                "http://",
                "Un cadenas et https://",
                "Beaucoup de publicités",
                "Des couleurs vives"
            },
            ReponseCorrecte = 1
        },

        new Question {
            Id = 5,
            ModuleId = 2,
            Texte = "Quel est un signe d’un site douteux?",
            Options = new List<string> {
                "Adresse commençant par https://",
                "Site gouvernemental",
                "Promesses trop belles pour être vraies",
                "Présence d’un cadenas"
            },
            ReponseCorrecte = 2
        },

        new Question {
            Id = 6,
            ModuleId = 2,
            Texte = "À quoi sert le bouton 'Retour' dans un navigateur?",
            Options = new List<string> {
                "Fermer l’ordinateur",
                "Revenir à la page précédente",
                "Ouvrir un nouvel onglet",
                "Actualiser la page"
            },
            ReponseCorrecte = 1
        },

        new Question {
            Id = 7,
            ModuleId = 2,
            Texte = "Que permet un onglet?",
            Options = new List<string> {
                "Changer la langue du site",
                "Ouvrir plusieurs pages en même temps",
                "Télécharger des fichiers automatiquement",
                "Supprimer l’historique"
            },
            ReponseCorrecte = 1
        },

        new Question {
            Id = 8,
            ModuleId = 2,
            Texte = "Quel site est un exemple de source fiable?",
            Options = new List<string> {
                "canada-gouv-info.net",
                "google-support-help-123.xyz",
                "quebec.ca",
                "gagne-un-iphone-maintenant.com"
            },
            ReponseCorrecte = 2
        },

        new Question {
            Id = 9,
            ModuleId = 2,
            Texte = "Quel type de recherche peut-on faire sur Internet?",
            Options = new List<string> {
                "Météo",
                "Recettes",
                "Actualités",
                "Toutes ces réponses"
            },
            ReponseCorrecte = 3
        },

        new Question {
            Id = 10,
            ModuleId = 2,
            Texte = "Pourquoi comparer plusieurs sources?",
            Options = new List<string> {
                "Pour vérifier si l’information est fiable",
                "Pour perdre du temps",
                "Parce qu’un seul site suffit toujours",
                "Pour éviter d’utiliser Google"
            },
            ReponseCorrecte = 0
        }
    };
    }

    private static List<Question> GetQuestionsMessagerie()
    {
        return new List<Question>
        {
            new Question { Id = 5, ModuleId = 3, Texte = "Que signifie @ dans une adresse email?", Options = new List<string> { "À", "Chez", "Arobase", "Tous les réponses" }, ReponseCorrecte = 3 },
            new Question { Id = 6, ModuleId = 3, Texte = "Qu'est-ce qu'un spam?", Options = new List<string> { "Un email important", "Un courrier indésirable", "Un virus", "Un logiciel" }, ReponseCorrecte = 1 }
        };
    }

    private static List<Question> GetQuestionsProtection()
    {
        return new List<Question>
        {
            new Question { Id = 7, ModuleId = 4, Texte = "Qu'est-ce qu'un antivirus?", Options = new List<string> { "Un virus", "Un logiciel de protection", "Un navigateur", "Un système d'exploitation" }, ReponseCorrecte = 1 },
            new Question { Id = 8, ModuleId = 4, Texte = "Pourquoi faut-il mettre à jour son système?", Options = new List<string> { "Pour avoir de nouvelles fonctionnalités", "Pour corriger des failles de sécurité", "Pour changer de système", "Toutes les réponses" }, ReponseCorrecte = 1 }
        };
    }
}