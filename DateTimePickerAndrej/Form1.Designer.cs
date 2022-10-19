namespace DateTimePickerAndrej
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
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonRezervacija = new System.Windows.Forms.Button();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVrijeme = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upišite datum leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upišite vrijeme polaska:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 179);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonRezervacija
            // 
            this.buttonRezervacija.Location = new System.Drawing.Point(180, 330);
            this.buttonRezervacija.Name = "buttonRezervacija";
            this.buttonRezervacija.Size = new System.Drawing.Size(75, 23);
            this.buttonRezervacija.TabIndex = 3;
            this.buttonRezervacija.Text = "rezervacija";
            this.buttonRezervacija.UseVisualStyleBackColor = true;
            this.buttonRezervacija.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(195, 28);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 4;
            // 
            // dateTimePickerVrijeme
            // 
            this.dateTimePickerVrijeme.AllowDrop = true;
            this.dateTimePickerVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerVrijeme.Location = new System.Drawing.Point(195, 65);
            this.dateTimePickerVrijeme.Name = "dateTimePickerVrijeme";
            this.dateTimePickerVrijeme.ShowUpDown = true;
            this.dateTimePickerVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVrijeme.TabIndex = 5;
            this.dateTimePickerVrijeme.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerVrijeme);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.buttonRezervacija);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonRezervacija;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerVrijeme;
    }
}

