using Dapper;
using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    /// <summary>
    /// Interface for performing data access operations.
    /// </summary>
    public interface IDataAccessService
    {
        /// <summary>
        /// Retrieves data based on the provided query.
        /// </summary>
        /// <typeparam name="T">Type of data to retrieve.</typeparam>
        /// <param name="query">Query string for data retrieval.</param>
        /// <returns>An IEnumerable collection of retrieved data.</returns>
        IEnumerable<T> Get<T>(string query);

        /// <summary>
        /// Inserts data based on the provided query and label.
        /// </summary>
        /// <typeparam name="T">Type of data to insert.</typeparam>
        /// <param name="query">Query string for data insertion.</param>
        /// <param name="labelToAdd">Data to be inserted.</param>
        void Insert<T>(string query, T labelToAdd);

        /// <summary>
        /// Deletes data based on the provided query and label.
        /// </summary>
        /// <typeparam name="T">Type of data to delete.</typeparam>
        /// <param name="query">Query string for data deletion.</param>
        /// <param name="labelToDelete">Data to be deleted.</param>
        void Delete<T>(string query, T labelToDelete);

        /// <summary>
        /// Retrieves data with optional parameters based on the provided query.
        /// </summary>
        /// <typeparam name="T">Type of data to retrieve.</typeparam>
        /// <param name="query">Query string for data retrieval.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>An IEnumerable collection of retrieved data.</returns>
        IEnumerable<T> GetWithParameters<T>(string query, object parameters = null);
    }

    public class DataAccessService : IDataAccessService
    {
        

        private static string GetConnectionstring()
        {
            string connString;

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string databaseFile = "OutlookMinerDB.mdf"; 
            int levelsToGoUp = 4; 

            string projectDirectory = currentDirectory;

            for (int i = 0; i < levelsToGoUp; i++)
            {
                projectDirectory = Directory.GetParent(projectDirectory).FullName;
            }

            string fullPathToDatabase = Path.Combine(projectDirectory, databaseFile);

            connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+fullPathToDatabase + ";Integrated Security=True;";
            return connString;
        }
        private string connString = GetConnectionstring();

      

        /// <summary>
        /// pulls data from the OutlookMinerDB database
        /// </summary>
        /// <param name="querry"> the sql querry to specify what you want to pull </param>
        /// <returns> returns whatever you querried as a list of LabelModels </returns>
        public IEnumerable<T> Get<T>(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    return connection.Query<T>(query);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("An exception occurred: " + ex.Message);
                return null;
            }

        }
        public IEnumerable<T> GetWithParameters<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    return connection.Query<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An exception occurred: " + ex.Message);
                return null;
            }

        }

        public void Insert<T>(string querry, T itemToAdd)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    connection.Execute(querry, itemToAdd);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("An exception occurred: " + ex.Message);

            }

        }

        public void Delete<T>(string query, T parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    connection.Execute(query, parameters);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An exception occurred: " + ex.Message);

            }

        }
    }
}
