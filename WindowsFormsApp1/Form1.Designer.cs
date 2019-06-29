namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.blatt1 = new WindowsFormsApp1.Blatt();
            this.blatt2 = new WindowsFormsApp1.Blatt();
            this.SuspendLayout();
            // 
            // blatt1
            // 
            this.blatt1.Location = new System.Drawing.Point(12, 12);
            this.blatt1.Monate = 0;
            this.blatt1.Name = "blatt1";
            this.blatt1.RestSchuld = 0D;
            this.blatt1.Size = new System.Drawing.Size(238, 177);
            this.blatt1.TabIndex = 0;
            // 
            // blatt2
            // 
            this.blatt2.Location = new System.Drawing.Point(256, 12);
            this.blatt2.Monate = 0;
            this.blatt2.Name = "blatt2";
            this.blatt2.RestSchuld = 0D;
            this.blatt2.Size = new System.Drawing.Size(238, 177);
            this.blatt2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 268);
            this.Controls.Add(this.blatt2);
            this.Controls.Add(this.blatt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Blatt blatt1;
        private Blatt blatt2;
    }
}

