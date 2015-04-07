/* TeamData.cs
 * Author: Richard Petrie
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.BaseBallScores
{
    /// <summary>
    /// Class holds data on BaseBall Teams
    /// </summary>
    public class TeamData : IComparable<TeamData>
    {
        /// <summary>
        /// The team's abbreviation.
        /// </summary>
        private string _abbreviation;

        /// <summary>
        /// Returns _abbreviation
        /// </summary>
        public string Abbreviation
        {
            get
            {
                return _abbreviation;
            }
        }

        /// <summary>
        /// The city or other location in which the team played.
        /// </summary>
        private string _city;

        /// <summary>
        /// Returns _city
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
        }

        /// <summary>
        /// The team's nickname.
        /// </summary>
        private string _nickname;

        /// <summary>
        /// Returns _nickname
        /// </summary>
        public string Nickname
        {
            get
            {
                return _nickname;
            }
        }

        /// <summary>
        /// The first year in which the team played in this location.
        /// </summary>
        private string _firstYear;

        /// <summary>
        /// Returns _firstYear;
        /// </summary>
        public string FirstYear
        {
            get
            {
                return _firstYear;
            }
        }

        /// <summary>
        /// The last year in which the team played in this location.
        /// </summary>
        private string _lastYear;

        /// <summary>
        /// Return _lastYear;
        /// </summary>
        public string LastYear
        {
            get
            {
                return _lastYear;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">Each field</param>
        public TeamData(string[] data)
        {
            _abbreviation = data[0];
            _city = data[1];
            _nickname = data[2];
            _firstYear = data[3];
            _lastYear = data[4];
            
        }

        /// <summary>
        /// Returns the string formatted into a specific way
        /// </summary>
        /// <returns>City Nickname (firstyear-lastyear)</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_city);
            sb.Append(" ");
            sb.Append(_nickname);
            sb.Append(" (");
            sb.Append(_firstYear);
            sb.Append("-");
            sb.Append(_lastYear);
            sb.Append(")");
            return sb.ToString();
        }

        /// <summary>
        /// Compares strings
        /// </summary>
        /// <param name="o">Sent function, o for other</param>
        /// <returns>Compare To return</returns>
        public int CompareTo(TeamData o) {
            return this.ToString().CompareTo(o.ToString());

        }
    }
}
