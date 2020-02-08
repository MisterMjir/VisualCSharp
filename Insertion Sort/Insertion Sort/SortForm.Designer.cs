namespace Insertion_Sort
{
    partial class SortForm
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
            this.AddNumButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.UpDownList = new System.Windows.Forms.NumericUpDown();
            this.NumberList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNumButton
            // 
            this.AddNumButton.Location = new System.Drawing.Point(177, 86);
            this.AddNumButton.Name = "AddNumButton";
            this.AddNumButton.Size = new System.Drawing.Size(75, 23);
            this.AddNumButton.TabIndex = 0;
            this.AddNumButton.Text = "Add Number";
            this.AddNumButton.UseVisualStyleBackColor = true;
            this.AddNumButton.Click += new System.EventHandler(this.AddFrontButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(177, 173);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(177, 115);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter a new number";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(177, 144);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // UpDownList
            // 
            this.UpDownList.Location = new System.Drawing.Point(38, 46);
            this.UpDownList.Name = "UpDownList";
            this.UpDownList.Size = new System.Drawing.Size(214, 20);
            this.UpDownList.TabIndex = 9;
            // 
            // NumberList
            // 
            this.NumberList.FormattingEnabled = true;
            this.NumberList.Location = new System.Drawing.Point(38, 86);
            this.NumberList.Name = "NumberList";
            this.NumberList.Size = new System.Drawing.Size(120, 108);
            this.NumberList.TabIndex = 10;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 226);
            this.Controls.Add(this.NumberList);
            this.Controls.Add(this.UpDownList);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddNumButton);
            this.Name = "SortForm";
            this.Text = "My Insertion Sort";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNumButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.NumericUpDown UpDownList;
        private System.Windows.Forms.ListBox NumberList;
    }
}

