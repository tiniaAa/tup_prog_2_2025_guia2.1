namespace Ejercicio_1
{
    partial class Form1
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
            lbxListar = new ListBox();
            btnRegistrar = new Button();
            btnListar = new Button();
            tbRegistrar = new TextBox();
            SuspendLayout();
            // 
            // lbxListar
            // 
            lbxListar.FormattingEnabled = true;
            lbxListar.Location = new Point(34, 232);
            lbxListar.Name = "lbxListar";
            lbxListar.Size = new Size(319, 144);
            lbxListar.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(426, 75);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(148, 49);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(426, 273);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(148, 51);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // tbRegistrar
            // 
            tbRegistrar.Location = new Point(34, 34);
            tbRegistrar.Multiline = true;
            tbRegistrar.Name = "tbRegistrar";
            tbRegistrar.Size = new Size(319, 137);
            tbRegistrar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 392);
            Controls.Add(tbRegistrar);
            Controls.Add(btnListar);
            Controls.Add(btnRegistrar);
            Controls.Add(lbxListar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxListar;
        private Button btnRegistrar;
        private Button btnListar;
        private TextBox tbRegistrar;
    }
}
