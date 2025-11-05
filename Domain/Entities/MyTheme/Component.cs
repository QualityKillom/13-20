namespace Domain.Entities;

public class Component
{
    private int id;
    private string name;
    private string category;
    private decimal price;
    private int stockQuantity;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Category { get => category; set => category = value; }
    public decimal Price { get => price; set => price = value; }
    public int StockQuantity { get => stockQuantity; set => stockQuantity = value; }

    public Component() { }
    public Component(int id, string name, string category, decimal price, int stockQuantity)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.price = price;
        this.stockQuantity = stockQuantity;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Component (Name, Category, Price, StockQuantity) VALUES (@Name, @Category, @Price, @StockQuantity)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@StockQuantity", StockQuantity);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Component SET Name = @Name, Category = @Category, Price = @Price, StockQuantity = @StockQuantity WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@StockQuantity", StockQuantity);
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
            string query = "DELETE FROM Component WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}