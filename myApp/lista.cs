using System;
using System.Collections.Generic;

namespace myApp{
    public class lista
    {

        public List<string> listaCarros {get;} = new List<string>  {"palio","celta"};
        
        public void adicionar(){
            this.listaCarros.Add("daniel");
            this.listaCarros.Remove("celta");
            this.listaCarros.Sort();
            foreach(var carro in this.listaCarros){
                Console.WriteLine($" {carro} é muito bom");
            }
        }
    }
}