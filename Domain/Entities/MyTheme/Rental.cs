namespace Domain.Entities.MyTheme;

public class Rental
{
    private int id;
    private int personId; // Customer who rents the car
    private int carId; // The rented car
    private int organizationId; // The rental salon
    private DateTime startDate;
    private DateTime? endDate;
    private decimal totalCost;

    public int Id { get => id; set => id = value; }
    public int PersonId { get => personId; set => personId = value; }
    public int CarId { get => carId; set => carId = value; }
    public int OrganizationId { get => organizationId; set => organizationId = value; }
    public DateTime StartDate { get => startDate; set => startDate = value; }
    public DateTime? EndDate { get => endDate; set => endDate = value; }
    public decimal TotalCost { get => totalCost; set => totalCost = value; }

    public Rental() { }
    public Rental(int id, int personId, int carId, int organizationId, DateTime startDate, DateTime? endDate, decimal totalCost)
    {
        this.id = id;
        this.personId = personId;
        this.carId = carId;
        this.organizationId = organizationId;
        this.startDate = startDate;
        this.endDate = endDate;
        this.totalCost = totalCost;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Rental (PersonId, CarId, OrganizationId, StartDate, EndDate, TotalCost) VALUES (@PersonId, @CarId, @OrganizationId, @StartDate, @EndDate, @TotalCost)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonId", PersonId);
                cmd.Parameters.AddWithValue("@CarId", CarId);
                cmd.Parameters.AddWithValue("@OrganizationId", OrganizationId);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TotalCost", TotalCost);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Rental SET PersonId = @PersonId, CarId = @CarId, OrganizationId = @OrganizationId, StartDate = @StartDate, EndDate = @EndDate, TotalCost = @TotalCost WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonId", PersonId);
                cmd.Parameters.AddWithValue("@CarId", CarId);
                cmd.Parameters.AddWithValue("@OrganizationId", OrganizationId);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TotalCost", TotalCost);
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
            string query = "DELETE FROM Rental WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}