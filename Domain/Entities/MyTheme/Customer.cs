namespace Domain.Entities;

public class Customer
{
    private int id;
    private string lastName;
    private string firstName;
    private string email;

    public int Id { get => id; set => id = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string Email { get => email; set => email = value; }

    public Customer() { }
    public Customer(int id, string lastName, string firstName, string email)
    {
        this.id = id;
        this.lastName = lastName;
        this.firstName = firstName;
        this.email = email;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Customer (LastName, FirstName, Email) VALUES (@LastName, @FirstName, @Email)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Customer SET LastName = @LastName, FirstName = @FirstName, Email = @Email WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@Email", Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Delete()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "DELETE FROM Customer WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}