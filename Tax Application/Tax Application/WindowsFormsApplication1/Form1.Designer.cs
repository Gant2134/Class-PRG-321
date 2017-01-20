namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_workers = new System.Windows.Forms.ListBox();
            this.Display_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(247)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(187, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "This is that bullshit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_workers
            // 
            this.listBox_workers.FormattingEnabled = true;
            this.listBox_workers.Items.AddRange(new object[] {
            "Aimon Larios",
            "Christopher McCall",
            "Josh Baca",
            "Greg McKee",
            "Julien Esposito"});
            this.listBox_workers.Location = new System.Drawing.Point(359, 51);
            this.listBox_workers.Name = "listBox_workers";
            this.listBox_workers.Size = new System.Drawing.Size(120, 95);
            this.listBox_workers.TabIndex = 1;
            this.listBox_workers.SelectedIndexChanged += new System.EventHandler(this.listBox_workers_SelectedIndexChanged);
            // 
            // Display_textbox
            // 
            this.Display_textbox.Location = new System.Drawing.Point(178, 169);
            this.Display_textbox.Name = "Display_textbox";
            this.Display_textbox.ReadOnly = true;
            this.Display_textbox.Size = new System.Drawing.Size(301, 20);
            this.Display_textbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 261);
            this.Controls.Add(this.Display_textbox);
            this.Controls.Add(this.listBox_workers);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "GUI selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_workers;
        private System.Windows.Forms.TextBox Display_textbox;
    }
}

