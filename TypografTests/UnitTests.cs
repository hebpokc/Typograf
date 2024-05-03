using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Windows.Forms;
using Typograf;

namespace TypografTests
{
    [TestClass]
    public class UnitTests
    {
        private static MainForm mainForm = new MainForm();
        MenuStrip menu = mainForm.Controls.Find("menuStrip", true).FirstOrDefault() as MenuStrip;

        [TestMethod]
        public void TestSpaceRule()
        {
            var input = "Привет    мир";
            var expected = "Привет мир";
            ToolStripMenuItem item = menu.Items.Find("spaceRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
        }

        [TestMethod]
        public void TestQuotesRule()
        {
            var input = "У него \"золотые\" руки";
            var expected = "У него «золотые» руки";
            ToolStripMenuItem item = menu.Items.Find("quotesRule1ToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
        }

        [TestMethod]
        public void TestMinusRule()
        {
            var input = "5-1=4";
            var expected = "5 − 1 = 4"; ;
            ToolStripMenuItem item = menu.Items.Find("minusRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            ToolStripMenuItem item2 = menu.Items.Find("mathSignRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            item2.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
            item2.Checked = false;
        }

        [TestMethod]
        public void TestHyphenRule()
        {
            var input = "Черно - белый";
            var expected = "Черно-белый";
            ToolStripMenuItem item = menu.Items.Find("hyphenRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
        }

        [TestMethod]
        public void TestPlusMinusRule()
        {
            var input = "85 +- 2";
            var expected = "85 ± 2";
            ToolStripMenuItem item = menu.Items.Find("plusMinusRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
        }

        [TestMethod]
        public void TestUnitRule()
        {
            var input = "433,92 +- 0,2 МГц";
            var expected = "(433,92 ± 0,2) МГц";
            ToolStripMenuItem item = menu.Items.Find("unitRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            ToolStripMenuItem item2 = menu.Items.Find("plusMinusRuleToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            item2.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
            item2.Checked = false;
        }

        [TestMethod]
        public void TestThreeDotsRule()
        {
            var input = "Молчат...нет ответа...";
            var expected = "Молчат…нет ответа…";
            ToolStripMenuItem item = menu.Items.Find("threeDotsToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
        }

        [TestMethod]
        public void TestPancakeCensorshipRule()
        {
            var input = "блин блинский";
            var expected = "бл*ин бл*инский";
            ToolStripMenuItem item = menu.Items.Find("pancakeCensorshipToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
        }

        [TestMethod]
        public void TestСharsNumbersRule()
        {
            var input = "Захотел дед ведро молока";
            var expected = "3ах07ел 9е9 8е9р0 м0л0ка";
            ToolStripMenuItem item = menu.Items.Find("charsNumbersToolStripMenuItem", true).FirstOrDefault() as ToolStripMenuItem;
            item.Checked = true;
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
            item.Checked = false;
        }

        [TestMethod]
        public void TestNoChangeForEmptyString()
        {
            var input = "";
            var expected = "";
            Assert.AreEqual(expected, mainForm.ApplyRules(input));
        }
    }
}
