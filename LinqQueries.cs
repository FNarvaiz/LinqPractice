public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();

    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            var options = new System.Text.Json.JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, options);
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    //Utilizando el operador where retorna los libros que fueron publicados despues del año 2000
    public IEnumerable<Book> LibrosDespuesDel2000()
    {
        //Extension method
        //return librosCollection.Where( p => p.PublishedDate.Year >2000);

        //Query Expression
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }
    //Utilizando el operador where retorna los libros que tengan mas de 250 paginas y el titulo contenga las palabras in Action
    public IEnumerable<Book> LibrosMas250PaginasYTituloInAction()
    {
        //Extension method
        //return librosCollection.Where( p => p.PageCount > 250 && p.Title!.Contains("in Action"));

        //Query Expression
        return from l in librosCollection 
                where l.PageCount > 250 
                && l.Title!.Contains("in Action") 
                select l;
    }

    public void ImprimirResultadoAdicional(string descripcion){
        Console.WriteLine("Resultado");
        Console.WriteLine("-------------");
        Console.WriteLine(descripcion);
        Console.WriteLine("-------------");
    }
}

