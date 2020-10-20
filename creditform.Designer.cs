namespace v10
{
    partial class creditform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.repay = new System.Windows.Forms.Button();
            this.contractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPASSPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрактыToolStripMenuItem,
            this.платежыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1528, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.обновитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.закрытьToolStripMenuItem});
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.контрактыToolStripMenuItem.Text = "Контракты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Удалить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "_______________";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // платежыToolStripMenuItem
            // 
            this.платежыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem,
            this.обновитьToolStripMenuItem1});
            this.платежыToolStripMenuItem.Name = "платежыToolStripMenuItem";
            this.платежыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.платежыToolStripMenuItem.Text = "Платежы";
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.показатьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractID,
            this.amount,
            this.percentContract,
            this.monthCount,
            this.dateStart,
            this.clNAME,
            this.clSURNAME,
            this.clLASTNAME,
            this.clPASSPORT,
            this.clTEL,
            this.clADDRESS});
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1504, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(12, 51);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(89, 23);
            this.insert.TabIndex = 2;
            this.insert.Text = "Добавить";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(107, 51);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(199, 51);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(280, 51);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(89, 23);
            this.refreshbutton.TabIndex = 5;
            this.refreshbutton.Text = "Обновить";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // repay
            // 
            this.repay.Location = new System.Drawing.Point(375, 51);
            this.repay.Name = "repay";
            this.repay.Size = new System.Drawing.Size(105, 23);
            this.repay.TabIndex = 8;
            this.repay.Text = "Вычислить";
            this.repay.UseVisualStyleBackColor = true;
            this.repay.Click += new System.EventHandler(this.repay_Click);
            // 
            // contractID
            // 
            this.contractID.HeaderText = "ID";
            this.contractID.MinimumWidth = 6;
            this.contractID.Name = "contractID";
            this.contractID.ReadOnly = true;
            this.contractID.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Сумма кредита";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 125;
            // 
            // percentContract
            // 
            this.percentContract.HeaderText = "Ставка (год %)";
            this.percentContract.MinimumWidth = 6;
            this.percentContract.Name = "percentContract";
            this.percentContract.ReadOnly = true;
            this.percentContract.Width = 90;
            // 
            // monthCount
            // 
            this.monthCount.HeaderText = "Срок (мес)";
            this.monthCount.MinimumWidth = 6;
            this.monthCount.Name = "monthCount";
            this.monthCount.ReadOnly = true;
            this.monthCount.Width = 125;
            // 
            // dateStart
            // 
            this.dateStart.HeaderText = "Дата получения";
            this.dateStart.MinimumWidth = 6;
            this.dateStart.Name = "dateStart";
            this.dateStart.ReadOnly = true;
            this.dateStart.Width = 125;
            // 
            // clNAME
            // 
            this.clNAME.HeaderText = "Имя";
            this.clNAME.MinimumWidth = 6;
            this.clNAME.Name = "clNAME";
            this.clNAME.ReadOnly = true;
            this.clNAME.Width = 125;
            // 
            // clSURNAME
            // 
            this.clSURNAME.HeaderText = "Фамилия";
            this.clSURNAME.MinimumWidth = 6;
            this.clSURNAME.Name = "clSURNAME";
            this.clSURNAME.ReadOnly = true;
            this.clSURNAME.Width = 125;
            // 
            // clLASTNAME
            // 
            this.clLASTNAME.HeaderText = "Отчество";
            this.clLASTNAME.MinimumWidth = 6;
            this.clLASTNAME.Name = "clLASTNAME";
            this.clLASTNAME.ReadOnly = true;
            this.clLASTNAME.Width = 125;
            // 
            // clPASSPORT
            // 
            this.clPASSPORT.HeaderText = "Паспорт";
            this.clPASSPORT.MinimumWidth = 6;
            this.clPASSPORT.Name = "clPASSPORT";
            this.clPASSPORT.ReadOnly = true;
            this.clPASSPORT.Width = 125;
            // 
            // clTEL
            // 
            this.clTEL.HeaderText = "Телефон";
            this.clTEL.MinimumWidth = 6;
            this.clTEL.Name = "clTEL";
            this.clTEL.ReadOnly = true;
            this.clTEL.Width = 125;
            // 
            // clADDRESS
            // 
            this.clADDRESS.HeaderText = "Адрес";
            this.clADDRESS.MinimumWidth = 6;
            this.clADDRESS.Name = "clADDRESS";
            this.clADDRESS.ReadOnly = true;
            this.clADDRESS.Width = 125;
            // 
            // creditform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 450);
            this.Controls.Add(this.repay);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "creditform";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem контрактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button repay;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPASSPORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clADDRESS;
    }
}

