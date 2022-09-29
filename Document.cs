
public class Document
{
    protected int code;
    protected string title;
    protected int year;
    protected string genre;
    protected bool isAvailable;
    protected int shelfNumber;
    protected string author;


    //Constructor

    public Document(int Code, string Title, int Year, string Genre, int ShelfNumber, string Author)
    {
        this.Code = Code;
        this.Title = Title;
        this.Year = Year;
        this.Genre = Genre;
        this.IsAvailable = IsAvailable;
        this.ShelfNumber = ShelfNumber;
        this.Author = Author;
    }


    //Properties

    public int Code { get; set; }

    public string Title { get; set; }

    public int Year { get; set; }

    public string Genre { get; set; }

    public bool IsAvailable { get; set; }

    public int ShelfNumber { get; set; }

    public string Author { get; set; }

}