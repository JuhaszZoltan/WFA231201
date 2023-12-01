using System.Configuration;

namespace WFA231201
{
    public partial class FrmDgv : Form
    {
        private List<Ember> Emberek { get; set; }

        public FrmDgv(List<Ember> emberek)
        {
            Emberek = emberek;
            InitializeComponent();
            this.Load += FrmDgv_Load;
        }

        private void FrmDgv_Load(object? sender, EventArgs e)
        {
            foreach (var ember in Emberek)
            {
                dgvAdatok.Rows.Add(
                    ember.Nev,
                    ember.Szul.ToString("yyyy-MM-dd"),
                    ember.VanLova);
            }
        }
    }
}
