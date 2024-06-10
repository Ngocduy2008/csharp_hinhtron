namespace csharp_hinhtron
{
    partial class Form1
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
            this.btntl1 = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.Label();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkdientich = new System.Windows.Forms.CheckBox();
            this.chkchuvi = new System.Windows.Forms.CheckBox();
            this.btntl2 = new System.Windows.Forms.Button();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btndientich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntl1
            // 
            this.btntl1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntl1.Location = new System.Drawing.Point(616, 221);
            this.btntl1.Name = "btntl1";
            this.btntl1.Size = new System.Drawing.Size(85, 34);
            this.btntl1.TabIndex = 0;
            this.btntl1.Text = "tính ";
            this.btntl1.UseVisualStyleBackColor = true;
            this.btntl1.Click += new System.EventHandler(this.btntl1_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.AutoSize = true;
            this.txtKQ.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(26, 221);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(89, 25);
            this.txtKQ.TabIndex = 1;
            this.txtKQ.Text = "kết quả ";
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdientich.Location = new System.Drawing.Point(18, 79);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(111, 29);
            this.rdbdientich.TabIndex = 2;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // txtbankinh
            // 
            this.txtbankinh.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankinh.Location = new System.Drawing.Point(122, 39);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(130, 33);
            this.txtbankinh.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(501, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbchuvi.Location = new System.Drawing.Point(18, 45);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(86, 29);
            this.rdbchuvi.TabIndex = 2;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(964, 447);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 37);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "bán kính ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkdientich);
            this.groupBox2.Controls.Add(this.chkchuvi);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(806, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // chkdientich
            // 
            this.chkdientich.AutoSize = true;
            this.chkdientich.Location = new System.Drawing.Point(24, 68);
            this.chkdientich.Name = "chkdientich";
            this.chkdientich.Size = new System.Drawing.Size(119, 29);
            this.chkdientich.TabIndex = 0;
            this.chkdientich.Text = "diện tích ";
            this.chkdientich.UseVisualStyleBackColor = true;
            // 
            // chkchuvi
            // 
            this.chkchuvi.AutoSize = true;
            this.chkchuvi.Location = new System.Drawing.Point(24, 33);
            this.chkchuvi.Name = "chkchuvi";
            this.chkchuvi.Size = new System.Drawing.Size(87, 29);
            this.chkchuvi.TabIndex = 0;
            this.chkchuvi.Text = "chu vi";
            this.chkchuvi.UseVisualStyleBackColor = true;
            // 
            // btntl2
            // 
            this.btntl2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntl2.Location = new System.Drawing.Point(921, 221);
            this.btntl2.Name = "btntl2";
            this.btntl2.Size = new System.Drawing.Size(85, 34);
            this.btntl2.TabIndex = 0;
            this.btntl2.Text = "tính";
            this.btntl2.UseVisualStyleBackColor = true;
            this.btntl2.Click += new System.EventHandler(this.btntl2_Click);
            // 
            // btnchuvi
            // 
            this.btnchuvi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuvi.Location = new System.Drawing.Point(30, 125);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(85, 37);
            this.btnchuvi.TabIndex = 0;
            this.btnchuvi.Text = "chu vi ";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btndientich
            // 
            this.btndientich.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndientich.Location = new System.Drawing.Point(167, 129);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(108, 37);
            this.btndientich.TabIndex = 0;
            this.btndientich.Text = "diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntl2);
            this.Controls.Add(this.btntl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntl1;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntl2;
        private System.Windows.Forms.CheckBox chkdientich;
        private System.Windows.Forms.CheckBox chkchuvi;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Label txtKQ;
    }
}

