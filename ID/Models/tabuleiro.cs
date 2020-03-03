using System;

namespace Models.Tabuleiro
{
    public class Tabuleiro{
        int[] _posicoes;
        public Tabuleiro(int[] posicoes){
            _posicoes = posicoes;
        }
        public Tabuleiro(bool Inicial){
            _posicoes = new int[]{4,4,4,4,4,4,0,4,4,4,4,4,4,0};
        }
        public int pontosFavor(){
            return this._posicoes[6];
        }
        public int pontosContra(){
            return this._posicoes[13];
        }
        public Tabuleiro Movimentar(int jogador, int posicao){
            int[] posicoes = this._posicoes;
            int jogada = jogador*7 + posicao;
            int bolas = posicoes[jogada];
            posicoes[jogada] = 0;
            for (int i = 1; i <= bolas; i++)
            {
                int adicionar = (jogada+i)%14;
                posicoes[adicionar] += 1;
                if(i == bolas){
                    
                }
            }

            return new Tabuleiro(posicoes);
        }

        public void Desenhar(){
            Console.WriteLine($"{this._posicoes[13]} {this._posicoes[12]} {this._posicoes[11]} {this._posicoes[10]} {this._posicoes[9]} {this._posicoes[8]} {this._posicoes[7]}");
            Console.WriteLine($"  {this._posicoes[0]} {this._posicoes[1]} {this._posicoes[2]} {this._posicoes[3]} {this._posicoes[4]} {this._posicoes[5]} {this._posicoes[6]}");
        }
    }
}