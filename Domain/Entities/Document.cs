namespace Domain.Entities;

using Npgsql;
using System;

public class Document
    {
        private int id;
        private int personId;
        private int documentTypeId;
        private int organizationId;
        private string number;
        private DateTime? issueDate;

        public int Id { get => id; set => id = value; }
        public int PersonId { get => personId; set => personId = value; }
        public int DocumentTypeId { get => documentTypeId; set => documentTypeId = value; }
        public int OrganizationId { get => organizationId; set => organizationId = value; }
        public string Number { get => number; set => number = value; }
        public DateTime? IssueDate { get => issueDate; set => issueDate = value; }

        public Document() { }
        public Document(int id, int personId, int documentTypeId, int organizationId, string number, DateTime? issueDate)
        {
            this.id = id;
            this.personId = personId;
            this.documentTypeId = documentTypeId;
            this.organizationId = organizationId;
            this.number = number;
            this.issueDate = issueDate;
        }

        public void Add()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Document (PersonId, DocumentTypeId, OrganizationId, Number, IssueDate) VALUES (@PersonId, @DocumentTypeId, @OrganizationId, @Number, @IssueDate)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonId", PersonId);
                    cmd.Parameters.AddWithValue("@DocumentTypeId", DocumentTypeId);
                    cmd.Parameters.AddWithValue("@OrganizationId", OrganizationId);
                    cmd.Parameters.AddWithValue("@Number", Number);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Document SET PersonId = @PersonId, DocumentTypeId = @DocumentTypeId, OrganizationId = @OrganizationId, Number = @Number, IssueDate = @IssueDate WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonId", PersonId);
                    cmd.Parameters.AddWithValue("@DocumentTypeId", DocumentTypeId);
                    cmd.Parameters.AddWithValue("@OrganizationId", OrganizationId);
                    cmd.Parameters.AddWithValue("@Number", Number);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate ?? (object)DBNull.Value);
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
                string query = "DELETE FROM Document WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }