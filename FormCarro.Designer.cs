
namespace Atividade07
{
    partial class FormCarro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lvPeças = new System.Windows.Forms.ListView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPeças = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Descrição = new System.Windows.Forms.ColumnHeader();
            this.Valor = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(120, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CarStop";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvPeças
            // 
            this.lvPeças.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Descrição,
            this.Valor});
            this.lvPeças.HideSelection = false;
            this.lvPeças.Location = new System.Drawing.Point(12, 152);
            this.lvPeças.Name = "lvPeças";
            this.lvPeças.Size = new System.Drawing.Size(306, 165);
            this.lvPeças.TabIndex = 1;
            this.lvPeças.UseCompatibleStateImageBehavior = false;
            this.lvPeças.View = System.Windows.Forms.View.Details;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(5, 63);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(109, 15);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo do veículo:";
            // 
            // lblPeças
            // 
            this.lblPeças.AutoSize = true;
            this.lblPeças.Location = new System.Drawing.Point(12, 134);
            this.lblPeças.Name = "lblPeças";
            this.lblPeças.Size = new System.Drawing.Size(102, 15);
            this.lblPeças.TabIndex = 4;
            this.lblPeças.Text = "Peças disponíveis:";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(131, 89);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 43);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 180;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // FormCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 334);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lblPeças);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lvPeças);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormCarro";
            this.Text = "FormCarro";
            this.Load += new System.EventHandler(this.FormCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListView lvPeças;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPeças;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader Valor;
    }
}