using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_NET_SHOP
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;
        
        public Form1()
        {
            InitializeComponent();
            ConfigurationSettings.GetConfig
        }

    }
}
