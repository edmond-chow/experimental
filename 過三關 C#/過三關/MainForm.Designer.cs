namespace 過三關
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Basic = new TicTacToeLibrary.Base();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Basic
            // 
            this.Basic.Location = new System.Drawing.Point(0, 0);
            this.Basic.Name = "Basic";
            this.Basic.TabIndex = 0;
            this.Basic.TicTacToeStartUp += new TicTacToeLibrary.Base.TicTacToeStartUpEventHandler(this.Basic_TicTacToeStartUp);
            this.Basic.TicTacToeClick += new System.EventHandler(this.Basic_Click);
            this.Basic.TicTacToeKeyDown += new System.Windows.Forms.KeyEventHandler(this.Basic_TicTacToeKeyDown);
            this.Basic.TicTacToeNewRound += new TicTacToeLibrary.Base.TicTacToeRoundEventHandler(this.Basic_TicTacToeNewRound);
            this.Basic.TicTacToeNewGame += new TicTacToeLibrary.Base.TicTacToeGameEventHandler(this.Basic_TicTacToeNewGame);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal TicTacToeLibrary.Base Basic;
        internal System.Windows.Forms.Timer Timer;

    }
}