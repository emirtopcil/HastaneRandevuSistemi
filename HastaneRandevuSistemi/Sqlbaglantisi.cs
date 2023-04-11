using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneRandevuSistemi
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M0TUUL9\\SQLEXPRESS;Initial Catalog=HastaneVeriTabani;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
