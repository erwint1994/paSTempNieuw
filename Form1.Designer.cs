namespace WindowsFormsApp1
{
    partial class Temperatuur
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
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.LblOverzicht = new System.Windows.Forms.Label();
            this.BtnOpslaanMaximumTemperatuur = new System.Windows.Forms.Button();
            this.BtnOpslaanMinimumTemperatuur = new System.Windows.Forms.Button();
            this.LblMaximumTemperatuur = new System.Windows.Forms.Label();
            this.LblMinimumTemperatuur = new System.Windows.Forms.Label();
            this.TbMaximumtemperatuur = new System.Windows.Forms.TextBox();
            this.TbMinimumTemperatuur = new System.Windows.Forms.TextBox();
            this.BtnOpvragenVanTot = new System.Windows.Forms.Button();
            this.DtpTot = new System.Windows.Forms.DateTimePicker();
            this.LblTot = new System.Windows.Forms.Label();
            this.LblVan = new System.Windows.Forms.Label();
            this.DtpVan = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DgvOverzicht = new System.Windows.Forms.DataGridView();
            this.TbLocatie = new System.Windows.Forms.TextBox();
            this.LblLocatieSensor = new System.Windows.Forms.Label();
            this.BtnLocatieSensorOpslaan = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.rdbGrafiek = new System.Windows.Forms.RadioButton();
            this.rdbTabel = new System.Windows.Forms.RadioButton();
            this.rdbDatagrid = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.txbInsertTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOverzicht)).BeginInit();
            this.SuspendLayout();
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // LblOverzicht
            // 
            this.LblOverzicht.AutoSize = true;
            this.LblOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOverzicht.Location = new System.Drawing.Point(281, 102);
            this.LblOverzicht.Name = "LblOverzicht";
            this.LblOverzicht.Size = new System.Drawing.Size(94, 24);
            this.LblOverzicht.TabIndex = 126;
            this.LblOverzicht.Text = "Overzicht:";
            // 
            // BtnOpslaanMaximumTemperatuur
            // 
            this.BtnOpslaanMaximumTemperatuur.Location = new System.Drawing.Point(170, 551);
            this.BtnOpslaanMaximumTemperatuur.Name = "BtnOpslaanMaximumTemperatuur";
            this.BtnOpslaanMaximumTemperatuur.Size = new System.Drawing.Size(75, 23);
            this.BtnOpslaanMaximumTemperatuur.TabIndex = 121;
            this.BtnOpslaanMaximumTemperatuur.Text = "Opslaan";
            this.BtnOpslaanMaximumTemperatuur.UseVisualStyleBackColor = true;
            // 
            // BtnOpslaanMinimumTemperatuur
            // 
            this.BtnOpslaanMinimumTemperatuur.Location = new System.Drawing.Point(170, 505);
            this.BtnOpslaanMinimumTemperatuur.Name = "BtnOpslaanMinimumTemperatuur";
            this.BtnOpslaanMinimumTemperatuur.Size = new System.Drawing.Size(75, 23);
            this.BtnOpslaanMinimumTemperatuur.TabIndex = 120;
            this.BtnOpslaanMinimumTemperatuur.Text = "Opslaan";
            this.BtnOpslaanMinimumTemperatuur.UseVisualStyleBackColor = true;
            // 
            // LblMaximumTemperatuur
            // 
            this.LblMaximumTemperatuur.AutoSize = true;
            this.LblMaximumTemperatuur.Location = new System.Drawing.Point(19, 491);
            this.LblMaximumTemperatuur.Name = "LblMaximumTemperatuur";
            this.LblMaximumTemperatuur.Size = new System.Drawing.Size(114, 13);
            this.LblMaximumTemperatuur.TabIndex = 119;
            this.LblMaximumTemperatuur.Text = "Maximum Temperatuur";
            // 
            // LblMinimumTemperatuur
            // 
            this.LblMinimumTemperatuur.AutoSize = true;
            this.LblMinimumTemperatuur.Location = new System.Drawing.Point(18, 530);
            this.LblMinimumTemperatuur.Name = "LblMinimumTemperatuur";
            this.LblMinimumTemperatuur.Size = new System.Drawing.Size(115, 13);
            this.LblMinimumTemperatuur.TabIndex = 118;
            this.LblMinimumTemperatuur.Text = "Minumum Temperatuur";
            // 
            // TbMaximumtemperatuur
            // 
            this.TbMaximumtemperatuur.Location = new System.Drawing.Point(22, 507);
            this.TbMaximumtemperatuur.Name = "TbMaximumtemperatuur";
            this.TbMaximumtemperatuur.Size = new System.Drawing.Size(142, 20);
            this.TbMaximumtemperatuur.TabIndex = 115;
            // 
            // TbMinimumTemperatuur
            // 
            this.TbMinimumTemperatuur.Location = new System.Drawing.Point(22, 551);
            this.TbMinimumTemperatuur.Name = "TbMinimumTemperatuur";
            this.TbMinimumTemperatuur.Size = new System.Drawing.Size(142, 20);
            this.TbMinimumTemperatuur.TabIndex = 114;
            // 
            // BtnOpvragenVanTot
            // 
            this.BtnOpvragenVanTot.Location = new System.Drawing.Point(453, 86);
            this.BtnOpvragenVanTot.Name = "BtnOpvragenVanTot";
            this.BtnOpvragenVanTot.Size = new System.Drawing.Size(75, 23);
            this.BtnOpvragenVanTot.TabIndex = 93;
            this.BtnOpvragenVanTot.Text = "Opvragen";
            this.BtnOpvragenVanTot.UseVisualStyleBackColor = true;
            // 
            // DtpTot
            // 
            this.DtpTot.Location = new System.Drawing.Point(328, 60);
            this.DtpTot.Name = "DtpTot";
            this.DtpTot.Size = new System.Drawing.Size(200, 20);
            this.DtpTot.TabIndex = 92;
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Location = new System.Drawing.Point(278, 60);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(26, 13);
            this.LblTot.TabIndex = 91;
            this.LblTot.Text = "Tot:";
            // 
            // LblVan
            // 
            this.LblVan.AutoSize = true;
            this.LblVan.Location = new System.Drawing.Point(278, 37);
            this.LblVan.Name = "LblVan";
            this.LblVan.Size = new System.Drawing.Size(29, 13);
            this.LblVan.TabIndex = 90;
            this.LblVan.Text = "Van:";
            // 
            // DtpVan
            // 
            this.DtpVan.Location = new System.Drawing.Point(328, 30);
            this.DtpVan.Name = "DtpVan";
            this.DtpVan.Size = new System.Drawing.Size(200, 20);
            this.DtpVan.TabIndex = 89;
            // 
            // DgvOverzicht
            // 
            this.DgvOverzicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOverzicht.Location = new System.Drawing.Point(285, 129);
            this.DgvOverzicht.Name = "DgvOverzicht";
            this.DgvOverzicht.Size = new System.Drawing.Size(691, 445);
            this.DgvOverzicht.TabIndex = 79;
            // 
            // TbLocatie
            // 
            this.TbLocatie.Location = new System.Drawing.Point(668, 40);
            this.TbLocatie.Name = "TbLocatie";
            this.TbLocatie.Size = new System.Drawing.Size(142, 20);
            this.TbLocatie.TabIndex = 62;
            // 
            // LblLocatieSensor
            // 
            this.LblLocatieSensor.AutoSize = true;
            this.LblLocatieSensor.Location = new System.Drawing.Point(665, 24);
            this.LblLocatieSensor.Name = "LblLocatieSensor";
            this.LblLocatieSensor.Size = new System.Drawing.Size(76, 13);
            this.LblLocatieSensor.TabIndex = 61;
            this.LblLocatieSensor.Text = "Locatie sensor";
            // 
            // BtnLocatieSensorOpslaan
            // 
            this.BtnLocatieSensorOpslaan.Location = new System.Drawing.Point(668, 66);
            this.BtnLocatieSensorOpslaan.Name = "BtnLocatieSensorOpslaan";
            this.BtnLocatieSensorOpslaan.Size = new System.Drawing.Size(142, 43);
            this.BtnLocatieSensorOpslaan.TabIndex = 60;
            this.BtnLocatieSensorOpslaan.Text = "Opslaan";
            this.BtnLocatieSensorOpslaan.UseVisualStyleBackColor = true;
            this.BtnLocatieSensorOpslaan.Click += new System.EventHandler(this.BtnLocatieSensorOpslaan_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(904, 11);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(72, 56);
            this.BtnLogout.TabIndex = 130;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(40, 86);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(140, 42);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start ";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(904, 73);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(72, 49);
            this.btnSettings.TabIndex = 131;
            this.btnSettings.Text = "Instellingen";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // rdbGrafiek
            // 
            this.rdbGrafiek.AutoSize = true;
            this.rdbGrafiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGrafiek.Location = new System.Drawing.Point(73, 248);
            this.rdbGrafiek.Name = "rdbGrafiek";
            this.rdbGrafiek.Size = new System.Drawing.Size(69, 20);
            this.rdbGrafiek.TabIndex = 132;
            this.rdbGrafiek.TabStop = true;
            this.rdbGrafiek.Text = "Grafiek";
            this.rdbGrafiek.UseVisualStyleBackColor = true;
            // 
            // rdbTabel
            // 
            this.rdbTabel.AutoSize = true;
            this.rdbTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTabel.Location = new System.Drawing.Point(73, 306);
            this.rdbTabel.Name = "rdbTabel";
            this.rdbTabel.Size = new System.Drawing.Size(62, 20);
            this.rdbTabel.TabIndex = 133;
            this.rdbTabel.TabStop = true;
            this.rdbTabel.Text = "Tabel";
            this.rdbTabel.UseVisualStyleBackColor = true;
            // 
            // rdbDatagrid
            // 
            this.rdbDatagrid.AutoSize = true;
            this.rdbDatagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDatagrid.Location = new System.Drawing.Point(73, 367);
            this.rdbDatagrid.Name = "rdbDatagrid";
            this.rdbDatagrid.Size = new System.Drawing.Size(78, 20);
            this.rdbDatagrid.TabIndex = 134;
            this.rdbDatagrid.TabStop = true;
            this.rdbDatagrid.Text = "Datagrid";
            this.rdbDatagrid.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(36, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 20);
            this.lblTime.TabIndex = 139;
            this.lblTime.Text = "Invoeren Tijd";
            // 
            // txbInsertTime
            // 
            this.txbInsertTime.Location = new System.Drawing.Point(142, 57);
            this.txbInsertTime.Name = "txbInsertTime";
            this.txbInsertTime.Size = new System.Drawing.Size(38, 20);
            this.txbInsertTime.TabIndex = 138;
            // 
            // Temperatuur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 596);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txbInsertTime);
            this.Controls.Add(this.rdbDatagrid);
            this.Controls.Add(this.rdbTabel);
            this.Controls.Add(this.rdbGrafiek);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblOverzicht);
            this.Controls.Add(this.BtnOpslaanMaximumTemperatuur);
            this.Controls.Add(this.BtnOpslaanMinimumTemperatuur);
            this.Controls.Add(this.LblMaximumTemperatuur);
            this.Controls.Add(this.LblMinimumTemperatuur);
            this.Controls.Add(this.TbMaximumtemperatuur);
            this.Controls.Add(this.TbMinimumTemperatuur);
            this.Controls.Add(this.BtnOpvragenVanTot);
            this.Controls.Add(this.DtpTot);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.LblVan);
            this.Controls.Add(this.DtpVan);
            this.Controls.Add(this.DgvOverzicht);
            this.Controls.Add(this.TbLocatie);
            this.Controls.Add(this.LblLocatieSensor);
            this.Controls.Add(this.BtnLocatieSensorOpslaan);
            this.Controls.Add(this.BtnStart);
            this.Name = "Temperatuur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Temperatuur_FormClosed);
            this.Load += new System.EventHandler(this.Temperatuur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOverzicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.Label LblOverzicht;
        private System.Windows.Forms.Button BtnOpslaanMaximumTemperatuur;
        private System.Windows.Forms.Button BtnOpslaanMinimumTemperatuur;
        private System.Windows.Forms.Label LblMaximumTemperatuur;
        private System.Windows.Forms.Label LblMinimumTemperatuur;
        private System.Windows.Forms.TextBox TbMaximumtemperatuur;
        private System.Windows.Forms.TextBox TbMinimumTemperatuur;
        private System.Windows.Forms.Button BtnOpvragenVanTot;
        private System.Windows.Forms.DateTimePicker DtpTot;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label LblVan;
        private System.Windows.Forms.DateTimePicker DtpVan;
        private System.Windows.Forms.DataGridView DgvOverzicht;
        private System.Windows.Forms.TextBox TbLocatie;
        private System.Windows.Forms.Label LblLocatieSensor;
        private System.Windows.Forms.Button BtnLocatieSensorOpslaan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.RadioButton rdbDatagrid;
        private System.Windows.Forms.RadioButton rdbTabel;
        private System.Windows.Forms.RadioButton rdbGrafiek;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txbInsertTime;
    }
}

