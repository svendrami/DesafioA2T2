using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioA2T2
{
    public partial class Form1 : Form
    {

        public int counterSim = 0;
        public int counterNao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Você clicou em SIM");
            //incrementar o contador sim
            counterSim += 1;
            updateCountersLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você clicou em Não");
            //incrementar o contador não
            counterNao += 1;
            updateCountersLabels();
        }

        private void updateCountersLabels()
        {
            counterSimLbl.Text = counterSim.ToString();
            counterNaoLbl.Text = counterNao.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
