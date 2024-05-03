using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;

namespace Typograf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            printBtn_Click(sender, e);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = ApplyRules(inputRichTextBox.Text);
        }

        public string ApplyRules(string text)
        {
            bool useSpaceRule = spaceRuleToolStripMenuItem.Checked;
            bool useQuotesRule = quotesRule1ToolStripMenuItem.Checked;
            bool useHyphenRule = hyphenRuleToolStripMenuItem.Checked;
            bool useMinusRule = minusRuleToolStripMenuItem.Checked;
            bool useMathSingRule = mathSignRuleToolStripMenuItem.Checked;
            bool usePlusMinusRule = plusMinusRuleToolStripMenuItem.Checked;
            bool useUnitRule = unitRuleToolStripMenuItem.Checked;
            bool threeDotsRule = threeDotsToolStripMenuItem.Checked;
            bool pancakesCencorRule = pancakeCensorshipToolStripMenuItem.Checked;
            bool charsNumbersRule = charsNumbersToolStripMenuItem.Checked;

            if (useSpaceRule)
            {
                text = Regex.Replace(text, @"\s+", " ");
            }
            if (useQuotesRule)
            {
                text = Regex.Replace(text, "\"(\\w+)", "«$1");
                text = Regex.Replace(text, "(\\w+)\"", "$1»");
            }
            if (useHyphenRule)
            {
                text = Regex.Replace(text, @"(\w+)\s*-\s*(\w+)", "$1-$2");
            }
            if (useMinusRule)
            {
                text = Regex.Replace(text, @"(\d+)\s*-\s*(\d+)", "$1 − $2");
            }
            if (usePlusMinusRule)
            {
                text = Regex.Replace(text, @"\+-", "±");
            }
            if (useMathSingRule)
            {
                text = Regex.Replace(text, @"(\S)\s*([+\-*=\/±])\s*(\S)", "$1 $2 $3");;
            }
            if (useUnitRule)
            {
                text = Regex.Replace(text, @"(\d+(?:[,.]\d+)?)\s*[±\+-]\s*(\d+(?:[,.]\d+)?)\s*([^\d\s\.,]+)", "($1 ± $2) $3");
            }
            if (threeDotsRule)
            {
                text = Regex.Replace(text, @"\.\.\.", "…");
            }
            if (pancakesCencorRule)
            {
                text = Regex.Replace(text, @"блин", "бл*ин", RegexOptions.IgnoreCase);
            }
            if (charsNumbersRule)
            {
                text = Regex.Replace(text, "о", "0", RegexOptions.IgnoreCase);
                text = Regex.Replace(text, "з", "3", RegexOptions.IgnoreCase);
                text = Regex.Replace(text, "ч", "4", RegexOptions.IgnoreCase);
                text = Regex.Replace(text, "б", "6", RegexOptions.IgnoreCase);
                text = Regex.Replace(text, "т", "7", RegexOptions.IgnoreCase);
                text = Regex.Replace(text, "в", "8", RegexOptions.IgnoreCase);
                text = Regex.Replace(text, "д", "9", RegexOptions.IgnoreCase);
            }

            return text;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Типограф - это мощный и интуитивно понятный инструмент для работы с текстом, разработанный с учетом " +
                "потребностей профессиональных дизайнеров и типографов. Программа предназначена для создания и редактирования шрифтов, " +
                "а также для выполнения сложных задач по настройке и оптимизации типографики в различных проектах.", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputRichTextBox.Clear();
            outputRichTextBox.Clear();
        }
    }
}
