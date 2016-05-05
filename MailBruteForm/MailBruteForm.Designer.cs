namespace MailBruteForm
{
    partial class MailBruteForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailBruteForm));
            this.btnLoadBase = new System.Windows.Forms.Button();
            this.btnLoadProxy = new System.Windows.Forms.Button();
            this.lblCountAccount = new System.Windows.Forms.Label();
            this.lblCountProxy = new System.Windows.Forms.Label();
            this.listBoxGood = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCountGood = new System.Windows.Forms.Label();
            this.lblCountBad = new System.Windows.Forms.Label();
            this.lblCountThread = new System.Windows.Forms.Label();
            this.txtBoxCountThread = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadBase
            // 
            this.btnLoadBase.Location = new System.Drawing.Point(12, 12);
            this.btnLoadBase.Name = "btnLoadBase";
            this.btnLoadBase.Size = new System.Drawing.Size(159, 23);
            this.btnLoadBase.TabIndex = 0;
            this.btnLoadBase.Text = "Load base";
            this.btnLoadBase.UseVisualStyleBackColor = true;
            this.btnLoadBase.Click += new System.EventHandler(this.btnLoadBase_Click);
            // 
            // btnLoadProxy
            // 
            this.btnLoadProxy.Location = new System.Drawing.Point(12, 41);
            this.btnLoadProxy.Name = "btnLoadProxy";
            this.btnLoadProxy.Size = new System.Drawing.Size(159, 23);
            this.btnLoadProxy.TabIndex = 1;
            this.btnLoadProxy.Text = "Load proxy";
            this.btnLoadProxy.UseVisualStyleBackColor = true;
            // 
            // lblCountAccount
            // 
            this.lblCountAccount.AutoSize = true;
            this.lblCountAccount.Location = new System.Drawing.Point(12, 80);
            this.lblCountAccount.Name = "lblCountAccount";
            this.lblCountAccount.Size = new System.Drawing.Size(80, 13);
            this.lblCountAccount.TabIndex = 2;
            this.lblCountAccount.Text = "Count account:";
            // 
            // lblCountProxy
            // 
            this.lblCountProxy.AutoSize = true;
            this.lblCountProxy.Location = new System.Drawing.Point(12, 106);
            this.lblCountProxy.Name = "lblCountProxy";
            this.lblCountProxy.Size = new System.Drawing.Size(66, 13);
            this.lblCountProxy.TabIndex = 3;
            this.lblCountProxy.Text = "Count proxy:";
            // 
            // listBoxGood
            // 
            this.listBoxGood.FormattingEnabled = true;
            this.listBoxGood.Location = new System.Drawing.Point(177, 12);
            this.listBoxGood.Name = "listBoxGood";
            this.listBoxGood.Size = new System.Drawing.Size(365, 251);
            this.listBoxGood.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCountGood
            // 
            this.lblCountGood.AutoSize = true;
            this.lblCountGood.ForeColor = System.Drawing.Color.Lime;
            this.lblCountGood.Location = new System.Drawing.Point(12, 130);
            this.lblCountGood.Name = "lblCountGood";
            this.lblCountGood.Size = new System.Drawing.Size(36, 13);
            this.lblCountGood.TabIndex = 6;
            this.lblCountGood.Text = "Good:";
            // 
            // lblCountBad
            // 
            this.lblCountBad.AutoSize = true;
            this.lblCountBad.ForeColor = System.Drawing.Color.Red;
            this.lblCountBad.Location = new System.Drawing.Point(12, 153);
            this.lblCountBad.Name = "lblCountBad";
            this.lblCountBad.Size = new System.Drawing.Size(29, 13);
            this.lblCountBad.TabIndex = 7;
            this.lblCountBad.Text = "Bad:";
            // 
            // lblCountThread
            // 
            this.lblCountThread.AutoSize = true;
            this.lblCountThread.Location = new System.Drawing.Point(12, 179);
            this.lblCountThread.Name = "lblCountThread";
            this.lblCountThread.Size = new System.Drawing.Size(71, 13);
            this.lblCountThread.TabIndex = 8;
            this.lblCountThread.Text = "Count thread:";
            // 
            // txtBoxCountThread
            // 
            this.txtBoxCountThread.Location = new System.Drawing.Point(60, 205);
            this.txtBoxCountThread.Name = "txtBoxCountThread";
            this.txtBoxCountThread.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCountThread.TabIndex = 9;
            this.txtBoxCountThread.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thread:";
            // 
            // MailBruteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCountThread);
            this.Controls.Add(this.lblCountThread);
            this.Controls.Add(this.lblCountBad);
            this.Controls.Add(this.lblCountGood);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBoxGood);
            this.Controls.Add(this.lblCountProxy);
            this.Controls.Add(this.lblCountAccount);
            this.Controls.Add(this.btnLoadProxy);
            this.Controls.Add(this.btnLoadBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailBruteForm";
            this.Text = "Mail.Ru Brute";
            this.Load += new System.EventHandler(this.MailBruteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadBase;
        private System.Windows.Forms.Button btnLoadProxy;
        private System.Windows.Forms.Label lblCountAccount;
        private System.Windows.Forms.Label lblCountProxy;
        private System.Windows.Forms.ListBox listBoxGood;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCountGood;
        private System.Windows.Forms.Label lblCountBad;
        private System.Windows.Forms.Label lblCountThread;
        private System.Windows.Forms.TextBox txtBoxCountThread;
        private System.Windows.Forms.Label label1;
    }
}

