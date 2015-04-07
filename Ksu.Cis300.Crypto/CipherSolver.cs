/* CipherSolver.cs
 * Author: Richard Petrie
 * Date: 11/2/2014
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ksu.Cis300.WordLookup;

namespace Ksu.Cis300.Crypto
{
    public partial class CipherSolver : Form
    {
        /// <summary>
        /// Holds valid words
        /// </summary>
        private ITrie _dictionary = new TrieWithNoChildren();

        /// <summary>
        /// Constructor man
        /// </summary>
        public CipherSolver()
        {
            InitializeComponent();
            _dictionary = new TrieWithNoChildren();
            try
            {
                using (StreamReader input = File.OpenText("dictionary.txt"))
                {
                    while (!input.EndOfStream)
                    {
                        string word = input.ReadLine();
                        _dictionary = _dictionary.Add(word);
                    }
                }
                MessageBox.Show("Dictionary successfully read.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Opens a file to the top text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenFile.ShowDialog() == DialogResult.OK)
                {
                    uxText.Text = File.ReadAllText(uxOpenFile.FileName);
                }
            }
            catch { MessageBox.Show("Failed to open file"); }
        }
        /// <summary>
        /// Does some invalid character checking, creates arrays, then calls decrypt funcction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDecrypt_Click(object sender, EventArgs e)
        {
            //Reset state
            uxOut.Text = "";

            //Check for invalid characters
            string text = uxText.Text.Trim();
            foreach (char c in text)
            {
                if (c < 'a' || c > 'z')
                {
                    if (c != ' ')
                    {
                        uxOut.Text = "Invalid characters. Only lower case letters and spaced allowed";
                        return;
                    }
                }
            }

            //Build cipher array
            string[] cipher = text.Split(' ');

            //Build and initialize partial array
            StringBuilder[] partial = new StringBuilder[cipher.Length];
            for (int i = 0; i < partial.Length; i++)
            {
                partial[i] = new StringBuilder();
                for (int c = 0; c < cipher[i].Length; c++)
                {
                    partial[i].Append('?');
                }
            }

            //Run decryption and update uxOut accordingly.
            StringBuilder a = new StringBuilder();
            if (Decrypt(cipher, partial, new bool[26]))
            {
                foreach (StringBuilder s in partial)
                {
                    a.Append(s.ToString());
                    a.Append(' ');
                    
                }
                uxOut.Text = a.ToString();
            }
            else
            {
                uxOut.Text = "No solution found";
            }

        }
        /// <summary>
        /// Does the decreptions
        /// </summary>
        /// <param name="cipher">refrence to the text entered in uxText</param>
        /// <param name="partial">reference to the current 'theory' of what the ansewr is</param>
        /// <param name="alphaUsed">reference to what letters have been used.</param>
        /// <returns>If the answer is good</returns>
        private bool Decrypt(String[] cipher, StringBuilder[] partial, bool[] alphaUsed)
        {
            int solvedCount = 0;

            //Stuff to break recursion
            foreach (StringBuilder s in partial)
            {
                if (!_dictionary.WildcardSearch(s.ToString()))
                {
                    return false;
                }
                if (!s.ToString().Contains('?'))
                {
                    if (_dictionary.Contains(s.ToString()))
                    {
                        solvedCount++;
                    }
                }
            }

            if (solvedCount == partial.Length)
            {
                return true;
            }

            //What character to replace throughout partial
            int wordIndex = 0, characterIndex = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                characterIndex = partial[i].ToString().IndexOf('?');
                if (characterIndex != -1)
                {
                    wordIndex = i;
                    break;
                }
            }
            bool found = false;
            char v = cipher[wordIndex][characterIndex];

            //Replace character with a new character we haven't used yet.
            for (int boolIndex = 0; boolIndex < 26; boolIndex++)
            {
                if (alphaUsed[boolIndex] == false)
                {
                    for (int i = 0; i < partial.Length; i++)
                    {
                        for (int c = 0; c < partial[i].Length; c++)
                        {
                            if (cipher[i][c] == v)
                            {
                                partial[i][c] = (char)(boolIndex + 'a');
                            }
                        }
                    }

                    alphaUsed[boolIndex] = true;
                    found = Decrypt(cipher, partial, alphaUsed);

                    //Undo
                    //Could use stacks or linked lists to make this more CPU effecient
                    //Hold change locations in these data structures so we aren't searching the entire array.
                    if (!found) 
                    {
                        alphaUsed[boolIndex] = false;
                        for (int i = 0; i < partial.Length; i++)
                        {
                            for (int c = 0; c < partial[i].Length; c++)
                            {
                                if (cipher[i][c] == v)
                                {
                                    partial[i][c] = '?';
                                }
                            }
                        }
                    }
                    else { return true; }
                }
            }
            return found;
        }
    }
}
