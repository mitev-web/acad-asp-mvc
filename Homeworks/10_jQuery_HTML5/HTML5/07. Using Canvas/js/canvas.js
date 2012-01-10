	 $(document).ready(function(){
		 
		context = $("#canvasId")[0].getContext("2d");
			
		context.fillStyle = "#CC4757";
		context.strokeStyle = "#95323E";
		context.lineWidth   = 4;
		context.strokeRect(0, 0, 152, 122);
		context.fillRect(2, 2, 150, 120);
		
	    context.fillStyle = "#000";
		context.strokeStyle = "#ACE500";
		context.lineWidth   = 4;
		context.strokeRect(50, 170, 152, 102);
		context.fillRect(52, 172, 150, 100);
		
		context.fillStyle = "#CC4757";
		context.strokeStyle = "#E0FFA3";
		context.lineWidth   = 4;
		context.strokeRect(70, 195, 112, 52);
		context.fillRect(72, 197, 110, 50);

		context.fillStyle   = 'none';
		context.strokeStyle = '#f00';
		context.lineWidth   = 4;
		// Draw a path
		context.beginPath();
	
		context.moveTo(200, 100);  
		context.lineTo(200, 0); 
		context.lineTo(230, 60);
		context.lineTo(260, 0);
		context.lineTo(260, 100);
		context.moveTo(300, 100);  
		context.lineTo(300, 20); 
		context.fill();
		context.arc(300, 20, 15, 0, Math.PI*2, true); 

		context.moveTo(340, 0);  
		context.lineTo(410, 0);  
		context.moveTo(370, 0);
		context.lineTo(370, 100);  
		context.moveTo(450, 0); 
		context.lineTo(450, 100);  
		context.lineTo(500, 100);
		context.moveTo(450, 50); 
		context.lineTo(500, 50);  
		context.moveTo(450, 0); 
		context.lineTo(500, 0); 
		context.moveTo(540, 0); 
		context.lineTo(580, 100); 
		context.lineTo(620, 0); 

		context.fill();
		context.stroke();
		context.closePath();
		 
	 });