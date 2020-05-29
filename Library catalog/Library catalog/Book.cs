namespace Library_catalog
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Annotation { get; set; }
        public long ISBN { get; set; }
        public string Date { get; set; }

        public Book(string title, string author, string annotation, long isbn, string date)
        {
            Title = title;
            Author = author;
            Annotation = annotation;
            ISBN = isbn;
            Date = date;
        }
    }
}