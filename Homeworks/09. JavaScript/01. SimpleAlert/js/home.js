// JavaScript Document
	function getTime(fname,lname ){
			var currentTime = new Date();
			var hours = currentTime.getHours();
			var minutes = currentTime.getMinutes();
		alert("Hello "+fname+" "+lname+"\nIt's "+hours+":"+minutes);
	}