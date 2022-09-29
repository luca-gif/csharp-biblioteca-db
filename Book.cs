public class Book : Document
{

    //Constructor
    public Book(int code, string title, int year, string genre, bool isAvailable, int shelfNumber, string author, int pages) : base(code, title, year, genre, shelfNumber, author)
    {
        this.TotalPages = pages;
    }

    public int TotalPages { get; set; }
}
