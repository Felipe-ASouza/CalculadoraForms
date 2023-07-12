namespace CalculadorInterface
{
    public partial class Form1 : Form
    {

        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = ""; //Atrivuir o resultado vazio no campo do resultado para adicionar o segundo número;

        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = ""; //Atrivuir o resultado vazio no campo do resultado para adicionar o segundo número;
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = ""; //Atrivuir o resultado vazio no campo do resultado para adicionar o segundo número;
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada &= Operacao.Divisao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = ""; //Atrivuir o resultado vazio no campo do resultado para adicionar o segundo número;
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(TxtResultado.Text);
                    break;
            }
            TxtResultado.Text = Convert.ToString(Resultado);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += ",";
        }
    }
}