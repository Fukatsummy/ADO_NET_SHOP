using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_SHOP
{
    public partial class AddGoods : Form
    {
        int _lastid;
        public AddGoods(int lastid)
        {
            InitializeComponent();
            _lastid = lastid;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddGoods_Load(object sender, EventArgs e)
        {
            tb_id.Text = _lastid.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
