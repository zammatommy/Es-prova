using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_interrgazione
{
    class Program
    {

        vbvbbbvbvbv
            oooojjj
            kkk
             curuivrpuevrbyvh
        static void Main(string[] args)
        {
            // Delegato      // Metodo
            Thread t1 = new Thread(new ThreadStart(Threads.PrimoThread));   //Oggetto per il primo thread, si riferisce al metodo "Threads.PrimoThread"
            Thread t2 = new Thread(new ThreadStart(Threads.SecondoThread)); //Oggetto per il secondo thread, si riferisce al metodo "Threads.SecondoThread"

            t1.Start(); //Avvia primo thread
            t2.Start(); //Avvia secondo thread
            try
            {
                t1.Abort();
            }
            catch
            {
                Console.WriteLine("eccezione per luccisione di un tHread");
            }


            //Ciclo che verrà eseguito in parallelo
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main{0} " + i);
            }

            Console.ReadKey();
        }
    }

    class Threads //Classe che contiene i thread che verranno lanciati
    {
        public static void PrimoThread() //Metodo del primo thread
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread 1: " + i);
            }
        }

        public static void SecondoThread() //Metodo del secondo thread
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 2: " + i);
            }

        }
    }
}

        }
    }
}
