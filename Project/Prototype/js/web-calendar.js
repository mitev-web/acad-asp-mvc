// JavaScript Document
	$(document).ready(function(){
	$(".close-button").click(function() {
		$(this).parent().toggle('slow', function(){
			
		});
	});
	
	
	$(".config-button").click(function () {
	
		$("#config-box").toggle("slide", { direction: "right" }, 1000);

});

	$(".link-button").click(function () {
	
		$(this).addClass("active");

});


	
	$("#formregister").submit(function() {
	
			if($("#email").val() != $("#email2").val()){
				alert("Emails do not match!");	
				location.reload();
				return false;
			}else if($("#pass").val() != $("#pass2").val()){
			    alert("Passwords do not match!");	
				location.reload();
				return false;
			}else{
				return true;	
			}
	});
});