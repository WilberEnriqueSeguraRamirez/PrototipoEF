
namespace Vista
{
    partial class frmConsultaCuentas
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
            this.dvgTipo = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTipo
            // 
            this.dvgTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTipo.Location = new System.Drawing.Point(12, 91);
            this.dvgTipo.Name = "dvgTipo";
            this.dvgTipo.RowHeadersWidth = 51;
            this.dvgTipo.RowTemplate.Height = 24;
            this.dvgTipo.Size = new System.Drawing.Size(1038, 442);
            this.dvgTipo.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(462, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(140, 46);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 545);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dvgTipo);
            this.Name = "frmConsultaCuentas";
            this.Text = "frmConsultaCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTipo;
        private System.Windows.Forms.Button btnConsultar;
    }
}