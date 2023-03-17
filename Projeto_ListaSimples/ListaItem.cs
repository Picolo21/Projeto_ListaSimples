using Projeto_ListaSimples;

namespace Projeto_ListaSimples
{
    internal class ListItem
    {
        public Item Begin { get; set; }
        public Item End { get; set; }
        public ListItem()
        {
            Begin = null;
            End = null;
        }
        public void Insert(Item i)
        {
            if (IsEmpty())
            {
                Begin = i;
                End = i;
            }
            else if (i.Value <= Begin.Value)
            {
                InsertFirst(i);
            }
            else if (i.Value >= End.Value)
            {
                InsertLast(i);
            }
            else
            {
                Item aux = Begin;
                while (aux.Next != null && aux.Next.Value < i.Value)
                {
                    aux = aux.Next;
                }
                i.Next = aux.Next;
                aux.Next = i;
            }
        }
        public void InsertLast(Item i)
        {
            End.Next = i;
            End = i;
        }
        public void InsertFirst(Item i)
        {
            i.Next = Begin;
            Begin = i;
            if (End == null)
            {
                End = i;
            }
        }
        public bool Find(Item f)
        {
            Item aux = Begin;
            while (aux != null)
            {
                if (aux.Value == f.Value)
                {
                    return true;
                }
                aux = aux.Next;
            }
            return false;
        }
        public bool IsEmpty()
        {
            return Begin == null;
        }
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Item aux = Begin;
                while (aux != null)
                {
                    Console.WriteLine(aux.Value);
                    aux = aux.Next;
                }
            }
        }
    }
}