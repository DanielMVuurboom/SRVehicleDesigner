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
            this.handlingRoadLabel = new System.Windows.Forms.Label();
            this.fuelSizeLabel = new System.Windows.Forms.Label();
            this.handlingRoadBox = new System.Windows.Forms.ComboBox();
            this.handlingOffRoadBox = new System.Windows.Forms.ComboBox();
            this.handlingOffRoadLabel = new System.Windows.Forms.Label();
            this.economyBox = new System.Windows.Forms.TextBox();
            this.economyLabel = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.accelBox = new System.Windows.Forms.TextBox();
            this.accelLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.designPointLabel = new System.Windows.Forms.Label();
            this.physicalGroup = new System.Windows.Forms.GroupBox();
            this.loadFreeLabel = new System.Windows.Forms.Label();
            this.loadFreeBox = new System.Windows.Forms.TextBox();
            this.cargoFactorFreeLabel = new System.Windows.Forms.Label();
            this.cargoFactorFreeBox = new System.Windows.Forms.TextBox();
            this.loadLabel = new System.Windows.Forms.Label();
            this.loadBox = new System.Windows.Forms.TextBox();
            this.cargoFactorLabel = new System.Windows.Forms.Label();
            this.cargoFactorBox = new System.Windows.Forms.TextBox();
            this.armorLabel = new System.Windows.Forms.Label();
            this.armorBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.ElectronicsGroup = new System.Windows.Forms.GroupBox();
            this.sigBox = new System.Windows.Forms.TextBox();
            this.ecdBox = new System.Windows.Forms.ComboBox();
            this.ecdLabel = new System.Windows.Forms.Label();
            this.edBox = new System.Windows.Forms.ComboBox();
            this.edLabel = new System.Windows.Forms.Label();
            this.eccmBox = new System.Windows.Forms.ComboBox();
            this.eccmLabel = new System.Windows.Forms.Label();
            this.ecmBox = new System.Windows.Forms.ComboBox();
            this.ecmLabel = new System.Windows.Forms.Label();
            this.sensorBox = new System.Windows.Forms.ComboBox();
            this.sensorLabel = new System.Windows.Forms.Label();
            this.sigLabel = new System.Windows.Forms.Label();
            this.pilotBox = new System.Windows.Forms.ComboBox();
            this.pilotLabel = new System.Windows.Forms.Label();
            this.autoNavBox = new System.Windows.Forms.ComboBox();
            this.autoNavlabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.drivingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.physicalGroup.SuspendLayout();
            this.ElectronicsGroup.SuspendLayout();
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
            this.drivingGroup.Location = new System.Drawing.Point(24, 149);
            this.drivingGroup.Name = "drivingGroup";
            this.drivingGroup.Size = new System.Drawing.Size(622, 72);
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
            this.fuelSizeBox.Validated += new System.EventHandler(this.generic_Validated);
            // 
            // handlingRoadLabel
            // 
            this.handlingRoadLabel.AutoSize = true;
            this.handlingRoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handlingRoadLabel.Location = new System.Drawing.Point(3, 16);
            this.handlingRoadLabel.Name = "handlingRoadLabel";
            this.handlingRoadLabel.Size = new System.Drawing.Size(49, 13);
            this.handlingRoadLabel.TabIndex = 4;
            this.handlingRoadLabel.Text = "Handling";
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
            // handlingRoadBox
            // 
            this.handlingRoadBox.FormattingEnabled = true;
            this.handlingRoadBox.Location = new System.Drawing.Point(6, 35);
            this.handlingRoadBox.Name = "handlingRoadBox";
            this.handlingRoadBox.Size = new System.Drawing.Size(77, 21);
            this.handlingRoadBox.TabIndex = 7;
            this.handlingRoadBox.SelectionChangeCommitted += new System.EventHandler(this.handlingRoadBox_SelectionChangeCommitted);
            // 
            // handlingOffRoadBox
            // 
            this.handlingOffRoadBox.FormattingEnabled = true;
            this.handlingOffRoadBox.Location = new System.Drawing.Point(108, 35);
            this.handlingOffRoadBox.Name = "handlingOffRoadBox";
            this.handlingOffRoadBox.Size = new System.Drawing.Size(77, 21);
            this.handlingOffRoadBox.TabIndex = 8;
            this.handlingOffRoadBox.SelectionChangeCommitted += new System.EventHandler(this.handlingOffRoadBox_SelectionChangeCommitted);
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
            // economyBox
            // 
            this.economyBox.Location = new System.Drawing.Point(416, 36);
            this.economyBox.Name = "economyBox";
            this.economyBox.Size = new System.Drawing.Size(77, 20);
            this.economyBox.TabIndex = 11;
            this.economyBox.Validating += new System.ComponentModel.CancelEventHandler(this.economyBox_Validating);
            this.economyBox.Validated += new System.EventHandler(this.generic_Validated);
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
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(212, 36);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(77, 20);
            this.speedBox.TabIndex = 9;
            this.speedBox.Validating += new System.ComponentModel.CancelEventHandler(this.speedBox_Validating);
            this.speedBox.Validated += new System.EventHandler(this.generic_Validated);
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
            // accelBox
            // 
            this.accelBox.Location = new System.Drawing.Point(314, 36);
            this.accelBox.Name = "accelBox";
            this.accelBox.Size = new System.Drawing.Size(77, 20);
            this.accelBox.TabIndex = 10;
            this.accelBox.Validating += new System.ComponentModel.CancelEventHandler(this.accelBox_Validating);
            this.accelBox.Validated += new System.EventHandler(this.generic_Validated);
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
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(21, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(21, 33);
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
            this.designPointLabel.Location = new System.Drawing.Point(21, 46);
            this.designPointLabel.Name = "designPointLabel";
            this.designPointLabel.Size = new System.Drawing.Size(69, 13);
            this.designPointLabel.TabIndex = 5;
            this.designPointLabel.Text = "design points";
            // 
            // physicalGroup
            // 
            this.physicalGroup.Controls.Add(this.loadFreeLabel);
            this.physicalGroup.Controls.Add(this.loadFreeBox);
            this.physicalGroup.Controls.Add(this.cargoFactorFreeLabel);
            this.physicalGroup.Controls.Add(this.cargoFactorFreeBox);
            this.physicalGroup.Controls.Add(this.loadLabel);
            this.physicalGroup.Controls.Add(this.loadBox);
            this.physicalGroup.Controls.Add(this.cargoFactorLabel);
            this.physicalGroup.Controls.Add(this.cargoFactorBox);
            this.physicalGroup.Controls.Add(this.armorLabel);
            this.physicalGroup.Controls.Add(this.armorBox);
            this.physicalGroup.Controls.Add(this.bodyLabel);
            this.physicalGroup.Controls.Add(this.bodyBox);
            this.physicalGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalGroup.Location = new System.Drawing.Point(24, 73);
            this.physicalGroup.Name = "physicalGroup";
            this.physicalGroup.Size = new System.Drawing.Size(622, 70);
            this.physicalGroup.TabIndex = 6;
            this.physicalGroup.TabStop = false;
            this.physicalGroup.Text = "Physical";
            // 
            // loadFreeLabel
            // 
            this.loadFreeLabel.AutoSize = true;
            this.loadFreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFreeLabel.Location = new System.Drawing.Point(517, 16);
            this.loadFreeLabel.Name = "loadFreeLabel";
            this.loadFreeLabel.Size = new System.Drawing.Size(55, 13);
            this.loadFreeLabel.TabIndex = 16;
            this.loadFreeLabel.Text = "Load Free";
            // 
            // loadFreeBox
            // 
            this.loadFreeBox.Location = new System.Drawing.Point(520, 32);
            this.loadFreeBox.Name = "loadFreeBox";
            this.loadFreeBox.ReadOnly = true;
            this.loadFreeBox.Size = new System.Drawing.Size(77, 20);
            this.loadFreeBox.TabIndex = 6;
            this.loadFreeBox.TabStop = false;
            // 
            // cargoFactorFreeLabel
            // 
            this.cargoFactorFreeLabel.AutoSize = true;
            this.cargoFactorFreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoFactorFreeLabel.Location = new System.Drawing.Point(311, 16);
            this.cargoFactorFreeLabel.Name = "cargoFactorFreeLabel";
            this.cargoFactorFreeLabel.Size = new System.Drawing.Size(44, 13);
            this.cargoFactorFreeLabel.TabIndex = 14;
            this.cargoFactorFreeLabel.Text = "CF Free";
            // 
            // cargoFactorFreeBox
            // 
            this.cargoFactorFreeBox.Location = new System.Drawing.Point(314, 32);
            this.cargoFactorFreeBox.Name = "cargoFactorFreeBox";
            this.cargoFactorFreeBox.ReadOnly = true;
            this.cargoFactorFreeBox.Size = new System.Drawing.Size(77, 20);
            this.cargoFactorFreeBox.TabIndex = 4;
            this.cargoFactorFreeBox.TabStop = false;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(413, 16);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(31, 13);
            this.loadLabel.TabIndex = 12;
            this.loadLabel.Text = "Load";
            // 
            // loadBox
            // 
            this.loadBox.Location = new System.Drawing.Point(416, 32);
            this.loadBox.Name = "loadBox";
            this.loadBox.Size = new System.Drawing.Size(77, 20);
            this.loadBox.TabIndex = 5;
            this.loadBox.Validating += new System.ComponentModel.CancelEventHandler(this.loadBox_Validating);
            this.loadBox.Validated += new System.EventHandler(this.generic_Validated);
            // 
            // cargoFactorLabel
            // 
            this.cargoFactorLabel.AutoSize = true;
            this.cargoFactorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoFactorLabel.Location = new System.Drawing.Point(209, 16);
            this.cargoFactorLabel.Name = "cargoFactorLabel";
            this.cargoFactorLabel.Size = new System.Drawing.Size(68, 13);
            this.cargoFactorLabel.TabIndex = 10;
            this.cargoFactorLabel.Text = "Cargo Factor";
            // 
            // cargoFactorBox
            // 
            this.cargoFactorBox.Location = new System.Drawing.Point(212, 32);
            this.cargoFactorBox.Name = "cargoFactorBox";
            this.cargoFactorBox.Size = new System.Drawing.Size(77, 20);
            this.cargoFactorBox.TabIndex = 3;
            this.cargoFactorBox.Validating += new System.ComponentModel.CancelEventHandler(this.cargoFactorBox_Validating);
            this.cargoFactorBox.Validated += new System.EventHandler(this.generic_Validated);
            // 
            // armorLabel
            // 
            this.armorLabel.AutoSize = true;
            this.armorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorLabel.Location = new System.Drawing.Point(105, 16);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(34, 13);
            this.armorLabel.TabIndex = 8;
            this.armorLabel.Text = "Armor";
            // 
            // armorBox
            // 
            this.armorBox.Location = new System.Drawing.Point(108, 32);
            this.armorBox.Name = "armorBox";
            this.armorBox.ReadOnly = true;
            this.armorBox.Size = new System.Drawing.Size(77, 20);
            this.armorBox.TabIndex = 2;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLabel.Location = new System.Drawing.Point(3, 16);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(31, 13);
            this.bodyLabel.TabIndex = 7;
            this.bodyLabel.Text = "Body";
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(6, 32);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.ReadOnly = true;
            this.bodyBox.Size = new System.Drawing.Size(77, 20);
            this.bodyBox.TabIndex = 1;
            // 
            // ElectronicsGroup
            // 
            this.ElectronicsGroup.Controls.Add(this.sigBox);
            this.ElectronicsGroup.Controls.Add(this.ecdBox);
            this.ElectronicsGroup.Controls.Add(this.ecdLabel);
            this.ElectronicsGroup.Controls.Add(this.edBox);
            this.ElectronicsGroup.Controls.Add(this.edLabel);
            this.ElectronicsGroup.Controls.Add(this.eccmBox);
            this.ElectronicsGroup.Controls.Add(this.eccmLabel);
            this.ElectronicsGroup.Controls.Add(this.ecmBox);
            this.ElectronicsGroup.Controls.Add(this.ecmLabel);
            this.ElectronicsGroup.Controls.Add(this.sensorBox);
            this.ElectronicsGroup.Controls.Add(this.sensorLabel);
            this.ElectronicsGroup.Controls.Add(this.sigLabel);
            this.ElectronicsGroup.Controls.Add(this.pilotBox);
            this.ElectronicsGroup.Controls.Add(this.pilotLabel);
            this.ElectronicsGroup.Controls.Add(this.autoNavBox);
            this.ElectronicsGroup.Controls.Add(this.autoNavlabel);
            this.ElectronicsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectronicsGroup.Location = new System.Drawing.Point(24, 227);
            this.ElectronicsGroup.Name = "ElectronicsGroup";
            this.ElectronicsGroup.Size = new System.Drawing.Size(622, 124);
            this.ElectronicsGroup.TabIndex = 7;
            this.ElectronicsGroup.TabStop = false;
            this.ElectronicsGroup.Text = "Electronics";
            // 
            // sigBox
            // 
            this.sigBox.Location = new System.Drawing.Point(211, 33);
            this.sigBox.Name = "sigBox";
            this.sigBox.ReadOnly = true;
            this.sigBox.Size = new System.Drawing.Size(77, 20);
            this.sigBox.TabIndex = 15;
            // 
            // ecdBox
            // 
            this.ecdBox.DisplayMember = "Level";
            this.ecdBox.FormattingEnabled = true;
            this.ecdBox.Location = new System.Drawing.Point(314, 81);
            this.ecdBox.Name = "ecdBox";
            this.ecdBox.Size = new System.Drawing.Size(77, 21);
            this.ecdBox.TabIndex = 20;
            this.ecdBox.SelectionChangeCommitted += new System.EventHandler(this.ecdBox_SelectionChangeCommitted);
            // 
            // ecdLabel
            // 
            this.ecdLabel.AutoSize = true;
            this.ecdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecdLabel.Location = new System.Drawing.Point(311, 65);
            this.ecdLabel.Name = "ecdLabel";
            this.ecdLabel.Size = new System.Drawing.Size(29, 13);
            this.ecdLabel.TabIndex = 27;
            this.ecdLabel.Text = "ECD";
            // 
            // edBox
            // 
            this.edBox.DisplayMember = "Level";
            this.edBox.FormattingEnabled = true;
            this.edBox.Location = new System.Drawing.Point(211, 81);
            this.edBox.Name = "edBox";
            this.edBox.Size = new System.Drawing.Size(77, 21);
            this.edBox.TabIndex = 19;
            this.edBox.SelectionChangeCommitted += new System.EventHandler(this.edBox_SelectionChangeCommitted);
            // 
            // edLabel
            // 
            this.edLabel.AutoSize = true;
            this.edLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabel.Location = new System.Drawing.Point(208, 65);
            this.edLabel.Name = "edLabel";
            this.edLabel.Size = new System.Drawing.Size(22, 13);
            this.edLabel.TabIndex = 25;
            this.edLabel.Text = "ED";
            // 
            // eccmBox
            // 
            this.eccmBox.DisplayMember = "Level";
            this.eccmBox.FormattingEnabled = true;
            this.eccmBox.Location = new System.Drawing.Point(110, 81);
            this.eccmBox.Name = "eccmBox";
            this.eccmBox.Size = new System.Drawing.Size(77, 21);
            this.eccmBox.TabIndex = 18;
            this.eccmBox.SelectionChangeCommitted += new System.EventHandler(this.eccmBox_SelectionChangeCommitted);
            // 
            // eccmLabel
            // 
            this.eccmLabel.AutoSize = true;
            this.eccmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eccmLabel.Location = new System.Drawing.Point(107, 65);
            this.eccmLabel.Name = "eccmLabel";
            this.eccmLabel.Size = new System.Drawing.Size(37, 13);
            this.eccmLabel.TabIndex = 23;
            this.eccmLabel.Text = "ECCM";
            // 
            // ecmBox
            // 
            this.ecmBox.DisplayMember = "Level";
            this.ecmBox.FormattingEnabled = true;
            this.ecmBox.Location = new System.Drawing.Point(6, 81);
            this.ecmBox.Name = "ecmBox";
            this.ecmBox.Size = new System.Drawing.Size(77, 21);
            this.ecmBox.TabIndex = 17;
            this.ecmBox.SelectionChangeCommitted += new System.EventHandler(this.ecmBox_SelectionChangeCommitted);
            // 
            // ecmLabel
            // 
            this.ecmLabel.AutoSize = true;
            this.ecmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecmLabel.Location = new System.Drawing.Point(3, 65);
            this.ecmLabel.Name = "ecmLabel";
            this.ecmLabel.Size = new System.Drawing.Size(30, 13);
            this.ecmLabel.TabIndex = 21;
            this.ecmLabel.Text = "ECM";
            // 
            // sensorBox
            // 
            this.sensorBox.DisplayMember = "Level";
            this.sensorBox.FormattingEnabled = true;
            this.sensorBox.Location = new System.Drawing.Point(314, 32);
            this.sensorBox.Name = "sensorBox";
            this.sensorBox.Size = new System.Drawing.Size(77, 21);
            this.sensorBox.TabIndex = 16;
            this.sensorBox.SelectionChangeCommitted += new System.EventHandler(this.sensorBox_SelectionChangeCommitted);
            // 
            // sensorLabel
            // 
            this.sensorLabel.AutoSize = true;
            this.sensorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorLabel.Location = new System.Drawing.Point(311, 16);
            this.sensorLabel.Name = "sensorLabel";
            this.sensorLabel.Size = new System.Drawing.Size(40, 13);
            this.sensorLabel.TabIndex = 19;
            this.sensorLabel.Text = "Sensor";
            // 
            // sigLabel
            // 
            this.sigLabel.AutoSize = true;
            this.sigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigLabel.Location = new System.Drawing.Point(209, 16);
            this.sigLabel.Name = "sigLabel";
            this.sigLabel.Size = new System.Drawing.Size(52, 13);
            this.sigLabel.TabIndex = 17;
            this.sigLabel.Text = "Signature";
            // 
            // pilotBox
            // 
            this.pilotBox.DisplayMember = "Level";
            this.pilotBox.FormattingEnabled = true;
            this.pilotBox.Location = new System.Drawing.Point(108, 32);
            this.pilotBox.Name = "pilotBox";
            this.pilotBox.Size = new System.Drawing.Size(77, 21);
            this.pilotBox.TabIndex = 14;
            this.pilotBox.SelectionChangeCommitted += new System.EventHandler(this.pilotBox_SelectionChangeCommitted);
            // 
            // pilotLabel
            // 
            this.pilotLabel.AutoSize = true;
            this.pilotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotLabel.Location = new System.Drawing.Point(105, 16);
            this.pilotLabel.Name = "pilotLabel";
            this.pilotLabel.Size = new System.Drawing.Size(27, 13);
            this.pilotLabel.TabIndex = 15;
            this.pilotLabel.Text = "Pilot";
            // 
            // autoNavBox
            // 
            this.autoNavBox.DisplayMember = "Level";
            this.autoNavBox.FormattingEnabled = true;
            this.autoNavBox.Location = new System.Drawing.Point(6, 32);
            this.autoNavBox.Name = "autoNavBox";
            this.autoNavBox.Size = new System.Drawing.Size(77, 21);
            this.autoNavBox.TabIndex = 13;
            this.autoNavBox.SelectionChangeCommitted += new System.EventHandler(this.autoNavBox_SelectionChangeCommitted);
            // 
            // autoNavlabel
            // 
            this.autoNavlabel.AutoSize = true;
            this.autoNavlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoNavlabel.Location = new System.Drawing.Point(3, 16);
            this.autoNavlabel.Name = "autoNavlabel";
            this.autoNavlabel.Size = new System.Drawing.Size(49, 13);
            this.autoNavlabel.TabIndex = 13;
            this.autoNavlabel.Text = "AutoNav";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(570, 423);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 458);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ElectronicsGroup);
            this.Controls.Add(this.physicalGroup);
            this.Controls.Add(this.designPointLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.drivingGroup);
            this.Name = "Modification";
            this.Text = "Modification";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Modification_Paint);
            this.drivingGroup.ResumeLayout(false);
            this.drivingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.physicalGroup.ResumeLayout(false);
            this.physicalGroup.PerformLayout();
            this.ElectronicsGroup.ResumeLayout(false);
            this.ElectronicsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox drivingGroup;
        private System.Windows.Forms.Label handlingOffRoadLabel;
        private System.Windows.Forms.ComboBox handlingOffRoadBox;
        private System.Windows.Forms.Label handlingRoadLabel;
        private System.Windows.Forms.ComboBox handlingRoadBox;
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
        private System.Windows.Forms.GroupBox physicalGroup;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.TextBox loadBox;
        private System.Windows.Forms.Label cargoFactorLabel;
        private System.Windows.Forms.TextBox cargoFactorBox;
        private System.Windows.Forms.Label armorLabel;
        private System.Windows.Forms.TextBox armorBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label loadFreeLabel;
        private System.Windows.Forms.TextBox loadFreeBox;
        private System.Windows.Forms.Label cargoFactorFreeLabel;
        private System.Windows.Forms.TextBox cargoFactorFreeBox;
        private System.Windows.Forms.GroupBox ElectronicsGroup;
        private System.Windows.Forms.ComboBox autoNavBox;
        private System.Windows.Forms.Label autoNavlabel;
        private System.Windows.Forms.ComboBox eccmBox;
        private System.Windows.Forms.Label eccmLabel;
        private System.Windows.Forms.ComboBox ecmBox;
        private System.Windows.Forms.Label ecmLabel;
        private System.Windows.Forms.ComboBox sensorBox;
        private System.Windows.Forms.Label sensorLabel;
        private System.Windows.Forms.Label sigLabel;
        private System.Windows.Forms.ComboBox pilotBox;
        private System.Windows.Forms.Label pilotLabel;
        private System.Windows.Forms.ComboBox edBox;
        private System.Windows.Forms.Label edLabel;
        private System.Windows.Forms.ComboBox ecdBox;
        private System.Windows.Forms.Label ecdLabel;
        private System.Windows.Forms.TextBox sigBox;
        private System.Windows.Forms.Button saveButton;
    }
}