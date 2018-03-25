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
            this.gbVehicle = new System.Windows.Forms.GroupBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMakeYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVehicleOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVehicleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecentVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novovazioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novobaseadoNoAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusHeader = new System.Windows.Forms.Label();
            this.lblMissKm = new System.Windows.Forms.Label();
            this.lblMissDays = new System.Windows.Forms.Label();
            this.tbNextKm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbExecutor = new System.Windows.Forms.TextBox();
            this.lblMinusKm = new System.Windows.Forms.Label();
            this.lblMinusDate = new System.Windows.Forms.Label();
            this.lblPlusKm = new System.Windows.Forms.Label();
            this.lblPlusDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNextDate = new System.Windows.Forms.MaskedTextBox();
            this.tbDate = new System.Windows.Forms.MaskedTextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gbVehicle.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.gbDetails.SuspendLayout();
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
            this.dgvMain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_RowEnter);
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
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPlate.Location = new System.Drawing.Point(97, 93);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(63, 14);
            this.lblPlate.TabIndex = 0;
            this.lblPlate.Text = "BGT 9925";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Placa:";
            // 
            // lblMakeYear
            // 
            this.lblMakeYear.AutoSize = true;
            this.lblMakeYear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMakeYear.Location = new System.Drawing.Point(97, 69);
            this.lblMakeYear.Name = "lblMakeYear";
            this.lblMakeYear.Size = new System.Drawing.Size(35, 14);
            this.lblMakeYear.TabIndex = 0;
            this.lblMakeYear.Text = "2015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fabricante:";
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMaker.Location = new System.Drawing.Point(97, 45);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(70, 14);
            this.lblMaker.TabIndex = 0;
            this.lblMaker.Text = "Chevrolet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modelo:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblModel.Location = new System.Drawing.Point(97, 21);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 14);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Camaro";
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
            this.novoToolStripMenuItem,
            this.menuVehicleOpen,
            this.menuVehicleEdit,
            this.menuRecentVehicle,
            this.menuExit});
            this.menuVehicle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVehicle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuVehicle.Name = "menuVehicle";
            this.menuVehicle.ShortcutKeyDisplayString = "Alt";
            this.menuVehicle.Size = new System.Drawing.Size(68, 20);
            this.menuVehicle.Text = "Veículo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // menuVehicleOpen
            // 
            this.menuVehicleOpen.Name = "menuVehicleOpen";
            this.menuVehicleOpen.Size = new System.Drawing.Size(130, 22);
            this.menuVehicleOpen.Text = "Abrir";
            // 
            // menuVehicleEdit
            // 
            this.menuVehicleEdit.Name = "menuVehicleEdit";
            this.menuVehicleEdit.Size = new System.Drawing.Size(130, 22);
            this.menuVehicleEdit.Text = "Editar";
            // 
            // menuRecentVehicle
            // 
            this.menuRecentVehicle.Name = "menuRecentVehicle";
            this.menuRecentVehicle.Size = new System.Drawing.Size(130, 22);
            this.menuRecentVehicle.Text = "Recentes";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(130, 22);
            this.menuExit.Text = "Sair";
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novovazioToolStripMenuItem,
            this.novobaseadoNoAtualToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.serviçoToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // novovazioToolStripMenuItem
            // 
            this.novovazioToolStripMenuItem.Name = "novovazioToolStripMenuItem";
            this.novovazioToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.novovazioToolStripMenuItem.Text = "Novo (vazio)";
            // 
            // novobaseadoNoAtualToolStripMenuItem
            // 
            this.novobaseadoNoAtualToolStripMenuItem.Name = "novobaseadoNoAtualToolStripMenuItem";
            this.novobaseadoNoAtualToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.novobaseadoNoAtualToolStripMenuItem.Text = "Novo (baseado no atual)";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // menuHelp
            // 
            this.menuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuHelp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(54, 20);
            this.menuHelp.Text = "Ajuda";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblStatus);
            this.gbDetails.Controls.Add(this.lblStatusHeader);
            this.gbDetails.Controls.Add(this.lblMissKm);
            this.gbDetails.Controls.Add(this.lblMissDays);
            this.gbDetails.Controls.Add(this.tbNextKm);
            this.gbDetails.Controls.Add(this.label15);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(69, 204);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 14);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "sem status";
            // 
            // lblStatusHeader
            // 
            this.lblStatusHeader.AutoSize = true;
            this.lblStatusHeader.Location = new System.Drawing.Point(10, 204);
            this.lblStatusHeader.Name = "lblStatusHeader";
            this.lblStatusHeader.Size = new System.Drawing.Size(56, 14);
            this.lblStatusHeader.TabIndex = 9;
            this.lblStatusHeader.Text = "status:";
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
            // lblMissDays
            // 
            this.lblMissDays.AutoSize = true;
            this.lblMissDays.Location = new System.Drawing.Point(386, 102);
            this.lblMissDays.Name = "lblMissDays";
            this.lblMissDays.Size = new System.Drawing.Size(98, 14);
            this.lblMissDays.TabIndex = 8;
            this.lblMissDays.Text = "faltam 3 dias";
            // 
            // tbNextKm
            // 
            this.tbNextKm.Location = new System.Drawing.Point(232, 129);
            this.tbNextKm.Name = "tbNextKm";
            this.tbNextKm.Size = new System.Drawing.Size(100, 22);
            this.tbNextKm.TabIndex = 7;
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
            // tbKm
            // 
            this.tbKm.Location = new System.Drawing.Point(43, 129);
            this.tbKm.Name = "tbKm";
            this.tbKm.Size = new System.Drawing.Size(100, 22);
            this.tbKm.TabIndex = 7;
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
            // tbExecutor
            // 
            this.tbExecutor.Location = new System.Drawing.Point(7, 175);
            this.tbExecutor.Name = "tbExecutor";
            this.tbExecutor.Size = new System.Drawing.Size(494, 22);
            this.tbExecutor.TabIndex = 4;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "próx.verificação:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "data:";
            // 
            // tbNextDate
            // 
            this.tbNextDate.Location = new System.Drawing.Point(284, 97);
            this.tbNextDate.Mask = "00/00/0000";
            this.tbNextDate.Name = "tbNextDate";
            this.tbNextDate.Size = new System.Drawing.Size(80, 22);
            this.tbNextDate.TabIndex = 1;
            this.tbNextDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(55, 97);
            this.tbDate.Mask = "00/00/0000";
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(80, 22);
            this.tbDate.TabIndex = 1;
            this.tbDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(7, 18);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(494, 75);
            this.tbDescription.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 580);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbVehicle);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gbVehicle.ResumeLayout(false);
            this.gbVehicle.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox gbVehicle;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn execDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextKM;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.ToolStripMenuItem menuRecentVehicle;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuVehicleOpen;
        private System.Windows.Forms.Label lblMakeYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ToolStripMenuItem menuVehicleEdit;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.MaskedTextBox tbDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMinusDate;
        private System.Windows.Forms.Label lblPlusDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox tbNextDate;
        private System.Windows.Forms.TextBox tbExecutor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNextKm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMissKm;
        private System.Windows.Forms.Label lblMissDays;
        private System.Windows.Forms.Label lblMinusKm;
        private System.Windows.Forms.Label lblPlusKm;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novovazioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novobaseadoNoAtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusHeader;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    }
}

