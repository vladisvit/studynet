Public Class StringBase
    Public Function StrinEquality() As Boolean
        Dim name As Object = "kvn"
        Dim values As Char() = {"k", "v", "n"}
        Dim myName As String = New String(values)
        Console.WriteLine("{0}=={1} operator result is {2}", name, myName, name = myName)
        Console.WriteLine("{0}Equals{1} method result is {2}", name, myName, myName.Equals(name))
    End Function

    Public Function GetStringAsCharEnumerator() As String
        Dim sWorld As String = "world"
        'two way
        ' get enumerator
        Dim sWorldResult As String = String.Empty
        Dim oEn As IEnumerator = sWorld.GetEnumerator()
        While oEn.MoveNext()
            Dim oChar As Char = CType(oEn.Current, Char)
            sWorldResult += oChar + "."
        End While

        Return sWorldResult
    End Function

    Public Function GetStringAsCharForEach() As String
        Dim sWorld As String = "world"
        'two way
        ' get enumerator
        Dim sWorldResult As String = String.Empty

        For Each oChar As Char In sWorld
            sWorldResult += oChar + "."
        Next

        Return sWorldResult
    End Function

End Class

