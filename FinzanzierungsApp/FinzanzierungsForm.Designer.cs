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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinzanzierungsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btRemove = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.paSumme = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnschlussZins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZinsen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGesamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuszahlung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.paSumme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1038, 334);
            this.tabs.TabIndex = 1;
            // 
            // paSumme
            // 
            this.paSumme.Controls.Add(this.label2);
            this.paSumme.Controls.Add(this.tbAnschlussZins);
            this.paSumme.Controls.Add(this.label1);
            this.paSumme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paSumme.Location = new System.Drawing.Point(3, 157);
            this.paSumme.Name = "paSumme";
            this.paSumme.Size = new System.Drawing.Size(1024, 36);
            this.paSumme.TabIndex = 2;
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
            // tbAnschlussZins
            // 
            this.tbAnschlussZins.Location = new System.Drawing.Point(93, 7);
            this.tbAnschlussZins.Name = "tbAnschlussZins";
            this.tbAnschlussZins.Size = new System.Drawing.Size(64, 20);
            this.tbAnschlussZins.TabIndex = 1;
            this.tbAnschlussZins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAnschlussZins.TextChanged += new System.EventHandler(this.TbAnschlussZins_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colZinsen,
            this.colGesamt,
            this.colAuszahlung});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 154);
            this.dataGridView1.TabIndex = 3;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Title";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colZinsen
            // 
            this.colZinsen.DataPropertyName = "GezahlteZinsen";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C";
            this.colZinsen.DefaultCellStyle = dataGridViewCellStyle1;
            this.colZinsen.HeaderText = "Zinsen";
            this.colZinsen.Name = "colZinsen";
            this.colZinsen.ReadOnly = true;
            // 
            // colGesamt
            // 
            this.colGesamt.DataPropertyName = "Gesamt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C";
            this.colGesamt.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGesamt.HeaderText = "Gesamt";
            this.colGesamt.Name = "colGesamt";
            this.colGesamt.ReadOnly = true;
            // 
            // colAuszahlung
            // 
            this.colAuszahlung.DataPropertyName = "Auszahlung";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C";
            this.colAuszahlung.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAuszahlung.HeaderText = "Auszahlung";
            this.colAuszahlung.Name = "colAuszahlung";
            this.colAuszahlung.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabs);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 560);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 222);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.paSumme);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zusammenfassung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Charts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FinzanzierungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 585);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinzanzierungsForm";
            this.Text = "Finanzierung";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.paSumme.ResumeLayout(false);
            this.paSumme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZinsen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGesamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuszahlung;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

