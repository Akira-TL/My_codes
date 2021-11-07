Module Module1

    Sub Main()
        Dim nowtime As Date
        Dim line As String
        Console.Write(vbCrLf + "What is your name?")
        Dim name = "TL"
        Console.ReadKey(False)
        Console.Clear()
        nowtime = DateTime.Now

        Console.WriteLine("Hello, {0},on {1:y-M-d} at {2:H:m:s}now!", name, nowtime.Date, nowtime)  '用占位符取代内插
        Console.WriteLine("Enter one or more lines of text(press CTRL+Z to exit):")
        Console.WriteLine()
        line = " "
        Do While (line <> "") '判断控制台输入Ctrl+Z,Writeline方法返回“Null”
            Console.Write("  ")
            line = Console.ReadLine()
            If (line <> "") Then
                Console.WriteLine("  " + line)
            End If
        Loop
    End Sub

End Module