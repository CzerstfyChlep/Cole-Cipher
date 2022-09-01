namespace ColeCipher
{
    partial class MainForm
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.CodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(260, 111);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "Input";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 129);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(260, 111);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "Output";
            // 
            // CodeButton
            // 
            this.CodeButton.Location = new System.Drawing.Point(197, 246);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(75, 23);
            this.CodeButton.TabIndex = 2;
            this.CodeButton.Text = "Cole";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(116, 246);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(75, 23);
            this.DecodeButton.TabIndex = 3;
            this.DecodeButton.Text = "Decole";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(12, 249);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(98, 20);
            this.IPBox.TabIndex = 5;
            this.IPBox.Text = "IP";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 275);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(260, 20);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.CodeButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Name = "MainForm";
            this.Text = "ColeCipher by ChytraWydra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button CodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

