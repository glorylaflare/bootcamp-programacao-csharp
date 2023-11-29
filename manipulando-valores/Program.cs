using System.Globalization;

string numero1 = "10";
string numero2 = "20";
string resultado = numero1 + numero2;
Console.WriteLine(resultado);

//Formatando valor monetário
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 3405.33M;
Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("N2"));
//Formatando de acordo com a cultura
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

//Formatando porcentagem
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

//Formatando valores personalizados
int num = 345213;
Console.WriteLine(num.ToString("##-##-##"));

//Formatando datas
DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime dataParse = DateTime.Parse("12/09/2014 21:00:00");
Console.WriteLine(dataParse);

string dataString = "2022-04-23 18:00";
bool sucesso = DateTime.TryParseExact(dataString, 
                                        "yyyy-MM-dd HH:mm", 
                                        CultureInfo.InvariantCulture, 
                                        DateTimeStyles.None, 
                                        out DateTime dataFinal); //out significa se conseguir ou não
Console.WriteLine(dataFinal);
if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {dataFinal}");
}
else 
{
    Console.WriteLine($"{dataString} não é uma data válida");
}