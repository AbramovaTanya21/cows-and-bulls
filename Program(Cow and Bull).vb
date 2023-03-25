Imports System

Module Program
    Sub Main(args As String())

        '//TODO: Генерируем код
        Dim ver As String
        Dim namber As String
        Dim cow As Integer = 0
        Dim bull As Integer = 0
        Dim Rgh As Integer
        Dim Hod As Integer

        Randomize()
        Do
            namber = Int((9000 * Rnd()) + 1000)
            Console.WriteLine(namber)
        Loop Until Not ChackDublicates(namber)

        Console.WriteLine("Привет, попробуй угадать загаданное четырехзначное число!")

        Do
            Console.WriteLine("Введи число")
            ver = Console.ReadLine()

            If CorrectNum(ver) = False Then
                If IsCorrect(ver) Then
                    If ChackDublicates1(ver) = False Then

                        For m As Integer = 0 To 3
                            For i As Integer = 0 To 3
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
                        Console.WriteLine("Цифры в числе не должны повторяться!")
                    End If
                Else
                    Console.WriteLine("Вы выели не четырехзначное число")
                End If
            Else
                Console.WriteLine("Введите,пожалуйста, число")
            End If
            Hod += 1
        Loop Until ver = namber
        Console.WriteLine("Молодец. Ты угадал за {0} ходов", Hod)
    End Sub
    Function ChackDublicates(num As String) As Boolean
        ChackDublicates = False
        For n As Integer = 1 To 3
            For i As Integer = n To 3
                If num.Chars(n - 1) = num.Chars(i) Then
                    ChackDublicates = True
                    Exit Function
                End If
            Next
        Next
    End Function
    Function IsCorrect(ver As String) As Boolean
        If Len(ver) = 4 Then
            IsCorrect = True
        Else
            IsCorrect = False
        End If
    End Function
    Function ChackDublicates1(ver As String) As Boolean
        ChackDublicates1 = False
        For n As Integer = 1 To 3
            For i As Integer = n To 3
                If ver.Chars(n - 1) = ver.Chars(i) Then
                    ChackDublicates1 = True
                    Exit Function
                End If
            Next
        Next
    End Function
    Function CorrectNum(ver As String) As Boolean
        For i = 0 To ver.Length - 1
            If Asc(ver.Chars(i)) = 49 Or 50 Or 51 Or 52 Or 53 Or 54 Or 55 Or 56 Or 57 Then
                CorrectNum = True
            Else
                CorrectNum = False
            End If
        Next
    End Function
End Module














