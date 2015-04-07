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
        /// Solves the maze from the cell it is sent to the nearest exit, prioritizing the north east corner.
        /// </summary>
        /// <param name="currentCell">Starting position</param>
        private void MazeSolve(Cell currentCell)
        {
            Stack<Direction> path = new Stack<Direction>();
            bool[,] visited = new bool[uxMaze.MazeHeight, uxMaze.MazeWidth];
            Direction currentDirection = new Direction();
            currentDirection = Direction.North;
            visited[currentCell.Row,currentCell.Column] = true;

            //Loops while cell is in the maze
            do {
                if (currentDirection <= Direction.West) {

                    if (uxMaze.IsClear(currentCell, currentDirection))
                    {
                            if (!uxMaze.IsInMaze(uxMaze.Step(currentCell,currentDirection)) || !visited[uxMaze.Step(currentCell, currentDirection).Row, uxMaze.Step(currentCell, currentDirection).Column])
                            {
                                uxMaze.DrawPath(currentCell, currentDirection);
                                path.Push(currentDirection);
                                currentCell = uxMaze.Step(currentCell, currentDirection);
                                try //will throw index out of bounds exception on tiles outside the maze
                                {
                                    visited[currentCell.Row, currentCell.Column] = true;
                                }
                                catch { IndexOutOfRangeException e; }
                                currentDirection = Direction.North;

                            }
                            else currentDirection++;
                        }
                        else currentDirection++;
                    
                } else {
                    if (path.Count != 0)
                    {
                        //backtrack
                        currentDirection = path.Pop();
                        currentCell = uxMaze.ReverseStep(currentCell, currentDirection);
                        uxMaze.ErasePath(currentCell, currentDirection);
                        currentDirection++;
                    }
                    else
                    {
                        MessageBox.Show("No path out :(");
                        return;
                    }
                }
            } while (uxMaze.IsInMaze(currentCell));
        }
        /// <summary>
        /// When you click on the maze, solve from that location out
        /// </summary>
        /// <param name="e">Used to grab mouse loc</param>
        private void uxMaze_MouseClick(object sender, MouseEventArgs e)
        {
            Cell currentCell = uxMaze.GetCellFromPixel(e.Location);
            if (uxMaze.IsInMaze(currentCell))
            {
                uxMaze.EraseAllPaths();
                MazeSolve(currentCell);
                uxMaze.Invalidate();
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
