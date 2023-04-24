Imports System
Imports System.ComponentModel
Imports Cows_and_bulls_5.Program

Module Program
    Const Lent As Byte = 5

    Enum CorrectType
        Incorreclength
        IncorrectName
        duplication
        Correctly
        Withoutinput
    End Enum
    Sub Main(args As String())

        Dim ver As String
        Dim namber As String
        Dim cow As Integer = 0
        Dim bull As Integer = 0
        Dim Rgh As Integer
        Dim Hod As Integer
        Dim Mistake As CorrectType


        Dim k As ConsoleKeyInfo
        Randomize()
        Do

            Do
                namber = Int((9 * 10 ^ (Lent - 1)) * Rnd()) + Math.Pow(10, (Lent - 1))
                Console.WriteLine(namber)
            Loop Until Not ChackDublicates(namber)

            Console.WriteLine("Привет, попробуй угадать загаданное четырехзначное число!")

            Do
                Console.WriteLine("Введи число")
                ver = Console.ReadLine()

                Mistake = IsCorrect(ver)
                Select Case Mistake
                    Case CorrectType.Withoutinput : Console.WriteLine("Не время отчаиваться!")
                    Case CorrectType.Incorreclength : Console.WriteLine("Число не той длинны!")
                    Case CorrectType.IncorrectName : Console.WriteLine("Это разве число!?")
                    Case CorrectType.duplication : Console.WriteLine("Цифры в числе не должны повторяться!")
                End Select

                If Mistake <> CorrectType.Correctly Then Continue Do

                For m As Integer = 0 To Lent - 1
                    For i As Integer = 0 To Lent - 1
                        If ver.Chars(m) = namber.Chars(i) Then
                            If i = m Then
                                bull += 1
                            Else
                                cow += 1
                            End If
                            Rgh = bull + cow
                        End If
                    Next
                Next
                Hod += 1
                Console.WriteLine("В вашем числе {0} быков и {1} коров, всего правильных ответов {2}, за {3} ход", bull, cow, Rgh, Hod + 1)
                bull = 0
                cow = 0
                Rgh = 0
            Loop Until ver = namber

            Console.WriteLine("Молодец. Ты угадал за {0} ходов", Hod + 1)
            Hod = 0
            Console.WriteLine()
            Console.WriteLine("Хочешь сыграть еще раз? Нажми:(y(да),n(нет))")
            Do
                k = Console.ReadKey(True)
            Loop Until k.KeyChar = "n"c Or k.KeyChar = "y"c
            Console.Clear()

        Loop Until k.KeyChar = "n"c
        Console.WriteLine(k)

    End Sub
    Function ChackDublicates(List As String) As Boolean
        ChackDublicates = False
        For n As Integer = 1 To Lent - 1
            For i As Integer = n To Lent - 1
                If List.Chars(n - 1) = List.Chars(i) Then
                    ChackDublicates = True
                    Exit Function
                End If
            Next
        Next
    End Function

    Function IsCorrect(ver As String) As CorrectType
        IsCorrect = CorrectType.Correctly

        If Len(ver) = 0 Then Return CorrectType.Withoutinput
        For i = 0 To Len(ver) - 1
            If Not Char.IsDigit(ver.Chars(i)) Then Return CorrectType.IncorrectName
        Next
        If ChackDublicates(ver) Then Return CorrectType.duplication
        If Len(ver) <> Lent Then Return CorrectType.Incorreclength
        'Try
        '    Dim Test As Integer = CInt(ver)
        'Catch ex As Exception
        '    Return False
        'End Try
    End Function
End Module














