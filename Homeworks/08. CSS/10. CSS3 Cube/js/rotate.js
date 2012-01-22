	var vP = "";
	if ($.browser.webkit) {
	vP = "-webkit-";
	} else if ($.browser.msie) {
		vP = "-ms-";
	} else if ($.browser.mozilla) {
		vP = "-moz-";
	} else if ($.browser.opera) {
		vP = "-o-";
	}
	
	function rotate_cube(e) {
			$('#Ycube').css(vP+"transform","rotateY("+e+"deg)");
			e = e+0.5;
			setTimeout('rotate_cube('+e+')', 10);
	}
	
	