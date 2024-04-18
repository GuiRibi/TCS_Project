namespace TCS_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBoxMinimize = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBoxClose = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBoxGraph = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            button1 = new Button();
            labelResults = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox5 = new TextBox();
            comboBox5 = new ComboBox();
            helpProvider1 = new HelpProvider();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(42, 42, 42);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.3333359F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(61, 61, 61);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Controls.Add(pictureBoxMinimize, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBoxClose, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 30);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.MouseDown += tableLayoutPanel2_MouseDown;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Image = Properties.Resources.Minimize;
            pictureBoxMinimize.Location = new Point(743, 3);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(24, 24);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconSpark;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.Xwhite;
            pictureBoxClose.Location = new Point(773, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(24, 24);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.875F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.125F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 30);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(800, 420);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(pictureBoxGraph, 1, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel4.Controls.Add(labelResults, 1, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(431, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel4.Size = new Size(369, 420);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBoxGraph
            // 
            pictureBoxGraph.Dock = DockStyle.Fill;
            pictureBoxGraph.Location = new Point(23, 61);
            pictureBoxGraph.Name = "pictureBoxGraph";
            pictureBoxGraph.Size = new Size(323, 188);
            pictureBoxGraph.TabIndex = 0;
            pictureBoxGraph.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel7.Controls.Add(button1, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(23, 255);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(323, 64);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(108, 32);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Dock = DockStyle.Top;
            labelResults.ForeColor = Color.White;
            labelResults.Location = new Point(23, 322);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(323, 20);
            labelResults.TabIndex = 2;
            labelResults.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label1, 1, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 362F));
            tableLayoutPanel5.Size = new Size(431, 420);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 8);
            label1.Name = "label1";
            label1.Size = new Size(405, 50);
            label1.TabIndex = 0;
            label1.Text = "RLC circuit ";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel6.Controls.Add(comboBox4, 2, 3);
            tableLayoutPanel6.Controls.Add(comboBox3, 2, 2);
            tableLayoutPanel6.Controls.Add(comboBox2, 2, 1);
            tableLayoutPanel6.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel6.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel6.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(label4, 0, 2);
            tableLayoutPanel6.Controls.Add(label3, 0, 1);
            tableLayoutPanel6.Controls.Add(label5, 0, 3);
            tableLayoutPanel6.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel6.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel6.Controls.Add(label6, 0, 4);
            tableLayoutPanel6.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel6.Controls.Add(comboBox5, 2, 4);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(23, 61);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 6;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel6.Size = new Size(405, 356);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // comboBox4
            // 
            comboBox4.Dock = DockStyle.Bottom;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Hz", "kHz", "MHz", "GHz" });
            comboBox4.Location = new Point(291, 230);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(75, 28);
            comboBox4.TabIndex = 1;
            comboBox4.KeyPress += comboBox4_KeyPress;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Bottom;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "F", "mF", "µF", "nF", "pF" });
            comboBox3.Location = new Point(291, 160);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(75, 28);
            comboBox3.TabIndex = 1;
            comboBox3.KeyPress += comboBox3_KeyPress;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Bottom;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "H", "mH", "µH", "nH", "pH" });
            comboBox2.Location = new Point(291, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(75, 28);
            comboBox2.TabIndex = 1;
            comboBox2.KeyPress += comboBox2_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Bottom;
            textBox4.Location = new Point(44, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 27);
            textBox4.TabIndex = 7;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Bottom;
            textBox3.Location = new Point(44, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 27);
            textBox3.TabIndex = 6;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Bottom;
            textBox2.Location = new Point(44, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            helpProvider1.SetHelpString(label2, "Resistance");
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            helpProvider1.SetShowHelp(label2, true);
            label2.Size = new Size(35, 35);
            label2.TabIndex = 0;
            label2.Text = "R";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            helpProvider1.SetHelpString(label4, "Capacitance");
            label4.Location = new Point(3, 156);
            label4.Name = "label4";
            helpProvider1.SetShowHelp(label4, true);
            label4.Size = new Size(35, 35);
            label4.TabIndex = 2;
            label4.Text = "C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            helpProvider1.SetHelpString(label3, "Inductance");
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            helpProvider1.SetShowHelp(label3, true);
            label3.Size = new Size(35, 35);
            label3.TabIndex = 1;
            label3.Text = "L";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.White;
            helpProvider1.SetHelpString(label5, "Frequency");
            label5.Location = new Point(3, 226);
            label5.Name = "label5";
            helpProvider1.SetShowHelp(label5, true);
            label5.Size = new Size(35, 35);
            label5.TabIndex = 3;
            label5.Text = "f";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(44, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "mΩ", "Ω", "KΩ", "MΩ" });
            comboBox1.Location = new Point(291, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 28);
            comboBox1.TabIndex = 2;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            helpProvider1.SetHelpString(label6, "Frequency");
            label6.Location = new Point(3, 287);
            label6.Name = "label6";
            helpProvider1.SetShowHelp(label6, true);
            label6.Size = new Size(35, 35);
            label6.TabIndex = 8;
            label6.Text = "U";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Bottom;
            textBox5.Location = new Point(44, 292);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(241, 27);
            textBox5.TabIndex = 9;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // comboBox5
            // 
            comboBox5.Dock = DockStyle.Bottom;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "kV", "V", "mV", "µV" });
            comboBox5.Location = new Point(291, 291);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(75, 28);
            comboBox5.TabIndex = 10;
            comboBox5.KeyPress += comboBox5_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxClose;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBoxGraph;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private HelpProvider helpProvider1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button1;
        private Label label6;
        private TextBox textBox5;
        private ComboBox comboBox5;
        private Label labelResults;
    }
}
