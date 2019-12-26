using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Pet;
using Jogo;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var generator = new FibonacciGenerator();
            foreach(var digit in generator.Generate(15)){
                Console.WriteLine(digit);
            }
            */

            //new teinandoListaAnimais().MostrarLista();

            /*var game = new jogo();

            var startingDeck = from s in game.Suits()
                            from r in game.Ranks()
                            select new { Suit = s, Rank = r };

            var topo = startingDeck.Take(26);
            var baixo = startingDeck.SkipLast(26);
            */

            mostrar();
            Console.ReadKey();

async void mostrar(){
    Console.WriteLine("\n" + await preparar());
}

async Task<string> preparar(){
            Console.WriteLine("begin");

            Task<int> cafe =  PourCoffee();
            Task<int> ovos =  FryEggs(2);
            Task<int> bacons =  FryBacon(3);

            int o = await ovos;
            int b = await bacons;
            int c = await cafe;
            

            return "Breakfast is ready!";
}


            async Task<int> PourCoffee(){
                Task<int> rTask = esperar(1);
                int r = await rTask;
                Console.WriteLine("coffee is ready");
                return r;
            }

            async Task<int> FryEggs(int Qtd_eeg){
                Task<int> rTask = esperar(Qtd_eeg);
                int r = await rTask;
                Console.WriteLine("eggs are ready");
                return r;
            }

            async Task<int> FryBacon(int Qtd_bacon){
                Task<int> rTask = esperar(Qtd_bacon);
                int r = await rTask;
                Console.WriteLine("bacon is ready");
                return r;
            }

            async Task<int> esperar(int n){
                int contador = 1;

                for(int i=1; i<=n; i++){
                    //Thread.Sleep(1000);
                    await Task.Delay(1000);
                    contador *=i;
                }

                return contador;
            }

        }
    }
}
