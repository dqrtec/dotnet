using System;
using System.Collections.Generic;

namespace Pet{
    public class teinandoListaAnimais{
        List<IPet> listaAnimais = new List<IPet> {
                new Dog(),
                new Cat(),
                new Dog(),
                new Dog(),
                new Cat(),
            };

        public void MostrarLista(){
            Console.WriteLine($"exitem {listaAnimais.Count}º animais na lista de animais");

            foreach(var animal in listaAnimais){
                Console.WriteLine(animal.talkToHuman());
            }
        }
    }
}