using System;   
using GestionnaireDeMotsPasse;

int LongueurDePasse = outil.DemanderNombrePositifNonNul("Veuillez choisir la longueur de votre mot de passe: ");
Console.WriteLine();

int ChoixAlphabet = outil.DemanderNombreEntre("Veuillez choisir une option de mots de passes \n" +
    "1- Lettres minuscules \n" +
    "2- Lettres minuscules et majuscules \n" +
    "3- Lettres minuscules et majuscules et chiffres \n" +
    "4- Lettres minuscules, majuscules, chiffres et caractères spéciaux \n" +
    "Votre choix: ", 1, 4);

Console.WriteLine();
int nombreDeMotsDePasse = outil.DemanderNombrePositifNonNul("Combien de mots de passe voulez-vous générer ? : ");
Console.WriteLine();

string minuscule = "abcdefghijklmnopqrstuvwxyz";
string majuscule = minuscule.ToUpper();
string chiffre = "1234567890";
string caracteres_speciaux = "$%^&*!";
string Alphabet;
Random rand = new Random();

if (ChoixAlphabet == 1)
    Alphabet = minuscule;
else if (ChoixAlphabet == 2)
    Alphabet = minuscule + majuscule;
else if (ChoixAlphabet == 3)
    Alphabet = minuscule + chiffre + majuscule;
else
    Alphabet = minuscule + chiffre + majuscule + caracteres_speciaux;

int LongueurAlphabet = Alphabet.Length;

for (int j = 0; j < nombreDeMotsDePasse; j++)
{
    string MotDePasse = "";

    for (int i = 0; i < LongueurDePasse; i++)
    {
        int index = rand.Next(0, LongueurAlphabet);
        MotDePasse += Alphabet[index];
    }

    Console.WriteLine($"Mot de passe {j + 1} : {MotDePasse}");
}