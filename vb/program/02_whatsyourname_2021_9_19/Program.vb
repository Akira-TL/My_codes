Imports System

Module Module1
    Dim nowtime As Date
    Dim line As String
    Dim noweek
    Dim name
    Dim now
    Dim y
    Dim m
    Dim d
    Sub Main()
        Console.Write(vbCrLf + "What is your name? " + vbCrLf)
        name = Console.ReadLine()
        'Console.ReadKey(False)
        Console.Clear()
        nowtime = DateTime.Now
        'noweek = Weekday(Now)
        'Select Case noweek
        'Case 2 : noweek = "Monday"
        'Case 3 : noweek = "Tuesday"
        'Case 4 : noweek = "Wendy"
        'Case 5 : noweek = "Thursday"
        'Case 6 : noweek = "Friday"
        'Case 7 : noweek = "Sunday"
        'Case 1 : noweek = "Saturday"
        'End Select
        y = Year(nowtime)
        m = Month(nowtime)
        d = Day(nowtime)
        'Console.WriteLine($"Hello, {name},on {nowtime:d} at {nowtime:T}!") '字符串内插
        Console.WriteLine("Hello, {0},today is {1} at {2:HH:mm} now!", name, y & "年" & m & "月" & d & "日", nowtime)
        Console.WriteLine("Enter one or more lines of number (press CTRL+Z to exit):")
        'now = Format(nowtime, "m月d日")
        Console.WriteLine()
        line = " "
        'Do While (line <> "") '判断控制台输入Ctrl+Z，WriteLine方法返回“Null”
        '    Console.Write(" ")
        '    line = Console.ReadLine()
        '    If (line <> "") Then
        '        Console.WriteLine(" " + line)
        '    End If
        'Loop
        Do While (line <> "") '判断控制台输入Ctrl+Z，WriteLine方法返回“Null”
            Console.Write(" ")
            line = Console.ReadLine()
            If line = "" Then
                End
            End If
            If (line < 100) Then
                Console.WriteLine("Less than 100")
            End If
            If (line > 100) Then
                Console.WriteLine("More than 100")
            End If
            If (line = 100) Then
                Console.WriteLine("Equal to 100")

            End If
        Loop
    End Sub
End Module