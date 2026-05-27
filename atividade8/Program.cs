using System.Collections.Generic;
 
List<string> catalogo = new List<string>{"Hamburguer Especial", "Batata Rústica", "Refrigerante Artesanal"};

foreach (string item in catalogo)
{
    Console.WriteLine(item);
}

catalogo.Insert(0, "Pizza Quatro Queijos");
catalogo.Remove("Refrigerante Artesanal");

Console.WriteLine("\nCatálogo atualizado:");
foreach (string item in catalogo)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------------------------------------");

bool existeBatataRustica = catalogo.Contains("Batata Rústica");
Console.WriteLine($"Existe Batata Rústica?: {existeBatataRustica}");

Console.WriteLine("----------------------------------------");


int posicaoPizza = catalogo.IndexOf("Pizza Quatro Queijos");
Console.WriteLine($"Posição da Pizza Quatro Queijos: {posicaoPizza}");


for (int i = 0; i < catalogo.Count; i++)
{
    Console.WriteLine($"\nÍndice {i}: {catalogo[i]}");
}


Console.WriteLine($"\nQuantidade de itens no catálogo: {catalogo.Count}");
