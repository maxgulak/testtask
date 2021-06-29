
namespace DbFirstTest
{
    partial class RenameComponent
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
            this.label1 = new System.Windows.Forms.Label();
            this.newNameOfComponent_textBox = new System.Windows.Forms.TextBox();
            this.RenameComponent_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите новое имя компонента:";
            // 
            // newNameOfComponent_textBox
            // 
            this.newNameOfComponent_textBox.Location = new System.Drawing.Point(185, 4);
            this.newNameOfComponent_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newNameOfComponent_textBox.Name = "newNameOfComponent_textBox";
            this.newNameOfComponent_textBox.Size = new System.Drawing.Size(173, 20);
            this.newNameOfComponent_textBox.TabIndex = 1;
            // 
            // RenameComponent_button
            // 
            this.RenameComponent_button.Location = new System.Drawing.Point(11, 28);
            this.RenameComponent_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RenameComponent_button.Name = "RenameComponent_button";
            this.RenameComponent_button.Size = new System.Drawing.Size(347, 25);
            this.RenameComponent_button.TabIndex = 2;
            this.RenameComponent_button.Text = "Переименовать";
            this.RenameComponent_button.UseVisualStyleBackColor = true;
            this.RenameComponent_button.Click += new System.EventHandler(this.RenameComponent_button_Click);
            // 
            // RenameComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 61);
            this.Controls.Add(this.RenameComponent_button);
            this.Controls.Add(this.newNameOfComponent_textBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RenameComponent";
            this.Text = "Переименование компонента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newNameOfComponent_textBox;
        private System.Windows.Forms.Button RenameComponent_button;
    }
}