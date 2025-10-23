namespace shash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            headerPanel = new Panel();
            flowTop = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            splitContainer1 = new SplitContainer();
            panelLeft = new Panel();
            richTextBox1 = new RichTextBox();
            panelRight = new Panel();
            richTextBox2 = new RichTextBox();
            flowBottom = new FlowLayoutPanel();
            button1 = new Button();
            buttonCopy = new Button();
            buttonClear = new Button();
            statusLabel = new Label();
            tabPage2 = new TabPage();
            placeholderLabel = new Label();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            headerPanel.SuspendLayout();
            flowTop.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            flowBottom.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 480);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(712, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Text Encryption";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(headerPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowBottom, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(706, 446);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(flowTop);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(15, 15);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(676, 94);
            headerPanel.TabIndex = 0;
            // 
            // flowTop
            // 
            flowTop.Controls.Add(label1);
            flowTop.Controls.Add(textBox1);
            flowTop.Controls.Add(groupBox1);
            flowTop.Dock = DockStyle.Fill;
            flowTop.Location = new Point(0, 0);
            flowTop.Margin = new Padding(0, 6, 0, 0);
            flowTop.Name = "flowTop";
            flowTop.Size = new Size(676, 94);
            flowTop.TabIndex = 1;
            flowTop.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 8);
            label1.Margin = new Padding(0, 8, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Passphrase:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 4);
            textBox1.Margin = new Padding(0, 4, 12, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 1;
            toolTip1.SetToolTip(textBox1, "Enter a passphrase used to derive the encryption key. Leave empty for no passphrase.");
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(406, 4);
            groupBox1.Margin = new Padding(0, 4, 0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(251, 68);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mode";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Text -> Cipher";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(140, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Cipher -> Text";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(12, 124);
            splitContainer1.Margin = new Padding(0, 12, 0, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelRight);
            splitContainer1.Size = new Size(682, 250);
            splitContainer1.SplitterDistance = 339;
            splitContainer1.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(richTextBox1);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(6);
            panelLeft.Size = new Size(339, 250);
            panelLeft.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 9F);
            richTextBox1.Location = new Point(6, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 238);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(richTextBox2);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(0, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(6);
            panelRight.Size = new Size(339, 250);
            panelRight.TabIndex = 0;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Window;
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Font = new Font("Consolas", 9F);
            richTextBox2.Location = new Point(6, 6);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(327, 238);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // flowBottom
            // 
            flowBottom.AutoSize = true;
            flowBottom.Controls.Add(button1);
            flowBottom.Controls.Add(buttonCopy);
            flowBottom.Controls.Add(buttonClear);
            flowBottom.Controls.Add(statusLabel);
            flowBottom.Dock = DockStyle.Fill;
            flowBottom.Location = new Point(15, 389);
            flowBottom.Name = "flowBottom";
            flowBottom.Padding = new Padding(4);
            flowBottom.Size = new Size(676, 42);
            flowBottom.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(4, 8);
            button1.Margin = new Padding(0, 4, 8, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(6, 2, 6, 2);
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "Process";
            toolTip1.SetToolTip(button1, "Encrypt or decrypt depending on selected mode.");
            button1.Click += button1_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.AutoSize = true;
            buttonCopy.Location = new Point(87, 8);
            buttonCopy.Margin = new Padding(0, 4, 8, 4);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Padding = new Padding(6, 2, 6, 2);
            buttonCopy.Size = new Size(102, 29);
            buttonCopy.TabIndex = 1;
            buttonCopy.Text = "Copy Output";
            toolTip1.SetToolTip(buttonCopy, "Copy the output text to the clipboard.");
            buttonCopy.Click += buttonCopy_Click;
            // 
            // buttonClear
            // 
            buttonClear.AutoSize = true;
            buttonClear.Location = new Point(197, 8);
            buttonClear.Margin = new Padding(0, 4, 8, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Padding = new Padding(6, 2, 6, 2);
            buttonClear.Size = new Size(75, 29);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            toolTip1.SetToolTip(buttonClear, "Clear both input and output.");
            buttonClear.Click += buttonClear_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.DimGray;
            statusLabel.Location = new Point(292, 14);
            statusLabel.Margin = new Padding(12, 10, 0, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 15);
            statusLabel.TabIndex = 3;
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(placeholderLabel);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(712, 452);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "placeholder";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // placeholderLabel
            // 
            placeholderLabel.Dock = DockStyle.Fill;
            placeholderLabel.Location = new Point(3, 3);
            placeholderLabel.Name = "placeholderLabel";
            placeholderLabel.Size = new Size(706, 446);
            placeholderLabel.TabIndex = 0;
            placeholderLabel.Text = "placeholder";
            placeholderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 480);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "shash";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            headerPanel.ResumeLayout(false);
            flowTop.ResumeLayout(false);
            flowTop.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            flowBottom.ResumeLayout(false);
            flowBottom.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label headerLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowTop;
        private Panel headerPanel;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private SplitContainer splitContainer1;
        private Panel panelLeft;
        private RichTextBox richTextBox1;
        private Panel panelRight;
        private RichTextBox richTextBox2;
        private FlowLayoutPanel flowBottom;
        private Button button1;
        private Button buttonCopy;
        private Button buttonClear;
        private ToolTip toolTip1;
        private Label statusLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label placeholderLabel;
    }
}