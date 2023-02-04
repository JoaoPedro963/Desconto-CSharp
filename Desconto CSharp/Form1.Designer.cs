
namespace Desconto_CSharp
{
    partial class Form1
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValor.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(64, 54);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(157, 21);
            this.txtValor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE UM VALOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(73, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "10% DE DESCONTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.Font = new System.Drawing.Font("OCR-A BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnCalcular.Location = new System.Drawing.Point(88, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValorDesconto.Font = new System.Drawing.Font("OCR-A BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.Location = new System.Drawing.Point(64, 117);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(157, 21);
            this.txtValorDesconto.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(279, 236);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorDesconto;
    }
}

