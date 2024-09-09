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

    public void push(int valor)
    {
        No novoNo = new No(valor);

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

    public int QuantidadeElementos()
    {
        int contador = 0;
        var atual = this.topo;

        while (atual != null)
        {
            contador++;
            atual = atual.prox;
        }

        Console.WriteLine("\nQuantidade de elementos na pilha: " + contador);
        return contador;
    }

    public void imprimir()
    {
        No noAtual = this.topo;

        while (noAtual != null)
        {
            Console.Write(noAtual.valor + " -> ");
            noAtual = noAtual.prox;
        }
    }
}