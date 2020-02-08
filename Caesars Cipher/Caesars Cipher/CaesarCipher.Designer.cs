namespace Caesars_Cipher
{
    partial class CaesarCipher
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
            this.StringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnocdeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StringTextBox
            // 
            this.StringTextBox.Location = new System.Drawing.Point(122, 109);
            this.StringTextBox.Multiline = true;
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.Size = new System.Drawing.Size(569, 233);
            this.StringTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your text:";
            // 
            // EnocdeButton
            // 
            this.EnocdeButton.Location = new System.Drawing.Point(122, 375);
            this.EnocdeButton.Name = "EnocdeButton";
            this.EnocdeButton.Size = new System.Drawing.Size(117, 63);
            this.EnocdeButton.TabIndex = 2;
            this.EnocdeButton.Text = "Encode";
            this.EnocdeButton.UseVisualStyleBackColor = true;
            this.EnocdeButton.Click += new System.EventHandler(this.EnocdeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(574, 375);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(117, 63);
            this.DecodeButton.TabIndex = 3;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EnocdeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StringTextBox);
            this.Name = "CaesarCipher";
            this.Text = "Musgrave\'s Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnocdeButton;
        private System.Windows.Forms.Button DecodeButton;
    }
}

