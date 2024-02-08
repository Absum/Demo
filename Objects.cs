
namespace GraphQLDemo
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class Query
    {
        public Book[] GetBooks() =>
            [
                new Book
                {
                    Title = "C# in depth.",
                    id = 1,
                    Author = new Author
                    {
                        Name = "Jon Skeet"
                    }
                },
                new Book
                {
                    Title = "C# in depth part 2.",
                    id = 2,
                    Author = new Author
                    {
                        Name = "Jon Skeet, Tomi Kaihlaniemi"
                    }
                }
            ];
        public Book? GetBook(int id)
        {
            return GetBooks().FirstOrDefault(book => book.id == id);
        }
    }
}