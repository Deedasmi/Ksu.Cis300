/* TeamAndDate.cs
 * Author: Richard Petrie
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.BaseBallScores
{
    struct TeamAndDate
    {
        /// <summary>
        /// Team name abbreviation
        /// </summary>
        private string _abbreviation;

        /// <summary>
        /// Date of the game
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Holds the hashcode for this struct
        /// </summary>
        private int _hashCode;

        /// <summary>
        /// Constructs a TeamAndDate by initializing the private values to given values for the team abbreviation and date of game
        /// </summary>
        /// <param name="abbreviation">Given team name abbreviation</param>
        /// <param name="date">Given date of the game</param>
        public TeamAndDate(string abbreviation, DateTime date)
        {
            _date = date.Date;
            _abbreviation = abbreviation;
            _hashCode = _abbreviation.Length;
            _hashCode *= 39;
            _hashCode += _date.Year;
            _hashCode += 39;
            _hashCode += _date.Month;
            _hashCode += 39;
            _hashCode += _date.Day;
            for (int i = 0; i < abbreviation.Length; i++)
            {
                unchecked
                {
                    _hashCode *= 39;
                    _hashCode += _abbreviation[i] - 'a';
                }
            }
        }

        /// <summary>
        /// Converts a hash for the team and date
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return _hashCode;
        }
    }
}