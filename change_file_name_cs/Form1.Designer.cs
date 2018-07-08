namespace change_file_name_cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.btn_searchDir = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_hasChar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_recursion = new System.Windows.Forms.CheckBox();
            this.cb_nameLength = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(12, 44);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(179, 20);
            this.tb_dir.TabIndex = 0;
            // 
            // btn_searchDir
            // 
            this.btn_searchDir.Location = new System.Drawing.Point(197, 44);
            this.btn_searchDir.Name = "btn_searchDir";
            this.btn_searchDir.Size = new System.Drawing.Size(75, 23);
            this.btn_searchDir.TabIndex = 1;
            this.btn_searchDir.Text = "folder dir";
            this.btn_searchDir.UseVisualStyleBackColor = true;
            this.btn_searchDir.Click += new System.EventHandler(this.btn_searchDir_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(52, 214);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(168, 214);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_hasChar
            // 
            this.cb_hasChar.AutoSize = true;
            this.cb_hasChar.Location = new System.Drawing.Point(12, 153);
            this.cb_hasChar.Name = "cb_hasChar";
            this.cb_hasChar.Size = new System.Drawing.Size(91, 17);
            this.cb_hasChar.TabIndex = 5;
            this.cb_hasChar.Text = "has character";
            this.cb_hasChar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name length :";
            // 
            // cb_recursion
            // 
            this.cb_recursion.AutoSize = true;
            this.cb_recursion.Location = new System.Drawing.Point(12, 176);
            this.cb_recursion.Name = "cb_recursion";
            this.cb_recursion.Size = new System.Drawing.Size(103, 17);
            this.cb_recursion.TabIndex = 9;
            this.cb_recursion.Text = "Recursion folder";
            this.cb_recursion.UseVisualStyleBackColor = true;
            // 
            // cb_nameLength
            // 
            this.cb_nameLength.FormattingEnabled = true;
            this.cb_nameLength.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_nameLength.Location = new System.Drawing.Point(91, 127);
            this.cb_nameLength.Name = "cb_nameLength";
            this.cb_nameLength.Size = new System.Drawing.Size(45, 21);
            this.cb_nameLength.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_nameLength);
            this.Controls.Add(this.cb_recursion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_hasChar);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_searchDir);
            this.Controls.Add(this.tb_dir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change name file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Button btn_searchDir;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.CheckBox cb_hasChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_recursion;
        private System.Windows.Forms.ComboBox cb_nameLength;
    }
}

