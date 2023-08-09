Imports TicTacToeLibrary
Imports TicTacToeLibrary.Base
Imports TicTacToeLibrary.BaseType
Imports TicTacToeLibrary.BaseType.VectorBoolean
Imports System.Runtime.CompilerServices
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.Serialization
Imports System.Security
Public Module BaseType
    Public Structure VectorBoolean
        Public Shared ReadOnly BaseBoolean As VectorBoolean = New VectorBoolean(False, False)
        Private PosBoolean As Boolean
        Private NegBoolean As Boolean
        Public Sub New(Pos As Boolean, Neg As Boolean)
            Me.PosBoolean = Pos
            Me.NegBoolean = Neg
        End Sub
        Public Sub New(Val As Double)
            If Val > 0 Then
                Me.PosBoolean = True
                Me.NegBoolean = False
            ElseIf Val < 0 Then
                Me.PosBoolean = False
                Me.NegBoolean = True
            Else
                Me.PosBoolean = False
                Me.NegBoolean = False
            End If
        End Sub
        Public Shared Operator =(left As VectorBoolean, right As VectorBoolean) As Boolean
            Return left.PosBoolean = right.PosBoolean And left.NegBoolean = right.NegBoolean
        End Operator
        Public Shared Operator <>(left As VectorBoolean, right As VectorBoolean) As Boolean
            Return Not (left = right)
        End Operator
        Public Shared Widening Operator CType(VBool As VectorBoolean) As Double
            If VBool.PosBoolean = True And VBool.NegBoolean = False Then
                Return 1
            ElseIf VBool.PosBoolean = False And VBool.NegBoolean = True Then
                Return -1
            Else
                Return 0
            End If
        End Operator
        Public Shared Widening Operator CType(VBool As VectorBoolean) As Integer
            If VBool.PosBoolean = True And VBool.NegBoolean = False Then
                Return 1
            ElseIf VBool.PosBoolean = False And VBool.NegBoolean = True Then
                Return -1
            Else
                Return 0
            End If
        End Operator
        Public Shared Narrowing Operator CType(VBool As Double) As VectorBoolean
            Return New VectorBoolean(VBool)
        End Operator
        Public Shared Narrowing Operator CType(VBool As Integer) As VectorBoolean
            Return New VectorBoolean(VBool)
        End Operator
        Public Shared Function ReverseVectorBoolean(VBools As VectorBoolean()) As VectorBoolean()
            Dim Output As VectorBoolean() = VBools.Clone()
            For i As Integer = 0 To VBools.Length - 1
                Output(i) = VBools(VBools.Length - 1 - i)
            Next
            Return Output
        End Function
        Public Overrides Function ToString() As String
            Return "[" + CType(CType(Me, Double), String) + ", (+: " + CType(Me.PosBoolean, String) + ", -: " + CType(Me.NegBoolean, String) + ")" + "]"
        End Function
    End Structure
    <Extension()>
    Public Function Occurrences(ths As String, phrase As String) As Integer
        Return (ths.Length - ths.Replace(phrase, String.Empty).Length) / phrase.Length
    End Function
    <Extension()>
    Public Function Reverse(VectorBooleanArray As VectorBoolean()) As VectorBoolean()
        Return ReverseVectorBoolean(VectorBooleanArray)
    End Function
    <Extension()>
    Public Function ToStr(Value As Double()) As String
        Dim str As String = "{"
        For i As Integer = 0 To Value.Length - 1
            str = str + Value(i).ToString
            If i <> Value.Length - 1 Then
                str = str + ", "
            End If
        Next
        str = str + "}"
        Return str
    End Function
    <Extension()>
    Public Function ToStr(Value As Integer()) As String
        Dim str As String = "{"
        For i As Integer = 0 To Value.Length - 1
            str = str + Value(i).ToString
            If i <> Value.Length - 1 Then
                str = str + ", "
            End If
        Next
        str = str + "}"
        Return str
    End Function
    <Extension()>
    Public Function ToStr(Value As String()) As String
        Dim str As String = "{"
        For i As Integer = 0 To Value.Length - 1
            str = str + Value(i).ToString
            If i <> Value.Length - 1 Then
                str = str + ", "
            End If
        Next
        str = str + "}"
        Return str
    End Function
    <Extension()>
    Public Function ToStr(Value As VectorBoolean()) As String
        Dim str As String = "{"
        For i As Integer = 0 To Value.Length - 1
            str = str + Value(i).ToString
            If i <> Value.Length - 1 Then
                str = str + ", "
            End If
        Next
        str = str + "}"
        Return str
    End Function
End Module
<DefaultEvent("TicTacToeStartUp")>
Public Class Base
    ''' 
    ''' Initialize Protection{Event, Property}
    ''' 
    <Serializable>
    Public Class UsercontrolDistroyedException
        Inherits System.Exception
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(message As String)
            MyBase.New(message)
        End Sub
        Public Sub New(message As String, innerException As TicTacToeLibrary.Base.UsercontrolDistroyedException)
            MyBase.New(message, innerException)
        End Sub
        <SecuritySafeCritical>
        Protected Sub New(info As SerializationInfo, context As StreamingContext)
            MyBase.New(info, context)
        End Sub
    End Class
    <Serializable>
    Public Class EventNotExistException
        Inherits System.Exception
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(message As String)
            MyBase.New(message)
        End Sub
        Public Sub New(message As String, innerException As TicTacToeLibrary.Base.EventNotExistException)
            MyBase.New(message, innerException)
        End Sub
        <SecuritySafeCritical>
        Protected Sub New(info As SerializationInfo, context As StreamingContext)
            MyBase.New(info, context)
        End Sub
    End Class
    Private Sub ThrowEventNotExistException() Handles EventNotExistTimer.Tick
        If AutoSizeChangedEvent IsNot Nothing Or
           AutoValidateChangedEvent IsNot Nothing Or
           BackColorChangedEvent IsNot Nothing Or
           BackgroundImageChangedEvent IsNot Nothing Or
           BackgroundImageLayoutChangedEvent IsNot Nothing Or
           BindingContextChangedEvent IsNot Nothing Or
           CausesValidationChangedEvent IsNot Nothing Or
           ChangeUICuesEvent IsNot Nothing Or
           ClickEvent IsNot Nothing Or
           ClientSizeChangedEvent IsNot Nothing Or
           ContextMenuChangedEvent IsNot Nothing Or
           ContextMenuStripChangedEvent IsNot Nothing Or
           ControlAddedEvent IsNot Nothing Or
           ControlRemovedEvent IsNot Nothing Or
           CursorChangedEvent IsNot Nothing Or
           DisposedEvent IsNot Nothing Or
           DockChangedEvent IsNot Nothing Or
           DoubleClickEvent IsNot Nothing Or
           DragDropEvent IsNot Nothing Or
           DragEnterEvent IsNot Nothing Or
           DragLeaveEvent IsNot Nothing Or
           DragOverEvent IsNot Nothing Or
           EnabledChangedEvent IsNot Nothing Or
           EnterEvent IsNot Nothing Or
           FontChangedEvent IsNot Nothing Or
           ForeColorChangedEvent IsNot Nothing Or
           GiveFeedbackEvent IsNot Nothing Or
           GotFocusEvent IsNot Nothing Or
           HandleCreatedEvent IsNot Nothing Or
           HandleDestroyedEvent IsNot Nothing Or
           HelpRequestedEvent IsNot Nothing Or
           ImeModeChangedEvent IsNot Nothing Or
           InvalidatedEvent IsNot Nothing Or
           KeyDownEvent IsNot Nothing Or
           KeyPressEvent IsNot Nothing Or
           KeyUpEvent IsNot Nothing Or
           LayoutEvent IsNot Nothing Or
           LeaveEvent IsNot Nothing Or
           LoadEvent IsNot Nothing Or
           LocationChangedEvent IsNot Nothing Or
           LostFocusEvent IsNot Nothing Or
           MarginChangedEvent IsNot Nothing Or
           MouseCaptureChangedEvent IsNot Nothing Or
           MouseClickEvent IsNot Nothing Or
           MouseDoubleClickEvent IsNot Nothing Or
           MouseDownEvent IsNot Nothing Or
           MouseEnterEvent IsNot Nothing Or
           MouseHoverEvent IsNot Nothing Or
           MouseLeaveEvent IsNot Nothing Or
           MouseMoveEvent IsNot Nothing Or
           MouseUpEvent IsNot Nothing Or
           MouseWheelEvent IsNot Nothing Or
           MoveEvent IsNot Nothing Or
           PaddingChangedEvent IsNot Nothing Or
           PaintEvent IsNot Nothing Or
           ParentChangedEvent IsNot Nothing Or
           PreviewKeyDownEvent IsNot Nothing Or
           QueryAccessibilityHelpEvent IsNot Nothing Or
           QueryContinueDragEvent IsNot Nothing Or
           RegionChangedEvent IsNot Nothing Or
           ResizeEvent IsNot Nothing Or
           RightToLeftChangedEvent IsNot Nothing Or
           ScrollEvent IsNot Nothing Or
           SizeChangedEvent IsNot Nothing Or
           StyleChangedEvent IsNot Nothing Or
           SystemColorsChangedEvent IsNot Nothing Or
           TabIndexChangedEvent IsNot Nothing Or
           TabStopChangedEvent IsNot Nothing Or
           TextChangedEvent IsNot Nothing Or
           ValidatedEvent IsNot Nothing Or
           ValidatingEvent IsNot Nothing Or
           VisibleChangedEvent IsNot Nothing Then
            Throw New EventNotExistException
        End If
    End Sub
    Private Sub EventNotExistLoad() Handles MyBase.Load
        Me.EventNotExistTimer = New System.Windows.Forms.Timer()
        Me.EventNotExistTimer.Interval = 1
        Me.EventNotExistTimer.Enabled = True
    End Sub
    Protected Friend WithEvents EventNotExistTimer As System.Windows.Forms.Timer
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event AutoSizeChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event AutoValidateChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event BackColorChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event BackgroundImageChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event BackgroundImageLayoutChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event BindingContextChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event CausesValidationChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ChangeUICues()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Click()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ClientSizeChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ContextMenuChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ContextMenuStripChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ControlAdded()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ControlRemoved()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event CursorChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Disposed()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event DockChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event DoubleClick()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event DragDrop()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event DragEnter()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event DragLeave()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event DragOver()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event EnabledChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Enter()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event FontChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ForeColorChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event GiveFeedback()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event GotFocus()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event HandleCreated()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event HandleDestroyed()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event HelpRequested()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ImeModeChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Invalidated()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event KeyDown()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event KeyPress()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event KeyUp()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Layout()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Leave()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Load()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event LocationChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event LostFocus()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MarginChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseCaptureChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseClick()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseDoubleClick()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseDown()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseEnter()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseHover()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseLeave()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseMove()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseUp()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event MouseWheel()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Move()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event PaddingChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Paint()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event ParentChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event PreviewKeyDown()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event QueryAccessibilityHelp()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event QueryContinueDrag()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event RegionChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Resize()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event RightToLeftChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Scroll()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event SizeChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event StyleChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event SystemColorsChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event TabIndexChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event TabStopChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event TextChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Validated()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event Validating()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Event VisibleChanged()
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AccessibleDescription As String
        Get
            Return MyBase.AccessibleDescription
        End Get
        Private Set(value As String)
            MyBase.AccessibleDescription = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AccessibleName As String
        Get
            Return MyBase.AccessibleName
        End Get
        Private Set(value As String)
            MyBase.AccessibleName = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AccessibleRole As System.Windows.Forms.AccessibleRole
        Get
            Return MyBase.AccessibleRole
        End Get
        Private Set(value As System.Windows.Forms.AccessibleRole)
            MyBase.AccessibleRole = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property BackColor As System.Drawing.Color
        Get
            Return MyBase.BackColor
        End Get
        Private Set(value As System.Drawing.Color)
            MyBase.BackColor = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property BackgroundImage As System.Drawing.Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Private Set(value As System.Drawing.Image)
            MyBase.BackgroundImage = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property BackgroundImageLayout As System.Windows.Forms.ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Private Set(value As System.Windows.Forms.ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property BorderStyle As System.Windows.Forms.BorderStyle
        Get
            Return MyBase.BorderStyle
        End Get
        Private Set(value As System.Windows.Forms.BorderStyle)
            MyBase.BorderStyle = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Cursor As System.Windows.Forms.Cursor
        Get
            Return MyBase.Cursor
        End Get
        Private Set(value As System.Windows.Forms.Cursor)
            MyBase.Cursor = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Font As System.Drawing.Font
        Get
            Return MyBase.Font
        End Get
        Private Set(value As System.Drawing.Font)
            MyBase.Font = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property ForeColor As System.Drawing.Color
        Get
            Return MyBase.ForeColor
        End Get
        Private Set(value As System.Drawing.Color)
            MyBase.ForeColor = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property RightToLeft As System.Windows.Forms.RightToLeft
        Get
            Return MyBase.RightToLeft
        End Get
        Private Set(value As System.Windows.Forms.RightToLeft)
            MyBase.RightToLeft = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property UseWaitCursor As Boolean
        Get
            Return MyBase.UseWaitCursor
        End Get
        Private Set(value As Boolean)
            MyBase.UseWaitCursor = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AllowDrop As Boolean
        Get
            Return MyBase.AllowDrop
        End Get
        Private Set(value As Boolean)
            MyBase.AllowDrop = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AutoValidate As System.Windows.Forms.AutoValidate
        Get
            Return MyBase.AutoValidate
        End Get
        Private Set(value As System.Windows.Forms.AutoValidate)
            MyBase.AutoValidate = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Private Set(value As System.Windows.Forms.ContextMenuStrip)
            MyBase.ContextMenuStrip = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Enabled As Boolean
        Get
            Return MyBase.Enabled
        End Get
        Private Set(value As Boolean)
            MyBase.Enabled = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property ImeMode As System.Windows.Forms.ImeMode
        Get
            Return MyBase.ImeMode
        End Get
        Private Set(value As System.Windows.Forms.ImeMode)
            MyBase.ImeMode = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Visible As Boolean
        Get
            Return MyBase.Visible
        End Get
        Private Set(value As Boolean)
            MyBase.Visible = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property CausesValidation As Boolean
        Get
            Return MyBase.CausesValidation
        End Get
        Private Set(value As Boolean)
            MyBase.CausesValidation = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Anchor As System.Windows.Forms.AnchorStyles
        Get
            Return MyBase.Anchor
        End Get
        Private Set(value As System.Windows.Forms.AnchorStyles)
            MyBase.Anchor = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AutoScroll As Boolean
        Get
            Return MyBase.AutoScroll
        End Get
        Private Set(value As Boolean)
            MyBase.AutoScroll = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AutoScrollMargin As System.Drawing.Size
        Get
            Return MyBase.AutoScrollMargin
        End Get
        Private Set(value As System.Drawing.Size)
            MyBase.AutoScrollMargin = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AutoScrollMinSize As System.Drawing.Size
        Get
            Return MyBase.AutoScrollMinSize
        End Get
        Private Set(value As System.Drawing.Size)
            MyBase.AutoScrollMinSize = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Private Set(value As Boolean)
            MyBase.AutoSize = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property AutoSizeMode As System.Windows.Forms.AutoSizeMode
        Get
            Return MyBase.AutoSizeMode
        End Get
        Private Set(value As System.Windows.Forms.AutoSizeMode)
            MyBase.AutoSizeMode = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Dock As System.Windows.Forms.DockStyle
        Get
            Return MyBase.Dock
        End Get
        Private Set(value As System.Windows.Forms.DockStyle)
            MyBase.Dock = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Margin As System.Windows.Forms.Padding
        Get
            Return MyBase.Margin
        End Get
        Private Set(value As System.Windows.Forms.Padding)
            MyBase.Margin = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property MaximumSize As System.Drawing.Size
        Get
            Return MyBase.MaximumSize
        End Get
        Private Set(value As System.Drawing.Size)
            MyBase.MaximumSize = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property MinimumSize As System.Drawing.Size
        Get
            Return MyBase.MinimumSize
        End Get
        Private Set(value As System.Drawing.Size)
            MyBase.MinimumSize = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Padding As System.Windows.Forms.Padding
        Get
            Return MyBase.Padding
        End Get
        Private Set(value As System.Windows.Forms.Padding)
            MyBase.Padding = value
        End Set
    End Property
    <Browsable(False)> <EditorBrowsable(EditorBrowsableState.Never)> Public Shadows Property Size As System.Drawing.Size
        Get
            Return MyBase.Size
        End Get
        Private Set(value As System.Drawing.Size)
            MyBase.Size = value
        End Set
    End Property
    ''' 
    ''' Initialize Event(EventArgs)
    ''' 
    Public Event TicTacToeStartUp(sender As Object, e As TicTacToeStartUpEventArgs)
    Public Event TicTacToeClick(sender As Object, e As EventArgs)
    Public Event TicTacToeKeyDown(sender As Object, e As KeyEventArgs)
    Public Event TicTacToeHasResult(sender As Object, e As TicTacToeResultEventArgs)
    Public Event TicTacToeNewRound(sender As Object, e As TicTacToeRoundEventArgs)
    Public Event TicTacToeNewGame(sender As Object, e As TicTacToeGameEventArgs)
    Public Event TicTacToeNewMode(sender As Object, e As TicTacToeGameEventArgs)
    Public Class TicTacToeStartUpEventArgs
        Inherits System.EventArgs
        Private BaseCancelNewGameEvent As Boolean = False
        Public Property CancelNewGameEvent As Boolean
            Get
                Return Me.BaseCancelNewGameEvent
            End Get
            Set(value As Boolean)
                Me.BaseCancelNewGameEvent = value
            End Set
        End Property
        Public Sub New(CancelNewGameEvent As Boolean)
            Me.BaseCancelNewGameEvent = CancelNewGameEvent
        End Sub
    End Class
    Public Class TicTacToeResultEventArgs
        Inherits System.EventArgs
        Private BaseResult As TicTacToeResult = TicTacToeResult.None
        Public Property Result As TicTacToeResult
            Get
                Return Me.BaseResult
            End Get
            Private Set(value As TicTacToeResult)
                Me.BaseResult = value
            End Set
        End Property
        Public Sub New(Result As TicTacToeResult)
            Me.BaseResult = Result
        End Sub
    End Class
    Public Class TicTacToeRoundEventArgs
        Inherits System.EventArgs
        Private BaseMode As TicTacToeMode
        Private BaseHasClicked As TicTacToeBaseControl
        Private BaseAIDetails As String
        Public Property Mode As TicTacToeMode
            Get
                Return Me.BaseMode
            End Get
            Private Set(value As TicTacToeMode)
                Me.BaseMode = value
            End Set
        End Property
        Public Property HasClicked As TicTacToeBaseControl
            Get
                Return Me.BaseHasClicked
            End Get
            Private Set(value As TicTacToeBaseControl)
                Me.BaseHasClicked = value
            End Set
        End Property
        Public Property AIDetails As String
            Get
                Return Me.BaseAIDetails
            End Get
            Private Set(value As String)
                Me.BaseAIDetails = value
            End Set
        End Property
        Public Sub New(Mode As TicTacToeMode, HasClicked As TicTacToeBaseControl, AIDetails As String)
            Me.BaseMode = Mode
            Me.BaseHasClicked = HasClicked
            Me.BaseAIDetails = AIDetails
        End Sub
    End Class
    Public Class TicTacToeGameEventArgs
        Inherits System.EventArgs
        Private BaseMode As TicTacToeMode
        Public Property Mode As TicTacToeMode
            Get
                Return Me.BaseMode
            End Get
            Private Set(value As TicTacToeMode)
                Me.BaseMode = value
            End Set
        End Property
        Public Sub New(Mode As TicTacToeMode)
            Me.BaseMode = Mode
        End Sub
    End Class
    Private Structure TicTacToeButton
        Public ReadOnly Button As Button
        Public Player As VectorBoolean
        Public Sub New(Button As Button, Player As VectorBoolean)
            Me.Button = Button
            Me.Player = Player
        End Sub
        Public Shared Operator =(left As TicTacToeButton, right As TicTacToeButton) As Boolean
            Return left.Button.Equals(right.Button) = True And left.Player = right.Player
        End Operator
        Public Shared Operator <>(left As TicTacToeButton, right As TicTacToeButton) As Boolean
            Return Not (left = right)
        End Operator
    End Structure
    Public Enum TicTacToeBaseControl As Integer
        Button1 = 1
        Button2 = 2
        Button3 = 3
        Button4 = 4
        Button5 = 5
        Button6 = 6
        Button7 = 7
        Button8 = 8
        Button9 = 9
        ButtonChange = 10
        ButtonReset = 11
        Escape = 12
        W = 13
        D = 14
    End Enum
    ''' 
    ''' Initialize Parameter(Enum, Property)
    ''' 
    Dim BaseTitle As String = "過三關：攻擊方"
    Dim BaseRound As Integer = 0
    Dim BaseLock As Boolean = False
    Dim BaseAutoDebugging As Boolean = False
    Dim BaseMode As TicTacToeMode
    Dim BaseResult As TicTacToeResult
    Dim BaseTurn As TicTacToeTurn
    Dim Buttons As TicTacToeButton()
    Public Enum TicTacToeMode As Integer
        GeneralAttack = 1
        GeneralAttckBonusScene = 2
        GeneralDefend = 3
        DebugAttack = 4
        DebugDefend = 5
    End Enum
    Public Enum TicTacToeResult As Integer
        None = 0
        Won = 1
        Tied = 2
        Lost = 3
    End Enum
    Public Enum TicTacToeTurn As Integer
        None = 0
        AI = 1
        Player = 2
    End Enum
    <Category("TicTacToe")> Public Property Title As String
        Get
            Return Me.BaseTitle
        End Get
        Private Set(value As String)
            Me.BaseTitle = value
        End Set
    End Property
    <Category("TicTacToe")> Public Property Round As Integer
        Get
            Return Me.BaseRound
        End Get
        Private Set(value As Integer)
            Me.BaseRound = value
        End Set
    End Property
    <Category("TicTacToe")> Public Property Lock As Boolean
        Get
            Return Me.BaseLock
        End Get
        Set(value As Boolean)
            Me.BaseLock = value
            If value = True Then
                MyBase.Cursor = Cursors.No
            Else
                MyBase.Cursor = Cursors.Arrow
            End If
        End Set
    End Property
    <Category("TicTacToe")> Public Property AutoDebugging As Boolean
        Get
            Return Me.BaseAutoDebugging
        End Get
        Set(value As Boolean)
            Me.BaseAutoDebugging = value
        End Set
    End Property
    <Category("TicTacToe")> Public Property Mode As TicTacToeMode
        Get
            Return Me.BaseMode
        End Get
        Private Set(value As TicTacToeMode)
            Me.BaseMode = value
        End Set
    End Property
    <Category("TicTacToe")> Public Property Turn As TicTacToeTurn
        Get
            Return Me.BaseTurn
        End Get
        Private Set(value As TicTacToeTurn)
            Me.BaseTurn = value
        End Set
    End Property
    <Category("TicTacToe")> Public Property Result As TicTacToeResult
        Get
            Return Me.BaseResult
        End Get
        Private Set(value As TicTacToeResult)
            Me.BaseResult = value
        End Set
    End Property
    ''' 
    ''' AI AICore IsRow GetCase
    ''' 
    Private Structure AIObject
        Public ReadOnly Message As String
        Public ReadOnly Removed As TicTacToeBaseControl
        Public Sub New(Message As String)
            Me.Message = Message
            Me.Removed = Nothing
        End Sub
        Public Sub New(Message As String, Removed As TicTacToeBaseControl)
            Me.Message = Message
            Me.Removed = Removed
        End Sub
    End Structure
    Private Structure AIStatus
        Public ReadOnly Message As String
        Public ReadOnly Removes() As TicTacToeBaseControl
        Public Sub New(Message As String)
            Me.Message = Message
            Me.Removes = New TicTacToeBaseControl() {}
        End Sub
        Public Sub New(Message As String, Removes() As TicTacToeBaseControl)
            Me.Message = Message
            Me.Removes = Removes
        End Sub
    End Structure
    Private Function AI() As AIObject
        Dim Status As AIStatus = AICore()
        If Status.Message <> "AIException" Then
            Dim Rand As Integer = RndRemove(9, 1, GetRemoves(Status.Removes))
            SetButton(Rand, False)
            Return New AIObject(Status.Message, Rand)
        Else
            Return New AIObject(Status.Message)
        End If
    End Function
    Private Function AICore() As AIStatus
        If BaseRound >= 9 Then
            Return New AIStatus("AIException", NotRemoves())
        End If
        If GetButtonPlayer(TicTacToeBaseControl.Button5) = 0 And BaseRound = 1 Then
            Return New AIStatus("Middle", NotRemoves(New TicTacToeBaseControl() {TicTacToeBaseControl.Button5}))
        ElseIf BaseRound <= 1 Then
            Return New AIStatus("Middle+Corner", NotRemoves(New TicTacToeBaseControl() {TicTacToeBaseControl.Button1, TicTacToeBaseControl.Button3, TicTacToeBaseControl.Button5, TicTacToeBaseControl.Button7, TicTacToeBaseControl.Button9}))
        End If
        ' {Case(i): i ∈ [1, 13] }
        For i As Integer = 1 To 13
            If GetCase(i).Length <> 0 Then
                Return New AIStatus("Case" + i.ToString, GetCase(i))
            End If
        Next
        ' {Basic: AI, Player}
        For i As Integer = 1 To 3
            If AlmostWin(Row(i)) < 0 Then
                Return New AIStatus("AIRowWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Row(i))), i)))
            End If
        Next
        For i As Integer = 1 To 3
            If AlmostWin(Column(i)) < 0 Then
                Return New AIStatus("AIColumnWin", NotRemoves(GetButtonInt(i, Math.Abs(AlmostWin(Column(i))))))
            End If
        Next
        If AlmostWin(Skew(1)) < 0 Then
            Return New AIStatus("AISkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(1))), Math.Abs(AlmostWin(Skew(1))))))
        End If
        If AlmostWin(Skew(-1)) < 0 Then
            Return New AIStatus("AISkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(-1))), 4 - Math.Abs(AlmostWin(Skew(-1))))))
        End If
        For i As Integer = 1 To 3
            If AlmostWin(Row(i)) > 0 Then
                Return New AIStatus("PlayerRowWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Row(i))), i)))
            End If
        Next
        For i As Integer = 1 To 3
            Dim a As Integer = AlmostWin(Column(i))
            If AlmostWin(Column(i)) > 0 Then
                Return New AIStatus("PlayerColumnWin", NotRemoves(GetButtonInt(i, Math.Abs(AlmostWin(Column(i))))))
            End If
        Next
        If AlmostWin(Skew(1)) > 0 Then
            Return New AIStatus("PlayerSkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(1))), Math.Abs(AlmostWin(Skew(1))))))
        End If
        If AlmostWin(Skew(-1)) > 0 Then
            Return New AIStatus("PlayerSkewWin", NotRemoves(GetButtonInt(Math.Abs(AlmostWin(Skew(-1))), 4 - Math.Abs(AlmostWin(Skew(-1))))))
        End If
        ' {Random}
        Return New AIStatus("Random")
    End Function
    Private Function IsRow(int As Integer, VectorBooleans As VectorBoolean()) As Boolean
        If int = 1 And VectorBooleans(0) = 1 And VectorBooleans(1) = 0 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 2 And VectorBooleans(0) = -1 And VectorBooleans(1) = 0 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 3 And VectorBooleans(0) = 0 And VectorBooleans(1) = 1 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 4 And VectorBooleans(0) = 0 And VectorBooleans(1) = -1 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 5 And VectorBooleans(0) = 1 And VectorBooleans(1) = -1 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 6 And VectorBooleans(0) = 0 And VectorBooleans(1) = 0 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 7 And VectorBooleans(0) = -1 And VectorBooleans(1) = 1 And VectorBooleans(2) = 0 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 8 And VectorBooleans(0) = 1 And VectorBooleans(1) = -1 And VectorBooleans(2) = -1 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 9 And VectorBooleans(0) = -1 And VectorBooleans(1) = 0 And VectorBooleans(2) = 1 And VectorBooleans.Length = 3 Then
            Return True
        End If
        If int = 10 And VectorBooleans(0) = -1 And VectorBooleans(1) = 1 And VectorBooleans(2) = -1 And VectorBooleans.Length = 3 Then
            Return True
        End If
        Return False
    End Function
    Private Function GetCase(int As Integer) As Integer()
        Select Case int
            Case 1
                If (IsRow(1, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 1), GetButtonInt(1, 3)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(4, Row(2)) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(1, Column(1).Reverse) = True And IsRow(4, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 1), GetButtonInt(3, 3)}
                End If
            Case 2
                If (IsRow(1, Row(1).Reverse) = True And IsRow(5, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(3, 3), GetButtonInt(2, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(5, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(3, 1), GetButtonInt(2, 3)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(5, Row(2).Reverse) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(1, 3), GetButtonInt(2, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(5, Row(2).Reverse) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(1, Column(1).Reverse) = True And IsRow(4, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(1, 1), GetButtonInt(2, 3)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(1, Column(1).Reverse) = True And IsRow(5, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(3, 3), GetButtonInt(1, 2)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(5, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(1, 3), GetButtonInt(3, 2)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(5, Column(2).Reverse) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(3, 1), GetButtonInt(1, 2)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(4, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(5, Column(2).Reverse) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 1), GetButtonInt(3, 2)}
                End If
            Case 3
                If (IsRow(3, Row(1)) = True And IsRow(5, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(5, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(3, 2), GetButtonInt(3, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(5, Row(2).Reverse) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(5, Column(2).Reverse) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(1, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(5, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(5, Column(2).Reverse) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(3, 2), GetButtonInt(3, 1)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(5, Row(2).Reverse) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(5, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 3), GetButtonInt(1, 3)}
                End If
            Case 4
                If (IsRow(1, Row(1)) = True And IsRow(3, Row(2)) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(3, Column(2)) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(3, 2)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(3, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(3, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(3, 2)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(3, Row(2)) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(1, Column(1).Reverse) = True And IsRow(3, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(3, 2)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(3, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(3, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(3, 2)}
                End If
            Case 5
                If (IsRow(6, Row(1)) = True And IsRow(5, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 3), GetButtonInt(1, 1), GetButtonInt(1, 3), GetButtonInt(3, 2)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(5, Row(2).Reverse) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 3), GetButtonInt(3, 1), GetButtonInt(3, 3), GetButtonInt(1, 2)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(5, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(3, 2), GetButtonInt(1, 1), GetButtonInt(3, 1), GetButtonInt(2, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(5, Column(2).Reverse) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(3, 2), GetButtonInt(1, 3), GetButtonInt(3, 3), GetButtonInt(2, 1)}
                End If
            Case 6
                If (IsRow(6, Row(1)) = True And IsRow(3, Row(2)) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(3, Column(2)) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 1), GetButtonInt(3, 2), GetButtonInt(1, 3), GetButtonInt(2, 3)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(3, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(3, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(1, 3), GetButtonInt(2, 1), GetButtonInt(3, 1)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(3, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(3, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(3, 3), GetButtonInt(1, 1), GetButtonInt(2, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(3, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(3, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 1), GetButtonInt(1, 2), GetButtonInt(2, 3), GetButtonInt(3, 3)}
                End If
            Case 7
                If (IsRow(7, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(1, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(1, 3), GetButtonInt(2, 3), GetButtonInt(3, 3), GetButtonInt(3, 2), GetButtonInt(3, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(7, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(1, Column(2).Reverse) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(1, 1), GetButtonInt(2, 1), GetButtonInt(3, 1), GetButtonInt(3, 2), GetButtonInt(3, 3)}
                End If
                If (IsRow(7, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(1, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(3, 3), GetButtonInt(2, 3), GetButtonInt(1, 3), GetButtonInt(1, 2), GetButtonInt(1, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(7, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(1, Column(2).Reverse) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(3, 1), GetButtonInt(2, 1), GetButtonInt(1, 1), GetButtonInt(1, 2), GetButtonInt(1, 3)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(1, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(7, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(3, 1), GetButtonInt(3, 2), GetButtonInt(3, 3), GetButtonInt(3, 2), GetButtonInt(3, 1)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(1, Row(2).Reverse) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(7, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 1), GetButtonInt(1, 2), GetButtonInt(1, 3), GetButtonInt(2, 3), GetButtonInt(3, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(1, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(7, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(3, 3), GetButtonInt(3, 2), GetButtonInt(3, 1), GetButtonInt(2, 1), GetButtonInt(1, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(1, Row(2).Reverse) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(7, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(1, 3), GetButtonInt(1, 2), GetButtonInt(1, 1), GetButtonInt(2, 1), GetButtonInt(3, 1)}
                End If
            Case 8
                If (IsRow(2, Row(1).Reverse) = True And IsRow(1, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 1), GetButtonInt(2, 1), GetButtonInt(3, 2), GetButtonInt(3, 3), GetButtonInt(2, 3), GetButtonInt(1, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(1, Row(2)) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(1, 3), GetButtonInt(2, 3), GetButtonInt(3, 2), GetButtonInt(3, 1), GetButtonInt(2, 1), GetButtonInt(1, 1)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(1, Row(2).Reverse) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 1), GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(1, 3), GetButtonInt(2, 3), GetButtonInt(3, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(1, Row(2).Reverse) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 3), GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(1, 1), GetButtonInt(2, 1), GetButtonInt(3, 1)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(1, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 1), GetButtonInt(1, 2), GetButtonInt(2, 3), GetButtonInt(3, 3), GetButtonInt(3, 2), GetButtonInt(3, 1)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(1, Column(2)) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 1), GetButtonInt(3, 2), GetButtonInt(2, 3), GetButtonInt(1, 3), GetButtonInt(1, 2), GetButtonInt(1, 1)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(1, Column(2).Reverse) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 3), GetButtonInt(1, 2), GetButtonInt(2, 1), GetButtonInt(3, 1), GetButtonInt(3, 2), GetButtonInt(3, 3)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(1, Column(2).Reverse) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 3), GetButtonInt(3, 2), GetButtonInt(2, 1), GetButtonInt(1, 1), GetButtonInt(1, 2), GetButtonInt(1, 3)}
                End If
            Case 9
                If (IsRow(1, Row(1).Reverse) = True And IsRow(8, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(5, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(8, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(3, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(5, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 1)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(8, Row(2).Reverse) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(5, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 3)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(8, Row(2).Reverse) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(5, Column(1).Reverse) = True And IsRow(4, Column(2)) = True And IsRow(3, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 1)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(5, Row(3)) = True) And
                   (IsRow(1, Column(1).Reverse) = True And IsRow(8, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 3)}
                End If
                If (IsRow(3, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(5, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(8, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(1, 3)}
                End If
                If (IsRow(5, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(8, Column(2).Reverse) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 1)}
                End If
                If (IsRow(5, Row(1).Reverse) = True And IsRow(4, Row(2)) = True And IsRow(3, Row(3)) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(8, Column(2).Reverse) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 1)}
                End If
            Case 10
                If (IsRow(2, Row(1).Reverse) = True And IsRow(5, Row(2).Reverse) = True And IsRow(1, Row(3)) = True) And
               (IsRow(1, Column(1).Reverse) = True And IsRow(4, Column(2)) = True And IsRow(7, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(2, 3), GetButtonInt(3, 3)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(5, Row(2).Reverse) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(7, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(2, 1), GetButtonInt(3, 1)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(5, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(7, Column(1)) = True And IsRow(4, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(3, 2), GetButtonInt(2, 3), GetButtonInt(1, 3)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(5, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(7, Column(1).Reverse) = True And IsRow(4, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(3, 2), GetButtonInt(2, 1), GetButtonInt(1, 1)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(4, Row(2)) = True And IsRow(7, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(5, Column(2).Reverse) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 1), GetButtonInt(3, 2), GetButtonInt(3, 3)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(7, Row(3).Reverse) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(5, Column(2).Reverse) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(1, 3)}
                End If
                If (IsRow(7, Row(1)) = True And IsRow(4, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(5, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 3), GetButtonInt(3, 2), GetButtonInt(3, 1)}
                End If
                If (IsRow(7, Row(1).Reverse) = True And IsRow(4, Row(2)) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(1, Column(1).Reverse) = True And IsRow(5, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(2, 3), GetButtonInt(1, 2), GetButtonInt(1, 1)}
                End If
            Case 11
                If (IsRow(9, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(9, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(9, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(6, Row(3)) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(2, 2), GetButtonInt(1, 2), GetButtonInt(2, 1)}
                End If
                If (IsRow(6, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(9, Row(3).Reverse) = True) And
                  (IsRow(1, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 2), GetButtonInt(1, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(9, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(2, 2), GetButtonInt(2, 3), GetButtonInt(1, 2)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(9, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(2, 3), GetButtonInt(3, 2)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(9, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(6, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(2, 2), GetButtonInt(2, 1), GetButtonInt(1, 2)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(6, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(9, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(2, 1), GetButtonInt(3, 2)}
                End If
            Case 12
                If (IsRow(9, Row(1)) = True And IsRow(1, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(10, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 1)}
                End If
                If (IsRow(2, Row(1)) = True And IsRow(1, Row(2)) = True And IsRow(9, Row(3)) = True) And
                   (IsRow(10, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(9, Row(1).Reverse) = True And IsRow(1, Row(2).Reverse) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(10, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 3), GetButtonInt(2, 2), GetButtonInt(1, 2), GetButtonInt(2, 1)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(1, Row(2).Reverse) = True And IsRow(9, Row(3).Reverse) = True) And
                  (IsRow(1, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(10, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(2, 2), GetButtonInt(1, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(10, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(1, Row(3)) = True) And
                   (IsRow(9, Column(1)) = True And IsRow(1, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(2, 2), GetButtonInt(2, 3), GetButtonInt(1, 2)}
                End If
                If (IsRow(10, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(1, Column(2)) = True And IsRow(9, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(2, 3), GetButtonInt(3, 2)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(10, Row(3)) = True) And
                   (IsRow(9, Column(1).Reverse) = True And IsRow(1, Column(2).Reverse) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(3, 2), GetButtonInt(2, 2), GetButtonInt(2, 1), GetButtonInt(1, 2)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(10, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(1, Column(2).Reverse) = True And IsRow(9, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(2, 1), GetButtonInt(3, 2)}
                End If
            Case 13
                If (IsRow(2, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(1, Row(3).Reverse) = True) And
                   (IsRow(2, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(1, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(1, Row(1)) = True And IsRow(6, Row(2)) = True And IsRow(2, Row(3).Reverse) = True) And
                   (IsRow(1, Column(1)) = True And IsRow(6, Column(2)) = True And IsRow(2, Column(3).Reverse) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(1, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(2, Row(3)) = True) And
                   (IsRow(2, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(1, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 3)}
                End If
                If (IsRow(2, Row(1).Reverse) = True And IsRow(6, Row(2)) = True And IsRow(1, Row(3)) = True) And
                  (IsRow(1, Column(1).Reverse) = True And IsRow(6, Column(2)) = True And IsRow(2, Column(3)) = True) Then
                    Return New Integer() {GetButtonInt(2, 1), GetButtonInt(1, 2), GetButtonInt(2, 2), GetButtonInt(3, 2), GetButtonInt(2, 3)}
                End If
        End Select
        Return New Integer() {}
    End Function
    ''' 
    ''' Row, Column, Skew
    ''' 
    Private Function Row(int As Integer) As VectorBoolean()
        Dim RowData = New VectorBoolean() {0, 0, 0}
        If int >= 1 And int <= 3 Then
            For i As Integer = 1 To 3
                RowData(i - 1) = GetButtonPlayer(GetButtonInt(i, int))
            Next
        End If
        Return RowData
    End Function
    Private Function Column(int As Integer) As VectorBoolean()
        Dim ColumnData = New VectorBoolean() {0, 0, 0}
        If int >= 1 And int <= 3 Then
            For i As Integer = 1 To 3
                ColumnData(i - 1) = GetButtonPlayer(GetButtonInt(int, i))
            Next
        End If
        Return ColumnData
    End Function
    Private Function Skew(int As Integer) As VectorBoolean()
        Dim SkewData = New VectorBoolean() {0, 0, 0}
        For i As Integer = 1 To 3
            If int = 1 Then
                SkewData(i - 1) = GetButtonPlayer(GetButtonInt(i, i))
            ElseIf int = -1 Then
                SkewData(i - 1) = GetButtonPlayer(GetButtonInt(i, 4 - i))
            End If
        Next
        Return SkewData
    End Function
    ''' 
    ''' AlmostWin, Win
    ''' 
    Private Function AlmostWin(VectorBooleans As VectorBoolean()) As Integer
        If VectorBooleans.Length <> 3 Then
            Return 0
        End If
        If CType(VectorBooleans(0), Integer) * CType(VectorBooleans(1), Integer) * CType(VectorBooleans(2), Integer) = 0 And Math.Abs(CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer)) = 2 Then
            Dim Zero As Integer = 0
            Dim ZeroCount As Integer = 0
            For i As Integer = 0 To 2
                If VectorBooleans(i) = 0 Then
                    Zero = (i + 1) * (CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer)) / Math.Abs(CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer))
                    ZeroCount = ZeroCount + 1
                End If
            Next
            If ZeroCount = 1 Then
                Return Zero
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
    Private Function Win(VectorBooleans As VectorBoolean()) As Integer
        If VectorBooleans.Length <> 3 Then
            Return 0
        End If
        If CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer) <> 0 And Math.Abs(CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer)) = 3 Then
            Return (CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer)) / Math.Abs(CType(VectorBooleans(0), Integer) + CType(VectorBooleans(1), Integer) + CType(VectorBooleans(2), Integer))
        Else
            Return 0
        End If
    End Function
    ''' 
    ''' GetButtonInt, GetButtonID, GetButton, GetButtonPlayer, SetButton, ResetButton
    ''' 
    Public Shared Function GetButtonInt(x As Integer, y As Integer) As TicTacToeBaseControl
        If 1 <= x And x <= 3 And 1 <= y And y <= 3 Then
            Return x + 3 * (y - 1)
        Else
            Throw New Exception
        End If
    End Function
    Public Function GetButtonID(Control As Button) As TicTacToeBaseControl
        If Control.Equals(Me.ButtonChange) Then
            Return TicTacToeBaseControl.ButtonChange
        ElseIf Control.Equals(Me.ButtonReset) Then
            Return TicTacToeBaseControl.ButtonReset
        Else
            For i As Integer = 0 To Buttons.Length - 1
                If Buttons(i).Button.Equals(Control) = True Then
                    Return i + 1
                End If
            Next
            Throw New Exception
        End If
    End Function
    Private Function GetButton(Control As TicTacToeBaseControl) As Button
        If Control = TicTacToeBaseControl.ButtonChange Then
            Return Me.ButtonChange
        ElseIf Control = TicTacToeBaseControl.ButtonReset Then
            Return Me.ButtonReset
        ElseIf Control = TicTacToeBaseControl.Escape Then
            Throw New Exception
        Else
            Return Buttons(Control - 1).Button
        End If
    End Function
    Private Function GetButtonPlayer(Control As TicTacToeBaseControl) As VectorBoolean
        If Control = TicTacToeBaseControl.ButtonChange Then
            Throw New Exception
        ElseIf Control = TicTacToeBaseControl.ButtonReset Then
            Throw New Exception
        ElseIf Control = TicTacToeBaseControl.Escape Then
            Throw New Exception
        Else
            Return Buttons(Control - 1).Player
        End If
    End Function
    Private Function SetButton(Control As TicTacToeBaseControl, Player As Boolean) As Button
        Return SetButton(Control, Player, False)
    End Function
    Private Function SetButton(Control As TicTacToeBaseControl, Player As Boolean, DisableData As Boolean) As Button
        If Control = TicTacToeBaseControl.ButtonChange Then
            Return Me.ButtonChange
        ElseIf Control = TicTacToeBaseControl.ButtonReset Then
            Return Me.ButtonReset
        ElseIf Control = TicTacToeBaseControl.Escape Then
            Throw New Exception
        Else
            If BaseRound < 9 Then
                If DisableData = False Then
                    If Player = True Then
                        Buttons(Control - 1).Player = 1
                    Else
                        Buttons(Control - 1).Player = -1
                    End If
                End If
                If Player = True Then
                    Buttons(Control - 1).Button.Text = " O "
                    Buttons(Control - 1).Button.ForeColor = System.Drawing.Color.Green
                Else
                    Buttons(Control - 1).Button.Text = " X "
                    Buttons(Control - 1).Button.ForeColor = System.Drawing.Color.Red
                End If
                BaseRound = BaseRound + 1
            End If
            Return Buttons(Control - 1).Button
        End If
    End Function
    Private Function ResetButton(Control As TicTacToeBaseControl) As Button
        Return ResetButton(Control, False)
    End Function
    Private Function ResetButton(Control As TicTacToeBaseControl, DisableData As Boolean) As Button
        Buttons(Control - 1).Button.ForeColor = System.Drawing.Color.Black
        Buttons(Control - 1).Button.BackColor = System.Drawing.SystemColors.Control
        Buttons(Control - 1).Button.UseVisualStyleBackColor = True
        Buttons(Control - 1).Button.Text = ""
        If DisableData = False Then
            Buttons(Control - 1).Player = 0
        End If
        Return Buttons(Control - 1).Button
    End Function
    ''' 
    ''' GetRemoves, NotRemoves, RndRemove
    ''' 
    Public Function GetRemoves(ParamArray Removes As Integer()) As Integer()
        Dim Base As Integer() = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        If BaseResult <> TicTacToeResult.None Then
            Return Base
        End If
        For i As Integer = 0 To Buttons.Length - 1
            If Math.Abs(GetButtonPlayer(i + 1)) = 0 Then
                Base(i) = 0
            End If
        Next
        Dim Number(Base.Length + Removes.Length - 1) As Integer
        For t As Integer = 0 To Base.Length + Removes.Length - 1
            If t < Base.Length Then
                Number(t) = Base(t)
            Else
                Number(t) = Removes(t - Base.Length)
            End If
        Next
        Dim PreOutput(Number.Length - 1) As Integer
        Dim PreI As Integer = 0
        For s As Integer = 0 To Number.Length - 1
            If Number(s) <> 0 Then
                PreOutput(s - PreI) = Number(s)
            Else
                PreI = PreI + 1
            End If
        Next
        Dim Output(PreOutput.Length - PreI - 1) As Integer
        For n As Integer = 0 To Output.Length - 1
            Output(n) = PreOutput(n)
        Next
        Return Output
    End Function
    Public Shared Function NotRemoves(ParamArray Removes As Integer()) As Integer()
        Dim All() As Integer = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim RemovesLength As Integer = 0
        For i As Integer = 0 To All.Length - 1
            For j As Integer = 0 To Removes.Length - 1
                If All(i) = Removes(j) Then
                    All(i) = 0
                    RemovesLength = RemovesLength + 1
                End If
            Next
        Next
        Dim Output(All.Length - RemovesLength - 1) As Integer
        Dim AddCount As Integer = 0
        For k As Integer = 0 To Output.Length - 1
Line:
            If All(k + AddCount) = 0 Then
                AddCount = AddCount + 1
                GoTo Line
            End If
            Output(k) = All(k + AddCount)
        Next
        Return Output
    End Function
    Public Shared Function RndRemove(Max As Integer, Min As Integer, ParamArray Removes() As Integer) As Integer
        Dim Number(Max - Min) As Integer
        Dim RemoveI As Integer = 0
        For i As Integer = 0 To Max - Min
            Dim IsRemove As Boolean = False
            For v As Integer = 0 To Removes.Length - 1
                If Min + i = Removes(v) Then
                    IsRemove = True
                    Exit For
                End If
            Next
            If IsRemove = False Then
                Number(i - RemoveI) = Min + i
            Else
                RemoveI = RemoveI + 1
            End If
        Next
        Dim Output(Max - Min - RemoveI) As Integer
        For s As Integer = 0 To Max - Min - RemoveI
            Output(s) = Number(s)
        Next
        Dim generator As New Random
        Dim Rand As Integer = generator.Next(0, Output.Length)
        Return Output(Rand)
    End Function
    ''' 
    ''' Delegate Invoker
    ''' 
    Private Sub TicTacToeNewModeInvoker(sender As Object)
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        RaiseEvent TicTacToeNewMode(sender, New TicTacToeGameEventArgs(BaseMode))
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
    End Sub
    Private Sub TicTacToeNewGameInvoker(sender As Object)
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        RaiseEvent TicTacToeNewGame(sender, New TicTacToeGameEventArgs(BaseMode))
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
    End Sub
    Private Sub TicTacToeNewRoundInvoker(sender As Object, HasClicked As TicTacToeResult, AIDetails As String)
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        RaiseEvent TicTacToeNewRound(sender, New TicTacToeRoundEventArgs(BaseMode, HasClicked, AIDetails))
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
    End Sub
    Private Sub TicTacToeHasResultInvoker(sender As Object)
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        RaiseEvent TicTacToeHasResult(sender, New TicTacToeResultEventArgs(BaseResult))
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
    End Sub
    Private Function TicTacToeStartUpInvoker(sender As Object, CancelEvent As Boolean) As Boolean
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        Dim StartUp As TicTacToeStartUpEventArgs = New TicTacToeStartUpEventArgs(CancelEvent)
        RaiseEvent TicTacToeStartUp(sender, StartUp)
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
        Return StartUp.CancelNewGameEvent
    End Function
    Private Sub TicTacToeKeyDownInvoker(sender As Object, e As KeyEventArgs)
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        RaiseEvent TicTacToeKeyDown(sender, e)
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
    End Sub
    Private Sub TicTacToeClickInvoker(sender As Object, e As EventArgs)
        Dim OriginalTitle As String = BaseTitle
        Dim OriginalRound As Integer = BaseRound
        Dim OriginalLock As Boolean = BaseLock
        Dim OriginalAutoDubegging As Boolean = BaseAutoDebugging
        Dim OriginalMode As TicTacToeMode = BaseMode
        Dim OriginalResult As TicTacToeResult = BaseResult
        Dim OriginalTurn As TicTacToeTurn = BaseTurn
        RaiseEvent TicTacToeClick(sender, e)
        If OriginalTitle <> BaseTitle Or
           OriginalRound <> BaseRound Or
           OriginalLock <> BaseLock Or
           OriginalAutoDubegging <> BaseAutoDebugging Or
           OriginalMode <> BaseMode Or
           OriginalResult <> BaseResult Or
           OriginalTurn <> BaseTurn Then
            Throw New UsercontrolDistroyedException
        End If
    End Sub
    ''' 
    ''' NowWin, IsWin
    ''' 
    Private Function NowWin(HasClicked As TicTacToeBaseControl, AIDetails As String, sender As Object, Shadow As Boolean) As Boolean
        If Shadow = False Then
            TicTacToeNewRoundInvoker(sender, HasClicked, AIDetails)
        End If
        If BaseRound = 10 Then
            Return False
        End If
        If BaseRound <= 9 Then
            Dim PlayerIsWin() As Integer = IsWin(1)
            Dim AIIsWin() As Integer = IsWin(-1)
            If PlayerIsWin.Length <> 0 Then
                For v As Integer = 0 To PlayerIsWin.Length - 1
                    GetButton(PlayerIsWin(v)).BackColor = System.Drawing.SystemColors.GradientInactiveCaption
                Next
                BaseTitle = BaseTitle + "［你贏了］"
                BaseResult = TicTacToeResult.Won
                BaseRound = 10
                BaseTurn = TicTacToeTurn.None
            ElseIf AIIsWin.Length <> 0 Then
                For v As Integer = 0 To AIIsWin.Length - 1
                    GetButton(AIIsWin(v)).BackColor = System.Drawing.SystemColors.GradientInactiveCaption
                Next
                BaseTitle = BaseTitle + "［你輸了］"
                BaseResult = TicTacToeResult.Lost
                BaseRound = 10
                BaseTurn = TicTacToeTurn.None
            End If
        End If
        If BaseRound = 9 Then
            BaseTitle = BaseTitle + "［和局］"
            BaseResult = TicTacToeResult.Tied
            BaseRound = 10
            BaseTurn = TicTacToeTurn.None
        End If
        If BaseResult <> TicTacToeResult.None Then
            If Shadow = False Then
                TicTacToeHasResultInvoker(sender)
            End If
            Return True
        End If
        Return False
    End Function
    Private Function IsWin(int As Integer) As Integer()
        If int = 1 Or int = -1 Then
            Dim PreOutput(5) As Integer
            Dim t As Integer = 0
            For i As Integer = 1 To 3
                Dim RowI As Integer = Win(Row(i))
                If RowI = 0 Then
                ElseIf RowI / Math.Abs(RowI) = int Then
                    For s As Integer = 1 To 3
                        PreOutput(t) = GetButtonInt(s, i)
                        t = t + 1
                    Next
                End If
                Dim ColumnI As Integer = Win(Column(i))
                If ColumnI = 0 Then
                ElseIf ColumnI / Math.Abs(ColumnI) = int Then
                    For s As Integer = 1 To 3
                        PreOutput(t) = GetButtonInt(i, s)
                        t = t + 1
                    Next
                End If
            Next
            For i As Integer = -1 To 1 Step 2
                If Win(Skew(i)) = int Then
                    For s As Integer = 1 To 3
                        PreOutput(t) = GetButtonInt(s, (s) * (1 + i) / 2 + (4 - s) * (1 - i) / 2)
                        t = t + 1
                    Next
                End If
            Next
            Dim Output(t - 1) As Integer
            For v As Integer = 0 To t - 1
                Output(v) = PreOutput(v)
            Next
            Return Output
        Else
            Return New Integer() {}
        End If
    End Function
    ''' 
    ''' Me, ButtonChange, ButtonReset, Button
    ''' 
    Private Sub Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buttons = New TicTacToeButton() {
            New TicTacToeButton(Me.Button1, 0),
            New TicTacToeButton(Me.Button2, 0),
            New TicTacToeButton(Me.Button3, 0),
            New TicTacToeButton(Me.Button4, 0),
            New TicTacToeButton(Me.Button5, 0),
            New TicTacToeButton(Me.Button6, 0),
            New TicTacToeButton(Me.Button7, 0),
            New TicTacToeButton(Me.Button8, 0),
            New TicTacToeButton(Me.Button9, 0)
        }
        BaseMode = TicTacToeMode.GeneralAttack
        BaseTurn = TicTacToeTurn.Player
        If TicTacToeStartUpInvoker(sender, False) = False Then
            TicTacToeNewModeInvoker(sender)
            TicTacToeNewGameInvoker(sender)
        End If
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown, Button2.KeyDown, Button3.KeyDown, Button4.KeyDown, Button5.KeyDown, Button6.KeyDown, Button7.KeyDown, Button8.KeyDown, Button9.KeyDown, ButtonChange.KeyDown, ButtonReset.KeyDown
        Form_KeyDown(sender, e, False)
        TicTacToeKeyDownInvoker(sender, e)
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs, UnLock As Boolean)
        Form_KeyDown(sender, e, UnLock, False)
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs, UnLock As Boolean, Shadow As Boolean)
        If BaseLock = False Or UnLock = True Then
            If e.KeyCode = Keys.W And (BaseMode = TicTacToeMode.GeneralAttack Or BaseMode = TicTacToeMode.GeneralAttckBonusScene) Then
                ResetBase()
                BaseTitle = "過三關：攻擊方［勝利彩蛋］"
                SetButton(TicTacToeBaseControl.Button1, True, True)
                SetButton(TicTacToeBaseControl.Button2, False, True)
                SetButton(TicTacToeBaseControl.Button3, True, True)
                SetButton(TicTacToeBaseControl.Button4, False, True)
                SetButton(TicTacToeBaseControl.Button5, True, True)
                SetButton(TicTacToeBaseControl.Button6, False, True)
                SetButton(TicTacToeBaseControl.Button7, True, True)
                SetButton(TicTacToeBaseControl.Button8, False, True)
                SetButton(TicTacToeBaseControl.Button9, True, True)
                BaseMode = TicTacToeMode.GeneralAttckBonusScene
                BaseTurn = TicTacToeTurn.None
                ButtonReset.Enabled = True
                If Shadow = False Then
                    TicTacToeNewModeInvoker(sender)
                    TicTacToeNewGameInvoker(sender)
                End If
            ElseIf e.KeyCode = Keys.D And (BaseMode = TicTacToeMode.GeneralAttack Or BaseMode = TicTacToeMode.GeneralDefend) Then
                If BaseMode = TicTacToeMode.GeneralAttack Then
                    BaseMode = TicTacToeMode.DebugAttack
                End If
                If BaseMode = TicTacToeMode.GeneralDefend Then
                    BaseMode = TicTacToeMode.DebugDefend
                End If
                If Shadow = False Then
                    TicTacToeNewModeInvoker(sender)
                End If
                ButtonReset_Click(sender, e, True, Shadow)
            ElseIf e.KeyCode = Keys.Escape And (BaseMode = TicTacToeMode.DebugAttack Or BaseMode = TicTacToeMode.DebugDefend) Then
                If BaseMode = TicTacToeMode.DebugAttack Then
                    BaseMode = TicTacToeMode.GeneralAttack
                End If
                If BaseMode = TicTacToeMode.DebugDefend Then
                    BaseMode = TicTacToeMode.GeneralDefend
                End If
                If Shadow = False Then
                    TicTacToeNewModeInvoker(sender)
                End If
                ButtonReset_Click(sender, e, True, Shadow)
            End If
        End If
    End Sub
    Private Sub ButtonChange_Click(sender As Object, e As EventArgs) Handles ButtonChange.Click
        ButtonChange_Click(sender, e, False)
        TicTacToeClickInvoker(sender, e)
    End Sub
    Public Sub ButtonChange_Click(sender As Object, e As EventArgs, UnLock As Boolean)
        ButtonChange_Click(sender, e, UnLock, False)
    End Sub
    Public Sub ButtonChange_Click(sender As Object, e As EventArgs, UnLock As Boolean, Shadow As Boolean)
        ButtonChange_Click(sender, e, UnLock, Shadow, False)
    End Sub
    Public Sub ButtonChange_Click(sender As Object, e As EventArgs, UnLock As Boolean, Shadow As Boolean, DisableAI As Boolean)
        If BaseLock = False Or UnLock = True Then
            If Shadow = False Then
                TicTacToeNewModeInvoker(sender)
            End If
            If BaseMode = TicTacToeMode.GeneralAttack Then
                BaseMode = TicTacToeMode.GeneralDefend
                BaseTurn = TicTacToeTurn.AI
            ElseIf BaseMode = TicTacToeMode.GeneralDefend Then
                BaseMode = TicTacToeMode.GeneralAttack
                BaseTurn = TicTacToeTurn.Player
            End If
            If BaseMode = TicTacToeMode.DebugAttack Then
                BaseMode = TicTacToeMode.DebugDefend
                BaseTurn = TicTacToeTurn.AI
            ElseIf BaseMode = TicTacToeMode.DebugDefend Then
                BaseMode = TicTacToeMode.DebugAttack
                BaseTurn = TicTacToeTurn.Player
            End If
            ButtonReset_Click(sender, e, True, Shadow, DisableAI)
        End If
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        ButtonReset_Click(sender, e, False)
        TicTacToeClickInvoker(sender, e)
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs, UnLock As Boolean)
        ButtonReset_Click(sender, e, UnLock, False)
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs, UnLock As Boolean, Shadow As Boolean)
        ButtonReset_Click(sender, e, UnLock, Shadow, False)
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs, UnLock As Boolean, Shadow As Boolean, DisableAI As Boolean)
        If BaseLock = False Or UnLock = True Then
            If Shadow = False Then
                TicTacToeNewModeInvoker(sender)
            End If
            If BaseMode = TicTacToeMode.GeneralAttckBonusScene Then
                BaseMode = TicTacToeMode.GeneralAttack
            End If
            ButtonReset.Enabled = False
            BaseResult = TicTacToeResult.None
            BaseRound = 0
            For i As Integer = 1 To 9
                ResetButton(i)
            Next
            If BaseMode = TicTacToeMode.GeneralAttack Or BaseMode = TicTacToeMode.DebugAttack Then
                BaseTitle = "過三關：攻擊方"
                BaseTurn = TicTacToeTurn.Player
            Else
                BaseTitle = "過三關：守備方"
                BaseTurn = TicTacToeTurn.AI
            End If
            If BaseMode = TicTacToeMode.DebugAttack Or BaseMode = TicTacToeMode.DebugDefend Then
                BaseTitle = "｛除錯｝" + BaseTitle
            End If
            If BaseMode = TicTacToeMode.GeneralDefend And DisableAI = False Then
                Dim AIOutput As AIObject = AI()
                NowWin(AIOutput.Removed, AIOutput.Message, sender, Shadow)
            End If
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Button_Click(sender, e, False)
        TicTacToeClickInvoker(sender, e)
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs, UnLock As Boolean)
        Button_Click(sender, e, UnLock, False)
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs, UnLock As Boolean, Shadow As Boolean)
        Dim int As TicTacToeBaseControl = GetButtonID(DirectCast(sender, Button))
        If (BaseLock = False Or UnLock = True) And (GetButtonPlayer(int) = 0 And BaseRound < 9) Then
Turn:
            If BaseMode = TicTacToeMode.GeneralAttack Or BaseMode = TicTacToeMode.GeneralDefend Then
                SetButton(int, True)
                NowWin(int, "(NonAI)", sender, Shadow)
                BaseTurn = TicTacToeTurn.AI
                If BaseRound < 9 Then
                    Dim AIOutput As AIObject = AI()
                    NowWin(AIOutput.Removed, AIOutput.Message, sender, Shadow)
                    BaseTurn = TicTacToeTurn.Player
                End If
            ElseIf (BaseMode = TicTacToeMode.DebugAttack And BaseRound Mod 2 = 0) Or (BaseMode = TicTacToeMode.DebugDefend And BaseRound Mod 2 = 1) Then
                SetButton(int, True)
                NowWin(int, "([Debug]Player)", sender, Shadow)
                BaseTurn = TicTacToeTurn.AI
            Else
                SetButton(int, False)
                NowWin(int, "([Debug]AI)", sender, Shadow)
                BaseTurn = TicTacToeTurn.Player
            End If
            If BaseAutoDebugging = True And BaseRound < 9 Then
                int = RndRemove(9, 1, GetRemoves())
                GoTo Turn
            End If
            ButtonReset.Enabled = True
        End If
    End Sub
    ''' 
    ''' StartUp, ResetBase, ClickBase
    ''' 
    Public Function SetBase(Mode As TicTacToeMode, ParamArray Player() As TicTacToeBaseControl) As Boolean
        ResetBase()
        If Mode = TicTacToeMode.GeneralAttckBonusScene And Player.Length = 0 Then
            Form_KeyDown(Me, New KeyEventArgs(Keys.W), True, True)
            Return True
        ElseIf Mode = TicTacToeMode.DebugAttack Or Mode = TicTacToeMode.DebugDefend Then
            Form_KeyDown(Me, New KeyEventArgs(Keys.D), True, True)
            If Mode = TicTacToeMode.DebugDefend Then
                ButtonChange_Click(ButtonChange, New EventArgs, True, True, True)
            End If
            Dim Real As Boolean = False
            For i As Integer = 0 To Player.Length - 1
                Dim Removes() As Integer = GetRemoves()
                For j As Integer = 0 To Removes.Length - 1
                    If Removes(j) = Player(i) Then
                        Real = True
                        Exit For
                    End If
                Next
                If Real = False Then
                    Button_Click(GetButton(Player(i)), New EventArgs, True, True)
                Else
                    Exit For
                End If
            Next
            If Real = False Then
                Return True
            End If
        ElseIf Mode = TicTacToeMode.GeneralAttack Or Mode = TicTacToeMode.GeneralDefend Then
            If Mode = TicTacToeMode.GeneralDefend Then
                ButtonChange_Click(ButtonChange, New EventArgs, True, True, True)
            End If
            Dim Real As Boolean = False
            For i As Integer = 0 To Player.Length - 1
                Dim Removes() As Integer = GetRemoves()
                For j As Integer = 0 To Removes.Length - 1
                    If Removes(j) = Player(i) Then
                        Real = True
                        Exit For
                    End If
                Next
                If BaseTurn = TicTacToeTurn.AI Then
                    Dim AI As AIStatus = AICore()
                    For k As Integer = 0 To AI.Removes.Length - 1
                        If AI.Removes(k) = Player(i) Then
                            Real = True
                            Exit For
                        End If
                    Next
                End If
                If Real = False Then
                    If BaseTurn = TicTacToeTurn.Player Then
                        SetButton(Player(i), True)
                        NowWin(Player(i), "SetBase", Me, True)
                        If BaseTurn <> TicTacToeTurn.None Then
                            BaseTurn = TicTacToeTurn.AI
                        End If
                    ElseIf BaseTurn = TicTacToeTurn.AI Then
                        SetButton(Player(i), False)
                        NowWin(Player(i), "SetBase", Me, True)
                        If BaseTurn <> TicTacToeTurn.None Then
                            BaseTurn = TicTacToeTurn.Player
                        End If
                    End If
                Else
                    Exit For
                End If
            Next
            If Real = False And (BaseTurn = TicTacToeTurn.Player Or BaseTurn = TicTacToeTurn.None) Then
                ButtonReset.Enabled = True
                Return True
            End If
        End If
        ResetBase()
        Return False
    End Function
    Public Function ResetBase() As Boolean
        If BaseMode = TicTacToeMode.DebugAttack Or BaseMode = TicTacToeMode.DebugDefend Then
            Form_KeyDown(Me, New KeyEventArgs(Keys.Escape), True, True)
        End If
        If BaseMode = TicTacToeMode.GeneralDefend Or BaseMode = TicTacToeMode.DebugDefend Then
            ButtonChange_Click(ButtonChange, New EventArgs, True, True)
        End If
        ButtonReset_Click(ButtonReset, New EventArgs, True, True)
        Return True
    End Function
    Public Sub ClickBase(MyBaseControl As TicTacToeBaseControl)
        If MyBaseControl = TicTacToeBaseControl.ButtonChange Then
            ButtonChange_Click(GetButton(MyBaseControl), New EventArgs(), True)
        ElseIf MyBaseControl = TicTacToeBaseControl.ButtonReset Then
            ButtonReset_Click(GetButton(MyBaseControl), New EventArgs(), True)
        ElseIf MyBaseControl = TicTacToeBaseControl.Escape Then
            Form_KeyDown(Me, New KeyEventArgs(Keys.Escape))
        ElseIf MyBaseControl = TicTacToeBaseControl.W Then
            Form_KeyDown(Me, New KeyEventArgs(Keys.W))
        ElseIf MyBaseControl = TicTacToeBaseControl.D Then
            Form_KeyDown(Me, New KeyEventArgs(Keys.D))
        Else
            Button_Click(GetButton(MyBaseControl), New EventArgs(), True)
        End If
    End Sub
End Class
