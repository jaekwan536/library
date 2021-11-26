using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library
{
    class BookManager
    {
        public List<String> bookInfoList()
        {
            List<String> books = new List<string>();

            // 각자 수정 (포트, 디비이름, 아이디, 패스워드)
            string connstr = "Server=127.0.0.1;Port=3306;Database=library;Uid=jaekwan;Pwd=aries";
            MySqlConnection conn = new MySqlConnection(connstr);
            MySqlCommand cmd = conn.CreateCommand();
            string sql = "Select * from member";
            cmd.CommandText = sql;
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add(reader["id"].ToString());
                books.Add(reader["mName"].ToString());
            }
            return books;
        }
    }
}
