namespace Ejercicio_1
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
            tbDNI = new TextBox();
            tbNOMBRE = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nAceptar = new Button();
            btncancelar = new Button();
            SuspendLayout();
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(156, 16);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(125, 27);
            tbDNI.TabIndex = 0;
            // 
            // tbNOMBRE
            // 
            tbNOMBRE.Location = new Point(156, 72);
            tbNOMBRE.Name = "tbNOMBRE";
            tbNOMBRE.Size = new Size(125, 27);
            tbNOMBRE.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // nAceptar
            // 
            nAceptar.DialogResult = DialogResult.OK;
            nAceptar.Location = new Point(12, 128);
            nAceptar.Name = "nAceptar";
            nAceptar.Size = new Size(123, 40);
            nAceptar.TabIndex = 4;
            nAceptar.Text = "Aceptar";
            nAceptar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            btncancelar.CausesValidation = false;
            btncancelar.DialogResult = DialogResult.Cancel;
            btncancelar.Location = new Point(183, 128);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(123, 40);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 181);
            Controls.Add(btncancelar);
            Controls.Add(nAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNOMBRE);
            Controls.Add(tbDNI);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbDNI;
        public TextBox tbNOMBRE;
        private Label label1;
        private Label label2;
        private Button nAceptar;
        private Button btncancelar;
    }
}