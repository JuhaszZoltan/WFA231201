namespace WFA231201
{
    partial class FrmDgv
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
            dgvAdatok = new DataGridView();
            clNev = new DataGridViewTextBoxColumn();
            clSzul = new DataGridViewTextBoxColumn();
            clVanLo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAdatok).BeginInit();
            SuspendLayout();
            // 
            // dgvAdatok
            // 
            dgvAdatok.AllowUserToAddRows = false;
            dgvAdatok.AllowUserToDeleteRows = false;
            dgvAdatok.AllowUserToResizeColumns = false;
            dgvAdatok.AllowUserToResizeRows = false;
            dgvAdatok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdatok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdatok.Columns.AddRange(new DataGridViewColumn[] { clNev, clSzul, clVanLo });
            dgvAdatok.Location = new Point(12, 12);
            dgvAdatok.Name = "dgvAdatok";
            dgvAdatok.ReadOnly = true;
            dgvAdatok.RowHeadersVisible = false;
            dgvAdatok.RowTemplate.Height = 25;
            dgvAdatok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdatok.Size = new Size(699, 372);
            dgvAdatok.TabIndex = 0;
            // 
            // clNev
            // 
            clNev.HeaderText = "Név";
            clNev.Name = "clNev";
            clNev.ReadOnly = true;
            // 
            // clSzul
            // 
            clSzul.FillWeight = 80F;
            clSzul.HeaderText = "Születési dátum";
            clSzul.Name = "clSzul";
            clSzul.ReadOnly = true;
            // 
            // clVanLo
            // 
            clVanLo.FillWeight = 40F;
            clVanLo.HeaderText = "Van lova";
            clVanLo.Name = "clVanLo";
            clVanLo.ReadOnly = true;
            // 
            // FrmDgv
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 396);
            Controls.Add(dgvAdatok);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmDgv";
            Text = "FrmDgv";
            ((System.ComponentModel.ISupportInitialize)dgvAdatok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdatok;
        private DataGridViewTextBoxColumn clNev;
        private DataGridViewTextBoxColumn clSzul;
        private DataGridViewCheckBoxColumn clVanLo;
    }
}