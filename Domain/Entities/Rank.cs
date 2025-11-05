namespace Domain.Entities;
using Npgsql;

public class Rank
{
    private int id;
    private string title;
    private decimal salary;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Rank() { }
    public Rank(int id, string title, decimal salary)
    {
        this.id = id;
        this.title = title;
        this.salary = salary;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Rank (Title, Salary) VALUES (@Title, @Salary)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Rank SET Title = @Title, Salary = @Salary WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Salary", Salary);
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
            string query = "DELETE FROM Rank WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}