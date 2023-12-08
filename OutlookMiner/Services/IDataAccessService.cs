using Dapper;
using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IDataAccessService
    {
        public IEnumerable<T> Get<T>(string querry);

        public void Insert<T>(string querry, T labelToAdd);

        public void Delete(string querry, LabelModel labelToDelete);
    }

    public class DataAccessService : IDataAccessService
    {
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sebas" +
            "\\Downloads\\Ellab---OutlookMiner (2)\\Ellab---OutlookMiner\\Ellab---OutlookMiner\\" +
            "OutlookMiner\\OutlookMinerDB.mdf\";Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// pulls data from the OutlookMinerDB database
        /// </summary>
        /// <param name="querry"> the sql querry to specify what you want to pull </param>
        /// <returns> returns whatever you querried as a list of LabelModels </returns>
        public IEnumerable<T> Get<T>(string querry)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                return connection.Query<T>(querry);
            }
        }

        public void Insert<T>(string querry, T itemToAdd)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                connection.Execute(querry, itemToAdd);
            }
        }

        public void Delete(string querry, LabelModel labelToDelete)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(querry, connection);

                cmd.Parameters.AddWithValue("@Id", labelToDelete.Id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
