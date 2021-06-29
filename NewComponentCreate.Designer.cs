
namespace DbFirstTest
{
    partial class NewComponentCreate
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
            this.nameOfNewComponent_textBox = new System.Windows.Forms.TextBox();
            this.CreateNewComponent_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfNewComponent_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название:";
            // 
            // nameOfNewComponent_textBox
            // 
            this.nameOfNewComponent_textBox.Location = new System.Drawing.Point(157, 7);
            this.nameOfNewComponent_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameOfNewComponent_textBox.Name = "nameOfNewComponent_textBox";
            this.nameOfNewComponent_textBox.Size = new System.Drawing.Size(272, 22);
            this.nameOfNewComponent_textBox.TabIndex = 1;
            // 
            // CreateNewComponent_button
            // 
            this.CreateNewComponent_button.Location = new System.Drawing.Point(15, 74);
            this.CreateNewComponent_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewComponent_button.Name = "CreateNewComponent_button";
            this.CreateNewComponent_button.Size = new System.Drawing.Size(416, 34);
            this.CreateNewComponent_button.TabIndex = 3;
            this.CreateNewComponent_button.Text = "Создать";
            this.CreateNewComponent_button.UseVisualStyleBackColor = true;
            this.CreateNewComponent_button.Click += new System.EventHandler(this.CreateNewComponent_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите количество:";
            // 
            // numberOfNewComponent_textBox
            // 
            this.numberOfNewComponent_textBox.Location = new System.Drawing.Point(171, 44);
            this.numberOfNewComponent_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfNewComponent_textBox.Name = "numberOfNewComponent_textBox";
            this.numberOfNewComponent_textBox.Size = new System.Drawing.Size(259, 22);
            this.numberOfNewComponent_textBox.TabIndex = 2;
            // 
            // NewComponentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 118);
            this.Controls.Add(this.numberOfNewComponent_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateNewComponent_button);
            this.Controls.Add(this.nameOfNewComponent_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewComponentCreate";
            this.Text = "Новый компонент ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewComponent_button;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox nameOfNewComponent_textBox;
        protected internal System.Windows.Forms.TextBox numberOfNewComponent_textBox;
    }
}