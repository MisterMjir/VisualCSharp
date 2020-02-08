namespace Calculator
{
    partial class Calculator
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.BackColor = System.Drawing.Color.White;
            this.NumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberLabel.Location = new System.Drawing.Point(26, 24);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(224, 38);
            this.NumberLabel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 57);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(192, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 57);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 57);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(192, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 57);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(108, 319);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 57);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(26, 319);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(58, 57);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "CE";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(192, 319);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(58, 57);
            this.EqualButton.TabIndex = 12;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(314, 83);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(58, 57);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(314, 162);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(58, 57);
            this.SubtractButton.TabIndex = 14;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(314, 237);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(58, 57);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(314, 319);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(58, 57);
            this.DivideButton.TabIndex = 16;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 422);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumberLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
    }
}

