'Alexis Villagran
'RCET 2265
'Spring 2025
'MULTIPLICATIONTABLE
'https://github.com/alxsvxn/MultiplicationTable.git

Option Compare Text
Option Strict On
Option Explicit On

Module MultiplicationTable

    Sub Main()
        Dim userInput As String
        Dim tableSize As Integer
        Dim loopInput As Boolean = False
        Dim result As String
        Do
            Do
                Console.WriteLine("Please enter a whole number!")
                Console.WriteLine("Or press Q to Exit")
                userInput = Console.ReadLine()
                Try
                    tableSize = CInt(userInput)
                    If tableSize > 0 Then
                        loopInput = True
                    End If

                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine("Let's try again!")
                    Else
                        loopInput = True
                    End If

                End Try

            Loop Until loopInput = True

            loopInput = False

            Do While userInput <> "Q" And loopInput = False

                loopInput = True
                Console.WriteLine()
                Console.WriteLine($"Here is a {userInput}" & " * " &
                              $"{userInput} multiplication table!")

                For i = 1 To tableSize

                    For j = 1 To tableSize

                        result = CStr(i * j)

                        result = result.PadLeft(4)

                        Console.Write(result)
                    Next
                    Console.WriteLine()

                Next
            Loop
            Console.WriteLine()
        Loop While userInput <> "Q"
    End Sub

End Module
