namespace FinzanzierungsApp
{
    partial class BausteinControl
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
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbZinsen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDauer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGesamt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRestSchuld = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLaufzeit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbGezahlteZinsen = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.tbEnde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbStart
            // 
            this.tbStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStart.Location = new System.Drawing.Point(79, 41);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(187, 20);
            this.tbStart.TabIndex = 0;
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbStart.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // tbZinsen
            // 
            this.tbZinsen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZinsen.Location = new System.Drawing.Point(79, 67);
            this.tbZinsen.Name = "tbZinsen";
            this.tbZinsen.Size = new System.Drawing.Size(187, 20);
            this.tbZinsen.TabIndex = 1;
            this.tbZinsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbZinsen.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auszahlung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zinsen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate";
            // 
            // tbRate
            // 
            this.tbRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRate.Location = new System.Drawing.Point(79, 93);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(187, 20);
            this.tbRate.TabIndex = 4;
            this.tbRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRate.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dauer";
            // 
            // tbDauer
            // 
            this.tbDauer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDauer.Location = new System.Drawing.Point(79, 262);
            this.tbDauer.Name = "tbDauer";
            this.tbDauer.ReadOnly = true;
            this.tbDauer.Size = new System.Drawing.Size(187, 20);
            this.tbDauer.TabIndex = 6;
            this.tbDauer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gesamtkosten";
            // 
            // tbGesamt
            // 
            this.tbGesamt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGesamt.Location = new System.Drawing.Point(79, 181);
            this.tbGesamt.Name = "tbGesamt";
            this.tbGesamt.ReadOnly = true;
            this.tbGesamt.Size = new System.Drawing.Size(187, 20);
            this.tbGesamt.TabIndex = 8;
            this.tbGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "€";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "€";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "€";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Restschuld";
            // 
            // tbRestSchuld
            // 
            this.tbRestSchuld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRestSchuld.Location = new System.Drawing.Point(79, 236);
            this.tbRestSchuld.Name = "tbRestSchuld";
            this.tbRestSchuld.ReadOnly = true;
            this.tbRestSchuld.Size = new System.Drawing.Size(187, 20);
            this.tbRestSchuld.TabIndex = 14;
            this.tbRestSchuld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Laufzeit";
            // 
            // tbLaufzeit
            // 
            this.tbLaufzeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLaufzeit.Location = new System.Drawing.Point(79, 119);
            this.tbLaufzeit.Name = "tbLaufzeit";
            this.tbLaufzeit.Size = new System.Drawing.Size(187, 20);
            this.tbLaufzeit.TabIndex = 17;
            this.tbLaufzeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLaufzeit.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Jahre";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "€";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Zinsen";
            // 
            // tbGezahlteZinsen
            // 
            this.tbGezahlteZinsen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGezahlteZinsen.Location = new System.Drawing.Point(79, 207);
            this.tbGezahlteZinsen.Name = "tbGezahlteZinsen";
            this.tbGezahlteZinsen.ReadOnly = true;
            this.tbGezahlteZinsen.Size = new System.Drawing.Size(187, 20);
            this.tbGezahlteZinsen.TabIndex = 20;
            this.tbGezahlteZinsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Location = new System.Drawing.Point(16, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(151, 20);
            this.tbTitle.TabIndex = 23;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(187, 3);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(30, 23);
            this.btRemove.TabIndex = 24;
            this.btRemove.Text = "-";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Start";
            // 
            // startDate
            // 
            this.startDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDate.Location = new System.Drawing.Point(79, 148);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(187, 20);
            this.startDate.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Ende";
            // 
            // tbEnde
            // 
            this.tbEnde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnde.Location = new System.Drawing.Point(79, 288);
            this.tbEnde.Name = "tbEnde";
            this.tbEnde.ReadOnly = true;
            this.tbEnde.Size = new System.Drawing.Size(187, 20);
            this.tbEnde.TabIndex = 28;
            this.tbEnde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BausteinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbEnde);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbGezahlteZinsen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLaufzeit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbRestSchuld);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGesamt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDauer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbZinsen);
            this.Controls.Add(this.tbStart);
            this.Name = "BausteinControl";
            this.Size = new System.Drawing.Size(309, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbZinsen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDauer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGesamt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRestSchuld;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLaufzeit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbGezahlteZinsen;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbEnde;
    }
}
