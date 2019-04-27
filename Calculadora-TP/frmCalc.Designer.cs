namespace Calculadora_TP
{
    partial class frmCalc
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 21);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(115, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(146, 21);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(120, 20);
            this.txtN2.TabIndex = 1;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(12, 73);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(46, 23);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(64, 73);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(46, 23);
            this.btnSubtrai.TabIndex = 3;
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(116, 73);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(46, 23);
            this.btnMulti.TabIndex = 4;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(168, 73);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(46, 23);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnExpo
            // 
            this.btnExpo.Location = new System.Drawing.Point(220, 73);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(46, 23);
            this.btnExpo.TabIndex = 6;
            this.btnExpo.Text = "^";
            this.btnExpo.UseVisualStyleBackColor = true;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(12, 47);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(254, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 120);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "frmCalc";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

