
namespace DbFirstTest
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новыйКомпонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewParentComponent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewChildComponent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameComponent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteComponent_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateReport_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(10, 11);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(398, 329);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйКомпонентToolStripMenuItem,
            this.RenameComponent_ToolStripMenuItem,
            this.DeleteComponent_ToolStripMenuItem,
            this.CreateReport_ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(213, 114);
            // 
            // новыйКомпонентToolStripMenuItem
            // 
            this.новыйКомпонентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewParentComponent_ToolStripMenuItem,
            this.NewChildComponent_ToolStripMenuItem});
            this.новыйКомпонентToolStripMenuItem.Name = "новыйКомпонентToolStripMenuItem";
            this.новыйКомпонентToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.новыйКомпонентToolStripMenuItem.Text = "Новый компонент";
            // 
            // NewParentComponent_ToolStripMenuItem
            // 
            this.NewParentComponent_ToolStripMenuItem.Name = "NewParentComponent_ToolStripMenuItem";
            this.NewParentComponent_ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.NewParentComponent_ToolStripMenuItem.Text = "Компонент верхнего уровня";
            this.NewParentComponent_ToolStripMenuItem.Click += new System.EventHandler(this.NewParentComponent_ToolStripMenuItem_Click);
            // 
            // NewChildComponent_ToolStripMenuItem
            // 
            this.NewChildComponent_ToolStripMenuItem.Name = "NewChildComponent_ToolStripMenuItem";
            this.NewChildComponent_ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.NewChildComponent_ToolStripMenuItem.Text = "Вложенный компонент";
            this.NewChildComponent_ToolStripMenuItem.Click += new System.EventHandler(this.NewChildComponent_ToolStripMenuItem_Click);
            // 
            // RenameComponent_ToolStripMenuItem
            // 
            this.RenameComponent_ToolStripMenuItem.Name = "RenameComponent_ToolStripMenuItem";
            this.RenameComponent_ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.RenameComponent_ToolStripMenuItem.Text = "Переименовать";
            this.RenameComponent_ToolStripMenuItem.Click += new System.EventHandler(this.RenameComponent_ToolStripMenuItem_Click);
            // 
            // DeleteComponent_ToolStripMenuItem
            // 
            this.DeleteComponent_ToolStripMenuItem.Name = "DeleteComponent_ToolStripMenuItem";
            this.DeleteComponent_ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.DeleteComponent_ToolStripMenuItem.Text = "Удалить";
            this.DeleteComponent_ToolStripMenuItem.Click += new System.EventHandler(this.DeleteComponent_ToolStripMenuItem_Click);
            // 
            // CreateReport_ToolStripMenuItem
            // 
            this.CreateReport_ToolStripMenuItem.Name = "CreateReport_ToolStripMenuItem";
            this.CreateReport_ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.CreateReport_ToolStripMenuItem.Text = "Отчёт о сводном составе";
            this.CreateReport_ToolStripMenuItem.Click += new System.EventHandler(this.CreateReport_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 349);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.treeView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр компонентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem новыйКомпонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewParentComponent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewChildComponent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameComponent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteComponent_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateReport_ToolStripMenuItem;
    }
}

