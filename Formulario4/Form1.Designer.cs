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
            SuspendLayout();
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.Location = new Point(67, 57);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(39, 15);
            LDesde.TabIndex = 0;
            LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(67, 110);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(37, 15);
            LHasta.TabIndex = 1;
            LHasta.Text = "Hasta";
            // 
            // tDesde
            // 
            tDesde.Location = new Point(124, 54);
            tDesde.Name = "tDesde";
            tDesde.Size = new Size(100, 23);
            tDesde.TabIndex = 2;
            // 
            // tHasta
            // 
            tHasta.Location = new Point(124, 107);
            tHasta.Name = "tHasta";
            tHasta.Size = new Size(100, 23);
            tHasta.TabIndex = 3;
            // 
            // Formulario4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tHasta);
            Controls.Add(tDesde);
            Controls.Add(LHasta);
            Controls.Add(LDesde);
            Name = "Formulario4";
            Text = "Formulario4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDesde;
        private Label LHasta;
        private TextBox tDesde;
        private TextBox tHasta;
    }
}
