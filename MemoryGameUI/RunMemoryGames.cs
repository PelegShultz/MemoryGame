using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameUI
{
    internal class RunMemoryGames
    {
        public static void StartGame()
        {
            BoardForm mainForm = new BoardForm();
            SettingForm settingsForm = new SettingForm(mainForm);
            settingsForm.ShowDialog();
            while ((settingsForm.FirstPlayerName == string.Empty || settingsForm.SecondPlayerName == string.Empty) && !settingsForm.XButtunClicked)
            {
                settingsForm.ShowDialog();
            }

            if (settingsForm.DialogResult == DialogResult.OK)
            {
                mainForm.ShowDialog();
            }
        }   
    }
}
