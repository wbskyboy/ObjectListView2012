﻿using BrightIdeasSoftware;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ObjectListViewDemo
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId = "System.Windows.Forms.Control.set_Text(System.String)")]
		private void InitializeComponent()
		{
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabSimple = new ObjectListViewDemo.TabSimpleExample();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabComplex = new ObjectListViewDemo.TabComplexExample();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabDataSet = new ObjectListViewDemo.TabDataSet();
            this.tabPageFileExplorer = new System.Windows.Forms.TabPage();
            this.tabFileExplorer1 = new ObjectListViewDemo.TabFileExplorer();
            this.tabPageFastList = new System.Windows.Forms.TabPage();
            this.tabFastList1 = new ObjectListViewDemo.TabFastList();
            this.tabPageTreeListView = new System.Windows.Forms.TabPage();
            this.tabTreeListView1 = new ObjectListViewDemo.TabTreeListView();
            this.tabPageDataTreeListView = new System.Windows.Forms.TabPage();
            this.tabDataTreeListView1 = new ObjectListViewDemo.TabDataTreeListView();
            this.tabPagePrinting = new System.Windows.Forms.TabPage();
            this.tabPrinting1 = new ObjectListViewDemo.TabPrinting();
            this.tabPageDragAndDrop = new System.Windows.Forms.TabPage();
            this.tabDragAndDrop1 = new ObjectListViewDemo.TabDragAndDrop();
            this.tabDescribedTasks = new System.Windows.Forms.TabPage();
            this.tabDescribedTask1 = new ObjectListViewDemo.TabDescribedTask();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPageFileExplorer.SuspendLayout();
            this.tabPageFastList.SuspendLayout();
            this.tabPageTreeListView.SuspendLayout();
            this.tabPageDataTreeListView.SuspendLayout();
            this.tabPagePrinting.SuspendLayout();
            this.tabPageDragAndDrop.SuspendLayout();
            this.tabDescribedTasks.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(1323, 20);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPageFileExplorer);
            this.tabControl1.Controls.Add(this.tabPageFastList);
            this.tabControl1.Controls.Add(this.tabPageTreeListView);
            this.tabControl1.Controls.Add(this.tabPageDataTreeListView);
            this.tabControl1.Controls.Add(this.tabPagePrinting);
            this.tabControl1.Controls.Add(this.tabPageDragAndDrop);
            this.tabControl1.Controls.Add(this.tabDescribedTasks);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1343, 755);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabSimple);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1335, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple Example";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabSimple
            // 
            this.tabSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSimple.Location = new System.Drawing.Point(4, 3);
            this.tabSimple.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabSimple.Name = "tabSimple";
            this.tabSimple.Size = new System.Drawing.Size(1327, 720);
            this.tabSimple.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabComplex);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1335, 726);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complex Example";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabComplex
            // 
            this.tabComplex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabComplex.Location = new System.Drawing.Point(4, 3);
            this.tabComplex.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabComplex.Name = "tabComplex";
            this.tabComplex.Size = new System.Drawing.Size(1327, 720);
            this.tabComplex.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.tabDataSet);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage11.Size = new System.Drawing.Size(1335, 726);
            this.tabPage11.TabIndex = 11;
            this.tabPage11.Text = "DataListView";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabDataSet
            // 
            this.tabDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDataSet.Location = new System.Drawing.Point(4, 3);
            this.tabDataSet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabDataSet.Name = "tabDataSet";
            this.tabDataSet.Size = new System.Drawing.Size(1327, 720);
            this.tabDataSet.TabIndex = 0;
            // 
            // tabPageFileExplorer
            // 
            this.tabPageFileExplorer.Controls.Add(this.tabFileExplorer1);
            this.tabPageFileExplorer.Location = new System.Drawing.Point(4, 25);
            this.tabPageFileExplorer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageFileExplorer.Name = "tabPageFileExplorer";
            this.tabPageFileExplorer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageFileExplorer.Size = new System.Drawing.Size(1335, 726);
            this.tabPageFileExplorer.TabIndex = 12;
            this.tabPageFileExplorer.Text = "File Explorer";
            this.tabPageFileExplorer.UseVisualStyleBackColor = true;
            // 
            // tabFileExplorer1
            // 
            this.tabFileExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFileExplorer1.Location = new System.Drawing.Point(4, 3);
            this.tabFileExplorer1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabFileExplorer1.Name = "tabFileExplorer1";
            this.tabFileExplorer1.Size = new System.Drawing.Size(1327, 720);
            this.tabFileExplorer1.TabIndex = 0;
            // 
            // tabPageFastList
            // 
            this.tabPageFastList.Controls.Add(this.tabFastList1);
            this.tabPageFastList.Location = new System.Drawing.Point(4, 25);
            this.tabPageFastList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageFastList.Name = "tabPageFastList";
            this.tabPageFastList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageFastList.Size = new System.Drawing.Size(1302, 683);
            this.tabPageFastList.TabIndex = 13;
            this.tabPageFastList.Text = "Fast List";
            this.tabPageFastList.UseVisualStyleBackColor = true;
            // 
            // tabFastList1
            // 
            this.tabFastList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFastList1.Location = new System.Drawing.Point(5, 5);
            this.tabFastList1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabFastList1.Name = "tabFastList1";
            this.tabFastList1.Size = new System.Drawing.Size(1067, 577);
            this.tabFastList1.TabIndex = 0;
            // 
            // tabPageTreeListView
            // 
            this.tabPageTreeListView.Controls.Add(this.tabTreeListView1);
            this.tabPageTreeListView.Location = new System.Drawing.Point(4, 25);
            this.tabPageTreeListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTreeListView.Name = "tabPageTreeListView";
            this.tabPageTreeListView.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageTreeListView.Size = new System.Drawing.Size(1335, 726);
            this.tabPageTreeListView.TabIndex = 14;
            this.tabPageTreeListView.Text = "TreeListView";
            this.tabPageTreeListView.UseVisualStyleBackColor = true;
            // 
            // tabTreeListView1
            // 
            this.tabTreeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTreeListView1.Location = new System.Drawing.Point(4, 3);
            this.tabTreeListView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabTreeListView1.Name = "tabTreeListView1";
            this.tabTreeListView1.Size = new System.Drawing.Size(1327, 720);
            this.tabTreeListView1.TabIndex = 0;
            // 
            // tabPageDataTreeListView
            // 
            this.tabPageDataTreeListView.Controls.Add(this.tabDataTreeListView1);
            this.tabPageDataTreeListView.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataTreeListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageDataTreeListView.Name = "tabPageDataTreeListView";
            this.tabPageDataTreeListView.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageDataTreeListView.Size = new System.Drawing.Size(1335, 726);
            this.tabPageDataTreeListView.TabIndex = 15;
            this.tabPageDataTreeListView.Text = "DataTreeListView";
            this.tabPageDataTreeListView.UseVisualStyleBackColor = true;
            // 
            // tabDataTreeListView1
            // 
            this.tabDataTreeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDataTreeListView1.Location = new System.Drawing.Point(4, 3);
            this.tabDataTreeListView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabDataTreeListView1.Name = "tabDataTreeListView1";
            this.tabDataTreeListView1.Size = new System.Drawing.Size(1327, 720);
            this.tabDataTreeListView1.TabIndex = 0;
            // 
            // tabPagePrinting
            // 
            this.tabPagePrinting.Controls.Add(this.tabPrinting1);
            this.tabPagePrinting.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrinting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPagePrinting.Name = "tabPagePrinting";
            this.tabPagePrinting.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPagePrinting.Size = new System.Drawing.Size(1335, 726);
            this.tabPagePrinting.TabIndex = 16;
            this.tabPagePrinting.Text = "Printing ListViews";
            this.tabPagePrinting.UseVisualStyleBackColor = true;
            // 
            // tabPrinting1
            // 
            this.tabPrinting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrinting1.Location = new System.Drawing.Point(4, 3);
            this.tabPrinting1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabPrinting1.Name = "tabPrinting1";
            this.tabPrinting1.Size = new System.Drawing.Size(1327, 720);
            this.tabPrinting1.TabIndex = 0;
            // 
            // tabPageDragAndDrop
            // 
            this.tabPageDragAndDrop.Controls.Add(this.tabDragAndDrop1);
            this.tabPageDragAndDrop.Location = new System.Drawing.Point(4, 25);
            this.tabPageDragAndDrop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageDragAndDrop.Name = "tabPageDragAndDrop";
            this.tabPageDragAndDrop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageDragAndDrop.Size = new System.Drawing.Size(1335, 726);
            this.tabPageDragAndDrop.TabIndex = 17;
            this.tabPageDragAndDrop.Text = "Drag and drop";
            this.tabPageDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // tabDragAndDrop1
            // 
            this.tabDragAndDrop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDragAndDrop1.Location = new System.Drawing.Point(4, 3);
            this.tabDragAndDrop1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDragAndDrop1.Name = "tabDragAndDrop1";
            this.tabDragAndDrop1.Size = new System.Drawing.Size(1327, 720);
            this.tabDragAndDrop1.TabIndex = 0;
            // 
            // tabDescribedTasks
            // 
            this.tabDescribedTasks.Controls.Add(this.tabDescribedTask1);
            this.tabDescribedTasks.Location = new System.Drawing.Point(4, 25);
            this.tabDescribedTasks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDescribedTasks.Name = "tabDescribedTasks";
            this.tabDescribedTasks.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDescribedTasks.Size = new System.Drawing.Size(1335, 726);
            this.tabDescribedTasks.TabIndex = 18;
            this.tabDescribedTasks.Text = "Pretty Tasks";
            this.tabDescribedTasks.UseVisualStyleBackColor = true;
            // 
            // tabDescribedTask1
            // 
            this.tabDescribedTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDescribedTask1.Location = new System.Drawing.Point(4, 3);
            this.tabDescribedTask1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tabDescribedTask1.Name = "tabDescribedTask1";
            this.tabDescribedTask1.Size = new System.Drawing.Size(1327, 720);
            this.tabDescribedTask1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(0, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(200, 100);
            this.tabPage7.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 729);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1343, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 755);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "ObjectListView Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPageFileExplorer.ResumeLayout(false);
            this.tabPageFastList.ResumeLayout(false);
            this.tabPageTreeListView.ResumeLayout(false);
            this.tabPageDataTreeListView.ResumeLayout(false);
            this.tabPagePrinting.ResumeLayout(false);
            this.tabPageDragAndDrop.ResumeLayout(false);
            this.tabDescribedTasks.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
        private TabSimpleExample tabSimple;
        private TabComplexExample tabComplex;
        private TabDataSet tabDataSet;
        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage7;
        public ToolStripStatusLabel toolStripStatusLabel3;
        public ToolStripStatusLabel toolStripStatusLabel1;
        private TabPage tabPage11;
        private TabPage tabPageFileExplorer;
        private TabFileExplorer tabFileExplorer1;
        private TabPage tabPageFastList;
        private TabFastList tabFastList1;
        private TabPage tabPageTreeListView;
        private TabTreeListView tabTreeListView1;
        private TabPage tabPageDataTreeListView;
        private TabDataTreeListView tabDataTreeListView1;
        private TabPage tabPagePrinting;
        private TabPrinting tabPrinting1;
        private TabPage tabPageDragAndDrop;
        private TabPage tabDescribedTasks;
        private TabDescribedTask tabDescribedTask1;
        private TabDragAndDrop tabDragAndDrop1;
    }
}
