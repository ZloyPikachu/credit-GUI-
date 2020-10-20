namespace v10
{
    partial class paymentform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditsysDataSet = new v10.creditsysDataSet();
            this.repaymentTableAdapter = new v10.creditsysDataSetTableAdapters.repaymentTableAdapter();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsysDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.period,
            this.payment,
            this.credit,
            this.percent,
            this.remainder,
            this.fullname,
            this.contractID});
            this.dataGridView1.Location = new System.Drawing.Point(21, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // repaymentBindingSource
            // 
            this.repaymentBindingSource.DataMember = "repayment";
            this.repaymentBindingSource.DataSource = this.creditsysDataSet;
            // 
            // creditsysDataSet
            // 
            this.creditsysDataSet.DataSetName = "creditsysDataSet";
            this.creditsysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repaymentTableAdapter
            // 
            this.repaymentTableAdapter.ClearBeforeFill = true;
            // 
            // num
            // 
            this.num.HeaderText = "№";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 50;
            // 
            // period
            // 
            this.period.HeaderText = "период";
            this.period.MinimumWidth = 6;
            this.period.Name = "period";
            this.period.ReadOnly = true;
            this.period.Width = 90;
            // 
            // payment
            // 
            this.payment.HeaderText = "платеж";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            this.payment.Width = 90;
            // 
            // credit
            // 
            this.credit.HeaderText = "кредит";
            this.credit.MinimumWidth = 6;
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.Width = 90;
            // 
            // percent
            // 
            this.percent.HeaderText = "процент";
            this.percent.MinimumWidth = 6;
            this.percent.Name = "percent";
            this.percent.ReadOnly = true;
            this.percent.Width = 90;
            // 
            // remainder
            // 
            this.remainder.HeaderText = "остаток";
            this.remainder.MinimumWidth = 6;
            this.remainder.Name = "remainder";
            this.remainder.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "ФИО";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 140;
            // 
            // contractID
            // 
            this.contractID.HeaderText = "ID";
            this.contractID.MinimumWidth = 6;
            this.contractID.Name = "contractID";
            this.contractID.ReadOnly = true;
            this.contractID.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица платежей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact №";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(595, 27);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(111, 22);
            this.id.TabIndex = 3;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(712, 27);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(951, 30);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(93, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Обновить";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // paymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 528);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "paymentform";
            this.Text = "Платежи";
            this.Load += new System.EventHandler(this.payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsysDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private creditsysDataSet creditsysDataSet;
        private System.Windows.Forms.BindingSource repaymentBindingSource;
        private creditsysDataSetTableAdapters.repaymentTableAdapter repaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn period;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainder;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button refresh;
    }
}