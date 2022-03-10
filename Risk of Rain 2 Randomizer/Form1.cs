using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk_of_Rain_2_Randomizer
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ListBoxClear()
        {
            lbArt.Items.Clear();
            lbChar.Items.Clear();
            lbDiff.Items.Clear();
        }

        private void RollCharacters()
        {
            var checkRadio = gbPlayerCount.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int radioSelection = int.Parse(checkRadio.Text);

            string[] Characters = new string[] { "Acrid", "Artificer", "Bandit", "Captain", "Commando", "Engineer", "Huntress", "Loader", "Mercenary",
                "MUL-T", "Railgunner", "REX", "Void Fiend" };

            int length = Characters.Length;
            int min = 0;
            int max = length - 1;

            if (cbDupe.Checked == true)
            {
                for (int i = 0; i < radioSelection; i++)
                {
                    int selection = random.Next(min, max);
                    lbChar.Items.Add(Characters[selection]);
                }
            }
            else if (cbDupe.Checked == false)
            {
                for (int i = 0; i < radioSelection; i++)
                {
                    int selection = random.Next(min, max);
                    string removeSelection = Characters[selection];
                    lbChar.Items.Add(Characters[selection]);
                    Characters = Characters.Where(o=> o != removeSelection).ToArray();
                    max--;
                }
            }
        }

        private void RollDifficulty()
        {
            string[] Difficulty = new string[] { "Drizzle", "Rainstorm", "Monsoon" };

            int length = Difficulty.Length;
            int min = 0;
            int max = length;

            int selection = random.Next(min, max);

            lbDiff.Items.Add(Difficulty[selection]);
        }

        private void RollArtifacts()
        {
            string[] Artifacts = new string[] { "Chaos", "Command", "Death", "Dissonance", "Enigma", "Evolution", "Frailty", "Glass", "Honor", "Kin",
                "Metamorphosis", "Sacrifice", "Soul", "Spite", "Swarms", "Vengeance"};
            
            int length = Artifacts.Length;
            int min = 0;
            int max = length - 1;
            int numberOfArtifacts = random.Next(min, max);

            for (int i = 0; i < numberOfArtifacts; i++)
            {
                int selection = random.Next(min, max);
                string removeSelection = Artifacts[selection];
                lbArt.Items.Add(removeSelection);
                Artifacts = Artifacts.Where(o=> o != removeSelection).ToArray();
                max--;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ListBoxClear();

            RollCharacters();

            RollDifficulty();

            RollArtifacts();
        }

        private void lbChar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}