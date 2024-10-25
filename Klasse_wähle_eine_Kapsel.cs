namespace Text_Adventure_Console_Game
{
    internal static class Klasse_wähle_eine_Kapsel
    {

        public static void Kapsel_Wählen_Rot_oder_Blau()
        {
            while (true/*Kapsel_wählen == "rot" | Kapsel_wählen == "blau"*/)
            {
                string Kapsel_wählen = Console.ReadLine();
                if (Kapsel_wählen == "rot")
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 12);
                    Console.WriteLine("Du nimmst die rote Kapsel mit einem schluck Wasser.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.SetCursorPosition(30, 12);
                    Console.WriteLine("Du fühlst eine kälte die anfängt dich zu durchströmen.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else if (Kapsel_wählen == "blau")
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 12);
                    Console.WriteLine("Du wachst in deinem Bett auf und machst dich fertig zur Arbeit alles ist wie immer.");
                    Console.SetCursorPosition(40, 13);
                    Console.WriteLine("******GAME OVER******");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Klasse_Jpeg_to_Asci_Generator.Kapsel_wählen_Bild();
                    Console.SetCursorPosition(30, 14);
                    Console.WriteLine("Falsche Auswahl, wähle die rote oder die blaue Kapsel, gib rot oder blau ein!");
                    //Thread.Sleep(2000);
                    //Console.Clear();
                }
            }
        }

        public static void Enter_The_Matrix()
        {
            while (true)
            {
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("YOU ENTER THE MATRIX");
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                break;
            }
        }
    }
}