namespace Domain.Entities;

using Npgsql;
using System;

public class Worker
{
    private int id;
    private int personId;
    private int rankId;
    private DateTime hireDate;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public int PersonId
    {
        get { return personId; }
        set { personId = value; }
    }
    public int RankId
    {
        get { return rankId; }
        set { rankId = value; }
    }
    public DateTime HireDate
    {
        get { return hireDate; }
        set { hireDate = value; }
    }

    public Worker() { }
    public Worker(int id, int personId, int rankId, DateTime hireDate)
    {
        this.id = id;
        this.personId = personId;
        this.rankId = rankId;
        this.hireDate = hireDate;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Worker (PersonId, RankId, HireDate) VALUES (@PersonId, @RankId, @HireDate)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonId", PersonId);
                cmd.Parameters.AddWithValue("@RankId", RankId);
                cmd.Parameters.AddWithValue("@HireDate", HireDate);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Worker SET PersonId = @PersonId, RankId = @RankId, HireDate = @HireDate WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonId", PersonId);
                cmd.Parameters.AddWithValue("@RankId", RankId);
                cmd.Parameters.AddWithValue("@HireDate", HireDate);
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
            string query = "DELETE FROM Worker WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}