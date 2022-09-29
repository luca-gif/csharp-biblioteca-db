// Creo user

List<User> users = new List<User>();

users.Add(new User("Luca", "Rossi", "luca@rossi.com", "psw", 370554515));
users.Add(new User("Marco", "Versi", "marco@verdi.com", "psw", 370544415));


// Creo libri

List<Book> books = new List<Book>();

books.Add(new Book(005, "harry potter", 2014, "action", true, 15, "J.K. Rowland", 188));


// Creo Dvd

List<Dvd> dvd = new List<Dvd>();

dvd.Add(new Dvd(005, "rambo", 2014, "action", true, 145, "rambo", 109));


// Ricerca per titolo

Console.WriteLine("Cerchi un libro o un DVD?");
string search = Console.ReadLine().ToLower();

if (search == "libro")
{
    Console.WriteLine("Inserisci un titolo");
    string bookToSearch = Console.ReadLine().ToLower();

    foreach (Book book in books)
    {
        if (book.Title == bookToSearch)
        {
            Console.WriteLine(book.Title);
        }
        else
        {
            Console.WriteLine("Mi dispiace ma questo libro non è presente, scegline un altro!");
        }
    }
}

else if (search == "dvd")
{
    Console.WriteLine("Inserisci un titolo");
    string dvdToSearch = Console.ReadLine().ToLower();

    foreach (Dvd dvdItem in dvd)
    {
        if (dvdItem.Title == dvdToSearch)
        {
            Console.WriteLine(dvdItem.Title);
        }
        else
        {
            Console.WriteLine("Mi dispiace ma questo DVD non è presente, scegline un altro!");
        }
    }
}

else
{
    Console.WriteLine($"{search} non è presente, prova a cercare qualcosa di cui disponiamo.");
}

