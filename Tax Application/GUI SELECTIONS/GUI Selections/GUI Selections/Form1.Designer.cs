namespace GUI_Selections
{
    partial class GUI_selector
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
            System.Windows.Forms.Button Connector_button;
            this.Display = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.ListBox();
            Connector_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(204, 215);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(319, 20);
            this.Display.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Items.AddRange(new object[] {
            "Aimon Larios",
            "Josh Baca",
            "Christopher McCall",
            "Greg McKee",
            "Julien Esposito"});
            this.NameBox.Location = new System.Drawing.Point(360, 52);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(163, 134);
            this.NameBox.TabIndex = 1;
            // 
            // Connector_button
            // 
            Connector_button.Location = new System.Drawing.Point(204, 71);
            Connector_button.Name = "Connector_button";
            Connector_button.Size = new System.Drawing.Size(110, 51);
            Connector_button.TabIndex = 2;
            Connector_button.Text = "this button might work";
            Connector_button.UseVisualStyleBackColor = true;
            // 
            // GUI_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 333);
            this.Controls.Add(Connector_button);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Display);
            this.Name = "GUI_selector";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.ListBox NameBox;
    }
}

