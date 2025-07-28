namespace AplikasiAbsensi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbnama = new ComboBox();
            dttanggal = new DateTimePicker();
            txtpin = new TextBox();
            btncekin = new Button();
            btncekot = new Button();
            dgvrekap = new DataGridView();
            lblstatus = new Label();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvrekap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 79);
            label1.Name = "label1";
            label1.Size = new Size(195, 51);
            label1.TabIndex = 0;
            label1.Text = "ABSENSI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(346, 280);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 2;
            label3.Text = "Tanggal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(348, 355);
            label4.Name = "label4";
            label4.Size = new Size(31, 18);
            label4.TabIndex = 3;
            label4.Text = "PIN";
            // 
            // cbnama
            // 
            cbnama.BackColor = Color.White;
            cbnama.ForeColor = SystemColors.ControlText;
            cbnama.FormattingEnabled = true;
            cbnama.Location = new Point(347, 222);
            cbnama.Name = "cbnama";
            cbnama.Size = new Size(221, 28);
            cbnama.TabIndex = 4;
            // 
            // dttanggal
            // 
            dttanggal.CalendarForeColor = Color.LightCyan;
            dttanggal.CalendarMonthBackground = Color.LightCyan;
            dttanggal.CalendarTitleBackColor = Color.LightCyan;
            dttanggal.CalendarTitleForeColor = Color.LightCyan;
            dttanggal.CalendarTrailingForeColor = Color.LightCyan;
            dttanggal.Location = new Point(347, 302);
            dttanggal.Name = "dttanggal";
            dttanggal.Size = new Size(221, 27);
            dttanggal.TabIndex = 5;
            // 
            // txtpin
            // 
            txtpin.ForeColor = SystemColors.Desktop;
            txtpin.Location = new Point(347, 376);
            txtpin.Name = "txtpin";
            txtpin.Size = new Size(221, 27);
            txtpin.TabIndex = 6;
            // 
            // btncekin
            // 
            btncekin.BackColor = Color.Transparent;
            btncekin.BackgroundImageLayout = ImageLayout.None;
            btncekin.FlatAppearance.BorderSize = 0;
            btncekin.FlatStyle = FlatStyle.Flat;
            btncekin.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncekin.ForeColor = Color.MidnightBlue;
            btncekin.Location = new Point(292, 425);
            btncekin.Name = "btncekin";
            btncekin.Size = new Size(127, 43);
            btncekin.TabIndex = 7;
            btncekin.Text = "CHECK IN";
            btncekin.UseVisualStyleBackColor = false;
            btncekin.Click += btncekin_Click;
            // 
            // btncekot
            // 
            btncekot.BackColor = Color.Transparent;
            btncekot.FlatAppearance.BorderSize = 0;
            btncekot.FlatStyle = FlatStyle.Flat;
            btncekot.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncekot.ForeColor = Color.Transparent;
            btncekot.Location = new Point(456, 425);
            btncekot.Name = "btncekot";
            btncekot.Size = new Size(114, 43);
            btncekot.TabIndex = 8;
            btncekot.Text = "CHECK OUT";
            btncekot.UseVisualStyleBackColor = false;
            btncekot.Click += btncekot_Click;
            // 
            // dgvrekap
            // 
            dgvrekap.BackgroundColor = SystemColors.ButtonFace;
            dgvrekap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrekap.Location = new Point(78, 531);
            dgvrekap.Name = "dgvrekap";
            dgvrekap.RowHeadersWidth = 51;
            dgvrekap.Size = new Size(693, 137);
            dgvrekap.TabIndex = 9;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.BackColor = Color.Transparent;
            lblstatus.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(264, 495);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(57, 18);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(346, 201);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 11;
            label2.Text = "Nama Pegawai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(387, 130);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 12;
            label5.Text = "Pegawai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(849, 710);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(lblstatus);
            Controls.Add(dgvrekap);
            Controls.Add(btncekot);
            Controls.Add(btncekin);
            Controls.Add(txtpin);
            Controls.Add(dttanggal);
            Controls.Add(cbnama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvrekap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox cbnama;
        private DateTimePicker dttanggal;
        private TextBox txtpin;
        private Button btncekin;
        private Button btncekot;
        private DataGridView dgvrekap;
        private Label lblstatus;
        private Label label2;
        private Label label5;
    }
}
