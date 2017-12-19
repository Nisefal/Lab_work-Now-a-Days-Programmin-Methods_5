using System.Data;
using System.Data.SqlClient;

namespace Lab5
{
    class DatabaseAdapter
    {
        static string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Lab5;Integrated Security=True";
        public static DataSet GetClients()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT * FROM Clients", conn);
                DataSet dsCli = new DataSet();
                adapterClients.Fill(dsCli);
                return dsCli;
            }
        }

        public static DataSet GetTransactionsClient(int id)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT * FROM Transactions WHERE Id_client="+id.ToString(), conn);
                DataSet dsCli = new DataSet();
                adapterClients.Fill(dsCli);
                return dsCli;
            }
        }
        public static DataSet GetAllTransactions()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT * FROM Transactions", conn);
                DataSet dsCli = new DataSet();
                adapterClients.Fill(dsCli);
                return dsCli;
            }
        }

        public static DataSet GetQuality()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT * FROM Quality", conn);
                DataSet dsCli = new DataSet();
                adapterClients.Fill(dsCli);
                return dsCli;
            }
        }

        public static DataSet GetDisabledClients()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT * FROM Disabeled", conn);
                DataSet dsCli = new DataSet();
                adapterClients.Fill(dsCli);
                return dsCli;
            }
        }

        public static void AddClient(string name, int money, string email)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {

                SqlDataAdapter adapterClients = new SqlDataAdapter("SELECT * FROM Disabled", conn);
            }
        }
    }
}
