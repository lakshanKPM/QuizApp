using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Quizapp : Form
    {
        private int score = 0;
        public Quizapp()
        {
            InitializeComponent();
            radioButton2.Tag = "correct";
            radioButton6.Tag = "correct";
            radioButton11.Tag = "correct";
            radioButton13.Tag = "correct";
            radioButton19.Tag = "correct";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool anySelected = false;
            int totalScore = 0;

            // Check which RadioButton is selected
            void CheckSelectedRadioButton(GroupBox groupBox)
            {
                bool selected = false;
                foreach (Control control in groupBox.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        selected = true;
                        anySelected = true;
                        switch (radioButton.Tag?.ToString())
                        {
                            case "correct":
                                totalScore++;
                                break;
                            case "incorrect":
                                // No score change for incorrect answers
                                break;
                            default:
                                // Handle unexpected cases if necessary
                                break;
                        }
                        break;
                    }
                }
                if (!selected)
                {
                    resultPanel2.Visible = true;
                    resultLabel2.Text = "Please select an answer for all questions.";
                }
            }

            CheckSelectedRadioButton(groupBox1);
            CheckSelectedRadioButton(groupBox2);
            CheckSelectedRadioButton(groupBox3);
            CheckSelectedRadioButton(groupBox4);
            CheckSelectedRadioButton(groupBox5);

            if (anySelected)
            {
                resultPanel1.Visible = true;
                resultLabel1.Text = "Your Marks: " + totalScore;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
