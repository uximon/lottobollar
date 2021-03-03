using System;
using System.Net.NetworkInformation;

namespace Lottobollar
{
    

        class Program
        {
            public static void Main(string[] args) {



            int[] nummer = new int[10];  //gör en vektor som håller tio tal
            



            Console.WriteLine("Please enter 10 numbers: ");
            for (int i = 0; i < nummer.Length; i++)             //for-loop som tar input och deklarerar det till nummer i ordning 0-9.
            {

                Console.Write("Number {0}: ", i + 1);

                try 
                { 
                nummer[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Skriv heltal tack"); // om användare skriver något annat än heltal så minskar varvet med ett för att inte förstöra positionerna.
                    i--;
                }

                
            }

            Console.WriteLine("Kanon, nu kommer 2 nummer slumpas fram....");
            Console.WriteLine();
            Console.WriteLine("Klicka på enter när du känner dig redo!");
            Console.ReadKey();
            Console.WriteLine();


            Random randomobject = new Random();
            int[] arrayrandom = new int[2]; //gör en vektor som håller 2 random nummer så att vi kan styra positionerna induviduellt.


            do
            {
                arrayrandom[0] = randomobject.Next(1, 26); //precis som vi gör här
                arrayrandom[1] = randomobject.Next(1, 26);

            } while (arrayrandom[0] == arrayrandom[1]); //slumpa om medan de är samma tal, vi vill inte ha dubbleringar.



            int correct0 = 0;  // deklarerar de rätta svaren för att kunna använda det i loopen och sedan if-satsen som vilkor.
            int correct1 = 0;

            for (int i = 0; i < nummer.Length; i++)
            {
                if (arrayrandom[0] == nummer[i])            // När arrayrandom[0] == nummer[i] så blir correct av värde 1 som då indikerar att de matchar med något av talen i nummer[i]
                    correct0 = i + 1;
                if (arrayrandom[1] == nummer[i])
                    correct1 = i + 1;
            }


            Console.Write("Talen blev {0} och {1}. ", arrayrandom[0], arrayrandom[1]);  //alla olika vilkor bara. correct blir större än nåll när den har hittat en matchning.

            if (correct0 > 0 && correct1 > 0)
                Console.WriteLine("Grattis! Båda matchade! Du vann ett vokabulär på 1300 ord.");

            else if (correct0 > 0)
                Console.WriteLine("Nr {0} matchade med dina gissningar. Du vann en relativt stor kaka.", arrayrandom[0]);

            else if (correct1 > 0)
                Console.WriteLine("Nr {0} matchade med dina gissningar. Du vann en relativt stor kaka.", arrayrandom[1]);

           
            else
                Console.WriteLine("Tyvärr matchade inte någon av dina gissningar.");

            Console.Write("Tryck enter för att avsluta:");
            Console.ReadKey();
 
        }   
        }
}


