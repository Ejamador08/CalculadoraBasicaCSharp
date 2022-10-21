using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        #region Variables
        //declaración de variables
        double num1;
        double num2;
        char operador;
        #endregion

        #region Objetos
        //objetos por cada clase que contiene las operaciones
        Operaciones.CSuma s = new Operaciones.CSuma();
        Operaciones.CResta r = new Operaciones.CResta();
        Operaciones.CProducto p = new Operaciones.CProducto();
        Operaciones.CDivision d = new Operaciones.CDivision();
        Operaciones.CExponente ex = new Operaciones.CExponente();
        Operaciones.CModular m = new Operaciones.CModular();
        #endregion

        public frmCalculadora()
        {
            InitializeComponent();
            txtresultado.Text = "-.-"; //caja de texto que mostramos los resultados
        }

        #region CerrarApp
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region EncenderCalculadora
        public void EncenderCalculadora()
        {
            txtresultado.Text = "";
            txtresultado.Focus();
            btnClean.Enabled = true;
            btnRaiz.Enabled = true;
            btnPotencia.Enabled = true;
            btnPorcentaje.Enabled = true;
            btnSiete.Enabled = true;
            btnOcho.Enabled = true;
            btnNueve.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnDivision.Enabled = true;
            btnCuatro.Enabled = true;
            btnCinco.Enabled = true;
            btnSeis.Enabled = true;
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnUno.Enabled = true;
            btnDos.Enabled = true;
            btnTres.Enabled = true;
            btnNegativo.Enabled = true;
            btnDecimales.Enabled = true;
            btnCero.Enabled = true;
            btnIgual.Enabled = true;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            EncenderCalculadora(); //llamamos el metodo para encender la calculadora
        }
        #endregion

        #region BotonesNuméricos
        private void btnCero_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }



        #endregion

        #region BotonesOperaciones
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = char.Parse("+");
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = char.Parse("-");
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = char.Parse("*");
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = char.Parse("/");
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operador = char.Parse("^");
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Text = Convert.ToString(Math.Sqrt(num1));
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            operador = char.Parse("%");
            num1 = double.Parse(txtresultado.Text);
            txtresultado.Clear();
        }
        #endregion

        #region BotonIgual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtresultado.Text);
            switch (operador)
            {
                case '+':
                    txtresultado.Text = Convert.ToString(s.OperacionSuma(num1, num2));
                    break;
                case '-':
                    txtresultado.Text = Convert.ToString(r.OperacionResta(num1, num2));
                    break;
                case '*':
                    txtresultado.Text = Convert.ToString(p.OperacionProducto(num1, num2));
                    break;
                case '/':
                    if (num2<=0)
                    {
                        txtresultado.Text = "Syntas.Error!!!";
                    }
                    else
                    {
                        txtresultado.Text = Convert.ToString(d.OperacionDivision(num1, num2));
                    }
                    break;
                case '^':
                    if (num2 < 0)
                    {
                        txtresultado.Text = "Syntas.Error!!!";
                    }
                    else if (num2 == 0)
                    {
                        txtresultado.Text = "1";
                    }
                    else
                    {
                        txtresultado.Text =Convert.ToString(ex.OperacionExpoenciación(num1,num2));
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        txtresultado.Text = Convert.ToString(num1);
                    }
                    else
                    {
                        txtresultado.Text = Convert.ToString(m.OperacionExpoenciación(num1, num2));
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region CambiarSigno
        private void btnNegativo_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtresultado.Text);
            num1 = ((num1) * (-1));
            txtresultado.Text = num1.ToString();
        }
        #endregion

        #region AgregarDecimales
        private void btnDecimales_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + ".";
        }
        #endregion

        #region LimpiarPantalla
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
        }
        #endregion
    }
}
