using execoes_dotnet.Models;

new ExemploExcecoes().Metodo1();

try 
{
    string[] linhas = File.ReadAllLines("File/arquivoLeitura.txt");

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally 
{
    Console.WriteLine("Chegou até aqui");
}