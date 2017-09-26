using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app4
{
    public partial class MainPage : ContentPage
        
    {
        float dato1;
        float dato2;
        String op;
        float rsl;
        public MainPage()
            
        {
            InitializeComponent();
        }

        private void uno_Clicked(object sender, EventArgs o)
        {
             rs.Text = rs.Text+"1";
        }

        private void dos_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text+"2";
        }
        private void tres_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "3";
        }
        private void cuatro_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "4";
        }
        private void cinco_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "5";
        }
        private void seis_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "6";
        }
        private void siete_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "7";
        }
        private void ocho_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "8";
        }
        private void nueve_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "9";
        }
        private void cero_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + "0";
        }
        private void punto_Clicked(object sender, EventArgs o)
        {
            rs.Text = rs.Text + ".";
        }
        private void sqrt_Clicked(object sender, EventArgs o)
        {
            double raiz = double.Parse(rs.Text);
            double rl;
            rl = Math.Sqrt(raiz);
            rs.Text = "" + rl;
        }

        private void lp_Clicked(object sender, EventArgs o)
        {
            rs.Text = null;
            dato1 = 0;
            dato2 = 0;
            op = null;
        }
        private void suma_Clicked(object sender, EventArgs o)
        {
            op = "+";
            dato1 = float.Parse(rs.Text);
            rs.Text = null;
        }
        private void resta_Clicked(object sender, EventArgs o)
        {
            op = "-";
            dato1 = float.Parse(rs.Text);
            rs.Text = null;
        }
        private void mul_Clicked(object sender, EventArgs o)
        {
            op = "*";
            dato1 = float.Parse(rs.Text);
            rs.Text = null;
        }
        private void div_Clicked(object sender, EventArgs o)
        {
            op = "/";
            dato1 = float.Parse(rs.Text);
            rs.Text = null;
        }

        private void igual_Clicked(object sender, EventArgs o)
        {
            dato2 = float.Parse(rs.Text);
            if (op.Equals("+"))
            {
                suma();
            }
            if (op.Equals("-"))
            {
                resta();
            }
            if (op.Equals("*"))
            {
                mult();
            }
            if (op.Equals("/"))
            {
                div();
            }
        }

        private void suma()
        {
            rsl = dato1 + dato2;
            rs.Text = ""+rsl;
        }
        private void resta()
        {
            rsl = dato1 - dato2;
            rs.Text = "" + rsl;
        }
        private void mult()
        {
            rsl = dato1 * dato2;
            rs.Text = "" + rsl;
        }
        private void div()
        {
            rsl = dato1 / dato2;
            rs.Text = "" + rsl;
        }


    }
}
