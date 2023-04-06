using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotNumbers
{
    public partial class BotGeneral : Form
    {
        public BotGeneral()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method clears all the text boxes on the form.
        /// </summary>
        private void button_reset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        /// <summary>
        /// This method clears the text boxes.
        /// </summary>
        private void ClearTextBoxes()
        {
            text_x.Text = "";
            text_y.Text = "";
        }

        /// <summary>
        /// This method adds the current cursor position to the text boxes when the add button is clicked.
        /// </summary>
        private void button_add_Click(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;

            text_x.Text += cursorPosition.X.ToString() + Environment.NewLine;
            text_y.Text += cursorPosition.Y.ToString() + Environment.NewLine;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        /// <summary>
        /// Performs a mouse click at the specified coordinates.
        /// </summary>
        /// <param name="x">The x coordinate of the mouse click.</param>
        /// <param name="y">The y coordinate of the mouse click.</param>
        public void DoMouseClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
            Cursor.Position = new Point(x, y);
        }

        /// <summary>
        /// This method is used to perform a mouse click at the given coordinates.
        /// </summary>
        /// <param name="x">The x coordinate of the mouse click.</param>
        /// <param name="y">The y coordinate of the mouse click.</param>
        private void button_replay_Click(object sender, EventArgs e)
        {
            int x, y;
            for (int j = 0; j <= 9; j++)
            {
                int linesLength = text_x.Lines.Length - 1;
                for (int i = 0; i < linesLength; i++)
                {
                    x = Convert.ToInt32(text_x.Lines[i]);
                    y = Convert.ToInt32(text_y.Lines[i]);

                    DoMouseClick(x, y);
                }
            }
        }
    }
}
