namespace Tinhtiendien
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
            label2 = new Label();
            KWhTxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            KetQuaLsB = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(293, 45);
            label1.Name = "label1";
            label1.Size = new Size(421, 41);
            label1.TabIndex = 0;
            label1.Text = "Ứng dụng tính tiền điện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 118);
            label2.Name = "label2";
            label2.Size = new Size(294, 24);
            label2.TabIndex = 1;
            label2.Text = "Tổng điện năng tiêu thụ (KWh):";
            // 
            // KWhTxt
            // 
            KWhTxt.Location = new Point(391, 112);
            KWhTxt.Name = "KWhTxt";
            KWhTxt.Size = new Size(335, 32);
            KWhTxt.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(391, 234);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 3;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 234);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 303);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "Kết quả:";
            // 
            // KetQuaLsB
            // 
            KetQuaLsB.FormattingEnabled = true;
            KetQuaLsB.ItemHeight = 24;
            KetQuaLsB.Location = new Point(391, 303);
            KetQuaLsB.Name = "KetQuaLsB";
            KetQuaLsB.Size = new Size(406, 196);
            KetQuaLsB.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 541);
            Controls.Add(KetQuaLsB);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(KWhTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox KWhTxt;
        private Button button1;
        private Button button2;
        private Label label3;
        private ListBox KetQuaLsB;
    }
}
