namespace FinzanzierungsApp
{
    partial class FinazierungControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAddBaustein = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddBaustein
            // 
            this.btAddBaustein.Location = new System.Drawing.Point(183, 12);
            this.btAddBaustein.Name = "btAddBaustein";
            this.btAddBaustein.Size = new System.Drawing.Size(35, 23);
            this.btAddBaustein.TabIndex = 0;
            this.btAddBaustein.Text = "+";
            this.btAddBaustein.UseVisualStyleBackColor = true;
            this.btAddBaustein.Click += new System.EventHandler(this.BtAddBaustein_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 44);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(435, 308);
            this.flowPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.btAddBaustein);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 44);
            this.panel1.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Location = new System.Drawing.Point(14, 15);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(151, 20);
            this.tbTitle.TabIndex = 24;
            this.tbTitle.TextChanged += new System.EventHandler(this.TbTitle_TextChanged);
            // 
            // FinazierungControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FinazierungControl";
            this.Size = new System.Drawing.Size(435, 352);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddBaustein;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTitle;
    }
}
