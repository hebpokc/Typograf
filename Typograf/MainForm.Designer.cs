
namespace Typograf
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quotesRule1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hyphenRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathSignRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusMinusRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeDotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pancakeCensorshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charsNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRichTextBox.Location = new System.Drawing.Point(35, 56);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(648, 693);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputRichTextBox.Location = new System.Drawing.Point(739, 56);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(648, 693);
            this.outputRichTextBox.TabIndex = 1;
            this.outputRichTextBox.Text = "";
            // 
            // printBtn
            // 
            this.printBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printBtn.Location = new System.Drawing.Point(619, 783);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(186, 46);
            this.printBtn.TabIndex = 2;
            this.printBtn.Text = "Оттипографить";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1424, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.clearToolStripMenuItem.Text = "Очистить";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spaceRuleToolStripMenuItem,
            this.quotesRule1ToolStripMenuItem,
            this.hyphenRuleToolStripMenuItem,
            this.minusRuleToolStripMenuItem,
            this.mathSignRuleToolStripMenuItem,
            this.plusMinusRuleToolStripMenuItem,
            this.unitRuleToolStripMenuItem,
            this.threeDotsToolStripMenuItem,
            this.pancakeCensorshipToolStripMenuItem,
            this.charsNumbersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // spaceRuleToolStripMenuItem
            // 
            this.spaceRuleToolStripMenuItem.CheckOnClick = true;
            this.spaceRuleToolStripMenuItem.Name = "spaceRuleToolStripMenuItem";
            this.spaceRuleToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.spaceRuleToolStripMenuItem.Text = "Нельзя писать подряд более одного пробела";
            this.spaceRuleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // quotesRule1ToolStripMenuItem
            // 
            this.quotesRule1ToolStripMenuItem.CheckOnClick = true;
            this.quotesRule1ToolStripMenuItem.Name = "quotesRule1ToolStripMenuItem";
            this.quotesRule1ToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.quotesRule1ToolStripMenuItem.Text = "Использовать кавычки \"ёлочки\"";
            this.quotesRule1ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // hyphenRuleToolStripMenuItem
            // 
            this.hyphenRuleToolStripMenuItem.CheckOnClick = true;
            this.hyphenRuleToolStripMenuItem.Name = "hyphenRuleToolStripMenuItem";
            this.hyphenRuleToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.hyphenRuleToolStripMenuItem.Text = "Дефис слитно";
            this.hyphenRuleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // minusRuleToolStripMenuItem
            // 
            this.minusRuleToolStripMenuItem.CheckOnClick = true;
            this.minusRuleToolStripMenuItem.Name = "minusRuleToolStripMenuItem";
            this.minusRuleToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.minusRuleToolStripMenuItem.Text = "В цифрах указывается минус";
            this.minusRuleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // mathSignRuleToolStripMenuItem
            // 
            this.mathSignRuleToolStripMenuItem.CheckOnClick = true;
            this.mathSignRuleToolStripMenuItem.Name = "mathSignRuleToolStripMenuItem";
            this.mathSignRuleToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.mathSignRuleToolStripMenuItem.Text = "Знаки операций отбиваются пробелом";
            this.mathSignRuleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // plusMinusRuleToolStripMenuItem
            // 
            this.plusMinusRuleToolStripMenuItem.CheckOnClick = true;
            this.plusMinusRuleToolStripMenuItem.Name = "plusMinusRuleToolStripMenuItem";
            this.plusMinusRuleToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.plusMinusRuleToolStripMenuItem.Text = "Символ плюс-минус";
            this.plusMinusRuleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // unitRuleToolStripMenuItem
            // 
            this.unitRuleToolStripMenuItem.CheckOnClick = true;
            this.unitRuleToolStripMenuItem.Name = "unitRuleToolStripMenuItem";
            this.unitRuleToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.unitRuleToolStripMenuItem.Text = "Значения относительно единицы измерений заносятся в скобки";
            this.unitRuleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.infoToolStripMenuItem.Text = "О программе";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // threeDotsToolStripMenuItem
            // 
            this.threeDotsToolStripMenuItem.CheckOnClick = true;
            this.threeDotsToolStripMenuItem.Name = "threeDotsToolStripMenuItem";
            this.threeDotsToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.threeDotsToolStripMenuItem.Text = "Троеточие";
            this.threeDotsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // pancakeCensorshipToolStripMenuItem
            // 
            this.pancakeCensorshipToolStripMenuItem.CheckOnClick = true;
            this.pancakeCensorshipToolStripMenuItem.Name = "pancakeCensorshipToolStripMenuItem";
            this.pancakeCensorshipToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.pancakeCensorshipToolStripMenuItem.Text = "Цензура блинов";
            this.pancakeCensorshipToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // charsNumbersToolStripMenuItem
            // 
            this.charsNumbersToolStripMenuItem.CheckOnClick = true;
            this.charsNumbersToolStripMenuItem.Name = "charsNumbersToolStripMenuItem";
            this.charsNumbersToolStripMenuItem.Size = new System.Drawing.Size(533, 24);
            this.charsNumbersToolStripMenuItem.Text = "Буквы-цифры";
            this.charsNumbersToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ToolStripMenuItem_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 867);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Типограф";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quotesRule1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hyphenRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minusRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathSignRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plusMinusRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeDotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pancakeCensorshipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charsNumbersToolStripMenuItem;
    }
}

