<?php

$out = fopen('php://output', 'wb');
fwrite($out, helloWorld() . "\n");
fclose($out);

function helloWorld() : string {
	return "Hello, World!";
}
