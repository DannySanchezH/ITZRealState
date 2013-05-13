

  
$(document).ready(function(){
    $("#login").click(function(){
	$('#logInF').toggle('slow');
    });
		  
    $("#sig").click(function(){
      $('#signInF').toggle('slow');
    });
});


/*		 //Otros efectos con "fadeIn / fadeOut" 	  y 	"how / hide"
var banLog = false, banSign = false; //  false cuando no se Žsta mostrando el formulario.

$(document).ready(function(){
    $("#login").click(function(){
	if(banLog==true){	//Si se Žsta mostrando "Esconder"
	    //$("#logInF").hide('slow');
            $("#logInF").fadeOut('slow');
	    banLog=false;
        }else{ //  "Mostar"
	    //$("#logInF").show('slow');
            $("#logInF").fadeIn('slow');
	    banLog=true;
	}
    });
		  
    $("#sig").click(function(){
	if(banSign==true){	//Si se Žsta mostrando "Esconder"
            //$("#signInF").hide('slow');
            $("#signInF").fadeOut('slow');
	    banSign=false;
	}else{ //  "Mostar"
            //$("#signInF").show('slow');
	    $("#signInF").fadeIn('slow');
	    banSign=true;
	}
    });
});
*/
