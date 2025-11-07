namespace Domain.Entities.MyTheme;

public class Car
{
    private int id;
    private int organizationId; // Links to the rental salon (Organization)
    private string make;
    private string model;
    private int year;
    private string licensePlate;
    private decimal dailyRate;
    private bool isAvailable;

    public int Id { get => id; set => id = value; }
    public int OrganizationId { get => organizationId; set => organizationId = value; }
    public string Make { get => make; set => make = value; }
    public string Model { get => model; set => model = value; }
    public int Year { get => year; set => year = value; }
    public string LicensePlate { get => licensePlate; set => licensePlate = value; }
    public decimal DailyRate { get => dailyRate; set => dailyRate = value; }
    public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

    public Car() { }
    public Car(int id, int organizationId, string make, string model, int year, string licensePlate, decimal dailyRate, bool isAvailable)
    {
        this.id = id;
        this.organizationId = organizationId;
        this.make = make;
        this.model = model;
        this.year = year;
        this.licensePlate = licensePlate;
        this.dailyRate = dailyRate;
        this.isAvailable = isAvailable;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Car (OrganizationId, Make, Model, Year, LicensePlate, DailyRate, IsAvailable) VALUES (@OrganizationId, @Make, @Model, @Year, @LicensePlate, @DailyRate, @IsAvailable)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@OrganizationId", OrganizationId);
                cmd.Parameters.AddWithValue("@Make", Make);
                cmd.Parameters.AddWithValue("@Model", Model);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@LicensePlate", LicensePlate);
                cmd.Parameters.AddWithValue("@DailyRate", DailyRate);
                cmd.Parameters.AddWithValue("@IsAvailable", IsAvailable);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Car SET OrganizationId = @OrganizationId, Make = @Make, Model = @Model, Year = @Year, LicensePlate = @LicensePlate, DailyRate = @DailyRate, IsAvailable = @IsAvailable WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@OrganizationId", OrganizationId);
                cmd.Parameters.AddWithValue("@Make", Make);
                cmd.Parameters.AddWithValue("@Model", Model);
                cmd.Parameters.AddWithValue("@Year", Year);
                cmd.Parameters.AddWithValue("@LicensePlate", LicensePlate);
                cmd.Parameters.AddWithValue("@DailyRate", DailyRate);
                cmd.Parameters.AddWithValue("@IsAvailable", IsAvailable);
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
            string query = "DELETE FROM Car WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}