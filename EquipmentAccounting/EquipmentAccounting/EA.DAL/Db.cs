using EA.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Data.SqlClient;
using EA.DAL.Db;
using EA.DAL.Models;

namespace EA.DAL.Repo
{
    public class DeptRepo : IRepo<Dept>
    {
        private readonly Db.Db db = new Db.Db();

        public List<Dept> GetAll()
        {
            var list = new List<Dept>();

            using var conn = db.GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT Id, Name FROM Dept", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Dept
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            return list;
        }

        public void Add(Dept dept)
        {
            using var conn = db.GetConnection();
            conn.Open();

            var cmd = new SqlCommand(
                "INSERT INTO Dept(Name) VALUES(@name)", conn);
            cmd.Parameters.AddWithValue("@name", dept.Name);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = db.GetConnection();
            conn.Open();

            var cmd = new SqlCommand(
                "DELETE FROM Dept WHERE Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
