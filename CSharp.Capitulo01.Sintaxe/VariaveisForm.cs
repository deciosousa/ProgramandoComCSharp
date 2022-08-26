using System;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Sintaxe
{
    public partial class VariaveisForm : Form
    {
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
    }
}
