Module Module1

    Sub Main()
        Dim objsortList As New System.Collections.SortedList
        Dim i As Int32
        objsortList.Add("one", 11)
        objsortList.Add("two", 22)
        objsortList.Add("three", 33)
        objsortList.Add("four", 44)
        For i = 0 To 3
            Console.WriteLine(objsortList.GetKeyList(i))
        Next
        Console.Read()
    End Sub

End Module
