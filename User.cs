
public class User
{

    //Constructor
    public User(string Name, string Surname, string Email, string Password, int Phone)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Email = Email;
        this.Password = Password;
        this.Phone = Phone;
    }

    //Properties
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public int Phone { get; set; }

}
