Friend Structure AsyncCoroutineMethodBuilder

#Region "Fields"

    Private ReadOnly Coroutine As Coroutine

#End Region

#Region "Constructors"

    Public Sub New(Coroutine As Coroutine)
        Me.Coroutine = Coroutine
    End Sub

#End Region

#Region "Properties"

    Public ReadOnly Property Task As Coroutine
        Get
            Return Coroutine
        End Get
    End Property

#End Region

#Region "Methods"

    Public Shared Function Create() As AsyncCoroutineMethodBuilder
        Return New AsyncCoroutineMethodBuilder(New Coroutine(Nothing))
    End Function

    Public Sub Start(Of TStateMachine As IAsyncStateMachine)(ByRef StateMachine As TStateMachine)
        StateMachine.MoveNext()
    End Sub

    <SecurityCritical>
    Public Sub AwaitOnCompleted(Of TAwaiter As INotifyCompletion, TStateMachine As IAsyncStateMachine)(ByRef Awaiter As TAwaiter, ByRef StateMachine As TStateMachine)
        Awaiter.OnCompleted(AddressOf StateMachine.MoveNext)
    End Sub

    <SecuritySafeCritical>
    Public Sub AwaitOnUnsafeCompleted(Of TAwaiter As ICriticalNotifyCompletion, TStateMachine As IAsyncStateMachine)(ByRef Awaiter As TAwaiter, ByRef StateMachine As TStateMachine)
        Awaiter.UnsafeOnCompleted(AddressOf StateMachine.MoveNext)
    End Sub

    Public Sub SetException(Exception As Exception)

    End Sub

    Public Sub SetStateMachine(StateMachine As IAsyncStateMachine)
        StateMachine.SetStateMachine(StateMachine)
    End Sub

#End Region


End Structure