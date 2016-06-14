using CenterFaculty.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterFaculty.Controller
{
    public class SqlServerDAO
    {
        private const string DatabaseConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=D:\TEST1\CenterFaculty\CenterFaculty\CFE.mdf;Integrated Security=True";

        public IEnumerable<SubCategory> GetSubCategoryRequestByCategory(string categoryName)
        {
            const string selectQueryStatement = @"SELECT * 
                                    FROM SubCategory 
                                    LEFT JOIN 
                                        Category 
                                        ON 
                                        SubCategory.CategoryId = Category.Id 
                                    WHERE Category.Name = @CATEGORY";
            using (SqlConnection defaultSqlConnection = new SqlConnection(DatabaseConnectionString))
            {
                defaultSqlConnection.Open();
                DataTable queryResult = new DataTable();

                using (SqlCommand queryCommand = new SqlCommand(selectQueryStatement, defaultSqlConnection))
                {
                    queryCommand.Parameters.AddWithValue("@CATEGORY", categoryName);
                    var sqlReader = queryCommand.ExecuteReader();
                    queryResult.Load(sqlReader);
                }

                var subcategoryByCategoryName = BuildSubCategory(queryResult);
                return subcategoryByCategoryName;
            }
        }

        private List<SubCategory> BuildSubCategory(DataTable dataTable)
        {
            var subcategories = new List<SubCategory>();

            foreach (DataRow currentRow in dataTable.Rows)
            {
                var subcategory = new SubCategory
                {
                    Description = currentRow["Description"].ToString(),
                    CategoryId = (int)currentRow["CategoryId"],
                    Id = (int)currentRow["Id"]
                };
                subcategories.Add(subcategory);
            }
            return subcategories;
        }

        public IEnumerable<CFEUser> GetUsersListToSend()
        {
            const string selectQueryStatement = @"SELECT * FROM CFEUser";
            using (SqlConnection defaultSqlConnection = new SqlConnection(DatabaseConnectionString))
            {
                defaultSqlConnection.Open();
                DataTable queryResult = new DataTable();

                using (SqlCommand queryCommand = new SqlCommand(selectQueryStatement, defaultSqlConnection))
                {
                    var sqlReader = queryCommand.ExecuteReader();
                    queryResult.Load(sqlReader);
                }

                var userToSend = BuildUsers(queryResult);
                return userToSend;
            }
        }

        private List<CFEUser> BuildUsers(DataTable dataTable)
        {
            var users = new List<CFEUser>();

            foreach (DataRow currentRow in dataTable.Rows)
            {
                var user = new CFEUser
                {
                    Fname = currentRow["Fname"].ToString(),
                    Lname = currentRow["Lname"].ToString(),
                    Email = currentRow["Email"].ToString()
                };
                users.Add(user);
            }
            return users;
        }

        public IEnumerable<Problem> GetProblemDetailBySubcategory(string subCategoryName)
        {
            const string selectQueryStatement = @"SELECT * 
                                    FROM Problem 
                                    LEFT JOIN 
                                         SubCategory
                                        ON 
                                        SubCategory.Id = Problem.SubCategoryId
                                    WHERE SubCategory.Description = @SUBCATEGORY";
            using (SqlConnection defaultSqlConnection = new SqlConnection(DatabaseConnectionString))
            {
                defaultSqlConnection.Open();
                DataTable queryResult = new DataTable();

                using (SqlCommand queryCommand = new SqlCommand(selectQueryStatement, defaultSqlConnection))
                {
                    queryCommand.Parameters.AddWithValue("@SUBCATEGORY", subCategoryName);
                    var sqlReader = queryCommand.ExecuteReader();
                    queryResult.Load(sqlReader);
                }

                var problemDetailBySub = BuildProblemDetail(queryResult);
                return problemDetailBySub;
            }
        }

        private List<Problem> BuildProblemDetail(DataTable dataTable)
        {
            var details = new List<Problem>();

            foreach (DataRow currentRow in dataTable.Rows)
            {
                var detail = new Problem
                {
                    Label = currentRow["Label"].ToString(),
                    
                    SubCategoryId = (int)currentRow["SubCategoryId"],
                    id = (int)currentRow["Id"]
                };
                details.Add(detail);
            }
            return details;
        }

        public bool StoreMessageInDatabase(MessageModel messageBox)
        {
            try
            {
                const string selectQueryStatement = @"INSERT INTO Message(Type, Category, Date, Suffix, Fname, Lname, Department, Phone, Email, Description, Detail, Message, StaffName, SendTo)
                                                    Values(@TYPE, @CATEGORY, @DATE, @SUFFIX, @FNAME, @LNAME, @DEPARTMENT, @PHONE, @EMAIL, @DESCRIPTION, @DETAIL, @MESSAGE, @STAFFNAME, @SENDTO)";
                using (SqlConnection defaultSqlConnection = new SqlConnection(DatabaseConnectionString))
                {
                    defaultSqlConnection.Open();
                    DataTable queryResult = new DataTable();

                    using (SqlCommand queryCommand = new SqlCommand(selectQueryStatement, defaultSqlConnection))
                    {
                        queryCommand.Parameters.AddWithValue("@TYPE", messageBox.Type);
                        queryCommand.Parameters.AddWithValue("@CATEGORY", messageBox.Category);
                        queryCommand.Parameters.AddWithValue("@DATE", messageBox.Date);
                        queryCommand.Parameters.AddWithValue("@SUFFIX", messageBox.Suffix);
                        queryCommand.Parameters.AddWithValue("@FNAME", messageBox.Fname);
                        queryCommand.Parameters.AddWithValue("@LNAME", messageBox.Lname);
                        queryCommand.Parameters.AddWithValue("@DEPARTMENT", messageBox.Department);
                        queryCommand.Parameters.AddWithValue("@PHONE", messageBox.Phone);
                        queryCommand.Parameters.AddWithValue("@EMAIL", messageBox.Email);
                        queryCommand.Parameters.AddWithValue("@DESCRIPTION", messageBox.Description);
                        queryCommand.Parameters.AddWithValue("@DETAIL", messageBox.Detail);
                        queryCommand.Parameters.AddWithValue("@MESSAGE", messageBox.MessageBox);
                        queryCommand.Parameters.AddWithValue("@STAFFNAME", "Brijesh"/*messageBox.StaffName*/);
                        queryCommand.Parameters.AddWithValue("@SENDTO", messageBox.Users);
                        queryCommand.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch(SqlException e)
            {
                return false;
            }
        }
    }
}
