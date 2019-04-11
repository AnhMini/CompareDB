using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CompareDB
{
    class KetNoi
    {
        public bool KiemTraKetNoi(string connectString)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connectString);
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
