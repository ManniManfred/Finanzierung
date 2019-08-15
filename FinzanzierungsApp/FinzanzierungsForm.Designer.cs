namespace FinzanzierungsApp
{
    partial class FinzanzierungsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinzanzierungsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btRemove = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.paSumme = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnschlussZins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.paSumme.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave,
            this.toolStripSeparator1,
            this.btAdd,
            this.btRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1038, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = global::FinzanzierungsApp.Properties.Resources.document_save_5;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 22);
            this.btSave.Text = "Speichern";
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdd.Image = global::FinzanzierungsApp.Properties.Resources.list_add_3;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 22);
            this.btAdd.Text = "Variante hinzufügen";
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRemove.Image = global::FinzanzierungsApp.Properties.Resources.list_remove_3;
            this.btRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(23, 22);
            this.btRemove.Text = "Variante entfernen";
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 61);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1038, 524);
            this.tabs.TabIndex = 1;
            // 
            // paSumme
            // 
            this.paSumme.Controls.Add(this.label2);
            this.paSumme.Controls.Add(this.tbAnschlussZins);
            this.paSumme.Controls.Add(this.label1);
            this.paSumme.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSumme.Location = new System.Drawing.Point(0, 25);
            this.paSumme.Name = "paSumme";
            this.paSumme.Size = new System.Drawing.Size(1038, 36);
            this.paSumme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anschluß Zins";
            // 
            // tbAnschlussZins
            // 
            this.tbAnschlussZins.Location = new System.Drawing.Point(93, 7);
            this.tbAnschlussZins.Name = "tbAnschlussZins";
            this.tbAnschlussZins.Size = new System.Drawing.Size(64, 20);
            this.tbAnschlussZins.TabIndex = 1;
            this.tbAnschlussZins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAnschlussZins.TextChanged += new System.EventHandler(this.TbAnschlussZins_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // FinzanzierungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 585);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.paSumme);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinzanzierungsForm";
            this.Text = "Finanzierung";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.paSumme.ResumeLayout(false);
            this.paSumme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.ToolStripButton btRemove;
        private System.Windows.Forms.Panel paSumme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnschlussZins;
        private System.Windows.Forms.Label label1;
    }
}

