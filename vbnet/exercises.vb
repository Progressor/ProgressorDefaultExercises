
Public Module Exercises

	Friend Sub Main()

		Console.WriteLine(helloWorld())
		Console.WriteLine(alternate("Hlo ol!", "el,Wrd"))
	End Sub

	Public Function helloWorld() As String
		Return "Hello, World!"
	End Function

	Public Function alternate(first As String, second As String) As String
		alternate = String.Empty
		Dim i As Integer
		For i = 0 To Math.Min(first.Length, second.Length) - 1
			alternate += first(i) + second(i)
		Next
		alternate += first.Substring(i) + second.Substring(i)
	End Function
End Module
