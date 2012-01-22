function mixColor(selector, color, speed){
    
    $(selector).css("color", color);
    setTimeout("mixColor('"+selector+"','"+getRandomColor()+"')", speed);
}

function mixBackgroundSize(selector, min, max){
	
//	    for (var i = 1; i < max; i++ ) {
//			$(selector).css("font-size",$(selector).css.va
//		}


	
}

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.round(Math.random() * 15)];
    }
    return color;
}