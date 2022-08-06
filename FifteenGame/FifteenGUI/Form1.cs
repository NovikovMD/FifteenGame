using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifteenGUI
{
    public partial class Fifteen : Form
    {
        Game game;
        int time = 0;
        bool unPlug = true;
        public Fifteen()
        {
            InitializeComponent();
            game = new Game(4);
        }
        private void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                int number = game.GetNumber(position);
                Button button = GetButton(position);
                button.Text = number.ToString();
                button.Enabled = true;
                button.Visible = true;
                if (number == 0)
                    button.Visible = false;
            }
        }


        private Button GetButton(int index)
        {
            return (Button)Controls.Find("button" + index, true)[0];
        }

        private void Fifteen_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void startMenu_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            timer.Enabled = true;
            timer.Start();
            game.Start();
            for (int i = 0; i < 300; i++)//mix the field
                game.ShiftRandom();
            RefreshButtonField();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            int prevPosition;
            game.Shift(position, out prevPosition);

            RefreshButtonField();
            if (prevPosition != -1)
                GetButton(prevPosition).Focus();

            if (game.Check())
            {
                MessageBox.Show("Вы победили!");
                for (int i = 0; i < 16; i++)
                    GetButton(i).Enabled = false;
            }

            StepsBox.Text = game.countSteps.ToString();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            TimerBox.Text = time.ToString();
        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            Return();
        }
        private void Return()
        {
            int prevPos;
            game.StepBack(out prevPos);

            RefreshButtonField();
            if (prevPos != -1)
                GetButton(prevPos).Focus();
            StepsBox.Text = game.countSteps.ToString();

        }

        private void Fifteen_KeyDown(object sender, KeyEventArgs e)
        {
            if (unPlug && e.Control && e.KeyValue == 90)
            {
                unPlug = false;
                Return();
            }
        }

        private void button9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 90)
            {
                unPlug = true;
            }
        }
    }
}
