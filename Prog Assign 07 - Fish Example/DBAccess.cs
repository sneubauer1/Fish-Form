using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prog_Assign_07_Fish_Example
{
    class DBAccess
    {
        private const string CONNECT_INFO = "Data Source=.\\SQLExpress; Initial Catalog=CSC470Fish;" +
                                            "Integrated Security=True; MultipleActiveResultSets=True";

        // SQL Server Error Numbers
        private const int DUPLICATE_KEY = 2627;
        private const int FOREIGN_KEY_VIOLATION = 547;

        private SqlConnection conn;

        public DBAccess()
        {
            try
            {
                conn = new SqlConnection(CONNECT_INFO);
                conn.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public List<Fish> GetAllFish()
        {

            List<Fish> fishList = new List<Fish>();
            try
            {
                // Create a sql command for dbo.GetAllStates using the conn
                SqlCommand cmdGetAllStates = new SqlCommand("dbo.GetAllFish", conn);
                // Set the CommandType property of the command to stored procedure
                cmdGetAllStates.CommandType = CommandType.StoredProcedure;
                // Execute a sql reader
                SqlDataReader reader = cmdGetAllStates.ExecuteReader();

                // Loop through all rows from the reader
                while (reader.Read())
                {
                    // create and add each state to the states list
                    fishList.Add(new Fish(Int32.Parse(reader["Id"].ToString()), 
                                          reader["Name"].ToString(),
                                          reader["WaterType"].ToString()));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return fishList;
        }

        public string FishAdd(string name, string waterType)
        {
            try
            {
                // Specify the stored procedure and connection as a new command
                SqlCommand cmdAddFish = new SqlCommand("dbo.FishAdd", conn);

                // Specify a stored procedure type of command
                cmdAddFish.CommandType = CommandType.StoredProcedure;

                // Add a parameter for the stored procedure and its value
                cmdAddFish.Parameters.AddWithValue("@Name", name);
                // Add another parameter and its value
                cmdAddFish.Parameters.AddWithValue("@WaterType", waterType);

                // Prepare to receive a return value from the stored proc
                SqlParameter returnVal = new SqlParameter();
                returnVal.SqlDbType = SqlDbType.Int;
                returnVal.Direction = ParameterDirection.ReturnValue;
                returnVal.ParameterName = "@returnVal";
                cmdAddFish.Parameters.Add(returnVal);

                // Execute the command
                cmdAddFish.ExecuteNonQuery();

                // Handle the return results
                // First get the result from the command parameters
                int result = Int32.Parse(cmdAddFish.Parameters["@returnVal"].Value.ToString());
                // Now check for a duplicate key (use the predefined constant)
                if (result == DUPLICATE_KEY)
                    /* return the error message "The fish named nnn already exits."
                       where nnn is the attempted name */
                    return "The fish named " + name + " already exists.";
                // Check for errors other than duplicate keys
                else if (result < 0)
                    /* return the error message "Error number: nnn"
                       where nnn is the returned error number */
                    return "Error number: " + result.ToString();
                else
                    // No errors, so return the empty string
                    return "";
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }
        public string FishModify(int id, string name, string waterType)
        {
            try
            {
                // Specify the stored procedure and connection as a new command
                SqlCommand cmdModifyFish = new SqlCommand("dbo.FishModify", conn);

                // Specify a stored procedure type of command
                cmdModifyFish.CommandType = CommandType.StoredProcedure;

                // Add a parameter for the stored procedure and its value
                cmdModifyFish.Parameters.AddWithValue("@Id", id);
                // Add another parameter and its value
                cmdModifyFish.Parameters.AddWithValue("@Name", name);
                // Add another parameter and its value
                cmdModifyFish.Parameters.AddWithValue("@WaterType", waterType);

                // Prepare to receive a return value from the stored proc
                SqlParameter returnVal = new SqlParameter();
                returnVal.SqlDbType = SqlDbType.Int;
                returnVal.Direction = ParameterDirection.ReturnValue;
                returnVal.ParameterName = "@returnVal";
                cmdModifyFish.Parameters.Add(returnVal);

                // Execute the command
                cmdModifyFish.ExecuteNonQuery();

                // Handle the return results
                // First get the result from the command parameters
                int result = Int32.Parse(cmdModifyFish.Parameters["@returnVal"].Value.ToString());
                // Now check for a duplicate key (use the predefined constant)
                if (result == DUPLICATE_KEY)
                    /* return the error message "The fish named nnn already exits."
                       where nnn is the attempted name */
                    return "The fish named " + name + " already exists.";
                // Check for errors other than duplicate keys
                else if (result < 0)
                    /* return the error message "Error number: nnn"
                       where nnn is the returned error number */
                    return "Error number: " + result.ToString();
                else
                    // No errors, so return the empty string
                    return "";
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }
    }
}