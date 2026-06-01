using System.Collections.Generic;
 
List<string> catalogo = new List<string>{"Hamburguer Especial", "Batata Rústica", "Refrigerante Artesanal"};

static void ExibirCatalogo(List<string> catalogo)
{
    foreach (string item in catalogo)
    {
    Console.WriteLine(item);
    }
}
Console.WriteLine("\nMenu: ");

ExibirCatalogo(catalogo);


catalogo.Insert(0, "Pizza Quatro Queijos");
catalogo.Remove("Refrigerante Artesanal");

Console.WriteLine("\nMenu atualizado:");

ExibirCatalogo(catalogo);

Console.WriteLine("----------------------------------------");
static void verificarItem(List<string> catalogo, string item)
{
    bool Existe = catalogo.Contains(item);
    Console.WriteLine($"Existe {item}? {Existe}");
}

verificarItem(catalogo, "Batata Rústica");

Console.WriteLine("----------------------------------------");

static void VerificarPosicao(List<string> catalogo, string item)
{
    int posicao = catalogo.IndexOf(item);
    Console.WriteLine($"A posição do item {item} é: {posicao}");
}

VerificarPosicao(catalogo, "Pizza Quatro Queijos");

Console.WriteLine("----------------------------------------");

static void VerificarQuantidade(List<string> catalogo)
{
    for (int i = 0; i < catalogo.Count; i++)
    {
        Console.WriteLine($"\nÍndice {i}: {catalogo[i]}");
    }

}

Console.WriteLine("\nQuantidade de itens no catálogo:");
VerificarQuantidade(catalogo);
