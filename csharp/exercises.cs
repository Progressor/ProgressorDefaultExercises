using System;

public class Exercises {

	static void Main() {

		var exercises = new Exercises();
		Console.WriteLine(exercises.helloWorld());
		Console.WriteLine(exercises.alternate("Hlo ol!", "el,Wrd"));
		Console.WriteLine(new String(exercises.swapEncrypt("Hello World".ToCharArray(), 11)));
		Console.WriteLine(new String(exercises.swapEncrypt("eHll ooWlrd".ToCharArray(), 11)));
		Console.WriteLine(exercises.isPalindrome("Hello, World!"));
		Console.WriteLine(exercises.isPalindrome("A Santa dog lived as a devil God at NASA."));
		for (var i = 0; i < 10; i ++)
			Console.WriteLine(exercises.fibonacci(i));
	}

	public string helloWorld() => "Hello, World!";

	public string alternate(string first, string second) {
		var result = string.Empty;
		int i;
		for (i = 0; i < first.Length && i < second.Length; i++)
			result += first[i].ToString() + second[i];
		result += first.Substring(i) + second.Substring(i);
		return result;
	}

	public char[] swapEncrypt(char[] toSwap, int length) {
		for (var i = 0; i + 1 < length; i += 2) {
			var tmp = toSwap[i];
			toSwap[i] = toSwap[i + 1];
			toSwap[i + 1] = tmp; 
		}
		return toSwap;
	}

	public bool isPalindrome(string palindrome) {
		var clear = System.Text.RegularExpressions.Regex.Replace(palindrome, "[^A-Za-z]", "").ToLower();
		for (int i = 0, j = clear.Length - 1; i < j; i++, j--)
			if (clear[i] != clear[j]) return false;
		return true;
	}

	public int fibonacci(int num) {
		if (num < 1) return 0;
		if (num == 1) return 1;
		return fibonacci(num - 2) + fibonacci(num - 1);
	}
}
