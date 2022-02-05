// Written by samrcode on GitHub
// Click!
using System;
using System.Windows.Forms;

class samrClicker
{
    public static void Main(string args[])
    {
        // Begin Box
        DialogResult start;
        start = MessageBox.Show(
            "Are you sure you want to start samrClicker? Press Cancel anytime during playing to exit the game.",
            "samrClicker",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
        if (start == DialogResult.No)
        {
            Environment.Exit(0);
        }
        else
        {
            Close();
        }

        // Sets Count
        var count = 1;

        // First Count
        DialogResult firstMain;
        firstMain = MessageBox.Show(
            "You clicked 1 time!",
            "samrClicker",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information
            );
        if (firstMain == DialogResult.Cancel)
        {
            Environment.Exit(0);
        }
        else
        {
            Close();
        }

        // Begin Loop
        
        while (true)
        {
            count++;
            DialogResult main;
            main = MessageBox.Show(
                "You clicked " +
                    Convert.ToString(count) +
                    " times!",
                "samrClicker",
                MessageBoxButton.OKCancel,
                MessageBoxIcon.Information
            );
            if (main == DialogResult.Cancel)
            {
                Environment.Exit(0)
            }
            else
            {
                Close();
            }
        }
    }
}
