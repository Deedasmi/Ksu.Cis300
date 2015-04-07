/* drawgraph.cs
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
using Ksu.Cis300.GraphDrawing;
using Ksu.Cis300.Graphs;
using System.IO;

namespace Ksu.Cis300.GraphDrawer
{
    /// <summary>
    /// The main window with full functionality
    /// </summary>
    public partial class DrawGraph : Form
    {
        /// <summary>
        /// Holds all points and edge combinations. Complete graph.
        /// </summary>
        private DirectedGraph<Point, double> _graph;

        /// <summary>
        /// Constructor
        /// </summary>
        public DrawGraph()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads in points and populates _graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoad_Click(object sender, EventArgs e)
        {
            List<Point> points = new List<Point>();
            if (uxFile.ShowDialog() == DialogResult.OK)
            {
                uxGraph.Clear();
                _graph = new DirectedGraph<Point, double>();
                using (StreamReader input = new StreamReader(uxFile.FileName)) {
                    string line = input.ReadLine();
                    int x,y;
                    LineNums(line, out x, out y);
                    uxGraph.GraphSize = new Size(x,y);
                    while (!input.EndOfStream) {
                        line = input.ReadLine();
                        LineNums(line, out x, out y);
                        Point p = new Point(x, y);
                        uxGraph.DrawPoint(p);
                        points.Add(p);
                        _graph.AddNode(p);
                    }
                }
            }
            //Done with the file
            //Write edges to graph
            foreach (Point p in points)
            {
                for (int i = 0; i < points.Count; i++)
                    if (!p.Equals(points[i])) {
                        double d = GetDistance(p, points[i]);
                        _graph.AddEdge(p, points[i], d);
                    }
            }

            //Find and draw path, or just say 0
            if (_graph.NodeCount != 0)
            {
                FindShortestPath(points[0]);
            }
            else
            {
                MessageBox.Show("Total cost: 0");
            }
        }

        /// <summary>
        /// Seperate function simple for cleanliness. Calculates the shortest path and draws the graph
        /// </summary>
        /// <param name="s">Initial point</param>
        private void FindShortestPath(Point s)
        {
            double total = 0;
            Dictionary<Point, Tuple<Point, double>> mst = new Dictionary<Point, Tuple<Point, double>>();
            foreach (Tuple<Point, double> edge in _graph.OutgoingEdges(s))
            {
                mst.Add(edge.Item1, new Tuple<Point, double>(s, edge.Item2));
            }

            while (mst.Count > 0)
            {
                double smallest = double.PositiveInfinity;
                Tuple<Point, double> smallestEdge = new Tuple<Point, double>(s, smallest);
                Point source = s;
                foreach (KeyValuePair<Point, Tuple<Point, double>> kvp in mst)
                {
                        if (kvp.Value.Item2 < smallest)
                        {
                            smallest = kvp.Value.Item2;
                            smallestEdge = kvp.Value;
                            source = kvp.Key;
                        }
                }
                uxGraph.DrawLine(source, smallestEdge.Item1);
                total += smallestEdge.Item2;
                mst.Remove(source);

                //Update shortest path to remaining keys
                foreach (Tuple<Point, double> edge in _graph.OutgoingEdges(source))
                {
                    if (mst.ContainsKey(edge.Item1))
                    {
                        if (edge.Item2 < mst[edge.Item1].Item2)
                        {
                            mst[edge.Item1] = new Tuple<Point, double>(source, edge.Item2);
                        }
                    }
                }
            }
            MessageBox.Show("Total cost: " + total);
        }


    
        /// <summary>
        /// Convinece function to turn input line into two ints
        /// </summary>
        /// <param name="line">The line to pull the data from</param>
        /// <param name="x">X coordinate of the point</param>
        /// <param name="y">Y coordinate of the point</param>
        private void LineNums(string line, out int x, out int y) {
            x = Convert.ToInt32(line.Substring(0, line.IndexOf(',')));
            line = line.Substring((line.IndexOf(',') + 1),(line.Length - line.IndexOf(',') - 1));
            y = Convert.ToInt32(line);
        }

        /// <summary>
        /// Gets the distance from point to another point
        /// </summary>
        /// <param name="u">Starting point</param>
        /// <param name="v">Destination point</param>
        /// <returns>Distance</returns>
        private double GetDistance(Point u, Point v)
        {
            double d1 = (u.X - v.X) * (u.X - v.X);
            double d2 = (u.Y - v.Y) * (u.Y - v.Y);
            return Math.Sqrt(d1 + d2);
        }

    }
}
