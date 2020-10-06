using System;
using System.Windows.Forms;

namespace Star
    {
    public partial class StarForm : Form
        {
        Game game;
        public StarForm()
            {
            InitializeComponent();
            }
        

        private void starForm_Load(object sender, EventArgs e)
            {
            stopButton.Enabled = false;
            
            }

        private void startButton_Click(object sender, EventArgs e)
            {
            game = new Game(pictureBox);
            game.Start((int)amountStarMenuNumericUpDown.Value);
            startButton.Enabled = false;
            stopButton.Enabled = true;
            amountStarMenuNumericUpDown.Enabled = false;
            mainTimer.Enabled = true;
            }

        private void stopButton_Click(object sender, EventArgs e)
            {
            if (mainTimer.Enabled == false)
                return;
            startButton.Enabled = true;
            amountStarMenuNumericUpDown.Enabled = true;
            mainTimer.Enabled = false;
            stopButton.Enabled = false;

            }

        private void mainTimer_Tick(object sender, EventArgs e)
            {
            game.RefreshGameField();
            }
        }
    }
