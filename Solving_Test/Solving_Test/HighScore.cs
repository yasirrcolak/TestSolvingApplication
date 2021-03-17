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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Back Button. Go to guidance page.
        /// Geri Butonu. Yönlendirme sayfasına gider.
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
        /// High Score page is loaded method.
        /// Yüksek puanlar sayfası yüklendi methodu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScore_Load(object sender, EventArgs e)
        {
            Welcome.HighScoreRead(listBox1);
        }
    }
}
