using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    class SQLManager
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-NGV0MUQJ\SQLEXPRESS;Initial Catalog=GOALRATE;Integrated Security=True");

        public bool CheckAccount(string username, string password)
        {
            string query = "select * from ACCOUNT where username = '" + username + "' and password = '" + password + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            if (dt.Rows.Count == 1)
            {
                return true;
            }

            return false;
        }

        public bool CheckAccountRegister(string username, string password)
        {
            string query = "insert into ACCOUNT(username,password) values(@username ,@password)";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
                return false;
            }


            return true;
        }

        public void GetJson() // Get data as json then dump into database
        {
            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString(@"https://tygia.com/json.php?ran=0&rate=0&gold=1&bank=VIETCOM&date=now");

                Price listGolds = JsonConvert.DeserializeObject<Price>(rawJson);

                foreach (Gold gold in listGolds.golds[0].value)
                {
                    InsertGoldRate(gold.buy, gold.sell, gold.company, gold.brand, gold.updated, gold.brand, gold.day, gold.id, gold.type, gold.code);
                }
            }
        }

        private void InsertGoldRate(decimal buy, decimal sell, string company, string brand, DateTime updated, string brand1, string day, string id, string type, string code)
        {
            string query = "insert into GOLD(buy,sell,company,brand,updated,brand1,day,id,type,code) values(@buy,@sell,@company,@brand,@updated,@brand1,@day,@id,@type,@code)";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@buy", buy);
            command.Parameters.AddWithValue("@sell", sell);
            command.Parameters.AddWithValue("@company", company);
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@updated", updated);
            command.Parameters.AddWithValue("@brand1", brand1);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@code", code);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        public DataTable GetDataTable(string dateTime)
        {
            connection.Open();
            string query = "exec VIEWGOLD '" + dateTime + "'";

            SqlDataAdapter ada = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            connection.Close();

            return dt;
        }

        public DataTable GetDataTable1(string dateTime, string type)
        {
            connection.Open();
            string query = "exec VIEWGOLD1 '" + dateTime + "', N'" + type + "'";

            SqlDataAdapter ada = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            connection.Close();

            return dt;
        }

        public void UpdateGold(decimal buy, decimal sell, string company, string brand, DateTime updated, string brand1, string day, string id, string type, string code)
        {
            connection.Open();
            string query = "exec UPDATEGOLD @buy,@sell,@company,@brand,@updated,@brand1,@day,@id,@type,@code";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@buy", buy);
            command.Parameters.AddWithValue("@sell", sell);
            command.Parameters.AddWithValue("@company", company);
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@updated", updated);
            command.Parameters.AddWithValue("@brand1", brand1);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@code", code);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {

                connection.Close();
            }
        }

        public void UpdateJson(string now)
        {
            Delete(now);

            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString(@"https://tygia.com/json.php?ran=0&rate=0&gold=1&bank=VIETCOM&date=now");

                Price listGolds = JsonConvert.DeserializeObject<Price>(rawJson);

                foreach (Gold gold in listGolds.golds[0].value)
                {
                    UpdateGold(gold.buy, gold.sell, gold.company, gold.brand, gold.updated, gold.brand, gold.day, gold.id, gold.type, gold.code);
                }
            }
        }

        private void Delete(string now)
        {
            connection.Open();
            string query = "delete from GOLD where CONVERT(VARCHAR(10), updated, 103) =  @now";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@now", now);
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                connection.Close();
            }
            connection.Close();
        }
    }
}
