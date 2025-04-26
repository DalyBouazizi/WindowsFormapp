namespace View
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nom1 = new System.Windows.Forms.TextBox();
            this.tb_tel1 = new System.Windows.Forms.TextBox();
            this.tb_prenom1 = new System.Windows.Forms.TextBox();
            this.tb_adr1 = new System.Windows.Forms.TextBox();
            this.tb_email1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_idcl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // tb_nom1
            // 
            this.tb_nom1.Location = new System.Drawing.Point(128, 37);
            this.tb_nom1.Name = "tb_nom1";
            this.tb_nom1.Size = new System.Drawing.Size(173, 22);
            this.tb_nom1.TabIndex = 1;
            // 
            // tb_tel1
            // 
            this.tb_tel1.Location = new System.Drawing.Point(128, 126);
            this.tb_tel1.Name = "tb_tel1";
            this.tb_tel1.Size = new System.Drawing.Size(173, 22);
            this.tb_tel1.TabIndex = 2;
            // 
            // tb_prenom1
            // 
            this.tb_prenom1.Location = new System.Drawing.Point(128, 76);
            this.tb_prenom1.Name = "tb_prenom1";
            this.tb_prenom1.Size = new System.Drawing.Size(173, 22);
            this.tb_prenom1.TabIndex = 3;
            // 
            // tb_adr1
            // 
            this.tb_adr1.Location = new System.Drawing.Point(128, 175);
            this.tb_adr1.Name = "tb_adr1";
            this.tb_adr1.Size = new System.Drawing.Size(173, 22);
            this.tb_adr1.TabIndex = 4;
            // 
            // tb_email1
            // 
            this.tb_email1.Location = new System.Drawing.Point(128, 230);
            this.tb_email1.Name = "tb_email1";
            this.tb_email1.Size = new System.Drawing.Size(173, 22);
            this.tb_email1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "N°Tel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Email";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(52, 311);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(133, 35);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Create";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(191, 311);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 35);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(508, 150);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 35);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_idcl
            // 
            this.tb_idcl.Location = new System.Drawing.Point(532, 106);
            this.tb_idcl.Name = "tb_idcl";
            this.tb_idcl.Size = new System.Drawing.Size(100, 22);
            this.tb_idcl.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Id Client";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(508, 191);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(133, 35);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 466);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 466);
            this.splitter2.TabIndex = 17;
            this.splitter2.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_idcl);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_email1);
            this.Controls.Add(this.tb_adr1);
            this.Controls.Add(this.tb_prenom1);
            this.Controls.Add(this.tb_tel1);
            this.Controls.Add(this.tb_nom1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_adr;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom1;
        private System.Windows.Forms.TextBox tb_tel1;
        private System.Windows.Forms.TextBox tb_prenom1;
        private System.Windows.Forms.TextBox tb_adr1;
        private System.Windows.Forms.TextBox tb_email1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_idcl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}

