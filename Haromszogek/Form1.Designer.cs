namespace Haromszogek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Adatbetoltes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox_Hibak = new System.Windows.Forms.ListBox();
            this.listBox_Derekszogek = new System.Windows.Forms.ListBox();
            this.label_Kerulet = new System.Windows.Forms.Label();
            this.label_Terulet = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Adatbetoltes
            // 
            this.button_Adatbetoltes.Location = new System.Drawing.Point(13, 13);
            this.button_Adatbetoltes.Name = "button_Adatbetoltes";
            this.button_Adatbetoltes.Size = new System.Drawing.Size(153, 43);
            this.button_Adatbetoltes.TabIndex = 0;
            this.button_Adatbetoltes.Text = "Adatok betöltése";
            this.button_Adatbetoltes.UseVisualStyleBackColor = true;
            this.button_Adatbetoltes.Click += new System.EventHandler(this.button_Adatbetoltes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Hibak);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hibák a kiválasztott állományban";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Derekszogek);
            this.groupBox2.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 224);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Derékszögű háromszögek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Terulet);
            this.groupBox3.Controls.Add(this.label_Kerulet);
            this.groupBox3.Location = new System.Drawing.Point(463, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiválasztott derékszögű háromszög adatai";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox_Hibak
            // 
            this.listBox_Hibak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Hibak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Hibak.ForeColor = System.Drawing.Color.Red;
            this.listBox_Hibak.FormattingEnabled = true;
            this.listBox_Hibak.Location = new System.Drawing.Point(3, 16);
            this.listBox_Hibak.Name = "listBox_Hibak";
            this.listBox_Hibak.Size = new System.Drawing.Size(701, 104);
            this.listBox_Hibak.TabIndex = 0;
            // 
            // listBox_Derekszogek
            // 
            this.listBox_Derekszogek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Derekszogek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Derekszogek.ForeColor = System.Drawing.Color.Green;
            this.listBox_Derekszogek.FormattingEnabled = true;
            this.listBox_Derekszogek.ItemHeight = 18;
            this.listBox_Derekszogek.Location = new System.Drawing.Point(3, 23);
            this.listBox_Derekszogek.Name = "listBox_Derekszogek";
            this.listBox_Derekszogek.Size = new System.Drawing.Size(438, 198);
            this.listBox_Derekszogek.TabIndex = 0;
            this.listBox_Derekszogek.SelectedIndexChanged += new System.EventHandler(this.listBox_Derekszogek_SelectedIndexChanged);
            // 
            // label_Kerulet
            // 
            this.label_Kerulet.AutoSize = true;
            this.label_Kerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Kerulet.Location = new System.Drawing.Point(17, 34);
            this.label_Kerulet.Name = "label_Kerulet";
            this.label_Kerulet.Size = new System.Drawing.Size(86, 20);
            this.label_Kerulet.TabIndex = 0;
            this.label_Kerulet.Text = "Kerület = ";
            // 
            // label_Terulet
            // 
            this.label_Terulet.AutoSize = true;
            this.label_Terulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Terulet.Location = new System.Drawing.Point(17, 74);
            this.label_Terulet.Name = "label_Terulet";
            this.label_Terulet.Size = new System.Drawing.Size(85, 20);
            this.label_Terulet.TabIndex = 0;
            this.label_Terulet.Text = "Terület = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Adatbetoltes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Derékszögű háromszögek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Adatbetoltes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox_Hibak;
        private System.Windows.Forms.ListBox listBox_Derekszogek;
        private System.Windows.Forms.Label label_Terulet;
        private System.Windows.Forms.Label label_Kerulet;
    }
}

