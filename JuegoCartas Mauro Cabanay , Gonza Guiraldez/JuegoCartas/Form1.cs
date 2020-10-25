using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCartas
{
    public partial class Form1 : Form
    {

        // firstClicked será nulo hasta el primer click

        Label firstClicked = null;
        // secondClicked apunta al segundo Label será nulo hasta que el jugador clicks

        Label secondClicked = null;


        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();

        }

        Random random = new Random();
        //
        List<string> icons = new List<string>()
             {
             "!", "!", "N", "N", ",", ",", "k", "k",
             "b", "b", "v", "v", "w", "w", "z", "z"
             };

        private void AssignIconsToSquares()
        {
            foreach (Control control in
            tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber =
                    random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];

                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) 
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                // Chequea si ganó
                CheckForWinner();
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                if (firstClicked.Text == secondClicked.Text) 
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                timer1.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Parar el timer
            timer1.Stop();
            // Oculta ambos icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner() 
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Ganaste!", "Felicitaciones");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
