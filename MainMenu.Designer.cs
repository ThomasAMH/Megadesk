namespace MegaDesk_Montoya
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.deskImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "MegaDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quoting Solution";
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddQuoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuoteButton.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteButton.Location = new System.Drawing.Point(27, 142);
            this.AddQuoteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(361, 74);
            this.AddQuoteButton.TabIndex = 2;
            this.AddQuoteButton.Text = "Add a Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = false;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewAllQuotesButton
            // 
            this.ViewAllQuotesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViewAllQuotesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewAllQuotesButton.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllQuotesButton.Location = new System.Drawing.Point(27, 224);
            this.ViewAllQuotesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewAllQuotesButton.Name = "ViewAllQuotesButton";
            this.ViewAllQuotesButton.Size = new System.Drawing.Size(361, 74);
            this.ViewAllQuotesButton.TabIndex = 3;
            this.ViewAllQuotesButton.Text = "View All Quotes";
            this.ViewAllQuotesButton.UseVisualStyleBackColor = false;
            this.ViewAllQuotesButton.Click += new System.EventHandler(this.ViewAllQuotesButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchQuotesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchQuotesButton.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesButton.Location = new System.Drawing.Point(27, 305);
            this.SearchQuotesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(361, 74);
            this.SearchQuotesButton.TabIndex = 4;
            this.SearchQuotesButton.Text = "Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = false;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // mainExitButton
            // 
            this.mainExitButton.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExitButton.Location = new System.Drawing.Point(27, 468);
            this.mainExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(361, 46);
            this.mainExitButton.TabIndex = 6;
            this.mainExitButton.Text = "Exit Program";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // deskImage
            // 
            this.deskImage.Image = ((System.Drawing.Image)(resources.GetObject("deskImage.Image")));
            this.deskImage.Location = new System.Drawing.Point(454, 161);
            this.deskImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deskImage.Name = "deskImage";
            this.deskImage.Padding = new System.Windows.Forms.Padding(56, 62, 56, 62);
            this.deskImage.Size = new System.Drawing.Size(403, 341);
            this.deskImage.TabIndex = 7;
            this.deskImage.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.deskImage);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewAllQuotesButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MegaDesk - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.deskImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewAllQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button mainExitButton;
        private System.Windows.Forms.PictureBox deskImage;
    }
}

