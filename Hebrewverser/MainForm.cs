using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hebrewverser
{
    public partial class MainForm : Form
    {
        private static readonly char[] RTL_CHARACTERS = { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ך', 'ל', 'מ', 'ם', 'נ', 'ן', 'ס', 'ע', 'פ', 'ף', 'צ', 'ץ', 'ק', 'ר', 'ש', 'ת', ' ', '-' };

        public MainForm()
        {
            InitializeComponent();
        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {
            UpdateReversedText();
        }

        private void UpdateReversedText()
        {
            machineTextBox.Text = ReverseRTL(userText.Text);
        }

        public static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string ReverseRTL(string text)
        {
            var output = new StringBuilder();
            foreach (var line in text.Split('\n'))
            {
                var reversedLine = new StringBuilder();
                for (var i = 0; i < line.Length;)
                {
                    var rtl_start = line.IndexOfAny(RTL_CHARACTERS, i);
                    if (rtl_start == -1)
                    {
                        reversedLine.Insert(0, line.Substring(i));
                        break;
                    }

                    var rtl_end = rtl_start;
                    for (; rtl_end < line.Length && RTL_CHARACTERS.Contains(line[rtl_end]); rtl_end++) { }

                    reversedLine.Insert(0, line[i..rtl_start]);
                    reversedLine.Insert(0, Reverse(line[rtl_start..rtl_end]));

                    i = rtl_end;
                }
                output.Append(reversedLine);
                output.Append("\r\n");
            }
            return output.ToString();
        }
    }
}