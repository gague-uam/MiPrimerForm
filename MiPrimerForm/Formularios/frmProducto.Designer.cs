namespace MiPrimerForm.Formularios
{
    partial class frmProducto
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
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabRegistros = new System.Windows.Forms.TabControl();
            this.CbIVA = new System.Windows.Forms.CheckBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGeneral.SuspendLayout();
            this.tabRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGrid
            // 
            this.tabGrid.Location = new System.Drawing.Point(4, 22);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(681, 320);
            this.tabGrid.TabIndex = 1;
            this.tabGrid.Text = "Registros Guardados";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.CbIVA);
            this.tabGeneral.Controls.Add(this.tbPrice);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.TbName);
            this.tabGeneral.Controls.Add(this.TbCode);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(681, 320);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Datos del Producto";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabRegistros
            // 
            this.tabRegistros.Controls.Add(this.tabGeneral);
            this.tabRegistros.Controls.Add(this.tabGrid);
            this.tabRegistros.Location = new System.Drawing.Point(46, 38);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.SelectedIndex = 0;
            this.tabRegistros.Size = new System.Drawing.Size(689, 346);
            this.tabRegistros.TabIndex = 0;
            // 
            // CbIVA
            // 
            this.CbIVA.AutoSize = true;
            this.CbIVA.Location = new System.Drawing.Point(68, 133);
            this.CbIVA.Name = "CbIVA";
            this.CbIVA.Size = new System.Drawing.Size(75, 17);
            this.CbIVA.TabIndex = 13;
            this.CbIVA.Text = "Aplica IVA";
            this.CbIVA.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(64, 92);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(103, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio:";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(64, 60);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(228, 20);
            this.TbName.TabIndex = 10;
            // 
            // TbCode
            // 
            this.TbCode.Location = new System.Drawing.Point(64, 31);
            this.TbCode.Name = "TbCode";
            this.TbCode.Size = new System.Drawing.Size(228, 20);
            this.TbCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabRegistros);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabRegistros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabControl tabRegistros;
        private System.Windows.Forms.CheckBox CbIVA;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}