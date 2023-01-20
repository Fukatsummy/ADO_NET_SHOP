namespace ADO_NET_SHOP
{
    partial class AddGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.Label();
            this.label2_name = new System.Windows.Forms.Label();
            this.label3_Cid = new System.Windows.Forms.Label();
            this.label4_price = new System.Windows.Forms.Label();
            this.label5_count = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_id
            // 
            this.tb_id.AutoSize = true;
            this.tb_id.Location = new System.Drawing.Point(12, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(15, 13);
            this.tb_id.TabIndex = 2;
            this.tb_id.Text = "id";
            // 
            // label2_name
            // 
            this.label2_name.AutoSize = true;
            this.label2_name.Location = new System.Drawing.Point(12, 55);
            this.label2_name.Name = "label2_name";
            this.label2_name.Size = new System.Drawing.Size(33, 13);
            this.label2_name.TabIndex = 3;
            this.label2_name.Text = "name";
            // 
            // label3_Cid
            // 
            this.label3_Cid.AutoSize = true;
            this.label3_Cid.Location = new System.Drawing.Point(12, 93);
            this.label3_Cid.Name = "label3_Cid";
            this.label3_Cid.Size = new System.Drawing.Size(60, 13);
            this.label3_Cid.TabIndex = 4;
            this.label3_Cid.Text = "Category id";
            // 
            // label4_price
            // 
            this.label4_price.AutoSize = true;
            this.label4_price.Location = new System.Drawing.Point(12, 128);
            this.label4_price.Name = "label4_price";
            this.label4_price.Size = new System.Drawing.Size(31, 13);
            this.label4_price.TabIndex = 5;
            this.label4_price.Text = "Price";
            // 
            // label5_count
            // 
            this.label5_count.AutoSize = true;
            this.label5_count.Location = new System.Drawing.Point(12, 158);
            this.label5_count.Name = "label5_count";
            this.label5_count.Size = new System.Drawing.Size(35, 13);
            this.label5_count.TabIndex = 6;
            this.label5_count.Text = "Count";
            this.label5_count.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 261);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5_count);
            this.Controls.Add(this.label4_price);
            this.Controls.Add(this.label3_Cid);
            this.Controls.Add(this.label2_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddGoods";
            this.Text = "AddGoods";
            this.Load += new System.EventHandler(this.AddGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label tb_id;
        public System.Windows.Forms.Label label2_name;
        public System.Windows.Forms.Label label3_Cid;
        public System.Windows.Forms.Label label4_price;
        public System.Windows.Forms.Label label5_count;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
    }
}