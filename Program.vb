Imports System

Module Program
     Sub Main(args As String())

        While True

            Console.Write("Zadejte èíslo k faktoriálu: ")

            Dim cislo_text As String = Console.ReadLine()
            Dim cislo As Integer = 0

            Dim vysledek As Integer = 1

            If (Integer.TryParse(cislo_text, cislo) = False) Then
                Console.WriteLine("Chyba v zadání, znovu.")
                Continue While
            End If

            If cislo > 10 Then
                Console.WriteLine("Èíslo vìtší jak 10, znovu.")
                Continue While
            End If

            If cislo < 0 Then
                Console.WriteLine("Èíslo je záporné, znovu.")
                Continue While
            End If

            vysledek = Faktorial(cislo)

            Console.WriteLine("Vysledek faktoriálu je " + vysledek.ToString)

            Console.WriteLine("++++++++++++++++++++++++++")

        End While

    End Sub

    Function Faktorial(cislo As Integer) As Integer

        Dim vysledek As Integer = 1

        While cislo > 0

            vysledek = vysledek * cislo

            cislo = cislo - 1

        End While

        Return vysledek

    End Function


End Module
