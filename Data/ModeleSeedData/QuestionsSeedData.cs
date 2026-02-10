using ApprentissageInformatique.Data.SeedModels;

namespace ApprentissageInformatique.Data.ModeleSeedData;

public static class QuestionsSeedData
{
    public static List<QuestionSeed> GetQuestionsOrdinateur()
    {
        return new List<QuestionSeed>
        {
            new QuestionSeed { Id = 1, ModuleId = 1, Texte = "Quel est le rôle de l'écran d'un ordinateur?", Options = new List<string> { "Pour écrire des mots", "Pour voir les images", "Pour déplacer la flèche", "Pour brancher une clé USB" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 2, ModuleId = 1, Texte = "Quelle est la fonction principale de la souris?", Options = new List<string> { "Pour voir les images", "Pour écrire des mots", "Pour déplacer la flèche sur l'écran", "Pour allumer l'ordinateur" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 3, ModuleId = 1, Texte = "Que permet de faire un double-clic avec la souris?", Options = new List<string> { "Sélectionner", "Ouvrir un fichier ou un programme", "Fermer un programme", "Faire de l'espace" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 4, ModuleId = 1, Texte = "À quoi sert la roulette (molette) de la souris?", Options = new List<string> { "Pour sélectionner", "Pour ouvrir un programme", "Pour descendre ou monter dans une page", "Pour fermer une fenêtre" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 5, ModuleId = 1, Texte = "Quelle touche du clavier permet de faire de l'espace entre les mots?", Options = new List<string> { "La touche Entrée", "La barre d'espace", "La touche Majuscule", "Les flèches de direction" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 6, ModuleId = 1, Texte = "Quelle touche permet de mettre les lettres en majuscule?", Options = new List<string> { "La barre d'espace", "La touche Entrée", "La touche Majuscule (Shift)", "La touche Retour arrière" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 7, ModuleId = 1, Texte = "Que sont les icônes sur le bureau Windows?", Options = new List<string> { "Des programmes ouverts", "Des fichiers", "Des raccourcis vers des programmes", "Des dossiers vides" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 8, ModuleId = 1, Texte = "Comment fermer un programme sous Windows?", Options = new List<string> { "Avec un double-clic", "Avec le X en haut à droite", "Avec la barre d'espace", "Avec la touche Entrée" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 9, ModuleId = 1, Texte = "Quelle est la différence principale entre un ordinateur bureau et un ordinateur portable?", Options = new List<string> { "Le portable est plus cher", "Le bureau a un écran plus grand", "Le portable regroupe tout dans un seul appareil", "Le bureau n'a pas de clavier" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 10, ModuleId = 1, Texte = "À quoi servent les prises USB?", Options = new List<string> { "Pour allumer l'ordinateur", "Pour voir les images", "Pour brancher une clé ou un téléphone", "Pour écrire des mots" }, ReponseCorrecte = 2 }
        };
    }

    public static List<QuestionSeed> GetQuestionsInternet()
    {
        return new List<QuestionSeed>
        {
            new QuestionSeed { Id = 1, ModuleId = 2, Texte = "À quoi sert un navigateur Internet?", Options = new List<string> { "À écrire des documents", "À aller sur Internet", "À installer des logiciels", "À envoyer des textos" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 2, ModuleId = 2, Texte = "Quel exemple est un navigateur?", Options = new List<string> { "Microsoft Word", "Google Chrome", "Adobe Reader", "Skype" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 3, ModuleId = 2, Texte = "Que doit-on écrire dans la barre de recherche?", Options = new List<string> { "Des mots-clés", "Des phrases complètes obligatoires", "Seulement des chiffres", "Le nom de son ordinateur" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 4, ModuleId = 2, Texte = "Quel signe indique qu'un site est sécurisé?", Options = new List<string> { "http://", "Un cadenas et https://", "Beaucoup de publicités", "Des couleurs vives" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 5, ModuleId = 2, Texte = "Quel est un signe d'un site douteux?", Options = new List<string> { "Adresse commençant par https://", "Site gouvernemental", "Promesses trop belles pour être vraies", "Présence d'un cadenas" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 6, ModuleId = 2, Texte = "À quoi sert le bouton 'Retour' dans un navigateur?", Options = new List<string> { "Fermer l'ordinateur", "Revenir à la page précédente", "Ouvrir un nouvel onglet", "Actualiser la page" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 7, ModuleId = 2, Texte = "Que permet un onglet?", Options = new List<string> { "Changer la langue du site", "Ouvrir plusieurs pages en même temps", "Télécharger des fichiers automatiquement", "Supprimer l'historique" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 8, ModuleId = 2, Texte = "Quel site est un exemple de source fiable?", Options = new List<string> { "canada-gouv-info.net", "google-support-help-123.xyz", "quebec.ca", "gagne-un-iphone-maintenant.com" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 9, ModuleId = 2, Texte = "Quel type de recherche peut-on faire sur Internet?", Options = new List<string> { "Météo", "Recettes", "Actualités", "Toutes ces réponses" }, ReponseCorrecte = 3 },
            new QuestionSeed { Id = 10, ModuleId = 2, Texte = "Pourquoi comparer plusieurs sources?", Options = new List<string> { "Pour vérifier si l'information est fiable", "Pour perdre du temps", "Parce qu'un seul site suffit toujours", "Pour éviter d'utiliser Google" }, ReponseCorrecte = 0 }
        };
    }

    public static List<QuestionSeed> GetQuestionsMessagerie()
    {
        return new List<QuestionSeed>
        {
            new QuestionSeed { Id = 1, ModuleId = 3, Texte = "À quoi sert une adresse courriel ?", Options = new List<string> { "À envoyer et recevoir des messages", "À regarder des vidéos", "À jouer à des jeux", "À installer des applications" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 2, ModuleId = 3, Texte = "Quel site permet d'accéder à Gmail ?", Options = new List<string> { "google.ca", "gmail.com", "hotmail.fr", "facebook.com" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 3, ModuleId = 3, Texte = "Que signifie le champ « À : » dans un courriel ?", Options = new List<string> { "Le sujet du message", "L'adresse du destinataire", "La pièce jointe", "La signature" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 4, ModuleId = 3, Texte = "À quoi sert le champ « Objet » ?", Options = new List<string> { "À écrire le message", "À ajouter une photo", "À indiquer le sujet du courriel", "À envoyer le message" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 5, ModuleId = 3, Texte = "Comment appelle-t-on un message frauduleux qui tente de voler des informations ?", Options = new List<string> { "Un message important", "Un spam", "Un phishing", "Un brouillon" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 6, ModuleId = 3, Texte = "À quoi sert le bouton « Nouveau message » dans Gmail ?", Options = new List<string> { "À supprimer un message", "À écrire un nouveau courriel", "À se déconnecter", "À ajouter un contact" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 7, ModuleId = 3, Texte = "Que signifie « Ajouter une pièce jointe » ?", Options = new List<string> { "Ajouter une photo ou un document", "Ajouter un contact", "Ajouter un nouveau compte", "Ajouter un mot de passe" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 8, ModuleId = 3, Texte = "Que fait le bouton « Envoyer » ?", Options = new List<string> { "Il enregistre le message", "Il supprime le message", "Il envoie le courriel au destinataire", "Il ferme Gmail" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 9, ModuleId = 3, Texte = "Que doit-on faire si un message semble suspect ?", Options = new List<string> { "Cliquer sur tous les liens", "Répondre rapidement", "Le supprimer ou l'ignorer", "Envoyer ses informations personnelles" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 10, ModuleId = 3, Texte = "Pourquoi est-il important de se déconnecter après usage ?", Options = new List<string> { "Pour économiser de la batterie", "Pour éviter que d'autres accèdent à votre courriel", "Pour supprimer les messages", "Pour accélérer Internet" }, ReponseCorrecte = 1 }
        };
    }

    public static List<QuestionSeed> GetQuestionsProtection()
    {
        return new List<QuestionSeed>
        {
            new QuestionSeed { Id = 7, ModuleId = 4, Texte = "Qu'est-ce qu'un antivirus?", Options = new List<string> { "Un virus", "Un logiciel de protection", "Un navigateur", "Un système d'exploitation" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 8, ModuleId = 4, Texte = "Pourquoi faut-il mettre à jour son système?", Options = new List<string> { "Pour avoir de nouvelles fonctionnalités", "Pour corriger des failles de sécurité", "Pour changer de système", "Toutes les réponses" }, ReponseCorrecte = 1 }
        };
    }
}
