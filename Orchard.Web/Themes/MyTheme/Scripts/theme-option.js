$(document).ready(function() {


$('select#colors').change(function () { 
	var b = $(this).children(":selected").val();
	if (b == 'blue') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("blue");
	}
	else if (b == 'navyblue') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("navyblue");
	}	
	else if (b == 'orange') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("orange");
	}
	else if (b == 'yellow') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("yellow");
	}
	else if (b == 'green') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("green");
	}
	else if (b == 'tealgreen') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("tealgreen");
	}
	else if (b == 'red') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("red");
	}
	else if (b == 'pink') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("pink");
	}
	else if (b == 'purple') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("purple");
	}
	else if (b == 'magenta') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("magenta");
	}
	else if (b == 'cream') {
		$('body').css('backgroundColor', '#f8f8f8').removeClass().addClass("cream");
	}
});	



$('select#layout').change(function () { 
	var b = $(this).children(":selected").val();
	if (b == 'streched') {
		window.location.href = "index.html";
	}	
	else if (b == 'boxed') {
		window.location.href = "../boxed/index.html";
	}
});	


 $("select#colors option").click(function(){
  var color = $(this).attr('value');
  if ($("#css_color_style").length > 0){
	  $("#css_color_style").remove();
  } 
  $("head").append("<link>");
  css = $("head").children(":last");
  css.attr({
    rel:  "stylesheet",
    type: "text/css",
    id: "css_color_style",
    href: "css/colors/color-" + color + ".css"
  });
 })

 $("#panel a.open").click(function(){
  var margin_left = $("#panel").css("margin-left");
  if (margin_left == "-210px"){
  $("#panel").animate({marginLeft: "0px"});
 }
 else{
  $("#panel").animate({marginLeft: "-210px"});
 }

 })

}); 