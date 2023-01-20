namespace ADO_NET_SHOP
{
    partial class EditCategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cencel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(74, 36);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(217, 20);
            this.tb_name.TabIndex = 10;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(74, 6);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(217, 20);
            this.tb_id.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // btn_cencel
            // 
            this.btn_cencel.Location = new System.Drawing.Point(182, 96);
            this.btn_cencel.Name = "btn_cencel";
            this.btn_cencel.Size = new System.Drawing.Size(109, 35);
            this.btn_cencel.TabIndex = 7;
            this.btn_cencel.Text = "Cencel";
            this.btn_cencel.UseVisualStyleBackColor = true;
            this.btn_cencel.Click += new System.EventHandler(this.btn_cencel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(15, 96);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(109, 35);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cencel);
            this.Controls.Add(this.btn_ok);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.Load += new System.EventHandler(this.EditCategory_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cencel;
        private System.Windows.Forms.Button btn_ok;
    }
}