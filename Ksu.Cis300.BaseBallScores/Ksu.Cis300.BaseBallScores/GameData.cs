/* GameData.cs
 * Author: Richard Petrie
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.BaseBallScores
{
    public class GameData
    {
        /// <summary>
        /// Date of the game
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Return _date
        /// </summary>
        public DateTime Date 
        {
            get {
                return _date;
            }
        }

        /// <summary>
        /// A string containing the home team's location and nickname, separated by a space.
        /// </summary>
        private string _homeFullName;

        /// <summary>
        /// returns _homeFullName
        /// </summary>
        public string HomeFullName 
        {
            get
            {
                return _homeFullName;
            }
        }

        /// <summary>
        /// The home team's abbreviation.
        /// </summary>
        private string _homeAbbreviation;

        /// <summary>
        /// returns _homeAbbreviation
        /// </summary>
        public string HomeAbbreviation 
        {
            get {
                return _homeAbbreviation;
            }
        }

        /// <summary>
        /// The home team's score.
        /// </summary>
        private string _homeScore;

        /// <summary>
        /// Returns _homeScore;
        /// </summary>
        public string HomeScore 
        {
            get 
            {
                return _homeScore;
            }
        }

        /// <summary>
        /// A string containing the visiting team's location and nickname, separated by a space.
        /// </summary>
        private string _awayFullName;

        /// <summary>
        /// Return _awayFullName;
        /// </summary>
        public string AwayFullName
        {
            get
            {
                return _awayFullName;
            }
        }

        /// <summary>
        /// The visiting team's abbreviation.
        /// </summary>
        private string _awayAbbreviation;

        /// <summary>
        /// Returns _awayAbbreviation;
        /// </summary>
        public string AwayAbbreviation 
        {
            get
            {
                return _awayAbbreviation;
            }
        }

        /// <summary>
        /// The visiting team's score.
        /// </summary>
        private string _awayScore;

        /// <summary>
        /// Returns _awayScore;
        /// </summary>
        public string AwayScore 
        {
            get 
            {
                return _awayScore;
            }
        }

        /// <summary>
        /// The winning pitcher.
        /// </summary>
        private string _winPitcher;

        /// <summary>
        /// Returns _winPitcher
        /// </summary>
        public string WinningPitcher 
        {
            get 
            {
                return _winPitcher;
            }
        }

        /// <summary>
        /// The losing pitcher
        /// </summary>
        private string _lossPitcher;

        /// <summary>
        /// Returns _lossPitcher
        /// </summary>
        public string LosingPitcher 
        {
            get
            {
                return _lossPitcher;
            }
        }

        /// <summary>
        /// The pitcher credited with a save.
        /// </summary>
        private string _savePitcher;

        /// <summary>
        /// Returns _savePitcher;
        /// </summary>
        public string SavePitcher 
        {
            get
            {
                return _savePitcher;
            }
        }
        /// <summary>
        /// The batter who drove in the game-winning run.
        /// </summary>
        private string _gameBatter;

        /// <summary>
        /// Returns _gameBatter
        /// </summary>
        public string GameBatter
        {
            get
            {
                return _gameBatter;
            }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">String array we use to initialize fields</param>
        /// <param name="dictionary">Team dictionary - just for grabbing names</param>
        public GameData(string[] data, Dictionary<string, TeamData> dictionary)
        {
            int year = Convert.ToInt32(data[0].Substring(0, 4));
            int month = Convert.ToInt32(data[0].Substring(4, 2));
            int day = Convert.ToInt32(data[0].Substring(6, 2));
            _date = new DateTime(year, month, day);
            _awayAbbreviation = data[3];
            _homeAbbreviation = data[6];
            _awayScore = data[9];
            _homeScore = data[10];
            _winPitcher = data[94];
            _lossPitcher = data[96];
            _savePitcher = data[98];
            _gameBatter = data[100];
            StringBuilder sb = new StringBuilder();
            TeamData temp;
            
            //Home Full Name
            dictionary.TryGetValue(data[3], out temp);
            sb.Append(temp.City);
            sb.Append(" ");
            sb.Append(temp.Nickname);
            _homeFullName = sb.ToString();

            sb.Clear();

            //Away full name
            dictionary.TryGetValue(data[6], out temp);
            sb.Append(temp.City);
            sb.Append(" ");
            sb.Append(temp.Nickname);
            _awayFullName = sb.ToString();
        }
    }
}
