
namespace DbFirstTest
{
    partial class NewParentComponentCreate
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
            this.nameOfNewParentComponent_textBox = new System.Windows.Forms.TextBox();
            this.CreateNewParentComponent_button = new System.Windows.Forms.Button();
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
            // nameOfNewParentComponent_textBox
            // 
            this.nameOfNewParentComponent_textBox.Location = new System.Drawing.Point(157, 7);
            this.nameOfNewParentComponent_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameOfNewParentComponent_textBox.Name = "nameOfNewParentComponent_textBox";
            this.nameOfNewParentComponent_textBox.Size = new System.Drawing.Size(272, 22);
            this.nameOfNewParentComponent_textBox.TabIndex = 1;
            // 
            // CreateNewParentComponent_button
            // 
            this.CreateNewParentComponent_button.Location = new System.Drawing.Point(15, 49);
            this.CreateNewParentComponent_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewParentComponent_button.Name = "CreateNewParentComponent_button";
            this.CreateNewParentComponent_button.Size = new System.Drawing.Size(416, 34);
            this.CreateNewParentComponent_button.TabIndex = 2;
            this.CreateNewParentComponent_button.Text = "Создать";
            this.CreateNewParentComponent_button.UseVisualStyleBackColor = true;
            this.CreateNewParentComponent_button.Click += new System.EventHandler(this.CreateNewParentComponent_button_Click);
            // 
            // NewParentComponentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 96);
            this.Controls.Add(this.CreateNewParentComponent_button);
            this.Controls.Add(this.nameOfNewParentComponent_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "NewParentComponentCreate";
            this.Text = "Новый компонент верхнего уровня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewParentComponent_button;
        protected internal System.Windows.Forms.TextBox nameOfNewParentComponent_textBox;
    }
}