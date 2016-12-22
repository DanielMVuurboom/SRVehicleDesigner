namespace SRVehicleDesigner
{
    partial class Selection
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
            this.chassisGroupListBox = new System.Windows.Forms.ListBox();
            this.chassisGroupLabel = new System.Windows.Forms.Label();
            this.chassisLabel = new System.Windows.Forms.Label();
            this.chassisListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chassisGroupListBox
            // 
            this.chassisGroupListBox.FormattingEnabled = true;
            this.chassisGroupListBox.Location = new System.Drawing.Point(118, 12);
            this.chassisGroupListBox.Name = "chassisGroupListBox";
            this.chassisGroupListBox.Size = new System.Drawing.Size(120, 17);
            this.chassisGroupListBox.TabIndex = 0;
            this.chassisGroupListBox.SelectedIndexChanged += new System.EventHandler(this.chassisGroupListBox_SelectedIndexChanged);
            // 
            // chassisGroupLabel
            // 
            this.chassisGroupLabel.AutoSize = true;
            this.chassisGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassisGroupLabel.Location = new System.Drawing.Point(24, 12);
            this.chassisGroupLabel.Name = "chassisGroupLabel";
            this.chassisGroupLabel.Size = new System.Drawing.Size(88, 13);
            this.chassisGroupLabel.TabIndex = 2;
            this.chassisGroupLabel.Text = "Chassis Group";
            // 
            // chassisLabel
            // 
            this.chassisLabel.AutoSize = true;
            this.chassisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassisLabel.Location = new System.Drawing.Point(24, 36);
            this.chassisLabel.Name = "chassisLabel";
            this.chassisLabel.Size = new System.Drawing.Size(50, 13);
            this.chassisLabel.TabIndex = 3;
            this.chassisLabel.Text = "Chassis";
            // 
            // chassisListBox
            // 
            this.chassisListBox.FormattingEnabled = true;
            this.chassisListBox.Location = new System.Drawing.Point(118, 36);
            this.chassisListBox.Name = "chassisListBox";
            this.chassisListBox.Size = new System.Drawing.Size(120, 17);
            this.chassisListBox.TabIndex = 4;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chassisListBox);
            this.Controls.Add(this.chassisLabel);
            this.Controls.Add(this.chassisGroupLabel);
            this.Controls.Add(this.chassisGroupListBox);
            this.Name = "Selection";
            this.Text = "Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chassisGroupListBox;
        private System.Windows.Forms.Label chassisGroupLabel;
        private System.Windows.Forms.Label chassisLabel;
        private System.Windows.Forms.ListBox chassisListBox;
    }
}

