using System.Data;
namespace WinFormsApp1;

public partial class Form1 : Form
{
    string expressao = "";// String que conterá a expressao numerica a ser calculada
    bool igual = false;// Booleano que armazena informacao caso o botao igual seja pressionado
    char[] operadores = new char[] { '+', '-', '/', '*', '%' };// array de operadores para modelagem de string
    public double Calcular(string expression)//Metodo que realiza o calculo utiliza um objeto da biblioteca System.Data Datatable
    {
        DataTable dt = new DataTable();
        return Convert.ToDouble(dt.Compute(expression, ""));//utiliza o metodo compute para realizar o calculo
    }
    public Form1()
    {
        InitializeComponent();
    }
    private void AtualizarResultado()
    {
        // Verifica se a expressão contém um operador no final e se a expressão não está vazia.
        if (expressao.LastIndexOfAny(operadores) == expressao.Length - 1 && expressao != "")
        {
            // Remove o operador do texto exibido na tela da conta e nao realiza a conta para evitar excecoes.
            txtresultado.Text = txtconta.Text.Remove(txtconta.Text.Length - 1);
        }
        // Verifica se a expressão está vazia.
        else if (expressao == "")
        {
            // Define o texto exibido na tela de resultado como vazio e nao realiza a conta para evitar excecoes..
            txtresultado.Text = "";
        }
        else
        {
            // Chama a função Calcular para calcular o resultado da expressão e exibi-lo na tela.
            txtresultado.Text = Calcular(expressao).ToString();
        }
    }

    private void botao0_Click(object sender, EventArgs e)
    {
        // Verifica se o último botão pressionado foi o botão "Igual".
        if (igual)
        {
            // Reverte as mudancas feitas na fonte quando a tecla igual foi pressionada.
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            // Define o texto exibido na tela da conta e do resultado como vazio.
            txtconta.Text = "";
            txtresultado.Text = "";
            // Define a variável igual como false.
            igual = false;
        }
        // Adiciona o número ao texto exibido na tela do resultado.
        txtresultado.Text += "0";
        // Adiciona o número ao texto exibido na tela da conta.
        txtconta.Text += "0";
        // Adiciona o número à expressão.
        expressao += "0";
        // Atualiza o resultado exibido na tela.
        AtualizarResultado();
    }


    private void botao1_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";

        }
        txtresultado.Text += "1";
        txtconta.Text += "1";
        expressao += "1";
        AtualizarResultado();
    }

    private void botao2_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "2";
        txtconta.Text += "2";
        expressao += "2";
        AtualizarResultado();
    }

    private void botao3_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "3";
        txtconta.Text += "3";
        expressao += "3";
        AtualizarResultado();
    }

    private void botao4_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "4";
        txtconta.Text += "4";
        expressao += "4";
        AtualizarResultado();
    }

    private void botao5_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "5";
        txtconta.Text += "5";
        expressao += "5";
        AtualizarResultado();
    }

    private void botao6_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "6";
        txtconta.Text += "6";
        expressao += "6";
        AtualizarResultado();
    }

    private void botao7_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "7";
        txtconta.Text += "7";
        expressao += "7";
        AtualizarResultado();
    }

    private void botao8_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "8";
        txtconta.Text += "8";
        expressao += "8";
        AtualizarResultado();
    }

    private void botao9_Click(object sender, EventArgs e)
    {
        if (igual)
        {
            txtconta.Font = new Font(txtconta.Font.FontFamily, 14.25f);
            txtresultado.Font = new Font(txtresultado.Font.FontFamily, 38.25f, FontStyle.Regular);
            txtconta.Text = "";
            txtresultado.Text = "";
        }
        txtresultado.Text += "9";
        txtconta.Text += "9";
        expressao += "9";
        AtualizarResultado();
    }

    private void botaovirgula_Click(object sender, EventArgs e)
    {
        txtresultado.Text += ",";
        txtconta.Text += ",";
        expressao += ".";
    }

    private void botaoadicao_Click(object sender, EventArgs e)
    {
        txtconta.Text += "+";
        expressao += "+";
    }

    private void botaomenos_Click(object sender, EventArgs e)
    {
        txtconta.Text += "-";
        expressao += "-";
    }

    private void botaovezes_Click(object sender, EventArgs e)
    {
        txtconta.Text += "x";
        expressao += "*";
    }

    private void botaodivisao_Click(object sender, EventArgs e)
    {
        txtconta.Text += "÷";
        expressao += "/";
    }

    // Método chamado quando o botão "=" é clicado
    private void botaoigual_Click(object sender, EventArgs e)
    {
        // Define a variável "igual" como true, indicando que o resultado deve ser exibido
        igual = true;
        // Define o tamanho da fonte do campo de conta e resultado, aumentando o destaque para o resultado
        txtconta.Font = new Font(txtconta.Font.FontFamily, 10);
        txtresultado.Font = new Font(txtresultado.Font.FontFamily, 50, FontStyle.Bold);
        // Adiciona o sinal "=" antes do resultado exibido
        txtresultado.Text = "= " + txtresultado.Text;
    }

    //Método que limpa todas as strings existentes
    private void botaoC_Click(object sender, EventArgs e)
    {
        txtconta.Text = "";
        txtresultado.Text = "";
        expressao = "";
    }
    //Método que deleta o ultimo char das strings e atualiza o resultado
    private void botaobackspace_Click(object sender, EventArgs e)
    {
        txtconta.Text = txtconta.Text.Remove(txtconta.Text.Length - 1);
        expressao = expressao.Remove(expressao.Length - 1);
        AtualizarResultado();
    }
    //Método que divide por cem (porcentagem)
    private void botaopotencia_Click(object sender, EventArgs e)//Errata: Porcentagem
    {
        txtconta.Text += "%";
        expressao += "/100";
        AtualizarResultado();
    }
}