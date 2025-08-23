namespace Formulario4
{
    partial class Formulario4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LDesde = new Label();
            LHasta = new Label();
            tDesde = new TextBox();
            tHasta = new TextBox();
            bGenFucion = new Button();
            lListaNros = new Label();
            lbxListNros = new ListBox();
            bPar = new Button();
            bImpar = new Button();
            bPrimos = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(21, 86);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 0;
            LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(21, 124);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta";
            // 
            // tDesde
            // 
            tDesde.Location = new Point(79, 83);
            tDesde.Name = "tDesde";
            tDesde.Size = new Size(100, 23);
            tDesde.TabIndex = 2;
            // 
            // tHasta
            // 
            tHasta.Location = new Point(79, 121);
            tHasta.Name = "tHasta";
            tHasta.Size = new Size(100, 23);
            tHasta.TabIndex = 3;
            // 
            // bGenFucion
            // 
            bGenFucion.Location = new Point(42, 167);
            bGenFucion.Name = "bGenFucion";
            bGenFucion.Size = new Size(99, 23);
            bGenFucion.TabIndex = 4;
            bGenFucion.Text = "Genere Fución";
            bGenFucion.UseVisualStyleBackColor = true;
            bGenFucion.Click += bGenFucion_Click;
            // 
            // lListaNros
            // 
            lListaNros.AutoSize = true;
            lListaNros.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lListaNros.Location = new Point(123, 31);
            lListaNros.Name = "lListaNros";
            lListaNros.Size = new Size(166, 25);
            lListaNros.TabIndex = 5;
            lListaNros.Text = "Lista de Números";
            lListaNros.Click += lListaNros_Click;
            // 
            // lbxListNros
            // 
            lbxListNros.FormattingEnabled = true;
            lbxListNros.ItemHeight = 15;
            lbxListNros.Location = new Point(243, 83);
            lbxListNros.Name = "lbxListNros";
            lbxListNros.Size = new Size(148, 199);
            lbxListNros.TabIndex = 6;
            lbxListNros.SelectedIndexChanged += lbxListNros_SelectedIndexChanged;
            // 
            // bPar
            // 
            bPar.Location = new Point(52, 208);
            bPar.Name = "bPar";
            bPar.Size = new Size(75, 23);
            bPar.TabIndex = 7;
            bPar.Text = "Pares";
            bPar.UseVisualStyleBackColor = true;
            bPar.Click += bPar_Click;
            // 
            // bImpar
            // 
            bImpar.Location = new Point(52, 249);
            bImpar.Name = "bImpar";
            bImpar.Size = new Size(75, 23);
            bImpar.TabIndex = 8;
            bImpar.Text = "Impares";
            bImpar.UseVisualStyleBackColor = true;
            bImpar.Click += bImpar_Click;
            // 
            // bPrimos
            // 
            bPrimos.Location = new Point(52, 290);
            bPrimos.Name = "bPrimos";
            bPrimos.Size = new Size(75, 23);
            bPrimos.TabIndex = 9;
            bPrimos.Text = "Primos";
            bPrimos.UseVisualStyleBackColor = true;
            bPrimos.Click += bPrimos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lListaNros);
            panel1.Controls.Add(bPrimos);
            panel1.Controls.Add(lbxListNros);
            panel1.Controls.Add(bImpar);
            panel1.Controls.Add(tDesde);
            panel1.Controls.Add(bPar);
            panel1.Controls.Add(LDesde);
            panel1.Controls.Add(bGenFucion);
            panel1.Controls.Add(LHasta);
            panel1.Controls.Add(tHasta);
            panel1.Location = new Point(31, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 356);
            panel1.TabIndex = 10;
            // 
            // Formulario4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Formulario4";
            Text = "Formulario4";
            Load += Formulario4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LDesde;
        private Label LHasta;
        private TextBox tDesde;
        private TextBox tHasta;
        private Button bGenFucion;
        private Label lListaNros;
        private ListBox lbxListNros;
        private Button bPar;
        private Button bImpar;
        private Button bPrimos;
        private Panel panel1;
    }
}
