using System;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;
     
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -------- CRIAÇÃO DE VARIÁVEIS ------

            int x = 42;
            int X = 10;

            string nome = "Décio";
            char letra = 'a';
            bool aprovado = true;
            aprovado = false; // não é necessário criar a variável novamente para utilizá-la.

            DateTime dataNascimento = new DateTime(2000,1,1);

            var a = 2; // a palavra reservada 'var' usa a inferência de tipo
            var b = 6;
            var c = 10;
            var d = 13;

            // 'var' não pode ser usado sem o conceito de inferência, ou seja, sem o sinal de atribuição (=)

            object meuObjeto = 35; // o 'object' é flexível em relação aos tipos de dados que podem ser usados.
            meuObjeto = "Décio";
            meuObjeto = false;

            // -------- FRACIONÁRIOS ------

            var valor = 7.8m; // a letra 'm' é usada para criar variáveis do tipo decimal.

            // o 'float' e o 'double' não se indicados para trabalhar com valores monetários, por não realizarem o arredondamento adequadamente. Para valores decimais é recomendado o uso de 'decimal'.

            var bimestre1 = 5.9m;

            // -------- INICIALIZAR MÚLTIPLAS VARIÁVEIS ------
            int numero = 11, outroNumero = 12, esseNumero = 14; // é possível inicializar múltiplas variáveis na mesma linha, desde que todas sejam do mesmo tipo. Esta não é uma boa prática.

            // -------- CONCATENAR ------
            resultadoListBox.Items.Add("a="+a); // 'items' é característica e 'Add' é método (ação / verbo no infinitivo).
            resultadoListBox.Items.Add(string.Concat("b=",b)); 
            resultadoListBox.Items.Add(string.Format("c={0}",c)); 
            //resultadoListBox.Items.Add(string.Format("c={0}-d={1}",c,d));
            resultadoListBox.Items.Add($"d={d}");

            // -------- OPERAÇÕES ARITMÉTICAS ------

            resultadoListBox.Items.Add($"c*d={c*d}");
            resultadoListBox.Items.Add($"d/a={d/a}");
            resultadoListBox.Items.Add($"d%a={d%a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -------- OPERAÇÕES ARITMÉTICAS COM NOTAÇÃO REDUZIDA ------
            var x = 5;
            resultadoListBox.Items.Add("x=" + x);

            x = x - 3;
            x -= 3; // essa é a escrita abreviada/reduzida. Vbale para outras operações aritméticas.
            resultadoListBox.Items.Add("x=" + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -------- OPERADORES INCREMENTAIS E DECREMENTAIS ------
            int a;

            //pré-incremental
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultadoListBox.Items.Add("a = " + a);

            //pós-incremental
            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // -------- BOOLEANAS ------

            var d = 32.0;

            ExibirValores();

            resultadoListBox.Items.Add($"w<=x={w <= x}");
            resultadoListBox.Items.Add($"x==z={x == z}");
            resultadoListBox.Items.Add($"x!=z={x != z}");
            resultadoListBox.Items.Add($"x==d={x == d}");
        }

        private void ExibirValores()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("z = " + z);
            resultadoListBox.Items.Add("-------------------------------------");
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValores();

            resultadoListBox.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"x == z && x != z = {x == z && x!= z}");
            resultadoListBox.Items.Add($"!(y>w) = {!(y > w)}");
        }

        private void ternariasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // -------- TERNÁRIAS ------

            int ano;

            ano = 2014;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto?{(ano % 4 == 0 ? "sim" : "não")}.");

            ano = 2016;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto?{(DateTime.IsLeapYear(ano) ? "sim" : "não")}.");

            // O operador ternário gera um código mais curto. A mesma operação com 'if' 'else' seria da seguinte forma:
            //var resposta = "";
            //if (DateTime.IsLeapYear(ano))
            //{
            //    resposta = "sim";
            //}
            //else
            //{
            //    resposta = "não";
            //}
        }
    }
}
