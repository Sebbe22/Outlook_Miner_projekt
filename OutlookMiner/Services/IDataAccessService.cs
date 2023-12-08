using Microsoft.Data.SqlClient;
using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IDataAccessService
    {
        public List<LabelModel> Pull(string querry);

        public void Push(string querry, LabelModel labelToAdd);
    }

    public class DataAccessService : IDataAccessService
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sebas" +
            "\\Downloads\\Ellab---OutlookMiner (2)\\Ellab---OutlookMiner\\Ellab---OutlookMiner\\" +
            "OutlookMiner\\OutlookMinerDB.mdf\";Integrated Security=True;Connect Timeout=30";

        public List<LabelModel> Pull(string querry)
        {
            List<LabelModel> labelList = new List<LabelModel>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(querry, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LabelModel label = ReadList(reader);
                    labelList.Add(label);
                }
            }

            return labelList;
        }

        private LabelModel ReadList(SqlDataReader reader)
        {
            LabelModel label = new LabelModel();

            label.Id = reader.GetInt32(0);
            label.Category = reader.GetString(1);
            label.LabelName = reader.GetString(2);

            return label;
        }

        public void Push(string querry, LabelModel labelToAdd)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(querry, connection);

                cmd.Parameters.AddWithValue("@Id", labelToAdd.Id);
                cmd.Parameters.AddWithValue("@Category", labelToAdd.Category);
                cmd.Parameters.AddWithValue("@LabelName", labelToAdd.LabelName);

                int row = cmd.ExecuteNonQuery();

                if(row < 1)
                {
                    throw new ArgumentException("Cant create label");
                }
            }
        }
    }
}
