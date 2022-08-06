using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewGUI
{
    public partial class MainWindow : Window
    {
        Game game;
        int time = 0;
        int size = 4;
        System.Windows.Threading.DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            game = new Game(size);
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0,0,1);
        }
        private void timerTick(object sender, EventArgs e)
        {
            time++;
            Time.Content = "_Время: " + time.ToString();
        }
        private void RefreshButtonField()
        {
            for (int position = 0; position < size* size; position++)
            {
                int number = game.GetNumber(position);
                Button button = GetButton(position);
                button.Content = number.ToString();
                button.Visibility = Visibility.Visible;
                button.IsEnabled = true;
                if (number == 0)
                    button.Visibility = Visibility.Hidden;
            }
        }


        private Button GetButton(int index) => (Button)FindName("button" + index);

        private void Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            game.history = 0;
            time = 0;
            Time.Content = "_Время: 0";
            game.countSteps = 0;
            Steps.Content = "_Количесво шагов: " + game.countSteps.ToString();
            timer.Start();
            game.Start();
            for (int i = 0; i < 1; i++)
                game.ShiftRandom();
            RefreshButtonField();
            BackButton.IsEnabled = true;
            AddBut.IsEnabled = true;
            DelBut.IsEnabled = true;
        }

        private void ButtonClick(object sender, EventArgs e)
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
                for (int i = 0; i < size * size; i++)
                    GetButton(i).IsEnabled = false;
                BackButton.IsEnabled = false;
                AddBut.IsEnabled = false;
                DelBut.IsEnabled = false;
                timer.Stop();
            }

            Steps.Content = "_Количесво шагов: " + game.countSteps.ToString();

        }

        private void ReturnButton(object sender, RoutedEventArgs e)
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
            Steps.Content = "_Количесво шагов: " + game.countSteps.ToString();

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers==ModifierKeys.Control && e.Key == Key.Z)
                Return();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            if (size < 8)
            {
                for (int i = 0; i < size + size + 1; i++)
                {
                    Button newButton = new Button();
                    newButton.Name = "button" + (size * size + i);
                    newButton.Content = "button" + (size * size + i);
                    newButton.Tag = (char)(size * size + i);
                    uniformGrid.Children.Add(newButton);
                    uniformGrid.RegisterName(newButton.Name, newButton);
                }
                game.Resize(++size);
                StartGame();
            }
        }

        private void DelButton(object sender, RoutedEventArgs e)
        {
            if (size > 2)
            {
                for (int i = 0; i < size + size - 1; i++)
                {
                    Button ss = (Button)this.FindName("button" + (size * size - 1 - i));
                    uniformGrid.UnregisterName(ss.Name);
                    uniformGrid.Children.Remove(ss);
                }
                game.Resize(--size);
                StartGame();
            }
        }
    }
}
