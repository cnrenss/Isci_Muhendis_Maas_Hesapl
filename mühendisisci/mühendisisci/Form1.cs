namespace mühendisisci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Muhendis");
            comboBox1.Items.Add("Isci");
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            string adsoyad = txtadsoyad.Text;
            int saat = Convert.ToInt32(txtsaat.Text);
            int maas = 250;
            string combomeslek = comboBox1.SelectedItem.ToString();
            int netmaas = maas * saat;
            if (combomeslek == "Isci")
            {
                
                MessageBox.Show("İsim ve Soyİsim:" + adsoyad + "\n" + "Maas: " + netmaas );
                    
            }
            else if (combomeslek == "Muhendis")
            {
                int muhmaas = netmaas + 1000;
                MessageBox.Show("İsim ve Soyİsim:" + adsoyad + "\n" + "Maas: " + muhmaas);
            }
        }
    }
}