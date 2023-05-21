using TakeWhileVsWhere.Models;

List<Produto> listaProdutos = new List<Produto>();

listaProdutos.Add(new Produto(2, "Budweiser", 4.00M, 12.99M));
listaProdutos.Add(new Produto(1, "Heineken", 5.99M, 14.99M));
listaProdutos.Add(new Produto(3, "Stella Artois", 4.99M, 13.99M));
listaProdutos.Add(new Produto(4, "Corona Extra", 5.99M, 14.99M));
listaProdutos.Add(new Produto(5, "Brahma Chopp", 0.99M, 2.99M));

//// TakeWhile()
///  Listará até encontrar um valor contrário a condição da expressão!
var list01 = listaProdutos.TakeWhile(prod => prod.Custo <= 4.99M).ToList();
Console.WriteLine($"Exibindo os elemento retornados através do TakeWhile() => {list01.Count()}");
foreach (var item in list01)
{
    Console.WriteLine($"Id = {item.Id} Nome = {item.Nome}, Custo = {item.Custo.ToString("C2")} Preço = {item.Preco.ToString("C2")}");
}

//// While()
///  Listará todos os elementos que satisfaçam a condição da expressão!
var list02 = listaProdutos.Where(prod => prod.Custo <= 4.99M).ToList();
Console.WriteLine($"Exibindo os elemento retornados através do Where() => {list02.Count()}");
foreach (var item in list02)
{
    Console.WriteLine($"Id = {item.Id} Nome = {item.Nome}, Custo = {item.Custo.ToString("C2")} Preço = {item.Preco.ToString("C2")}");
}
