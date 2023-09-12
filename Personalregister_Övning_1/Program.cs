/*

Uppgift 1 
Klasser: Personal & Lista (..känns kanske inte helt logiskt med Lista det kanske mer är en metod)

Uppgift 2 
Attribut för klassen Personal: förNamn, efterNamn, Lön.
Attribut för klassen Listan: antalPersoner.

Metoder: Write. ReadLine. Read.  

Uppgift 3
Programmet skulle inte skapa en nöjd kund 
eftersom den endast tar in namn och lön 
och ger tillbaka antalet anställda. 
Men det går endast att skriva in en person.
Så fail på det, men ni kan iaf se hur jag skrivit. 
Tyvärr inte hunnit implementera breakpoints. 

*/
using PersonalRegister;
using Listan;
using System.Xml;

namespace PersonalRegister
{
    class läggTillPersonal 
        // mer logiskt namn hade varit Personal (men använder den till att lägga till personal..
    {
        public string personalFörnamn { get; set; }
        public string personalEfternamn { get; set; }
        public int personalLön { get; set; }

    }
}
namespace Listan
{
    class ListaPersonal
    {
        public int antalPersoner { get; set; }
        // Här behöver man skapa numrerade personposter 

    }
}
namespace Personalregister_Övning_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            läggTillPersonal info = new läggTillPersonal();

            int antalPersoner = 0;

            Console.Write("Skriv förnamn: ");
            info.personalFörnamn = Console.ReadLine();

            Console.Write("Skriv efternamn: ");
            info.personalEfternamn = Console.ReadLine();

            Console.Write("Skriv lön: ");
            info.personalLön = Console.Read();
           
            antalPersoner ++;

            Console.WriteLine("Personalantalet är nu: " + antalPersoner); 

            if ( antalPersoner > 0 ) 
            {
                Console.WriteLine("PersonalRegister. Antal: " + antalPersoner + " anställ/anställda.");
            }
        }
    }
}


