using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

public class databaseHelper
{
	public static string connectionString = @"Data Source =..\..\CTRL2.db;Version=3;";
    //C:\Users\dylan\Desktop\HomepagePRJT\HomepagePRJT
    public static void InitialDatabase()
	{/*
        if(!File.Exists(@"..\..\CTRL2.db"))
        {
            SQLiteConnection.CreateFile(@"..\..\CTRL2.db");

            using (var connection = new SQLiteConnection(connectionString)) 
            {
				connection.Open();

				string createSeniorCitizenTableQuery = @"
					CREATE TABLE IF NOT EXISTS SeniorCitizen (
					sID INTEGER PRIMARY KEY AUTOINCREMENT,
					sFName TEXT NOT NULL,
					sLName TEXT NOT NULL,
					sProgress INTEGER NOT NULL,
					FOREIGN KEY(tID) references Teacher(tID),
					FOREIGN KEY(uID) references User(uID),
					FOREIGN KEY(qID) references Quiz(qID)
					);";

				using (SQLiteCommand command = new SQLiteCommand(createSeniorCitizenTableQuery, connection))
				{
					//command.CommandText = createSeniorCitizenTableQuery;
					connection.Open();
					command.ExecuteNonQuery();
				}

				string createTeacherTableQuery = @"
					CREATE TABLE IF NOT EXISTS Teacher (
					tID INTEGER PRIMARY KEY AUTOINCREMENT,
					tFName TEXT NOT NULL,
					tLName TEXT NOT NULL,
					tContact TEXT NOT NULL,
					FOREIGN KEY(uID) references User(uID)
					);";

				using (var command = new SQLiteCommand(connection))
				{
					command.CommandText = createTeacherTableQuery;
					command.ExecuteNonQuery();
				}

				string createQuizTableQuery = @"
					CREATE TABLE IF NOT EXISTS Quiz (
					qID INTEGER PRIMARY KEY AUTOINCREMENT,
					q1 INTEGER NOT NULL,
					q2 INTEGER NOT NULL,
					q3 INTEGER NOT NULL,
					q4 INTEGER NOT NULL,
					q5 INTEGER NOT NULL,
					FOREIGN KEY(tID) references Teacher(tID)
					);";

				using (var command = new SQLiteCommand(connection))
				{
					command.CommandText = createQuizTableQuery;
					command.ExecuteNonQuery();
				}

				string createUserTableQuery = @"
					CREATE TABLE IF NOT EXISTS User (
					uID INTEGER PRIMARY KEY AUTOINCREMENT,
					uUsername TEXT NOT NULL UNIQUE,
					uPosition TEXT NOT NULL,
					uPassword TEXT NOT NULL
					);";

				using (var command = new SQLiteCommand(connection))
				{
					command.CommandText = createUserTableQuery;
					command.ExecuteNonQuery();
				}
			}
		}*/

	}
	public static void AddSeniorCitizen(string sFName, string sLName, int sProgress)
	{
		
		int uID = 0; // Initialize userId

		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			string query = "SELECT uID FROM User ORDER BY rowId DESC";

			SQLiteCommand command = new SQLiteCommand(query, connection);
			connection.Open();

			object result = command.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

			if (result != null)
			{
				uID = Convert.ToInt32(result); // Convert the result to int
				uID += 1;
			}
			else
			{
				uID = 1;
				
			}

		}
		int qID = 0; // Initialize userId

		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			string query = "SELECT qID FROM Quiz ORDER BY rowId DESC";

			SQLiteCommand command = new SQLiteCommand(query, connection);
			connection.Open();

			object result = command.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

			if (result != null)
			{
				qID = Convert.ToInt32(result); // Convert the result to int
				qID += 1;
			}
			else
			{
				qID = 1;

			}
		}


		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			connection.Open();

			using (SQLiteCommand command = new SQLiteCommand(connection))
			{
				command.CommandText =
					@"INSERT INTO SeniorCitizen (sFName, sLName, sProgress, uID, qID)
                    VALUES (@sFName, @sLName, @sProgress, @uID, @qID);";
				command.Parameters.AddWithValue("@sFName", sFName);
				command.Parameters.AddWithValue("@sLName", sLName);
				command.Parameters.AddWithValue("@sProgress", sProgress);
				command.Parameters.AddWithValue("@uID", uID);
				command.Parameters.AddWithValue("@qID", qID);
				command.ExecuteNonQuery();
				command.Parameters.Clear();
			}
		}
	}
	public static void AddTeacher(string tFName, string tLName, string tContact)
	{
		int uID = 0; // Initialize userId

		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			string query = "SELECT uID FROM User ORDER BY rowId DESC";

			SQLiteCommand command = new SQLiteCommand(query, connection);
			connection.Open();

			object result = command.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

			if (result != null)
			{
				uID = Convert.ToInt32(result); // Convert the result to int
				uID += 1;
			}
			else
			{
				uID = 1;

			}
		}
		
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			connection.Open();

			using (SQLiteCommand command = new SQLiteCommand(connection))
			{
				command.CommandText =
					@"INSERT INTO Teacher (tFName, tLName, tContact, uID)
					VALUES (@tFName, @tLName, @tContact, @uID);";
				command.Parameters.AddWithValue("@tFName", tFName);
				command.Parameters.AddWithValue("@tLName", tLName);
				command.Parameters.AddWithValue("@tContact", tContact);
				command.Parameters.AddWithValue("@uID", uID);
				
				command.ExecuteNonQuery();
				command.Parameters.Clear();
			}
		}
	}
	public static void AddQuiz(int q1, int q2, int q3, int q4, int q5)
	{
		
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			connection.Open();

			using (SQLiteCommand command = new SQLiteCommand(connection))
			{
				command.CommandText =
					@"INSERT INTO Quiz (q1, q2, q3, q4, q5)
                    VALUES (@q1, @q2, @q3, @q4, @q5);";
				command.Parameters.AddWithValue("@q1", q1);
				command.Parameters.AddWithValue("@q2", q2);
				command.Parameters.AddWithValue("@q3", q3);
				command.Parameters.AddWithValue("@q4", q4);
				command.Parameters.AddWithValue("@q5", q5);
				command.ExecuteNonQuery();
				command.Parameters.Clear();
			}
		}
	}
	public static void AddUser(string uUsername, string uPosition, string uPassword)
	{	
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			connection.Open();

			using (SQLiteCommand command = new SQLiteCommand(connection))
			{
				command.CommandText =
				@"INSERT INTO User (uUsername, uPosition, uPassword)
                    VALUES (@uUsername, @uPosition, @uPassword);";
				command.Parameters.AddWithValue("@uUsername", uUsername);
				command.Parameters.AddWithValue("@uPosition", uPosition);
				command.Parameters.AddWithValue("@uPassword", uPassword);
				command.ExecuteNonQuery();
				command.Parameters.Clear();
			}
		}
	}
	
	public string Login(string username, string password)
	{
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			string query = "SELECT uUsername FROM User WHERE uUsername = '"+username+"'";
			string query1 = "SELECT uPassword FROM User WHERE uPassword = '" + password + "' AND uUsername = '"+username+"'";
			

			SQLiteCommand command = new SQLiteCommand(query, connection);
			SQLiteCommand command1 = new SQLiteCommand(query1, connection);
	
			connection.Open();

			object result = command.ExecuteScalar(); // username
			object result1 = command1.ExecuteScalar();// password
		
			if (result != null && result1 !=null)
			{
				return "true";
			}
			else
			{
				return "false";
			}

		}
		
	}
	public string getPosition(string username)
	{
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			string query2 = "SELECT uPosition FROM User WHERE uUsername = '" + username + "'";

			SQLiteCommand command2 = new SQLiteCommand(query2, connection);
			connection.Open();

			object result2 = command2.ExecuteScalar();
			return result2.ToString();
		}
	}
	public static void FillTable(DataGridView data)
	{
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM SeniorCitizen", connection))
			{
				using (SQLiteDataAdapter sda = new SQLiteDataAdapter(command))
				{
					using (DataTable dt = new DataTable())
					{
						sda.Fill(dt);
						data.DataSource = dt;
					}

				}
			}

		}
	}
	public static void updatePassword(string uUsername, string uPassword)
	{
		using (SQLiteConnection connection = new SQLiteConnection(connectionString))
		{
			string query = "UPDATE User SET uPassword = @uPassword WHERE uUsername = @uUsername";

			try
			{
				connection.Open();

				using (SQLiteCommand command = new SQLiteCommand(query, connection))
				{
					// Add parameters to prevent SQL injection
					command.Parameters.AddWithValue("@uUsername", uUsername);
					command.Parameters.AddWithValue("@uPassword", uPassword);

					// Execute the update query
					var rowsAffected = command.ExecuteNonQuery();
				}
			}
			catch (Exception ex) 
			{
                Console.WriteLine(ex.Message);
                throw;
            }
		}
	}
	public int getUid(string name)
	{
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT uID FROM User WHERE uUsername = '" + name + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
			
            return Convert.ToInt32(result2);
        }
    }
	public int getQuizID(int id)
	{
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT qID FROM SeniorCitizen WHERE uID = '" + id + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public static void updateQ1(int qID, int q1)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query = "UPDATE Quiz SET q1 = @q1 WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@q1", q1);
                   
                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public static void updateProgress(int qID, int sProgress)
    {	
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
			
            string query = "UPDATE SeniorCitizen SET sProgress = @sProgress WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@sProgress", sProgress);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
	public int getQ1(int qID)
	{
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT q1 FROM Quiz WHERE qID = '" + qID + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public static void updateQ2(int qID, int q2)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query = "UPDATE Quiz SET q2 = @q2 WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@q2", q2);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public int getQ2(int qID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT q2 FROM Quiz WHERE qID = '" + qID + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public static void updateQ3(int qID, int q3)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query = "UPDATE Quiz SET q3 = @q3 WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@q3", q3);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public int getQ3(int qID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT q3 FROM Quiz WHERE qID = '" + qID + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public static void updateQ4(int qID, int q4)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query = "UPDATE Quiz SET q4 = @q4 WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@q4", q4);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public int getQ4(int qID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT q4 FROM Quiz WHERE qID = '" + qID + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public static void updateQ5(int qID, int q5)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query = "UPDATE Quiz SET q5 = @q5 WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@q5", q5);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public int getQ5(int qID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT q5 FROM Quiz WHERE qID = '" + qID + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public int getProgress(int sID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT sProgress FROM SeniorCitizen WHERE sID = '" + sID + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();
            return Convert.ToInt32(result2);
        }
    }
    public int getSid(int uid)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT sID FROM SeniorCitizen WHERE uID = '" + uid + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();

            return Convert.ToInt32(result2);
        }
    }

    public int getTid(int uID2)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT tID FROM Teacher WHERE uID = '" + uID2 + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();

            return Convert.ToInt32(result2);
        }
    }

    public static void updateTid(int uID, int tID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {

            string query = "UPDATE SeniorCitizen SET tID = @tID WHERE uID = @uID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@uID", uID);
                    command.Parameters.AddWithValue("@tID", tID);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }

    public int getStudents(int tid)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query2 = "SELECT * FROM SeniorCitizen WHERE tID = '" + tid + "'";

            SQLiteCommand command2 = new SQLiteCommand(query2, connection);
            connection.Open();

            object result2 = command2.ExecuteScalar();

            return Convert.ToInt32(result2);
        }
    }
    //SELECT ... FROM table1 JOIN table2 USING ( column1 ,... )
    public static void FillTable2(DataGridView data, int tID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        { 
            using (SQLiteCommand command = new SQLiteCommand("SELECT sFName,sLName, sProgress, q1,q2,q3,q4,q5 FROM SeniorCitizen INNER JOIN Quiz ON SeniorCitizen.qID = Quiz.qID WHERE SeniorCitizen.tID='" + tID+"'", connection))
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(command))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        data.DataSource = dt;
                    }

                }
            }

        }
    }
    public static void FillTable3(DataGridView data, int sID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM SeniorCitizen WHERE sID='" + sID + "'", connection))
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(command))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        data.DataSource = dt;
                    }

                }
            }

        }
    }

    public static void FillTable4(DataGridView data, int qID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Quiz WHERE qID='" + qID + "'", connection))
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(command))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        data.DataSource = dt;
                    }

                }
            }

        }
    }

    public static void updateQuizTID(int qID, int tID)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            string query = "UPDATE Quiz SET tID = @tID WHERE qID = @qID";

            try
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@qID", qID);
                    command.Parameters.AddWithValue("@tID", tID);

                    // Execute the update query
                    var rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
