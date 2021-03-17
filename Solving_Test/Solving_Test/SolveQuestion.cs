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
    public partial class SolveQuestion : Form
    {
        int numberQuestion;

        public SolveQuestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function goes to the next question in the database.
        /// </summary>
        public static void next()
        {
                       
            string a;
            a = Welcome.swQuestionRead.ReadLine();
            a = Welcome.swQuestionRead.ReadLine();
            a = Welcome.swQuestionRead.ReadLine();
            a = Welcome.swQuestionRead.ReadLine();
            a = Welcome.swQuestionRead.ReadLine();
            a = Welcome.swQuestionRead.ReadLine();
            
        }

        /// <summary>
        /// Solve Question page is loaded method.
        /// Soru Çöz sayfası yüklendi methodu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolveQuestion_Load(object sender, EventArgs e)
        {            
         
            // Button6 Next Qustion (SONRAKİ SORU) enabled is false.
            button6.Enabled = false;

            // Button7 Save Score (PUANI KAYDET) enabled is false.
            button7.Enabled = false;

            // checks until the correct question comes up based on the chosen test.
            while (true)
            {

                // if current test is == questions.txt readline 
                if (Welcome.currentTest == Welcome.swQuestionRead.ReadLine())
                {
                    Welcome.QuestionRead(label4, button1, button2, button3, button4);
                    numberQuestion++;
                
                    // label3 is Question number (SORU NUMARASI) 
                    label3.Text = numberQuestion.ToString();

                    break;
                }
                else
                {
                    next();
                }
            }
            

        }

        /// <summary>
        /// Option A Button.
        /// A şıkkı butonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            // trueOption is question.txt readline.  
            string trueOption = Welcome.swQuestionRead.ReadLine();

            // if trueOption is "a" or "A".
            if (trueOption == "a" || trueOption == "A")
            {
                button1.BackColor = Color.Green;
                
                // label1 is Skor.
                Welcome.skor = Convert.ToInt32(label1.Text);
                Welcome.skor += 10;
                label1.Text = Welcome.skor.ToString();
                // button7 is Save score button.
                button7.Enabled = true;   
            }
            else
            {
                button1.BackColor = Color.Red;
            }

            // button1 is optian A (A ŞIKKI)
            button1.Enabled = false;
            // button2 is option B (B ŞIKKI)
            button2.Enabled = false;
            // button3 is option C (C ŞIKKI)
            button3.Enabled = false;
            // button4 is option D (D ŞIKKI)
            button4.Enabled = false;
            // button 6 is next question (SONRAKİ SORU).
            button6.Enabled = true;

        }

        /// <summary>
        /// Option B Button.
        /// B şıkkı butonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            
            // trueOption is question.txt readline.  
            string trueOption = Welcome.swQuestionRead.ReadLine();

            // if trueOption is "b" or "B".
            if (trueOption == "b" || trueOption == "B")
            {
                button2.BackColor = Color.Green;

                // label1 is Skor.
                Welcome.skor = Convert.ToInt32(label1.Text);
                Welcome.skor += 10;
                label1.Text = Welcome.skor.ToString();
                // button7 is Save score button.
                button7.Enabled = true;
            }
            else
            {
                button2.BackColor = Color.Red;
            }

            // button1 is optian A (A ŞIKKI)
            button1.Enabled = false;
            // button2 is option B (B ŞIKKI)
            button2.Enabled = false;
            // button3 is option C (C ŞIKKI)
            button3.Enabled = false;
            // button4 is option D (D ŞIKKI)
            button4.Enabled = false;
            // button 6 is next question (SONRAKİ SORU).
            button6.Enabled = true;

        }

        /// <summary>
        /// Option C Button.
        /// C şıkkı butonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            // trueOption is question.txt readline.
            string trueOption = Welcome.swQuestionRead.ReadLine();

            // if trueOption is "c" or "C".
            if (trueOption == "c" || trueOption == "C")
            {
                button3.BackColor = Color.Green;
 
                // label1 is Skor.
                Welcome.skor = Convert.ToInt32(label1.Text);
                Welcome.skor += 10;
                label1.Text = Welcome.skor.ToString();
                // button7 is Save score button.
                button7.Enabled = true;
            }
            else
            {
                button3.BackColor = Color.Red;
            }

            // button1 is optian A (A ŞIKKI)
            button1.Enabled = false;
            // button2 is option B (B ŞIKKI)
            button2.Enabled = false;
            // button3 is option C (C ŞIKKI)
            button3.Enabled = false;
            // button4 is option D (D ŞIKKI)
            button4.Enabled = false;
            // button 6 is next question (SONRAKİ SORU).
            button6.Enabled = true;
        
        }

        /// <summary>
        /// Option D Button.
        /// D şıkkı butonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

            // trueOption is question.txt readline.
            string trueOption = Welcome.swQuestionRead.ReadLine();

            // if trueOption is "d" or "D".
            if (trueOption == "d" || trueOption == "D")
            {
                button4.BackColor = Color.Green;
                
                // label1 is Skor.
                Welcome.skor = Convert.ToInt32(label1.Text);
                Welcome.skor += 10;
                label1.Text = Welcome.skor.ToString();
                // button7 is Save score button.
                button7.Enabled = true;
            }
            else
            {
                button4.BackColor = Color.Red;
            }

            // button1 is optian A (A ŞIKKI)
            button1.Enabled = false;
            // button2 is option B (B ŞIKKI)
            button2.Enabled = false;
            // button3 is option C (C ŞIKKI)
            button3.Enabled = false;
            // button4 is option D (D ŞIKKI)
            button4.Enabled = false;
            // button 6 is next question (SONRAKİ SORU).
            button6.Enabled = true;

        }

        /// <summary>
        /// Back Button. Go to guidance page.
        /// Geri butonu. yönlendirme sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Guidance guidancePage = new Guidance();
            guidancePage.Show();
            this.Hide();
        }

        /// <summary>
        /// Next Question Button. Loads the next question
        /// Sonraki butonu. Sonraki soruyu yükler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {

            // checks until the correct question comes up based on the chosen test. and checks is empty
            while (true)
            {

                // ctrl is question.txt readline.
                string ctrl = Welcome.swQuestionRead.ReadLine();

                // if ctrl = curent test and not null. 
                if (Welcome.currentTest == ctrl && ctrl != null)
                {
                    Welcome.QuestionRead(label4, button1, button2, button3, button4);
                    numberQuestion++;

                    // label3 is Question number (SORU NUMARASI) 
                    label3.Text = numberQuestion.ToString();
                    break;
                }
                else if (ctrl != null)
                {
                    next();
                }else if (ctrl == null)
                {
                    MessageBox.Show("Soru Kalmadı :(");
                    break;
                }
            }

            // button1 is optian A (A ŞIKKI)
            button1.BackColor = Color.White;
            // button2 is option B (B ŞIKKI)
            button2.BackColor = Color.White;
            // button3 is option C (C ŞIKKI)
            button3.BackColor = Color.White;
            // button4 is option D (D ŞIKKI)
            button4.BackColor = Color.White;


            // button1 is optian A (A ŞIKKI)
            button1.Enabled = true;
            // button2 is option B (B ŞIKKI)
            button2.Enabled = true;
            // button3 is option C (C ŞIKKI)
            button3.Enabled = true;
            // button4 is option D (D ŞIKKI)
            button4.Enabled = true;
            // button 6 is next question (SONRAKİ SORU).
            button6.Enabled = false;

        }

        /// <summary>
        /// Save Score Button.
        /// Puanı Kaydet butonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            // label1 is Score label.
            Welcome.HighScoreWrite(Welcome.userType,label1.Text);
            MessageBox.Show("Kaydedildi :)");

            // button7 is Save Score (PUANI KAYDET).
            button7.Enabled = false; 
        }
    }
}