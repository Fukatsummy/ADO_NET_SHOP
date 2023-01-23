namespace ADO_NET_SHOP
{
    partial class EditGoods
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
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_cat_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label5_count = new System.Windows.Forms.Label();
            this.label4_price = new System.Windows.Forms.Label();
            this.label3_Cid = new System.Windows.Forms.Label();
            this.label2_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(133, 162);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(177, 20);
            this.tb_count.TabIndex = 23;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(133, 128);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(177, 20);
            this.tb_price.TabIndex = 22;
            // 
            // tb_cat_id
            // 
            this.tb_cat_id.Location = new System.Drawing.Point(133, 93);
            this.tb_cat_id.Name = "tb_cat_id";
            this.tb_cat_id.Size = new System.Drawing.Size(177, 20);
            this.tb_cat_id.TabIndex = 21;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(133, 55);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(177, 20);
            this.tb_name.TabIndex = 20;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(133, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(177, 20);
            this.tb_id.TabIndex = 19;
            // 
            // label5_count
            // 
            this.label5_count.AutoSize = true;
            this.label5_count.Location = new System.Drawing.Point(24, 165);
            this.label5_count.Name = "label5_count";
            this.label5_count.Size = new System.Drawing.Size(35, 13);
            this.label5_count.TabIndex = 18;
            this.label5_count.Text = "Count";
            // 
            // label4_price
            // 
            this.label4_price.AutoSize = true;
            this.label4_price.Location = new System.Drawing.Point(24, 135);
            this.label4_price.Name = "label4_price";
            this.label4_price.Size = new System.Drawing.Size(31, 13);
            this.label4_price.TabIndex = 17;
            this.label4_price.Text = "Price";
            // 
            // label3_Cid
            // 
            this.label3_Cid.AutoSize = true;
            this.label3_Cid.Location = new System.Drawing.Point(24, 100);
            this.label3_Cid.Name = "label3_Cid";
            this.label3_Cid.Size = new System.Drawing.Size(60, 13);
            this.label3_Cid.TabIndex = 16;
            this.label3_Cid.Text = "Category id";
            // 
            // label2_name
            // 
            this.label2_name.AutoSize = true;
            this.label2_name.Location = new System.Drawing.Point(24, 62);
            this.label2_name.Name = "label2_name";
            this.label2_name.Size = new System.Drawing.Size(33, 13);
            this.label2_name.TabIndex = 15;
            this.label2_name.Text = "name";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(24, 26);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(15, 13);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "id";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(14, 204);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(158, 204);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 265);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_cat_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5_count);
            this.Controls.Add(this.label4_price);
            this.Controls.Add(this.label3_Cid);
            this.Controls.Add(this.label2_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "EditGoods";
            this.Text = "EditGoods";
            this.Load += new System.EventHandler(this.EditGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5_count;
        private System.Windows.Forms.Label label4_price;
        private System.Windows.Forms.Label label3_Cid;
        private System.Windows.Forms.Label label2_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.TextBox tb_count;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_cat_id;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_id;
    }
}