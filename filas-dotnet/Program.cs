//### FILA ###
Queue<int> fila = new Queue<int>();

fila.Enqueue(2); //Adiciona um elemento na fila
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue(); //Remove um elemento da fila

//### PILHA ###
Stack<int> pilha = new Stack<int>();
pilha.Push(2); //Adiciona um elemento na pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop(); //Remove um elemento da fila

//## DICIONÁRIO ##
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("PE", "Pernambuco");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("PE");

//Alterando o valor de uma chave
estados["SP"] = "São Paulo (2)";
foreach (var i in estados)
{
    Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
}
//Verificando se uma chave existe ou não
string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else 
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}
//Consultando valor através de uma chave
Console.WriteLine(estados["SP"]);