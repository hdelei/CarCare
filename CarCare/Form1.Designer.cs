namespace CarCare
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.execDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSNewVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSOpenVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVehicleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecentVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSNewEmptyService = new System.Windows.Forms.ToolStripMenuItem();
            this.TSNewService = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEditService = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDeleteService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.MaskedTextBox();
            this.tbNextDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPlusDate = new System.Windows.Forms.Label();
            this.lblPlusKm = new System.Windows.Forms.Label();
            this.lblMinusDate = new System.Windows.Forms.Label();
            this.lblMinusKm = new System.Windows.Forms.Label();
            this.tbExecutor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNextKm = new System.Windows.Forms.TextBox();
            this.lblMissDays = new System.Windows.Forms.Label();
            this.lblMissKm = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMakeYear = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.gbVehicle = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuBar.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.gbVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.execDate,
            this.service,
            this.executor,
            this.odometer,
            this.value,
            this.nextDate,
            this.nextKM});
            this.dgvMain.Location = new System.Drawing.Point(13, 272);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(800, 233);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMain_RowEnter);
            // 
            // execDate
            // 
            this.execDate.HeaderText = "Data";
            this.execDate.Name = "execDate";
            // 
            // service
            // 
            this.service.HeaderText = "Serviço";
            this.service.Name = "service";
            // 
            // executor
            // 
            this.executor.HeaderText = "Executor";
            this.executor.Name = "executor";
            // 
            // odometer
            // 
            this.odometer.HeaderText = "nº KM";
            this.odometer.Name = "odometer";
            // 
            // value
            // 
            this.value.HeaderText = "Valor";
            this.value.Name = "value";
            // 
            // nextDate
            // 
            this.nextDate.HeaderText = "Próx. Data ";
            this.nextDate.Name = "nextDate";
            // 
            // nextKM
            // 
            this.nextKM.HeaderText = "Próx. Km";
            this.nextKM.Name = "nextKM";
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVehicle,
            this.serviçoToolStripMenuItem,
            this.menuHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(825, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuVehicle
            // 
            this.menuVehicle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNewVehicle,
            this.TSOpenVehicle,
            this.menuVehicleEdit,
            this.menuRecentVehicle,
            this.TSAppExit});
            this.menuVehicle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuVehicle.Name = "menuVehicle";
            this.menuVehicle.ShortcutKeyDisplayString = "Alt";
            this.menuVehicle.Size = new System.Drawing.Size(68, 20);
            this.menuVehicle.Text = "Veículo";
            // 
            // TSNewVehicle
            // 
            this.TSNewVehicle.Name = "TSNewVehicle";
            this.TSNewVehicle.Size = new System.Drawing.Size(130, 22);
            this.TSNewVehicle.Text = "Novo";
            this.TSNewVehicle.Click += new System.EventHandler(this.TSNewVehicle_Click);
            // 
            // TSOpenVehicle
            // 
            this.TSOpenVehicle.Name = "TSOpenVehicle";
            this.TSOpenVehicle.Size = new System.Drawing.Size(130, 22);
            this.TSOpenVehicle.Text = "Abrir";
            this.TSOpenVehicle.Click += new System.EventHandler(this.TSOpenVehicle_Click);
            // 
            // menuVehicleEdit
            // 
            this.menuVehicleEdit.Name = "menuVehicleEdit";
            this.menuVehicleEdit.Size = new System.Drawing.Size(130, 22);
            this.menuVehicleEdit.Text = "Editar";
            this.menuVehicleEdit.Click += new System.EventHandler(this.MenuVehicleEdit_Click);
            // 
            // menuRecentVehicle
            // 
            this.menuRecentVehicle.Name = "menuRecentVehicle";
            this.menuRecentVehicle.Size = new System.Drawing.Size(130, 22);
            this.menuRecentVehicle.Text = "Recentes";
            // 
            // TSAppExit
            // 
            this.TSAppExit.Name = "TSAppExit";
            this.TSAppExit.Size = new System.Drawing.Size(130, 22);
            this.TSAppExit.Text = "Sair";
            this.TSAppExit.Click += new System.EventHandler(this.TSAppExit_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNewEmptyService,
            this.TSNewService,
            this.TSEditService,
            this.TSDeleteService});
            this.serviçoToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // TSNewEmptyService
            // 
            this.TSNewEmptyService.Name = "TSNewEmptyService";
            this.TSNewEmptyService.Size = new System.Drawing.Size(235, 22);
            this.TSNewEmptyService.Text = "Novo (vazio)";
            this.TSNewEmptyService.Click += new System.EventHandler(this.TSNewEmptyService_Click);
            // 
            // TSNewService
            // 
            this.TSNewService.Name = "TSNewService";
            this.TSNewService.Size = new System.Drawing.Size(235, 22);
            this.TSNewService.Text = "Novo (baseado no atual)";
            this.TSNewService.Click += new System.EventHandler(this.TSNewService_Click);
            // 
            // TSEditService
            // 
            this.TSEditService.Name = "TSEditService";
            this.TSEditService.Size = new System.Drawing.Size(235, 22);
            this.TSEditService.Text = "Editar";
            this.TSEditService.Click += new System.EventHandler(this.TSEditService_Click);
            // 
            // TSDeleteService
            // 
            this.TSDeleteService.Name = "TSDeleteService";
            this.TSDeleteService.Size = new System.Drawing.Size(235, 22);
            this.TSDeleteService.Text = "Excluir";
            this.TSDeleteService.Click += new System.EventHandler(this.TSDeleteService_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuHelp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(54, 20);
            this.menuHelp.Text = "Ajuda";
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(738, 545);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(7, 18);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(494, 75);
            this.tbDescription.TabIndex = 0;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(55, 97);
            this.tbDate.Mask = "00/00/0000";
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(80, 22);
            this.tbDate.TabIndex = 1;
            this.tbDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbNextDate
            // 
            this.tbNextDate.Location = new System.Drawing.Point(284, 97);
            this.tbNextDate.Mask = "00/00/0000";
            this.tbNextDate.Name = "tbNextDate";
            this.tbNextDate.ReadOnly = true;
            this.tbNextDate.Size = new System.Drawing.Size(80, 22);
            this.tbNextDate.TabIndex = 1;
            this.tbNextDate.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "data:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 14);
            this.label13.TabIndex = 2;
            this.label13.Text = "executor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "próx.verificação:";
            // 
            // lblPlusDate
            // 
            this.lblPlusDate.AutoSize = true;
            this.lblPlusDate.BackColor = System.Drawing.Color.Transparent;
            this.lblPlusDate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlusDate.Location = new System.Drawing.Point(367, 96);
            this.lblPlusDate.Name = "lblPlusDate";
            this.lblPlusDate.Size = new System.Drawing.Size(21, 23);
            this.lblPlusDate.TabIndex = 3;
            this.lblPlusDate.Text = "+";
            // 
            // lblPlusKm
            // 
            this.lblPlusKm.AutoSize = true;
            this.lblPlusKm.BackColor = System.Drawing.Color.Transparent;
            this.lblPlusKm.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusKm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlusKm.Location = new System.Drawing.Point(330, 129);
            this.lblPlusKm.Name = "lblPlusKm";
            this.lblPlusKm.Size = new System.Drawing.Size(21, 23);
            this.lblPlusKm.TabIndex = 3;
            this.lblPlusKm.Text = "+";
            // 
            // lblMinusDate
            // 
            this.lblMinusDate.AutoSize = true;
            this.lblMinusDate.BackColor = System.Drawing.Color.Transparent;
            this.lblMinusDate.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMinusDate.Location = new System.Drawing.Point(264, 95);
            this.lblMinusDate.Name = "lblMinusDate";
            this.lblMinusDate.Size = new System.Drawing.Size(18, 23);
            this.lblMinusDate.TabIndex = 3;
            this.lblMinusDate.Text = "–";
            // 
            // lblMinusKm
            // 
            this.lblMinusKm.AutoSize = true;
            this.lblMinusKm.BackColor = System.Drawing.Color.Transparent;
            this.lblMinusKm.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusKm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMinusKm.Location = new System.Drawing.Point(216, 128);
            this.lblMinusKm.Name = "lblMinusKm";
            this.lblMinusKm.Size = new System.Drawing.Size(18, 23);
            this.lblMinusKm.TabIndex = 3;
            this.lblMinusKm.Text = "–";
            // 
            // tbExecutor
            // 
            this.tbExecutor.Location = new System.Drawing.Point(7, 175);
            this.tbExecutor.Name = "tbExecutor";
            this.tbExecutor.ReadOnly = true;
            this.tbExecutor.Size = new System.Drawing.Size(494, 22);
            this.tbExecutor.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 14);
            this.label14.TabIndex = 6;
            this.label14.Text = "Km:";
            // 
            // tbKm
            // 
            this.tbKm.Location = new System.Drawing.Point(43, 129);
            this.tbKm.Name = "tbKm";
            this.tbKm.ReadOnly = true;
            this.tbKm.Size = new System.Drawing.Size(100, 22);
            this.tbKm.TabIndex = 7;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(401, 201);
            this.tbCost.Name = "tbCost";
            this.tbCost.ReadOnly = true;
            this.tbCost.Size = new System.Drawing.Size(100, 22);
            this.tbCost.TabIndex = 7;
            this.tbCost.Text = "0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(151, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 14);
            this.label15.TabIndex = 6;
            this.label15.Text = "próx.Km:";
            // 
            // tbNextKm
            // 
            this.tbNextKm.Location = new System.Drawing.Point(232, 129);
            this.tbNextKm.Name = "tbNextKm";
            this.tbNextKm.ReadOnly = true;
            this.tbNextKm.Size = new System.Drawing.Size(100, 22);
            this.tbNextKm.TabIndex = 7;
            // 
            // lblMissDays
            // 
            this.lblMissDays.AutoSize = true;
            this.lblMissDays.Location = new System.Drawing.Point(386, 102);
            this.lblMissDays.Name = "lblMissDays";
            this.lblMissDays.Size = new System.Drawing.Size(98, 14);
            this.lblMissDays.TabIndex = 8;
            this.lblMissDays.Text = "faltam 3 dias";
            // 
            // lblMissKm
            // 
            this.lblMissKm.AutoSize = true;
            this.lblMissKm.Location = new System.Drawing.Point(349, 135);
            this.lblMissKm.Name = "lblMissKm";
            this.lblMissKm.Size = new System.Drawing.Size(105, 14);
            this.lblMissKm.TabIndex = 8;
            this.lblMissKm.Text = "faltam 1000 km";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(10, 204);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(56, 14);
            this.label200.TabIndex = 9;
            this.label200.Text = "status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "custo:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(69, 204);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 14);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "sem status";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblStatus);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.label200);
            this.gbDetails.Controls.Add(this.lblMissKm);
            this.gbDetails.Controls.Add(this.lblMissDays);
            this.gbDetails.Controls.Add(this.tbNextKm);
            this.gbDetails.Controls.Add(this.label15);
            this.gbDetails.Controls.Add(this.tbCost);
            this.gbDetails.Controls.Add(this.tbKm);
            this.gbDetails.Controls.Add(this.label14);
            this.gbDetails.Controls.Add(this.tbExecutor);
            this.gbDetails.Controls.Add(this.lblMinusKm);
            this.gbDetails.Controls.Add(this.lblMinusDate);
            this.gbDetails.Controls.Add(this.lblPlusKm);
            this.gbDetails.Controls.Add(this.lblPlusDate);
            this.gbDetails.Controls.Add(this.label10);
            this.gbDetails.Controls.Add(this.label13);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.tbNextDate);
            this.gbDetails.Controls.Add(this.tbDate);
            this.gbDetails.Controls.Add(this.tbDescription);
            this.gbDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbDetails.Location = new System.Drawing.Point(306, 36);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(507, 230);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Serviço";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblModel.Location = new System.Drawing.Point(4, 35);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(70, 22);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Camaro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modelo:";
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaker.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMaker.Location = new System.Drawing.Point(4, 82);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(100, 22);
            this.lblMaker.TabIndex = 0;
            this.lblMaker.Text = "Chevrolet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(4, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fabricante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(4, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ano:";
            // 
            // lblMakeYear
            // 
            this.lblMakeYear.AutoSize = true;
            this.lblMakeYear.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeYear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMakeYear.Location = new System.Drawing.Point(4, 125);
            this.lblMakeYear.Name = "lblMakeYear";
            this.lblMakeYear.Size = new System.Drawing.Size(50, 22);
            this.lblMakeYear.TabIndex = 0;
            this.lblMakeYear.Text = "2015";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(4, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Placa:";
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPlate.Location = new System.Drawing.Point(4, 171);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(90, 22);
            this.lblPlate.TabIndex = 0;
            this.lblPlate.Text = "BGT 9925";
            // 
            // gbVehicle
            // 
            this.gbVehicle.BackColor = System.Drawing.Color.White;
            this.gbVehicle.Controls.Add(this.lblPlate);
            this.gbVehicle.Controls.Add(this.label7);
            this.gbVehicle.Controls.Add(this.lblMakeYear);
            this.gbVehicle.Controls.Add(this.label3);
            this.gbVehicle.Controls.Add(this.label5);
            this.gbVehicle.Controls.Add(this.lblMaker);
            this.gbVehicle.Controls.Add(this.label4);
            this.gbVehicle.Controls.Add(this.lblModel);
            this.gbVehicle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbVehicle.Location = new System.Drawing.Point(13, 36);
            this.gbVehicle.Name = "gbVehicle";
            this.gbVehicle.Size = new System.Drawing.Size(287, 230);
            this.gbVehicle.TabIndex = 1;
            this.gbVehicle.TabStop = false;
            this.gbVehicle.Text = "Tipo do veículo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 580);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbVehicle);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbVehicle.ResumeLayout(false);
            this.gbVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn execDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextKM;
        private System.Windows.Forms.ToolStripMenuItem menuRecentVehicle;
        private System.Windows.Forms.ToolStripMenuItem TSAppExit;
        private System.Windows.Forms.ToolStripMenuItem TSOpenVehicle;
        private System.Windows.Forms.ToolStripMenuItem menuVehicleEdit;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSNewEmptyService;
        private System.Windows.Forms.ToolStripMenuItem TSNewService;
        private System.Windows.Forms.ToolStripMenuItem TSEditService;
        private System.Windows.Forms.ToolStripMenuItem TSDeleteService;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem TSNewVehicle;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.MaskedTextBox tbDate;
        private System.Windows.Forms.MaskedTextBox tbNextDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPlusDate;
        private System.Windows.Forms.Label lblPlusKm;
        private System.Windows.Forms.Label lblMinusDate;
        private System.Windows.Forms.Label lblMinusKm;
        private System.Windows.Forms.TextBox tbExecutor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNextKm;
        private System.Windows.Forms.Label lblMissDays;
        private System.Windows.Forms.Label lblMissKm;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMakeYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.GroupBox gbVehicle;
    }
}

