
namespace proga_lab_5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftBorder = new System.Windows.Forms.TextBox();
            this.rightBorder = new System.Windows.Forms.TextBox();
            this.accuracyField = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rectangleMethodCheck = new System.Windows.Forms.CheckBox();
            this.trapeziumMethod = new System.Windows.Forms.CheckBox();
            this.simpsonMethodCheck = new System.Windows.Forms.CheckBox();
            this.centralRectangleAnswer = new System.Windows.Forms.TextBox();
            this.trapeziumAnswer = new System.Windows.Forms.TextBox();
            this.simpsonAnswer = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.впередToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.впередToolStripMenuItem.Text = "Вперед";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // leftBorder
            // 
            this.leftBorder.Location = new System.Drawing.Point(40, 61);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(165, 22);
            this.leftBorder.TabIndex = 1;
            // 
            // rightBorder
            // 
            this.rightBorder.Location = new System.Drawing.Point(40, 125);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(165, 22);
            this.rightBorder.TabIndex = 2;
            // 
            // accuracyField
            // 
            this.accuracyField.Location = new System.Drawing.Point(40, 193);
            this.accuracyField.Name = "accuracyField";
            this.accuracyField.Size = new System.Drawing.Size(165, 22);
            this.accuracyField.TabIndex = 3;
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(40, 264);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(165, 22);
            this.function.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "f";
            // 
            // rectangleMethodCheck
            // 
            this.rectangleMethodCheck.AutoSize = true;
            this.rectangleMethodCheck.Location = new System.Drawing.Point(260, 53);
            this.rectangleMethodCheck.Name = "rectangleMethodCheck";
            this.rectangleMethodCheck.Size = new System.Drawing.Size(183, 21);
            this.rectangleMethodCheck.TabIndex = 9;
            this.rectangleMethodCheck.Text = "Метод прямоугольника";
            this.rectangleMethodCheck.UseVisualStyleBackColor = true;
            // 
            // trapeziumMethod
            // 
            this.trapeziumMethod.AutoSize = true;
            this.trapeziumMethod.BackColor = System.Drawing.SystemColors.Control;
            this.trapeziumMethod.Location = new System.Drawing.Point(260, 140);
            this.trapeziumMethod.Name = "trapeziumMethod";
            this.trapeziumMethod.Size = new System.Drawing.Size(139, 21);
            this.trapeziumMethod.TabIndex = 10;
            this.trapeziumMethod.Text = "Метод трапеций";
            this.trapeziumMethod.UseVisualStyleBackColor = false;
            // 
            // simpsonMethodCheck
            // 
            this.simpsonMethodCheck.AutoSize = true;
            this.simpsonMethodCheck.Location = new System.Drawing.Point(260, 232);
            this.simpsonMethodCheck.Name = "simpsonMethodCheck";
            this.simpsonMethodCheck.Size = new System.Drawing.Size(141, 21);
            this.simpsonMethodCheck.TabIndex = 11;
            this.simpsonMethodCheck.Text = "Метод Симпсона";
            this.simpsonMethodCheck.UseVisualStyleBackColor = true;
            // 
            // centralRectangleAnswer
            // 
            this.centralRectangleAnswer.Location = new System.Drawing.Point(260, 80);
            this.centralRectangleAnswer.Name = "centralRectangleAnswer";
            this.centralRectangleAnswer.Size = new System.Drawing.Size(160, 22);
            this.centralRectangleAnswer.TabIndex = 12;
            // 
            // trapeziumAnswer
            // 
            this.trapeziumAnswer.Location = new System.Drawing.Point(260, 167);
            this.trapeziumAnswer.Name = "trapeziumAnswer";
            this.trapeziumAnswer.Size = new System.Drawing.Size(160, 22);
            this.trapeziumAnswer.TabIndex = 13;
            // 
            // simpsonAnswer
            // 
            this.simpsonAnswer.Location = new System.Drawing.Point(260, 256);
            this.simpsonAnswer.Name = "simpsonAnswer";
            this.simpsonAnswer.Size = new System.Drawing.Size(160, 22);
            this.simpsonAnswer.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 680);
            this.Controls.Add(this.simpsonAnswer);
            this.Controls.Add(this.trapeziumAnswer);
            this.Controls.Add(this.centralRectangleAnswer);
            this.Controls.Add(this.simpsonMethodCheck);
            this.Controls.Add(this.trapeziumMethod);
            this.Controls.Add(this.rectangleMethodCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.accuracyField);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox leftBorder;
        private System.Windows.Forms.TextBox rightBorder;
        private System.Windows.Forms.TextBox accuracyField;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox rectangleMethodCheck;
        private System.Windows.Forms.CheckBox trapeziumMethod;
        private System.Windows.Forms.CheckBox simpsonMethodCheck;
        private System.Windows.Forms.TextBox centralRectangleAnswer;
        private System.Windows.Forms.TextBox trapeziumAnswer;
        private System.Windows.Forms.TextBox simpsonAnswer;
    }
}

