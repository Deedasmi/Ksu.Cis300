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

namespace Ksu.Cis300.PhoneCounter
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Holds the contents of list A
        /// </summary>
        private LinkedListCell<PhoneCount> _listA = new LinkedListCell<PhoneCount>();
        /// <summary>
        /// Holds the contents of ListB
        /// </summary>
        private LinkedListCell<PhoneCount> _listB = new LinkedListCell<PhoneCount>();

        /// <summary>
        /// Filename for list a
        /// </summary>
        private string _fileAName;
        /// <summary>
        /// Filename for list b
        /// </summary>
        private string _fileBName;
        
        /// <summary>
        /// Same GUI builder as always
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads the first file
        /// </summary>
        private void uxFile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _fileAName = uxFileDialog.FileName;
                    uxFile1Text.Text = "File Loaded";
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Loads the second file
        /// </summary>
        private void uxFile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _fileBName = uxFileDialog.FileName;
                    uxFile2Text.Text = "File Loaded";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Does all the work
        /// </summary>
        private void uxGo_Click(object sender, EventArgs e)
        {
            // Variable incase a matching number is found
            bool found = false;
            //Read file A
            using (StreamReader input = new StreamReader(_fileAName))
            {
                while (!input.EndOfStream)
                {
                    string number = input.ReadLine().Trim();
                   //first time
                    if (_listA.Next == null)
                    {
                        PhoneCount tempP = new PhoneCount(1, number);
                        _listA.Data = tempP;
                        _listA.Next = new LinkedListCell<PhoneCount>();
                    }
                    else
                    {
                        LinkedListCell<PhoneCount> temp = _listA;
                        while (temp.Data != null)
                        {
                            if (number.CompareTo(temp.Data.Numer) == 0)
                            {
                                found = true;
                                temp.Data.Count++;
                                break;
                            }
                            temp = temp.Next;
                        }
                        if (found == false) {
                            PhoneCount tempP = new PhoneCount(1, number);
                            temp.Data = tempP;
                            temp.Next = new LinkedListCell<PhoneCount>();
                        }
                    }
                    found = false;
                }
            }

            //Read File B
            using (StreamReader input = new StreamReader(_fileBName))
            {
                while (!input.EndOfStream)
                {
                    string number = input.ReadLine().Trim();
                    //first time
                    if (_listB.Next == null)
                    {
                        PhoneCount tempP = new PhoneCount(1, number);
                        _listB.Data = tempP;
                        _listB.Next = new LinkedListCell<PhoneCount>();
                    }
                    else
                    {
                        LinkedListCell<PhoneCount> temp = _listB;
                        while (temp.Data != null)
                        {
                            if (number.CompareTo(temp.Data.Numer) == 0)
                            {
                                found = true;
                                temp.Data.Count++;
                                break;
                            }
                            temp = temp.Next;
                        }
                        if (found == false)
                        {
                            PhoneCount tempP = new PhoneCount(1, number);
                            temp.Data = tempP;
                            temp.Next = new LinkedListCell<PhoneCount>();
                        }
                    }
                    found = false;
                }
            }

            //Check for duplicates
            LinkedListCell<PhoneCount> tempA = _listA;
            while (tempA.Data != null)
            {
                if (tempA.Data.Count >= Convert.ToInt32(uxMinCount.Text)) {
                    LinkedListCell<PhoneCount> tempB = _listB;
                    while (tempB.Data != null)
                    {
                        if (tempA.Data.Numer.CompareTo(tempB.Data.Numer) == 0)
                        {
                            if (tempB.Data.Count >= Convert.ToInt32(uxMinCount.Text)) {
                            
                                uxMatch.Text = uxMatch.Text + tempA.Data.Numer + Environment.NewLine + "\t" +  tempA.Data.Count + " Times (file 1)";
                                uxMatch.Text = uxMatch.Text + Environment.NewLine + "\t" + tempB.Data.Count + " Times (file 2)" + Environment.NewLine+ Environment.NewLine;
                                break;
                            }
                        }
                        tempB = tempB.Next;
                    }
                }
                tempA = tempA.Next;
            }

        }
    }
}
