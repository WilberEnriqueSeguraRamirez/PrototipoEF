
namespace Vista
{
    partial class frmCuenta
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtIdTc = new System.Windows.Forms.TextBox();
            this.tstC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtSa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bntEnviar = new System.Windows.Forms.Button();
            this.dvgTipo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(188, 134);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtIdTc
            // 
            this.txtIdTc.Location = new System.Drawing.Point(188, 195);
            this.txtIdTc.Name = "txtIdTc";
            this.txtIdTc.Size = new System.Drawing.Size(100, 22);
            this.txtIdTc.TabIndex = 2;
            // 
            // tstC
            // 
            this.tstC.Location = new System.Drawing.Point(188, 257);
            this.tstC.Name = "tstC";
            this.tstC.Size = new System.Drawing.Size(100, 22);
            this.tstC.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(188, 322);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            // 
            // txtSa
            // 
            this.txtSa.Location = new System.Drawing.Point(188, 371);
            this.txtSa.Name = "txtSa";
            this.txtSa.Size = new System.Drawing.Size(100, 22);
            this.txtSa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID Tipo Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Abono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Saldo Acumulado";
            // 
            // bntEnviar
            // 
            this.bntEnviar.Location = new System.Drawing.Point(183, 425);
            this.bntEnviar.Name = "bntEnviar";
            this.bntEnviar.Size = new System.Drawing.Size(105, 48);
            this.bntEnviar.TabIndex = 12;
            this.bntEnviar.Text = "Enviar";
            this.bntEnviar.UseVisualStyleBackColor = true;
            this.bntEnviar.Click += new System.EventHandler(this.bntEnviar_Click);
            // 
            // dvgTipo
            // 
            this.dvgTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTipo.Location = new System.Drawing.Point(367, 62);
            this.dvgTipo.Name = "dvgTipo";
            this.dvgTipo.RowHeadersWidth = 51;
            this.dvgTipo.RowTemplate.Height = 24;
            this.dvgTipo.Size = new System.Drawing.Size(943, 477);
            this.dvgTipo.TabIndex = 13;
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 566);
            this.Controls.Add(this.dvgTipo);
            this.Controls.Add(this.bntEnviar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSa);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.tstC);
            this.Controls.Add(this.txtIdTc);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtID);
            this.Name = "frmCuenta";
            this.Text = "frmCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtIdTc;
        private System.Windows.Forms.TextBox tstC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtSa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntEnviar;
        private System.Windows.Forms.DataGridView dvgTipo;
    }
}