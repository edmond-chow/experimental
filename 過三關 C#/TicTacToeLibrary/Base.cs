using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Security;
namespace TicTacToeLibrary
{
    public partial class Base : UserControl
    {
        public Base()
        {
            InitializeComponent();
            InitializeOnBase();
            InitializeEvents();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Base_Load(this, e);
            EventNotExistLoad();
        }
        //
        // Initialize Protection{Event, Property}
        //
        [Serializable]
        public class UsercontrolDistroyedException : System.Exception
        {
            public UsercontrolDistroyedException() : base() { }
            public UsercontrolDistroyedException(string message) : base(message) { }
            public UsercontrolDistroyedException(string message, TicTacToeLibrary.Base.UsercontrolDistroyedException innerException) : base(message, innerException) { }
            [SecuritySafeCritical]
            protected UsercontrolDistroyedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }
        [Serializable]
        public class EventNotExistException : System.Exception
        {
            public EventNotExistException() : base() { }
            public EventNotExistException(string message) : base(message) { }
            public EventNotExistException(string message, TicTacToeLibrary.Base.EventNotExistException innerException) : base(message, innerException) { }
            [SecuritySafeCritical]
            protected EventNotExistException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }
        private void ThrowEventNotExistException(object sender, EventArgs e)
        {
            if (this.AutoSizeChanged.GetInvocationList().Length != 1 ||
                this.AutoValidateChanged.GetInvocationList().Length != 1 ||
                this.BackColorChanged.GetInvocationList().Length != 1 ||
                this.BackgroundImageChanged.GetInvocationList().Length != 1 ||
                this.BackgroundImageLayoutChanged.GetInvocationList().Length != 1 ||
                this.BindingContextChanged.GetInvocationList().Length != 1 ||
                this.CausesValidationChanged.GetInvocationList().Length != 1 ||
                this.ChangeUICues.GetInvocationList().Length != 1 ||
                this.Click.GetInvocationList().Length != 1 ||
                this.ClientSizeChanged.GetInvocationList().Length != 1 ||
                this.ContextMenuChanged.GetInvocationList().Length != 1 ||
                this.ContextMenuStripChanged.GetInvocationList().Length != 1 ||
                this.ControlAdded.GetInvocationList().Length != 1 ||
                this.ControlRemoved.GetInvocationList().Length != 1 ||
                this.CursorChanged.GetInvocationList().Length != 1 ||
                this.Disposed.GetInvocationList().Length != 1 ||
                this.DockChanged.GetInvocationList().Length != 1 ||
                this.DoubleClick.GetInvocationList().Length != 1 ||
                this.DragDrop.GetInvocationList().Length != 1 ||
                this.DragEnter.GetInvocationList().Length != 1 ||
                this.DragLeave.GetInvocationList().Length != 1 ||
                this.DragOver.GetInvocationList().Length != 1 ||
                this.EnabledChanged.GetInvocationList().Length != 1 ||
                this.Enter.GetInvocationList().Length != 1 ||
                this.FontChanged.GetInvocationList().Length != 1 ||
                this.ForeColorChanged.GetInvocationList().Length != 1 ||
                this.GiveFeedback.GetInvocationList().Length != 1 ||
                this.GotFocus.GetInvocationList().Length != 1 ||
                this.HandleCreated.GetInvocationList().Length != 1 ||
                this.HandleDestroyed.GetInvocationList().Length != 1 ||
                this.HelpRequested.GetInvocationList().Length != 1 ||
                this.ImeModeChanged.GetInvocationList().Length != 1 ||
                this.Invalidated.GetInvocationList().Length != 1 ||
                this.KeyDown.GetInvocationList().Length != 1 ||
                this.KeyPress.GetInvocationList().Length != 1 ||
                this.KeyUp.GetInvocationList().Length != 1 ||
                this.Layout.GetInvocationList().Length != 1 ||
                this.Leave.GetInvocationList().Length != 1 ||
                this.Load.GetInvocationList().Length != 1 ||
                this.LocationChanged.GetInvocationList().Length != 1 ||
                this.LostFocus.GetInvocationList().Length != 1 ||
                this.MarginChanged.GetInvocationList().Length != 1 ||
                this.MouseCaptureChanged.GetInvocationList().Length != 1 ||
                this.MouseClick.GetInvocationList().Length != 1 ||
                this.MouseDoubleClick.GetInvocationList().Length != 1 ||
                this.MouseDown.GetInvocationList().Length != 1 ||
                this.MouseEnter.GetInvocationList().Length != 1 ||
                this.MouseHover.GetInvocationList().Length != 1 ||
                this.MouseLeave.GetInvocationList().Length != 1 ||
                this.MouseMove.GetInvocationList().Length != 1 ||
                this.MouseUp.GetInvocationList().Length != 1 ||
                this.MouseWheel.GetInvocationList().Length != 1 ||
                this.Move.GetInvocationList().Length != 1 ||
                this.PaddingChanged.GetInvocationList().Length != 1 ||
                this.Paint.GetInvocationList().Length != 1 ||
                this.ParentChanged.GetInvocationList().Length != 1 ||
                this.PreviewKeyDown.GetInvocationList().Length != 1 ||
                this.QueryAccessibilityHelp.GetInvocationList().Length != 1 ||
                this.QueryContinueDrag.GetInvocationList().Length != 1 ||
                this.RegionChanged.GetInvocationList().Length != 1 ||
                this.Resize.GetInvocationList().Length != 1 ||
                this.RightToLeftChanged.GetInvocationList().Length != 1 ||
                this.Scroll.GetInvocationList().Length != 1 ||
                this.SizeChanged.GetInvocationList().Length != 1 ||
                this.StyleChanged.GetInvocationList().Length != 1 ||
                this.SystemColorsChanged.GetInvocationList().Length != 1 ||
                this.TabIndexChanged.GetInvocationList().Length != 1 ||
                this.TabStopChanged.GetInvocationList().Length != 1 ||
                this.TextChanged.GetInvocationList().Length != 1 ||
                this.Validated.GetInvocationList().Length != 1 ||
                this.Validating.GetInvocationList().Length != 1 ||
                this.VisibleChanged.GetInvocationList().Length != 1) { throw new EventNotExistException(); }
        }
        private void EventNotExistLoad()
        {
            this.EventNotExistTimer = new System.Windows.Forms.Timer();
            this.EventNotExistTimer.Interval = 1;
            this.EventNotExistTimer.Enabled = true;
            this.EventNotExistTimer.Tick += new EventHandler(this.ThrowEventNotExistException);
        }
        protected internal System.Windows.Forms.Timer EventNotExistTimer;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler AutoSizeChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler AutoValidateChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler BackColorChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler BackgroundImageChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler BackgroundImageLayoutChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler BindingContextChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler CausesValidationChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ChangeUICues;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Click;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ClientSizeChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ContextMenuChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ContextMenuStripChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ControlAdded;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ControlRemoved;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler CursorChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Disposed;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler DockChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler DoubleClick;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler DragDrop;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler DragEnter;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler DragLeave;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler DragOver;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler EnabledChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Enter;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler FontChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ForeColorChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler GiveFeedback;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler GotFocus;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler HandleCreated;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler HandleDestroyed;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler HelpRequested;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ImeModeChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Invalidated;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler KeyDown;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler KeyPress;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler KeyUp;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Layout;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Leave;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Load;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler LocationChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler LostFocus;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MarginChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseCaptureChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseClick;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseDoubleClick;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseDown;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseEnter;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseHover;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseLeave;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseMove;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseUp;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler MouseWheel;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Move;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler PaddingChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Paint;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler ParentChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler PreviewKeyDown;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler QueryAccessibilityHelp;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler QueryContinueDrag;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler RegionChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Resize;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler RightToLeftChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Scroll;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler SizeChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler StyleChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler SystemColorsChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler TabIndexChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler TabStopChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler TextChanged;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Validated;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler Validating;
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new event EventHandler VisibleChanged;
        private void OnBase(object sender, EventArgs e) { }
        private void InitializeOnBase()
        {
            this.AutoSizeChanged = this.OnBase;
            this.AutoValidateChanged = this.OnBase;
            this.BackColorChanged = this.OnBase;
            this.BackgroundImageChanged = this.OnBase;
            this.BackgroundImageLayoutChanged = this.OnBase;
            this.BindingContextChanged = this.OnBase;
            this.CausesValidationChanged = this.OnBase;
            this.ChangeUICues = this.OnBase;
            this.Click = this.OnBase;
            this.ClientSizeChanged = this.OnBase;
            this.ContextMenuChanged = this.OnBase;
            this.ContextMenuStripChanged = this.OnBase;
            this.ControlAdded = this.OnBase;
            this.ControlRemoved = this.OnBase;
            this.CursorChanged = this.OnBase;
            this.Disposed = this.OnBase;
            this.DockChanged = this.OnBase;
            this.DoubleClick = this.OnBase;
            this.DragDrop = this.OnBase;
            this.DragEnter = this.OnBase;
            this.DragLeave = this.OnBase;
            this.DragOver = this.OnBase;
            this.EnabledChanged = this.OnBase;
            this.Enter = this.OnBase;
            this.FontChanged = this.OnBase;
            this.ForeColorChanged = this.OnBase;
            this.GiveFeedback = this.OnBase;
            this.GotFocus = this.OnBase;
            this.HandleCreated = this.OnBase;
            this.HandleDestroyed = this.OnBase;
            this.HelpRequested = this.OnBase;
            this.ImeModeChanged = this.OnBase;
            this.Invalidated = this.OnBase;
            this.KeyDown = this.OnBase;
            this.KeyPress = this.OnBase;
            this.KeyUp = this.OnBase;
            this.Layout = this.OnBase;
            this.Leave = this.OnBase;
            this.Load = this.OnBase;
            this.LocationChanged = this.OnBase;
            this.LostFocus = this.OnBase;
            this.MarginChanged = this.OnBase;
            this.MouseCaptureChanged = this.OnBase;
            this.MouseClick = this.OnBase;
            this.MouseDoubleClick = this.OnBase;
            this.MouseDown = this.OnBase;
            this.MouseEnter = this.OnBase;
            this.MouseHover = this.OnBase;
            this.MouseLeave = this.OnBase;
            this.MouseMove = this.OnBase;
            this.MouseUp = this.OnBase;
            this.MouseWheel = this.OnBase;
            this.Move = this.OnBase;
            this.PaddingChanged = this.OnBase;
            this.Paint = this.OnBase;
            this.ParentChanged = this.OnBase;
            this.PreviewKeyDown = this.OnBase;
            this.QueryAccessibilityHelp = this.OnBase;
            this.QueryContinueDrag = this.OnBase;
            this.RegionChanged = this.OnBase;
            this.Resize = this.OnBase;
            this.RightToLeftChanged = this.OnBase;
            this.Scroll = this.OnBase;
            this.SizeChanged = this.OnBase;
            this.StyleChanged = this.OnBase;
            this.SystemColorsChanged = this.OnBase;
            this.TabIndexChanged = this.OnBase;
            this.TabStopChanged = this.OnBase;
            this.TextChanged = this.OnBase;
            this.Validated = this.OnBase;
            this.Validating = this.OnBase;
            this.VisibleChanged = this.OnBase;
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new string AccessibleDescription
        {
            get { return base.AccessibleDescription; }
            private set { base.AccessibleDescription = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new string AccessibleName
        {
            get { return base.AccessibleName; }
            private set { base.AccessibleName = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.AccessibleRole AccessibleRole
        {
            get { return base.AccessibleRole; }
            private set { base.AccessibleRole = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Color BackColor
        {
            get { return base.BackColor; }
            private set { base.BackColor = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            private set { base.BackgroundImage = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.ImageLayout BackgroundImageLayout
        {
            get { return base.BackgroundImageLayout; }
            private set { base.BackgroundImageLayout = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            private set { base.BorderStyle = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.Cursor Cursor
        {
            get { return base.Cursor; }
            private set { base.Cursor = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Font Font
        {
            get { return base.Font; }
            private set { base.Font = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Color ForeColor
        {
            get { return base.ForeColor; }
            private set { base.ForeColor = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.RightToLeft RightToLeft
        {
            get { return base.RightToLeft; }
            private set { base.RightToLeft = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool UseWaitCursor
        {
            get { return base.UseWaitCursor; }
            private set { base.UseWaitCursor = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool AllowDrop
        {
            get { return base.AllowDrop; }
            private set { base.AllowDrop = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.AutoValidate AutoValidate
        {
            get { return base.AutoValidate; }
            private set { base.AutoValidate = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.ContextMenuStrip ContextMenuStrip
        {
            get { return base.ContextMenuStrip; }
            private set { base.ContextMenuStrip = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool Enabled
        {
            get { return base.Enabled; }
            private set { base.Enabled = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.ImeMode ImeMode
        {
            get { return base.ImeMode; }
            private set { base.ImeMode = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool Visible
        {
            get { return base.Visible; }
            private set { base.Visible = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool CausesValidation
        {
            get { return base.CausesValidation; }
            private set { base.CausesValidation = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.AnchorStyles Anchor
        {
            get { return base.Anchor; }
            private set { base.Anchor = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool AutoScroll
        {
            get { return base.AutoScroll; }
            private set { base.AutoScroll = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Size AutoScrollMargin
        {
            get { return base.AutoScrollMargin; }
            private set { base.AutoScrollMargin = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Size AutoScrollMinSize
        {
            get { return base.AutoScrollMinSize; }
            private set { base.AutoScrollMinSize = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new bool AutoSize
        {
            get { return base.AutoSize; }
            private set { base.AutoSize = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.AutoSizeMode AutoSizeMode
        {
            get { return base.AutoSizeMode; }
            private set { base.AutoSizeMode = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.DockStyle Dock
        {
            get { return base.Dock; }
            private set { base.Dock = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.Padding Margin
        {
            get { return base.Margin; }
            private set { base.Margin = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Size MaximumSize
        {
            get { return base.MaximumSize; }
            private set { base.MaximumSize = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Size MinimumSize
        {
            get { return base.MinimumSize; }
            private set { base.MinimumSize = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Windows.Forms.Padding Padding
        {
            get { return base.Padding; }
            private set { base.Padding = value; }
        }
        [Browsable(false)] [EditorBrowsable(EditorBrowsableState.Never)] public new System.Drawing.Size Size
        {
            get { return base.Size; }
            private set { base.Size = value; }
        }
        protected override Size DefaultSize
        {
            get { return new Size(276, 317); }
        }
        protected override Size DefaultMaximumSize
        {
            get { return new Size(276, 317); }
        }
        protected override Size DefaultMinimumSize
        {
            get { return new Size(276, 317); }
        }
        //
        // Initialize Event(EventArgs)
        //
        private void InitializeEvents()
        {
            this.TicTacToeStartUpEvent = this.OnTicTacToeStartUp;
            this.TicTacToeClickEvent = this.OnTicTacToeClick;
            this.TicTacToeKeyDownEvent = this.OnTicTacToeKeyDown;
            this.TicTacToeHasResultEvent = this.OnTicTacToeHasResult;
            this.TicTacToeNewRoundEvent = this.OnTicTacToeNewRound;
            this.TicTacToeNewGameEvent = this.OnTicTacToeNewGame;
            this.TicTacToeNewModeEvent = this.OnTicTacToeNewMode;
        }
        public delegate void TicTacToeStartUpEventHandler(object sender, TicTacToeStartUpEventArgs e);
        public delegate void TicTacToeResultEventHandler(object sender, TicTacToeResultEventArgs e);
        public delegate void TicTacToeRoundEventHandler(object sender, TicTacToeRoundEventArgs e);
        public delegate void TicTacToeGameEventHandler(object sender, TicTacToeGameEventArgs e);
        private TicTacToeStartUpEventHandler TicTacToeStartUpEvent;
        private EventHandler TicTacToeClickEvent;
        private KeyEventHandler TicTacToeKeyDownEvent;
        private TicTacToeResultEventHandler TicTacToeHasResultEvent;
        private TicTacToeRoundEventHandler TicTacToeNewRoundEvent;
        private TicTacToeGameEventHandler TicTacToeNewGameEvent;
        private TicTacToeGameEventHandler TicTacToeNewModeEvent;
        public event TicTacToeStartUpEventHandler TicTacToeStartUp
        {
            add { this.TicTacToeStartUpEvent += value; }
            remove { this.TicTacToeStartUpEvent -= value; }
        }
        public event EventHandler TicTacToeClick
        {
            add { this.TicTacToeClickEvent += value; }
            remove { this.TicTacToeClickEvent -= value; }
        }
        public event KeyEventHandler TicTacToeKeyDown
        {
            add { this.TicTacToeKeyDownEvent += value; }
            remove { this.TicTacToeKeyDownEvent -= value; }
        }
        public event TicTacToeResultEventHandler TicTacToeHasResult
        {
            add { this.TicTacToeHasResultEvent += value; }
            remove { this.TicTacToeHasResultEvent -= value; }
        }
        public event TicTacToeRoundEventHandler TicTacToeNewRound
        {
            add { this.TicTacToeNewRoundEvent += value; }
            remove { this.TicTacToeNewRoundEvent -= value; }
        }
        public event TicTacToeGameEventHandler TicTacToeNewGame
        {
            add { this.TicTacToeNewGameEvent += value; }
            remove { this.TicTacToeNewGameEvent -= value; }
        }
        public event TicTacToeGameEventHandler TicTacToeNewMode
        {
            add { this.TicTacToeNewModeEvent += value; }
            remove { this.TicTacToeNewModeEvent -= value; }
        }
        protected virtual void OnTicTacToeStartUp(object sender, TicTacToeStartUpEventArgs e) { }
        protected virtual void OnTicTacToeClick(object sender, EventArgs e) { }
        protected virtual void OnTicTacToeKeyDown(object sender, KeyEventArgs e) { }
        protected virtual void OnTicTacToeHasResult(object sender, TicTacToeResultEventArgs e) { }
        protected virtual void OnTicTacToeNewRound(object sender, TicTacToeRoundEventArgs e) { }
        protected virtual void OnTicTacToeNewGame(object sender, TicTacToeGameEventArgs e) { }
        protected virtual void OnTicTacToeNewMode(object sender, TicTacToeGameEventArgs e) { }
        public class TicTacToeStartUpEventArgs : System.EventArgs
        {
            private bool BaseCancelNewGameEvent = false;
            public bool CancelNewGameEvent
            {
                get { return this.BaseCancelNewGameEvent; }
                set { this.BaseCancelNewGameEvent = value; }
            }
            public TicTacToeStartUpEventArgs(bool CancelNewGameEvent) { this.BaseCancelNewGameEvent = CancelNewGameEvent; }
        }
        public class TicTacToeResultEventArgs : System.EventArgs
        {
            private TicTacToeResult BaseResult = TicTacToeResult.None;
            public TicTacToeResult Result
            {
                get { return this.BaseResult; }
                private set { this.BaseResult = value; }
            }
            public TicTacToeResultEventArgs(TicTacToeResult Result) { this.BaseResult = Result; }
        }
        public class TicTacToeRoundEventArgs : System.EventArgs
        {
            private TicTacToeMode BaseMode;
            private TicTacToeBaseControl BaseHasClicked;
            private string BaseAIDetails;
            public TicTacToeMode Mode
            {
                get { return this.BaseMode; }
                private set { this.BaseMode = value; }
            }
            public TicTacToeBaseControl HasClicked
            {
                get { return this.BaseHasClicked; }
                private set { this.BaseHasClicked = value; }
            }
            public string AIDetails
            {
                get { return this.BaseAIDetails; }
                private set { this.BaseAIDetails = value; }
            }
            public TicTacToeRoundEventArgs(TicTacToeMode Mode, TicTacToeBaseControl HasClicked, string AIDetails)
            {
                this.BaseMode = Mode;
                this.BaseHasClicked = HasClicked;
                this.BaseAIDetails = AIDetails;
            }
        }
        public class TicTacToeGameEventArgs : System.EventArgs
        {
            private TicTacToeMode BaseMode;
            public TicTacToeMode Mode
            {
                get { return this.BaseMode; }
                private set { this.BaseMode = value; }
            }
            public TicTacToeGameEventArgs(TicTacToeMode Mode) { this.BaseMode = Mode; }
        }
        private struct TicTacToeButton
        {
            public readonly Button Button;
            public BaseType.VectorBoolean Player;
            public TicTacToeButton(Button Button, BaseType.VectorBoolean Player)
            {
                this.Button = Button;
                this.Player = Player;
            }
            public static bool operator ==(TicTacToeButton left, TicTacToeButton right) { return left.Button.Equals(right.Button) && left.Player == right.Player; }
            public static bool operator !=(TicTacToeButton left, TicTacToeButton right) { return !(left == right); }
            public override bool Equals(object obj)
            {
                if (obj is TicTacToeButton) { return this.Equals((TicTacToeButton)obj); }
                return base.Equals(obj);
            }
            public bool Equals(TicTacToeButton obj) { return this == obj; }
            public override int GetHashCode() { return base.GetHashCode(); }
        }
        public enum TicTacToeBaseControl
        {
            Button1 = 1,
            Button2 = 2,
            Button3 = 3,
            Button4 = 4,
            Button5 = 5,
            Button6 = 6,
            Button7 = 7,
            Button8 = 8,
            Button9 = 9,
            ButtonChange = 10,
            ButtonReset = 11,
            Escape = 12,
            W = 13,
            D = 14,
        }
        //
        // Initialize Parameter(Enum, Property)
        //
        private string BaseTitle = "過三關：攻擊方";
        private int BaseRound = 0;
        private bool BaseLock = false;
        private bool BaseAutoDubegging = false;
        private TicTacToeMode BaseMode;
        private TicTacToeResult BaseResult;
        private TicTacToeTurn BaseTurn;
        private TicTacToeButton[] Buttons;
        public enum TicTacToeMode
        {
             GeneralAttack = 1,
             GeneralAttckBonusScene = 2,
             GeneralDefend = 3,
             DebugAttack = 4,
             DebugDefend = 5,
        }
        public enum TicTacToeResult
        {
            None = 0,
            Won = 1,
            Tied = 2,
            Lost = 3,
        }
        public enum TicTacToeTurn
        {
            None = 0,
            AI = 1,
            Player = 2,
        }
        [Category("TicTacToe")] public string Title
        {
            get { return this.BaseTitle; }
            private set { this.BaseTitle = value; }
        }
        [Category("TicTacToe")] public int Round
        {
            get { return this.BaseRound; }
            private set { this.BaseRound = value; }
        }
        [Category("TicTacToe")] public bool Lock
        {
            get { return this.BaseLock; }
            set
            { 
                this.BaseLock = value;
                if (value == true) { base.Cursor = Cursors.No; }
                else { base.Cursor = Cursors.Arrow; }
            }
        }
        [Category("TicTacToe")] public bool AutoDubegging
        {
            get { return this.BaseAutoDubegging; }
            set { this.BaseAutoDubegging = value; }
        }
        [Category("TicTacToe")] public TicTacToeMode Mode
        {
            get { return this.BaseMode; }
            private set { this.BaseMode = value; }
        }
        [Category("TicTacToe")] public TicTacToeTurn Turn
        {
            get { return this.BaseTurn; }
            private set { this.BaseTurn = value; }
        }
        [Category("TicTacToe")] public TicTacToeResult Result
        {
            get { return this.BaseResult; }
            private set { this.BaseResult = value; }
        }
        //
        // AI AICore IsRow GetCase
        //
        private struct AIObject
        {
            public readonly string Message;
            public readonly TicTacToeBaseControl Removed;
            public AIObject(string Message)
            {
                this.Message = Message;
                this.Removed = 0;
            }
            public AIObject(string Message, TicTacToeBaseControl Removed)
            {
                this.Message = Message;
                this.Removed = Removed;
            }
        }
        private struct AIStatus
        {
            public readonly string Message;
            public readonly TicTacToeBaseControl[] Removes;
            public AIStatus(string Message)
            {
                this.Message = Message;
                this.Removes = new TicTacToeBaseControl[] {};
            }
            public AIStatus(string Message, TicTacToeBaseControl[] Removes)
            {
                this.Message = Message;
                this.Removes = Removes;
            }
        }
        private AIObject AI()
        {
            AIStatus Status = AICore();
            if (Status.Message != "AIException")
            {
                int Rand = RndRemove(9, 1, GetRemoves(Status.Removes.ToInt()));
                SetButton(Rand.ToBsCon(), false);
                return new AIObject(Status.Message, Rand.ToBsCon());
            }
            else { return new AIObject(Status.Message); }
        }
        private AIStatus AICore()
        {
            if (BaseRound >= 9) { return new AIStatus("AIException", NotRemoves().ToBsCon()); }
            if (GetButtonPlayer(TicTacToeBaseControl.Button5) == 0 && BaseRound == 1) { return new AIStatus("Middle", NotRemoves(new TicTacToeBaseControl[] { TicTacToeBaseControl.Button5 }.ToInt()).ToBsCon()); }
            else if (BaseRound <= 1) { return new AIStatus("Middle+Corner", NotRemoves(new TicTacToeBaseControl[] { TicTacToeBaseControl.Button1, TicTacToeBaseControl.Button3, TicTacToeBaseControl.Button5, TicTacToeBaseControl.Button7, TicTacToeBaseControl.Button9 }.ToInt()).ToBsCon()); }
            // {Case(i): i ∈ [1, 13] }
            for (int i = 1; i <= 13; ++i)
            {
                if (GetCase(i).Length != 0) { return new AIStatus("Case" + i.ToString(), GetCase(i).ToBsCon()); }
            }
            // {Basic: AI, Player}
            for (int i = 1; i <= 3; ++i)
            {
                if (AlmostWin(Row(i)) < 0) { return new AIStatus("AIRowWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Row(i))), i).ToInt()).ToBsCon()); }
            }
            for (int i = 1; i <= 3; ++i)
            {
                if (AlmostWin(Column(i)) < 0) { return new AIStatus("AIColumnWin", NotRemoves(GetButtonInt(i, Math.Abs(AlmostWin(Column(i)))).ToInt()).ToBsCon()); }
            }
            if (AlmostWin(Skew(1)) < 0) { return new AIStatus("AISkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(1))), Math.Abs(AlmostWin(Skew(1)))).ToInt()).ToBsCon()); }
            if (AlmostWin(Skew(-1)) < 0) { return new AIStatus("AISkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(-1))), 4 - Math.Abs(AlmostWin(Skew(-1)))).ToInt()).ToBsCon()); }
            for (int i = 1; i <= 3; ++i)
            {
                if (AlmostWin(Row(i)) > 0) { return new AIStatus("PlayerRowWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Row(i))), i).ToInt()).ToBsCon()); }
            }
            for (int i = 1; i <= 3; ++i)
            {
                if (AlmostWin(Column(i)) > 0) { return new AIStatus("PlayerColumnWin", NotRemoves(GetButtonInt(i, Math.Abs(AlmostWin(Column(i)))).ToInt()).ToBsCon()); }
            }
            if (AlmostWin(Skew(1)) > 0) { return new AIStatus("PlayerSkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(1))), Math.Abs(AlmostWin(Skew(1)))).ToInt()).ToBsCon()); }
            if (AlmostWin(Skew(-1)) > 0) { return new AIStatus("PlayerSkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(-1))), 4 - Math.Abs(AlmostWin(Skew(-1)))).ToInt()).ToBsCon()); }
            // {Random}
            return new AIStatus("Random");
        }
        private bool IsRow(int n, BaseType.VectorBoolean[] VectorBooleans)
        {
            if (n == 1 && VectorBooleans[0] == 1 && VectorBooleans[1] == 0 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 2 && VectorBooleans[0] == -1 && VectorBooleans[1] == 0 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 3 && VectorBooleans[0] == 0 && VectorBooleans[1] == 1 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 4 && VectorBooleans[0] == 0 && VectorBooleans[1] == -1 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 5 && VectorBooleans[0] == 1 && VectorBooleans[1] == -1 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 6 && VectorBooleans[0] == 0 && VectorBooleans[1] == 0 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 7 && VectorBooleans[0] == -1 && VectorBooleans[1] == 1 && VectorBooleans[2] == 0 && VectorBooleans.Length == 3) { return true; }
            if (n == 8 && VectorBooleans[0] == 1 && VectorBooleans[1] == -1 && VectorBooleans[2] == -1 && VectorBooleans.Length == 3) { return true; }
            if (n == 9 && VectorBooleans[0] == -1 && VectorBooleans[1] == 0 && VectorBooleans[2] == 1 && VectorBooleans.Length == 3) { return true; }
            if (n == 10 && VectorBooleans[0] == -1 && VectorBooleans[1] == 1 && VectorBooleans[2] == -1 && VectorBooleans.Length == 3) { return true; }
            return false;
        }
        private int[] GetCase(int n)
        {
            switch (n)
            {
                case 1:
                    if ((IsRow(1, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 1).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(4, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(4, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 1).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    break;
                case 2:
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(5, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(5, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(4, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(5, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(5, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(4, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    break;
                case 3:
                    if ((IsRow(3, Row(1)) == true && IsRow(5, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(5, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(5, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(5, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    break;
                case 4:
                    if ((IsRow(1, Row(1)) == true && IsRow(3, Row(2)) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(3, Column(2)) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(3, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(3, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(3, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(3, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(3, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(3, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    break;
                case 5:
                    if ((IsRow(6, Row(1)) == true && IsRow(5, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(5, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    break;
                case 6:
                    if ((IsRow(6, Row(1)) == true && IsRow(3, Row(2)) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(3, Column(2)) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(3, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(3, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(3, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(3, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(3, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(3, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    break;
                case 7:
                    if ((IsRow(7, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(1, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(7, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(1, Column(2).Reverse()) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(7, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(1, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(7, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(1, Column(2).Reverse()) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(1, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(7, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(1, Row(2).Reverse()) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(7, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(1, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(7, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(1, Row(2).Reverse()) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(7, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    break;
                case 8:
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(1, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(1, Row(2)) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(1, Row(2).Reverse()) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(1, Row(2).Reverse()) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 3).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(1, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(1, Column(2)) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(1, Column(2).Reverse()) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(1, Column(2).Reverse()) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    break;
                case 9:
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(8, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(5, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(8, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(3, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(5, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(8, Row(2).Reverse()) == true && IsRow(6, Row(3)) == true) &&
                       (IsRow(5, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(8, Row(2).Reverse()) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(5, Column(1).Reverse()) == true && IsRow(4, Column(2)) == true && IsRow(3, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(5, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(8, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(3, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(5, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(8, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(5, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(8, Column(2).Reverse()) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(5, Row(1).Reverse()) == true && IsRow(4, Row(2)) == true && IsRow(3, Row(3)) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(8, Column(2).Reverse()) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 1).ToInt() }; }
                    break;
                case 10:
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(4, Column(2)) == true && IsRow(7, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(5, Row(2).Reverse()) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(7, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(5, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(7, Column(1)) == true && IsRow(4, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(5, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(7, Column(1).Reverse()) == true && IsRow(4, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(4, Row(2)) == true && IsRow(7, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 3).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(7, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(5, Column(2).Reverse()) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 3).ToInt() }; }
                    if ((IsRow(7, Row(1)) == true && IsRow(4, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(5, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(3, 1).ToInt() }; }
                    if ((IsRow(7, Row(1).Reverse()) == true && IsRow(4, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(5, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(1, 1).ToInt() }; }
                    break;
                case 11:
                    if ((IsRow(9, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(9, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(9, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(6, Row(3)) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(6, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(9, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(9, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(9, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(9, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(6, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(6, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(9, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    break;
                case 12:
                    if ((IsRow(9, Row(1)) == true && IsRow(1, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(10, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(2, Row(1)) == true && IsRow(1, Row(2)) == true && IsRow(9, Row(3)) == true) &&
                        (IsRow(10, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(9, Row(1).Reverse()) == true && IsRow(1, Row(2).Reverse()) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(10, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 3).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 1).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(1, Row(2).Reverse()) == true && IsRow(9, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(10, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(10, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(9, Column(1)) == true && IsRow(1, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(10, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(1, Column(2)) == true && IsRow(9, Column(3)) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 3).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(10, Row(3)) == true) &&
                        (IsRow(9, Column(1).Reverse()) == true && IsRow(1, Column(2).Reverse()) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(10, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(1, Column(2).Reverse()) == true && IsRow(9, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(2, 1).ToInt(), GetButtonInt(3, 2).ToInt() }; }
                    break;
                case 13:
                    if ((IsRow(2, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(1, Row(3).Reverse()) == true) &&
                        (IsRow(2, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(1, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(1, Row(1)) == true && IsRow(6, Row(2)) == true && IsRow(2, Row(3).Reverse()) == true) &&
                        (IsRow(1, Column(1)) == true && IsRow(6, Column(2)) == true && IsRow(2, Column(3).Reverse()) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(1, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(2, Row(3)) == true) &&
                        (IsRow(2, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(1, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    if ((IsRow(2, Row(1).Reverse()) == true && IsRow(6, Row(2)) == true && IsRow(1, Row(3)) == true) &&
                        (IsRow(1, Column(1).Reverse()) == true && IsRow(6, Column(2)) == true && IsRow(2, Column(3)) == true))
                    { return new int[] { GetButtonInt(2, 1).ToInt(), GetButtonInt(1, 2).ToInt(), GetButtonInt(2, 2).ToInt(), GetButtonInt(3, 2).ToInt(), GetButtonInt(2, 3).ToInt() }; }
                    break;
            }
            return new int[] { };
        }
        //
        // Row, Column, Skew
        //
        private BaseType.VectorBoolean[] Row(int n)
        {
            BaseType.VectorBoolean[] RowData = new BaseType.VectorBoolean[] { (0).ToVecBool(), (0).ToVecBool(), (0).ToVecBool() };
            if (n >= 1 && n <= 3)
            {
                for (int i = 1; i <= 3; ++i) { RowData[i - 1] = GetButtonPlayer(GetButtonInt(i, n)); }
            }
            return RowData;
        }
        private BaseType.VectorBoolean[] Column(int n)
        {
            BaseType.VectorBoolean[] ColumnData = new BaseType.VectorBoolean[] { (0).ToVecBool(), (0).ToVecBool(), (0).ToVecBool() };
            if (n >= 1 && n <= 3)
            {
                for (int i = 1; i <= 3; ++i) { ColumnData[i - 1] = GetButtonPlayer(GetButtonInt(n, i)); }
            }
            return ColumnData;
        }
        private BaseType.VectorBoolean[] Skew(int n)
        {
            BaseType.VectorBoolean[] SkewData = new BaseType.VectorBoolean[] { (0).ToVecBool(), (0).ToVecBool(), (0).ToVecBool() };
            for (int i = 1; i <= 3; ++i)
            {
                if (n == 1) { SkewData[i - 1] = GetButtonPlayer(GetButtonInt(i, i)); }
                else if (n == -1) { SkewData[i - 1] = GetButtonPlayer(GetButtonInt(i, 4 - i)); }
            }
            return SkewData;
        }
        //
        // AlmostWin, Win
        //
        private int AlmostWin(BaseType.VectorBoolean[] VectorBooleans)
        {
            if (VectorBooleans.Length != 3) { return 0; }
            if (VectorBooleans[0] * VectorBooleans[1] * VectorBooleans[2] == 0 && Math.Abs(VectorBooleans[0] + VectorBooleans[1] + VectorBooleans[2]) == 2)
            {
                int Zero = 0;
                int ZeroCount = 0;
                for (int i = 0; i <= 2; ++i)
                {
                    if (VectorBooleans[i] == 0)
                    {
                        Zero = (int)((i + 1) * (VectorBooleans[0] + VectorBooleans[1] + VectorBooleans[2]) / Math.Abs(VectorBooleans[0] + VectorBooleans[1] + VectorBooleans[2]));
                        ZeroCount = ZeroCount + 1;
                    }
                }
                if (ZeroCount == 1)  { return Zero; }
                else { return 0; }
            }
            else { return 0; }
        }
        private int Win(BaseType.VectorBoolean[] VectorBooleans)
        {
            if (VectorBooleans.Length != 3) { return 0; }
            if (VectorBooleans[0] * VectorBooleans[1] * VectorBooleans[2] != 0 && Math.Abs(VectorBooleans[0] + VectorBooleans[1] + VectorBooleans[2]) == 3) { return (int)((VectorBooleans[0] + VectorBooleans[1] + VectorBooleans[2]) / Math.Abs(VectorBooleans[0] + VectorBooleans[1] + VectorBooleans[2])); }
            else { return 0; }
        }
        //
        // GetButtonInt, GetButtonID, GetButton, GetButtonPlayer, SetButton, ResetButton
        //
        public static TicTacToeBaseControl GetButtonInt(int x, int y)
        {
            if (1 <= x && x <= 3 && 1 <= y && y <= 3) { return (TicTacToeBaseControl)(x + 3 * (y - 1)); }
            else { throw new Exception(); }
        }
        public TicTacToeBaseControl GetButtonID(Button Control)
        {
            if (Control.Equals(this.ButtonChange)) { return TicTacToeBaseControl.ButtonChange; }
            else if (Control.Equals(this.ButtonReset)) { return TicTacToeBaseControl.ButtonReset; }
            else
            {
                for (int i = 0; i < Buttons.Length; ++i)
                {
                    if (Buttons[i].Button.Equals(Control) == true) { 
                        return (TicTacToeBaseControl)(i + 1);
                    }
                }
                throw new Exception();
            }
        }
        private Button GetButton(TicTacToeBaseControl Control)
        {
            if (Control == TicTacToeBaseControl.ButtonChange) { return this.ButtonChange; }
            else if (Control == TicTacToeBaseControl.ButtonReset) { return this.ButtonReset; }
            else if (Control == TicTacToeBaseControl.Escape) { throw new Exception(); }
            else { return Buttons[Control.ToInt() - 1].Button; }
        }
        private BaseType.VectorBoolean GetButtonPlayer(TicTacToeBaseControl Control)
        {
            if (Control == TicTacToeBaseControl.ButtonChange) { throw new Exception(); }
            else if (Control == TicTacToeBaseControl.ButtonReset) { throw new Exception(); }
            else if (Control == TicTacToeBaseControl.Escape) { throw new Exception(); }
            else { return Buttons[Control.ToInt() - 1].Player; }
        }
        private Button SetButton(TicTacToeBaseControl Control, Boolean Player) { return SetButton(Control, Player, false); }
        private Button SetButton(TicTacToeBaseControl Control, Boolean Player, bool DisableData)
        {
            if (Control == TicTacToeBaseControl.ButtonChange) { return this.ButtonChange; }
            else if (Control == TicTacToeBaseControl.ButtonReset) { return this.ButtonReset; }
            else if (Control == TicTacToeBaseControl.Escape) { throw new Exception(); }
            else
            {
                if (BaseRound < 9)
                {
                    if (DisableData == false)
                    {
                        if (Player == true) { Buttons[Control.ToInt() - 1].Player = (BaseType.VectorBoolean)(1); }
                        else { Buttons[Control.ToInt() - 1].Player = (BaseType.VectorBoolean)(-1); }
                    }
                    if (Player == true)
                    {
                        Buttons[Control.ToInt() - 1].Button.Text = " O ";
                        Buttons[Control.ToInt() - 1].Button.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        Buttons[Control.ToInt() - 1].Button.Text = " X ";
                        Buttons[Control.ToInt() - 1].Button.ForeColor = System.Drawing.Color.Red;
                    }
                    BaseRound = BaseRound + 1;
                }
                return Buttons[Control.ToInt() - 1].Button;
            }
        }
        private Button ResetButton(TicTacToeBaseControl Control) { return ResetButton(Control, false); }
        private Button ResetButton(TicTacToeBaseControl Control, bool DisableData)
        {
            Buttons[Control.ToInt() - 1].Button.ForeColor = System.Drawing.Color.Black;
            Buttons[Control.ToInt() - 1].Button.BackColor = System.Drawing.SystemColors.Control;
            Buttons[Control.ToInt() - 1].Button.UseVisualStyleBackColor = true;
            Buttons[Control.ToInt() - 1].Button.Text = "";
            if (DisableData == false) { Buttons[Control.ToInt() - 1].Player = (BaseType.VectorBoolean)0; }
            return Buttons[Control.ToInt() - 1].Button;
        }
        //
        // GetRemoves, NotRemoves, RndRemove
        //
        public int[] GetRemoves(params int[] Removes)
        {
            int[] Base = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if (BaseResult != TicTacToeResult.None) { return Base; }
            for (int i = 0; i < Buttons.Length; ++i)
            {
                if (Math.Abs(GetButtonPlayer((TicTacToeBaseControl)(i + 1))) == 0) { Base[i] = 0; }
            }
            int[] Number = new int[Base.Length + Removes.Length];
            for (int t = 0; t < Base.Length + Removes.Length; ++t)
            {
                if (t < Base.Length) { Number[t] = Base[t]; }
                else { Number[t] = Removes[t - Base.Length]; }
            }
            int[] PreOutput = new int[Number.Length];
            int PreI = 0;
            for (int s = 0; s < Number.Length; ++s)
            {
                if (Number[s] != 0) { PreOutput[s - PreI] = Number[s]; }
                else { PreI = PreI + 1; }
            }
            int[] Output = new int[PreOutput.Length - PreI];
            for (int n = 0; n < Output.Length; ++n) { Output[n] = PreOutput[n]; }
            return Output;
        }
        public static int[] NotRemoves(params int[] Removes)
        {
            int[] All = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int RemovesLength = 0;
            for (int i = 0; i < All.Length; ++i)
            {
                for (int j = 0; j < Removes.Length; ++j)
                {
                    if (All[i] == Removes[j])
                    {
                        All[i] = 0;
                        RemovesLength = RemovesLength + 1;
                    }
                }
            }
            int[] Output = new int[All.Length - RemovesLength];
            int AddCount = 0;
            for (int k = 0; k < Output.Length; ++k)
            {
            Line:
                if (All[k + AddCount] == 0)
                {
                    AddCount = AddCount + 1;
                    goto Line;
                }
                Output[k] = All[k + AddCount];
            }
            return Output;
        }
        public static int RndRemove(int Max, int Min, params int[] Removes)
        {
            int[] Number = new int[Max - Min + 1];
            int RemoveI = 0;
            for (int i = 0; i < Max - Min + 1; ++i)
            {
                bool IsRemove = false;
                for (int v = 0; v < Removes.Length; ++v)
                {
                    if (Min + i == Removes[v])
                    {
                        IsRemove = true;
                        break;
                    }
                }
                if (IsRemove == false) { Number[i - RemoveI] = Min + i; }
                else { RemoveI = RemoveI + 1; }
            }
            int[] Output = new int[Max - Min - RemoveI + 1];
            for (int s = 0; s < Max - Min - RemoveI + 1; ++s) { Output[s] = Number[s]; }
            Random generator = new Random();
            int Rand = generator.Next(0, Output.Length);
            return Output[Rand];
        }
        //
        // Delegate Invoker
        //
        private void TicTacToeNewModeInvoker(object sender)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeNewModeEvent.Invoke(sender, new TicTacToeGameEventArgs(BaseMode));
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
        }
        private void TicTacToeNewGameInvoker(object sender)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeNewGameEvent.Invoke(sender, new TicTacToeGameEventArgs(BaseMode));
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
        }
        private void TicTacToeNewRoundInvoker(object sender, TicTacToeBaseControl HasClicked, string AIDetails)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeNewRoundEvent.Invoke(sender, new TicTacToeRoundEventArgs(BaseMode, HasClicked, AIDetails));
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
        }
        private void TicTacToeHasResultInvoker(object sender)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeHasResultEvent.Invoke(sender, new TicTacToeResultEventArgs(BaseResult));
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
        }
        private bool TicTacToeStartUpInvoker(object sender, bool CancelEvent)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeStartUpEventArgs StartUp = new TicTacToeStartUpEventArgs(CancelEvent);
            TicTacToeStartUpEvent.Invoke(sender, StartUp);
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
            return StartUp.CancelNewGameEvent;
        }
        private void TicTacToeKeyDownInvoker(object sender, KeyEventArgs e)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeKeyDownEvent.Invoke(sender, e);
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
        }
        private void TicTacToeClickInvoker(object sender, EventArgs e)
        {
            string OriginalTitle = BaseTitle;
            int OriginalRound = BaseRound;
            bool OriginalLock = BaseLock;
            bool OriginalAutoDubegging = BaseAutoDubegging;
            TicTacToeMode OriginalMode = BaseMode;
            TicTacToeResult OriginalResult = BaseResult;
            TicTacToeTurn OriginalTurn = BaseTurn;
            TicTacToeClickEvent.Invoke(sender, e);
            if (OriginalTitle != BaseTitle ||
                OriginalRound != BaseRound ||
                OriginalLock != BaseLock ||
                OriginalAutoDubegging != BaseAutoDubegging ||
                OriginalMode != BaseMode ||
                OriginalResult != BaseResult ||
                OriginalTurn != BaseTurn) { throw new UsercontrolDistroyedException(); }
        }
        //
        // NowWin, IsWin
        //
        private bool NowWin(TicTacToeBaseControl HasClicked, string AIDetails, object sender, bool Shadow)
        {
            if (Shadow == false) { TicTacToeNewRoundInvoker(sender, HasClicked, AIDetails); }
            if (BaseRound == 10) { return false; }
            if (BaseRound <= 9)
            {
                int[] PlayerIsWin = IsWin(1);
                int[] AIIsWin = IsWin(-1);
                if (PlayerIsWin.Length != 0)
                {
                    for (int v = 0; v < PlayerIsWin.Length; ++v) { GetButton((TicTacToeBaseControl)(PlayerIsWin[v])).BackColor = System.Drawing.SystemColors.GradientInactiveCaption; }
                    BaseTitle = BaseTitle + "［你贏了］";
                    BaseResult = TicTacToeResult.Won;
                    BaseRound = 10;
                    BaseTurn = TicTacToeTurn.None;
                }
                else if (AIIsWin.Length != 0)
                {
                    for (int v = 0; v < AIIsWin.Length; ++v) { GetButton((TicTacToeBaseControl)(AIIsWin[v])).BackColor = System.Drawing.SystemColors.GradientInactiveCaption; }
                    BaseTitle = BaseTitle + "［你輸了］";
                    BaseResult = TicTacToeResult.Lost;
                    BaseRound = 10;
                    BaseTurn = TicTacToeTurn.None;
                }
            }
            if (BaseRound == 9)
            {
                BaseTitle = BaseTitle + "［和局］";
                BaseResult = TicTacToeResult.Tied;
                BaseRound = 10;
                BaseTurn = TicTacToeTurn.None;
            }
            if (BaseResult != TicTacToeResult.None)
            {
                if (Shadow == false) { TicTacToeHasResultInvoker(sender); }
                return true;
            }
            return false;
        }
        private int[] IsWin(int n)
        {
            if (n == 1 || n == -1)
            {
                int[] PreOutput = new int[6];
                int t = 0;
                for (int i = 1; i <= 3; ++i)
                {
                    int RowI = Win(Row(i));
                    if (RowI == 0) { }
                    else if ((double)RowI / Math.Abs(RowI) == n)
                    {
                        for (int s = 1; s <= 3; ++s)
                        {
                            PreOutput[t] = GetButtonInt(s, i).ToInt();
                            t = t + 1;
                        }
                    }
                    int ColumnI = Win(Column(i));
                    if (ColumnI == 0) { }
                    else if ((double)ColumnI / Math.Abs(ColumnI) == n)
                    {
                        for (int s = 1; s <= 3; ++s)
                        {
                            PreOutput[t] = GetButtonInt(i, s).ToInt();
                            t = t + 1;
                        }
                    }
                }
                for (int i = -1; i <= 1; ++i, ++i)
                {
                    if (Win(Skew(i)) == n)
                    {
                        for (int s = 1; s <= 3; ++s)
                        {
                            PreOutput[t] = GetButtonInt(s, (s) * (1 + i) / 2 + (4 - s) * (1 - i) / 2).ToInt();
                            t = t + 1;
                        }
                    }
                }
                int[] Output = new int[t];
                for (int v = 0; v < t; ++v) { Output[v] = PreOutput[v]; }
                return Output;
            }
            else { return new int[] { }; }
        }
        //
        // Me, ButtonChange, ButtonReset, Button
        //
        void Base_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(276, 317);
            Buttons = new TicTacToeButton[] {
                new TicTacToeButton(this.Button1, (0).ToVecBool()),
                new TicTacToeButton(this.Button2, (0).ToVecBool()),
                new TicTacToeButton(this.Button3, (0).ToVecBool()),
                new TicTacToeButton(this.Button4, (0).ToVecBool()),
                new TicTacToeButton(this.Button5, (0).ToVecBool()),
                new TicTacToeButton(this.Button6, (0).ToVecBool()),
                new TicTacToeButton(this.Button7, (0).ToVecBool()),
                new TicTacToeButton(this.Button8, (0).ToVecBool()),
                new TicTacToeButton(this.Button9, (0).ToVecBool())
            };
            BaseMode = TicTacToeMode.GeneralAttack;
            BaseTurn = TicTacToeTurn.Player;
            if (TicTacToeStartUpInvoker(sender, false) == false)
            {
                TicTacToeNewModeInvoker(sender);
                TicTacToeNewGameInvoker(sender);
            }
        }
        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            Form_KeyDown(sender, e, false);
            TicTacToeKeyDownInvoker(sender, e);
        }
        void Form_KeyDown(object sender, KeyEventArgs e, bool UnLock) { Form_KeyDown(sender, e, UnLock, false); }
        void Form_KeyDown(object sender, KeyEventArgs e, bool UnLock, bool Shadow)
        {
            if (BaseLock == false || UnLock == true)
            {
                if (e.KeyCode == Keys.W && (BaseMode == TicTacToeMode.GeneralAttack || BaseMode == TicTacToeMode.GeneralAttckBonusScene))
                {
                    ResetBase();
                    BaseTitle = "過三關：攻擊方［勝利彩蛋］";
                    SetButton(TicTacToeBaseControl.Button1, true, true);
                    SetButton(TicTacToeBaseControl.Button2, false, true);
                    SetButton(TicTacToeBaseControl.Button3, true, true);
                    SetButton(TicTacToeBaseControl.Button4, false, true);
                    SetButton(TicTacToeBaseControl.Button5, true, true);
                    SetButton(TicTacToeBaseControl.Button6, false, true);
                    SetButton(TicTacToeBaseControl.Button7, true, true);
                    SetButton(TicTacToeBaseControl.Button8, false, true);
                    SetButton(TicTacToeBaseControl.Button9, true, true);
                    BaseMode = TicTacToeMode.GeneralAttckBonusScene;
                    BaseTurn = TicTacToeTurn.None;
                    ButtonReset.Enabled = true;
                    if (Shadow == false)
                    {
                        TicTacToeNewModeInvoker(sender);
                        TicTacToeNewGameInvoker(sender);
                    }
                }
                else if (e.KeyCode == Keys.D && (BaseMode == TicTacToeMode.GeneralAttack || BaseMode == TicTacToeMode.GeneralDefend))
                {
                    if (BaseMode == TicTacToeMode.GeneralAttack) { BaseMode = TicTacToeMode.DebugAttack; }
                    if (BaseMode == TicTacToeMode.GeneralDefend) { BaseMode = TicTacToeMode.DebugDefend; }
                    if (Shadow == false) { TicTacToeNewModeInvoker(sender); }
                    ButtonReset_Click(sender, e, true, Shadow);
                }
                else if (e.KeyCode == Keys.Escape && (BaseMode == TicTacToeMode.DebugAttack || BaseMode == TicTacToeMode.DebugDefend))
                {
                    if (BaseMode == TicTacToeMode.DebugAttack) { BaseMode = TicTacToeMode.GeneralAttack; }
                    if (BaseMode == TicTacToeMode.DebugDefend) { BaseMode = TicTacToeMode.GeneralDefend; }
                    if (Shadow == false) { TicTacToeNewModeInvoker(sender); }
                    ButtonReset_Click(sender, e, true, Shadow);
                }
            }
        }
        void ButtonChange_Click(object sender, EventArgs e)
        {
            ButtonChange_Click(sender, e, false);
            TicTacToeClickInvoker(sender, e);
        }
        void ButtonChange_Click(object sender, EventArgs e, bool UnLock) { ButtonChange_Click(sender, e, UnLock, false); }
        void ButtonChange_Click(object sender, EventArgs e, bool UnLock, bool Shadow) { ButtonChange_Click(sender, e, UnLock, Shadow, false); }
        void ButtonChange_Click(object sender, EventArgs e, bool UnLock, bool Shadow, bool DisableAI)
        {
            if (BaseLock == false || UnLock == true)
            {
                if (Shadow == false) { TicTacToeNewModeInvoker(sender); }
                if (BaseMode == TicTacToeMode.GeneralAttack)
                {
                    BaseMode = TicTacToeMode.GeneralDefend;
                    BaseTurn = TicTacToeTurn.AI;
                }
                else if (BaseMode == TicTacToeMode.GeneralDefend)
                {
                    BaseMode = TicTacToeMode.GeneralAttack;
                    BaseTurn = TicTacToeTurn.Player;
                }
                if (BaseMode == TicTacToeMode.DebugAttack)
                {
                    BaseMode = TicTacToeMode.DebugDefend;
                    BaseTurn = TicTacToeTurn.AI;
                }
                else if (BaseMode == TicTacToeMode.DebugDefend)
                {
                    BaseMode = TicTacToeMode.DebugAttack;
                    BaseTurn = TicTacToeTurn.Player;
                }
                ButtonReset_Click(sender, e, true, Shadow, DisableAI);
            }
        }
        void ButtonReset_Click(object sender, EventArgs e)
        {
            ButtonReset_Click(sender, e, false);
            TicTacToeClickInvoker(sender, e);
        }
        void ButtonReset_Click(object sender, EventArgs e, bool UnLock) { ButtonReset_Click(sender, e, UnLock, false); }
        void ButtonReset_Click(object sender, EventArgs e, bool UnLock, bool Shadow) { ButtonReset_Click(sender, e, UnLock, Shadow, false); }
        void ButtonReset_Click(object sender, EventArgs e, bool UnLock, bool Shadow, bool DisableAI)
        {
            if (BaseLock == false || UnLock == true)
            {
                if (Shadow == false) { TicTacToeNewModeInvoker(sender); }
                if (BaseMode == TicTacToeMode.GeneralAttckBonusScene) { BaseMode = TicTacToeMode.GeneralAttack; }
                ButtonReset.Enabled = false;
                BaseResult = TicTacToeResult.None;
                BaseRound = 0;
                for (int i = 1; i <= 9; ++i) { ResetButton(i.ToBsCon()); }
                if (BaseMode == TicTacToeMode.GeneralAttack || BaseMode == TicTacToeMode.DebugAttack)
                {
                    BaseTitle = "過三關：攻擊方";
                    BaseTurn = TicTacToeTurn.Player;
                }
                else
                {
                    BaseTitle = "過三關：守備方";
                    BaseTurn = TicTacToeTurn.AI;
                }
                if (BaseMode == TicTacToeMode.DebugAttack || BaseMode == TicTacToeMode.DebugDefend) { BaseTitle = "｛除錯｝" + BaseTitle; }
                if (BaseMode == TicTacToeMode.GeneralDefend && DisableAI == false)
                {
                    AIObject AIObject = AI();
                    NowWin(AIObject.Removed, AIObject.Message, sender, Shadow);
                }
            }
        }
        void Button_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e, false);
            TicTacToeClickInvoker(sender, e);
        }
        void Button_Click(object sender, EventArgs e, bool UnLock) { Button_Click(sender, e, UnLock, false); }
        void Button_Click(object sender, EventArgs e, bool UnLock, bool Shadow)
        {
            TicTacToeBaseControl n = GetButtonID(sender as Button);
            if ((BaseLock == false || UnLock == true) && (GetButtonPlayer(n) == 0 && BaseRound < 9))
            {
            Turn:
                if (BaseMode == TicTacToeMode.GeneralAttack || BaseMode == TicTacToeMode.GeneralDefend)
                {
                    SetButton(n, true);
                    NowWin(n, "(NonAI)", sender, Shadow);
                    BaseTurn = TicTacToeTurn.AI;
                    if (BaseRound < 9)
                    {
                        AIObject AIOutput = AI();
                        NowWin(AIOutput.Removed, AIOutput.Message, sender, Shadow);
                        BaseTurn = TicTacToeTurn.Player;
                    }
                }
                else if ((BaseMode == TicTacToeMode.DebugAttack && BaseRound % 2 == 0) || (BaseMode == TicTacToeMode.DebugDefend && BaseRound % 2 == 1))
                {
                    SetButton(n, true);
                    NowWin(n, "([Debug]Player)", sender, Shadow);
                    BaseTurn = TicTacToeTurn.AI;
                }
                else
                {
                    SetButton(n, false);
                    NowWin(n, "([Debug]AI)", sender, Shadow);
                    BaseTurn = TicTacToeTurn.Player;
                }
                if (BaseAutoDubegging == true && BaseRound < 9)
                {
                    n = (TicTacToeBaseControl)RndRemove(9, 1, GetRemoves());
                    goto Turn;
                }
                ButtonReset.Enabled = true;
            }
        }
        //
        // StartUp, ResetBase, ClickBase
        //
        public bool SetBase(TicTacToeMode Mode, params TicTacToeBaseControl[] Player)
        {
            ResetBase();
            if (Mode == TicTacToeMode.GeneralAttckBonusScene && Player.Length == 0)
            {
                Form_KeyDown(this, new KeyEventArgs(Keys.W), true, true);
                return true;
            }
            else if (Mode == TicTacToeMode.DebugAttack || Mode == TicTacToeMode.DebugDefend)
            {
                Form_KeyDown(this, new KeyEventArgs(Keys.D), true, true);
                if (Mode == TicTacToeMode.DebugDefend) { ButtonChange_Click(ButtonChange, new EventArgs(), true, true, true); }
                bool Real = false;
                for (int i = 0; i < Player.Length; ++i)
                {
                    int[] Removes = GetRemoves();
                    for (int j = 0; j < Removes.Length; ++j)
                    {
                        if (Removes[j] == Player[i].ToInt())
                        {
                            Real = true;
                            break;
                        }
                    }
                    if (Real == false) { Button_Click(GetButton(Player[i]), new EventArgs(), true, true); }
                    else { break; }
                }
                if (Real == false) { return true; }
            }
            else if (Mode == TicTacToeMode.GeneralAttack || Mode == TicTacToeMode.GeneralDefend)
            {
                if (Mode == TicTacToeMode.GeneralDefend) { ButtonChange_Click(ButtonChange, new EventArgs(), true, true, true); }
                bool Real = false;
                for (int i = 0; i < Player.Length; ++i)
                {
                    int[] Removes = GetRemoves();
                    for (int j = 0; j < Removes.Length; ++j)
                    {
                        if (Removes[j] == Player[i].ToInt())
                        {
                            Real = true;
                            break;
                        }
                    }
                    if (BaseTurn == TicTacToeTurn.AI)
                    {
                        AIStatus AI = AICore();
                        for (int k = 0; k < AI.Removes.Length; ++k)
                        {
                            if (AI.Removes[k] == Player[i])
                            {
                                Real = true;
                                break;
                            }
                        }
                    }
                    if (Real == false)
                    {
                        if (BaseTurn == TicTacToeTurn.Player)
                        {
                            SetButton(Player[i], true);
                            NowWin(Player[i], "SetBase", this, true);
                            if (BaseTurn != TicTacToeTurn.None) { BaseTurn = TicTacToeTurn.AI; }
                        }
                        else if (BaseTurn == TicTacToeTurn.AI)
                        {
                            SetButton(Player[i], false);
                            NowWin(Player[i], "SetBase", this, true);
                            if (BaseTurn != TicTacToeTurn.None) { BaseTurn = TicTacToeTurn.Player; }
                        }
                    }
                    else { break; }
                }
                if (Real == false && (BaseTurn == TicTacToeTurn.Player || BaseTurn == TicTacToeTurn.None))
                {
                    ButtonReset.Enabled = true;
                    return true;
                }
            }
            ResetBase();
            return false;
        }
        public bool ResetBase()
        {
            if (BaseMode == TicTacToeMode.DebugAttack || BaseMode == TicTacToeMode.DebugDefend) { Form_KeyDown(this, new KeyEventArgs(Keys.Escape), true, true); }
            if (BaseMode == TicTacToeMode.GeneralDefend || BaseMode == TicTacToeMode.DebugDefend) { ButtonChange_Click(ButtonChange, new EventArgs(), true, true); }
            ButtonReset_Click(ButtonReset, new EventArgs(), true, true);
            return true;
        }
        public void ClickBase(TicTacToeBaseControl MyBaseControl)
        {
            if (MyBaseControl == TicTacToeBaseControl.ButtonChange) { ButtonChange_Click(GetButton(MyBaseControl), new EventArgs(), true); }
            else if (MyBaseControl == TicTacToeBaseControl.ButtonReset) { ButtonReset_Click(GetButton(MyBaseControl), new EventArgs(), true); }
            else if (MyBaseControl == TicTacToeBaseControl.Escape) { Form_KeyDown(this, new KeyEventArgs(Keys.Escape)); }
            else if (MyBaseControl == TicTacToeBaseControl.W) { Form_KeyDown(this, new KeyEventArgs(Keys.W)); }
            else if (MyBaseControl == TicTacToeBaseControl.D) { Form_KeyDown(this, new KeyEventArgs(Keys.D)); }
            else { Button_Click(GetButton(MyBaseControl), new EventArgs(), true); }
        }
    }
    public static class BaseType
    {
        public struct VectorBoolean
        {
            public static readonly VectorBoolean BaseBoolean = new VectorBoolean(false, false);
            private bool PosBoolean;
            private bool NegBoolean;
            public VectorBoolean(bool Pos, bool Neg)
            {
                this.PosBoolean = Pos;
                this.NegBoolean = Neg;
            }
            public VectorBoolean(double Val)
            {
                if (Val > 0)
                {
                    this.PosBoolean = true;
                    this.NegBoolean = false;
                }
                else if (Val < 0)
                {
                    this.PosBoolean = false;
                    this.NegBoolean = true;
                }
                else
                {
                    this.PosBoolean = false;
                    this.NegBoolean = false;
                }
            }
            public static bool operator ==(VectorBoolean left, VectorBoolean right) { return left.PosBoolean == right.NegBoolean && left.NegBoolean == right.NegBoolean; }
            public static bool operator !=(VectorBoolean left, VectorBoolean right) { return !(left == right); }
            public static implicit operator double(VectorBoolean VBool)
            {
                if (VBool.PosBoolean == true && VBool.NegBoolean == false) { return 1; }
                else if (VBool.PosBoolean == false && VBool.NegBoolean == true) { return -1; }
                else { return 0; }
            }
            public static explicit operator VectorBoolean(double VBool) { return new VectorBoolean(VBool); }
            public static VectorBoolean[] ReverseVectorBoolean(VectorBoolean[] VBools)
            {
                VectorBoolean[] Output = (VectorBoolean[])VBools.Clone();
                for (int i = 0; i < VBools.Length; ++i) { Output[i] = VBools[VBools.Length - 1 - i]; }
                return Output;
            }
            public override string ToString() { return "[" + ((double)this).ToString() + ", (+: " + this.PosBoolean.ToString() + ", -: " + this.NegBoolean.ToString() + ")" + "]"; }
            public override bool Equals(object obj)
            {
                if (obj is VectorBoolean) { return this.Equals((VectorBoolean)obj); }
                return base.Equals(obj);
            }
            public bool Equals(VectorBoolean obj) { return this == obj; }
            public override int GetHashCode() { return base.GetHashCode(); }
        }
        public static int Occurrences(this String ths, string phrase) { return (ths.Length - ths.Replace(phrase, string.Empty).Length) / phrase.Length; }
        public static VectorBoolean[] Reverse(this VectorBoolean[] VectorBooleanArray) { return VectorBoolean.ReverseVectorBoolean(VectorBooleanArray); }
        public static string ToStr(this double[] Value)
        {
            string str = "{";
            for (int i = 0; i < Value.Length; ++i)
            {
                str = str + Value[i].ToString();
                if (i != Value.Length - 1) { str = str + ", "; }
            }
            str = str + "}";
            return str;
        }
        public static string ToStr(this int[] Value)
        {
            string str = "{";
            for (int i = 0; i < Value.Length; ++i)
            {
                str = str + Value[i].ToString();
                if (i != Value.Length - 1) { str = str + ", "; }
            }
            str = str + "}";
            return str;
        }
        public static string ToStr(this string[] Value)
        {
            string str = "{";
            for (int i = 0; i < Value.Length; ++i)
            {
                str = str + Value[i].ToString();
                if (i != Value.Length - 1) { str = str + ", "; }
            }
            str = str + "}";
            return str;
        }
        public static string ToStr(this VectorBoolean[] Value)
        {
            string str = "{";
            for (int i = 0; i < Value.Length; ++i)
            {
                str = str + Value[i].ToString();
                if (i != Value.Length - 1) { str = str + ", "; }
            }
            str = str + "}";
            return str;
        }
    }
    public static class ExtMod
    {
        /* TicTacToeLibrary.Base.TicTacToeBaseControl */
        public static int ToInt(this TicTacToeLibrary.Base.TicTacToeBaseControl ths) { return (int)ths; }
        public static TicTacToeLibrary.Base.TicTacToeBaseControl ToBsCon(this int ths)
        {
            if (1 <= ths && ths <= 14) { return (TicTacToeLibrary.Base.TicTacToeBaseControl)ths; }
            else { throw new Exception(); }
        }
        public static int[] ToInt(this TicTacToeLibrary.Base.TicTacToeBaseControl[] ths)
        {
            int[] Output = new int[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI) { Output[OutputI] = (int)ths[OutputI]; }
            return Output;
        }
        public static TicTacToeLibrary.Base.TicTacToeBaseControl[] ToBsCon(this int[] ths)
        {
            TicTacToeLibrary.Base.TicTacToeBaseControl[] Output = new TicTacToeLibrary.Base.TicTacToeBaseControl[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI)
            {
                if (1 <= ths[OutputI] && ths[OutputI] <= 14) { Output[OutputI] = (TicTacToeLibrary.Base.TicTacToeBaseControl)ths[OutputI]; }
                else { throw new Exception(); }
            }
            return Output;
        }
        /* TicTacToeLibrary.Base.TicTacToeMode */
        public static int ToInt(this TicTacToeLibrary.Base.TicTacToeMode ths) { return (int)ths; }
        public static TicTacToeLibrary.Base.TicTacToeMode ToMode(this int ths)
        {
            if (1 <= ths && ths <= 5) { return (TicTacToeLibrary.Base.TicTacToeMode)ths; }
            else { throw new Exception(); }
        }
        public static int[] ToInt(this TicTacToeLibrary.Base.TicTacToeMode[] ths)
        {
            int[] Output = new int[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI) { Output[OutputI] = (int)ths[OutputI]; }
            return Output;
        }
        public static TicTacToeLibrary.Base.TicTacToeMode[] ToMode(this int[] ths)
        {
            TicTacToeLibrary.Base.TicTacToeMode[] Output = new TicTacToeLibrary.Base.TicTacToeMode[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI)
            {
                if (1 <= ths[OutputI] && ths[OutputI] <= 5) { Output[OutputI] = (TicTacToeLibrary.Base.TicTacToeMode)ths[OutputI]; }
                else { throw new Exception(); }
            }
            return Output;
        }
        /* TicTacToeLibrary.Base.TicTacToeResult */
        public static int ToInt(this TicTacToeLibrary.Base.TicTacToeResult ths) { return (int)ths; }
        public static TicTacToeLibrary.Base.TicTacToeResult ToResult(this int ths)
        {
            if (0 <= ths && ths <= 3) { return (TicTacToeLibrary.Base.TicTacToeResult)ths; }
            else { throw new Exception(); }
        }
        public static int[] ToInt(this TicTacToeLibrary.Base.TicTacToeResult[] ths)
        {
            int[] Output = new int[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI) { Output[OutputI] = (int)ths[OutputI]; }
            return Output;
        }
        public static TicTacToeLibrary.Base.TicTacToeResult[] ToResult(this int[] ths)
        {
            TicTacToeLibrary.Base.TicTacToeResult[] Output = new TicTacToeLibrary.Base.TicTacToeResult[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI)
            {
                if (0 <= ths[OutputI] && ths[OutputI] <= 3) { Output[OutputI] = (TicTacToeLibrary.Base.TicTacToeResult)ths[OutputI]; }
                else { throw new Exception(); }
            }
            return Output;
        }
        /* TicTacToeLibrary.Base.TicTacToeTurn */
        public static int ToInt(this TicTacToeLibrary.Base.TicTacToeTurn ths) { return (int)ths; }
        public static TicTacToeLibrary.Base.TicTacToeTurn ToTurn(this int ths)
        {
            if (0 <= ths && ths <= 2) { return (TicTacToeLibrary.Base.TicTacToeTurn)ths; }
            else { throw new Exception(); }
        }
        public static int[] ToInt(this TicTacToeLibrary.Base.TicTacToeTurn[] ths)
        {
            int[] Output = new int[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI) { Output[OutputI] = (int)ths[OutputI]; }
            return Output;
        }
        public static TicTacToeLibrary.Base.TicTacToeTurn[] ToTurn(this int[] ths)
        {
            TicTacToeLibrary.Base.TicTacToeTurn[] Output = new TicTacToeLibrary.Base.TicTacToeTurn[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI)
            {
                if (0 <= ths[OutputI] && ths[OutputI] <= 2) { Output[OutputI] = (TicTacToeLibrary.Base.TicTacToeTurn)ths[OutputI]; }
                else { throw new Exception(); }
            }
            return Output;
        }
        /* TicTacToeLibrary.BaseType.VectorBoolean */
        public static double ToDouble(this TicTacToeLibrary.BaseType.VectorBoolean ths) { return (double)ths; }
        public static TicTacToeLibrary.BaseType.VectorBoolean ToVecBool(this int ths) { return (TicTacToeLibrary.BaseType.VectorBoolean)(double)ths; }
        public static double[] ToDouble(this TicTacToeLibrary.BaseType.VectorBoolean[] ths)
        {
            double[] Output = new double[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI) { Output[OutputI] = (double)ths[OutputI]; }
            return Output;
        }
        public static TicTacToeLibrary.BaseType.VectorBoolean[] ToVecBool(this double[] ths)
        {
            TicTacToeLibrary.BaseType.VectorBoolean[] Output = new TicTacToeLibrary.BaseType.VectorBoolean[ths.Length];
            for (int OutputI = 0; OutputI < Output.Length; ++OutputI) { Output[OutputI] = (TicTacToeLibrary.BaseType.VectorBoolean)ths[OutputI]; }
            return Output;
        }
    }
}
