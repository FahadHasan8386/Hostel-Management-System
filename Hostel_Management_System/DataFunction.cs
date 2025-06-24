using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    internal class DataFunction
    {
        // It is declared as 'protected' meaning it can be accessed within this class and by derived classes.
        // Making it 'protected' promotes reusability while limiting direct external access if desired.
        protected SqlConnection getConnection()
        {
            // Initializes a new SqlConnection object.
            // This object represents a unique connection to a SQL Server database.
            SqlConnection con = new SqlConnection();

            // Sets the connection string for the SQL Server database.
            // This string contains all the necessary information to establish a connection.
            // "data source=DESKTOP-E4OT6REV\\SQLEXPRESS" specifies the server and SQL Server instance.
            // "database=hostel" specifies the name of the database to connect to.
            // "integrated security=True" indicates that Windows Authentication should be used,
            // meaning the user's current Windows login credentials will be used to authenticate with SQL Server.
            con.ConnectionString = "data source=WIN11\\SQLEXPRESS;database=HMS;Integrated Security=True";

            // Returns the configured SqlConnection object.
            // This object can then be used to open a connection, execute commands, and close the connection.
            return con;
        }

        // This method is designed to retrieve data from the database using a SQL SELECT query.
        // It takes a 'query' string as input, executes it, and returns the results in a DataSet.
        // 'public' means it can be accessed from any other class.
        // 'DataSet' is a disconnected cache of data retrieved from a data source.
        public DataSet getData(String query)
        {
            // 1. Get a database connection:
            // Calls the 'getConnection()' method to get a new, unopen SqlConnection object
            // configured with the database connection string.
            SqlConnection con = getConnection();

            // 2. Create a SQL Command object:
            // Initializes a new SqlCommand object. This object is used to send SQL statements or
            // stored procedures to a database.
            SqlCommand cmd = new SqlCommand();

            // 3. Associate command with connection:
            // Assigns the SqlConnection object 'con' to the 'Connection' property of the SqlCommand.
            // This tells the command which database connection to use for execution.
            cmd.Connection = con;

            // 4. Set the SQL query text:
            // Assigns the input 'query' string (e.g., "SELECT * FROM Students") to the 'CommandText'
            // property of the SqlCommand.
            cmd.CommandText = query;

            // 5. Create a DataAdapter:
            // Initializes a new SqlDataAdapter object, passing the SqlCommand as an argument.
            // A SqlDataAdapter is used to bridge between a DataSet and SQL Server,
            // enabling data to be retrieved into the DataSet and updates to be sent back to the database.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // 6. Create a DataSet to hold the results:
            // Initializes a new, empty DataSet object. This will store the data fetched from the database.
            DataSet ds = new DataSet();

            // 7. Fill the DataSet:
            // Calls the 'Fill' method of the SqlDataAdapter. This method executes the command
            // associated with the adapter (cmd) and populates the DataSet 'ds' with the results.
            // The connection 'con' is implicitly opened and closed by 'da.Fill()'.
            da.Fill(ds);

            // 8. Return the DataSet:
            // Returns the DataSet containing the retrieved data.
            return ds;
        }

        public void setData(String query, String msg)
        {
            // 1. Get a database connection:
            // Calls the 'getConnection()' method to get a new SqlConnection object.
            SqlConnection con = getConnection();

            // 2. Create a SQL Command object:
            // Initializes a new SqlCommand object to execute the non-query statement.
            SqlCommand cmd = new SqlCommand();

            // 3. Associate command with connection:
            // Assigns the SqlConnection object 'con' to the 'Connection' property of the SqlCommand.
            cmd.Connection = con;

            // 4. Open the database connection:
            // Explicitly opens the connection to the database. This is necessary before executing the command.
            con.Open();

            // 5. Set the SQL query text:
            // Assigns the input 'query' string (e.g., "INSERT INTO Students VALUES ('John Doe')")
            // to the 'CommandText' property of the SqlCommand.
            cmd.CommandText = query;

            // 6. Execute the non-query command:
            // Executes the SQL statement. 'ExecuteNonQuery()' is used for INSERT, UPDATE, DELETE,
            // and DDL (Data Definition Language) statements as they do not return a result set.
            // It returns the number of rows affected by the operation.
            cmd.ExecuteNonQuery();

            // 7. Close the database connection:
            // Closes the connection to the database. It's crucial to close connections to free up resources.
            con.Close();

            // 8. Display a message to the user:
            // Shows a message box with the provided 'msg' (e.g., "Data saved successfully!").
            // "Information" is the title of the message box.
            // "MessageBoxButtons.OK" adds an OK button to the message box.
            // "MessageBoxIcon.Information" displays an information icon in the message box.
            // NOTE: MessageBox.Show() is a UI component typically found in Windows Forms or WPF applications.
            // In a web-based or console application, you would use a different mechanism to display messages.
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
