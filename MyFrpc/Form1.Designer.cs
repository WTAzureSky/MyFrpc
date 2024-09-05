namespace MyFrpc
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.curPortBox = new System.Windows.Forms.TextBox();
            this.toBeBox = new System.Windows.Forms.TextBox();
            this.Changebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // curPortBox
            // 
            this.curPortBox.BackColor = System.Drawing.SystemColors.Window;
            this.curPortBox.Location = new System.Drawing.Point(107, 11);
            this.curPortBox.Name = "curPortBox";
            this.curPortBox.ReadOnly = true;
            this.curPortBox.Size = new System.Drawing.Size(100, 28);
            this.curPortBox.TabIndex = 0;
            this.curPortBox.TextChanged += new System.EventHandler(this.curPortBox_TextChanged);
            // 
            // toBeBox
            // 
            this.toBeBox.Location = new System.Drawing.Point(107, 45);
            this.toBeBox.Name = "toBeBox";
            this.toBeBox.Size = new System.Drawing.Size(100, 28);
            this.toBeBox.TabIndex = 1;
            // 
            // Changebutton
            // 
            this.Changebutton.Location = new System.Drawing.Point(213, 45);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(104, 28);
            this.Changebutton.TabIndex = 2;
            this.Changebutton.Text = "确认更改";
            this.Changebutton.UseVisualStyleBackColor = true;
            this.Changebutton.Click += new System.EventHandler(this.TryToChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前端口:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "更改端口:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(323, 45);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 28);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "启动穿透";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.OnClickFrp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 84);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Changebutton);
            this.Controls.Add(this.toBeBox);
            this.Controls.Add(this.curPortBox);
            this.Name = "MainForm";
            this.Text = "内网穿透";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox curPortBox;
        private System.Windows.Forms.TextBox toBeBox;
        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
    }
}

