Public Class MyCollectionsBase
    Private ReadOnly oMyWorldCollection As MyWorldCollection
    Public Sub New(Optional ByVal sWorldString As String = "world")
        oMyWorldCollection = New MyWorldCollection(sWorldString)
    End Sub

    ReadOnly Property MyWorld As MyWorldCollection
        Get
            Return oMyWorldCollection
        End Get
    End Property
    Public Class MyWorldCollection
        Implements IEnumerable
        Dim sWorld As String
        Public Sub New(ByVal sWorldString As String)
            sWorld = sWorldString
        End Sub
        Public Iterator Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            For Each oChar As Char In sWorld
                'yield return oChar 
                Yield (oChar + ".")
            Next
        End Function
    End Class
End Class
