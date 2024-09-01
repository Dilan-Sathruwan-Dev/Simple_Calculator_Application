namespace Simple_Calculator
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
            lbl_Num_1 = new Label();
            lbl_Num_2 = new Label();
            lbl_Result = new Label();
            txt_Num_1 = new TextBox();
            txt_Num_2 = new TextBox();
            txt_Result = new TextBox();
            btn_clear = new Button();
            btn_Exit = new Button();
            btn_add = new Button();
            btn_low = new Button();
            btn_mul = new Button();
            btn_div = new Button();
            SuspendLayout();
            // 
            // lbl_Num_1
            // 
            lbl_Num_1.AutoSize = true;
            lbl_Num_1.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold);
            lbl_Num_1.ForeColor = Color.Coral;
            lbl_Num_1.Location = new Point(12, 23);
            lbl_Num_1.Name = "lbl_Num_1";
            lbl_Num_1.Size = new Size(159, 19);
            lbl_Num_1.TabIndex = 0;
            lbl_Num_1.Text = "Enter Your First Number";
            lbl_Num_1.UseWaitCursor = true;
            lbl_Num_1.Click += label1_Click;
            // 
            // lbl_Num_2
            // 
            lbl_Num_2.AutoSize = true;
            lbl_Num_2.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold);
            lbl_Num_2.ForeColor = Color.Coral;
            lbl_Num_2.Location = new Point(12, 68);
            lbl_Num_2.Name = "lbl_Num_2";
            lbl_Num_2.Size = new Size(178, 19);
            lbl_Num_2.TabIndex = 0;
            lbl_Num_2.Text = "Enter Your Second Number";
            lbl_Num_2.UseWaitCursor = true;
            lbl_Num_2.Click += label1_Click;
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Yu Gothic UI Semibold", 13F, FontStyle.Bold);
            lbl_Result.ForeColor = Color.LawnGreen;
            lbl_Result.Location = new Point(113, 161);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(64, 25);
            lbl_Result.TabIndex = 0;
            lbl_Result.Text = "Result";
            lbl_Result.UseWaitCursor = true;
            lbl_Result.Click += label1_Click;
            // 
            // txt_Num_1
            // 
            txt_Num_1.BackColor = Color.DarkGray;
            txt_Num_1.ForeColor = Color.Blue;
            txt_Num_1.Location = new Point(187, 23);
            txt_Num_1.Name = "txt_Num_1";
            txt_Num_1.Size = new Size(85, 23);
            txt_Num_1.TabIndex = 1;
            txt_Num_1.TextAlign = HorizontalAlignment.Center;
            txt_Num_1.UseWaitCursor = true;
            // 
            // txt_Num_2
            // 
            txt_Num_2.BackColor = Color.DarkGray;
            txt_Num_2.ForeColor = Color.Blue;
            txt_Num_2.Location = new Point(187, 64);
            txt_Num_2.Name = "txt_Num_2";
            txt_Num_2.Size = new Size(85, 23);
            txt_Num_2.TabIndex = 1;
            txt_Num_2.TextAlign = HorizontalAlignment.Center;
            txt_Num_2.UseWaitCursor = true;
            // 
            // txt_Result
            // 
            txt_Result.BackColor = Color.DarkGray;
            txt_Result.ForeColor = Color.Blue;
            txt_Result.Location = new Point(73, 189);
            txt_Result.Name = "txt_Result";
            txt_Result.Size = new Size(142, 23);
            txt_Result.TabIndex = 1;
            txt_Result.TextAlign = HorizontalAlignment.Center;
            txt_Result.UseWaitCursor = true;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Black;
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_clear.ForeColor = Color.SpringGreen;
            btn_clear.Location = new Point(21, 225);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(83, 24);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.UseWaitCursor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Black;
            btn_Exit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.Location = new Point(187, 225);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(83, 24);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.UseWaitCursor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Black;
            btn_add.Font = new Font("Segoe UI", 13F);
            btn_add.ForeColor = Color.Fuchsia;
            btn_add.Location = new Point(33, 118);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(42, 32);
            btn_add.TabIndex = 3;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.UseWaitCursor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_low
            // 
            btn_low.BackColor = Color.Black;
            btn_low.Font = new Font("Segoe UI", 13F);
            btn_low.ForeColor = Color.Fuchsia;
            btn_low.Location = new Point(90, 118);
            btn_low.Name = "btn_low";
            btn_low.Size = new Size(42, 32);
            btn_low.TabIndex = 3;
            btn_low.Text = "-";
            btn_low.UseVisualStyleBackColor = false;
            btn_low.UseWaitCursor = true;
            btn_low.Click += btn_low_Click;
            // 
            // btn_mul
            // 
            btn_mul.BackColor = Color.Black;
            btn_mul.Font = new Font("Segoe UI", 13F);
            btn_mul.ForeColor = Color.Fuchsia;
            btn_mul.Location = new Point(148, 118);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(42, 32);
            btn_mul.TabIndex = 3;
            btn_mul.Text = "x";
            btn_mul.UseVisualStyleBackColor = false;
            btn_mul.UseWaitCursor = true;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_div
            // 
            btn_div.BackColor = Color.Black;
            btn_div.Font = new Font("Segoe UI", 13F);
            btn_div.ForeColor = Color.Fuchsia;
            btn_div.Location = new Point(207, 118);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(42, 32);
            btn_div.TabIndex = 3;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.UseWaitCursor = true;
            btn_div.Click += btn_div_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 261);
            Controls.Add(btn_div);
            Controls.Add(btn_mul);
            Controls.Add(btn_low);
            Controls.Add(btn_add);
            Controls.Add(btn_Exit);
            Controls.Add(btn_clear);
            Controls.Add(txt_Result);
            Controls.Add(txt_Num_2);
            Controls.Add(txt_Num_1);
            Controls.Add(lbl_Result);
            Controls.Add(lbl_Num_2);
            Controls.Add(lbl_Num_1);
            Name = "Form1";
            Text = "Simple Calculator";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Num_1;
        private Label lbl_Num_2;
        private Label lbl_Result;
        private TextBox txt_Num_1;
        private TextBox txt_Num_2;
        private TextBox txt_Result;
        private Button btn_clear;
        private Button btn_Exit;
        private Button btn_add;
        private Button btn_low;
        private Button btn_mul;
        private Button btn_div;
    }
}
