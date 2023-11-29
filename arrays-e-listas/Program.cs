// ### ARRAYS ###
// No array a capacidade é fixa

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 23;

// Redimensionar um Array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Percorrendo o Array com o FOR
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);   
}

// Percorrendo o Array com o FOREACH
foreach (var item in arrayInteiros)
{
    Console.WriteLine(item);
}

// ### LISTAS ###
// A capacidade da lista é dinâmica

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("PE");
listaString.Add("RS");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição #{i} - {listaString[i]}");
}

foreach (var item in listaString)
{
    Console.WriteLine(item);
}