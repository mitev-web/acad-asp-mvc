// JavaScript Document
	var name;
	function hello(){
		name = prompt("What's your name?", "")
	}
	
	window.onbeforeunload = sayGoodbye;
	function sayGoodbye()
	{
		return "Goodbye "+name+"!";
	}