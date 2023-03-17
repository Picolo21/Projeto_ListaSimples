using Projeto_ListaSimples;

class Program
{
    static void Main(string[] args)
    {
        ListItem list = new ListItem();
        Item item = new Item(21);
        list.Insert(item);
        item = new Item(22);
        list.Insert(item);
        item = new Item(10);
        list.Insert(item);
        item = new Item(40);
        list.Insert(item);
        item = new Item(25);
        list.Insert(item);
        list.Print();
    }
}
