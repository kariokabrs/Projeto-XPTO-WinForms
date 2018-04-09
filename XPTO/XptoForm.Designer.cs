namespace XPTO
{
    partial class XptoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGerarDV = new System.Windows.Forms.Button();
            this.btnVerificarMatriculas = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGerarDV
            // 
            this.btnGerarDV.Location = new System.Drawing.Point(114, 131);
            this.btnGerarDV.Name = "btnGerarDV";
            this.btnGerarDV.Size = new System.Drawing.Size(161, 176);
            this.btnGerarDV.TabIndex = 0;
            this.btnGerarDV.Text = "Gerar DV";
            this.toolTip1.SetToolTip(this.btnGerarDV, "Lê um arquivo localizado no próprio programa e gera um arquivo de saída com os DV" +
        " gerados. ");
            this.btnGerarDV.UseVisualStyleBackColor = true;
            this.btnGerarDV.Click += new System.EventHandler(this.btnGerarDV_Click);
            // 
            // btnVerificarMatriculas
            // 
            this.btnVerificarMatriculas.Location = new System.Drawing.Point(362, 131);
            this.btnVerificarMatriculas.Name = "btnVerificarMatriculas";
            this.btnVerificarMatriculas.Size = new System.Drawing.Size(161, 176);
            this.btnVerificarMatriculas.TabIndex = 1;
            this.btnVerificarMatriculas.Text = "Verificar Matriculas";
            this.toolTip1.SetToolTip(this.btnVerificarMatriculas, "Verifica um arquivo no próprio programa se os DV são válidos.  ");
            this.btnVerificarMatriculas.UseVisualStyleBackColor = true;
            this.btnVerificarMatriculas.Click += new System.EventHandler(this.btnVerificarMatriculas_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(176, 69);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(285, 13);
            this.lblPrincipal.TabIndex = 2;
            this.lblPrincipal.Text = "Programa para Geração e Verificação de Dígito Verificador";
            // 
            // XptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 373);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.btnVerificarMatriculas);
            this.Controls.Add(this.btnGerarDV);
            this.Name = "XptoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarDV;
        private System.Windows.Forms.Button btnVerificarMatriculas;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

