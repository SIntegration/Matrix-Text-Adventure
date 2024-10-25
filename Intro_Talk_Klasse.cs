using System;
using Text_Adventure_Console_Game;

internal static class Intro_Talk_Klasse
{

    public static void Intro_Talk()
    {
        Console.SetCursorPosition(40,12);
        Console.WriteLine("Kapitel 1: Aufwachen");
        Console.ReadKey();
        Console.Clear();
        Klasse_Jpeg_to_Asci_Generator.Intro_talk_Bild();
        Console.SetCursorPosition(40, 12);
        Console.WriteLine("Wake up, Neo...");
        Console.ReadKey();
        Console.Clear();
        Console.SetCursorPosition(40, 12);
        Console.WriteLine("Die Matrix hat dich...");
        Console.ReadKey();
        Console.Clear();
        Console.SetCursorPosition(40, 12);
        Console.WriteLine("Folge dem weißen Haasen...");
        Console.ReadKey();
        Console.Clear();
        Console.SetCursorPosition(40, 12);
        Console.WriteLine("Knock,Knock,NEO.");
        Console.ReadKey();
        Console.Clear();
        Console.SetCursorPosition(40, 12);
        Console.WriteLine("Es klopft zwei mal an der Tür.");
        Console.ReadKey();
        Console.Clear();
        Console.SetCursorPosition(30, 12);
        Console.WriteLine("Möchtest du zur Tür gehen oder so machen als wärst du nicht da?");
        Console.SetCursorPosition(40, 13);
        Console.Write("> ");
    }
}