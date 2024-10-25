using System.Runtime.InteropServices;

namespace Text_Adventure_Console_Game
{
    internal static class Hauptmenü_Titelscreen
    {

        public static void Hauptmenue()
        {
            //Titelbild
            //Gelöst hier mit text to ASCI Art Generator und einem "Verbatim string literal" wieder was gelernt :D also ein @ vor die Gänsefüschen
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("WILLKOMMEN IN MEINEM KLEINEN");

            string titelbild = @"
            ##########################################################################################################
            #   __  __    __   ____  ____  ____  _  _      __    ____  _  _  ____  _  _  ____  __  __  ____  ____    #
            #  (  \/  )  /__\ (_  _)(  _ \(_  _)( \/ )    /__\  (  _ \( \/ )( ___)( \( )(_  _)(  )(  )(  _ \( ___)   #
            #   )    (  /(__)\  )(   )   / _)(_  )  (    /(__)\  )(_) )\  /  )__)  )  (   )(   )(__)(  )   / )__)    #
            #  (_/\/\_)(__)(__)(__) (_)\_)(____)(_/\_)  (__)(__)(____/  \/  (____)(_)\_) (__) (______)(_)\_)(____)   #
            ##########################################################################################################";
            //zentriert das Titelbild bzw den String automatisch im Konsolenfenster anhand von leerzeichen Berechnung vom Rand aus
            int consoleWidth = Console.WindowWidth;
            int textLength = titelbild.Length;
            int spaces = Math.Max((consoleWidth - textLength) / 2, 0);

            Console.WriteLine(new string(' ', spaces) + titelbild);
            //Untere Schrift
            Console.SetCursorPosition(34, 12);
            Console.WriteLine("Antwortmöglichkeiten ja oder nein nur in Kleinschreibung!");
            Console.SetCursorPosition(41, 13);
            Console.WriteLine("Kapselwahl am Ende mit rot oder blau!");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("NACH JEDEM KAPITEL KOMMT EIN ASCI BILD NUR IM VOLLBILD ANZEIGBAR!");
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("Dialoge usw Formatiert auf normale Fenstergröße");
            Console.SetCursorPosition(30, 23);
            Console.WriteLine("****DRÜCKEN SIE EINE BELIEBIGE TASTE DAMIT DAS SPIEL BEGINNT****");
            Console.SetCursorPosition(25, 26);
            Console.WriteLine("Empfohlen Fenster Maximieren, auch wenn texte dann mehr links erscheinen.");
            Console.SetCursorPosition(31, 28);
            Klasse_Methode_Würfeln.Würfeln();
            Console.ReadKey();
            Console.Clear();
        }

        public static class Vollbild
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            static extern IntPtr GetConsoleWindow();

            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            const int SW_MAXIMIZE = 3;

            public static void Vollbild_start()
            {
                IntPtr hWnd = GetConsoleWindow();
                ShowWindow(hWnd, SW_MAXIMIZE);
                Console.WriteLine("Das Konsolenfenster ist jetzt im Vollbildmodus!");
            }

            static void Start()
            {
                Vollbild_start();

            }
        }
    }
}