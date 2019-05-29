namespace Temperatura
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.rdbCF = new System.Windows.Forms.RadioButton();
            this.rdbFC = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(37, 24);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(104, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Insira a Temperatura";
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(40, 40);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(154, 20);
            this.txbTemperatura.TabIndex = 1;
            // 
            // rdbCF
            // 
            this.rdbCF.AutoSize = true;
            this.rdbCF.Checked = true;
            this.rdbCF.Location = new System.Drawing.Point(40, 78);
            this.rdbCF.Name = "rdbCF";
            this.rdbCF.Size = new System.Drawing.Size(117, 17);
            this.rdbCF.TabIndex = 2;
            this.rdbCF.TabStop = true;
            this.rdbCF.Text = "Celsius - Fahrenheit";
            this.rdbCF.UseVisualStyleBackColor = true;
            // 
            // rdbFC
            // 
            this.rdbFC.AutoSize = true;
            this.rdbFC.Location = new System.Drawing.Point(40, 101);
            this.rdbFC.Name = "rdbFC";
            this.rdbFC.Size = new System.Drawing.Size(117, 17);
            this.rdbFC.TabIndex = 3;
            this.rdbFC.Text = "Fahrenheit - Celsius";
            this.rdbFC.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(37, 182);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(52, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resposta";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 229);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbFC);
            this.Controls.Add(this.rdbCF);
            this.Controls.Add(this.txbTemperatura);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "frmPrincipal";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.RadioButton rdbCF;
        private System.Windows.Forms.RadioButton rdbFC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}

