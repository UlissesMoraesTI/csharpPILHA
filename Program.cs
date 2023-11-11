Stack<int> pilha = new Stack<int>();

pilha.Push(02);
pilha.Push(04);
pilha.Push(06);
pilha.Push(08);
pilha.Push(10);
pilha.Push(12);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop}");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
