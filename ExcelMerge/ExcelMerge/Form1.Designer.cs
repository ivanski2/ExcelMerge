namespace ExcelMerge
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
            this.Merge = new System.Windows.Forms.Button();
            this.Select_all = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Merge
            // 
            this.Merge.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Merge.Location = new System.Drawing.Point(101, 395);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 23);
            this.Merge.TabIndex = 1;
            this.Merge.Text = "Merge";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select_all
            // 
            this.Select_all.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Select_all.Location = new System.Drawing.Point(20, 395);
            this.Select_all.Name = "Select_all";
            this.Select_all.Size = new System.Drawing.Size(75, 23);
            this.Select_all.TabIndex = 4;
            this.Select_all.Text = "Select all";
            this.Select_all.UseVisualStyleBackColor = true;
            this.Select_all.Click += new System.EventHandler(this.button2_Click);
            // 
            // Browse
            // 
            this.Browse.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Browse.Location = new System.Drawing.Point(39, 12);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 11;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button8_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 44);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(245, 329);
            this.listbox.TabIndex = 0;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Clear.Location = new System.Drawing.Point(182, 395);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button10_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Delete.Location = new System.Drawing.Point(138, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(283, 430);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Select_all);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.Button Select_all;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
    }
}

