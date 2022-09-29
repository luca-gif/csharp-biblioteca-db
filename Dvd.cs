public class Dvd : Document
{

    //Constructor
    public Dvd(int code, string title, int year, string genre, bool isAvailable, int shelfNumber, string author, int durate) : base(code, title, year, genre, shelfNumber, author)
    {
        Duration = durate;
    }

    public int Duration { get; set; }

}

