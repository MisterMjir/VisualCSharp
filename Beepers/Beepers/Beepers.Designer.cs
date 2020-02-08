namespace Beepers
{
    partial class Beepers
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
            this.forButton = new System.Windows.Forms.Button();
            this.whileButton = new System.Windows.Forms.Button();
            this.doButton = new System.Windows.Forms.Button();
            this.numBeepsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(341, 151);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(152, 63);
            this.forButton.TabIndex = 0;
            this.forButton.Text = "For Loop Beep";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.ForButton_Click);
            // 
            // whileButton
            // 
            this.whileButton.Location = new System.Drawing.Point(341, 255);
            this.whileButton.Name = "whileButton";
            this.whileButton.Size = new System.Drawing.Size(152, 63);
            this.whileButton.TabIndex = 1;
            this.whileButton.Text = "While Loop Beep";
            this.whileButton.UseVisualStyleBackColor = true;
            this.whileButton.Click += new System.EventHandler(this.WhileButton_Click);
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(341, 363);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(152, 63);
            this.doButton.TabIndex = 2;
            this.doButton.Text = "Do Loop Beep";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // numBeepsText
            // 
            this.numBeepsText.Location = new System.Drawing.Point(436, 72);
            this.numBeepsText.Name = "numBeepsText";
            this.numBeepsText.Size = new System.Drawing.Size(57, 20);
            this.numBeepsText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of beeps:";
            // 
            // Beepers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBeepsText);
            this.Controls.Add(this.doButton);
            this.Controls.Add(this.whileButton);
            this.Controls.Add(this.forButton);
            this.Name = "Beepers";
            this.Text = "Beep Bloop Beep!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.TextBox numBeepsText;
        private System.Windows.Forms.Label label1;
    }
}

