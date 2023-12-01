namespace WFA231201
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvAdatok = new ListView();
            clhNev = new ColumnHeader();
            clhSzul = new ColumnHeader();
            clhVanLova = new ColumnHeader();
            btnBetoltes = new Button();
            btnMegnyitas = new Button();
            SuspendLayout();
            // 
            // lsvAdatok
            // 
            lsvAdatok.Columns.AddRange(new ColumnHeader[] { clhNev, clhSzul, clhVanLova });
            lsvAdatok.Location = new Point(21, 15);
            lsvAdatok.Margin = new Padding(5, 6, 5, 6);
            lsvAdatok.Name = "lsvAdatok";
            lsvAdatok.Size = new Size(505, 527);
            lsvAdatok.TabIndex = 0;
            lsvAdatok.UseCompatibleStateImageBehavior = false;
            lsvAdatok.View = View.Details;
            // 
            // clhNev
            // 
            clhNev.Text = "Név";
            clhNev.Width = 200;
            // 
            // clhSzul
            // 
            clhSzul.Text = "Születési dátum";
            clhSzul.Width = 200;
            // 
            // clhVanLova
            // 
            clhVanLova.Text = "Van lova";
            clhVanLova.Width = 100;
            // 
            // btnBetoltes
            // 
            btnBetoltes.Location = new Point(536, 15);
            btnBetoltes.Margin = new Padding(5, 6, 5, 6);
            btnBetoltes.Name = "btnBetoltes";
            btnBetoltes.Size = new Size(229, 74);
            btnBetoltes.TabIndex = 1;
            btnBetoltes.Text = "adatok betoltése";
            btnBetoltes.UseVisualStyleBackColor = true;
            // 
            // btnMegnyitas
            // 
            btnMegnyitas.Location = new Point(534, 131);
            btnMegnyitas.Name = "btnMegnyitas";
            btnMegnyitas.Size = new Size(233, 74);
            btnMegnyitas.TabIndex = 2;
            btnMegnyitas.Text = "Másik form megnyitása";
            btnMegnyitas.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 557);
            Controls.Add(btnMegnyitas);
            Controls.Add(btnBetoltes);
            Controls.Add(lsvAdatok);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "ListView";
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvAdatok;
        private Button btnBetoltes;
        private ColumnHeader clhNev;
        private ColumnHeader clhSzul;
        private ColumnHeader clhVanLova;
        private Button btnMegnyitas;
    }
}