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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.doTagStripCheck = new System.Windows.Forms.CheckBox();
            this.aTagHrefCheck = new System.Windows.Forms.CheckBox();
            this.doBrReplaceCheck = new System.Windows.Forms.CheckBox();
            this.ampCodeStripCheck = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rootUrlText = new System.Windows.Forms.TextBox();
            this.doAddRootPrefixCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.browserControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.44304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.55696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputText
            // 
            this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.Location = new System.Drawing.Point(3, 217);
            this.inputText.MaxLength = 0;
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputText.Size = new System.Drawing.Size(571, 166);
            this.inputText.TabIndex = 0;
            // 
            // browserControl
            // 
            this.browserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserControl.Location = new System.Drawing.Point(3, 3);
            this.browserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserControl.Name = "browserControl";
            this.browserControl.Size = new System.Drawing.Size(571, 208);
            this.browserControl.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.domStructButton);
            this.flowLayoutPanel1.Controls.Add(this.saveTSVButton);
            this.flowLayoutPanel1.Controls.Add(this.domResetButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 450);
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
            this.domStructButton.Click += new System.EventHandler(this.domStructButton_Click);
            // 
            // saveTSVButton
            // 
            this.saveTSVButton.Location = new System.Drawing.Point(84, 3);
            this.saveTSVButton.Name = "saveTSVButton";
            this.saveTSVButton.Size = new System.Drawing.Size(75, 23);
            this.saveTSVButton.TabIndex = 1;
            this.saveTSVButton.Text = "TSV保存";
            this.saveTSVButton.UseVisualStyleBackColor = true;
            this.saveTSVButton.Click += new System.EventHandler(this.saveTSVButton_Click);
            // 
            // domResetButton
            // 
            this.domResetButton.Location = new System.Drawing.Point(165, 3);
            this.domResetButton.Name = "domResetButton";
            this.domResetButton.Size = new System.Drawing.Size(75, 23);
            this.domResetButton.TabIndex = 2;
            this.domResetButton.Text = "リセット";
            this.domResetButton.UseVisualStyleBackColor = true;
            this.domResetButton.Click += new System.EventHandler(this.domResetButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ampCodeStripCheck);
            this.flowLayoutPanel2.Controls.Add(this.doTagStripCheck);
            this.flowLayoutPanel2.Controls.Add(this.doBrReplaceCheck);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(168, 389);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(406, 22);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // doTagStripCheck
            // 
            this.doTagStripCheck.AutoSize = true;
            this.doTagStripCheck.Location = new System.Drawing.Point(117, 3);
            this.doTagStripCheck.Name = "doTagStripCheck";
            this.doTagStripCheck.Size = new System.Drawing.Size(97, 16);
            this.doTagStripCheck.TabIndex = 0;
            this.doTagStripCheck.Text = "セル内タグ除去";
            this.doTagStripCheck.UseVisualStyleBackColor = true;
            // 
            // aTagHrefCheck
            // 
            this.aTagHrefCheck.AutoSize = true;
            this.aTagHrefCheck.Location = new System.Drawing.Point(3, 6);
            this.aTagHrefCheck.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.aTagHrefCheck.Name = "aTagHrefCheck";
            this.aTagHrefCheck.Size = new System.Drawing.Size(127, 16);
            this.aTagHrefCheck.TabIndex = 1;
            this.aTagHrefCheck.Text = "aタグの場合URL抽出";
            this.aTagHrefCheck.UseVisualStyleBackColor = true;
            // 
            // doBrReplaceCheck
            // 
            this.doBrReplaceCheck.AutoSize = true;
            this.doBrReplaceCheck.Location = new System.Drawing.Point(220, 3);
            this.doBrReplaceCheck.Name = "doBrReplaceCheck";
            this.doBrReplaceCheck.Size = new System.Drawing.Size(105, 16);
            this.doBrReplaceCheck.TabIndex = 2;
            this.doBrReplaceCheck.Text = "brタグを｜に変換";
            this.doBrReplaceCheck.UseVisualStyleBackColor = true;
            // 
            // ampCodeStripCheck
            // 
            this.ampCodeStripCheck.AutoSize = true;
            this.ampCodeStripCheck.Location = new System.Drawing.Point(3, 3);
            this.ampCodeStripCheck.Name = "ampCodeStripCheck";
            this.ampCodeStripCheck.Size = new System.Drawing.Size(108, 16);
            this.ampCodeStripCheck.TabIndex = 3;
            this.ampCodeStripCheck.Text = "＆実体参照除去";
            this.ampCodeStripCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.aTagHrefCheck);
            this.flowLayoutPanel3.Controls.Add(this.doAddRootPrefixCheck);
            this.flowLayoutPanel3.Controls.Add(this.rootUrlText);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(30, 417);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(544, 27);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // rootUrlText
            // 
            this.rootUrlText.Location = new System.Drawing.Point(240, 3);
            this.rootUrlText.Name = "rootUrlText";
            this.rootUrlText.Size = new System.Drawing.Size(288, 19);
            this.rootUrlText.TabIndex = 0;
            // 
            // doAddRootPrefixCheck
            // 
            this.doAddRootPrefixCheck.AutoSize = true;
            this.doAddRootPrefixCheck.Location = new System.Drawing.Point(136, 6);
            this.doAddRootPrefixCheck.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.doAddRootPrefixCheck.Name = "doAddRootPrefixCheck";
            this.doAddRootPrefixCheck.Size = new System.Drawing.Size(98, 16);
            this.doAddRootPrefixCheck.TabIndex = 2;
            this.doAddRootPrefixCheck.Text = "ルートURL付与";
            this.doAddRootPrefixCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "table2tsv";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox doTagStripCheck;
        private System.Windows.Forms.CheckBox aTagHrefCheck;
        private System.Windows.Forms.CheckBox doBrReplaceCheck;
        private System.Windows.Forms.CheckBox ampCodeStripCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox doAddRootPrefixCheck;
        private System.Windows.Forms.TextBox rootUrlText;
    }
}

