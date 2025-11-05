namespace Domain.Entities;
public class Order
    {
        private int id;
        private int userId;
        private int configurationId;
        private DateTime? orderDate;
        private string status;

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public int ConfigurationId { get => configurationId; set => configurationId = value; }
        public DateTime? OrderDate { get => orderDate; set => orderDate = value; }
        public string Status { get => status; set => status = value; }

        public Order() { }
        public Order(int id, int userId, int configurationId, DateTime? orderDate, string status)
        {
            this.id = id;
            this.userId = userId;
            this.configurationId = configurationId;
            this.orderDate = orderDate;
            this.status = status;
        }

        public void Add()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Orders (UserId, ConfigurationId, OrderDate, Status) VALUES (@UserId, @ConfigurationId, @OrderDate, @Status)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@ConfigurationId", ConfigurationId);
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", Status ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Orders SET UserId = @UserId, ConfigurationId = @ConfigurationId, OrderDate = @OrderDate, Status = @Status WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@ConfigurationId", ConfigurationId);
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", Status ?? (object)DBNull.Value);
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
                string query = "DELETE FROM Orders WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }