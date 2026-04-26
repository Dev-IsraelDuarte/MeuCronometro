namespace MeuCronometro
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
            components = new System.ComponentModel.Container();
            lblTempo = new Label();
            btnIniciar = new Button();
            btnPausar = new Button();
            btnZerar = new Button();
            btnVolta = new Button();
            lstVoltas = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempo.Location = new Point(122, 17);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(319, 65);
            lblTempo.TabIndex = 0;
            lblTempo.Text = "00:00:00.000";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.GradientInactiveCaption;
            btnIniciar.Location = new Point(122, 122);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausar
            // 
            btnPausar.BackColor = Color.YellowGreen;
            btnPausar.Location = new Point(243, 122);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(75, 23);
            btnPausar.TabIndex = 2;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = false;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnZerar
            // 
            btnZerar.BackColor = Color.FromArgb(0, 192, 0);
            btnZerar.Location = new Point(366, 122);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(75, 23);
            btnZerar.TabIndex = 3;
            btnZerar.Text = "Zerar";
            btnZerar.UseVisualStyleBackColor = false;
            btnZerar.Click += btnZerar_Click;
            // 
            // btnVolta
            // 
            btnVolta.Location = new Point(122, 180);
            btnVolta.Name = "btnVolta";
            btnVolta.Size = new Size(75, 23);
            btnVolta.TabIndex = 4;
            btnVolta.Text = "Marcar Volta";
            btnVolta.UseVisualStyleBackColor = true;
            btnVolta.Click += btnVolta_Click;
            // 
            // lstVoltas
            // 
            lstVoltas.FormattingEnabled = true;
            lstVoltas.Location = new Point(122, 209);
            lstVoltas.Name = "lstVoltas";
            lstVoltas.Size = new Size(319, 154);
            lstVoltas.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 377);
            Controls.Add(lstVoltas);
            Controls.Add(btnVolta);
            Controls.Add(btnZerar);
            Controls.Add(btnPausar);
            Controls.Add(btnIniciar);
            Controls.Add(lblTempo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTempo;
        private Button btnIniciar;
        private Button btnPausar;
        private Button btnZerar;
        private Button btnVolta;
        private ListBox lstVoltas;
        private System.Windows.Forms.Timer timer1;
    }
}
