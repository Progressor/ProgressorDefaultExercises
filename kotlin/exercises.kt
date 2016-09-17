
fun main(vararg args: String) {
	println(helloWorld())
	println(alternate("Hlo ol!", "el,Wrd"))
	println(String(swapEncrypt("Hello World".toCharArray(), 11)))
	println(String(swapEncrypt("eHll ooWlrd".toCharArray(), 11)))
	println(isPalindrome("Hello, World!"))
	println(isPalindrome("A Santa dog lived as a devil God at NASA."))
	for (i in 0..10)
		println(fibonacci(i))
}

fun helloWorld() = "Hello, World!"

fun alternate(first: String, second: String) : String {
	var result = ""
	val I = Math.min(first.length, second.length)
	for (i in 0 .. I - 1)
		result += first.substring(i, i + 1) + second.substring(i, i + 1)
	result += first.substring(I) + second.substring(I)
	return result
}

fun swapEncrypt(toSwap: CharArray, length: Int) : CharArray {
	for (i in 0 .. length - 2 step 2) {
		val tmp = toSwap[i]
		toSwap[i] = toSwap[i + 1]
		toSwap[i + 1] = tmp 
	}
	return toSwap
}

fun isPalindrome(palindrome: String) : Boolean {
	val clean = java.util.regex.Pattern.compile("[^A-Za-z]").matcher(palindrome).replaceAll("").toLowerCase()
	var i = 0; var j = clean.length - 1
	while (i < j) {
		if (clean[i] != clean[j]) return false
		i++; j--
	}
	return true
}

fun fibonacci(num: Int) : Int {
	if (num < 1) return 0
	if (num == 1) return 1
	return fibonacci(num - 2) + fibonacci(num - 1)
}
