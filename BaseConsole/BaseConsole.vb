Imports Base

Module BaseConsole
    Sub Main()
        Dim oStringBase As StringBase = New StringBase()
        Console.WriteLine(oStringBase.GetStringAsCharEnumerator())
        Console.WriteLine(oStringBase.GetStringAsCharEnumerator())
        For Each oChar In New MyCollectionsBase().MyWorld
            Console.WriteLine(oChar)
        Next
        Console.WriteLine()
        For Each oChar In New MyCollectionsBase("VLADIMIR").MyWorld
            Console.WriteLine(oChar)
        Next
        oStringBase.StrinEquality()
        Console.Read()
    End Sub

End Module
