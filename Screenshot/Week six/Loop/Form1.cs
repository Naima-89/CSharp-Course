
    using System;
using System.Windows.Forms;

namespace Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lsbox.Items.Clear();

            // FOR LOOP
            lsbox.Items.Add("FOR LOOP");

            for (int i = 1; i <= 5; i++)
            {
                lsbox.Items.Add(i);
            }

            // WHILE LOOP
            lsbox.Items.Add("WHILE LOOP");
            int x = 1;

            while (x <= 5)
            {
                lsbox.Items.Add(x);
                x++;
            }

            // DO WHILE LOOP
            lsbox.Items.Add("DO WHILE LOOP");

            int y = 1;

            do
            {
                lsbox.Items.Add(y);
                y++;
            }
            while (y <= 5);
        }
    }
}