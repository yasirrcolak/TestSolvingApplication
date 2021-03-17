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
    public partial class Guidance : Form
    {
        public Guidance()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create Question Button(SORU YAZ). Go to Create question page. 
        /// Soru Yaz sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            CreateQuestion createQuestionPage = new CreateQuestion();
            createQuestionPage.Show();
            this.Hide();
        }

        /// <summary>
        /// Solve Question Button(SORU ÇÖZ). Go to Test select page.
        /// Test Seçimi sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            TestSelect testSelectPage = new TestSelect();
            testSelectPage.Show();
            this.Hide();
        }

        /// <summary>
        /// Application Quit Button(ÇIKIŞ)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// High Score Button(PUANLARA BAK). Go to High score page.
        /// Yüksek puanlar sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

            HighScore highScorePage = new HighScore();
            highScorePage.Show();
            this.Hide();
        }

        /// <summary>
        /// Guidance page is loaded method.
        /// Yönlendirme sayfası yüklendi methodu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guidance_Load(object sender, EventArgs e)
        {

            // if user type is member, Create question button visible is false;
            if (Welcome.userType == "member")
            {
                // button1 is Create Question button.
                button1.Visible = false;
            }
        }

    }
}
