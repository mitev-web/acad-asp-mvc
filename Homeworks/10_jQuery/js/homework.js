// JavaScript Document

	$(document).ready(function() {

		//Task 01
		//Select all of the div elements that have a class of "module".
		$('div.module');
		//Come up with three selectors that you could use to get the third item in the #myList unordered list
		$("#myList li:nth-child(3)");
		$("#myListItem");
		$("ul #myListItem");
		
		//Select the label for the search input using an attribute selector
		$('label[for|="q"]');
		
		//Count hidden elements on the page 	(hint: .length)
		console.log($('body').find(':hidden').length);
		
		//Count the image elements that have an alt attribute
		console.log($('img[alt]').size());
		
		//Select all of the odd table rows in the table body
		 $("tbody tr:odd");
		 
		 
		 //Task02
		 //Select all of the image elements on the page
		 $('img');
		 //Log each image's alt attribute
		$('img').each(function(index) {
			console.log(index + ': ' + $(this).attr("alt"));
		});
		//Select the search input text box, then traverse up to the form and add a class to the form.
		$("input[name=q]").parent().addClass("gencho");
		
		//Select the list item inside #myList that has a class of "current"
		//Remove that class from it
		//Add a class of "current" to the next list item
		$("#myList li.current").removeClass("current").next().addClass("current");
	
		//Task03
		//Select the select element inside #specials
		//Traverse your way to the submit button.
		//Select the first list item in the #slideshow element
		//Add the class "current" to it, and then add a class of "disabled" to its sibling elements
		$("#specials .input_submit").addClass("current").siblings().addClass("disabled");
		
		//Task04
		
		//Add five new list items to the end of the unordered list #myList
		for(i = 0; i<5;i++)	 $("#myList").append("<li></li>");

		//Remove the odd list items
		$("#myList li:odd").remove();
		//Add another h2 and another paragraph to the last div.module
		$("div.module").last().append("<h2>test</h2><p>test</p>");
		//Add another option to the select element
		//Give the option the value "Wednesday"
		$("select option:nth-child(3)").after("<option>Wednesday</option>");
		//Add a new div.module to the page after the last one
		$("div.module").last().after('<div class="module"></div>');
		//Put a copy of one of the existing images inside of it
		image = $('body').find("img").first();
		$("div.module").append(image);

});