# Text_Adventure_Console_Game
Dies ist die Readme bzw. Teil der Dokumentation zum Zwischen Projekt Fachinformatiker Anwendungsentwicklung ein 
Text Adventure Konsolen Spiel in C#, 
stark von Matrix geklaut :D aber alles selbst geschrieben usw.

[BEGIN DOKUMENTATION]

[TOOLS]
https://sketchmypic.com/       //Zuerst das zur Umwandlung eines JPG Bildes in einen Sketch(Bilder die gezeichnet sind k�nnen nicht gesketched werden)
https://ascii-generator.site/ //Dann das mit dem Sketch Bild in ASCI und dann in den Code meiner Klasse Jpeg to Asci Generator


[ERSTER TAG] 

[PLANUNG]
			Ich habe mir 6 verschiedene Projekte �berlegt welche ich mir in einer Woche zutrauen w�rde 
			und in Excalidraw simpel visuel dargestellt mit Kurzbeschreibungen wie ich diese mir vorstellen w�rde.



[ZWEITER TAG]

[PLANUNG]
			Ich habe �berlegt welches der Projekte die ich mir ausgedacht habe ich nun nehmen werde.
			Nach l�ngerem �berlegen entschied ich mich f�r das Text Adventure.

[UMSETZUNG]
			Ich habe heute den groben Text vom Anfang bis zum Ende damit ich Grundger�st habe so ausm Kopf aus dem Film genommen 
			und in vielen WriteLines, die Text Ausgabe erst mal grob geschrieben. 
			Die Entscheidungsm�glichkeiten habe ich mittels einer bzw jeweils einer f�r jede Entscheidung While schleife erstellt.
			Anschliessend war der Code so lang 76 Zeilen meine ich, dass ich die Gesamt �bersicht verlor. 
			Mittels der Gl�hbirne bei Visual Studio Code habe ich das Programm refractoriert meine ich heisst es.
			Hierzu wurden neue Klassen angelegt in welche die Methoden bzw die Texte und Entscheidungen f�r mich logisch zerstreut wurden 
			um die Lesbarkeit des Codes jedenfalls f�r mich wiederherzustellen.



[DRITTER TAG]

[PLANUNG]
			Ich �berlege wie ich ein Men� und ein Titelbild integrieren kann 
			und recherhiere hierzu auf Youtube da ich bisher nur meine zu Wissen, es geht auf umwegen Grafiken oder Bilder darzustellen.
			Eine �berlegung ist auch wie mache ich die Textausgabe mittig und vielleicht mit Einblendungseffekten auch hierzu recherchiere ich nun.
			Ich m�chte einen virtuellen W�rfel einf�gen wo man in welchem Bezug weiss ich jetzt noch nicht W�rfeln kann.
			Ein Inventar m�chte ich ebenfalls integrieren aber weiss auch noch nicht wie ich das mache mit einer Liste auf jeden Fall.
			Sobald ich von allem die grob gelernten infos zusammen habe und das Gesamt Grundger�st des Spiels steht m�chte ich mit dem ausschm�cken des spiels beginnen.
			Heisst mehr Dialoge mehr Entscheidungsm�glichkeiten und mehr wege die Handlung zu ver�ndern zus�tzliche Items Sammeln im Rucksack lagern.

[UMSETZUNG]
			Ich habe nach Recherche es geschafft jetzt mittels eines ASCi to ART generators(LINK einf�gen) 
			und eines Verbatim String literals wie ich lernte vor die G�nsef�sschen ein @ 
			damit alle Zeichen ohne die Escape Operatoren auszuwerten ausgegeben werden wie rein geschrieben.
			Somit Titelbild Check. :D Text mittig auch erledigt mit Console.SetCursorPosition(50,0) und danach die WriteLine 
            bzw 12 beim unterem Text damit er unterm Titelbild ist nicht dar�ber wie es bei 0 der Fall w�re.

[PLANUNG]	Ausprobieren ob es m�glich ist hiermit f�r jeden Dialog ein grobes szenen Bild zu implementieren.
			
[UMSETZUNG]
			(Ich dachte mir da es digital ist f�ge ich auch Code fetzen ab jetzt hinzu was ich gemacht habe, 
			 wenns wieder un�bersichtlich wird im Code, mache ich daraus Methoden und Klassen bzw. refraktoriere wieder mit der Gl�hbirne.)


[BEGINN CODE HAUPTMEN�]

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
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("****DR�CKEN SIE EINE BELIEBIGE TASTE DAMIT DAS SPIEL BEGINNT****");
            Console.ReadKey();
            Console.Clear();

[ENDE CODE HAUPTMEN�]

[GEDANKEN]

Der Methode in der neuen Klasse nach Auslagerung des Codes von oben muss immer von private auf public gestellt werden 
sonst hat die main methode keinen Zugriff habe ich gelernt.
Und ich erinnere mich so war es auch bei den Dialogen und den anderen Klassen.
Funktioniert bis hierhin alles ohne Fehler und Dau sicher sei festgehalten. 
Und ich bin so tief in der Materie wie nie zuvor. Juhu :D aber lange nicht gut oder perfekt was ich aber gerne sein m�chte.

[UMSETZUNG]

(MEIN MAINCODE AM DRITTEN TAG)

[BEGINN CODE]

            using System.Threading.Channels;


            namespace Text_Adventure_Console_Game
            {
            internal class Matrix_Adventure_Hauptcode
            {
            static void Main(string[] args)
            {
            Hauptmen�_Titelscreen.Hauptmenue();
            



            //W�rfel

            //Inventar

            //Sound




            Intro_Talk_Klasse.Intro_Talk();
            Entscheidungen.Zur_T�r_gehen();
            Von_der_Party_abhauen_an_die_T�r_gehen.Du_gehst_an_die_T�r();
            Entscheidungen.Zur_Party_gehen_oder_zuhause_bleiben();
            Von_der_Party_abhauen_an_die_T�r_gehen.Auf_der_Party();
            Entscheidungen.Warten_oder_abhauen_vor_der_Frau();
            Gespr�ch_auf_der_Party.Gespr�ch_mit_Trinity();
            //Treffen mit Morpheus
            //Wahl rote oder blaue Pille bei Wahl der Matrix Pille eskalation im Programm dann Ende als w�re man aus der Matrix gesaugt worden. :D
            //Bei wahl blaue Pille Programm ende ohne eskalation "du kehrst in dein langweiliges leben zur�ck".

            Console.SetCursorPosition(50, 12);
            Console.WriteLine("******GAME OVER******");
            }
        }
    }   

[ENDE CODE]

[GEDANKEN]
            Ich finde ihn clean zu lesen so und kanns selber nicht glauben, :D das ich auch wenns nur eine Konsolenapp ist, 
            das schon hinbekomme daran war vor der Umschulung nicht zu denken. 
            Aber ich f�hle mich zu langsam voran schreitend im lernen teils �berfordert auch 
            von Fachbegriffen oder mathematischen Operatoren oder was jetzt in die Klammer soll oder muss manchmal.
            Als Beispiel ohne die Gl�hbirne w�rde es mir schwer fallen, 
            den Code in andere Klassen korrekt formuliert zu speichern und den Main Code zu bereinigen.
            Obwohl ich es einfach finde wenn ich es mir dann nat�rlich zum lernen genau anschaue aber ausm Kopf ist was anderes.
            Ich lerne sehr viel und recherchiere etc. und gebe mir M�he. 
            Aber es dauert vermutlich einfach etwas Zeit, bis es besser auswendig im Kopf gespeichert ist.

[UMSETZUNG]
            Ich habe vor jeden Text der ausgegeben wird Console.SetCursorPosition(50,12); gesetzt damit jeder Text mittig dargestellt wird.
            Bei jedem Else in den Schleifen also wenn eine Falscheingabe erfolgte habe ich ein Console.Clear(); gesetzt 
            weil sonst der alte text noch da stand und es eine Text in Text Darstellung gab.

[UMSETZUNG]
            Ich habe mittels Random eine simple W�rfel Methode in der Klasse_Methode_W�rfeln erstellt mit Ausgabe.

[BEGINN CODE]

             internal static class Klasse_Methode_W�rfeln
    {

        public static void W�rfeln()
        {
            static int W�rfeln()
            {
                Random random = new Random();
                return random.Next(1, 7);
            }
            Console.WriteLine("W�rfelergebnis: " + W�rfeln());
        }
    }

[ENDE CODE]



[VIERTER TAG]

[PLANUNG]
        Ich besch�ftige mich seit gestern noch damit wie ich ein Bild unkompliziert in eine Konsolenapp bekomme.
        Hierzu habe ich Asci Generatoren Online gefunden wo das Bild dann ein riesen String ist mit einem @ davor.
        Das funktionierte aber die skalierung ist viel zu gro� f�r das kleine Konsolenfenster.
        Heute kam ich auf den Trichter nach einer eigenen Klasse Welche verschiedene Bilder in einer Liste abrufbar abspeichern soll.
        Ich m�chte kurz gesagt das �ber den Dialog texten ASCI bilder welche ich mit einer Ai generiere angezeigt werden im richtigen format.
        Bisher bekomme ich es seit gef�hlt viel zu langer Zeit nicht hin das zu formatieren bis jetzt oder die Konsolenaufl�sung anzupassen und 
        den Text zu vergr��ern vlt ist auch eine �berlegung aber wie ist die Frage der Fragen.
        Bis jetzt das was mich am meisten aufh�llt.

[UMSETZUNG]
        Ich habe eine Klasse erstellt Klasse_Jpeg_to_Asci_Generator welche ein Bild in ein ASCI umwandelt diese habe ich von diesem https://medium.com/@dorlugasigal/creating-ascii-art-72fcdc9aa6bd Medium Beitrag 
        abgeschrieben(da es ein Bild ist auf der Homepage).
        Code funktioniert auch allerdings falsch formatiert.
        Ich habe die Dokumentation vervollst�ndigt und die Formatierung bearbeitet um die Lesbarkeit zu erh�hen und auf aktuellem Stand ins Wochenende zu gehen.



[F�NFTER TAG]

[PLANUNG]
        Heute schreibe ich den Dialog zuende damit die Story fertig ist bis zur Wahl der Kapsel hierzu schaue ich zur Recherche die Szenen auf Youtube an.
        Dann besch�ftige ich mich weiter die W�rfel Klasse in den Code zu implementieren vlt das man W�rfelt ob man die Rote oder Blaue Nimmt hm bin mir da noch unsicher wie es bis Mittwoch sein wird im Code.
        Danach m�chte ich ja eigentlich Bilder in Asci umgewandelt richtig formatiert darstellen oberhalb des text Dialogs wie ich an Bilder komme durch Ai kein Problem, wie ich sie in Asci umwandle auch kein Thema.
        Allerdings wie ich die Zeichenfolge des Bildes dann so formatiere oder autoformatieren lasse am besten weiss ich aktuell immer noch nicht. Richtig ausgeben mit raus zoomen das es gut aussieht geht zumindest aber es �rgert mich das es nicht funktioniert wie ich m�chte gerne.

[UMSETZUNG]
        Ich habe den kompletten Dialog weiterhin mittels dieser Struktur komplettiert. (siehe unten erster Code)
        Dialog mit Morpheus bis zur Wahl der Kapsel.
        Ich habe da der Dialog 140 Zeilen hat ihn in eine Methode refraktoriert mit der Gl�hbirne und anschliesend in eine neue Klasse "Treffen_mit_Morpheus" ausgelagert.
        Um zum einen die Lesbarkeit des Codes wiederherzustellen ihn zu komprimieren optisch und die �bersicht zu behalten.
        Nun muss ich wie immer vlt geht das auch anderst aber die Methode in der Klasse auf Public stellen das diese angesprochen werden kann in meinem Main Code.
        Ich habe mittel einer while Schleife eine Wahl implementiert die blaue oder rote Kapsel zu w�hlen Code siehe unten.
        Ich habe den Code nochmals verbessert damit bei falscher Eingabe alles mittig ist mit einer Anweisung was zu tun ist siehe weiter unten, 
        unter [CODE ELSE 2.0] :D.

[BEGINN CODE DIALOG STRUKTUR]

        Console.SetCursorPosition(40, 12);            //hiermit richte ich den Text aus die erste Zahl steht hier f�r die X achse also links nach rechts die zweite f�r die Y Achse also oben nach unten. 
                                                      //Y muss je nach Stringl�nge eingestellt werden was auch nicht 100% exakt leider funktioniert gef�hlt aber ich bin bem�ht :D.
        Console.WriteLine("DIALOGTEXT INDIVIDUELL");  //Gibt mir den Dialog Text als String aus, durch WriteLine und durch die "" erkennt es, dass als String.
        Console.ReadKey();                            //Wartet auf das dr�cken einer Taste damit der Code nicht einfach durchl�uft ohne pause und man lesen kann dann eine Taste dr�cken.
        Console.Clear();                              //L�scht alle vorherigen Anzeige Elemente der Konsole das mache ich damit keine Fehler entstehen und Text in Text dargestellt wird und man nichts lesen kann.
       
[ENDE CODE DIALOG STRUKTUR]  

Unten zur While Schleife der Code, die Auswahl Methode.

[BEGINN CODE AUSWAHL]

    while (true/*Kapsel_w�hlen == "rot" | Kapsel_w�hlen == "blau"*/) //Beginn von der Schleife
            {
                string Kapsel_w�hlen = Console.ReadLine(); //Benutzereingabe einlesen (rot oder blau)
                if (Kapsel_w�hlen == "rot")                                                                                     //passiert nur wenn rot gew�hlt eingegeben wird
                {
                    Console.Clear();                                                                                            //l�scht das Konsolenfenster
                    Console.SetCursorPosition(30, 12);                                                                          //setzt die Cursor Position der n�chsten WriteLine
                    Console.WriteLine("Du nimmst die rote Kapsel mit einem schluck Wasser.");                                   //Schreibt eine Konsolen Ausgabe mit der WriteLine Methode
                    Console.ReadKey();                                                                                          //Wartet das irgendeine Taste gedr�ckt wird
                    Console.Clear();                                                            
                    Console.WriteLine("Du f�hlst eine k�lte die anf�ngt dich zu durchstr�men.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else if (Kapsel_w�hlen == "blau")                                                                               //passiert nur wenn blau gew�hlt eingegeben wird
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 12);
                    Console.WriteLine("Du wachst in deinem Bett auf und machst dich fertig zur Arbeit alles ist wie immer.");
                    Console.SetCursorPosition(40, 13);                                                                          //Hier habe ich bewusst die 13 gew�hlt das es untereinander ausgegeben wird mittig.
                    Console.WriteLine("******GAME OVER******");
                    Environment.Exit(0);                                                                                        //beendet das Programm
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 14);
                    Console.WriteLine("Falsche Auswahl, w�hle die rote oder die blaue Kapsel!");
                    Thread.Sleep(2000);                                                                                         //setzt einen Sleep Timer oder Haltepunkt f�r in dem Fall 2000 millisekunden also 2 Sekunden
                    Console.Clear();
                }
            }

[ENDE CODE AUSWAHL]

[GEDANKEN]

   Ich bin gerade beim Testen des Programms auf einen [BUG] gesto�en wenn man versucht alles durchzuskippen bis zur Eingabem�glichkeit, also dauernd [ENTER] zb gedr�ckt h�lt, 
   dann muss man anscheinend pro [ENTER] 2 sekunden mehr warten bis man wieder eine Eingabe machen kann wegen dem Sleep Timer in der While Schleife bevor die Konsole gel�scht wird hm.
   Ich verstehe nicht warum der sich addiert allerdings, vermutlich weil die Schleife sich ja so lange wiederholt bis man raus kommt mit einer der zwei richtigen Antworten.
   Ich �berlege den Sleeptimer vlt einfach raus zu nehmen das direkt gecleared wird damit m�sste es behoben sein vermutlich. :D

[BUG BEHOBEN]
   Auch wenn es ein kleiner Bug war ich habe folgende 2 Befehle auskommentiert in den Whil Schleifen jetzt kann man durchskippen und schneller testen . :)
   Allerdings dr�ckt man normal die Tasten fand ich es besser mit sleeptimer und anschliessendem Console.Clear(); aber jetzt ist es so und dokumentiert. 

   [BEGINN CODE AUSKOMMENTIERT WEGEN BUG]

                 //Thread.Sleep(2000);
                //Console.Clear();

   [ENDE CODE AUSKOMMENTIERT WEGEN BUG]


[BEGINN CODE ELSE 2.0]

            else
            {
                Console.Clear();
                Console.SetCursorPosition(30, 14);                                              //Setzt die Darstellung der Anweisung mittig bzw an die angegebenen x und y Koordinaten, 
                                                                                                //wo ich wie mehrfach erw�hnt noch nicht 100% durchblicke wie man das formatiert.
                Console.WriteLine("Falsche Eingabe, geben Sie -warten- oder -abhauen- ein");    //Anweisung bei Falscheingabe die jetzt nicht mehr verschwindet nach 2 Sekunden. 
                Console.SetCursorPosition(30, 15);                                              //das habe ich eingef�gt damit der Cursor mittig unter der Anweisung steht.
                //Thread.Sleep(2000);                                                           //auskommentiert wegen des Bug
                //Console.Clear();                                                              //auskommentiert wegen des Bug
            }

[ENDE CODE ELSE 2.0]



[SECHSTER TAG]

[PLANUNG]

Heute will ich zu jedem Kapitel eine kleinere ASCI Grafik zumindest einf�gen, 
obwohl ich eigentlich komplexere Grafiken runter skaliert einf�gen wollte aber die Konsole ist halt limitiert.
Ich m�chte den W�rfel noch implementieren die Methode funktioniert bzw die Klasse vlt auch nur als Gl�ckszahl am Anfang angezeigt das es eine Ausgabe gibt.
Dann m�chte ich nochmal versuchen indem ich die ganzen texte durchgehe durch anpassung der x und y Werte zu erreichen das alles mehr mittig gleichm��iger ist.
Farbwechsel Effekt einf�gen bevor Game Over wenn man die rote Kapsel w�hlt.
Die verwendeten Bilder im Objekte Ordner in der Projektmappe ablegen.
Alle Bilder Sketchen und ablegen auch ums besser nachvollziehen zu k�nnen, 
wie am Ende die ASCI Strings entstanden sind.
Vor Abgabe m�chte ich noch ein Fazit hinzuf�gen am Ende dieser Dokumentation.

[GEDANKEN]

Mit Grafiken und grafischer Ausgabe denke ich, 
k�nnte ich besser arbeiten freue mich das bald zu lernen.

[UMSETZUNG]

Ich habe 3 Kapitel erstellt und vor jedem Text ein Asci Bild als Verbatim String eingef�gt, 
welches nur im Vollbild Dargestellt wird aufgrund des kleinen Konsolenfensters.
Ich weiss nicht wie ich es kleiner bekomme oder das die Konsole vergr��ert startet startet


[SIEBTER TAG]

[PLANUNG]

Ich schaue nochmal �ber alles dr�ber, teste das Programm nochmal.
Packen des Projekts in eine .zip oder .rar Datei. 
Wenn alles ok ist sende ich das Programm an Herrn Lutz.
Projekt Abgeschlossen.

[ENDE DOKUMENTATION]

[FAZIT]

Ich habe viel gelernt im Vergleich zu vor der Umschulung h�tte, aber mehr lernen k�nnen wenn es keine Krankheitsausf�lle von Lehrkr�ften gegeben h�tte. 
Und ich die vollen Tage Systementwicklungs Grundlagen gehabt h�tte meiner Meinung nach.
Allerdings finde ich meinen Fortschritt gut f�r die vergangenen Umst�nde.
Mir hat es Spa� gemacht ein Projekt aus dem nichts zu erschaffen ob ich in der AE bleibe oder in die Si wechsle bleibt abzuwarten bis die Si Grundlagen Themen abgeschlossen sind was mir besser gef�llt.
Ich h�tte gerne auch hilfe bei der Praktikumssuche mit guter �bernahme Chance, da ich komplett neu in dem Bereich IT bin beruflich.
Aber zur�ck zum Projekt, ich hoffe da es ja vor allem um die Dokumentation ging das diese als gut angesehen wird.
Wenn ich in der Ae bleiben sollte m�chte ich gerne in die Blockchain Entwicklung oder in den Ai Bereich aber auch die Spieleentwicklung w�rde mich interessieren als Beispiel.
Mir fiel es auch immer leichter gef�hlt von Tag zu Tag mir im Kopf schon zu �berlegen wie ich was l�sen k�nnte und angehe bevor ich ein Zeichen schrieb,
was mir am Anfang unm�glich erschien wenn ich daran Dachte dies einmal zu k�nnen zumindest simpel meinen bisherigen F�higkeiten entsprechend.
Ich freue mich jedenfalls auf weiteren Unterricht und bin motiviert neues zu erlernen und mich zu verbessern
und anschliessend einen guten Praktikumsplatz und eine anschliessende �bernahme zu bekommen zb bei der Telekom oder Daimler oder 1&1 zb. etc.

