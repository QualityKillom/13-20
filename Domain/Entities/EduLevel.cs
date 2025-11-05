namespace Domain.Entities;

using Npgsql;
using System;

public class EduLevel
{
    private int id;
    private string name;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }

    public EduLevel() { }
    public EduLevel(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO EduLevel (Name) VALUES (@Name)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE EduLevel SET Name = @Name WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", Name);
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
            string query = "DELETE FROM EduLevel WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}