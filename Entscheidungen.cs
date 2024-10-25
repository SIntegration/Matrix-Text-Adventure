internal static class Entscheidungen
{

    public static void Zur_Tür_gehen()
    {
        while (true/*zur_tür_gehen=="ja" | zur_tür_gehen == "nein"*/)
        {
            string zur_tür_gehen = Console.ReadLine();
            if (zur_tür_gehen == "ja")
            {
                Console.Clear();
                Console.SetCursorPosition(30, 12);
                Console.WriteLine("Du gehst ein wenig paranoid zur Tür und fragst...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if (zur_tür_gehen == "nein")
            {
                Console.Clear();
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Du bist ganz still und sagst keinen Mucks, du hörst das jemand sich von der Tür entfernt.");
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("******GAME OVER******");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(20, 14);
                Console.WriteLine("Falsche Eingabe, gebe -ja- um zur Tür zu gehen oder -nein- um nicht an die Tür zu gehen ein!");
                Console.SetCursorPosition (20, 15);
                //Thread.Sleep(2000);
                //Console.Clear();
            }
        }
    }

    public static void Warten_oder_abhauen_vor_der_Frau()
    {
        while (true)
        {
            string warten_oder_abhauen = Console.ReadLine();

            if (warten_oder_abhauen == "ja")
            {
                Console.Clear();
                Console.SetCursorPosition(30, 12);
                Console.WriteLine("Du rührst dich nicht vom Fleck.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else if (warten_oder_abhauen == "nein")
            {
                Console.Clear();
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Du ziehst den schwanz ein und begibst dich zurück in dein tristes leben.");
                Console.ReadKey();
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("******GAME OVER******");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(30, 14);
                Console.WriteLine("Falsche Eingabe, geben Sie -ja um zu warten- oder -nein um abzuhauen- ein.");
                Console.SetCursorPosition(30, 15);    
                //Thread.Sleep(2000);
                //Console.Clear();
            }
        }
    }

    public static void Zur_Party_gehen_oder_zuhause_bleiben()
    {
        while (true)
        {
            string party_angebot = Console.ReadLine();

            if (party_angebot == "ja")
            {
                Console.Clear();
                Console.SetCursorPosition(30, 12);
                Console.WriteLine("Du entschliest dich zur Party zu gehen.");
                break;
            }
            else if (party_angebot == "nein")
            {
                Console.Clear();
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Du verabschiedest dich und bleibst zuhause und stellst fest das dein Computer nicht mehr funktioniert, dein Tag ist gelaufen.");
                Console.SetCursorPosition(30, 13);
                Console.WriteLine("******GAME OVER******");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(20, 14);
                Console.WriteLine("Bitte -ja- um zur Party zu gehen oder -nein- für nicht gehen eingeben!");
                //Thread.Sleep(2000);
                //Console.Clear();

            }
        }
    }
}