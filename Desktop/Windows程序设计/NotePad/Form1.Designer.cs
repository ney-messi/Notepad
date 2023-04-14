namespace NotePad
{
    partial class NotePad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            this.menuNotepad = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectALL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsNotepad = new System.Windows.Forms.ToolStrip();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打开OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.剪切UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.复制CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.粘贴PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rtxtNotepad = new System.Windows.Forms.RichTextBox();
            this.stsNotepad = new System.Windows.Forms.StatusStrip();
            this.tssLb11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLb12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.odlgNotepad = new System.Windows.Forms.OpenFileDialog();
            this.sdlgNotepad = new System.Windows.Forms.SaveFileDialog();
            this.fdlgNotepad = new System.Windows.Forms.FontDialog();
            this.tmrNotepad = new System.Windows.Forms.Timer(this.components);
            this.menuNotepad.SuspendLayout();
            this.toolsNotepad.SuspendLayout();
            this.stsNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNotepad
            // 
            this.menuNotepad.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuNotepad.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiView,
            this.tsmiHelp});
            this.menuNotepad.Location = new System.Drawing.Point(0, 0);
            this.menuNotepad.Name = "menuNotepad";
            this.menuNotepad.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuNotepad.Size = new System.Drawing.Size(761, 36);
            this.menuNotepad.TabIndex = 0;
            this.menuNotepad.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.另存为AToolStripMenuItem,
            this.tsmiClose});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(84, 28);
            this.tsmiFile.Text = "文件(F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(242, 34);
            this.tsmiNew.Text = "新建(N)";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(242, 34);
            this.tsmiOpen.Text = "打开(O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(242, 34);
            this.tsmiSave.Text = "保存(S) ";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.另存为AToolStripMenuItem.Text = "另存为(A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.另存为AToolStripMenuItem_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(242, 34);
            this.tsmiClose.Text = "退出(X)";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.tsmiSelectALL,
            this.tsmiDate});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(84, 28);
            this.tsmiEdit.Text = "编辑(E)";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmiUndo.Size = new System.Drawing.Size(243, 34);
            this.tsmiUndo.Text = "撤销(U) ";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(243, 34);
            this.tsmiCopy.Text = "复制(C) ";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(243, 34);
            this.tsmiCut.Text = "剪切(T) ";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(243, 34);
            this.tsmiPaste.Text = "粘贴(P) ";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiSelectALL
            // 
            this.tsmiSelectALL.Name = "tsmiSelectALL";
            this.tsmiSelectALL.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectALL.Size = new System.Drawing.Size(243, 34);
            this.tsmiSelectALL.Text = "全选(A) ";
            this.tsmiSelectALL.Click += new System.EventHandler(this.tsmiSelectALL_Click);
            // 
            // tsmiDate
            // 
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiDate.Size = new System.Drawing.Size(243, 34);
            this.tsmiDate.Text = "日期(D)        ";
            this.tsmiDate.Click += new System.EventHandler(this.tsmiDate_Click);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAuto,
            this.tsmiFont});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(89, 28);
            this.tsmiFormat.Text = "格式(O)";
            // 
            // tsmiAuto
            // 
            this.tsmiAuto.Checked = true;
            this.tsmiAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAuto.Name = "tsmiAuto";
            this.tsmiAuto.Size = new System.Drawing.Size(212, 34);
            this.tsmiAuto.Text = "自动换行(M)";
            this.tsmiAuto.Click += new System.EventHandler(this.tsmiAuto_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(212, 34);
            this.tsmiFont.Text = "字体(F)";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolStrip,
            this.tsmiStatusStrip});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(86, 28);
            this.tsmiView.Text = "查看(V)";
            // 
            // tsmiToolStrip
            // 
            this.tsmiToolStrip.Checked = true;
            this.tsmiToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolStrip.Name = "tsmiToolStrip";
            this.tsmiToolStrip.Size = new System.Drawing.Size(186, 34);
            this.tsmiToolStrip.Text = "工具栏(T)";
            this.tsmiToolStrip.Click += new System.EventHandler(this.tsmiToolStrip_Click);
            // 
            // tsmiStatusStrip
            // 
            this.tsmiStatusStrip.Checked = true;
            this.tsmiStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusStrip.Name = "tsmiStatusStrip";
            this.tsmiStatusStrip.Size = new System.Drawing.Size(186, 34);
            this.tsmiStatusStrip.Text = "状态栏(S)";
            this.tsmiStatusStrip.Click += new System.EventHandler(this.tsmiStatusStrip_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(88, 28);
            this.tsmiHelp.Text = "帮助(H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(225, 34);
            this.tsmiAbout.Text = "关于记事本(A)";
            this.tsmiAbout.Click += new System.EventHandler(this.关于记事本AToolStripMenuItem_Click);
            // 
            // toolsNotepad
            // 
            this.toolsNotepad.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripButton,
            this.打开OToolStripButton,
            this.保存SToolStripButton,
            this.打印PToolStripButton,
            this.toolStripSeparator,
            this.剪切UToolStripButton,
            this.复制CToolStripButton,
            this.粘贴PToolStripButton,
            this.toolStripSeparator1,
            this.帮助LToolStripButton});
            this.toolsNotepad.Location = new System.Drawing.Point(0, 36);
            this.toolsNotepad.Name = "toolsNotepad";
            this.toolsNotepad.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolsNotepad.Size = new System.Drawing.Size(761, 38);
            this.toolsNotepad.TabIndex = 1;
            this.toolsNotepad.Text = "toolStrip1";
            this.toolsNotepad.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolsNotepad_ItemClicked);
            // 
            // 新建NToolStripButton
            // 
            this.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新建NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.新建NToolStripButton.Text = "新建(&N)";
            this.新建NToolStripButton.Click += new System.EventHandler(this.新建NToolStripButton_Click);
            // 
            // 打开OToolStripButton
            // 
            this.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripButton.Image")));
            this.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripButton.Name = "打开OToolStripButton";
            this.打开OToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.打开OToolStripButton.Text = "打开(&O)";
            this.打开OToolStripButton.Click += new System.EventHandler(this.打开OToolStripButton_Click);
            // 
            // 保存SToolStripButton
            // 
            this.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripButton.Image")));
            this.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripButton.Name = "保存SToolStripButton";
            this.保存SToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.保存SToolStripButton.Text = "保存(&S)";
            this.保存SToolStripButton.Click += new System.EventHandler(this.保存SToolStripButton_Click);
            // 
            // 打印PToolStripButton
            // 
            this.打印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripButton.Image")));
            this.打印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripButton.Name = "打印PToolStripButton";
            this.打印PToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.打印PToolStripButton.Text = "打印(&P)";
            this.打印PToolStripButton.Click += new System.EventHandler(this.打印PToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // 剪切UToolStripButton
            // 
            this.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪切UToolStripButton.Image")));
            this.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切UToolStripButton.Name = "剪切UToolStripButton";
            this.剪切UToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.剪切UToolStripButton.Text = "剪切(&U)";
            this.剪切UToolStripButton.Click += new System.EventHandler(this.剪切UToolStripButton_Click);
            // 
            // 复制CToolStripButton
            // 
            this.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripButton.Image")));
            this.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripButton.Name = "复制CToolStripButton";
            this.复制CToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.复制CToolStripButton.Text = "复制(&C)";
            this.复制CToolStripButton.Click += new System.EventHandler(this.复制CToolStripButton_Click);
            // 
            // 粘贴PToolStripButton
            // 
            this.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripButton.Image")));
            this.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripButton.Name = "粘贴PToolStripButton";
            this.粘贴PToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.粘贴PToolStripButton.Text = "粘贴(&P)";
            this.粘贴PToolStripButton.Click += new System.EventHandler(this.粘贴PToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // 帮助LToolStripButton
            // 
            this.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.帮助LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("帮助LToolStripButton.Image")));
            this.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.帮助LToolStripButton.Name = "帮助LToolStripButton";
            this.帮助LToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.帮助LToolStripButton.Text = "帮助(&L)";
            this.帮助LToolStripButton.Click += new System.EventHandler(this.帮助LToolStripButton_Click);
            // 
            // rtxtNotepad
            // 
            this.rtxtNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotepad.Location = new System.Drawing.Point(8, 65);
            this.rtxtNotepad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtNotepad.Name = "rtxtNotepad";
            this.rtxtNotepad.Size = new System.Drawing.Size(747, 347);
            this.rtxtNotepad.TabIndex = 2;
            this.rtxtNotepad.Text = "";
            this.rtxtNotepad.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // stsNotepad
            // 
            this.stsNotepad.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLb11,
            this.tssLb12});
            this.stsNotepad.Location = new System.Drawing.Point(0, 388);
            this.stsNotepad.Name = "stsNotepad";
            this.stsNotepad.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.stsNotepad.Size = new System.Drawing.Size(761, 31);
            this.stsNotepad.TabIndex = 3;
            this.stsNotepad.Text = "statusStrip1";
            this.stsNotepad.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsNotepad_ItemClicked);
            // 
            // tssLb11
            // 
            this.tssLb11.AutoToolTip = true;
            this.tssLb11.Name = "tssLb11";
            this.tssLb11.Size = new System.Drawing.Size(46, 24);
            this.tssLb11.Text = "就绪";
            this.tssLb11.Click += new System.EventHandler(this.tssLb11_Click);
            // 
            // tssLb12
            // 
            this.tssLb12.AutoToolTip = true;
            this.tssLb12.Name = "tssLb12";
            this.tssLb12.Size = new System.Drawing.Size(136, 24);
            this.tssLb12.Text = "显示日期、时间";
            this.tssLb12.Click += new System.EventHandler(this.tssLb12_Click);
            // 
            // odlgNotepad
            // 
            this.odlgNotepad.FileName = "openFileDialog1";
            this.odlgNotepad.Filter = "RTF文件|*.rtf|所有文件|*.*";
            // 
            // sdlgNotepad
            // 
            this.sdlgNotepad.FileName = "无标题";
            this.sdlgNotepad.Filter = "RTF文件|*.rtf";
            // 
            // tmrNotepad
            // 
            this.tmrNotepad.Enabled = true;
            this.tmrNotepad.Interval = 1000;
            this.tmrNotepad.Tick += new System.EventHandler(this.tmrNotepad_Tick);
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 419);
            this.Controls.Add(this.stsNotepad);
            this.Controls.Add(this.rtxtNotepad);
            this.Controls.Add(this.toolsNotepad);
            this.Controls.Add(this.menuNotepad);
            this.MainMenuStrip = this.menuNotepad;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本";
            this.Load += new System.EventHandler(this.NotePad_Load);
            this.menuNotepad.ResumeLayout(false);
            this.menuNotepad.PerformLayout();
            this.toolsNotepad.ResumeLayout(false);
            this.toolsNotepad.PerformLayout();
            this.stsNotepad.ResumeLayout(false);
            this.stsNotepad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectALL;
        private System.Windows.Forms.ToolStripMenuItem tsmiDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiAuto;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip toolsNotepad;
        private System.Windows.Forms.ToolStripButton 新建NToolStripButton;
        private System.Windows.Forms.ToolStripButton 打开OToolStripButton;
        private System.Windows.Forms.ToolStripButton 保存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 打印PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 剪切UToolStripButton;
        private System.Windows.Forms.ToolStripButton 复制CToolStripButton;
        private System.Windows.Forms.ToolStripButton 粘贴PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 帮助LToolStripButton;
        private System.Windows.Forms.RichTextBox rtxtNotepad;
        private System.Windows.Forms.StatusStrip stsNotepad;
        private System.Windows.Forms.ToolStripStatusLabel tssLb11;
        private System.Windows.Forms.ToolStripStatusLabel tssLb12;
        private System.Windows.Forms.OpenFileDialog odlgNotepad;
        private System.Windows.Forms.SaveFileDialog sdlgNotepad;
        private System.Windows.Forms.FontDialog fdlgNotepad;
        private System.Windows.Forms.Timer tmrNotepad;
    }
}

