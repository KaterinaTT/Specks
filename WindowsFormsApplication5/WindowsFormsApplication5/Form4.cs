using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form4 : Form
    {
        Game game;
        public Form4()
        {
            InitializeComponent();
            game = new Game(5);
        }


        private void button0_Click(object sender, EventArgs e)
        {

            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.check_numbers())
            {
                MessageBox.Show("Вы победили!");
                start_game();
            }
        }
         private Button button(int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                case 16: return button16;
                case 17: return button17;
                case 18: return button18;
                case 19: return button19;
                case 20: return button20;
                case 21: return button21;
                case 22: return button22;
                case 23: return button23;
                case 24: return button24;
                default: return null;

            }
        }



         private void Form4_Load_1(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game()
        {
            game.start();
            for (int j = 0; j < 45; j++)
                game.shift_random();
            refresh();
        }
        private void refresh()
        {
            for (int position = 0; position < 25; position++)
            {
                int kr = game.get_number(position);
                button(position).Text = kr.ToString();
                button(position).Visible = (kr > 0);

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 inf1 = new Form1();
            inf1.ShowDialog();

        }

        
    }
}
    
