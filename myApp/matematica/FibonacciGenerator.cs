using System;
using System.Collections.Generic;

namespace myApp{
    public class FibonacciGenerator{
        private Dictionary<int, int> dicionarioFibonacci = new Dictionary<int, int>();

        private int Fib(int n) => n < 2 ? n : FibValue(n-1)+FibValue(n-2);
        private int FibValue(int n){
            if(!dicionarioFibonacci.ContainsKey(n)){
                dicionarioFibonacci.Add(n, Fib(n));
            }
            return dicionarioFibonacci[n];
        }

        public IEnumerable<int> Generate(int n){
            for( int i = 1; i<=n; i++){
                yield return FibValue(i);
            }
        }

    }
}