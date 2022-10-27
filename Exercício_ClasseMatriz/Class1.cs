using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_ClasseMatriz
{
    internal class Matriz
    {
        public void PreencherMatriz(int[,] mat, int multiplo)
        {
            int valor = 0;
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    
                        mat[linha, coluna] = valor;
                  
                }
            }
        }
        public String ExibirMatriz(int[,] mat)
        {
            String strResultado = "";
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    strResultado += mat[linha, coluna] + " ";
                }
                strResultado += "\n";
            }
            return strResultado;
        }
    }
}
