
namespace Vista
{
    partial class frmDarDeBaja
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
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dvgTipo = new System.Windows.Forms.DataGridView();
            this.btnBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaja
            // 
            this.txtBaja.Location = new System.Drawing.Point(236, 66);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(100, 22);
            this.txtBaja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese ID para Borrar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(43, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dvgTipo
            // 
            this.dvgTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTipo.Location = new System.Drawing.Point(383, 94);
            this.dvgTipo.Name = "dvgTipo";
            this.dvgTipo.RowHeadersWidth = 51;
            this.dvgTipo.RowTemplate.Height = 24;
            this.dvgTipo.Size = new System.Drawing.Size(518, 150);
            this.dvgTipo.TabIndex = 3;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(575, 262);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(128, 37);
            this.btnBaja.TabIndex = 4;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // frmDarDeBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 311);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dvgTipo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaja);
            this.Name = "frmDarDeBaja";
            this.Text = "frmDarDeBaja";
            ((System.ComponentModel.ISupportInitialize)(this.dvgTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dvgTipo;
        private System.Windows.Forms.Button btnBaja;
    }
}