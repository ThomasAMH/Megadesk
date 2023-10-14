namespace MegaDesk_Montoya
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.ReturnButton = new System.Windows.Forms.Button();
            this.dataGridViewQuotes = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrderDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDrawerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.AutoSize = true;
            this.ReturnButton.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(711, 500);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(156, 49);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Back To Home";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // dataGridViewQuotes
            // 
            this.dataGridViewQuotes.AllowUserToAddRows = false;
            this.dataGridViewQuotes.AllowUserToDeleteRows = false;
            this.dataGridViewQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.invoiceDate,
            this.quoteAmount,
            this.rushOrderDays,
            this.deskDepth,
            this.deskWidth,
            this.deskDrawerCount,
            this.deskMaterial});
            this.dataGridViewQuotes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuotes.Name = "dataGridViewQuotes";
            this.dataGridViewQuotes.ReadOnly = true;
            this.dataGridViewQuotes.RowHeadersWidth = 51;
            this.dataGridViewQuotes.RowTemplate.Height = 28;
            this.dataGridViewQuotes.Size = new System.Drawing.Size(874, 466);
            this.dataGridViewQuotes.TabIndex = 4;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "CustomerName";
            this.customerName.HeaderText = "Customer";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // invoiceDate
            // 
            this.invoiceDate.HeaderText = "Invoice Date";
            this.invoiceDate.MinimumWidth = 6;
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.ReadOnly = true;
            // 
            // quoteAmount
            // 
            this.quoteAmount.HeaderText = "Total Amount";
            this.quoteAmount.MinimumWidth = 6;
            this.quoteAmount.Name = "quoteAmount";
            this.quoteAmount.ReadOnly = true;
            // 
            // rushOrderDays
            // 
            this.rushOrderDays.HeaderText = "Rush Order";
            this.rushOrderDays.MinimumWidth = 6;
            this.rushOrderDays.Name = "rushOrderDays";
            this.rushOrderDays.ReadOnly = true;
            // 
            // deskDepth
            // 
            this.deskDepth.HeaderText = "Desk Depth";
            this.deskDepth.MinimumWidth = 6;
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.ReadOnly = true;
            // 
            // deskWidth
            // 
            this.deskWidth.HeaderText = "Desk Width";
            this.deskWidth.MinimumWidth = 6;
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.ReadOnly = true;
            // 
            // deskDrawerCount
            // 
            this.deskDrawerCount.HeaderText = "Drawer Count";
            this.deskDrawerCount.MinimumWidth = 6;
            this.deskDrawerCount.Name = "deskDrawerCount";
            this.deskDrawerCount.ReadOnly = true;
            // 
            // deskMaterial
            // 
            this.deskMaterial.HeaderText = "Desk Material";
            this.deskMaterial.MinimumWidth = 6;
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.ReadOnly = true;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dataGridViewQuotes);
            this.Controls.Add(this.ReturnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.DataGridView dataGridViewQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrderDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDrawerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskMaterial;
    }
}