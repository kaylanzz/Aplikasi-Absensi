namespace AplikasiAbsensi
{
    public partial class Form1 : Form
    {
        List<Absensi> daftarAbsensi = new List<Absensi>();

        Dictionary<string, string> dataPin = new Dictionary<string, string>
        {
            { "Yono", "1111" },
            { "Supradi", "2222" },
            { "Hondadi", "3333" },
            { "Sumanto", "4444" },
            { "Sity", "5555" },
            { "Sukinem", "6666" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void TampilkanData()
        {
            dgvrekap.DataSource = null;
            dgvrekap.DataSource = daftarAbsensi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbnama.Items.AddRange(new string[] { "Yono", "Supradi", "Hondadi", "Sumanto", "Sity", "Sukinem" });
            cbnama.SelectedIndex = 0;

        }
        public class Absensi
        {
            public string Nama { get; set; }
            public DateTime Tanggal { get; set; }
            public string JamMasuk { get; set; }
            public string JamKeluar { get; set; }
            public string keterangan { get; set; }
        }

        private void btncekin_Click(object sender, EventArgs e)
        {
            string nama = cbnama.Text;
            string pin = txtpin.Text;

            DateTime tanggal = dttanggal.Value.Date;
            if (!dataPin.ContainsKey(nama) || dataPin[nama] != pin)
            {
                lblstatus.Text = $"❌ PIN salah untuk {nama}!";
                return;
            }
            string keterangan = DateTime.Now.Hour >= 8 ? "Terlambat" : "Tepat waktu";

            var sudahAda = daftarAbsensi
                .FirstOrDefault(a => a.Nama == nama && a.Tanggal == tanggal);

            if (sudahAda == null)
            {
                daftarAbsensi.Add(new Absensi
                {
                    Nama = nama,
                    Tanggal = tanggal,
                    JamMasuk = DateTime.Now.ToString("HH:mm"),
                    JamKeluar = "-",
                    keterangan = keterangan
                });
                lblstatus.Text = $"✅ {nama} absen masuk pada {DateTime.Now:HH:mm}";
            }
            else
            {
                lblstatus.Text = $"⚠️ {nama} sudah absen masuk hari ini.";
            }

            TampilkanData();
        }

        private void btncekot_Click(object sender, EventArgs e)
        {
            string nama = cbnama.Text;

            DateTime tanggal = dttanggal.Value.Date;
            string pin = txtpin.Text;

            if (!dataPin.ContainsKey(nama) || dataPin[nama] != pin)
            {
                lblstatus.Text = $"❌ PIN salah untuk {nama}!";
                return;
            }
            var data = daftarAbsensi
                .FirstOrDefault(a => a.Nama == nama && a.Tanggal == tanggal);

            if (data != null && data.JamKeluar == "-")
            {
                data.JamKeluar = DateTime.Now.ToString("HH:mm");
                lblstatus.Text = $"✅ {nama} absen pulang pada {DateTime.Now:HH:mm}";
            }
            else if (data == null)
            {
                lblstatus.Text = $"⚠️ {nama} belum absen masuk hari ini.";
            }
            else
            {
                lblstatus.Text = $"⚠️ {nama} sudah absen pulang.";
            }
            TampilkanData();

        }
    }
}


