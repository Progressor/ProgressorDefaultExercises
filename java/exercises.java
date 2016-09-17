
public class exercises {

	public static void main(String... args) {

		exercises inst = new exercises();
		System.out.println(inst.helloWorld());
		System.out.println(inst.alternate("Hlo ol!", "el,Wrd"));
		System.out.println(new String(inst.swapEncrypt("Hello World".toCharArray(), 11)));
		System.out.println(new String(inst.swapEncrypt("eHll ooWlrd".toCharArray(), 11)));
		System.out.println(inst.isPalindrome("Hello, World!"));
		System.out.println(inst.isPalindrome("A Santa dog lived as a devil God at NASA."));
		for (int i = 0; i < 10; i++)
			System.out.println(inst.fibonacci(i));
	}

	public String helloWorld() {
		return "Hello, World!";
	}

	public String alternate(String first, String second) {
		String result = "";
		int i;
		for (i = 0; i < first.length() && i < second.length(); i++)
			result += first.substring(i, i + 1) + second.substring(i, i + 1);
		result += first.substring(i) + second.substring(i);
		return result;
	}

	public char[] swapEncrypt(char[] toSwap, int length) {
		for (int i = 0; i + 1 < length; i += 2) {
			char tmp = toSwap[i];
			toSwap[i] = toSwap[i + 1];
			toSwap[i + 1] = tmp; 
		}
		return toSwap;
	}

	public boolean isPalindrome(String palindrome) {
		String clean = java.util.regex.Pattern.compile("[^A-Za-z]").matcher(palindrome).replaceAll("").toLowerCase();
		for (int i = 0, j = clean.length() - 1; i < j; i++, j--)
			if (clean.charAt(i) != clean.charAt(j)) return false;
		return true;
	}

	public int fibonacci(int num) {
		if (num < 1) return 0;
		if (num == 1) return 1;
		return fibonacci(num - 2) + fibonacci(num - 1);
	}
}
