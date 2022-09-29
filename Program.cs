using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=biblioteca-db;Integrated Security=True";

SqlConnection connessioneSql = new SqlConnection(stringaDiConnessione);

//Aggiunge un libro

Console.WriteLine("Vuoi aggiungere un libro o un DVD?");
string add = Console.ReadLine().ToLower();

if (add == "libro")
{
	try
	{
        Console.WriteLine("Inserisci codice");
        int code = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci titolo");
        string title = Console.ReadLine();

        Console.WriteLine("Inserisci anno di produzione");
        int year = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il genere");
        string genre = Console.ReadLine();

        Console.WriteLine("E' disponibile?");
        int isAvailable = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Inserisci posizione");
        int shelfNumber = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci autore");
        string author = Console.ReadLine();

        Console.WriteLine("Inserisci pagine");
        int pages = Int32.Parse(Console.ReadLine());

        //Chiamo il metodo Open
        connessioneSql.Open();
        
        //Inserisco tutti i dati nella variabile query
        string query = "INSERT INTO books (code, title, year, genre, isAvailable, shelfNumber, author, pages) VALUES (@dato1, @dato2, @dato3, @dato4, @dato5, @dato6, @dato7, @dato8)";

        SqlCommand cmd = new SqlCommand(query, connessioneSql);

        cmd.Parameters.Add(new SqlParameter("@dato1", code));
        cmd.Parameters.Add(new SqlParameter("@dato2", title));
        cmd.Parameters.Add(new SqlParameter("@dato3", year));
        cmd.Parameters.Add(new SqlParameter("@dato4", genre));
        cmd.Parameters.Add(new SqlParameter("@dato5", isAvailable));
        cmd.Parameters.Add(new SqlParameter("@dato6", shelfNumber));
        cmd.Parameters.Add(new SqlParameter("@dato7", author));
        cmd.Parameters.Add(new SqlParameter("@dato8", pages));

        int affectedRows = cmd.ExecuteNonQuery();
    }
	catch (Exception e)
	{

        Console.WriteLine(e);
	}
}
