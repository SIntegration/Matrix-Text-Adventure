using System.Threading.Channels;
using System.Drawing;
using System.Runtime.InteropServices;


namespace Text_Adventure_Console_Game
{
    internal class Matrix_Adventure_Hauptcode : Klasse_Jpeg_to_Asci_Generator
    {
        static void Main(string[] args)
        {

            //Test Konsolenfenster Maximieren
            //Hauptmenü_Titelscreen.Vollbild.Vollbild_start();
            //obiges funktioniert nicht somit wie erwähnt,
            //Asci Bilder nur im Vollbild manuell korrekt und text nicht immer mittig

            Hauptmenü_Titelscreen.Hauptmenue();
            Klasse_Jpeg_to_Asci_Generator generator = new Klasse_Jpeg_to_Asci_Generator();
            Intro_Talk_Klasse.Intro_Talk();
            Entscheidungen.Zur_Tür_gehen();
            Von_der_Party_abhauen_an_die_Tür_gehen.Du_gehst_an_die_Tür();
            Entscheidungen.Zur_Party_gehen_oder_zuhause_bleiben();
            Von_der_Party_abhauen_an_die_Tür_gehen.Auf_der_Party();
            Entscheidungen.Warten_oder_abhauen_vor_der_Frau();
            Gespräch_auf_der_Party.Gespräch_mit_Trinity();
            Treffen_mit_Morpheus.Gespräch_mit_Morpheus();
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("******GAME OVER******");
        }
    }
}
