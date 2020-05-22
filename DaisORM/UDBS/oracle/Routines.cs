using DaisORM.UDBS.Oracle;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDBS;
using UDBS.Oracle;
using UDBS.Proxy;

namespace DaisORM.UDBS.oracle
{
    public class Routines
    {
        public static string SQL_SELECT_CATEGORIES = "select c.name from game g join game_category gc on g.game_id = gc.game_game_id " +
            "join category c on gc.category_category_id = c.category_id where game_id=:game_id";

        public static string SQL_SELECT_COUNT = "select count(*) from reviewer_review where game_game_id=:game_id and order_of_review in" +
            "(select max(order_of_review) from reviewer_review group by reviewer_reviewer_id)";

        public int updateUserScore()
        {
            Database db = new Database();
            db.Connect();

            OracleCommand command = db.CreateCommand("updateUserScore");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public int updateReviewerScore()
        {
            Database db = new Database();
            db.Connect();

            OracleCommand command = db.CreateCommand("updateReviewerScore");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public int promoteUser(int id)
        {
            Database db = new Database();
            db.Connect();

            OracleCommand command = db.CreateCommand("promoteUser");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_user_id", OracleDbType.Int32).Value = id;
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public int promoteUserAndHisReviews(int id)
        {
            Database db = new Database();
            db.Connect();

            OracleCommand command = db.CreateCommand("promoteUserAndHisReviews");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_user_id", OracleDbType.Int32).Value = id;
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public Tuple<string, int> lastTenReviews(int id)
        {
            Database db;
            db = new Database();
            db.Connect();

            OracleCommand command = db.CreateCommand("lastTenReviews");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_game_id", OracleDbType.Int32).Value = id;
            command.Parameters.Add("v_title", OracleDbType.NVarchar2, System.Data.ParameterDirection.Output);
            command.Parameters.Add("v_score", OracleDbType.Int32, System.Data.ParameterDirection.Output);
            int ret = db.ExecuteNonQuery(command);

            string title = command.Parameters["v_title"].Value.ToString();
            bool hasEnoughReviews = int.TryParse(command.Parameters["v_score"].Value.ToString(), out int result);
            db.Close();

            if (!hasEnoughReviews)
            {
                Console.WriteLine("Game does not have enough reviews");
                result = 0;
            }

            return Tuple.Create(title, result);
        }

        public Tuple<int, int, double> countAndAvg()
        {
            Database db;
            db = new Database();
            db.Connect();

            OracleCommand command = db.CreateCommand("countAndAvg");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("p_user_id", OracleDbType.Int32, System.Data.ParameterDirection.Output);
            command.Parameters.Add("p_count", OracleDbType.Int32, System.Data.ParameterDirection.Output);
            command.Parameters.Add("p_avg", OracleDbType.Double, System.Data.ParameterDirection.Output);
            int ret = db.ExecuteNonQuery(command);

            int user_id = 0;
            int count = 0;
            double avg = 0.0;
            try { 
                user_id = Convert.ToInt32(command.Parameters["p_user_id"].Value.ToString());
                count = Convert.ToInt32(command.Parameters["p_count"].Value.ToString());
                avg = Convert.ToDouble(command.Parameters["p_avg"].Value.ToString());
            }
            catch(Exception e)
            {
                e.ToString();
            }

            db.Close();

            return Tuple.Create(user_id, count, avg);
        }
    }
}
