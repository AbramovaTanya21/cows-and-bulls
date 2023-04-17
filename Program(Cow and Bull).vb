Imports System
Imports System.ComponentModel

Module Program
    Const Lent As Byte = 5
    Sub Main(args As String())

        Dim ver As String
        Dim namber As String
        Dim cow As Integer = 0
        Dim bull As Integer = 0
        Dim Rgh As Integer
        Dim Hod As Integer

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


                If IsCorrect(ver) Then
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
                    Console.WriteLine("В вашем числе {0} быков и {1} коров, всего правильных ответов {2}, за {3} ход", bull, cow, Rgh, Hod + 1)
                    bull = 0
                    cow = 0
                    Rgh = 0
                Else
                    Console.WriteLine("Введено не коректное число!")
                End If

                Hod += 1
            Loop Until ver = namber
            Console.WriteLine("Молодец. Ты угадал за {0} ходов", Hod)
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
    Function IsCorrect(ver As String) As Boolean
        If Len(ver) <> Lent Then Return False

        'Try
        '    Dim Test As Integer = CInt(ver)
        'Catch ex As Exception
        '    Return False
        'End Try

        For i = 0 To Len(ver) - 1
            If Not Char.IsDigit(ver.Chars(i)) Then Return False
        Next
        IsCorrect = Not ChackDublicates(ver)
    End Function
End Module














