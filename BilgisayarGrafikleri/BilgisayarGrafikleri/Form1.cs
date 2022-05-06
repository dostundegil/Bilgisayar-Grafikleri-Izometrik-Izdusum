using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarGrafikleri
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        System.Drawing.Graphics Grafikciz;

        Pen kalem = new Pen(Color.Red, 2);



        double[,] XEkseni = new double[2, 4] { { 0, 0, 0, 1 }, { 2, 0, 0, 1 } };
        double[,] YEkseni = new double[2, 4] { { 0, 0, 0, 1 }, { 0, 2, 0, 1 } };
        double[,] ZEkseni = new double[2, 4] { { 0, 0, 0, 1 }, { 0, 0, 2, 1 } };
        double[,] GeciciKub = new double[8, 4];

        double[,] Tizometrik = new double[4, 4] { {0.707   , -0.408 , 0, 0},
                                                  {0       , 0.816  , 0, 0},
                                                  {-0.707  , -0.408 , 0, 0},
                                                  {0       ,  0     , 0, 1},
         };



        double[,] XCisimNokta = new double[8, 4] { { 0 ,0 ,0 ,1 },
                                                   { 1 ,0 ,0 ,1 },
                                                   { 1 ,0 ,1 ,1 },
                                                   { 0 ,0 ,1 ,1 },
                                                   { 0 ,1 ,0 ,1 },
                                                   { 1 ,1 ,0 ,1 },
                                                   { 1 ,1 ,1 ,1 },
                                                   { 0 ,1 ,1 ,1 },
         };

        double[,] otele = new double[4, 4]{ {1, 0, 0, 0},
                                             {0, 1, 0, 0},
                                             {0, 0, 1, 0},
                                             {0, 0, 0, 1} };
        double[,] olcekle = new double[4, 4]{ {1, 0, 0, 0},
                                             {0, 1, 0, 0},
                                             {0, 0, 1, 0},
                                             {0, 0, 0, 1} };

        private void Ciz()
        {
            Grafikciz = this.CreateGraphics();

            kalem.Color = Color.Red;
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[0, 0]), KhesaplaY(GeciciKub[0, 1]), KhesaplaX(GeciciKub[1, 0]), KhesaplaY(GeciciKub[1, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[1, 0]), KhesaplaY(GeciciKub[1, 1]), KhesaplaX(GeciciKub[2, 0]), KhesaplaY(GeciciKub[2, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[2, 0]), KhesaplaY(GeciciKub[2, 1]), KhesaplaX(GeciciKub[3, 0]), KhesaplaY(GeciciKub[3, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[3, 0]), KhesaplaY(GeciciKub[3, 1]), KhesaplaX(GeciciKub[0, 0]), KhesaplaY(GeciciKub[0, 1]));

            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[4, 0]), KhesaplaY(GeciciKub[4, 1]), KhesaplaX(GeciciKub[5, 0]), KhesaplaY(GeciciKub[5, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[5, 0]), KhesaplaY(GeciciKub[5, 1]), KhesaplaX(GeciciKub[6, 0]), KhesaplaY(GeciciKub[6, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[6, 0]), KhesaplaY(GeciciKub[6, 1]), KhesaplaX(GeciciKub[7, 0]), KhesaplaY(GeciciKub[7, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[7, 0]), KhesaplaY(GeciciKub[7, 1]), KhesaplaX(GeciciKub[4, 0]), KhesaplaY(GeciciKub[4, 1]));

            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[0, 0]), KhesaplaY(GeciciKub[0, 1]), KhesaplaX(GeciciKub[4, 0]), KhesaplaY(GeciciKub[4, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[1, 0]), KhesaplaY(GeciciKub[1, 1]), KhesaplaX(GeciciKub[5, 0]), KhesaplaY(GeciciKub[5, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[2, 0]), KhesaplaY(GeciciKub[2, 1]), KhesaplaX(GeciciKub[6, 0]), KhesaplaY(GeciciKub[6, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciKub[3, 0]), KhesaplaY(GeciciKub[3, 1]), KhesaplaX(GeciciKub[7, 0]), KhesaplaY(GeciciKub[7, 1]));
            Grafikciz.Dispose();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            EksenCiz();
        }

        private void EksenCiz()
        {
           
            try { 
            kalem.Color = Color.Blue;
            double[,] GeciciXEkseni = new double[2, 4];
            double[,] GeciciYEkseni = new double[2, 4];
            double[,] GeciciZEkseni = new double[2, 4];

            int i, j, k;
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 4; j++)
                {
                    GeciciXEkseni[i, j] = 0;
                    GeciciYEkseni[i, j] = 0;
                    GeciciZEkseni[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {

                        GeciciXEkseni[i, j] += XEkseni[i, k] * Tizometrik[k, j];
                        GeciciYEkseni[i, j] += YEkseni[i, k] * Tizometrik[k, j];
                        GeciciZEkseni[i, j] += ZEkseni[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Grafikciz = this.CreateGraphics();
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciXEkseni[0, 0]), KhesaplaY(GeciciXEkseni[0, 1]), KhesaplaX(GeciciXEkseni[1, 0]), KhesaplaY(GeciciXEkseni[1, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciYEkseni[0, 0]), KhesaplaY(GeciciYEkseni[0, 1]), KhesaplaX(GeciciYEkseni[1, 0]), KhesaplaY(GeciciYEkseni[1, 1]));
            Grafikciz.DrawLine(kalem, KhesaplaX(GeciciZEkseni[0, 0]), KhesaplaY(GeciciZEkseni[0, 1]), KhesaplaX(GeciciZEkseni[1, 0]), KhesaplaY(GeciciZEkseni[1, 1]));
            Grafikciz.Dispose();
            }
            catch
            {
                ;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grafikciz = this.CreateGraphics();
        }
        private int KhesaplaX(double gecicix)
        {
            return Convert.ToInt32(500 + (100 * gecicix));
        }

        private int KhesaplaY(double geciciy)
        {
            return Convert.ToInt32(325 + (-100 * geciciy));
        }

        private void btnİzdüşüm_Click(object sender, EventArgs e)
        {
            Izdusum();
        }

        private void Izdusum()
        {
            EksenCiz();
            int i, j, k; ;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    GeciciKub[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        GeciciKub[i, j] += XCisimNokta[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Ciz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otele();
        }

        private void Otele()
        {
            try
            {
                EksenCiz();
                int i, j, k;
                
                if  (oteleX.Text != "")
                    otele[3, 0] = Convert.ToDouble(oteleX.Text);
                if (oteleY.Text != "")
                    otele[3, 1] = Convert.ToDouble(oteleY.Text);
                if (oteleZ.Text != "")
                    otele[3, 2] = Convert.ToDouble(oteleZ.Text);

                double[,] geciciKub2 = new double[8, 4];

                for (i = 0; i < 8; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        geciciKub2[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            geciciKub2[i, j] += XCisimNokta[i, k] * otele[k, j];
                        }
                    }
                }

                for (i = 0; i < 8; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        GeciciKub[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            GeciciKub[i, j] += geciciKub2[i, k] * Tizometrik[k, j];
                        }
                    }
                }
                Ciz();
                Temizle();
            }

            catch
            {
                ;
            }
        }

        private void Temizle()
        {
           
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnOlcekle_Click(object sender, EventArgs e)
        {
            Olcekle();
        }

        private void Olcekle()
        {
            try { 
            EksenCiz();
            double[,] gecicikub2 = new double[8, 4];
            int i, j, k;
            if (olcekleX.Text != "")
                olcekle[0, 0] = Convert.ToDouble(olcekleX.Text);
            if (olcekleY.Text != "")
                olcekle[1, 1] = Convert.ToDouble(olcekleY.Text);
            if (olcekleZ.Text != "")
                olcekle[2, 2] = Convert.ToDouble(olcekleZ.Text);

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    gecicikub2[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        gecicikub2[i, j] += XCisimNokta[i, k] * olcekle[k, j];
                    }
                }
            }

            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    GeciciKub[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        GeciciKub[i, j] += gecicikub2[i, k] * Tizometrik[k, j];
                    }
                }
            }

                kalem.Color = Color.FromArgb(233, 147, 64);
                Ciz();
                Temizle();
            }

            catch
            {
                ;
            }
        }

        private static void Dene(KeyPressEventArgs e)
        {
            byte backspace = (byte)e.KeyChar; //8
            if (!char.IsDigit(e.KeyChar) & backspace != 8)
                e.Handled = true;
        }

        private void oteleX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dene(e);
        }

        private void oteleY_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Dene(e);
        }

        private void oteleZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dene(e);
        }

        private void olcekleX_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dene(e);
        }

        private void olcekleY_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dene(e);
        }

        private void olcekleZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dene(e);
        }
    }
}
