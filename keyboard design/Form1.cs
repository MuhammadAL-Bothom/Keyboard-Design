using System;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace keyboard_design
{
    public partial class Form1 : Form
    {
        private bool isShiftPressed = false;
        private bool isCapsLockPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Attach Click events for all buttons
            button1.Click += ButtonClick;   // Esc
            button2.Click += ButtonClick;   // F1
            button3.Click += ButtonClick;   // F2
            button4.Click += ButtonClick;   // F3
            button5.Click += ButtonClick;   // F4
            button6.Click += ButtonClick;   // F5
            button7.Click += ButtonClick;   // F6
            button8.Click += ButtonClick;   // F7
            button9.Click += ButtonClick;   // F8
            button10.Click += ButtonClick;  // F9
            button11.Click += ButtonClick;  // F10
            button12.Click += ButtonClick;  // F11
            button13.Click += ButtonClick;  // F12
            button14.Click += ButtonClick;  // `
            button15.Click += ButtonClick;  // 1
            button16.Click += ButtonClick;  // 2
            button17.Click += ButtonClick;  // 3
            button18.Click += ButtonClick;  // 4
            button19.Click += ButtonClick;  // 5
            button20.Click += ButtonClick;  // 6
            button21.Click += ButtonClick;  // 7
            button22.Click += ButtonClick;  // 8
            button23.Click += ButtonClick;  // 9
            button24.Click += ButtonClick;  // 0
            button25.Click += ButtonClick;  // -
            button26.Click += ButtonClick;  // =
            button27.Click += ButtonBackspace_Click; // Backspace
            button28.Click += ButtonClick;  // Tab
            button29.Click += ButtonClick;  // Q
            button30.Click += ButtonClick;  // W
            button31.Click += ButtonClick;  // E
            button32.Click += ButtonClick;  // R
            button33.Click += ButtonClick;  // T
            button34.Click += ButtonClick;  // Y
            button35.Click += ButtonClick;  // U
            button36.Click += ButtonClick;  // I
            button37.Click += ButtonClick;  // O
            button38.Click += ButtonClick;  // P
            button39.Click += ButtonClick;  // [
            button40.Click += ButtonClick;  // ]
            button41.Click += ButtonClick;  // \
            button42.Click += ButtonCaps_Click;  // Caps Lock
            button43.Click += ButtonClick;  // A
            button44.Click += ButtonClick;  // S
            button45.Click += ButtonClick;  // D
            button46.Click += ButtonClick;  // F
            button47.Click += ButtonClick;  // G
            button48.Click += ButtonClick;  // H
            button49.Click += ButtonClick;  // J
            button50.Click += ButtonClick;  // K
            button51.Click += ButtonClick;  // L
            button52.Click += ButtonClick;  // ;
            button53.Click += ButtonClick;  // '
            button54.Click += ButtonEnter_Click; // Enter
            button55.Click += ButtonShift_Click; // Left Shift
            button56.Click += ButtonClick;  // Z
            button57.Click += ButtonClick;  // X
            button58.Click += ButtonClick;  // C
            button59.Click += ButtonClick;  // V
            button60.Click += ButtonClick;  // B
            button61.Click += ButtonClick;  // N
            button62.Click += ButtonClick;  // M
            button63.Click += ButtonClick;  // ,
            button64.Click += ButtonClick;  // .
            button65.Click += ButtonClick;  // /
            button66.Click += ButtonShift_Click; // Right Shift
            button67.Click += ButtonCtrl_Click;  // Left Ctrl
            button68.Click += ButtonAlt_Click;   // Left Alt
            button69.Click += ButtonSpace_Click; // Space
            button70.Click += ButtonAlt_Click;   // Right Alt
            button71.Click += ButtonCtrl_Click;  // Right Ctrl
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                string buttonText = button.Text;

                // Handle shift for uppercase letters or symbols
                if (isShiftPressed|| isCapsLockPressed)
                {
                    buttonText = buttonText.ToUpper();
                    isShiftPressed = false;
                }
                else
                {
                    buttonText = buttonText.ToLower();
                }


                textBox1.Text += buttonText;
            }
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine;
        }

        private void ButtonSpace_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void ButtonShift_Click(object sender, EventArgs e)
        {
            isShiftPressed = !isShiftPressed;
        }

        private void ButtonCaps_Click(object sender, EventArgs e)
        {
            if (!isCapsLockPressed)
            {
                label2.BackColor = System.Drawing.Color.Yellow; // Correct color usage
            }
            else
            {
                label2.BackColor = System.Drawing.Color.Black; // Reset color when Caps Lock is off
            }
            isCapsLockPressed = !isCapsLockPressed;
        }

        private void ButtonCtrl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ctrl key pressed");
        }

        private void ButtonAlt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alt key pressed");
        }
    }
}
