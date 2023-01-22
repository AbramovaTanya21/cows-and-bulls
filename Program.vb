Imports System

Module Program
    Sub Main(args As String())

        '//TODO: Генерируем код
        Dim namber As String = "1234"

        Console.WriteLine("Привет, попробуй угадать загаданное число!")
        Dim ver As String
        Do
            ver = Console.ReadLine()

            For i As Integer = 0 To 3
                If ver.Chars(0) = namber.Chars(i) Then
                    If i = 0 Then
                        Console.WriteLine("Первая цыфра вашего слова - бык")
                    Else
                        Console.WriteLine("Первая цыфра вашего слова - корова")
                    End If

                End If
            Next

            If namber = ver Then
                Console.WriteLine("Угадал все число, молодец!")
            Else
                Console.WriteLine("Ошибка, число не угадано")
            End If
        Loop Until namber = ver
    End Sub
End Module
