namespace Tinhtiendien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SoKwh = Convert.ToDouble(KWhTxt.Text);
            int[] Tiendien = { 1806, 1866, 2167, 2729, 3050, 3151 };

            int[] Bac = { 50, 50, 100, 100, 100, 100 };

            double tong = 0, Tien = 1;





            int j = 0;
            while (SoKwh > Bac[j])
            {
                Tien = Bac[j] * Tiendien[j];


                tong += Tien;
                KetQuaLsB.Items.Add("Bac " + (j + 1) + ": " + Tien.ToString() + Environment.NewLine);

                SoKwh -= Bac[j];
                j++;

                if (SoKwh < Bac[j])
                {
                    Tien = SoKwh * Tiendien[j];
                    tong += Tien;
                    KetQuaLsB.Items.Add("Bac " + (j + 1) + ": " + Tien.ToString() + Environment.NewLine);
                }
            }





            KetQuaLsB.Items.Add("Tong so tien: " + tong.ToString() + Environment.NewLine);









        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }

}
