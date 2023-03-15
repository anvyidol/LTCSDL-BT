
namespace ADO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDis = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pwInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlRd = new System.Windows.Forms.RadioButton();
            this.uNameInp = new System.Windows.Forms.TextBox();
            this.winRd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dbInp = new System.Windows.Forms.TextBox();
            this.lbInp = new System.Windows.Forms.Label();
            this.serverInp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDis);
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dbInp);
            this.groupBox1.Controls.Add(this.lbInp);
            this.groupBox1.Controls.Add(this.serverInp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết nối đến SERVER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(180, 275);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(119, 34);
            this.btnDis.TabIndex = 6;
            this.btnDis.Text = "Disconnect";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(52, 275);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(119, 34);
            this.btnConn.TabIndex = 5;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pwInp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sqlRd);
            this.groupBox2.Controls.Add(this.uNameInp);
            this.groupBox2.Controls.Add(this.winRd);
            this.groupBox2.Location = new System.Drawing.Point(9, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 168);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // pwInp
            // 
            this.pwInp.Location = new System.Drawing.Point(137, 128);
            this.pwInp.Name = "pwInp";
            this.pwInp.Size = new System.Drawing.Size(168, 23);
            this.pwInp.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // sqlRd
            // 
            this.sqlRd.AutoSize = true;
            this.sqlRd.Location = new System.Drawing.Point(23, 63);
            this.sqlRd.Name = "sqlRd";
            this.sqlRd.Size = new System.Drawing.Size(194, 21);
            this.sqlRd.TabIndex = 1;
            this.sqlRd.Text = "SQL Server Authentication";
            this.sqlRd.UseVisualStyleBackColor = true;
            // 
            // uNameInp
            // 
            this.uNameInp.Location = new System.Drawing.Point(137, 99);
            this.uNameInp.Name = "uNameInp";
            this.uNameInp.Size = new System.Drawing.Size(168, 23);
            this.uNameInp.TabIndex = 5;
            // 
            // winRd
            // 
            this.winRd.AutoSize = true;
            this.winRd.Checked = true;
            this.winRd.Location = new System.Drawing.Point(23, 36);
            this.winRd.Name = "winRd";
            this.winRd.Size = new System.Drawing.Size(176, 21);
            this.winRd.TabIndex = 0;
            this.winRd.TabStop = true;
            this.winRd.Text = "Windows Authentication";
            this.winRd.UseVisualStyleBackColor = true;
            this.winRd.CheckedChanged += new System.EventHandler(this.winRd_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database";
            // 
            // dbInp
            // 
            this.dbInp.Location = new System.Drawing.Point(125, 60);
            this.dbInp.Name = "dbInp";
            this.dbInp.Size = new System.Drawing.Size(223, 23);
            this.dbInp.TabIndex = 2;
            this.dbInp.Text = "AdventureWorks";
            // 
            // lbInp
            // 
            this.lbInp.AutoSize = true;
            this.lbInp.Location = new System.Drawing.Point(6, 34);
            this.lbInp.Name = "lbInp";
            this.lbInp.Size = new System.Drawing.Size(91, 17);
            this.lbInp.TabIndex = 1;
            this.lbInp.Text = "Server Name";
            // 
            // serverInp
            // 
            this.serverInp.Location = new System.Drawing.Point(125, 31);
            this.serverInp.Name = "serverInp";
            this.serverInp.Size = new System.Drawing.Size(223, 23);
            this.serverInp.TabIndex = 0;
            this.serverInp.Text = "A50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 364);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login nè";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sqlRd;
        private System.Windows.Forms.TextBox uNameInp;
        private System.Windows.Forms.RadioButton winRd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbInp;
        private System.Windows.Forms.Label lbInp;
        private System.Windows.Forms.TextBox serverInp;
    }
}

