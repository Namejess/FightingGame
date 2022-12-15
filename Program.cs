namespace FightingGame
{
    public class Program
    {
        private static bool next;

        static void Main(string[] args)
        { 
            Menu();
        }

        public static void Play(Character namePlayer)
        {
            Player player = new Player("Loup enragé");
            bool victory = true;
            bool Next = false;

            while (!player.IsDead())
            {
                //tour du player 
                Console.ForegroundColor = ConsoleColor.Red;
                player.Tackle(namePlayer);
                Console.WriteLine();
                //pour ne pas l'afficher 
                Console.ReadKey(true);

                if(player.IsDead())
                {
                    victory = false;
                    break;
                }

                //degats infliger par le character
                Console.ForegroundColor = ConsoleColor.Green;
                namePlayer.Tackle(player);
                Console.WriteLine();
                //pour ne pas l'afficher 
                Console.ReadKey(true);
            }

            if (victory)
            {
                namePlayer.gainXP(5);

                // a chaque fin de combat on affiche les caracteristiques
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(namePlayer.Feature());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!Next)
                {
                    Console.WriteLine("Salle suivante ? (O/N) ");
                    string capture = Console.ReadLine().ToUpper();
                    if(capture == "O")
                    {
                        next = true;
                        Play(namePlayer);
                    }
                    else if(capture == "N")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("C'est perdu... !!");
                Console.ReadKey();
            }
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Le game");
            Console.WriteLine("");
            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine("1. Soigneur ");
            Console.WriteLine("2. Mage ");
            Console.WriteLine("3. Guerrier ");
            Console.WriteLine("4. Quitter ");
            Console.WriteLine("");

            //default = else 
            switch (Console.ReadLine())
            {
                //on instancie un new guerrier 
                case "1":
                    Console.WriteLine("Vous avez choisis le Guerrier !");
                    Console.WriteLine("");
                    Play(new Warrior("Pentimiax"));
                    break;

                case "2":
                    Console.WriteLine("Vous avez choisis le Mage !");
                    Console.WriteLine("");
                    Play(new Warrior("Pentimiax"));
                    break;

                case "3":
                    Console.WriteLine("Vous avez choisis le Soigneur !");
                    Console.WriteLine("");
                    Play(new Warrior("Pentimiax"));
                    break;

                case "4":
                    break;
            }

        }
    }
}