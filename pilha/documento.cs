//EX1
public class Documento
{
    public No topo;

    public Documento()
    {
        this.topo = null;
    }

    public void push(string nome, string extensao, int tamanho)
    {
        No novoNo = new No(nome, extensao, tamanho);

        if (estaVazia())
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

    public bool consulta(string nome)
    {
        No atual = this.topo;
        while (atual != null)
        {
            if (atual.nome == nome)
            {
                Console.WriteLine("Documento encontrado: " + nome);
                return true;
            }
            atual = atual.prox;
        }
        Console.WriteLine("Documento não encontrado: " + nome);
        return false;
    }

    private bool estaVazia()
    {
        return this.topo == null;
    }

    public void imprimir()
    {
        No noAtual = this.topo;

        while (noAtual != null)
        {
            Console.Write("Nome: " + noAtual.nome + "\nExtensão: " + noAtual.extensao + "\nTamanho em KB: " + noAtual.tamanho + "\n\n");
            noAtual = noAtual.prox;
        }
    }
}