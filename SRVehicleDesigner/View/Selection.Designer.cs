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
            this.chassisGroupLabel = new System.Windows.Forms.Label();
            this.chassisLabel = new System.Windows.Forms.Label();
            this.chassisGroupBox = new System.Windows.Forms.ComboBox();
            this.chassisBox = new System.Windows.Forms.ComboBox();
            this.powerPlantBox = new System.Windows.Forms.ComboBox();
            this.powerPlantLabel = new System.Windows.Forms.Label();
            this.droneBox = new System.Windows.Forms.ComboBox();
            this.droneLabel = new System.Windows.Forms.Label();
            this.newVehicleButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.chassisLabel.Location = new System.Drawing.Point(24, 40);
            this.chassisLabel.Name = "chassisLabel";
            this.chassisLabel.Size = new System.Drawing.Size(50, 13);
            this.chassisLabel.TabIndex = 3;
            this.chassisLabel.Text = "Chassis";
            // 
            // chassisGroupBox
            // 
            this.chassisGroupBox.FormattingEnabled = true;
            this.chassisGroupBox.Location = new System.Drawing.Point(119, 12);
            this.chassisGroupBox.Name = "chassisGroupBox";
            this.chassisGroupBox.Size = new System.Drawing.Size(121, 21);
            this.chassisGroupBox.TabIndex = 4;
            this.chassisGroupBox.SelectedIndexChanged += new System.EventHandler(this.chassisGroupBox_SelectedIndexChanged);
            // 
            // chassisBox
            // 
            this.chassisBox.DisplayMember = "Name";
            this.chassisBox.FormattingEnabled = true;
            this.chassisBox.Location = new System.Drawing.Point(119, 40);
            this.chassisBox.Name = "chassisBox";
            this.chassisBox.Size = new System.Drawing.Size(121, 21);
            this.chassisBox.TabIndex = 5;
            this.chassisBox.SelectedIndexChanged += new System.EventHandler(this.chassisBox_SelectedIndexChanged);
            // 
            // powerPlantBox
            // 
            this.powerPlantBox.DisplayMember = "Type";
            this.powerPlantBox.FormattingEnabled = true;
            this.powerPlantBox.Location = new System.Drawing.Point(119, 68);
            this.powerPlantBox.Name = "powerPlantBox";
            this.powerPlantBox.Size = new System.Drawing.Size(121, 21);
            this.powerPlantBox.TabIndex = 6;
            // 
            // powerPlantLabel
            // 
            this.powerPlantLabel.AutoSize = true;
            this.powerPlantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerPlantLabel.Location = new System.Drawing.Point(24, 68);
            this.powerPlantLabel.Name = "powerPlantLabel";
            this.powerPlantLabel.Size = new System.Drawing.Size(75, 13);
            this.powerPlantLabel.TabIndex = 8;
            this.powerPlantLabel.Text = "Power Plant";
            // 
            // droneBox
            // 
            this.droneBox.FormattingEnabled = true;
            this.droneBox.Location = new System.Drawing.Point(119, 96);
            this.droneBox.Name = "droneBox";
            this.droneBox.Size = new System.Drawing.Size(121, 21);
            this.droneBox.TabIndex = 9;
            // 
            // droneLabel
            // 
            this.droneLabel.AutoSize = true;
            this.droneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droneLabel.Location = new System.Drawing.Point(24, 96);
            this.droneLabel.Name = "droneLabel";
            this.droneLabel.Size = new System.Drawing.Size(41, 13);
            this.droneLabel.TabIndex = 10;
            this.droneLabel.Text = "Drone";
            // 
            // newVehicleButton
            // 
            this.newVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVehicleButton.Location = new System.Drawing.Point(119, 224);
            this.newVehicleButton.Name = "newVehicleButton";
            this.newVehicleButton.Size = new System.Drawing.Size(121, 23);
            this.newVehicleButton.TabIndex = 11;
            this.newVehicleButton.Text = "Create Vehicle";
            this.newVehicleButton.UseVisualStyleBackColor = true;
            this.newVehicleButton.Click += new System.EventHandler(this.newVehicleButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(119, 195);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(120, 23);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Load Vehicle";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 261);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.newVehicleButton);
            this.Controls.Add(this.droneLabel);
            this.Controls.Add(this.droneBox);
            this.Controls.Add(this.powerPlantLabel);
            this.Controls.Add(this.powerPlantBox);
            this.Controls.Add(this.chassisBox);
            this.Controls.Add(this.chassisGroupBox);
            this.Controls.Add(this.chassisLabel);
            this.Controls.Add(this.chassisGroupLabel);
            this.Name = "Selection";
            this.Text = "Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label chassisGroupLabel;
        private System.Windows.Forms.Label chassisLabel;
        private System.Windows.Forms.ComboBox chassisGroupBox;
        private System.Windows.Forms.ComboBox chassisBox;
        private System.Windows.Forms.ComboBox powerPlantBox;
        private System.Windows.Forms.Label powerPlantLabel;
        private System.Windows.Forms.ComboBox droneBox;
        private System.Windows.Forms.Label droneLabel;
        private System.Windows.Forms.Button newVehicleButton;
        private System.Windows.Forms.Button loadButton;
    }
}

