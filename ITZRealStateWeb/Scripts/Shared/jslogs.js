	
$(window).load(function(){
 $("#txt").click(function(){
    if($("#txt").is(':visible'))
      {
		$("#juer").animate({ width: 'hide' }); 
      }
      else
      {
        $("#juer").animate({ width: 'show' }); 

      }
});
});//]]> 