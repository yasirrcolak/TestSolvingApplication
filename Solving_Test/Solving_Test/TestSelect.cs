using System;
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
    public partial class TestSelect : Form
    {
        public TestSelect()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test Select page is loaded method.
        /// Test Seçimi sayfası yüklendi methodu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestSelect_Load(object sender, EventArgs e)
        {
            Welcome.TestNamesRead(comboBox1);
            
            // if comboBox text is not null, 
            if (comboBox1.Text != null)
            {
                // button2 is start solving button (ÇÖZMEYE BAŞLA). 
                button2.Enabled = true;
            }
        }

        /// <summary>
        /// Start Solving button. Go to Solve Question page
        /// Çözmeye Başla butonu. Soru çözümü sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // comboBox1 is Test names comboBox.
            Welcome.currentTest = comboBox1.Text;
            SolveQuestion solveQuestionpage = new SolveQuestion();
            solveQuestionpage.Show();
            this.Hide();


            /*
            if ()
            {
                solveQuestionpage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Böyle bir sınav bulunmamaktadır!");

            }
            */

        }

        /// <summary>
        /// Back button. Go to guidance page.
        /// Geri Butonu. Yönlendirme sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Guidance guidancePack = new Guidance();
            guidancePack.Show();
            this.Hide();
        }
    }
}
