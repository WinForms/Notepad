namespace homework_206_notepad
{
    partial class Replace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replace));
            this.button3 = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.labelwith = new System.Windows.Forms.Label();
            this.labelwhat = new System.Windows.Forms.Label();
            this.textBoxwith = new System.Windows.Forms.TextBox();
            this.checkBoxRegistry = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.BtnFind_Click = new System.Windows.Forms.Button();
            this.textBoxwhat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(332, 68);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(95, 23);
            this.btnReplaceAll.TabIndex = 25;
            this.btnReplaceAll.Text = "Заменить все";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // labelwith
            // 
            this.labelwith.AutoSize = true;
            this.labelwith.Location = new System.Drawing.Point(13, 45);
            this.labelwith.Name = "labelwith";
            this.labelwith.Size = new System.Drawing.Size(29, 13);
            this.labelwith.TabIndex = 24;
            this.labelwith.Text = "Чем";
            // 
            // labelwhat
            // 
            this.labelwhat.AutoSize = true;
            this.labelwhat.Location = new System.Drawing.Point(13, 15);
            this.labelwhat.Name = "labelwhat";
            this.labelwhat.Size = new System.Drawing.Size(26, 13);
            this.labelwhat.TabIndex = 23;
            this.labelwhat.Text = "Что";
            // 
            // textBoxwith
            // 
            this.textBoxwith.Location = new System.Drawing.Point(63, 42);
            this.textBoxwith.Name = "textBoxwith";
            this.textBoxwith.Size = new System.Drawing.Size(263, 20);
            this.textBoxwith.TabIndex = 22;
            this.textBoxwith.TextChanged += new System.EventHandler(this.textBoxwith_TextChanged);
            // 
            // checkBoxRegistry
            // 
            this.checkBoxRegistry.AutoSize = true;
            this.checkBoxRegistry.Location = new System.Drawing.Point(13, 74);
            this.checkBoxRegistry.Name = "checkBoxRegistry";
            this.checkBoxRegistry.Size = new System.Drawing.Size(120, 17);
            this.checkBoxRegistry.TabIndex = 20;
            this.checkBoxRegistry.Text = "С у&четом регистра";
            this.checkBoxRegistry.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(332, 39);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(95, 23);
            this.btnReplace.TabIndex = 19;
            this.btnReplace.Text = "Заменить";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // BtnFind_Click
            // 
            this.BtnFind_Click.Location = new System.Drawing.Point(332, 10);
            this.BtnFind_Click.Name = "BtnFind_Click";
            this.BtnFind_Click.Size = new System.Drawing.Size(95, 23);
            this.BtnFind_Click.TabIndex = 18;
            this.BtnFind_Click.Text = "&Найти Далее";
            this.BtnFind_Click.UseVisualStyleBackColor = true;
            this.BtnFind_Click.Click += new System.EventHandler(this.BtnFind_Click_Click);
            // 
            // textBoxwhat
            // 
            this.textBoxwhat.Location = new System.Drawing.Point(63, 12);
            this.textBoxwhat.Name = "textBoxwhat";
            this.textBoxwhat.Size = new System.Drawing.Size(263, 20);
            this.textBoxwhat.TabIndex = 17;
            this.textBoxwhat.TextChanged += new System.EventHandler(this.textBoxwhat_TextChanged);
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 134);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.labelwith);
            this.Controls.Add(this.labelwhat);
            this.Controls.Add(this.textBoxwith);
            this.Controls.Add(this.checkBoxRegistry);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.BtnFind_Click);
            this.Controls.Add(this.textBoxwhat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Replace";
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Replace_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Label labelwith;
        private System.Windows.Forms.Label labelwhat;
        private System.Windows.Forms.TextBox textBoxwith;
        private System.Windows.Forms.CheckBox checkBoxRegistry;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button BtnFind_Click;
        private System.Windows.Forms.TextBox textBoxwhat;
    }
}