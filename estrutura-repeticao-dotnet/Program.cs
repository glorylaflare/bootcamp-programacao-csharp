int numero = 5;

Console.WriteLine("### For ###");
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");  
}

Console.WriteLine("### While ###");
int cont = 0;
while (cont <= 5)
{
    Console.WriteLine($"{numero} * {cont} = {numero * cont}");
    cont++;
}

Console.WriteLine("### While ###");
int soma = 0, num = 0;

do 
{
    Console.WriteLine("Digite um número (0 para parar)");
    num = Convert.ToInt32(Console.ReadLine());
    soma += num;

} while (num != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");