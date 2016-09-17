import re

def helloWorld(): return "Hello, World!"

def alternate(first, second):
	result = ''
	I = min(len(first), len(second))
	for i in range(I):
		result += first[i] + second[i]
	result += first[I:] + second[I:]
	return result

def swapEncrypt(toSwap, length):
	for i in range(0, length - 1, 2):
		tmp = toSwap[i]
		toSwap[i] = toSwap[i + 1]
		toSwap[i + 1] = tmp
	return toSwap

def isPalindrome(palindrome):
	clean = re.sub('[^A-Za-z]', '', palindrome).lower()
	i = 0; j = len(clean) - 1
	while i < j:
		if (clean[i] != clean[j]): return False
		i += 1; j -= 1
	return True

def fibonacci(num):
	if (num < 1): return 0
	if (num == 1): return 1
	return fibonacci(num - 2) + fibonacci(num - 1)

print(helloWorld())
print(alternate('Hlo ol!', 'el,Wrd'))
print(''.join(swapEncrypt(list('Hello World'), 11)))
print(''.join(swapEncrypt(list('eHll ooWlrd'), 11)))
print(isPalindrome('Hello, World!'))
print(isPalindrome('A Santa dog lived as a devil God at NASA.'))
for i in range(10):
	print(fibonacci(i))
