'use strict';

console.log(helloWorld())
console.log(alternate('Hlo ol!', 'el,Wrd'))
console.log(swapEncrypt('Hello World'.split('')).join(''))
console.log(swapEncrypt('eHll ooWlrd'.split('')).join(''))
console.log(isPalindrome('Hello, World!'))
console.log(isPalindrome('A Santa dog lived as a devil God at NASA.'))
console.log(fibonacci(0))
console.log(fibonacci(1))
console.log(fibonacci(2))
console.log(fibonacci(3))
console.log(fibonacci(4))
console.log(fibonacci(5))
console.log(fibonacci(6))
console.log(fibonacci(7))
console.log(fibonacci(8))
console.log(fibonacci(9))

function helloWorld() {
	return 'Hello, World!'
}

function alternate(first, second) {
	let result = '', i
	for (i = 0; i < first.length && i < second.length; i++)
		result += first[i] + second[i]
	result += first.substr(i) + second.substr(i)
	return result
}

function swapEncrypt(toSwap) {
	for (let i = 0, tmp; i + 1 < toSwap.length; i += 2) {
		tmp = toSwap[i]
		toSwap[i] = toSwap[i + 1]
		toSwap[i + 1] = tmp
	}
	return toSwap
}

function isPalindrome(palindrome) {
	var clean = palindrome.replace(/[^A-Za-z]/g, '').toLowerCase()
	for (var i = 0, j = clean.length - 1; i < j; i++, j--)
		if (clean[i] != clean[j]) return false
	return true
}

function fibonacci(num) {
	if (num < 1) return 0
	if (num == 1) return 1
	return fibonacci(num - 2) + fibonacci(num - 1)
}
