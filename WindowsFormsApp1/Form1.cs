using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double tn, Tz, h, k, a, Qn, T, dT, i, tt;
            string s;
            tn = Convert.ToDouble(Button_Tn.Text);//время нагревания
            h = Convert.ToDouble(Button_h.Text);//шаг замеров
            k = Convert.ToDouble(Button_K.Text);//коэфф k
            a = Convert.ToDouble(Button_A.Text);//коэфф A
            T = Convert.ToDouble(Button_th.Text);//T нач
            Qn = Convert.ToDouble(Button_Qn.Text);//Q нагревателя
            i = 1;
            tt = 0;
            while (tn > tt)
            {
                s = "'точка №" + i.ToString() + "в момент времени t=" + tt.ToString() + " температура T=" + T.ToString() + ".";
                listBox1.Items.Add(s);
                dT = k * (Qn - a * T * T);
                T = T + dT * h;
                tt += h;
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tz, qz,a;
            string s;
            tz = Convert.ToDouble(Button_Tz.Text);//T заданная
            qz = Convert.ToDouble(Button_Qz.Text);//q нагревателя
            a = qz / (tz * tz);
            s = "'требуемый уровень нагрева Tзад=" + tz.ToString() + "может быть достигнут при a=<" + a.ToString() + "при любом k";
            MessageBox.Show(s);
        }
    }
}
