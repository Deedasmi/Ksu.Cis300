/* UserInterface.cs
 * Author: Richard Petrie
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.BaseBallScores
{
    /// <summary>
    /// Main GUI
    /// </summary>
    public partial class UserInterface : Form
    {

        /// <summary>
        /// The teams read from the file
        /// </summary>
        private Dictionary<string, TeamData> _teams = new Dictionary<string, TeamData>();

        /// <summary>
        /// Teams added to the combo box
        /// </summary>
        private HashSet<string> _addedteams = new HashSet<string>();

        /// <summary>
        /// Info on individual games
        /// </summary>
        private Dictionary<TeamAndDate, List<GameData>> _gameInfo = new Dictionary<TeamAndDate, List<GameData>>();


        /// <summary>
        /// Constructor
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();

            //Read Team file
               
            using (StreamReader input = new StreamReader("TEAMABR.csv")) {
                while(!input.EndOfStream) {
                    TeamData temp = new TeamData(input.ReadLine().Split(','));
                    _teams.Add(temp.Abbreviation, temp);
                }
            }
            MessageBox.Show("Read in Teams");
                
        }

        /// <summary>
        /// Get a game file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetFile_Click(object sender, EventArgs e)
        {
            string filename;
            try
            {
                if (uxFile.ShowDialog() == DialogResult.OK)
                {
                    filename = uxFile.FileName;
                }


                using (StreamReader input = new StreamReader(uxFile.FileName))
                {
                    while (!input.EndOfStream)
                    {
                        //Read data
                        string line = input.ReadLine();
                        string[] data = new string[101];
                        for (int i = 0; i < 101; i++)
                        {
                            if (line[0] == '"')
                            {
                                line = line.Substring(1, (line.Length - 1));
                                data[i] = line.Substring(0, line.IndexOf('"'));
                                line = line.Substring((line.IndexOf('"') + 2), (line.Length - line.IndexOf('"') - 2));
                            }
                            else
                            {
                                data[i] = line.Substring(0, line.IndexOf(','));
                                line = line.Substring((line.IndexOf(',') + 1), (line.Length - line.IndexOf(',') - 1));
                            }

                        }
                        
                        //Data is read
                        //Create Team and Dates
                        int year = Convert.ToInt32(data[0].Substring(0, 4));
                        int month = Convert.ToInt32(data[0].Substring(4, 2));
                        int day = Convert.ToInt32(data[0].Substring(6, 2));
                        DateTime date = new DateTime(year, month, day);
                        TeamAndDate home = new TeamAndDate(data[3], date);
                        TeamAndDate away = new TeamAndDate(data[6], date);

                        //Initialize lists
                        if (!_gameInfo.ContainsKey(home))
                        {
                            _gameInfo.Add(home, new List<GameData>());

                        }
                        if (!_gameInfo.ContainsKey(away))
                        {
                            _gameInfo.Add(away, new List<GameData>());

                        }

                        //Add values and enable interface objects
                        _gameInfo[home].Add(new GameData(data, _teams));
                        _gameInfo[away].Add(new GameData(data, _teams));
                        uxTeams.Enabled = true;
                        uxResults.Enabled = true;
                        if (!_addedteams.Contains(data[3]))
                        {
                            uxTeams.Items.Add(_teams[data[3]]);
                            _addedteams.Add(data[3]);
                        }
                        uxTeams.SelectedIndex = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Reading of games failed");
                return;
            }
            MessageBox.Show("Games read");
        }

        /// <summary>
        /// Get Game Results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxResults_Click(object sender, EventArgs e)
        {
            TeamData tempTeam = (TeamData)uxTeams.SelectedItem;
            TeamAndDate key = new TeamAndDate(tempTeam.Abbreviation, uxDate.Value);
            if (!_gameInfo.ContainsKey(key))
            {
                MessageBox.Show("No games were played by this team on this date");
                return;
            }
            GameData gameToBeShown;
            GameDetails[] gameWindows = new GameDetails[_gameInfo[key].Count];
            for (int i = 0; i < _gameInfo[key].Count; i++)
            {
                gameWindows[i] = new GameDetails();
                gameToBeShown = _gameInfo[key][i];
                gameToBeShown = _gameInfo[key][i];
                gameWindows[i].Game = gameToBeShown;
                gameWindows[i].Show();
                

            }
        }
    }
    
}
