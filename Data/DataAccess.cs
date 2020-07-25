using Microsoft.Data.Sqlite;
using System.IO;
using System;
using Windows.Storage;

namespace Data
{
    public class DataAccess
    {
        public static void InitializeDatabase()
        {
            ApplicationData.Current.LocalFolder.CreateFileAsync("LibraryManager.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "LibraryManager.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                string tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Books (Id INTEGER PRIMARY KEY, " +
                    "Name NVARCHAR(50) NOT NULL)" +
                    "Author NVARCHAR(50) NULL)" +
                    "GivenTo NVARCHAR(50) NULL)" +
                    "Place NVARCHAR(50) NULL)" +
                    "Given BOOLEAN NOT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}
