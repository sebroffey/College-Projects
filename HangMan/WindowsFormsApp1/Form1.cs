using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        GameGUI theGameGUI;


        public Form1()
        {
            InitializeComponent();
            form1Warning.Visible = false;
            theGameGUI = new GameGUI("");
        }

        private void form1StartButton_Click(object sender, EventArgs e)
        {
            if (form1PlayerName.Text == "")
            {

                form1Warning.Visible = true;
                form1StartButton.Text = "";

            }

            else
            {

                if (form1PlayerName.Text == "Type Here")
                {

                    form1Warning.Visible = true;
                    form1StartButton.Text = "";
                }

                else
                {
                    theGameGUI = new WindowsFormsApp1.GameGUI(form1PlayerName.Text);
                    theGameGUI.Show();
                    
                    this.Hide();

                }



                




            }


            


        }

        private void form1Warning_Click(object sender, EventArgs e)
        {
            //Ignore
        }

        private void form1PlayerName_TextChanged(object sender, EventArgs e)
        {
            form1Warning.Visible = false;
            form1StartButton.Text = "START";

        }
    }
}
