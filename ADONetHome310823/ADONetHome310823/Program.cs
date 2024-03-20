using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace ADONetHome310823
{
    internal class Program
    {
        private static string conectionString = "Data Source=DESKTOP-2SM04KA;Initial Catalog=VegetablesAndFruits;UID=Mark;PWD=123;";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                Console.WriteLine(Hello world!);
                connection.Close();
            }

        }
    }
}
