namespace Domain.Entities;

public class PCConfiguration
{
    private int id;
    private int userId;
    private int componentId;
    private string configurationName;
    private decimal totalPrice;

    public int Id { get => id; set => id = value; }
    public int UserId { get => userId; set => userId = value; }
    public int ComponentId { get => componentId; set => componentId = value; }
    public string ConfigurationName { get => configurationName; set => configurationName = value; }
    public decimal TotalPrice { get => totalPrice; set => totalPrice = value; }

    public PCConfiguration() { }
    public PCConfiguration(int id, int userId, int componentId, string configurationName, decimal totalPrice)
    {
        this.id = id;
        this.userId = userId;
        this.componentId = componentId;
        this.configurationName = configurationName;
        this.totalPrice = totalPrice;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO PCConfiguration (UserId, ComponentId, ConfigurationName, TotalPrice) VALUES (@UserId, @ComponentId, @ConfigurationName, @TotalPrice)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@ComponentId", ComponentId);
                cmd.Parameters.AddWithValue("@ConfigurationName", ConfigurationName);
                cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE PCConfiguration SET UserId = @UserId, ComponentId = @ComponentId, ConfigurationName = @ConfigurationName, TotalPrice = @TotalPrice WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@ComponentId", ComponentId);
                cmd.Parameters.AddWithValue("@ConfigurationName", ConfigurationName);
                cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
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
            string query = "DELETE FROM PCConfiguration WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}