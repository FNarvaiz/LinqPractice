
LinqQueries queries = new LinqQueries();

string[] items = {
        "Todos los libros",
        "Where - libros despues del 2000",
        "Where - libros mas de 250 paginas y cont titulo Action",
        "Order - Traer los libro con menos de 400 paginas ordenados por cant de pag descendiente",
        "All - Comprobar si todos los libros estan publicados",
        "Any - Comprobar si algun libro tiene mas de 500 paginas",
        "Count - Contar cuantos libros tiene el titulo que empiezan con una vocal",
        "Take - Tomar los primeros 5 libros con mas paginas",
        "Skip - Omitir los primeros 3 libros con mas paginas",
        "Take y Skip - Tomar los primeros 20 libros omitiendo los primero 10 ordenados por titulo",
        "Average - Sacar el promedio de todas las paginas de todos los libros menos los q tienen 0",
        "Agregatte - Devolver los titulos concatenados q se publicaron despues del 2015",
        "Group By - Devolver todos los libros a partir del 2000 agrupados por anio",
        "Join - Une la catidad de libros q son de C# con los libros q tienen mas de 500 paginas",
        "Salir"
};

Func<IEnumerable<Book>>[] funciones = {
    queries.TodaLaColeccion,
    queries.LibrosDespuesDel2000,
    queries.LibrosMas250PaginasYTituloInAction,
};

int valorSeleccionado = 0;

void Menu()
{

    Console.Clear();
    Console.WriteLine("Menu");
    for (int x = 0; x < items.Count(); x++)
        Console.WriteLine($"{x}. {items[x]}");

}

while (valorSeleccionado != items.Count() - 1)
{
    Menu();
    valorSeleccionado = Convert.ToInt32(Console.ReadLine()!);
    if (valorSeleccionado < funciones.Count())
        ImprimirValores(funciones[valorSeleccionado]());
}


void ImprimirValores(IEnumerable<Book> list)
{

    string format = "{0,-60}{1,-9}{2,11}\n";
    Console.WriteLine(format, "Titulo", "N. Pag", "Fecha Publicacion");
    foreach (Book item in list)
    {
        Console.WriteLine(format, item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
    Console.Read();
}


