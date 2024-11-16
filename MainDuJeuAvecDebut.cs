namespace Boogle
{
    class Program
    {
        public static void Main(string[] args)
        {
            string langue;
            Console.WriteLine("Choose your language / Choix de langue : ");
            Console.WriteLine("Francais"); //Mettre en forme pour une liste *
            Console.WriteLine("English");
            langue = Convert.ToString(Console.ReadLine());
            if (langue != "Francais" && langue != "English") //Pour eviter tout autre langues
                if (langue == null)
                    Console.WriteLine("Please enter a correct language / Veuillez entrer une langue correct");
            Console.WriteLine(langue);

            //Déclaration de toutes les variables communes aux 2 langues ou systèmes separés?
            int tailleGrid = 4;
            int nbJoueurs = 2;
            if (langue == "Francais")
            {
                Console.WriteLine("Choix de la taille de la grille, minimum 4 par 4 : ");
                tailleGrid = Convert.ToInt32(Console.ReadLine());
                while (tailleGrid < 4)
                {
                    Console.WriteLine("Entrez une taille de grille correcte, minimum 4x4 (ex : 5) : ");
                    tailleGrid = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Combien de joueurs : ");
                nbJoueurs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrez les pseudos des joueurs : ");
                string[] joueurs = new string[nbJoueurs];
                for (int i = 0; i < nbJoueurs; i++)
                    joueurs[i] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Choose the grid, minimum 4x4 : ");
                tailleGrid = Convert.ToInt32(Console.ReadLine());
                while (tailleGrid < 4)
                {
                    Console.WriteLine("Please enter a correct grid size, minimum 4x4 (e.g. 5) : ");
                    tailleGrid = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("How many players? ");
                nbJoueurs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter player names : ");
                string[] joueurs = new string[nbJoueurs];
                for (int i = 0; i < nbJoueurs; i++)
                    joueurs[i] = Console.ReadLine();


            }
        }
    }
}