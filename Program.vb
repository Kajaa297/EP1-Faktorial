Imports System

Module Program
     Sub Main(args As String())

        While True

            Console.Write("Zadejte ��slo k faktori�lu: ")

            Dim cislo_text As String = Console.ReadLine()
            Dim cislo As Integer = 0

            Dim vysledek As Integer = 1

            If (Integer.TryParse(cislo_text, cislo) = False) Then
                Console.WriteLine("Chyba v zad�n�, znovu.")
                Continue While
            End If

            If cislo > 10 Then
                Console.WriteLine("��slo v�t�� jak 10, znovu.")
                Continue While
            End If

            If cislo < 0 Then
                Console.WriteLine("��slo je z�porn�, znovu.")
                Continue While
            End If

            vysledek = Faktorial(cislo)

            Console.WriteLine("Vysledek faktori�lu je " + vysledek.ToString)

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
