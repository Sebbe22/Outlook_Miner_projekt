using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OutlookMiner.Services
{
    public interface ILabelService
    {
        bool DeleteLabel(LabelModel label);
        IEnumerable<LabelModel> GetLabels();
        bool InsertLabel(LabelModel label);
    }

    public class LabelService : ILabelService
    {
        IDataAccessService dataAccess = new DataAccessService();
        public IEnumerable<LabelModel> GetLabels()
        {
            try
            {
                string query = "SELECT " +
                "L.ID AS Id, " +
                "LC.CategoryName AS Category, " +
                "L.LabelName, " +
                "SW.SearchWord " +
                "FROM Labels L " +
                "INNER JOIN LabelCategories LC ON L.CategoryID = LC.ID " +
                "LEFT JOIN SearchWords SW ON L.ID = SW.LabelID;";
                return dataAccess.Get<LabelModel>(query);
            }
            catch
            {
                return Enumerable.Empty<LabelModel>();
            }


        }

        public bool InsertLabel(LabelModel label)
        {
            try
            {
                int categoryId;
                int labelId;

                
                    string getCategoryIDQuery = "SELECT ID FROM LabelCategories WHERE CategoryName = @Category";
                    categoryId = dataAccess.GetWithParameters<int>(getCategoryIDQuery, new { Category = label.Category }).FirstOrDefault();

                    if (categoryId == 0) 
                    {
                        string insertCategoryQuery = "INSERT INTO LabelCategories (CategoryName) VALUES (@Category); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                        categoryId = dataAccess.GetWithParameters<int>(insertCategoryQuery, new { Category = label.Category }).FirstOrDefault();
                    }

                    string insertLabelsQuery = "INSERT INTO Labels(CategoryID, LabelName) VALUES (@CategoryID, @LabelName); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                    labelId = dataAccess.GetWithParameters<int>(insertLabelsQuery, new { CategoryID = categoryId, LabelName = label.LabelName }).FirstOrDefault();

                    string insertSearchWordsQuery = "INSERT INTO SearchWords(LabelID, SearchWord) VALUES (@LabelID, @SearchWord)";
                    dataAccess.Insert(insertSearchWordsQuery, new { LabelID = labelId, SearchWord = label.SearchWord });
                

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteLabel(LabelModel label)
        {
            try
            {
                
                    string deleteSearchWordsQuery = "DELETE FROM SearchWords WHERE LabelID = @LabelID";
                    dataAccess.Delete(deleteSearchWordsQuery, new { LabelID = label.Id });

                    string deleteLabelsQuery = "DELETE FROM Labels WHERE ID = @LabelID";
                    dataAccess.Delete(deleteLabelsQuery, new { LabelID = label.Id });


                    return true;
            }
            catch
            {
                return false;
            }

        }
    }

}
