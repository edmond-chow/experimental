namespace TicTacToeConsole
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Basic = new TicTacToeLibrary.Base();
            this.TicTacToeTestingTimer = new System.Windows.Forms.Timer(this.components);
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Basic
            // 
            this.Basic.Location = new System.Drawing.Point(0, 0);
            this.Basic.Name = "Basic";
            this.Basic.TabIndex = 0;
            this.Basic.TicTacToeClick += new System.EventHandler(this.Basic_Click);
            this.Basic.TicTacToeKeyDown += new System.Windows.Forms.KeyEventHandler(this.Basic_TicTacToeKeyDown);
            this.Basic.TicTacToeHasResult += new TicTacToeLibrary.Base.TicTacToeResultEventHandler(this.Basic_TicTacToeHasResult);
            this.Basic.TicTacToeNewRound += new TicTacToeLibrary.Base.TicTacToeRoundEventHandler(this.Basic_TicTacToeNewRound);
            // 
            // TicTacToeTestingTimer
            // 
            this.TicTacToeTestingTimer.Enabled = true;
            this.TicTacToeTestingTimer.Interval = 1;
            this.TicTacToeTestingTimer.Tick += new System.EventHandler(this.TicTacToeTestingTimer_Tick);
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "過三關";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.Click += new System.EventHandler(this.MyNotifyIcon_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 317);
            this.Controls.Add(this.Basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "過三關";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer TicTacToeTestingTimer;
        internal TicTacToeLibrary.Base Basic;
        internal System.Windows.Forms.NotifyIcon MyNotifyIcon;
        internal System.Windows.Forms.Timer Timer;

    }
}

