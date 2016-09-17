<?php

$out = fopen('php://output', 'wb');
fwrite($out, helloWorld() . "\n");
fwrite($out, alternate('Hlo ol!', 'el,Wrd') . "\n");
fwrite($out, implode('', swapEncrypt(str_split('Hello World'), 11)) . "\n");
fwrite($out, implode('', swapEncrypt(str_split('eHll ooWlrd'), 11)) . "\n");
fwrite($out, isPalindrome('Hello, World!') . "\n");
fwrite($out, isPalindrome('A Santa dog lived as a devil God at NASA.') . "\n");
for ($i = 0; $i < 10; $i++)
	fwrite($out, fibonacci($i) . "\n");
fclose($out);

function helloWorld() : string {	
	return "Hello, World!";
}

function alternate(string $first, string $second) : string {
	$result = '';
	for ($i = 0; $i < strlen($first) && $i < strlen($second); $i++)
		$result .= $first[$i] . $second[$i];
	$result .= substr($first, $i) . substr($second, $i);
	return $result;
}

function swapEncrypt(array $toSwap, int $length) : array {
	for ($i = 0, $tmp; $i + 1 < $length; $i += 2) {
		$tmp = $toSwap[$i];
		$toSwap[$i] = $toSwap[$i + 1];
		$toSwap[$i + 1] = $tmp;
	}
	return $toSwap;
}

function isPalindrome(string $palindrome) : string {
	$clean = strtolower(preg_replace('/[^A-Za-z]/', '', $palindrome));
	for ($i = 0, $j = strlen($clean) - 1; $i < $j; $i++ , $j--);
		if ($clean[$i] !== $clean[$j]) return false;
	return true;
}

function fibonacci(int $num) : int {
	if ($num < 1) return 0;
	if ($num === 1) return 1;
	return fibonacci($num - 2) + fibonacci($num - 1);
}
