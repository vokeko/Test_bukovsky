namespace Test_bukovsky
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.fromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(12, 22);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(156, 28);
            this.testConnectionButton.TabIndex = 0;
            this.testConnectionButton.Text = "Otestovat připojení";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 67);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(156, 27);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Přečíst záznamy";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(12, 112);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(156, 27);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Přidat záznamy";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(196, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(156, 27);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Hledat záznamy";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fromFileButton
            // 
            this.fromFileButton.Location = new System.Drawing.Point(196, 67);
            this.fromFileButton.Name = "fromFileButton";
            this.fromFileButton.Size = new System.Drawing.Size(156, 27);
            this.fromFileButton.TabIndex = 4;
            this.fromFileButton.Text = "Vložit ze souboru";
            this.fromFileButton.UseVisualStyleBackColor = true;
            this.fromFileButton.Click += new System.EventHandler(this.fromFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 179);
            this.Controls.Add(this.fromFileButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.testConnectionButton);
            this.Name = "Form1";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button fromFileButton;
    }
}

