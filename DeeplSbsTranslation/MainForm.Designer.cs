namespace DeeplSbsTranslation
{
    partial class MainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbOutput = new ListBox();
            rtbInput = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lbOutput, 1, 1);
            tableLayoutPanel1.Controls.Add(rtbInput, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbOutput
            // 
            lbOutput.Dock = DockStyle.Fill;
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 15;
            lbOutput.Location = new Point(54, 228);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(743, 219);
            lbOutput.TabIndex = 0;
            // 
            // rtbInput
            // 
            rtbInput.Dock = DockStyle.Fill;
            rtbInput.Location = new Point(54, 3);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(743, 219);
            rtbInput.TabIndex = 1;
            rtbInput.Text = "";
            rtbInput.KeyDown += rtbInput_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 225);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Output";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            ShowIcon = false;
            Text = "Sentence by sentence translation";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lbOutput;
        private RichTextBox rtbInput;
        private Label label1;
        private Label label2;
    }
}