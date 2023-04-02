namespace atv._2023
{
    partial class Form2
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
            this.lbllitro = new System.Windows.Forms.Label();
            this.lblalc = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtalc = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllitro
            // 
            this.lbllitro.AutoSize = true;
            this.lbllitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllitro.Location = new System.Drawing.Point(79, 64);
            this.lbllitro.Name = "lbllitro";
            this.lbllitro.Size = new System.Drawing.Size(246, 24);
            this.lbllitro.TabIndex = 0;
            this.lbllitro.Text = "Digite a quantidade de litros:";
            // 
            // lblalc
            // 
            this.lblalc.AutoSize = true;
            this.lblalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalc.Location = new System.Drawing.Point(79, 151);
            this.lblalc.Name = "lblalc";
            this.lblalc.Size = new System.Drawing.Size(357, 24);
            this.lblalc.TabIndex = 1;
            this.lblalc.Text = "Digite \"G\" para gasolina e \"A\" para alcool:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(79, 237);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(195, 24);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "O preço a pagar é de:";
            // 
            // txtlitros
            // 
            this.txtlitros.Location = new System.Drawing.Point(83, 100);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(220, 20);
            this.txtlitros.TabIndex = 3;
            // 
            // txtalc
            // 
            this.txtalc.Location = new System.Drawing.Point(83, 188);
            this.txtalc.Name = "txtalc";
            this.txtalc.Size = new System.Drawing.Size(220, 20);
            this.txtalc.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(104, 360);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(154, 41);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(296, 360);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(154, 41);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(486, 360);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(162, 40);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(83, 277);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(220, 20);
            this.txtresult.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtalc);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblalc);
            this.Controls.Add(this.lbllitro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllitro;
        private System.Windows.Forms.Label lblalc;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtalc;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtresult;
    }
}