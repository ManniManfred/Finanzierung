namespace FinzanzierungsApp
{
    partial class SonderTilgungControl
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbBetrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbBetrag
            // 
            this.tbBetrag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBetrag.Location = new System.Drawing.Point(3, 32);
            this.tbBetrag.Name = "tbBetrag";
            this.tbBetrag.Size = new System.Drawing.Size(125, 20);
            this.tbBetrag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "€";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Image = global::FinzanzierungsApp.Properties.Resources.list_add;
            this.btAdd.Location = new System.Drawing.Point(181, 32);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(30, 23);
            this.btAdd.TabIndex = 29;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Image = global::FinzanzierungsApp.Properties.Resources.list_remove_5;
            this.btRemove.Location = new System.Drawing.Point(151, 32);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(30, 23);
            this.btRemove.TabIndex = 28;
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(4, 59);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(207, 82);
            this.lbItems.TabIndex = 30;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.LbItems_SelectedIndexChanged);
            // 
            // SonderTilgungControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBetrag);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "SonderTilgungControl";
            this.Size = new System.Drawing.Size(216, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbBetrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbItems;
    }
}
