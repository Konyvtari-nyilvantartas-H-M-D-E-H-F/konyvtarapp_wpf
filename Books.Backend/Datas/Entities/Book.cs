using Books.Backend.Datas.Enums;

namespace Books.Backend.Datas.Entities
{
    public class Book
    {
        public Book(Guid id, string title, string author, decimal price, string publisher, int published, BookCategoryType schoolClass, int bookLenght, string isbn, int numnerOfBooks, bool availability)
        {
            Id = id;
            Price = price;
            Title = title;
            Author = author;
            Published = published;
            Publisher = publisher;
            BookCategory = schoolClass;
            BookLength = bookLenght;
            ISBN = isbn;
            NumberOfBooks = numnerOfBooks;
            Availability= availability;
        }

        public Book(string firstName, string author, decimal price, string publisher, int published, BookCategoryType schoolClass, int bookLenght,string isbn, int numnerOfBooks, bool availability)
        {
            Id = new Guid();
            Price = price;
            Title = firstName;
            Author = author;
            Published = published;
            Publisher = publisher;
            BookCategory = schoolClass;
            BookLength = bookLenght;
            ISBN = isbn;
            NumberOfBooks = numnerOfBooks;
            Availability = availability;
        }

        public Book()
        {
            Id = new Guid();
            Price = null;
            Title = string.Empty;
            Author = string.Empty;
            Published = null;
            Publisher = string.Empty;
            BookCategory = BookCategoryType.Fantasy;
            BookLength = null;
            ISBN = string.Empty;
            NumberOfBooks = null;
            Availability = true;
        }

        public Guid Id { get; set; }
        public string Author { get; set; } 
        public string Title { get; set; }
        public int? Published { get; set; }
        public string Publisher { get; set; }
        public decimal? Price { get; set; }
        public BookCategoryType BookCategory { get; set; }
        public int? BookLength { get; set; }
        public bool Availability { get; set; }
        public string ISBN { get; set; }
        public int? NumberOfBooks {  get; set; }


        public override string ToString()
        {
            return $"A könyv címe: {Title}" +
                $"Szerző: {Author}" +
                $"Kategória: {BookCategory}" +
                $"Kiadási év: {Published}" +
                $"Kiadó: {Publisher}" +
                $"Az ISBN száma: {ISBN}" +
                $"Oldalak száma: ({BookLength})" +
                $"A könyv ára: {Price}" +
                $"könyvek száma: {NumberOfBooks}";
        }
    }
}
