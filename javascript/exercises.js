
console.log(helloWorld());
console.log(alternate("Hlo ol!", "el,Wrd"));

function helloWorld() {
	return "Hello, World!";
}

function alternate(first, second) {
	var result = '', i;
	for (i = 0; i < first.length && i < second.length; i++)
		result += first[i] + second[i];
	result += first.substr(i) + second.substr(i);
	return result;
}
