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
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.btntn1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.lblketqua = new System.Windows.Forms.Label();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btndientich = new System.Windows.Forms.Button();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkchuvi = new System.Windows.Forms.CheckBox();
            this.chkdientinh = new System.Windows.Forms.CheckBox();
            this.btntn2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbankinh
            // 
            this.txtbankinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankinh.Location = new System.Drawing.Point(155, 55);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(151, 30);
            this.txtbankinh.TabIndex = 0;
            // 
            // btntn1
            // 
            this.btntn1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntn1.Location = new System.Drawing.Point(561, 264);
            this.btntn1.Name = "btntn1";
            this.btntn1.Size = new System.Drawing.Size(75, 38);
            this.btntn1.TabIndex = 1;
            this.btntn1.Text = "tính";
            this.btntn1.UseVisualStyleBackColor = true;
            this.btntn1.Click += new System.EventHandler(this.btntn1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(436, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tính năng 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbchuvi.Location = new System.Drawing.Point(62, 48);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(116, 27);
            this.rdbchuvi.TabIndex = 1;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "tính chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            this.rdbchuvi.CheckedChanged += new System.EventHandler(this.rdbchuvi_CheckedChanged);
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdientich.Location = new System.Drawing.Point(62, 109);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(138, 27);
            this.rdbdientich.TabIndex = 1;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "tính diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            this.rdbdientich.CheckedChanged += new System.EventHandler(this.rdbdientich_CheckedChanged);
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(47, 234);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(79, 23);
            this.lblketqua.TabIndex = 2;
            this.lblketqua.Text = "kết quả ";
            this.lblketqua.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnchuvi
            // 
            this.btnchuvi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuvi.Location = new System.Drawing.Point(51, 124);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 38);
            this.btnchuvi.TabIndex = 1;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btndientich
            // 
            this.btndientich.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndientich.Location = new System.Drawing.Point(180, 124);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(96, 38);
            this.btndientich.TabIndex = 1;
            this.btndientich.Text = "diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbankinh.Location = new System.Drawing.Point(47, 62);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(95, 23);
            this.lblbankinh.TabIndex = 2;
            this.lblbankinh.Text = "BÁN KÍNH";
            this.lblbankinh.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkdientinh);
            this.groupBox2.Controls.Add(this.chkchuvi);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(816, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tính năng 2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkchuvi
            // 
            this.chkchuvi.AutoSize = true;
            this.chkchuvi.Location = new System.Drawing.Point(43, 42);
            this.chkchuvi.Name = "chkchuvi";
            this.chkchuvi.Size = new System.Drawing.Size(117, 27);
            this.chkchuvi.TabIndex = 0;
            this.chkchuvi.Text = "tính chu vi";
            this.chkchuvi.UseVisualStyleBackColor = true;
            this.chkchuvi.CheckedChanged += new System.EventHandler(this.chkchuvi_CheckedChanged);
            // 
            // chkdientinh
            // 
            this.chkdientinh.AutoSize = true;
            this.chkdientinh.Location = new System.Drawing.Point(43, 102);
            this.chkdientinh.Name = "chkdientinh";
            this.chkdientinh.Size = new System.Drawing.Size(145, 27);
            this.chkdientinh.TabIndex = 0;
            this.chkdientinh.Text = "tính diện tích ";
            this.chkdientinh.UseVisualStyleBackColor = true;
            // 
            // btntn2
            // 
            this.btntn2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntn2.Location = new System.Drawing.Point(944, 264);
            this.btntn2.Name = "btntn2";
            this.btntn2.Size = new System.Drawing.Size(75, 38);
            this.btntn2.TabIndex = 3;
            this.btntn2.Text = "tính ";
            this.btntn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 705);
            this.Controls.Add(this.btntn2);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.btntn1);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.txtbankinh);
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

        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Button btntn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkdientinh;
        private System.Windows.Forms.CheckBox chkchuvi;
        private System.Windows.Forms.Button btntn2;
    }
}

