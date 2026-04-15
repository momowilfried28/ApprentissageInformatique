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

    public static List<QuestionSeed> GetQuestionsNettoyageProtection()
    {
        return new List<QuestionSeed>
        {
            new QuestionSeed { Id = 1, ModuleId = 4, Texte = "Qu'est-ce qu'un virus informatique ?", Options = new List<string> { "Un programme qui ralentit ou endommage l'ordinateur", "Un outil pour nettoyer Windows", "Une mise à jour de sécurité", "Un fichier pour accélérer le PC" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 2, ModuleId = 4, Texte = "Quel antivirus est déjà installé gratuitement sur Windows ?", Options = new List<string> { "Norton", "Avast", "Windows Defender", "McAfee" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 3, ModuleId = 4, Texte = "À quoi sert une analyse rapide dans Windows Defender ?", Options = new List<string> { "À vérifier rapidement si des menaces sont présentes", "À supprimer les fichiers personnels", "À nettoyer la corbeille", "À mettre à jour Windows" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 4, ModuleId = 4, Texte = "Comment vider la corbeille ?", Options = new List<string> { "Double-cliquer sur la corbeille", "Cliquer droit puis choisir 'Vider la corbeille'", "Ouvrir Windows Update", "Redémarrer l'ordinateur" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 5, ModuleId = 4, Texte = "À quoi sert l'Assistant de stockage ?", Options = new List<string> { "À libérer automatiquement de l'espace", "À protéger contre les virus", "À installer des logiciels", "À changer le fond d'écran" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 6, ModuleId = 4, Texte = "Pourquoi faut-il mettre Windows à jour ?", Options = new List<string> { "Pour rendre l'ordinateur plus sécurisé et plus stable", "Pour supprimer les fichiers inutiles", "Pour installer des jeux", "Pour changer la couleur du bureau" }, ReponseCorrecte = 0 },
            new QuestionSeed { Id = 7, ModuleId = 4, Texte = "Quel est l'endroit le plus sûr pour télécharger un logiciel ?", Options = new List<string> { "Une publicité 'Télécharger maintenant !'", "Un site inconnu", "Le site officiel du logiciel", "Un lien envoyé par un inconnu" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 8, ModuleId = 4, Texte = "Quel magasin intégré à Windows permet d'installer des logiciels en toute sécurité ?", Options = new List<string> { "Google Play", "Microsoft Store", "App Store", "Soft-download-free.xyz" }, ReponseCorrecte = 1 },
            new QuestionSeed { Id = 9, ModuleId = 4, Texte = "Quel signe peut indiquer qu'un PC est infecté ?", Options = new List<string> { "L'ordinateur est plus rapide que d'habitude", "Aucune publicité n'apparaît", "Des ralentissements ou des fenêtres étranges", "Le PC démarre plus vite" }, ReponseCorrecte = 2 },
            new QuestionSeed { Id = 10, ModuleId = 4, Texte = "Que faut-il éviter absolument pour rester en sécurité ?", Options = new List<string> { "Télécharger depuis le site officiel", "Installer depuis le Microsoft Store", "Cliquer sur des publicités 'Votre PC est infecté !'", "Mettre Windows à jour" }, ReponseCorrecte = 2 }
        };
    }

    public static List<QuestionSeed> GetQuestionsDepannage()
    {
        return new List<QuestionSeed>
    {
        new QuestionSeed {
            Id = 1,
            ModuleId = 5,
            Texte = "Quel est le premier réflexe quand quelque chose ne fonctionne pas ?",
            Options = new List<string> {
                "Changer d’ordinateur",
                "Redémarrer l’ordinateur",
                "Supprimer un programme",
                "Appeler un technicien"
            },
            ReponseCorrecte = 1
        },

        new QuestionSeed {
            Id = 2,
            ModuleId = 5,
            Texte = "Que signifie l’icône Wi-Fi avec une petite planète ?",
            Options = new List<string> {
                "Internet fonctionne",
                "Le son est coupé",
                "Pas d’Internet",
                "Le PC est en veille"
            },
            ReponseCorrecte = 2
        },

        new QuestionSeed {
            Id = 3,
            ModuleId = 5,
            Texte = "Que faire si un programme ne s’ouvre pas ?",
            Options = new List<string> {
                "Fermer puis rouvrir le programme",
                "Supprimer Windows",
                "Changer le clavier",
                "Éteindre l’écran"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 4,
            ModuleId = 5,
            Texte = "Comment vérifier un problème de son ?",
            Options = new List<string> {
                "Regarder si le son est coupé",
                "Changer de souris",
                "Ouvrir la calculatrice",
                "Supprimer un fichier"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 5,
            ModuleId = 5,
            Texte = "Que faire si tu as oublié ton mot de passe ?",
            Options = new List<string> {
                "Cliquer sur « Mot de passe oublié ? »",
                "Redémarrer l’ordinateur",
                "Créer un nouveau compte",
                "Appuyer sur Échap"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 6,
            ModuleId = 5,
            Texte = "Pourquoi un redémarrage aide souvent ?",
            Options = new List<string> {
                "Cela supprime Internet",
                "Cela ferme les programmes bloqués",
                "Cela efface les fichiers",
                "Cela change le mot de passe"
            },
            ReponseCorrecte = 1
        },

        new QuestionSeed {
            Id = 7,
            ModuleId = 5,
            Texte = "Que faire si le Wi-Fi ne fonctionne plus ?",
            Options = new List<string> {
                "Vérifier si le routeur est allumé",
                "Changer de clavier",
                "Supprimer le navigateur",
                "Éteindre l’écran"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 8,
            ModuleId = 5,
            Texte = "Comment tester rapidement si Internet fonctionne ?",
            Options = new List<string> {
                "Ouvrir Google et écrire « météo »",
                "Ouvrir la calculatrice",
                "Changer la langue du clavier",
                "Fermer toutes les fenêtres"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 9,
            ModuleId = 5,
            Texte = "Que vérifier si un mot de passe ne fonctionne pas ?",
            Options = new List<string> {
                "Si la touche Maj (majuscules) est activée",
                "Si la souris est branchée",
                "Si l’écran est propre",
                "Si la batterie est pleine"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 10,
            ModuleId = 5,
            Texte = "Que faire si un programme reste bloqué ?",
            Options = new List<string> {
                "Le fermer puis le rouvrir",
                "Changer de fond d’écran",
                "Supprimer le Wi-Fi",
                "Éteindre l’écran"
            },
            ReponseCorrecte = 0
        }
    };
    }

    public static List<QuestionSeed> GetQuestionsCybersécurité()
    {
        return new List<QuestionSeed>
    {
        new QuestionSeed {
            Id = 1,
            ModuleId = 6,
            Texte = "Comment reconnaître un site sécurisé ?",
            Options = new List<string> {
                "Il commence par https:// et un cadenas apparaît",
                "Il a beaucoup de couleurs",
                "Il affiche des publicités",
                "Il demande toujours votre mot de passe"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 2,
            ModuleId = 6,
            Texte = "Quel est un exemple de transaction en ligne ?",
            Options = new List<string> {
                "Changer le fond d’écran",
                "Acheter un produit ou remplir un formulaire",
                "Éteindre l’ordinateur",
                "Installer une imprimante"
            },
            ReponseCorrecte = 1
        },

        new QuestionSeed {
            Id = 3,
            ModuleId = 6,
            Texte = "Quel signe peut indiquer un courriel frauduleux ?",
            Options = new List<string> {
                "Une demande urgente",
                "Un message de votre ami",
                "Un courriel sans fautes",
                "Une facture que vous attendiez"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 4,
            ModuleId = 6,
            Texte = "Quel élément NE doit jamais être partagé ?",
            Options = new List<string> {
                "Votre numéro d’assurance sociale (NAS)",
                "Votre prénom",
                "Votre ville",
                "Votre couleur préférée"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 5,
            ModuleId = 6,
            Texte = "Qu’est‑ce qu’un mot de passe fort ?",
            Options = new List<string> {
                "Un mot simple comme 'bonjour'",
                "Un mot de passe avec 12 caractères, majuscules, chiffres et symboles",
                "Votre date de naissance",
                "Votre prénom"
            },
            ReponseCorrecte = 1
        },

        new QuestionSeed {
            Id = 6,
            ModuleId = 6,
            Texte = "À quoi sert la vérification en deux étapes (2FA) ?",
            Options = new List<string> {
                "À changer la couleur du site",
                "À recevoir un code pour confirmer votre identité",
                "À accélérer Internet",
                "À supprimer les virus"
            },
            ReponseCorrecte = 1
        },

        new QuestionSeed {
            Id = 7,
            ModuleId = 6,
            Texte = "Quel est un signe d’un faux site ?",
            Options = new List<string> {
                "Le prix est trop beau pour être vrai",
                "Le site est connu",
                "Le site commence par https://",
                "Le site a un cadenas"
            },
            ReponseCorrecte = 0
        },

        new QuestionSeed {
            Id = 8,
            ModuleId = 6,
            Texte = "Quel mode de paiement est sécurisé ?",
            Options = new List<string> {
                "Envoyer une photo de sa carte",
                "Payer via PayPal ou carte de crédit",
                "Donner son code par SMS",
                "Payer en cliquant sur un lien suspect"
            },
            ReponseCorrecte = 1
        },

        new QuestionSeed {
            Id = 9,
            ModuleId = 6,
            Texte = "Que faire si un message semble bizarre ?",
            Options = new List<string> {
                "Cliquer sur le lien pour vérifier",
                "Répondre rapidement",
                "Ne pas cliquer et supprimer le message",
                "Envoyer ses informations"
            },
            ReponseCorrecte = 2
        },

        new QuestionSeed {
            Id = 10,
            ModuleId = 6,
            Texte = "Quel est un bon réflexe de sécurité ?",
            Options = new List<string> {
                "Mettre à jour l’ordinateur",
                "Utiliser le même mot de passe partout",
                "Cliquer sur toutes les offres",
                "Partager ses codes par SMS"
            },
            ReponseCorrecte = 0
        }
    };
    }
}