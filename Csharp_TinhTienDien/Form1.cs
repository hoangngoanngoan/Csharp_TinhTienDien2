namespace Csharp_TinhTienDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double soDien;
        private void GetInPut()
        {
            soDien = Convert.ToDouble(txtSoDien.Text);
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            lsbKetQua.Items.Clear();
            GetInPut();
            int[] cuoc = { 1806, 1866, 2167, 2729, 3050, 3151 };
            int[] bac = { 0, 50, 100, 200, 300, 400 };
            double gia = 0;
            double tong = 0;
            for (int i = 5; i >= 0; i--)
            {
                if (soDien > bac[i])
                {
                    for (int j = i; j >= 0; j--)
                    {
                        gia = (soDien - bac[j]) * cuoc[j];
                        tong += gia;
                        soDien = soDien - (soDien - bac[i]);
                        lsbKetQua.Items.Add("Giá số điện bậc " + j + ": " + gia.ToString("0,##0.00 VND"));
                    }
                    i = -1;
                }
            }
            labKetQua.Text = tong.ToString("0,0##.00");
        }
    }
}
