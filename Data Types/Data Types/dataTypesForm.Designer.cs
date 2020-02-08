namespace Data_Types
{
    partial class dataTypesForm
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
            this.numericButton = new System.Windows.Forms.Button();
            this.boolButton = new System.Windows.Forms.Button();
            this.constantButton = new System.Windows.Forms.Button();
            this.stringButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numericButton
            // 
            this.numericButton.Location = new System.Drawing.Point(353, 26);
            this.numericButton.Name = "numericButton";
            this.numericButton.Size = new System.Drawing.Size(120, 61);
            this.numericButton.TabIndex = 0;
            this.numericButton.Text = "Numeric Data";
            this.numericButton.UseVisualStyleBackColor = true;
            this.numericButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // boolButton
            // 
            this.boolButton.Location = new System.Drawing.Point(353, 134);
            this.boolButton.Name = "boolButton";
            this.boolButton.Size = new System.Drawing.Size(120, 61);
            this.boolButton.TabIndex = 1;
            this.boolButton.Text = "Boolean Data";
            this.boolButton.UseVisualStyleBackColor = true;
            this.boolButton.Click += new System.EventHandler(this.BoolButton_Click);
            // 
            // constantButton
            // 
            this.constantButton.Location = new System.Drawing.Point(353, 243);
            this.constantButton.Name = "constantButton";
            this.constantButton.Size = new System.Drawing.Size(120, 61);
            this.constantButton.TabIndex = 2;
            this.constantButton.Text = "Constant Data";
            this.constantButton.UseVisualStyleBackColor = true;
            this.constantButton.Click += new System.EventHandler(this.ConstantButton_Click);
            // 
            // stringButton
            // 
            this.stringButton.Location = new System.Drawing.Point(353, 350);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(120, 61);
            this.stringButton.TabIndex = 3;
            this.stringButton.Text = "String Data";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.Click += new System.EventHandler(this.StringButton_Click);
            // 
            // dataTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stringButton);
            this.Controls.Add(this.constantButton);
            this.Controls.Add(this.boolButton);
            this.Controls.Add(this.numericButton);
            this.Name = "dataTypesForm";
            this.Text = "Mad Lab Experiment with Data Types (Wear Safety Goggles)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button numericButton;
        private System.Windows.Forms.Button boolButton;
        private System.Windows.Forms.Button constantButton;
        private System.Windows.Forms.Button stringButton;
    }
}

