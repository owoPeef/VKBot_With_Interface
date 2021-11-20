
namespace Bot
{
    partial class ConsoleLoggerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutputText = new System.Windows.Forms.Label();
            this.InputTextArea = new System.Windows.Forms.TextBox();
            this.UpperMenu = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsoleSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.StatsSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.SendButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.UpperMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.OutputText);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 381);
            this.panel1.TabIndex = 0;
            // 
            // OutputText
            // 
            this.OutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputText.ForeColor = System.Drawing.SystemColors.Control;
            this.OutputText.Location = new System.Drawing.Point(0, 0);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(776, 381);
            this.OutputText.TabIndex = 0;
            // 
            // InputTextArea
            // 
            this.InputTextArea.BackColor = System.Drawing.Color.RoyalBlue;
            this.InputTextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTextArea.ForeColor = System.Drawing.SystemColors.Control;
            this.InputTextArea.Location = new System.Drawing.Point(12, 425);
            this.InputTextArea.Name = "InputTextArea";
            this.InputTextArea.Size = new System.Drawing.Size(776, 13);
            this.InputTextArea.TabIndex = 1;
            this.InputTextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextArea_KeyDown);
            // 
            // UpperMenu
            // 
            this.UpperMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.UpperMenu.Location = new System.Drawing.Point(0, 0);
            this.UpperMenu.Name = "UpperMenu";
            this.UpperMenu.Size = new System.Drawing.Size(800, 24);
            this.UpperMenu.TabIndex = 2;
            this.UpperMenu.Text = "UpperPanel";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsoleSelector,
            this.StatsSelector});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // ConsoleSelector
            // 
            this.ConsoleSelector.Name = "ConsoleSelector";
            this.ConsoleSelector.Size = new System.Drawing.Size(117, 22);
            this.ConsoleSelector.Text = "Console";
            // 
            // StatsSelector
            // 
            this.StatsSelector.Name = "StatsSelector";
            this.StatsSelector.Size = new System.Drawing.Size(117, 22);
            this.StatsSelector.Text = "Stats";
            this.StatsSelector.Click += new System.EventHandler(this.StatsSelector_Click);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(775, 425);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(13, 13);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = ">";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConsoleLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.InputTextArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpperMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.UpperMenu;
            this.Name = "ConsoleLoggerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOT";
            this.Load += new System.EventHandler(this.ConsoleLoggerForm_Load);
            this.panel1.ResumeLayout(false);
            this.UpperMenu.ResumeLayout(false);
            this.UpperMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InputTextArea;
        private System.Windows.Forms.MenuStrip UpperMenu;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsoleSelector;
        private System.Windows.Forms.ToolStripMenuItem StatsSelector;
        private System.Windows.Forms.Label OutputText;
        private System.Windows.Forms.Button SendButton;
    }
}

