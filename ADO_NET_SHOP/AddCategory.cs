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
    public partial class AddCategory : Form
    {
        int lastid;
        public AddCategory(int id)
        {
            lastid = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            tb_id.Text = lastid.ToString();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            /*if(tb_id.Text.Length >0)
            {
                if(Char.IsDigit(tb_id.Text.Last()))
                {
                    tb_id.Text = tb_id.Text.Remove(tb_id.Text.Length-1);
                }
            }*/
        }
    }
}
