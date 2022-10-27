using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_ClasseMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] matriz = new int[3, 5];
        Matriz m = new Matriz();
        private void btnExibeMat_Click(object sender, EventArgs e)
        {
            m.PreencherMatriz(matriz, 4);
            lblRes.Text = m.ExibirMatriz(matriz);
        }
    }
}