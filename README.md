# Secure Password Manager (C#)

A robust and customizable command-line password generator built with **.NET 8**. This project focuses on security, modularity, and a crash-proof user experience through advanced input validation.

## 🚀 Key Features

- **Batch Generation:** Generate multiple unique passwords in a single execution.
- **Fully Customizable:** - Adjustable password length.
    - 4 Complexity Levels (Lowercase, Uppercase, Digits, Special Characters).
- **Bulletproof Validation:** Uses a dedicated utility class to handle errors (invalid characters, negative numbers, or out-of-range choices) without crashing.
- **Clean Architecture:** Separated logic between the core generator and the input utility tools for better maintainability.

## 🛠️ Project Structure

- `Program.cs`: The core engine. It manages the alphabet selection and the nested loops required for batch generation.
- `outil.cs`: A custom utility library containing static methods for secure console inputs (`DemanderNombreEntre`, `DemanderNombrePositifNonNul`).

## 💻 Installation & Usage

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.

### Steps
1. Clone the repository:
   ```bash
   git clone [https://github.com/YourUsername/PasswordManager.git](https://github.com/YourUsername/PasswordManager.git)
   Navigate to the project folder:

2.Bash
cd PasswordManager
Run the application:

3.Bash
dotnet run
# Gestionnaire de Mots de Passe / Password Manager

Un générateur de mots de passe robuste et sécurisé développé en C# (.NET 8), conçu pour offrir une personnalisation complète et une protection contre les erreurs de saisie.

---

## 🇫🇷 Version Française

### Description
Ce projet est un outil en ligne de commande qui permet de générer des mots de passe aléatoires et sécurisés. Il a été conçu avec une architecture modulaire, séparant la logique métier des outils de saisie pour garantir une expérience utilisateur fluide et sans crash.

### Fonctionnalités
- **Génération en lot :** Créez plusieurs mots de passe en une seule exécution.
- **Personnalisation totale :**
    - Choix de la longueur du mot de passe.
    - 4 niveaux de complexité (Minuscules, Majuscules, Chiffres, Caractères spéciaux).
- **Sécurité des entrées :** Gestion avancée des erreurs (validation des nombres, détection des entrées vides ou invalides) via une classe d'outils dédiée.

### Structure du Projet
- `Program.cs` : Contient la boucle principale et la logique de génération.
- `outil.cs` : Classe utilitaire pour la gestion sécurisée des entrées utilisateur dans la console.

### Installation et Utilisation
1. Clonez le dépôt.
2. Assurez-vous d'avoir le SDK .NET 8 installé.
3. Lancez le projet avec la commande :
   ```bash
   dotnet run
