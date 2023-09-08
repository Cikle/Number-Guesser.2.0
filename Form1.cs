using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace NumberGuesser2._0
{
    public partial class Form1 : Form
    {
        //Soundplayer from a Youtube tutorial, Link: https://www.youtube.com/watch?v=W8w-qWga98U
        SoundPlayer _music = new SoundPlayer(soundLocation: @"C:\Users\cyril\OneDrive\Desktop\Schule\Module\Lern Atelier 2\SoundsMusic\Fluffing-a-Duck.wav");
        SoundPlayer _win = new SoundPlayer(soundLocation: @"C:\Users\cyril\OneDrive\Desktop\Schule\Module\Lern Atelier 2\SoundsMusic\crowd-cheer-ii-6263 (online-audio-converter.com).wav");

        Number input = new Number();
        GenerateNumber generate = new GenerateNumber();
        
        public Form1()
        {
            InitializeComponent();
            Player1.Hide();
            _music.PlayLooping();
            winnerscreen.Hide();
        }


        /*Play-Button*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            Player1.Show();
            winnerscreen.Hide();
            generate.Secret();
        }

        /*Start of Game*/

        /*User inputs Number*/
        private void InputNumbers_TextChanged(object sender, EventArgs e)
        {

        }
        /*Exit Button*/
        private void button1_Click(object sender, EventArgs e)
        {
            Player1.Hide();
        }

        private void Player1_Enter(object sender, EventArgs e)
        {

        }

        private void usednumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberisbiggerorsmaller_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void endgame_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
            Player1.Show();
        }

        private async void send_Click(object sender, EventArgs e)
        {
            // Help from Marek von Rogall + Old Number-Guesser-Project, Link: https://github.com/Cikle/Number-guesser
            switch (input.checkInput(InputNumbers.Text, generate.secretNumber))
                {
                case 0:
                    numberisbiggerorsmaller.Text = "Error: Number needs to be between 1-100";
                    break;
                case 1:
                    numberisbiggerorsmaller.Text = InputNumbers.Text + " is too small.";
                    
                    break;
                case 2:
                    numberisbiggerorsmaller.Text = InputNumbers.Text + " is too big.";
                    
                    break;
                case 3:
                    winnerscreen.Show();
                    Player1.Hide();
                    await Task.Run(() => new SoundPlayer(@"C:\Users\cyril\OneDrive\Desktop\Schule\Module\Lern Atelier 2\SoundsMusic\crowd-cheer-ii-6263 (online-audio-converter.com).wav").Play());
                    
                    triescounter.Text = "You needed " + input.tries + " tries";
                    break;
                case 4:
                    numberisbiggerorsmaller.Text = InputNumbers.Text + " is not a valid input.";
                    break;
            }
            usednumbers.Text = string.Join(", ", input.usedNumbers);
        }
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            _music.PlayLooping();
            refresh();
            Player1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _music.PlayLooping();
            refresh();
        }
        private void refresh()
        {
            input.usedNumbers.Clear();
            usednumbers.Text = "";
            winnerscreen.Hide();
            InputNumbers.Enabled = true;
            send.Enabled = true;
            InputNumbers.Text = "";
            numberisbiggerorsmaller.Text = "";
            generate.Secret();
            input.usedNumbers.Clear();
            usednumbers.Text = "";
            Player1.Hide();
        }
    }
}
