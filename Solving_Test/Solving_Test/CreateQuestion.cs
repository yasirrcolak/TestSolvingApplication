using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solving_Test
{
    public partial class CreateQuestion : Form
    {
        public CreateQuestion()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Back Button. Got o guidance page.
        /// Geri butonu. yönlendirme sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Guidance guidancePage = new Guidance();
            guidancePage.Show();
            this.Hide();
        }

        /// <summary>
        /// Add Button. this question added is question.txt.
        /// Ekle butonu. soruyu question.txt ye ekler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // comboBox1 is test names.
            Welcome.QuestionWrite(comboBox1,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);
            Welcome.TestNamesWrite(comboBox1);
            MessageBox.Show("Eklendi :)");

            // textBox1 is Question.
            textBox1.Clear();
            // textBox2 is Option A.
            textBox2.Clear();
            // textBox3 is Option B.
            textBox3.Clear();
            // textBox4 is Option C.
            textBox4.Clear();
            // textBox5 is Option D. 
            textBox5.Clear();
            //textBox6 is true Option.
            textBox6.Clear();
        }

        /// <summary>
        /// Create Question page is loaded method.
        /// Soru Yaz sayfası yüklendi methodu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            Welcome.TestNamesRead(comboBox1);
        }

    }
}
