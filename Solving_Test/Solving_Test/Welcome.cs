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
    public partial class Welcome : Form
    {

        // usertype is User Type variable.
        public static string userType = "Null";
        
        // questionNumber is Question number variable.
        public static int questionNumber = 0;

        // skor is Skor variable.
        public static int skor = 0;

        // currentTest is Current Test name variable.
        public static string currentTest = null;

        public static FileStream fsQuestionRead = new FileStream("C:\\Users\\muham\\Desktop\\Datas\\questions.txt", FileMode.Open, FileAccess.Read);
        public static StreamReader swQuestionRead = new StreamReader(fsQuestionRead);

        public Welcome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Welcome page is loaded method.
        /// Karşılama sayfası yüklendi methodu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this function is Question write to question.txt.
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="question"></param>
        /// <param name="optionA"></param>
        /// <param name="optionB"></param>
        /// <param name="optionC"></param>
        /// <param name="optionD"></param>
        /// <param name="trueOption"></param>
        public static void QuestionWrite(ComboBox testName, string question, string optionA, string optionB, string optionC, string optionD, string trueOption)
        {
            
            swQuestionRead.Close();
            fsQuestionRead.Close();

            FileStream fsQuestionWrite = new FileStream("C:\\Users\\muham\\Desktop\\Datas\\questions.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swQuestionWrite = new StreamWriter(fsQuestionWrite);

            swQuestionWrite.WriteLine(testName.Text);
            swQuestionWrite.WriteLine(question);
            swQuestionWrite.WriteLine(optionA);
            swQuestionWrite.WriteLine(optionB);
            swQuestionWrite.WriteLine(optionC);
            swQuestionWrite.WriteLine(optionD);
            swQuestionWrite.WriteLine(trueOption);
            swQuestionWrite.Flush();
            swQuestionWrite.Close();
            fsQuestionWrite.Close();

        }

        /// <summary>
        /// this function is Question read from question.txt.
        /// </summary>
        /// <param name="questionTextBox"></param>
        /// <param name="optionAbutton"></param>
        /// <param name="optionBbutton"></param>
        /// <param name="optionCbutton"></param>
        /// <param name="optionDbutton"></param>
        public static void QuestionRead(Label questionTextBox, Button optionAbutton, Button optionBbutton, Button optionCbutton, Button optionDbutton)
        {
            
            questionTextBox.Text = swQuestionRead.ReadLine();
            optionAbutton.Text = swQuestionRead.ReadLine();
            optionBbutton.Text = swQuestionRead.ReadLine();
            optionCbutton.Text = swQuestionRead.ReadLine();
            optionDbutton.Text = swQuestionRead.ReadLine();
        
        }

        /// <summary>
        /// this function is High Score write to highScores.txt.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userScore"></param>
        public static void HighScoreWrite(string userName, string userScore)
        {
            FileStream fsHighScoreWrite = new FileStream("C:\\Users\\muham\\Desktop\\Datas\\highScores.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swHighScoreWrite = new StreamWriter(fsHighScoreWrite);

            swHighScoreWrite.WriteLine(userName);
            swHighScoreWrite.WriteLine(userScore);
            swHighScoreWrite.Flush();
            swHighScoreWrite.Close();
            fsHighScoreWrite.Close();

        }

        /// <summary>
        /// this function is High Score read from highScore.txt.
        /// </summary>
        /// <param name="nameListBox"></param>
        public static void HighScoreRead(ListBox hihgScoreListBox)
        {
            FileStream fsHighScoreRead = new FileStream("C:\\Users\\muham\\Desktop\\Datas\\highScores.txt", FileMode.Open, FileAccess.Read);
            StreamReader swHighSocreRead = new StreamReader(fsHighScoreRead);

            // line1 is user name line in High score page 
            string line1;
            // line2 is user score line in High score page.
            string line2;
            do
            {
                line1 = swHighSocreRead.ReadLine();
                line2 = swHighSocreRead.ReadLine();

                if ((line1 != null) && (line2 != null))
                {
                    hihgScoreListBox.Items.Add(line1 + "                          " + line2);
                }

            } while ((line1 != null) && (line2 != null));


            fsHighScoreRead.Close();
            swHighSocreRead.Close();

        }

        /// <summary>
        /// this function is Test Names write to testNames.txt.
        /// </summary>
        /// <param name="testName"></param>
        public static void TestNamesWrite(ComboBox testName)
        {
            
            FileStream fsTestNamesWrite = new FileStream("C:\\Users\\muham\\Desktop\\Datas\\testNames.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swTestNamesWrite = new StreamWriter(fsTestNamesWrite);

            swTestNamesWrite.WriteLine(testName.Text);
            swTestNamesWrite.Flush();
            swTestNamesWrite.Close();
            fsTestNamesWrite.Close();
          
        }

        /// <summary>
        /// this function is Test Names read fom testNames.txt.
        /// </summary>
        /// <param name="testNamesComboBox"></param>
        public static void TestNamesRead(ComboBox testNamesComboBox)
        {
            FileStream fsTestNamesRead = new FileStream("C:\\Users\\muham\\Desktop\\Datas\\testNames.txt", FileMode.Open, FileAccess.Read);
            StreamReader swTestNamesRead = new StreamReader(fsTestNamesRead);

            // line is test names comboBox current items in Question write page.
            string line;
            do
            {
                line = swTestNamesRead.ReadLine();

                if (line != null)
                {
                    testNamesComboBox.Items.Add(line);
                }

            } while (line != null);

            fsTestNamesRead.Close();
            swTestNamesRead.Close();

        }

        /// <summary>
        /// Login Button. Go to guidance page.
        /// Giriş butonu. yönlendirme sayfasına gider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Guidance guidancePack = new Guidance();

            // textBox1 is user name textBox.
            // textBox2 is password textBox.
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                userType = "admin";
                guidancePack.Show();
                this.Hide();

            }else if (textBox1.Text == "member" && textBox2.Text == "member")
            {
                userType = "member";
                guidancePack.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.\nLütfen tekrar deneyiniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

    }
}
