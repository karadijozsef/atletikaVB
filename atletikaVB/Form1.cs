using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atletikaVB
{
    public partial class atletika : Form
    {
        public atletika()
        {
            InitializeComponent();
        }

        private void atletika_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
