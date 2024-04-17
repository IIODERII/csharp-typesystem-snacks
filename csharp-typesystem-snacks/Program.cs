using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Snack 1
            //L’utente inserisce due numeri in successione.
            //Il software stampa il maggiore.
            //Snack 2
            //L’utente inserisce due parole in successione.
            //Il software stampa prima la parola più corta, poi la parola più lunga.
            //Snack 3
            //Il software deve chiedere per 10 volte all’utente di inserire un numero.
            //Il programma stampa la somma di tutti i numeri inseriti.
            //Snack 4
            //Calcola la somma e la media dei numeri da 2 a 10.
            //Snack 5
            //Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            //Snack 6
            //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            //Snack 7
            //Crea un array vuoto.
            //Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            //Snack 8
            //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
            //Snack 9
            //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
            //Snack 10
            //Fai inserire un numero, che chiameremo N, all’utente.
            //Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            //Ogni volta che ne crei uno, stampalo a schermo.
            //{
            //    //Snack 1
            //    Console.WriteLine("Inserire il primo numero");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Inserire il secondo numero");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"Il numero più grande tra i due è {Math.Max(num1, num2)}");
            //}
            //{
            //    //Snack 2
            //    Console.WriteLine("\n\nInserire la prima parola");
            //    string word1 = Console.ReadLine();
            //    Console.WriteLine("Inserire la seconda parola");
            //        string word2 = Console.ReadLine();

            //    Console.WriteLine(word1.Length > word2.Length ? word2 : word1);
            //    Console.WriteLine(word1.Length > word2.Length ? word1 : word2);
            //}
            //{
            //    //Snack 3
            //    Console.WriteLine("\n\n");
            //    int somma = 0;
            //    for (int i = 0; i < 10; i++) {
            //        Console.WriteLine("Inserisci un numero");
            //        somma += Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine($"La somma dei numeri inseriti è: {somma}");
            //}
            //{
            //    //Snack 4
            //    int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    int somma = 0;

            //    foreach (int number in numbers)
            //    {
            //        somma += number;
            //    }

            //    Console.WriteLine($"\n\nLa somma dei numeri da 2 a 10 è: {somma}");
            //    Console.WriteLine($"La mdeia dei numeri da 2 a 10 è: {somma / numbers.Length}");
            //}
            //{
            //    //Snack 5
            //    Console.WriteLine("Inserire un numero: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if(num % 2 == 0)
            //    {
            //        Console.WriteLine($"Il numero è pari, quindi ecco il tuo numero: {num}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Il numero è dispari, quindi ecco il numero successivo: {num++}");
            //    }
            //}
            //{
            //    //Snack 6
            //    string[] invited = { "John", "Alex", "Mark", "James", "Matthew" };

            //    Console.Write("\n\nCome ti chiami?: ");
            //    string name = Console.ReadLine();

            //    if (invited.Contains(name))
            //    {
            //        Console.WriteLine($"Prego {name}, può entrare!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Mi dispiace {name} ma non la vedo sulla mia lista");
            //    }
            //}
            //{
            //    //Snack 7
            //    int[] numList = {};
            //    for(int i = 0; i < 6; i++) {
            //        Console.WriteLine("Inserire un numero:");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        if( num % 2 == 0)
            //        {
            //            Array.Resize(ref numList, numList.Length+1);
            //            numList[numList.Length - 1] = num;
            //        };
            //    }
            //    foreach (var num in numList)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //{
            //    //Snack 8
            //    int[] numList = { 2, 45, 7, 32, 3, 4, 1, 6, 4, 2, 85 };
            //    int somma = 0;
            //    for(int i = 0;i < numList.Length;i++)
            //    {
            //        if(i% 2 != 0)
            //        {
            //            somma += numList[i];
            //        }
            //    }

            //    Console.WriteLine($"La somma dei inumeri in posizione dispari è: {somma}");
            //}
            {
                //Snack 9 
                int[] numList = {};
                
                while(numList.Sum(num => num) < 50) {
                    Console.Write($"\nInserisci un numero da inserire: ");
                    Array.Resize( ref numList, numList.Length+1 );
                    int num = Convert.ToInt32(Console.ReadLine());
                    numList[numList.Length-1] = num;
                }

                Console.WriteLine($"\nEcco la tua lista:");
                foreach( int num in numList )
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine($"La somma è pari a {numList.Sum(num => num)}");
            }
        }
    }
}
