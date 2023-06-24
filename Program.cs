// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

LinqQueries queries = new LinqQueries();


ImprimirValores(queries.TodaLaColeccion());

void ImprimirValores(IEnumerable<Book> list){

    string format = "{0,-60}{1,-9}{2,11}\n" ;
    Console.WriteLine(format,"Titulo", "N. Pag", "Fecha Publicacion");
    foreach( Book item in list){
        Console.WriteLine(format,item.Title, item.PageCount, item.PublishedDate!.Value.ToShortDateString());
    }
}