using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caArvoreBinaria
{
    internal class ArvoreBinaria
    {
        // atributos 
        public NohArvore root;

        // métodos
        public ArvoreBinaria()
        {
            root = null;
        }

        public bool isEmpty()
        {
            if (root == null)
                return true;
            else
                return false;
        }

        public void inserir(int n) // aridade 1
        {
            inserir(this.root, n); // aridade 2
        }
        public void inserir(NohArvore node, int valor) // aridade 2
        {                               // 10 e 15
            if (this.root == null)
            {
                this.root = new NohArvore(valor);
            }
            else
            {
                if (valor < node.getValor())
                { // insere a esquerda
                    if (node.getNoEsquerda() != null)
                    {
                        inserir(node.getNoEsquerda(), valor);
                    }
                    else // subarvore da esquerda está vazia
                    {
                        //Se nodo esquerdo vazio insere o novo no aqui 
                        node.setNoEsquerda(new NohArvore(valor));
                    }

                    //Verifica se o valor a ser inserido é maior que o noh corrente 
                    //da árrvore, se sim vai para subarvore direita 
                }
                else if (valor > node.getValor())
                {
                    //Se tiver elemento no no direito continua a busca 
                    if (node.getNoDireita() != null)
                    {
                        inserir(node.getNoDireita(), valor);
                    }
                    else // subárvore da direita está vazia
                    {
                        //Se nodo direito vazio insere o novo no aqui 
                        node.setNoDireita(new NohArvore(valor));
                    }
                } // fim do if para inserir a direita
            }

        } // fim do metodo inserir - aridade 2

        public void imprimirArvore()
        {
            if (this.root == null)
                Console.WriteLine("Árvore vazia");
            else
                imprimirArvore(this.root);
        }

        public void imprimirArvore(NohArvore node)
        {
            if (node.getNoEsquerda() != null)
            {
                imprimirArvore(node.getNoEsquerda());
            }

            Console.WriteLine("Noh: " + node.getValor());

            if (node.getNoDireita() != null)
            {
                imprimirArvore(node.getNoDireita());
            }

        }
        public int Tamanho()
        {
            if (this.root == null)
                return 0;

            else
                return Tamanho(this.root,0);

        }
        public int Tamanho(NohArvore node, int count)
        {
            if (node == null)
            {
                return count;
            }

            int alturaEsquerda = Tamanho(node.noEsquerda, count + 1);
            int alturaDireita = Tamanho(node.noDireita, count + 1);

            return Math.Max(alturaEsquerda, alturaDireita);
        }
        public void Remove(int value)
        {
            this.root = RemoveNode(this.root, value);
        }

        private NohArvore RemoveNode(NohArvore node, int value)
        {
            if (node == null)
            {
                return node;
            }

            if (value < node.valor)
            {
                node.noEsquerda = RemoveNode(node.noEsquerda, value);
            }
            else if (value > node.valor)
            {
                node.noDireita = RemoveNode(node.noDireita, value);
            }
            else
            {
                // Caso o nó tenha sido encontrado, proceda com a remoção
                if (node.noEsquerda == null)
                {
                    return node.noDireita;
                }
                else if (node.noDireita == null)
                {
                    return node.noEsquerda;
                }

                // Nó com dois filhos: encontra o sucessor ou predecessor para manter a propriedade da árvore
                node.valor = MinValue(node.noDireita);

                // Remove o sucessor ou predecessor encontrado
                node.noDireita = RemoveNode(node.noDireita, node.valor);
            }

            return node;
        }

        private int MinValue(NohArvore node)
        {
            int minValue = node.valor;
            while (node.noEsquerda != null)
            {
                minValue = node.noEsquerda.valor;
                node = node.noEsquerda;
            }
            return minValue;
        }
        public int Quantidade()
        {
            return Quantidade(this.root);

        }

        public int Quantidade(NohArvore node)
        {
            
            if (node == null)
            {
                return 0;
            }
            int value1 = Quantidade(node.noDireita);
            int value2 = Quantidade(node.noEsquerda);
            return 1 + value1 + value2;
            

        }
        public int NumeroDeFolahas()
        {
            return NumeroDeFolahas(this.root);
            
        }
        public int NumeroDeFolahas(NohArvore noh)
        {
            if (Equals(noh, null))
            {
                return 0;
            }
            else if (Equals(noh.noEsquerda, null) & Equals(noh.noDireita, null))
            {
                return 1;

            }
            else
            {
                return 0 + NumeroDeFolahas(noh.noEsquerda)+NumeroDeFolahas(noh.noDireita);
            }
        }
        private int Altura(NohArvore node)
        {
            if (node == null)
                return 0;
            return node.altura;
        }

        
        public int FatorBalanceamento(NohArvore node)
        {
            if (node == null)
                return 0;
            return Altura(node.noEsquerda) - Altura(node.noDireita);
        }



    } 
}


/*
 *                                          4
 *                                        /   \
 *                                       2     5  
 *                                      /  \     \
 *                                     1    3     6
 *                                                 \
   *                                                7 
 * 
 * 
 *  
 * 
 * 
 * 
 * 
 * 
 * 
 */
