namespace Domain.Entities;

using Npgsql;
using System;

public class Education
    {
        private int id;
        private int workerId;
        private int eduLevelId;
        private int specialtyId;
        private int qualificationId;
        private int institutionId;
        private int? graduationYear;

        public int Id { get => id; set => id = value; }
        public int WorkerId { get => workerId; set => workerId = value; }
        public int EduLevelId { get => eduLevelId; set => eduLevelId = value; }
        public int SpecialtyId { get => specialtyId; set => specialtyId = value; }
        public int QualificationId { get => qualificationId; set => qualificationId = value; }
        public int InstitutionId { get => institutionId; set => institutionId = value; }
        public int? GraduationYear { get => graduationYear; set => graduationYear = value; }

        public Education() { }
        public Education(int id, int workerId, int eduLevelId, int specialtyId, int qualificationId, int institutionId, int? graduationYear)
        {
            this.id = id;
            this.workerId = workerId;
            this.eduLevelId = eduLevelId;
            this.specialtyId = specialtyId;
            this.qualificationId = qualificationId;
            this.institutionId = institutionId;
            this.graduationYear = graduationYear;
        }

        public void Add()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Education (WorkerId, EduLevelId, SpecialtyId, QualificationId, InstitutionId, GraduationYear) VALUES (@WorkerId, @EduLevelId, @SpecialtyId, @QualificationId, @InstitutionId, @GraduationYear)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerId", WorkerId);
                    cmd.Parameters.AddWithValue("@EduLevelId", EduLevelId);
                    cmd.Parameters.AddWithValue("@SpecialtyId", SpecialtyId);
                    cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
                    cmd.Parameters.AddWithValue("@InstitutionId", InstitutionId);
                    cmd.Parameters.AddWithValue("@GraduationYear", GraduationYear ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(modMain.ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Education SET WorkerId = @WorkerId, EduLevelId = @EduLevelId, SpecialtyId = @SpecialtyId, QualificationId = @QualificationId, InstitutionId = @InstitutionId, GraduationYear = @GraduationYear WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@WorkerId", WorkerId);
                    cmd.Parameters.AddWithValue("@EduLevelId", EduLevelId);
                    cmd.Parameters.AddWithValue("@SpecialtyId", SpecialtyId);
                    cmd.Parameters.AddWithValue("@QualificationId", QualificationId);
                    cmd.Parameters.AddWithValue("@InstitutionId", InstitutionId);
                    cmd.Parameters.AddWithValue("@GraduationYear", GraduationYear ?? (object)DBNull.Value);
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
                string query = "DELETE FROM Education WHERE Id = @Id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }