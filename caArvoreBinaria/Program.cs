using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreBinaria
{
    class Program
    {
        public static bool Igualdade(NohArvore arvore1, NohArvore arvore2)
        {
            if (Equals(arvore1,null) || Equals(arvore2,null))
            {
                return Equals(arvore1, arvore2);
            }return Equals(arvore1.valor, arvore2.valor) & Igualdade(arvore1.noEsquerda,arvore2.noEsquerda) & Igualdade(arvore1.noDireita, arvore2.noDireita);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arvore Binaria:");

            ArvoreBinaria arvoreBin = new ArvoreBinaria(); // cria a árvore -> root = null
            ArvoreBinaria arvoreBin2 = new ArvoreBinaria();
            arvoreBin.inserir(20);
            arvoreBin.inserir(18);
            arvoreBin.inserir(25);
            arvoreBin.inserir(15);
            arvoreBin.inserir(19);
            arvoreBin.inserir(30);
            arvoreBin.inserir(21);


            Console.WriteLine(arvoreBin.NumeroDeFolahas());

        } // fim do Main()
    }
}
    