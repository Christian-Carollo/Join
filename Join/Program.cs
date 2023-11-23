using Join;

List<Categoria> listaCategorie = new() { new Categoria("Alimentare", 1), new Categoria("Fai da te", 2) };

List<Prodotto> listaProdotti = new() { new Prodotto (1, "Pasta", 1 ), new Prodotto ( 2,"Martello", 2 ) };


var risultato = listaCategorie.GroupJoin(listaProdotti, categoria => categoria.id, prodotto=> prodotto.categorieId, (categoria, matchingProdotti)=> new { CategoriaNome = categoria.nome, Prodotti = matchingProdotti.Select(prodotto=> prodotto.nome)});

foreach(var elemento in risultato)
{
    Console.WriteLine($"Categoria: {elemento.CategoriaNome}");
    Console.WriteLine($"\nProdotti:{string.Join(" - ",elemento.Prodotti)}\n");
}
