Imports System.Runtime.ConstrainedExecution

Public Class UserManager

    Structure User
        Public Name As String
        Public Result As Byte
    End Structure

    Private List(-1) As User
    Public Sub AddUser(Name As String)
        For i = 0 To List.Length - 1
            If List(i).Name = Name Then
                Exit Sub
            End If
        Next
        ReDim Preserve List(List.Length)
        Dim User As New User
        User.Name = Name
        List(List.Length - 1) = User
    End Sub

    Public Sub Print()
        If List.Length = 0 Then
            Console.WriteLine("Пока никто не учасивует в рейтинге")
        Else
            For Each User In List
                Console.Write(User.Name & ": ")
                If User.Result = 0 Then
                    Console.WriteLine("Пользователь не провел ни одной игры")
                Else
                    Console.WriteLine(User.Result)
                End If
            Next
        End If
    End Sub
    Public Sub AddResult(Hod As Integer, Name As String)
        For i = 0 To List.Length - 1
            If List(i).Name = Name Then
                If List(i).Result = 0 Or Hod < List(i).Result Then
                    List(i).Result = Hod
                    SortRaiting()
                    Exit Sub
                End If
            End If
        Next
    End Sub
    Private Sub SortRaiting()
        Dim Buf As User
        For j = 1 To List.Length - 1
            For i = List.Length - 1 To j
                If List(i).Result < List(i - 1).Result Then
                    Buf = List(i)
                    List(i) = List(i - 1)
                    List(i - 1) = Buf
                End If
            Next
        Next
    End Sub
End Class
