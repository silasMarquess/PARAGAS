using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using gasProject.dao;
using MySql.Data.MySqlClient;

namespace gasProject
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
               /* DBConexao._conexao = new MySqlConnection(gasProject.Properties.Resources.URL);
                DBConexao.OpenConexao();
                MessageBox.Show("Testde de conexao bem sucedido");*/

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
