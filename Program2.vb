﻿Imports System

Module Program
    Sub Main(args As String())

        '//TODO: Генерируем код
        Dim ver As String
        Dim namber As String = "1234"
        Dim cow As Integer = 0
        Dim bull As Integer = 0
        Dim Rgh As Integer

        Console.WriteLine("Привет, попробуй угадать загаданное число!(Введи число)")

        Do
            Console.WriteLine("Введи число")
            ver = Console.ReadLine(ChackDublicates(ver))
            Console.WriteLine("Если ваше число стало-False-цифры в вашем числе не повторяются и его можно вводить, если True-цифры дублируются, число вводить нельзя!")

            Do While Len(ver) = 4 And (ChackDublicates(ver)) = False
                For m As Integer = 0 To 3
                    For i As Integer = 0 To 3
                        If ver.Chars(m) = namber.Chars(i) Then
                            If i = m Then
                                Console.WriteLine("{0} цыфра вашего слова - бык", m + 1)
                                bull = bull + 1
                            Else
                                Console.WriteLine("{0} цыфра вашего слова - корова", m + 1)
                                cow = cow + 1
                            End If
                        End If
                    Next
                Next
                Rgh = bull + cow
                Console.WriteLine("В вашем числе {0} быков и {1} коров, всего правильных ответов {0}", bull, cow, Rgh)
            Loop Until namber = ver
        Loop
        Console.WriteLine("Число не четырехзначное или же в нем повторяются цифры, такое вводить нельзя!")


    End Sub
    Function ChackDublicates(ver As String) As Boolean
        ChackDublicates = False
        For n As Integer = 0 To 2
            For i As Integer = n + 1 To 3
                If ver.Chars(n) = ver.Chars(i) Then
                    ChackDublicates = True
                End If
            Next
        Next
    End Function
End Module
