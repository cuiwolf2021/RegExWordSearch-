﻿
namespace RegExWordSearch
{
    partial class FormImportDict
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportDict));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBriefIntroduction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "指定词典名称：";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.AllowDrop = true;
            this.textBoxTableName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxTableName.Location = new System.Drawing.Point(157, 31);
            this.textBoxTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTableName.MaxLength = 20;
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(315, 27);
            this.textBoxTableName.TabIndex = 1;
            this.textBoxTableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "指定词典文件：";
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFileDialog.BackgroundImage")));
            this.buttonOpenFileDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(157, 78);
            this.buttonOpenFileDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(50, 36);
            this.buttonOpenFileDialog.TabIndex = 3;
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(141, 227);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 29);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(305, 227);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxBriefIntroduction
            // 
            this.textBoxBriefIntroduction.AllowDrop = true;
            this.textBoxBriefIntroduction.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxBriefIntroduction.Location = new System.Drawing.Point(36, 121);
            this.textBoxBriefIntroduction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBriefIntroduction.MaxLength = 100;
            this.textBoxBriefIntroduction.Multiline = true;
            this.textBoxBriefIntroduction.Name = "textBoxBriefIntroduction";
            this.textBoxBriefIntroduction.Size = new System.Drawing.Size(436, 66);
            this.textBoxBriefIntroduction.TabIndex = 6;
            this.textBoxBriefIntroduction.Text = "简介";
            // 
            // FormImportDict
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.textBoxBriefIntroduction);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportDict";
            this.Text = "导入词典";
            this.Load += new System.EventHandler(this.FormImportDict_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxBriefIntroduction;
    }
}