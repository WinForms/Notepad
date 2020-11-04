namespace homework_206_notepad
{
    partial class Find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            this.direction = new System.Windows.Forms.GroupBox();
            this.down = new System.Windows.Forms.RadioButton();
            this.uP = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxRegistry = new System.Windows.Forms.CheckBox();
            this.direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // direction
            // 
            this.direction.Controls.Add(this.down);
            this.direction.Controls.Add(this.uP);
            this.direction.Location = new System.Drawing.Point(146, 39);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(129, 61);
            this.direction.TabIndex = 9;
            this.direction.TabStop = false;
            this.direction.Text = "Направление";
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Checked = true;
            this.down.Location = new System.Drawing.Point(67, 28);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(50, 17);
            this.down.TabIndex = 5;
            this.down.TabStop = true;
            this.down.Text = "Вн&из";
            this.down.UseVisualStyleBackColor = true;
            // 
            // uP
            // 
            this.uP.AutoSize = true;
            this.uP.Location = new System.Drawing.Point(6, 28);
            this.uP.Name = "uP";
            this.uP.Size = new System.Drawing.Size(55, 17);
            this.uP.TabIndex = 4;
            this.uP.Text = "В&верх";
            this.uP.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(281, 10);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(85, 23);
            this.BtnFind.TabIndex = 7;
            this.BtnFind.Text = "&Найти Далее";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 6;
            // 
            // checkBoxRegistry
            // 
            this.checkBoxRegistry.AutoSize = true;
            this.checkBoxRegistry.Location = new System.Drawing.Point(12, 83);
            this.checkBoxRegistry.Name = "checkBoxRegistry";
            this.checkBoxRegistry.Size = new System.Drawing.Size(120, 17);
            this.checkBoxRegistry.TabIndex = 10;
            this.checkBoxRegistry.Text = "С у&четом регистра";
            this.checkBoxRegistry.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 117);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxRegistry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Find";
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Find_FormClosing);
            this.direction.ResumeLayout(false);
            this.direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox direction;
        private System.Windows.Forms.RadioButton down;
        private System.Windows.Forms.RadioButton uP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxRegistry;
    }
}