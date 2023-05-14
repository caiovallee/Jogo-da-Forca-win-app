namespace Jogo_da_Forca
{
    public partial class Form1 : Form
    {
        private Forca jogoDaForca;
        public Form1()
        {
            InitializeComponent();
            TxtStatusFinal.Text = " ";
            RegistrarEventos();
            jogoDaForca = new Forca();
            ObterPalavraparcial();
            ObterDicaPalavra();
        }


        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
        }

        private void button24_Click(object sender, EventArgs e)
        {
        }

        private void button22_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Pbforca_Click(object sender, EventArgs e)
        {

        }

        private void LblPalavraSecreta_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void ObterPalavraparcial()
        {
            LblPalavraSecreta.Text = jogoDaForca.PalavraParcial;
        }
        private void ObterDicaPalavra()
        {
            lblDica.Text = jogoDaForca.QuantidadeLetras + " Letras";
        }

        private void RegistrarEventos()
        {
            foreach (Button botao in pnlBotoes.Controls)
            {
                botao.Click += DarPalpite;
                botao.Click += AtualizarBotoesPainel;
            }
            btnReset.Click += ReniciarJogo;
        }

        private void ReniciarJogo(object? sender, EventArgs e)
        {
            jogoDaForca = new Forca();
            ObterPalavraparcial();
            ObterDicaPalavra();
            TxtStatusFinal.Text = " ";
            pnlBotoes.Enabled = true;
           foreach(Button botao in pnlBotoes.Controls)
            {
                botao.Enabled = true;
            }
            Atualizarforca();
                     
            
        }

        

        private void AtualizarBotoesPainel(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            botaoClicado.Enabled = false;
        }

        private void DarPalpite(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            char palpite = botaoClicado.Text[0];

            if (jogoDaForca.JogadorAcertou(palpite) || jogoDaForca.JogadorPerdeu())
            {
                FinalizarJogo(palpite);
            }

            ObterPalavraparcial();

            Atualizarforca();

        }

        private void FinalizarJogo(char palpite)
        {
            if (jogoDaForca.JogadorPerdeu())
            {
                TxtStatusFinal.ForeColor = Color.Red;
            }
            else if (jogoDaForca.JogadorAcertou(palpite))
            {
                TxtStatusFinal.ForeColor = Color.Green;
            }
            pnlBotoes.Enabled = false;
            TxtStatusFinal.Text = jogoDaForca.mensagemFinal;
        }

        private void Atualizarforca()
        {
            switch (jogoDaForca.Erros)
            {
                case 0: Pbforca.Image = Properties.Resources.Forca1; break;
                case 1: Pbforca.Image = Properties.Resources.Forca2; break;
                case 2: Pbforca.Image = Properties.Resources.Forca3; break;
                case 3: Pbforca.Image = Properties.Resources.Forca4; break;
                case 4: Pbforca.Image = Properties.Resources.Forca5; break;
                
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StatusMensagem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStatusFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}