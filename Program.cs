using static System.Console;

string[] nomes = {"Eduardo", "Joao", "Adrian", "Vinicius", "Paulo"};
WriteLine("O tamanho do array é: " + nomes.Length);
Array.Sort(nomes);
WriteLine("Os nomes são....");
foreach(string nome in nomes)
{
    WriteLine(nome);
}
WriteLine();
string novonome = "Ariel";
List<string> adnome = new List<String>(nomes.ToList());
adnome.Add(novonome);
nomes = adnome.ToArray();
WriteLine("O tamanho do array é: "+ nomes.Length);
Array.Sort(nomes);
WriteLine("Os nomes são......");
foreach (var item in nomes)
{
    WriteLine(item);
}
ReadKey();


