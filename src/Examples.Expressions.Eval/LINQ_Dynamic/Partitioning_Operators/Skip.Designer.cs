﻿namespace Examples.Expressions.Eval.LINQ_Dynamic.Partitioning_Operators
{
    partial class Skip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiSkip_Simple_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiSkip_Simple_LINQ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiResult = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiSkip_Nested_LINQ_Execute = new System.Windows.Forms.Button();
            this.uiSkip_Nested_LINQ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiSkip_Simple_LINQ_Execute);
            this.groupBox1.Controls.Add(this.uiSkip_Simple_LINQ);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skip - Simple";
            // 
            // uiSkip_Simple_LINQ_Execute
            // 
            this.uiSkip_Simple_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiSkip_Simple_LINQ_Execute.Name = "uiSkip_Simple_LINQ_Execute";
            this.uiSkip_Simple_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiSkip_Simple_LINQ_Execute.TabIndex = 2;
            this.uiSkip_Simple_LINQ_Execute.Text = "LINQ Execute";
            this.uiSkip_Simple_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiSkip_Simple_LINQ_Execute.Click += new System.EventHandler(this.uiSkip_Simple_LINQ_Execute_Click);
            // 
            // uiSkip_Simple_LINQ
            // 
            this.uiSkip_Simple_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiSkip_Simple_LINQ.Name = "uiSkip_Simple_LINQ";
            this.uiSkip_Simple_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiSkip_Simple_LINQ.TabIndex = 0;
            this.uiSkip_Simple_LINQ.Text = "LINQ";
            this.uiSkip_Simple_LINQ.UseVisualStyleBackColor = true;
            this.uiSkip_Simple_LINQ.Click += new System.EventHandler(this.uiSkip_Simple_LINQ_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // uiResult
            // 
            this.uiResult.Location = new System.Drawing.Point(7, 35);
            this.uiResult.Name = "uiResult";
            this.uiResult.Size = new System.Drawing.Size(736, 158);
            this.uiResult.TabIndex = 0;
            this.uiResult.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiSkip_Nested_LINQ_Execute);
            this.groupBox3.Controls.Add(this.uiSkip_Nested_LINQ);
            this.groupBox3.Location = new System.Drawing.Point(193, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skip - Nested";
            // 
            // uiSkip_Nested_LINQ_Execute
            // 
            this.uiSkip_Nested_LINQ_Execute.Location = new System.Drawing.Point(10, 100);
            this.uiSkip_Nested_LINQ_Execute.Name = "uiSkip_Nested_LINQ_Execute";
            this.uiSkip_Nested_LINQ_Execute.Size = new System.Drawing.Size(100, 23);
            this.uiSkip_Nested_LINQ_Execute.TabIndex = 2;
            this.uiSkip_Nested_LINQ_Execute.Text = "LINQ Execute";
            this.uiSkip_Nested_LINQ_Execute.UseVisualStyleBackColor = true;
            this.uiSkip_Nested_LINQ_Execute.Click += new System.EventHandler(this.uiSkip_Nested_LINQ_Execute_Click);
            // 
            // uiSkip_Nested_LINQ
            // 
            this.uiSkip_Nested_LINQ.Location = new System.Drawing.Point(10, 20);
            this.uiSkip_Nested_LINQ.Name = "uiSkip_Nested_LINQ";
            this.uiSkip_Nested_LINQ.Size = new System.Drawing.Size(100, 23);
            this.uiSkip_Nested_LINQ.TabIndex = 0;
            this.uiSkip_Nested_LINQ.Text = "LINQ";
            this.uiSkip_Nested_LINQ.UseVisualStyleBackColor = true;
            this.uiSkip_Nested_LINQ.Click += new System.EventHandler(this.uiSkip_Nested_LINQ_Click);
            // 
            // Skip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Skip";
            this.Text = "Skip";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiSkip_Simple_LINQ_Execute;
        private System.Windows.Forms.Button uiSkip_Simple_LINQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox uiResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button uiSkip_Nested_LINQ_Execute;
        private System.Windows.Forms.Button uiSkip_Nested_LINQ;
    }
}