
namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.P1 = new System.Windows.Forms.Panel();
            this.lblencabezado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnDecimales = new System.Windows.Forms.Button();
            this.P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.DarkRed;
            this.P1.Controls.Add(this.lblencabezado);
            this.P1.Controls.Add(this.btnCerrar);
            this.P1.Location = new System.Drawing.Point(-1, -2);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(396, 46);
            this.P1.TabIndex = 0;
            // 
            // lblencabezado
            // 
            this.lblencabezado.AutoSize = true;
            this.lblencabezado.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencabezado.ForeColor = System.Drawing.Color.White;
            this.lblencabezado.Location = new System.Drawing.Point(53, -2);
            this.lblencabezado.Name = "lblencabezado";
            this.lblencabezado.Size = new System.Drawing.Size(286, 45);
            this.lblencabezado.TabIndex = 0;
            this.lblencabezado.Text = "Calculadora Básica";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(353, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("OCR-A BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(13, 62);
            this.txtresultado.MaxLength = 21;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(369, 37);
            this.txtresultado.TabIndex = 1;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.DarkRed;
            this.btnEncender.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender.ForeColor = System.Drawing.Color.White;
            this.btnEncender.Location = new System.Drawing.Point(12, 112);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(69, 60);
            this.btnEncender.TabIndex = 2;
            this.btnEncender.Text = "On";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkRed;
            this.btnClean.Enabled = false;
            this.btnClean.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(87, 112);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(69, 60);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "CE";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.DarkRed;
            this.btnRaiz.Enabled = false;
            this.btnRaiz.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.Color.White;
            this.btnRaiz.Location = new System.Drawing.Point(162, 112);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(69, 60);
            this.btnRaiz.TabIndex = 2;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.Color.DarkRed;
            this.btnPotencia.Enabled = false;
            this.btnPotencia.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.ForeColor = System.Drawing.Color.White;
            this.btnPotencia.Location = new System.Drawing.Point(237, 112);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(69, 60);
            this.btnPotencia.TabIndex = 2;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.DarkRed;
            this.btnPorcentaje.Enabled = false;
            this.btnPorcentaje.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.ForeColor = System.Drawing.Color.White;
            this.btnPorcentaje.Location = new System.Drawing.Point(312, 112);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(69, 60);
            this.btnPorcentaje.TabIndex = 2;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.DarkRed;
            this.btnSiete.Enabled = false;
            this.btnSiete.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.Color.White;
            this.btnSiete.Location = new System.Drawing.Point(12, 178);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(69, 60);
            this.btnSiete.TabIndex = 2;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.DarkRed;
            this.btnOcho.Enabled = false;
            this.btnOcho.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.Color.White;
            this.btnOcho.Location = new System.Drawing.Point(87, 178);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(69, 60);
            this.btnOcho.TabIndex = 2;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.DarkRed;
            this.btnNueve.Enabled = false;
            this.btnNueve.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.Color.White;
            this.btnNueve.Location = new System.Drawing.Point(162, 178);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(69, 60);
            this.btnNueve.TabIndex = 2;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.DarkRed;
            this.btnCuatro.Enabled = false;
            this.btnCuatro.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.Color.White;
            this.btnCuatro.Location = new System.Drawing.Point(12, 244);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(69, 60);
            this.btnCuatro.TabIndex = 2;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.DarkRed;
            this.btnCinco.Enabled = false;
            this.btnCinco.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(87, 244);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(69, 60);
            this.btnCinco.TabIndex = 2;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.DarkRed;
            this.btnSeis.Enabled = false;
            this.btnSeis.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(162, 244);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(69, 60);
            this.btnSeis.TabIndex = 2;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.DarkRed;
            this.btnUno.Enabled = false;
            this.btnUno.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.Color.White;
            this.btnUno.Location = new System.Drawing.Point(12, 310);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(69, 60);
            this.btnUno.TabIndex = 2;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.DarkRed;
            this.btnDos.Enabled = false;
            this.btnDos.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.Color.White;
            this.btnDos.Location = new System.Drawing.Point(87, 310);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(69, 60);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.DarkRed;
            this.btnTres.Enabled = false;
            this.btnTres.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(162, 310);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(69, 60);
            this.btnTres.TabIndex = 2;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.DarkRed;
            this.btnCero.Enabled = false;
            this.btnCero.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.Color.White;
            this.btnCero.Location = new System.Drawing.Point(12, 376);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(219, 60);
            this.btnCero.TabIndex = 2;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.DarkRed;
            this.btnMultiplicacion.Enabled = false;
            this.btnMultiplicacion.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacion.Location = new System.Drawing.Point(237, 178);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(69, 60);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DarkRed;
            this.btnDivision.Enabled = false;
            this.btnDivision.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(312, 178);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(69, 60);
            this.btnDivision.TabIndex = 2;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.DarkRed;
            this.btnSuma.Enabled = false;
            this.btnSuma.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(237, 244);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(69, 60);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.DarkRed;
            this.btnResta.Enabled = false;
            this.btnResta.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.White;
            this.btnResta.Location = new System.Drawing.Point(312, 244);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(69, 60);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.DarkRed;
            this.btnIgual.Enabled = false;
            this.btnIgual.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(237, 376);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(144, 60);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnNegativo
            // 
            this.btnNegativo.BackColor = System.Drawing.Color.DarkRed;
            this.btnNegativo.Enabled = false;
            this.btnNegativo.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativo.ForeColor = System.Drawing.Color.White;
            this.btnNegativo.Location = new System.Drawing.Point(237, 310);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(69, 60);
            this.btnNegativo.TabIndex = 2;
            this.btnNegativo.Text = "+/-";
            this.btnNegativo.UseVisualStyleBackColor = false;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // btnDecimales
            // 
            this.btnDecimales.BackColor = System.Drawing.Color.DarkRed;
            this.btnDecimales.Enabled = false;
            this.btnDecimales.Font = new System.Drawing.Font("OCR-A BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimales.ForeColor = System.Drawing.Color.White;
            this.btnDecimales.Location = new System.Drawing.Point(312, 310);
            this.btnDecimales.Name = "btnDecimales";
            this.btnDecimales.Size = new System.Drawing.Size(69, 60);
            this.btnDecimales.TabIndex = 2;
            this.btnDecimales.Text = ".";
            this.btnDecimales.UseVisualStyleBackColor = false;
            this.btnDecimales.Click += new System.EventHandler(this.btnDecimales_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(394, 451);
            this.Controls.Add(this.btnDecimales);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.P1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label lblencabezado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnDecimales;
    }
}

