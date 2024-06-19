using System;

namespace TD_AventureTexte {
    /*
        1. Le joueur est dans une forêt. Il peut aller à l'est ou à l'ouest.
            1.1. Si est = Il tombe d'une failaise et perd
            1.2. Si ouest = Il trouve un château 
        2. Le joueur est devant le château. Il peut entrer par la porte ou par la fenêtre.
            2.1. Si porte = Le garde l'arrête, il perd
            2.2. Si fenêtre il entre
        3. Le joeur est dans un couloir du château, il a la porte de gauche de droite
            3.1. Si gauche = il tombe sur les gardes et perd
            3.2. Si droite, il trouve la princesse et la sauve

        Aller plus loin :
        - Ajouter un inventaire avec une clé ou des objets 
        - Ajouter plus de chemins  
        - Ajouter un système de score, vie, magie...
    */

    class Program {
        static void Main(string[] args) {
            string readLine = null;
            while (readLine == null || (readLine.ToLower() != "est" && readLine.ToLower() != "ouest")) {
                Console.WriteLine("Vous êtes dans une forêt. Vous pouvez aller à l'est ou à l'ouest.");
                if ((readLine = Console.ReadLine()) != null) {
                    if (readLine.ToLower() == "est") {
                        Console.WriteLine("Vous tombez d'une failaise et perd");
                        Environment.Exit(0);
                    }
                    else if (readLine.ToLower() == "ouest")
                        Console.WriteLine("Vous trouvez un château");
                }
            }
            readLine = null;
            
            while (readLine == null || (readLine.ToLower() != "porte" && readLine.ToLower() != "fenêtre")) {
                Console.WriteLine("Vous êtes devant le château. Vous pouvez entrer par la porte ou par la fenêtre.");
                if ((readLine = Console.ReadLine()) != null) {
                    if (readLine.ToLower() == "porte") {
                        Console.WriteLine("Le garde vous arrête, vous perdez");
                        Environment.Exit(0);
                    }
                    else if (readLine.ToLower() == "fenêtre")
                        Console.WriteLine("Vous entrez");
                }
            }
            readLine = null;

            while (readLine == null || (readLine.ToLower() != "gauche" && readLine.ToLower() != "droite")) {
                Console.WriteLine("Vous entrez dans un couloir du château, vous avez une porte à gauche et à droite");
                if ((readLine = Console.ReadLine()) != null) {
                    if (readLine.ToLower() == "gauche") {
                        Console.WriteLine("Vous tombez sur les gardes et vous perdez");
                    }
                    else if (readLine.ToLower() == "droite") {
                        Console.WriteLine("Vous trouvez la princesse et vous la sauvez");
                    }
                }
            }
        }
    }
}
