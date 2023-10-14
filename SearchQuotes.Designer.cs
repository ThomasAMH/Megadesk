namespace MegaDesk_Montoya
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.ReturnButton = new System.Windows.Forms.Button();
            this.materialSearchCB = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(688, 498);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(198, 49);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Back To Home";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // materialSearchCB
            // 
            this.materialSearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialSearchCB.FormattingEnabled = true;
            this.materialSearchCB.Location = new System.Drawing.Point(494, 146);
            this.materialSearchCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialSearchCB.Name = "materialSearchCB";
            this.materialSearchCB.Size = new System.Drawing.Size(186, 28);
            this.materialSearchCB.TabIndex = 2;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(220, 143);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(226, 29);
            this.materialLabel.TabIndex = 3;
            this.materialLabel.Text = "Search By &Material: ";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(375, 300);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 62);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.materialSearchCB);
            this.Controls.Add(this.ReturnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.Text = "Search for a Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox materialSearchCB;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Button searchButton;
    }
}