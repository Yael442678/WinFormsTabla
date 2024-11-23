namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonMostrar = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            labelNombre = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 224, 192);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonMostrar);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(12, 14);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(785, 436);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Cursor = Cursors.IBeam;
            richTextBoxResultados.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(192, 188);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(389, 240);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonMostrar
            // 
            buttonMostrar.BackColor = Color.FromArgb(128, 255, 128);
            buttonMostrar.Cursor = Cursors.Hand;
            buttonMostrar.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMostrar.Location = new Point(335, 146);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.RightToLeft = RightToLeft.Yes;
            buttonMostrar.Size = new Size(94, 29);
            buttonMostrar.TabIndex = 3;
            buttonMostrar.Text = "VER";
            buttonMostrar.UseVisualStyleBackColor = false;
            buttonMostrar.Click += buttonMostrar_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.White;
            textBoxNum.Location = new Point(320, 113);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(125, 27);
            textBoxNum.TabIndex = 2;
            textBoxNum.TextAlign = HorizontalAlignment.Center;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = Color.White;
            labelNumero.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(191, 81);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(383, 20);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla de multiplicar deseas?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.White;
            labelTitulo.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(182, 27);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(398, 43);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de multiplicar";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("SimSun", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(295, 12);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(199, 15);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Yael Adonai de Alba Alva";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelNumero;
        private Label labelTitulo;
        private RichTextBox richTextBoxResultados;
        private Button buttonMostrar;
        private TextBox textBoxNum;
        private Label labelNombre;
    }
}
