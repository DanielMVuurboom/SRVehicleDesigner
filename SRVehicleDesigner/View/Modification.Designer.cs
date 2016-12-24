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
            this.components = new System.ComponentModel.Container();
            this.drivingGroup = new System.Windows.Forms.GroupBox();
            this.fuelSizeBox = new System.Windows.Forms.TextBox();
            this.fuelSizeLabel = new System.Windows.Forms.Label();
            this.economyBox = new System.Windows.Forms.TextBox();
            this.economyLabel = new System.Windows.Forms.Label();
            this.accelBox = new System.Windows.Forms.TextBox();
            this.accelLabel = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.handlingOffRoadLabel = new System.Windows.Forms.Label();
            this.handlingOffRoadBox = new System.Windows.Forms.ComboBox();
            this.handlingRoadLabel = new System.Windows.Forms.Label();
            this.handlingRoadBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.designPointLabel = new System.Windows.Forms.Label();
            this.drivingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // drivingGroup
            // 
            this.drivingGroup.Controls.Add(this.fuelSizeBox);
            this.drivingGroup.Controls.Add(this.handlingRoadLabel);
            this.drivingGroup.Controls.Add(this.fuelSizeLabel);
            this.drivingGroup.Controls.Add(this.handlingRoadBox);
            this.drivingGroup.Controls.Add(this.handlingOffRoadBox);
            this.drivingGroup.Controls.Add(this.handlingOffRoadLabel);
            this.drivingGroup.Controls.Add(this.economyBox);
            this.drivingGroup.Controls.Add(this.economyLabel);
            this.drivingGroup.Controls.Add(this.speedBox);
            this.drivingGroup.Controls.Add(this.speedLabel);
            this.drivingGroup.Controls.Add(this.accelBox);
            this.drivingGroup.Controls.Add(this.accelLabel);
            this.drivingGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingGroup.Location = new System.Drawing.Point(24, 85);
            this.drivingGroup.Name = "drivingGroup";
            this.drivingGroup.Size = new System.Drawing.Size(621, 77);
            this.drivingGroup.TabIndex = 0;
            this.drivingGroup.TabStop = false;
            this.drivingGroup.Text = "Driving";
            // 
            // fuelSizeBox
            // 
            this.fuelSizeBox.Location = new System.Drawing.Point(520, 36);
            this.fuelSizeBox.Name = "fuelSizeBox";
            this.fuelSizeBox.Size = new System.Drawing.Size(77, 20);
            this.fuelSizeBox.TabIndex = 12;
            this.fuelSizeBox.Validating += new System.ComponentModel.CancelEventHandler(this.fuelSizeBox_Validating);
            this.fuelSizeBox.Validated += new System.EventHandler(this.fuelSizeBox_Validated);
            // 
            // fuelSizeLabel
            // 
            this.fuelSizeLabel.AutoSize = true;
            this.fuelSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelSizeLabel.Location = new System.Drawing.Point(517, 20);
            this.fuelSizeLabel.Name = "fuelSizeLabel";
            this.fuelSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.fuelSizeLabel.TabIndex = 11;
            this.fuelSizeLabel.Text = "Fuel";
            // 
            // economyBox
            // 
            this.economyBox.Location = new System.Drawing.Point(416, 36);
            this.economyBox.Name = "economyBox";
            this.economyBox.Size = new System.Drawing.Size(77, 20);
            this.economyBox.TabIndex = 10;
            this.economyBox.Validating += new System.ComponentModel.CancelEventHandler(this.economyBox_Validating);
            this.economyBox.Validated += new System.EventHandler(this.economyBox_Validated);
            // 
            // economyLabel
            // 
            this.economyLabel.AutoSize = true;
            this.economyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.economyLabel.Location = new System.Drawing.Point(413, 20);
            this.economyLabel.Name = "economyLabel";
            this.economyLabel.Size = new System.Drawing.Size(51, 13);
            this.economyLabel.TabIndex = 9;
            this.economyLabel.Text = "Economy";
            // 
            // accelBox
            // 
            this.accelBox.Location = new System.Drawing.Point(314, 36);
            this.accelBox.Name = "accelBox";
            this.accelBox.Size = new System.Drawing.Size(77, 20);
            this.accelBox.TabIndex = 8;
            this.accelBox.Validating += new System.ComponentModel.CancelEventHandler(this.accelBox_Validating);
            this.accelBox.Validated += new System.EventHandler(this.accelBox_Validated);
            // 
            // accelLabel
            // 
            this.accelLabel.AutoSize = true;
            this.accelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelLabel.Location = new System.Drawing.Point(311, 20);
            this.accelLabel.Name = "accelLabel";
            this.accelLabel.Size = new System.Drawing.Size(34, 13);
            this.accelLabel.TabIndex = 7;
            this.accelLabel.Text = "Accel";
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(212, 36);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(77, 20);
            this.speedBox.TabIndex = 5;
            this.speedBox.Validating += new System.ComponentModel.CancelEventHandler(this.speedBox_Validating);
            this.speedBox.Validated += new System.EventHandler(this.speedBox_Validated);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(209, 20);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "Speed";
            // 
            // handlingOffRoadLabel
            // 
            this.handlingOffRoadLabel.AutoSize = true;
            this.handlingOffRoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handlingOffRoadLabel.Location = new System.Drawing.Point(105, 19);
            this.handlingOffRoadLabel.Name = "handlingOffRoadLabel";
            this.handlingOffRoadLabel.Size = new System.Drawing.Size(50, 13);
            this.handlingOffRoadLabel.TabIndex = 6;
            this.handlingOffRoadLabel.Text = "Off-Road";
            // 
            // handlingOffRoadBox
            // 
            this.handlingOffRoadBox.FormattingEnabled = true;
            this.handlingOffRoadBox.Location = new System.Drawing.Point(108, 35);
            this.handlingOffRoadBox.Name = "handlingOffRoadBox";
            this.handlingOffRoadBox.Size = new System.Drawing.Size(77, 21);
            this.handlingOffRoadBox.TabIndex = 5;
            this.handlingOffRoadBox.SelectedIndexChanged += new System.EventHandler(this.handlingOffRoadBox_SelectedIndexChanged);
            // 
            // handlingRoadLabel
            // 
            this.handlingRoadLabel.AutoSize = true;
            this.handlingRoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handlingRoadLabel.Location = new System.Drawing.Point(3, 19);
            this.handlingRoadLabel.Name = "handlingRoadLabel";
            this.handlingRoadLabel.Size = new System.Drawing.Size(49, 13);
            this.handlingRoadLabel.TabIndex = 4;
            this.handlingRoadLabel.Text = "Handling";
            // 
            // handlingRoadBox
            // 
            this.handlingRoadBox.FormattingEnabled = true;
            this.handlingRoadBox.Location = new System.Drawing.Point(6, 35);
            this.handlingRoadBox.Name = "handlingRoadBox";
            this.handlingRoadBox.Size = new System.Drawing.Size(77, 21);
            this.handlingRoadBox.TabIndex = 3;
            this.handlingRoadBox.SelectedIndexChanged += new System.EventHandler(this.handlingRoadBox_SelectedIndexChanged);
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(27, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(27, 45);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(27, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "cost";
            this.costLabel.UseMnemonic = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // designPointLabel
            // 
            this.designPointLabel.AutoSize = true;
            this.designPointLabel.Location = new System.Drawing.Point(27, 58);
            this.designPointLabel.Name = "designPointLabel";
            this.designPointLabel.Size = new System.Drawing.Size(69, 13);
            this.designPointLabel.TabIndex = 5;
            this.designPointLabel.Text = "design points";
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 374);
            this.Controls.Add(this.designPointLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.drivingGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Modification";
            this.Text = "Modification";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Modification_Paint);
            this.drivingGroup.ResumeLayout(false);
            this.drivingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label designPointLabel;
    }
}