using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contadorDeCedulas
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void calculaNota2()
        {
            if (txtQtdeN2.Text == "")
            {
                txtTotalN2.Text = "0,00";
            }
            else
            {
                decimal qtde = Convert.ToDecimal(txtQtdeN2.Text);
                decimal total = (qtde * 2);
                txtTotalN2.Text = total.ToString();
                txtTotalN2.Text = Convert.ToDecimal(txtTotalN2.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaNota5()
        {
            if (txtQtdeN5.Text == "")
            {
                txtTotalN5.Text = "0,00";
            }
            else
            {
                decimal qtde = Convert.ToDecimal(txtQtdeN5.Text);
                decimal total = (qtde * 5);
                txtTotalN5.Text = total.ToString();
                txtTotalN5.Text = Convert.ToDecimal(txtTotalN5.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaNota10()
        {
            if (txtQtdeN10.Text == "")
            {
                txtTotalN10.Text = "0,00";
            }
            else
            {
                decimal qtde = Convert.ToDecimal(txtQtdeN10.Text);
                decimal total = (qtde * 10);
                txtTotalN10.Text = total.ToString();
                txtTotalN10.Text = Convert.ToDecimal(txtTotalN10.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaNota20()
        {
            if (txtQtdeN20.Text == "")
            {
                txtTotalN20.Text = "0,00";
            }
            else
            {
                decimal qtde = Convert.ToDecimal(txtQtdeN20.Text);
                decimal total = (qtde * 20);
                txtTotalN20.Text = total.ToString();
                txtTotalN20.Text = Convert.ToDecimal(txtTotalN20.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaNota50()
        {
            if (txtQtdeN50.Text == "")
            {
                txtTotalN50.Text = "0,00";
            }
            else
            {
                decimal qtde = Convert.ToDecimal(txtQtdeN50.Text);
                decimal total = (qtde * 50);
                txtTotalN50.Text = total.ToString();
                txtTotalN50.Text = Convert.ToDecimal(txtTotalN50.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaNota100()
        {
            if (txtQtdeN100.Text == "")
            {
                txtTotalN100.Text = "0,00";
            }
            else
            {
                decimal qtde = Convert.ToDecimal(txtQtdeN100.Text);
                decimal total = (qtde * 100);
                txtTotalN100.Text = total.ToString();
                txtTotalN100.Text = Convert.ToDecimal(txtTotalN100.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void txtQtdeN2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaNota2();
                txtQtdeN5.Focus();
            }
            if(e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if(e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void txtQtdeN5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaNota5();
                txtQtdeN10.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtQtdeN10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaNota10();
                txtQtdeN20.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtQtdeN20_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaNota20();
                txtQtdeN50.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtQtdeN50_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaNota50();
                txtQtdeN100.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtQtdeN100_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaNota100();
                txtM5.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtQtdeN2_Click(object sender, EventArgs e)
        {

        }

        private void txtQtdeN5_Click(object sender, EventArgs e)
        {
            calculaNota2();
        }

        private void txtQtdeN10_Click(object sender, EventArgs e)
        {
            calculaNota5();
        }

        private void txtQtdeN20_Click(object sender, EventArgs e)
        {
            calculaNota10();
        }

        private void txtQtdeN50_Click(object sender, EventArgs e)
        {
            calculaNota20();
        }

        private void txtQtdeN100_Click(object sender, EventArgs e)
        {
            calculaNota50();
        }

        private void frmContador_Load(object sender, EventArgs e)
        {
            limpar();
            txtQtdeN2.Focus();
        }

        private void txtM5_Click(object sender, EventArgs e)
        {
            
        }
        private void calculaMoeda5()
        {
            if (txtM5.Text == "")
            {
                txtTotalM5.Text = "0,00";
            }
            else
            {
                double qtde = Convert.ToDouble(txtM5.Text);
                double total = (qtde * 0.05);
                txtTotalM5.Text = total.ToString();
                txtTotalM5.Text = Convert.ToDecimal(txtTotalM5.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaMoeda10()
        {
            if (txtM10.Text == "")
            {
                txtTotalM10.Text = "0,00";
            }
            else
            {
                double qtde = Convert.ToDouble(txtM10.Text);
                double total = (qtde * 0.10);
                txtTotalM10.Text = total.ToString();
                txtTotalM10.Text = Convert.ToDecimal(txtTotalM10.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaMoeda25()
        {
            if (txtM25.Text == "")
            {
                txtTotalM25.Text = "0,00";
            }
            else
            {
                double qtde = Convert.ToDouble(txtM25.Text);
                double total = (qtde * 0.25);
                txtTotalM25.Text = total.ToString();
                txtTotalM25.Text = Convert.ToDecimal(txtTotalM25.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
            private void calculaMoeda50()
        {
            if (txtM50.Text == "")
            {
                txtTotalM50.Text = "0,00";
            }
            else
            {
                double qtde = Convert.ToDouble(txtM50.Text);
                double total = (qtde * 0.50);
                txtTotalM50.Text = total.ToString();
                txtTotalM50.Text = Convert.ToDecimal(txtTotalM50.Text).ToString("##,##0.00");
                totalGeral();
            }
        }
        private void calculaMoeda1()
        {
            if (txtM1.Text == "")
            {
                txtTotalM1.Text = "0,00";
            }
            else
            {
                double qtde = Convert.ToDouble(txtM1.Text);
                double total = (qtde * 1);
                txtTotalM1.Text = total.ToString();
                txtTotalM1.Text = Convert.ToDecimal(txtTotalM1.Text).ToString("##,##0.00");
                totalGeral();
            }
        }

        private void txtM5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaMoeda5();
                txtM10.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtM10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaMoeda10();
                txtM25.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtM25_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaMoeda25();
                txtM50.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtM50_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaMoeda50();
                txtM1.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtM1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculaMoeda1();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnTotal_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtM10_Click(object sender, EventArgs e)
        {
            calculaMoeda5();
        }

        private void txtM25_Click(object sender, EventArgs e)
        {
            calculaMoeda10();
        }

        private void txtM50_Click(object sender, EventArgs e)
        {
            calculaMoeda25();
        }

        private void txtM1_Click(object sender, EventArgs e)
        {
            calculaMoeda50();
        }
        private void totalGeral()
        {
            double N2 = Convert.ToDouble(txtTotalN2.Text);
            double N5 = Convert.ToDouble(txtTotalN5.Text);
            double N10 = Convert.ToDouble(txtTotalN10.Text);
            double N20 = Convert.ToDouble(txtTotalN20.Text);
            double N50 = Convert.ToDouble(txtTotalN50.Text);
            double N100 = Convert.ToDouble(txtTotalN100.Text);

            double M5 = Convert.ToDouble(txtTotalM5.Text);
            double M10 = Convert.ToDouble(txtTotalM10.Text);
            double M25 = Convert.ToDouble(txtTotalM25.Text);
            double M50 = Convert.ToDouble(txtTotalM50.Text);
            double M1 = Convert.ToDouble(txtTotalM1.Text);

            double totalGeral = (N2 + N5 + N10 + N20 + N50 + N100 + M5 + M10 + M25 + M50 + M1);
            txtTotalGeral.Text = totalGeral.ToString();
            txtTotalGeral.Text = Convert.ToDecimal(txtTotalGeral.Text).ToString("##,##0.00");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if(txtQtdeN2.Text != "")
            {
                calculaNota2();
            }
            if(txtQtdeN5.Text != "")
            { 
            calculaNota5();
            }
            if (txtQtdeN10.Text != "")
            {
                calculaNota10();
            }
            if (txtQtdeN20.Text != "")
            {
                calculaNota20();
            }
            if (txtQtdeN50.Text != "")
            {
                calculaNota50();
            }
            if (txtQtdeN100.Text != "")
            {
                calculaNota100();
            }
            if (txtM5.Text != "")
            {
                calculaMoeda5();
            }
            if (txtM10.Text != "")
            {
                calculaMoeda10();
            }
            if (txtM25.Text != "")
            {
                calculaMoeda25();
            }
            if (txtM50.Text != "")
            {
                calculaMoeda50();
            }
            if (txtM1.Text != "")
            {
                calculaMoeda1();
            }
            totalGeral();
        }
        private void limpar()
        {
            txtQtdeN2.Text = "";
            txtQtdeN5.Text = "";
            txtQtdeN10.Text = "";
            txtQtdeN20.Text = "";
            txtQtdeN50.Text = "";
            txtQtdeN100.Text = "";

            txtTotalN2.Text = "0,00";
            txtTotalN5.Text = "0,00";
            txtTotalN10.Text = "0,00";
            txtTotalN20.Text = "0,00";
            txtTotalN50.Text = "0,00";
            txtTotalN100.Text = "0,00";

            txtM5.Text = "";
            txtM10.Text = "";
            txtM25.Text = "";
            txtM50.Text = "";
            txtM1.Text = "";

            txtTotalM5.Text = "0,00";
            txtTotalM10.Text = "0,00";
            txtTotalM25.Text = "0,00";
            txtTotalM50.Text = "0,00";
            txtTotalM1.Text = "0,00";

            txtTotalGeral.Text = "0,00";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            txtQtdeN2.Focus();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTotalGeral.Text);
        }

        private void txtQtdeN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtQtdeN5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtQtdeN10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtQtdeN20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtQtdeN50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtQtdeN100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtM5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtM10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtM25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtM50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }

        private void txtM1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)126 && e.KeyChar != (char)44) // Se a tecla pressionada não for número E a tecla pressionada não for Backspace E a tecla pressionada não for Delete E se a tecla pressionada não for igual ao vírgula
            {
                e.Handled = true; // Bloqueia as demais teclas
            }
        }
    }
}
