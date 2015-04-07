/* GameDetails.cs
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

namespace Ksu.Cis300.BaseBallScores
{
    /// <summary>
    /// Displays individual game data
    /// </summary>
    public partial class GameDetails : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GameDetails()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// The game being displayed
        /// </summary>
        private GameData _game;

        /// <summary>
        /// Sets game and calls dispaly function
        /// </summary>
        public GameData Game
        {
            set
            {
                _game = value;
                PopulateFields();
            }
        }

        /// <summary>
        /// Fills the fields
        /// </summary>
        private void PopulateFields() {
            this.Text = _game.Date.ToShortDateString();
            uxHomeFull.Text = _game.HomeFullName;
            uxAwayFull.Text = _game.AwayFullName;
            uxHomeScore.Text = _game.HomeScore;
            uxAwayScore.Text = _game.AwayScore;
            uxWinPitcher.Text = _game.WinningPitcher;
            uxLossPitcher.Text = _game.LosingPitcher;
            uxSave.Text = _game.SavePitcher;
            uxGameWin.Text = _game.GameBatter;
        }

    }
}
