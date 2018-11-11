Imports System.Text
Imports Base
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Base
    Private Const cnstDotWorld As String = "w.o.r.l.d."
    <TestMethod()> Public Sub StringBase()
        Dim oStringBase As StringBase = New StringBase()
        Assert.AreEqual(Of String)(cnstDotWorld, oStringBase.GetStringAsCharEnumerator())
        Assert.AreEqual(Of String)(cnstDotWorld, oStringBase.GetStringAsCharForEach())
    End Sub

    <TestMethod()> Public Sub CollectionBase()
        Dim oCollectionBase As MyCollectionsBase = New MyCollectionsBase()
        Dim sWorld As String = String.Empty
        For Each oChar In oCollectionBase.MyWorld
            sWorld += oChar
        Next

        Assert.AreEqual(cnstDotWorld, sWorld)

        oCollectionBase = New MyCollectionsBase("KVN")
        sWorld = String.Empty
        For Each oChar In oCollectionBase.MyWorld
            sWorld += oChar
        Next
        Assert.AreEqual("K.V.N.", sWorld)
    End Sub

End Class