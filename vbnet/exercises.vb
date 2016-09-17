
Public Module Exercises

	Friend Sub Main()

		Console.WriteLine(helloWorld())
		Console.WriteLine(alternate("Hlo ol!", "el,Wrd"))
		Console.WriteLine(new String(swapEncrypt("Hello World".ToCharArray(), 11)))
		Console.WriteLine(new String(swapEncrypt("eHll ooWlrd".ToCharArray(), 11)))
		Console.WriteLine(isPalindrome("Hello, World!"))
		Console.WriteLine(isPalindrome("A Santa dog lived as a devil God at NASA."))
		For i = 0 To 9
			Console.WriteLine(fibonacci(i))
		Next
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

	Public Function swapEncrypt(toSwap As Char(), length As Integer) As Char()
		For i = 0 to length - 2 Step 2
			Dim tmp = toSwap(i)
			toSwap(i) = toSwap(i + 1)
			toSwap(i + 1) = tmp
		Next
		Return toSwap
	End Function

	Public Function isPalindrome(palindrome As String) As Boolean
		Dim clear = System.Text.RegularExpressions.Regex.Replace(palindrome, "[^A-Za-z]", "").ToLower()
		Dim i = 0, j = clear.Length - 1
		While i < j
			If clear(i) <> clear(j) Then Return False
			i += 1
			j -= 1
		End While
		Return True
	End Function

	Public Function fibonacci(num As Integer) As Integer
	If num < 1 Then Return 0
	If num = 1 Then Return 1
	Return fibonacci(num - 2) + fibonacci(num - 1)
	End Function
End Module
