//    $("#login").click(function(){
//	    $('#logInF').show('slow');
//    });
		  
//    $("#sig").click(function(){
//      $('#signInF').toggle('slow');
//    });
//});

$(document).ready(function () {
    $("#login").click(function () {
        $('/Account/Login').show('slow');
    });
});

function ShowLogin() {
   
    $("#sidebar_container").hide("slow").load('/Account/Login').show("slow");
};

//$('.login').click(function () {
//    $("#sidebar_container").hide("slow").load('logInF').show("slow");
//});