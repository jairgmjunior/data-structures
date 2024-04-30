using BynaryTree;

BinaryTree tree = new BinaryTree();

tree.Insert(50);
tree.Insert(10);
tree.Insert(20);
tree.Insert(80);
tree.Insert(30);
tree.Insert(5);
tree.Insert(90);
tree.Insert(40);

Console.WriteLine("Árvore em ordem (in-order traversal):");
tree.InOrderTraversal(tree.Root);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Árvore em ordem Tree:");
tree.PrintTree();
Console.WriteLine();

int valorBusca = 80;
bool encontrado = tree.Search(valorBusca);

if (encontrado)
{
    Console.WriteLine($"O valor {valorBusca} está presente na árvore.");
}
else
{
    Console.WriteLine($"O valor {valorBusca} não está presente na árvore.");
}
