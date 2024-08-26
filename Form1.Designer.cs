namespace Terminal_helper
{
    partial class Terminal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CalcBut = new Button();
            ScanBut = new Button();
            panel1 = new Panel();
            output = new DataGridView();
            input = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)output).BeginInit();
            SuspendLayout();
            // 
            // CalcBut
            // 
            CalcBut.BackColor = Color.FromArgb(248, 244, 251);
            CalcBut.FlatStyle = FlatStyle.Popup;
            CalcBut.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalcBut.Location = new Point(12, 12);
            CalcBut.Name = "CalcBut";
            CalcBut.Size = new Size(210, 57);
            CalcBut.TabIndex = 0;
            CalcBut.Text = "Преобразования";
            CalcBut.UseVisualStyleBackColor = false;
            CalcBut.Click += CalcBut_Click;
            // 
            // ScanBut
            // 
            ScanBut.BackColor = Color.FromArgb(248, 244, 251);
            ScanBut.FlatStyle = FlatStyle.Popup;
            ScanBut.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ScanBut.Location = new Point(12, 75);
            ScanBut.Name = "ScanBut";
            ScanBut.Size = new Size(210, 57);
            ScanBut.TabIndex = 1;
            ScanBut.Text = "Ввести";
            ScanBut.UseVisualStyleBackColor = false;
            ScanBut.Click += ScanBut_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 92, 255);
            panel1.Controls.Add(output);
            panel1.Controls.Add(input);
            panel1.Location = new Point(299, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 797);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // output
            // 
            output.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            output.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            output.BackgroundColor = Color.FromArgb(248, 244, 251);
            output.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 244, 251);
            dataGridViewCellStyle1.Font = new Font("Consolas", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            output.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 244, 251);
            dataGridViewCellStyle2.Font = new Font("Consolas", 30F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            output.DefaultCellStyle = dataGridViewCellStyle2;
            output.GridColor = Color.Black;
            output.Location = new Point(36, 25);
            output.Name = "output";
            output.ReadOnly = true;
            output.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            output.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            output.RowHeadersVisible = false;
            output.RowHeadersWidth = 50;
            output.RowTemplate.Height = 28;
            output.Size = new Size(1152, 740);
            output.TabIndex = 1;
            // 
            // input
            // 
            input.BackColor = Color.FromArgb(248, 244, 251);
            input.BorderStyle = BorderStyle.FixedSingle;
            input.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            input.Location = new Point(36, 25);
            input.Multiline = true;
            input.Name = "input";
            input.Size = new Size(1152, 740);
            input.TabIndex = 0;
            // 
            // Terminal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 134, 255);
            ClientSize = new Size(1532, 828);
            Controls.Add(panel1);
            Controls.Add(ScanBut);
            Controls.Add(CalcBut);
            Name = "Terminal";
            Text = "Terminal helper";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)output).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CalcBut;
        private Button ScanBut;
        private Panel panel1;
        private TextBox input;
        private DataGridView output;
    }
}
