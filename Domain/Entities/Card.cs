namespace Domain.Entities;

using Npgsql;
using System;

public class Card
{
    private int id;
    private int workerId;
    private int bankId;
    private string cardNumber;
    private DateTime issueDate;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public int WorkerId
    {
        get { return workerId; }
        set { workerId = value; }
    }
    public int BankId
    {
        get { return bankId; }
        set { bankId = value; }
    }
    public string CardNumber
    {
        get { return cardNumber; }
        set { cardNumber = value; }
    }
    public DateTime IssueDate
    {
        get { return issueDate; }
        set { issueDate = value; }
    }

    public Card() { }
    public Card(int id, int workerId, int bankId, string cardNumber, DateTime issueDate)
    {
        this.id = id;
        this.workerId = workerId;
        this.bankId = bankId;
        this.cardNumber = cardNumber;
        this.issueDate = issueDate;
    }

    public void Add()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "INSERT INTO Card (WorkerId, BankId, CardNumber, IssueDate) VALUES (@WorkerId, @BankId, @CardNumber, @IssueDate)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@WorkerId", WorkerId);
                cmd.Parameters.AddWithValue("@BankId", BankId);
                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Update()
    {
        using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
        {
            conn.Open();
            string query = "UPDATE Card SET WorkerId = @WorkerId, BankId = @BankId, CardNumber = @CardNumber, IssueDate = @IssueDate WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@WorkerId", WorkerId);
                cmd.Parameters.AddWithValue("@BankId", BankId);
                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
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
            string query = "DELETE FROM Card WHERE Id = @Id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}