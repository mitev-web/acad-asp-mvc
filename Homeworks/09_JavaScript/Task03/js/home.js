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
	
	
	function validateEmail(email) {
		var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
		if(reg.test(email) == false) {
		alert('Invalid Email Address');
		return false;
   }else{
	   alert('Valid Email Address :)');
	   return true
   }
}
	
	