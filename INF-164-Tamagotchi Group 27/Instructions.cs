using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace INF_164_Tamagotchi_Group_27
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }
        //this will be used like a page number
        int instrPage = 0;
        //new array for the instructions and image paths
        string[,] instructions = new string[6, 2];
 


        private void Instructions_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Instruction_screen;
            rtbInstructions.BackColor = Color.DarkCyan;
            int i = 0;
            // Read the instrucitions file and store it in the 2d array it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"Instructions\TextFileWithInstructions.txt"))
            {
                //this will split the line
                string[] subs = line.Split(Convert.ToChar("+"));
                //this stores the file path
                instructions[i, 0] = subs[0];
                //this stores the actual instructions
                instructions[i, 1] = subs[1];

                i++;
            }
            //this fetches the image via the filepath stored in the array
            pbxInstructions.Image = Image.FromFile(instructions[instrPage, 0]);
            //this fetches the instructions via the filepath stored in the array
            rtbInstructions.Text = instructions[instrPage, 1];

        }      

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            //this works like a book where you flip back a page
            instrPage++;
            //this fetches the image via the filepath stored in the array
            pbxInstructions.Image = Image.FromFile(instructions[instrPage, 0]);
            //this fetches the instructions via the filepath stored in the array
            rtbInstructions.Text = instructions[instrPage, 1];
            //this will enable the previous button if it was disabled 
            btnPrevious.Enabled = true;
            if (instrPage >= 4)
            {
                //when you reach the first page it will disable the button
                btnNext.Enabled = false;
            }
        }

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            frmMainMenu frm1 = new frmMainMenu();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            //this works like a book where you flip back a page
            instrPage--;
            //this fetches the image via the filepath stored in the array
            pbxInstructions.Image = Image.FromFile(instructions[instrPage, 0]);
            //this fetches the instructions via the filepath stored in the array
            rtbInstructions.Text = instructions[instrPage, 1];
            //this will enable the next button if it was disabled 
            btnNext.Enabled = true;
            if (instrPage == 0)
            {
                //when you reach the first page it will disable the button
                btnPrevious.Enabled = false;
            }
        }
    }
}
