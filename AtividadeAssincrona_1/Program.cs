using System;
using System.Collections.Generic;

namespace AtividadeAssincrona_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_VALOR = 1000;
            const int MAX_VALOR_5000 = 5000;
            int count = 0;
            int contadorInstrucoes = 0;
            List<long> ListaInteiro = new List<long>();

            DateTime DataAtual;
            int Alternador = 10;

            DateTime InicioAlgoritmo = DateTime.Now;

            Console.WriteLine("TEMPO INICIAL: " + InicioAlgoritmo.ToString("HH:mm:ss.fff"));

            for (int count_1 = 0; count_1 <= MAX_VALOR; count_1++)
            {
                DataAtual = DateTime.Now;
                Alternador += 1;
                contadorInstrucoes++;
                switch (Alternador % 4)
                {
                    case 1:
                        Alternador = 2;
                        break;
                    case 2:
                        Alternador = Alternador * 2;
                        break;
                    case 3:
                        Alternador = Alternador / 2;
                        break;
                    default:
                        Alternador = 10;
                        break;
                }
                count_1 = Alternador + count_1;

                ListaInteiro.Add(count_1);
                ListaInteiro.Add(Alternador);

                contadorInstrucoes++;
                if (DataAtual.Ticks % 10 != 1)
                {
                    count_1 -= 1; 
                }
                else if (DataAtual.Ticks % 10 == 9)
                {
                    count_1 -= 2; 
                }
                else
                {
                    continue;
                }
                    
            }

            while(count < MAX_VALOR_5000)
            {
                ListaInteiro.Add(count);
                DataAtual = DateTime.Now;

                contadorInstrucoes++;
                if (count == (MAX_VALOR_5000) / ((DataAtual.Ticks % 10) + 1))
                    count = count * 2;
                else
                    count++;
            }

            for(int i = 0; i <= MAX_VALOR; i++)
            {
                contadorInstrucoes++;
                for (int j = 0; j <= MAX_VALOR_5000; j++)
                {
                    contadorInstrucoes++;
                }
            }

            contadorInstrucoes++;
            for (int k = 0; k <= MAX_VALOR; k++)
            {
                if (ListaInteiro.Exists(x => x == DateTime.Now.Ticks % 100))
                    k--;
                else
                    continue;
            }

            contadorInstrucoes++;
            for (int p = 0; p <= MAX_VALOR_5000; p++)
            {
                DateTime aux = DateTime.Now;
                DataAtual = aux;
            }

            contadorInstrucoes++;
            int X = 1;
            while (contadorInstrucoes % X == 0)
            {
                X++;
                contadorInstrucoes++;
                if (X < contadorInstrucoes)
                    ListaInteiro.Add(X);
                else
                    break;
            }

            contadorInstrucoes++;
            ListaInteiro.ForEach(x => x = x * 2);
            contadorInstrucoes++;
            ListaInteiro.ForEach(x => x = (x == 10 ? DateTime.Now.Ticks : 1));

            DateTime FimAlgoritmo = DateTime.Now;

            
            Console.WriteLine("TEMPO FINAL: " + FimAlgoritmo.ToString("HH:mm:ss.fff"));
            Console.WriteLine("TOTAL DE INSTRUÇÕES: " + contadorInstrucoes);
        }
    }
}
