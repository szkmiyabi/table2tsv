namespace table2tsv
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputText = new System.Windows.Forms.TextBox();
            this.browserControl = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.domStructButton = new System.Windows.Forms.Button();
            this.saveTSVButton = new System.Windows.Forms.Button();
            this.domResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.browserControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.81638F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.18362F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputText
            // 
            this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.Location = new System.Drawing.Point(3, 236);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(571, 164);
            this.inputText.TabIndex = 0;
            // 
            // browserControl
            // 
            this.browserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserControl.Location = new System.Drawing.Point(3, 3);
            this.browserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserControl.Name = "browserControl";
            this.browserControl.Size = new System.Drawing.Size(571, 227);
            this.browserControl.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.domStructButton);
            this.flowLayoutPanel1.Controls.Add(this.saveTSVButton);
            this.flowLayoutPanel1.Controls.Add(this.domResetButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 406);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // domStructButton
            // 
            this.domStructButton.Location = new System.Drawing.Point(3, 3);
            this.domStructButton.Name = "domStructButton";
            this.domStructButton.Size = new System.Drawing.Size(75, 23);
            this.domStructButton.TabIndex = 0;
            this.domStructButton.Text = "DOM構築";
            this.domStructButton.UseVisualStyleBackColor = true;
            // 
            // saveTSVButton
            // 
            this.saveTSVButton.Location = new System.Drawing.Point(84, 3);
            this.saveTSVButton.Name = "saveTSVButton";
            this.saveTSVButton.Size = new System.Drawing.Size(75, 23);
            this.saveTSVButton.TabIndex = 1;
            this.saveTSVButton.Text = "TSV保存";
            this.saveTSVButton.UseVisualStyleBackColor = true;
            // 
            // domResetButton
            // 
            this.domResetButton.Location = new System.Drawing.Point(165, 3);
            this.domResetButton.Name = "domResetButton";
            this.domResetButton.Size = new System.Drawing.Size(75, 23);
            this.domResetButton.TabIndex = 2;
            this.domResetButton.Text = "リセット";
            this.domResetButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "table2csv";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.WebBrowser browserControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button domStructButton;
        private System.Windows.Forms.Button saveTSVButton;
        private System.Windows.Forms.Button domResetButton;
    }
}

