public class LinqQueries{
    private List<Book> librosCollection = new List<Book>();

    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            var options = new System.Text.Json.JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, options );
        }
    }

    public IEnumerable<Book> TodaLaColeccion(){
        return librosCollection;
    }
}

