namespace AliParser
{
    partial class Form1
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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.Link = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.brnStop = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.ParsSetting = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPageEnd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numPageBegin = new System.Windows.Forms.NumericUpDown();
            this.rbtnRange = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbtnPages = new System.Windows.Forms.RadioButton();
            this.rbtnAllPage = new System.Windows.Forms.RadioButton();
            this.Log = new System.Windows.Forms.GroupBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.Link.SuspendLayout();
            this.Settings.SuspendLayout();
            this.ParsSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(6, 19);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(226, 360);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // Link
            // 
            this.Link.Controls.Add(this.txtUrl);
            this.Link.Location = new System.Drawing.Point(4, 3);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(440, 44);
            this.Link.TabIndex = 0;
            this.Link.TabStop = false;
            this.Link.Text = "Ссылка откуда парсить";
            this.Link.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(8, 18);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(426, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 356);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // brnStop
            // 
            this.brnStop.Location = new System.Drawing.Point(107, 356);
            this.brnStop.Name = "brnStop";
            this.brnStop.Size = new System.Drawing.Size(75, 23);
            this.brnStop.TabIndex = 2;
            this.brnStop.Text = "Стоп";
            this.brnStop.UseVisualStyleBackColor = true;
            this.brnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.cbFrom);
            this.Settings.Controls.Add(this.brnStop);
            this.Settings.Controls.Add(this.btnStart);
            this.Settings.Controls.Add(this.ParsSetting);
            this.Settings.Location = new System.Drawing.Point(12, 53);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(188, 385);
            this.Settings.TabIndex = 1;
            this.Settings.TabStop = false;
            this.Settings.Text = "Настройки";
            // 
            // ParsSetting
            // 
            this.ParsSetting.Controls.Add(this.label3);
            this.ParsSetting.Controls.Add(this.numPageEnd);
            this.ParsSetting.Controls.Add(this.label2);
            this.ParsSetting.Controls.Add(this.numPageBegin);
            this.ParsSetting.Controls.Add(this.rbtnRange);
            this.ParsSetting.Controls.Add(this.label1);
            this.ParsSetting.Controls.Add(this.numericUpDown1);
            this.ParsSetting.Controls.Add(this.rbtnPages);
            this.ParsSetting.Controls.Add(this.rbtnAllPage);
            this.ParsSetting.Location = new System.Drawing.Point(0, 60);
            this.ParsSetting.Name = "ParsSetting";
            this.ParsSetting.Size = new System.Drawing.Size(188, 290);
            this.ParsSetting.TabIndex = 0;
            this.ParsSetting.TabStop = false;
            this.ParsSetting.Text = "Парсить указанную страницу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "стр.";
            // 
            // numPageEnd
            // 
            this.numPageEnd.Location = new System.Drawing.Point(104, 115);
            this.numPageEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageEnd.Name = "numPageEnd";
            this.numPageEnd.Size = new System.Drawing.Size(50, 20);
            this.numPageEnd.TabIndex = 7;
            this.numPageEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageEnd.ValueChanged += new System.EventHandler(this.numPageEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "стр.";
            // 
            // numPageBegin
            // 
            this.numPageBegin.Location = new System.Drawing.Point(6, 115);
            this.numPageBegin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageBegin.Name = "numPageBegin";
            this.numPageBegin.Size = new System.Drawing.Size(50, 20);
            this.numPageBegin.TabIndex = 5;
            this.numPageBegin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageBegin.ValueChanged += new System.EventHandler(this.numPageBegin_ValueChanged);
            // 
            // rbtnRange
            // 
            this.rbtnRange.AutoSize = true;
            this.rbtnRange.Location = new System.Drawing.Point(7, 92);
            this.rbtnRange.Name = "rbtnRange";
            this.rbtnRange.Size = new System.Drawing.Size(169, 17);
            this.rbtnRange.TabIndex = 4;
            this.rbtnRange.TabStop = true;
            this.rbtnRange.Text = "С ... страницу по ... страницу";
            this.rbtnRange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "стр.";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 66);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(147, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnPages
            // 
            this.rbtnPages.AutoSize = true;
            this.rbtnPages.Location = new System.Drawing.Point(6, 42);
            this.rbtnPages.Name = "rbtnPages";
            this.rbtnPages.Size = new System.Drawing.Size(149, 17);
            this.rbtnPages.TabIndex = 1;
            this.rbtnPages.TabStop = true;
            this.rbtnPages.Text = "Определенную страницу";
            this.rbtnPages.UseVisualStyleBackColor = true;
            // 
            // rbtnAllPage
            // 
            this.rbtnAllPage.AutoSize = true;
            this.rbtnAllPage.Location = new System.Drawing.Point(6, 19);
            this.rbtnAllPage.Name = "rbtnAllPage";
            this.rbtnAllPage.Size = new System.Drawing.Size(96, 17);
            this.rbtnAllPage.TabIndex = 0;
            this.rbtnAllPage.TabStop = true;
            this.rbtnAllPage.Text = "Все страницы";
            this.rbtnAllPage.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Controls.Add(this.rtbLog);
            this.Log.Location = new System.Drawing.Point(206, 53);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(238, 385);
            this.Log.TabIndex = 2;
            this.Log.TabStop = false;
            this.Log.Text = "Лог [..]";
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Aliexpress",
            "Avito"});
            this.cbFrom.Location = new System.Drawing.Point(7, 20);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(175, 21);
            this.cbFrom.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Link);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parser Aliexpress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Link.ResumeLayout(false);
            this.Link.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.ParsSetting.ResumeLayout(false);
            this.ParsSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox Link;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button brnStop;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.RadioButton rbtnPages;
        private System.Windows.Forms.RadioButton rbtnAllPage;
        private System.Windows.Forms.GroupBox Log;
        private System.Windows.Forms.GroupBox ParsSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPageEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPageBegin;
        private System.Windows.Forms.RadioButton rbtnRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbFrom;
    }
}

