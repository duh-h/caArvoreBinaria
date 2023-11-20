using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreBinaria
{
    internal class NohArvore
    {
        // atributos
        public int valor;
        public int altura;
        public NohArvore noEsquerda; // sae
        public NohArvore noDireita;  // sad

        // métodos
        public NohArvore() { }

        public NohArvore(int _valor)
        {
            noEsquerda = null;
            this.valor = _valor;
            noDireita = null;
            this.altura = 1;
        }

        public int getValor()
        {
            return valor;
        }

        public void setValor(int _valor)
        {
            this.valor = _valor;
        }

        public NohArvore getNoEsquerda()
        {
            return noEsquerda;
        }

        public void setNoEsquerda(NohArvore _noEsquerda)
        {
            this.noEsquerda = _noEsquerda;
        }

        public NohArvore getNoDireita()
        {
            return noDireita;
        }

        public void setNoDireita(NohArvore _noDireita)
        {
            this.noDireita = _noDireita;
        }

    } // fim da classe NohArvore
}

