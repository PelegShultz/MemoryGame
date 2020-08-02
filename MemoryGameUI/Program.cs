using System;
using System.Windows.Forms;


namespace MemoryGameUI
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            RunMemoryGames.StartGame();
        }
    }
}
