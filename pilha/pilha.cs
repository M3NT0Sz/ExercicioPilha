// public class Pilha
// {
//     public No topo;

//     public Pilha()
//     {
//         this.topo = null;
//     }

//     public Boolean estaVazia()
//     {
//         if (this.topo == null)
//         {
//             return (true);
//         }
//         return (false);
//     }

//     public void push(int valor)
//     {
//         No novoNo = new No(valor);

//         if (estaVazia() == true)
//         {
//             this.topo = novoNo;
//         }
//         else
//         {
//             novoNo.prox = this.topo;
//             this.topo = novoNo;
//         }
//     }

//     public No pop()
//     {
//         No noAtual = this.topo;
//         if (estaVazia())
//         {
//             Console.WriteLine("A lista esta vazia");
//         }
//         else
//         {
//             this.topo = this.topo.prox;
//         }
//         return noAtual;
//     }

//     public int QuantidadeElementos()
//     {
//         No noAtual = this.topo;
//         int contador = 0;

//         while (noAtual != null)
//         {
//             contador++;
//             noAtual = noAtual.prox;
//         }

//         Console.WriteLine("\nQuantidade de elementos na pilha: " + contador);
//         return contador;
//     }

//     public int QuantidadeElementosImpar()
//     {
//         int contador = 0;
//         No noAtual = this.topo;

//         while (noAtual != null)
//         {
//             if (noAtual.valor % 2 != 0)
//             {
//                 contador++;
//                 noAtual = noAtual.prox;
//             }
//             else
//             {
//                 noAtual = noAtual.prox;
//             }
//         }

//         Console.WriteLine("\nQuantidade de elementos impares na pilha: " + contador);
//         return contador;
//     }
//     public (Pilha positivos, Pilha negativos) SepararPositivosNegativos()
//     {
//         Pilha positivos = new Pilha();
//         Pilha negativos = new Pilha();
//         No noAtual = this.topo;

//         while (noAtual != null)
//         {
//             if (noAtual.valor >= 0)
//             {
//                 positivos.push(noAtual.valor);
//             }
//             else
//             {
//                 negativos.push(noAtual.valor);
//             }
//             noAtual = noAtual.prox;
//         }

//         Console.WriteLine("\nPilha de valores positivos:");
//         positivos.imprimir();
//         Console.WriteLine("\nPilha de valores negativos:");
//         negativos.imprimir();

//         return (positivos, negativos);
//     }

//     public void inverter()
//     {
//         Pilha pilhaAuxiliar = new Pilha();
//         while (!this.estaVazia())
//         {
//             pilhaAuxiliar.push(this.pop().valor);
//         }
//         this.topo = pilhaAuxiliar.topo;
//         Console.WriteLine("Pilha invertida:");
//         this.imprimir();
//     }

//     public void imprimir()
//     {
//         No noAtual = this.topo;

//         while (noAtual != null)
//         {
//             Console.Write(noAtual.valor + " -> ");
//             noAtual = noAtual.prox;
//         }
//     }
// }

//==============================================
public class Pilha
{
    public No topo;

    public Pilha()
    {
        this.topo = null;
    }

    public Boolean estaVazia()
    {
        if (this.topo == null)
        {
            return (true);
        }
        return (false);
    }

    public void push(string letra)
    {
        No novoNo = new No(letra);

        if (estaVazia() == true)
        {
            this.topo = novoNo;
        }
        else
        {
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public No pop()
    {
        No noAtual = this.topo;
        if (estaVazia())
        {
            Console.WriteLine("A lista esta vazia");
        }
        else
        {
            this.topo = this.topo.prox;
        }
        return noAtual;
    }

    public void inverter()
    {
        Pilha pilhaAuxiliar = new Pilha();
        while (!this.estaVazia())
        {
            pilhaAuxiliar.push(this.pop().letra);
        }
        this.topo = pilhaAuxiliar.topo;
        Console.WriteLine("\nPilha invertida:");
        this.imprimirLetras();
    }

    public void palindromo()
    {
        Pilha pilhaAuxiliar = new Pilha();
        No noAtual = this.topo;

        while (noAtual != null)
        {
            pilhaAuxiliar.push(noAtual.letra);
            noAtual = noAtual.prox;
        }

        noAtual = this.topo;
        No noAuxiliar = pilhaAuxiliar.topo;

        while (noAtual != null)
        {
            if (noAtual.letra != noAuxiliar.letra)
            {
                Console.WriteLine("\nNão é um palíndromo");
                return;
            }
            noAtual = noAtual.prox;
            noAuxiliar = noAuxiliar.prox;
        }

        Console.WriteLine("\nÉ um palíndromo");
    }

    public void imprimirLetras()
    {
        No noAtual = this.topo;

        while (noAtual != null)
        {
            Console.Write(noAtual.letra + " -> ");
            noAtual = noAtual.prox;
        }
    }
}

//==============================================