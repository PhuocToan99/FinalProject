﻿namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnPostOrderTraverse = new System.Windows.Forms.Button();
            this.btnPreOrderTraverse = new System.Windows.Forms.Button();
            this.btnInOrderTraverse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.lblTreeHeight = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.bsTreePanel1 = new WindowsFormsApplication2.BSTreePanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnPostOrderTraverse);
            this.panel1.Controls.Add(this.btnPreOrderTraverse);
            this.panel1.Controls.Add(this.btnInOrderTraverse);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnSaveImage);
            this.panel1.Controls.Add(this.btnGenerateTree);
            this.panel1.Controls.Add(this.lblTreeHeight);
            this.panel1.Controls.Add(this.lblNodeCount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.numSize);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(520, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 556);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "MENU";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(11, 313);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(128, 35);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "label5";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnPostOrderTraverse
            // 
            this.btnPostOrderTraverse.Location = new System.Drawing.Point(14, 466);
            this.btnPostOrderTraverse.Name = "btnPostOrderTraverse";
            this.btnPostOrderTraverse.Size = new System.Drawing.Size(117, 28);
            this.btnPostOrderTraverse.TabIndex = 0;
            this.btnPostOrderTraverse.Text = "LRN Out";
            this.btnPostOrderTraverse.UseVisualStyleBackColor = true;
            this.btnPostOrderTraverse.Click += new System.EventHandler(this.btnPostOrderTraverse_Click);
            // 
            // btnPreOrderTraverse
            // 
            this.btnPreOrderTraverse.Location = new System.Drawing.Point(14, 432);
            this.btnPreOrderTraverse.Name = "btnPreOrderTraverse";
            this.btnPreOrderTraverse.Size = new System.Drawing.Size(117, 28);
            this.btnPreOrderTraverse.TabIndex = 0;
            this.btnPreOrderTraverse.Text = "NLR Out";
            this.btnPreOrderTraverse.UseVisualStyleBackColor = true;
            this.btnPreOrderTraverse.Click += new System.EventHandler(this.btnPreOrderTraverse_Click);
            // 
            // btnInOrderTraverse
            // 
            this.btnInOrderTraverse.Location = new System.Drawing.Point(14, 398);
            this.btnInOrderTraverse.Name = "btnInOrderTraverse";
            this.btnInOrderTraverse.Size = new System.Drawing.Size(117, 28);
            this.btnInOrderTraverse.TabIndex = 0;
            this.btnInOrderTraverse.Text = "LNR Out";
            this.btnInOrderTraverse.UseVisualStyleBackColor = true;
            this.btnInOrderTraverse.Click += new System.EventHandler(this.btnInOrderTraverse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 28);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Node";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(64, 191);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Node";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(13, 157);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(117, 28);
            this.btnSaveImage.TabIndex = 0;
            this.btnSaveImage.Text = "Save Image As...";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Location = new System.Drawing.Point(14, 88);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(117, 28);
            this.btnGenerateTree.TabIndex = 0;
            this.btnGenerateTree.Text = "Generate Random Tree";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // lblTreeHeight
            // 
            this.lblTreeHeight.AutoSize = true;
            this.lblTreeHeight.Location = new System.Drawing.Point(11, 371);
            this.lblTreeHeight.Name = "lblTreeHeight";
            this.lblTreeHeight.Size = new System.Drawing.Size(34, 13);
            this.lblTreeHeight.TabIndex = 1;
            this.lblTreeHeight.Text = "Value";
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(11, 348);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(34, 13);
            this.lblNodeCount.TabIndex = 1;
            this.lblNodeCount.Text = "Value";
            this.lblNodeCount.Click += new System.EventHandler(this.lblNodeCount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Value";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Size";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(69, 72);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(62, 20);
            this.numMax.TabIndex = 0;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(69, 46);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(62, 20);
            this.numMin.TabIndex = 0;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(69, 20);
            this.numSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(62, 20);
            this.numSize.TabIndex = 0;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.png";
            this.saveFileDialog1.Filter = "PNG|*.png|JPEG|*.jpg|Bitmap|*.bmp";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(523, 554);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "NormalAdd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bsTreePanel1
            // 
            this.bsTreePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bsTreePanel1.AutoScroll = true;
            this.bsTreePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bsTreePanel1.Location = new System.Drawing.Point(12, 12);
            this.bsTreePanel1.Name = "bsTreePanel1";
            this.bsTreePanel1.Size = new System.Drawing.Size(496, 549);
            this.bsTreePanel1.TabIndex = 0;
            this.bsTreePanel1.Load += new System.EventHandler(this.bsTreePanel1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 573);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bsTreePanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVL Tree Demo";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BSTreePanel bsTreePanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateTree;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Label lblTreeHeight;
        private System.Windows.Forms.Button btnInOrderTraverse;
        private System.Windows.Forms.Button btnPostOrderTraverse;
        private System.Windows.Forms.Button btnPreOrderTraverse;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

