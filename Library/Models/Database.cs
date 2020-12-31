using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connetionString = @"Server=RABBY-PC\SQLEXPRESS;Database=Library;User Id=sa;Password=1234;";
            SqlConnection conn = new SqlConnection(connetionString);
            Books = new Books(conn);
        }
    }
}
