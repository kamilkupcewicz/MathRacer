using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace MathGame.Classes
{
    class sqlConnection
    {
        private static SQLiteConnection dbConnection = new SQLiteConnection("Baza.db");

        public static void CreateTable()
        {
            string sqlCreate = @"CREATE TABLE IF NOT EXISTS Results
            (USERNAME TEXT NOT NULL,
            SCORE TEXT NOT NULL,
            DATE TEXT NOT NULL,
            MODE TEXT NOT NULL,
            TYPE TEXT NOT NULL);";
            ISQLiteStatement statement = dbConnection.Prepare(sqlCreate);
            statement.Step();
        }

        public static void InsertResult(string username, string score, DateTime date, string mode, string type)
        {
            string sqlInsert =
                $@"INSERT INTO [Results] ([USERNAME],[SCORE],[DATE],[MODE],[TYPE]) VALUES('{username}','{score}','{
                        date
                    }','{mode}','{type}')";
            dbConnection.Prepare(sqlInsert).Step();
        }

        public static List<PlayerResult> Select(string game, string mode)
        {
            PlayerResult result;
            List<PlayerResult> results = new List<PlayerResult>();
            string sqlSelect =
                $@"SELECT * FROM [Results] WHERE MODE='{game}' AND TYPE='{mode}' ORDER BY SCORE DESC LIMIT 25;";
            ISQLiteStatement statement = dbConnection.Prepare(sqlSelect);
            while (statement.Step() == SQLiteResult.ROW)
            {
                result = new PlayerResult();
                //result.choice_mode = statement["TYPE"] as string;
                //result.choice_game = statement["MODE"] as string;
                result.score = statement["SCORE"] as string;
                result.DateTime = statement["DATE"] as string;
                result.username = statement["USERNAME"] as string;
                results.Add(result);
            }
            return results;
        }

    }
}
