namespace SRVehicleDesigner
{
    partial class Modification
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
            this.drivingGroup = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.handlingRoadLabel = new System.Windows.Forms.Label();
            this.handlingRoadBox = new System.Windows.Forms.ComboBox();
            this.handlingOffRoadLabel = new System.Windows.Forms.Label();
            this.handlingOffRoadBox = new System.Windows.Forms.ComboBox();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.accelBox = new System.Windows.Forms.TextBox();
            this.accelLabel = new System.Windows.Forms.Label();
            this.economyBox = new System.Windows.Forms.TextBox();
            this.economyLabel = new System.Windows.Forms.Label();
            this.fuelSizeBox = new System.Windows.Forms.TextBox();
            this.fuelSizeLabel = new System.Windows.Forms.Label();
            this.drivingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // drivingGroup
            // 
            this.drivingGroup.Controls.Add(this.fuelSizeBox);
            this.drivingGroup.Controls.Add(this.fuelSizeLabel);
            this.drivingGroup.Controls.Add(this.economyBox);
            this.drivingGroup.Controls.Add(this.economyLabel);
            this.drivingGroup.Controls.Add(this.accelBox);
            this.drivingGroup.Controls.Add(this.accelLabel);
            this.drivingGroup.Controls.Add(this.speedBox);
            this.drivingGroup.Controls.Add(this.speedLabel);
            this.drivingGroup.Controls.Add(this.handlingOffRoadLabel);
            this.drivingGroup.Controls.Add(this.handlingOffRoadBox);
            this.drivingGroup.Controls.Add(this.handlingRoadLabel);
            this.drivingGroup.Controls.Add(this.handlingRoadBox);
            this.drivingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingGroup.Location = new System.Drawing.Point(24, 85);
            this.drivingGroup.Name = "drivingGroup";
            this.drivingGroup.Size = new System.Drawing.Size(810, 100);
            this.drivingGroup.TabIndex = 0;
            this.drivingGroup.TabStop = false;
            this.drivingGroup.Text = "Driving";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargo Factor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 2;
            // 
            // handlingRoadLabel
            // 
            this.handlingRoadLabel.AutoSize = true;
            this.handlingRoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handlingRoadLabel.Location = new System.Drawing.Point(3, 21);
            this.handlingRoadLabel.Name = "handlingRoadLabel";
            this.handlingRoadLabel.Size = new System.Drawing.Size(49, 13);
            this.handlingRoadLabel.TabIndex = 4;
            this.handlingRoadLabel.Text = "Handling";
            // 
            // handlingRoadBox
            // 
            this.handlingRoadBox.FormattingEnabled = true;
            this.handlingRoadBox.Location = new System.Drawing.Point(6, 37);
            this.handlingRoadBox.Name = "handlingRoadBox";
            this.handlingRoadBox.Size = new System.Drawing.Size(77, 21);
            this.handlingRoadBox.TabIndex = 3;
            this.handlingRoadBox.SelectedIndexChanged += new System.EventHandler(this.handlingRoadBox_SelectedIndexChanged);
            // 
            // handlingOffRoadLabel
            // 
            this.handlingOffRoadLabel.AutoSize = true;
            this.handlingOffRoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handlingOffRoadLabel.Location = new System.Drawing.Point(86, 21);
            this.handlingOffRoadLabel.Name = "handlingOffRoadLabel";
            this.handlingOffRoadLabel.Size = new System.Drawing.Size(50, 13);
            this.handlingOffRoadLabel.TabIndex = 6;
            this.handlingOffRoadLabel.Text = "Off-Road";
            // 
            // handlingOffRoadBox
            // 
            this.handlingOffRoadBox.FormattingEnabled = true;
            this.handlingOffRoadBox.Location = new System.Drawing.Point(89, 37);
            this.handlingOffRoadBox.Name = "handlingOffRoadBox";
            this.handlingOffRoadBox.Size = new System.Drawing.Size(77, 21);
            this.handlingOffRoadBox.TabIndex = 5;
            this.handlingOffRoadBox.SelectedIndexChanged += new System.EventHandler(this.handlingOffRoadBox_SelectedIndexChanged);
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(172, 38);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(77, 20);
            this.speedBox.TabIndex = 5;
            this.speedBox.TextChanged += new System.EventHandler(this.speedBox_TextChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(169, 22);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "Speed";
            // 
            // accelBox
            // 
            this.accelBox.Location = new System.Drawing.Point(255, 38);
            this.accelBox.Name = "accelBox";
            this.accelBox.Size = new System.Drawing.Size(77, 20);
            this.accelBox.TabIndex = 8;
            this.accelBox.TextChanged += new System.EventHandler(this.accelBox_TextChanged);
            // 
            // accelLabel
            // 
            this.accelLabel.AutoSize = true;
            this.accelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelLabel.Location = new System.Drawing.Point(252, 22);
            this.accelLabel.Name = "accelLabel";
            this.accelLabel.Size = new System.Drawing.Size(34, 13);
            this.accelLabel.TabIndex = 7;
            this.accelLabel.Text = "Accel";
            // 
            // economyBox
            // 
            this.economyBox.Location = new System.Drawing.Point(338, 38);
            this.economyBox.Name = "economyBox";
            this.economyBox.Size = new System.Drawing.Size(77, 20);
            this.economyBox.TabIndex = 10;
            this.economyBox.TextChanged += new System.EventHandler(this.economyBox_TextChanged);
            // 
            // economyLabel
            // 
            this.economyLabel.AutoSize = true;
            this.economyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.economyLabel.Location = new System.Drawing.Point(335, 22);
            this.economyLabel.Name = "economyLabel";
            this.economyLabel.Size = new System.Drawing.Size(51, 13);
            this.economyLabel.TabIndex = 9;
            this.economyLabel.Text = "Economy";
            // 
            // fuelSizeBox
            // 
            this.fuelSizeBox.Location = new System.Drawing.Point(421, 38);
            this.fuelSizeBox.Name = "fuelSizeBox";
            this.fuelSizeBox.Size = new System.Drawing.Size(77, 20);
            this.fuelSizeBox.TabIndex = 12;
            this.fuelSizeBox.TextChanged += new System.EventHandler(this.fuelSizeBox_TextChanged);
            // 
            // fuelSizeLabel
            // 
            this.fuelSizeLabel.AutoSize = true;
            this.fuelSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelSizeLabel.Location = new System.Drawing.Point(418, 22);
            this.fuelSizeLabel.Name = "fuelSizeLabel";
            this.fuelSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.fuelSizeLabel.TabIndex = 11;
            this.fuelSizeLabel.Text = "Fuel";
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 374);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.drivingGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Modification";
            this.Text = "Modification";
            this.drivingGroup.ResumeLayout(false);
            this.drivingGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox drivingGroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label handlingOffRoadLabel;
        private System.Windows.Forms.ComboBox handlingOffRoadBox;
        private System.Windows.Forms.Label handlingRoadLabel;
        private System.Windows.Forms.ComboBox handlingRoadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox accelBox;
        private System.Windows.Forms.Label accelLabel;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox fuelSizeBox;
        private System.Windows.Forms.Label fuelSizeLabel;
        private System.Windows.Forms.TextBox economyBox;
        private System.Windows.Forms.Label economyLabel;
    }
}