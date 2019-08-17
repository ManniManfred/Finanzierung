namespace FinzanzierungsApp
{
    partial class VarianteControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGesamt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbZinssatz = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGezahlteZinsen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDauer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.tbUnsicherheit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddBaustein
            // 
            this.btAddBaustein.Location = new System.Drawing.Point(610, 13);
            this.btAddBaustein.Name = "btAddBaustein";
            this.btAddBaustein.Size = new System.Drawing.Size(93, 23);
            this.btAddBaustein.TabIndex = 0;
            this.btAddBaustein.Text = "Neuer Baustein";
            this.btAddBaustein.UseVisualStyleBackColor = true;
            this.btAddBaustein.Click += new System.EventHandler(this.BtAddBaustein_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 161);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(717, 420);
            this.flowPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbUnsicherheit);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btAddBaustein);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 161);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGesamt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbZinssatz);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbStart);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbGezahlteZinsen);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDauer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 140);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summe";
            // 
            // tbGesamt
            // 
            this.tbGesamt.Location = new System.Drawing.Point(83, 78);
            this.tbGesamt.Name = "tbGesamt";
            this.tbGesamt.ReadOnly = true;
            this.tbGesamt.Size = new System.Drawing.Size(152, 20);
            this.tbGesamt.TabIndex = 43;
            this.tbGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Gesamt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "€";
            // 
            // tbZinssatz
            // 
            this.tbZinssatz.Location = new System.Drawing.Point(314, 103);
            this.tbZinssatz.Name = "tbZinssatz";
            this.tbZinssatz.ReadOnly = true;
            this.tbZinssatz.Size = new System.Drawing.Size(152, 20);
            this.tbZinssatz.TabIndex = 41;
            this.tbZinssatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Zinssatz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "%";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(83, 51);
            this.tbStart.Name = "tbStart";
            this.tbStart.ReadOnly = true;
            this.tbStart.Size = new System.Drawing.Size(152, 20);
            this.tbStart.TabIndex = 25;
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(83, 25);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(151, 20);
            this.tbTitle.TabIndex = 24;
            this.tbTitle.TextChanged += new System.EventHandler(this.TbTitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Titel";
            // 
            // tbGezahlteZinsen
            // 
            this.tbGezahlteZinsen.Location = new System.Drawing.Point(83, 104);
            this.tbGezahlteZinsen.Name = "tbGezahlteZinsen";
            this.tbGezahlteZinsen.ReadOnly = true;
            this.tbGezahlteZinsen.Size = new System.Drawing.Size(152, 20);
            this.tbGezahlteZinsen.TabIndex = 26;
            this.tbGezahlteZinsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Dauer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Auszahlung";
            // 
            // tbDauer
            // 
            this.tbDauer.Location = new System.Drawing.Point(314, 77);
            this.tbDauer.Name = "tbDauer";
            this.tbDauer.ReadOnly = true;
            this.tbDauer.Size = new System.Drawing.Size(152, 20);
            this.tbDauer.TabIndex = 34;
            this.tbDauer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Zinsen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "€";
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(314, 51);
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.Size = new System.Drawing.Size(152, 20);
            this.tbRate.TabIndex = 29;
            this.tbRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rate";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(511, 13);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(93, 23);
            this.btRefresh.TabIndex = 38;
            this.btRefresh.Text = "Aktualisieren";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // tbUnsicherheit
            // 
            this.tbUnsicherheit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUnsicherheit.Location = new System.Drawing.Point(511, 42);
            this.tbUnsicherheit.Multiline = true;
            this.tbUnsicherheit.Name = "tbUnsicherheit";
            this.tbUnsicherheit.ReadOnly = true;
            this.tbUnsicherheit.Size = new System.Drawing.Size(192, 111);
            this.tbUnsicherheit.TabIndex = 46;
            // 
            // FinazierungControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FinazierungControl";
            this.Size = new System.Drawing.Size(717, 581);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddBaustein;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDauer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGezahlteZinsen;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbZinssatz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGesamt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUnsicherheit;
    }
}
