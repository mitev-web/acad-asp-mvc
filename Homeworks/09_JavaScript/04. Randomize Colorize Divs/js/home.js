// JavaScript Document
	function rand(from, to){
   return Math.floor(Math.random() * (to - from + 1) + from);
}
function createColorDiv() 
{ 
	viewportwidth = window.innerWidth,
	viewportheight = window.innerHeight
	
	var height = Math.round(Math.random()*40);
	var width = Math.round(Math.random()*100);
	
	var body = document.getElementsByTagName('body') [0];
	var div = document.createElement('div');
	div.style.backgroundColor = getRandomColor();
	div.style.height = height+'px';
	div.style.position = 'absolute';
	div.style.width = width+'px';
	div.style.top = rand(1, viewportheight-height)+'px';
	div.style.left  = rand(1, viewportwidth-width)+'px';
	body.appendChild(div);

}

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++ ) {
        color += letters[Math.round(Math.random() * 15)];
    }
    return color;
}

function createColorDivs(number){
		for (i = 0; i< number;i++){
			createColorDiv();
		}
}
