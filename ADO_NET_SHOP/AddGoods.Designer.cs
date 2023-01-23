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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.l_id = new System.Windows.Forms.Label();
            this.label2_name = new System.Windows.Forms.Label();
            this.label3_Cid = new System.Windows.Forms.Label();
            this.label4_price = new System.Windows.Forms.Label();
            this.label5_count = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_cat_id = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(146, 197);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(2, 197);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.button2_Click);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(12, 19);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(15, 13);
            this.l_id.TabIndex = 2;
            this.l_id.Text = "id";
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
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(121, 12);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 7;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(121, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 8;
            // 
            // tb_cat_id
            // 
            this.tb_cat_id.Location = new System.Drawing.Point(121, 86);
            this.tb_cat_id.Name = "tb_cat_id";
            this.tb_cat_id.Size = new System.Drawing.Size(100, 20);
            this.tb_cat_id.TabIndex = 9;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(121, 121);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 10;
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(121, 151);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(100, 20);
            this.tb_count.TabIndex = 11;
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 261);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_cat_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5_count);
            this.Controls.Add(this.label4_price);
            this.Controls.Add(this.label3_Cid);
            this.Controls.Add(this.label2_name);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "AddGoods";
            this.Text = "AddGoods";
            this.Load += new System.EventHandler(this.AddGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Button btn_OK;
        public System.Windows.Forms.Label l_id;
        public System.Windows.Forms.Label label2_name;
        public System.Windows.Forms.Label label3_Cid;
        public System.Windows.Forms.Label label4_price;
        public System.Windows.Forms.Label label5_count;
        public System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_cat_id;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_count;
    }
}