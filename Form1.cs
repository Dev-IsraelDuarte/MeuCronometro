using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace MeuCronometro // Se você usou outro nome no Passo 1, mantenha o seu nome aqui!
{
    public partial class Form1 : Form
    {
        // 1. Criamos a nossa variável principal do tipo Stopwatch
        private Stopwatch cronometro;
        public Form1()
        {
            InitializeComponent();
            // Inicializamos o Stopwatch quando o programa abre
            cronometro = new Stopwatch();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            cronometro.Start(); // Começa a contar o tempo real
            timer1.Start(); // Começa a atualizar a tela
        }
        private void btnPausar_Click(object sender, EventArgs e)
        {
            cronometro.Stop(); // Pausa a contagem
            timer1.Stop(); // Pausa a atualização da tela
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            cronometro.Reset(); // Zera o contador interno
            lblTempo.Text = "00:00:00.000"; // Zera a tela
            lstVoltas.Items.Clear(); // Limpa o histórico de voltas (Opcional)

        }
        private void btnVolta_Click(object sender, EventArgs e)
        {
            // Pega o tempo que está no Label agora e adiciona como um item na lista
            if (cronometro.IsRunning)
            {
                int numeroDaVolta = lstVoltas.Items.Count + 1;
                lstVoltas.Items.Add($"Volta {numeroDaVolta}: {lblTempo.Text}");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Este método roda a cada 10 milissegundos
            TimeSpan tempo = cronometro.Elapsed;
            // Formatamos a exibição para Horas:Minutos:Segundos.Milissegundos
            lblTempo.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            tempo.Hours,
            tempo.Minutes,
            tempo.Seconds,
            tempo.Milliseconds);
        }
    }
}