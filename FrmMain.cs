namespace WFA231201
{
    public partial class FrmMain : Form
    {
        private List<Ember> emberek = new();
        private string eleresiUt;

        public FrmMain()
        {
            eleresiUt = @"..\..\..\src\adatok.txt";
            InitializeComponent();
            btnBetoltes.Click += BtnBetoltes_Click;
            btnMegnyitas.Click += BtnMegnyitas_Click;
        }

        private void BtnMegnyitas_Click(object? sender, EventArgs e)
        {
            FrmDgv frmDgv = new(emberek);
            frmDgv.ShowDialog();
        }

        private void BtnBetoltes_Click(object? sender, EventArgs e)
        {
            try
            {
                //listába való betöltés
                using StreamReader sr = new(eleresiUt);
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    string nev = sor[0];
                    DateTime szul = DateTime.Parse(sor[1]);
                    bool vanLo = sor[2] == "igen";
                    emberek.Add(new(nev, szul, vanLo));
                }
            }
            catch (Exception exc)
            {
                _ = MessageBox.Show(exc.Message);
                throw;
            }

            //listView-ba való betöltés
            foreach (var ember in emberek)
            {
                var lsviVektor = ember.ToString().Split(';');
                lsvAdatok.Items.Add(new ListViewItem(lsviVektor));
            }
        }
    }
}