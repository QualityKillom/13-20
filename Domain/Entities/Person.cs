namespace Domain.Entities;

using Npgsql;
using System;

public class Person
    {
        private int id;
        private string lastName;
        private string firstName;
        private string middleName;
        private string phone;

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string Phone { get => phone; set => phone = value; }

        public Person() { }
        public Person(int id, string lastName, string firstName, string middleName, string phone)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.phone = phone;
        }

        public void Add()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Person (LastName, FirstName, MiddleName, Phone) VALUES (@LastName, @FirstName, @MiddleName, @Phone)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", Phone ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Person SET LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName, Phone = @Phone WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", MiddleName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", Phone ?? (object)DBNull.Value);
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
                string query = "DELETE FROM Person WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }