using AliParser.Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbFrom.SelectedItem = "Aliexpress";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Выводить информацию о логе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Log.Text = $"Лог [{rtbLog.Lines.Count()}]";
        }

        /// <summary>
        /// От какой страницы парсить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numPageBegin_ValueChanged(object sender, EventArgs e)
        {
            rbtnRange.Text = $"С {numPageBegin.Value} страницу по {numPageEnd.Value} страницу";
        }

        /// <summary>
        /// По какую страницу парсить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numPageEnd_ValueChanged(object sender, EventArgs e)
        {
            rbtnRange.Text = $"С {numPageBegin.Value} страницу по {numPageEnd.Value} страницу";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string response = Aliexpress.GetPage(txtUrl.Text);
            //string response = Aliexpress.GetPage("https://www.avito.ru/moskva/mototsikly_i_mototehnika?cd=1&radius=0");
            string parsing = Aliexpress.ParsTover(response);
            rtbLog.Text = parsing;
            
        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
