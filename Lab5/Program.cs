using System;
using System.Data;


namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tClients of internet provider");
            Output(DatabaseAdapter.GetClients());

            Console.WriteLine("\t\tClient's transactions");
            Output(DatabaseAdapter.GetTransactionsClient(1));

            Console.WriteLine("\t\tAll transactions");
            Output(DatabaseAdapter.GetAllTransactions());

            Console.WriteLine("\t\tClients marks for quality");
            Output(DatabaseAdapter.GetQuality());

            Console.WriteLine("\t\tTemporary disabled clients");
            Output(DatabaseAdapter.GetDisabledClients());

            Console.ReadLine();


        }

        public static void Output(DataSet ds)
        {
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item.ToString().Trim() + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
