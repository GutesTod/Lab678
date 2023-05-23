namespace laba_4._1n
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
            mark_more = new CheckBox();
            treeView1 = new TreeView();
            layoutControls = new FlowLayoutPanel();
            btnLoad = new Button();
            btnSave = new Button();
            btnGroup = new Button();
            btnDelete = new Button();
            layoutFigures = new TableLayoutPanel();
            btnSquare = new Button();
            btnTriangle = new Button();
            btnCircle = new Button();
            justtext = new Label();
            cur_figure = new Label();
            layoutControls.SuspendLayout();
            layoutFigures.SuspendLayout();
            SuspendLayout();
            // 
            // mark_more
            // 
            mark_more.AutoSize = true;
            mark_more.Location = new Point(5, 131);
            mark_more.Name = "mark_more";
            mark_more.Size = new Size(101, 24);
            mark_more.TabIndex = 0;
            mark_more.Text = "Mul circles";
            mark_more.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(5, 161);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(266, 223);
            treeView1.TabIndex = 3;
            treeView1.AfterCheck += treeView1_AfterCheck;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // layoutControls
            // 
            layoutControls.Controls.Add(btnLoad);
            layoutControls.Controls.Add(btnSave);
            layoutControls.Controls.Add(btnGroup);
            layoutControls.Controls.Add(btnDelete);
            layoutControls.Location = new Point(5, 390);
            layoutControls.Name = "layoutControls";
            layoutControls.Size = new Size(202, 110);
            layoutControls.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(3, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGroup
            // 
            btnGroup.Location = new Point(3, 38);
            btnGroup.Name = "btnGroup";
            btnGroup.Size = new Size(94, 29);
            btnGroup.TabIndex = 2;
            btnGroup.Text = "Group";
            btnGroup.UseVisualStyleBackColor = true;
            btnGroup.Click += btnGroup_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(103, 38);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // layoutFigures
            // 
            layoutFigures.ColumnCount = 3;
            layoutFigures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutFigures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutFigures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutFigures.Controls.Add(btnSquare, 0, 0);
            layoutFigures.Controls.Add(btnTriangle, 1, 0);
            layoutFigures.Controls.Add(btnCircle, 2, 0);
            layoutFigures.Location = new Point(8, 12);
            layoutFigures.Name = "layoutFigures";
            layoutFigures.RowCount = 1;
            layoutFigures.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutFigures.Size = new Size(295, 104);
            layoutFigures.TabIndex = 5;
            // 
            // btnSquare
            // 
            btnSquare.Image = Properties.Resources.img_234910;
            btnSquare.Location = new Point(3, 3);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(92, 98);
            btnSquare.TabIndex = 0;
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Image = Properties.Resources.cf61ccd611c18b4b733c65de4915c0b7;
            btnTriangle.Location = new Point(101, 3);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(92, 98);
            btnTriangle.TabIndex = 1;
            btnTriangle.UseVisualStyleBackColor = true;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnCircle
            // 
            btnCircle.Image = Properties.Resources.Новый_проект__1_;
            btnCircle.Location = new Point(199, 3);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(93, 98);
            btnCircle.TabIndex = 2;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // justtext
            // 
            justtext.AutoSize = true;
            justtext.Location = new Point(306, 12);
            justtext.Name = "justtext";
            justtext.Size = new Size(105, 20);
            justtext.TabIndex = 6;
            justtext.Text = "Current Figure:";
            // 
            // cur_figure
            // 
            cur_figure.AutoSize = true;
            cur_figure.Location = new Point(407, 12);
            cur_figure.Name = "cur_figure";
            cur_figure.Size = new Size(46, 20);
            cur_figure.TabIndex = 7;
            cur_figure.Text = "Circle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 715);
            Controls.Add(cur_figure);
            Controls.Add(justtext);
            Controls.Add(layoutFigures);
            Controls.Add(layoutControls);
            Controls.Add(treeView1);
            Controls.Add(mark_more);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            MouseClick += Form1_MouseClick;
            layoutControls.ResumeLayout(false);
            layoutFigures.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox mark_more;
        private TreeView treeView1;
        private FlowLayoutPanel layoutControls;
        private Button btnLoad;
        private Button btnSave;
        private Button btnGroup;
        private Button btnDelete;
        private TableLayoutPanel layoutFigures;
        private Button btnSquare;
        private Button btnTriangle;
        private Button btnCircle;
        private Label justtext;
        private Label cur_figure;
    }
}