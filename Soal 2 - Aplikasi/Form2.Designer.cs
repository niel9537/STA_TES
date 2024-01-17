using FontAwesome.Sharp;

namespace STA_PROJECT
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            txtUsia = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnSave = new Button();
            txtTanggalMasukKerja = new TextBox();
            txtNama = new TextBox();
            label4 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtUsia);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtTanggalMasukKerja);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 580);
            panel1.TabIndex = 4;
            // 
            // txtUsia
            // 
            txtUsia.BorderStyle = BorderStyle.FixedSingle;
            txtUsia.Location = new Point(632, 104);
            txtUsia.Name = "txtUsia";
            txtUsia.Size = new Size(213, 33);
            txtUsia.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(437, 109);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 16;
            label7.Text = "Usia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(437, 68);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 15;
            label6.Text = "Tanggal Masuk Kerja";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Yellow;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(632, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(213, 33);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtTanggalMasukKerja
            // 
            txtTanggalMasukKerja.BorderStyle = BorderStyle.FixedSingle;
            txtTanggalMasukKerja.Location = new Point(632, 63);
            txtTanggalMasukKerja.Name = "txtTanggalMasukKerja";
            txtTanggalMasukKerja.Size = new Size(213, 33);
            txtTanggalMasukKerja.TabIndex = 9;
            // 
            // txtNama
            // 
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Location = new Point(183, 104);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(213, 33);
            txtNama.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 109);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 4;
            label4.Text = "Nama";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(183, 63);
            txtID.Name = "txtID";
            txtID.Size = new Size(213, 33);
            txtID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 68);
            label3.Name = "label3";
            label3.Size = new Size(25, 21);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 47);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "ENTRY DATA :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "FORM II";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1012, 580);
            Controls.Add(panel1);
            ForeColor = Color.Maroon;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STA PROJECT";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void BtnAutoUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button button6;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox textBox3;
        private TextBox txtNama;
        private Label label4;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Button button2;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox5;
        private TextBox txtTanggalMasukKerja;
        private Label label6;
        private Button btnSave;
        private TextBox txtUsia;
        private Label label7;
        private DataGridView dataGridView1;
    }
}