namespace Text_Adventure_Console_Game
{
    internal static class Klasse_Methode_Würfeln
    {

        public static void Würfeln()
        {
            static int Würfeln()
            {
                Random random = new Random();
                return random.Next(1, 43);

            }
            Console.WriteLine("PS: Ihre sinnlos gewürfelte Glückszahl, :D ist die Nummer: " + Würfeln());
        }
    }
}