
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TP.Aula05Exer02
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string usuario = "Aí vai dãr aaa ii eÊ";
            //Console.WriteLine("Digita uma frase para contarmos as vogais");
            //usuario = Console.ReadLine();

            string vogAce = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string vogNace = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            for (int i = 0; i < vogAce.Length; i++)
            {
                usuario = usuario.Replace(vogAce[i], vogNace[i]);
            }

            Dictionary<char, int> frequencia = new Dictionary<char, int>();

            string vogais = "aeiou";

            char[] letras = (usuario.ToLower()).ToCharArray();

            int cont = 1;


            for (int i = 0; i < letras.Length; i++)
            {
                if (vogais.Contains(letras[i]))
                {
                    if (!frequencia.ContainsKey(letras[i]))
                    {
                        frequencia.Add(letras[i], cont);
                    }

                    else if (frequencia.ContainsKey(letras[i]))
                    {
                        frequencia[letras[i]]++;
                    }
                }
            }

            foreach (KeyValuePair<char, int> par in frequencia)
            {
                Console.WriteLine($"{par.Key} ocorre {par.Value}");
            }

            //string letConc = String.Join("", letras);

            //Console.WriteLine(letConc);

        }

    }

}