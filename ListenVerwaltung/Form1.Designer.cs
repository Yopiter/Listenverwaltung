namespace ListenVerwaltung
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
            this.Tb = new System.Windows.Forms.DataGridView();
            this.Objekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verfallsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NKFach = new System.Windows.Forms.NumericUpDown();
            this.BT_down = new System.Windows.Forms.Button();
            this.BT_up = new System.Windows.Forms.Button();
            this.BT_use = new System.Windows.Forms.Button();
            this.BT_store = new System.Windows.Forms.Button();
            this.LBAnz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NKFach)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb
            // 
            this.Tb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Objekt,
            this.Menge,
            this.Anzahl,
            this.Verfallsdatum});
            this.Tb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tb.Location = new System.Drawing.Point(0, 34);
            this.Tb.MultiSelect = false;
            this.Tb.Name = "Tb";
            this.Tb.Size = new System.Drawing.Size(881, 259);
            this.Tb.TabIndex = 0;
            this.Tb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tb_CellClick);
            this.Tb.Leave += new System.EventHandler(this.Tb_Leave);
            // 
            // Objekt
            // 
            this.Objekt.HeaderText = "Objekt";
            this.Objekt.Name = "Objekt";
            // 
            // Menge
            // 
            this.Menge.HeaderText = "Menge/Spezifikation";
            this.Menge.Name = "Menge";
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            // 
            // Verfallsdatum
            // 
            this.Verfallsdatum.HeaderText = "Verfallsdatum";
            this.Verfallsdatum.Name = "Verfallsdatum";
            // 
            // NKFach
            // 
            this.NKFach.Location = new System.Drawing.Point(442, 8);
            this.NKFach.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NKFach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NKFach.Name = "NKFach";
            this.NKFach.Size = new System.Drawing.Size(43, 20);
            this.NKFach.TabIndex = 1;
            this.NKFach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NKFach.ValueChanged += new System.EventHandler(this.NKFach_ValueChanged);
            // 
            // BT_down
            // 
            this.BT_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_down.Location = new System.Drawing.Point(361, -1);
            this.BT_down.Name = "BT_down";
            this.BT_down.Size = new System.Drawing.Size(75, 33);
            this.BT_down.TabIndex = 2;
            this.BT_down.Text = "-";
            this.BT_down.UseVisualStyleBackColor = true;
            this.BT_down.Click += new System.EventHandler(this.BT_down_Click);
            // 
            // BT_up
            // 
            this.BT_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_up.Location = new System.Drawing.Point(491, -1);
            this.BT_up.Name = "BT_up";
            this.BT_up.Size = new System.Drawing.Size(75, 33);
            this.BT_up.TabIndex = 3;
            this.BT_up.Text = "+";
            this.BT_up.UseVisualStyleBackColor = true;
            this.BT_up.Click += new System.EventHandler(this.BT_up_Click);
            // 
            // BT_use
            // 
            this.BT_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_use.Location = new System.Drawing.Point(0, -1);
            this.BT_use.Name = "BT_use";
            this.BT_use.Size = new System.Drawing.Size(75, 33);
            this.BT_use.TabIndex = 4;
            this.BT_use.Text = "-";
            this.BT_use.UseVisualStyleBackColor = true;
            this.BT_use.Click += new System.EventHandler(this.BT_use_Click);
            // 
            // BT_store
            // 
            this.BT_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_store.Location = new System.Drawing.Point(111, -1);
            this.BT_store.Name = "BT_store";
            this.BT_store.Size = new System.Drawing.Size(75, 33);
            this.BT_store.TabIndex = 5;
            this.BT_store.Text = "+";
            this.BT_store.UseVisualStyleBackColor = true;
            this.BT_store.Click += new System.EventHandler(this.BT_store_Click);
            // 
            // LBAnz
            // 
            this.LBAnz.AutoSize = true;
            this.LBAnz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAnz.Location = new System.Drawing.Point(81, 3);
            this.LBAnz.Name = "LBAnz";
            this.LBAnz.Size = new System.Drawing.Size(24, 25);
            this.LBAnz.TabIndex = 6;
            this.LBAnz.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 293);
            this.Controls.Add(this.LBAnz);
            this.Controls.Add(this.BT_store);
            this.Controls.Add(this.BT_use);
            this.Controls.Add(this.BT_up);
            this.Controls.Add(this.BT_down);
            this.Controls.Add(this.NKFach);
            this.Controls.Add(this.Tb);
            this.Name = "Form1";
            this.Text = "Verwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NKFach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tb;
        private System.Windows.Forms.NumericUpDown NKFach;
        private System.Windows.Forms.Button BT_down;
        private System.Windows.Forms.Button BT_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objekt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verfallsdatum;
        private System.Windows.Forms.Button BT_use;
        private System.Windows.Forms.Button BT_store;
        private System.Windows.Forms.Label LBAnz;
    }
}

