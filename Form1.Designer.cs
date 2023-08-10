namespace switcherWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(341, 31);
            label1.TabIndex = 0;
            label1.Text = "Папка с установленой игрой";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Enabled = false;
            textBox1.Location = new Point(359, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(291, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(656, 61);
            button1.Name = "button1";
            button1.Size = new Size(99, 26);
            button1.TabIndex = 2;
            button1.Text = "Обзор";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Австралийский вариант английского языка", "Американский вариант английского языка", "Британский вариант английского языка", "Филиппинский вариант английского языка", "Аргентинский вариант испанского языка", "Бразильский вариант португальского языка", "Венгерский язык", "Вьетнамский язык", "Греческий язык", "Индонезийский язык", "Испанский язык", "Итальянский язык", "Китайский язык", "Корейский язык", "Малайзийский язык", "Мексиканский вариант испанского языка", "Немецкий язык", "Польский язык", "Португальский язык", "Румынский язык", "Русский язык", "Сингапурский вариант английского языка", "Тайваньский язык", "Тайский язык", "Турецкий язык", "Французский язык", "Чешский язык", "Японский язык" });
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Австралийский вариант английского языка", "Американский вариант английского языка", "Аргентинский вариант испанского языка", "Бразильский вариант португальского языка", "Британский вариант английского языка", "Венгерский язык", "Вьетнамский язык", "Греческий язык", "Индонезийский язык", "Испанский язык", "Итальянский язык", "Китайский язык", "Корейский язык", "Малайзийский язык", "Мексиканский вариант испанского языка", "Немецкий язык", "Польский язык", "Португальский язык", "Румынский язык", "Русский язык", "Сингапурский вариант английского языка", "Тайваньский язык", "Тайский язык", "Турецкий язык", "Филиппинский вариант английского языка", "Французский язык", "Чешский язык", "Японский язык" });
            comboBox1.Location = new Point(240, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(449, 29);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Австралийский вариант английского языка";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(222, 31);
            label2.TabIndex = 4;
            label2.Text = "Язык локализации";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(328, 228);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 5;
            button2.Text = "Погнали";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(767, 290);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Localisation changer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button2;
    }
}