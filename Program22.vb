Imports System
Module Program22
    Sub Main(args As String())

        '//TODO: ���������� ���
        Dim ver As String
        Dim namber As String = "1234"
        Dim cow As Integer = 0
        Dim bull As Integer = 0
        Dim Rgh As Integer

        Console.WriteLine("������, �������� ������� ���������� �����!(����� �����)")

        Do
            Console.WriteLine("����� �����")

            ver = Console.ReadLine()
            Console.WriteLine(ChackDublicates(ver))
            ChackDublicates(namber)

            Console.WriteLine("���� ���� ����� �����-False-����� � ����� ����� �� ����������� � ��� ����� �������, ���� True-����� �����������, ����� ������� ������!")

            Do While Len(ver) = 4 And (ChackDublicates(ver)) = False And (ChackDublicates(namber)) = False
                For m As Integer = 0 To 3
                    For i As Integer = 0 To 3
                        If ver.Chars(m) = namber.Chars(i) Then
                            If i = m Then
                                bull = bull + 1
                            Else
                                cow = cow + 1
                            End If
                        End If
                    Next
                Next
            Loop
            Console.WriteLine("����� �� �������������� ��� �� � ��� ����������� �����, ����� ������� ������!")
        Loop Until namber = ver
        Rgh = bull + cow
        Console.WriteLine("� ����� ����� {0} ����� � {1} �����, ����� ���������� ������� {0}", bull, cow, Rgh)
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
