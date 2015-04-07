/* MazeSolver.cs
 * Author: Richard Petrie
 * Maze generation provided by instructor
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
using Ksu.Cis300.MazeLibrary;

namespace Ksu.Cis300.MazeSolver
{
    public partial class MazeSolverForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MazeSolverForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Declare boolean array to track visited locations
        /// </summary>
        private bool[,] _visited;
        /// <summary>
        /// Solves the maze from the cell it is sent to the nearest exit, prioritizing the north east corner.
        /// </summary>
        /// <param name="currentCell">Starting position</param>
        private bool MazeSolve(Cell currentCell)
        {
            Direction currentDirection = new Direction();
            currentDirection = Direction.North;
            _visited[currentCell.Row,currentCell.Column] = true;
            bool temp = false;

            for (int i = 0; i < 4; i++)
            {
                if (uxMaze.IsClear(currentCell, currentDirection))
                {
                    if (uxMaze.IsInMaze(uxMaze.Step(currentCell,currentDirection)) == false)
                    {
                        uxMaze.DrawPath(currentCell, currentDirection);
                        return true;
                    }
                    if (_visited[uxMaze.Step(currentCell, currentDirection).Row, uxMaze.Step(currentCell, currentDirection).Column] == false)
                    {
                        uxMaze.DrawPath(currentCell, currentDirection);
                        temp = MazeSolve(uxMaze.Step(currentCell, currentDirection));
                        if (temp)
                        {
                            break;
                        }
                        uxMaze.ErasePath(currentCell, currentDirection);
                    }
                }
                currentDirection++;
            }
            return temp;
        }
        /// <summary>
        /// When you click on the maze, initialize array and solve from that location out
        /// </summary>
        /// <param name="e">Used to grab mouse loc</param>
        private void uxMaze_MouseClick(object sender, MouseEventArgs e)
        {
            _visited = new bool[uxMaze.MazeHeight, uxMaze.MazeWidth];
            bool temp = false ;
            Cell currentCell = uxMaze.GetCellFromPixel(e.Location);
            if (uxMaze.IsInMaze(currentCell))
            {
                uxMaze.EraseAllPaths();
                temp = MazeSolve(currentCell);
                uxMaze.Invalidate();
            }
            if (!temp)
            {
                MessageBox.Show("Maze not solved");
            }

        }
        /// <summary>
        /// Generate new maze
        /// </summary>
        private void uxNew_Click(object sender, EventArgs e)
        {
            uxMaze.Generate();
        }
    }
}
