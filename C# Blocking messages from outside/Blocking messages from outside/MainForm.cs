using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Blocking_messages_from_outside
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        [DllImport("User32.dll")]
        private extern static bool InSendMessage();
        protected override void WndProc(ref Message m)
        {
            if (InSendMessage()) { return; }
            base.WndProc(ref m);
        }
    }
}