Imports System

Module Program
    Sub Main(args As String())
        Dim n As Integer, Pr As Long = 1

        Console.WriteLine("Привет, я перемножаю числа! Хочешь что-нибудь умножить?")

        Do
            Console.WriteLine("Введите число:")
            n = Console.ReadLine()

            If Pr < Int32.MaxValue / n Then
                Pr = Pr * n
            Else
                Console.WriteLine("Переполнение памяти")
                Exit Do
            End If
        Loop Until n = 1

        Console.WriteLine("Произведение чисел={0}", Pr)
    End Sub
End Module
