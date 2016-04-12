$(document).ready(function(){
   var ws = new WebSocket('ws://achex.ca:4010');
	 ws.onmessage = function(evt){
		var datos = evt.data;
		var obj = jQuery.parseJSON(datos);
         if(obj.clase!=null){
             
			if(obj.clase=="white_btn"){
			  reproducir(obj.tecla,"");
			}
			if(obj.clase=="black_btn_second"){
			  reproducir(obj.tecla,"b");
			}
			 
             Colorverdadero=$('.'+obj.clase+'[value="'+obj.tecla+'"]').css("background-color");
			 
             $('.'+obj.clase+'[value="'+obj.tecla+'"]').animate({borderRadius: "10px"},10,null,function(){
             $('.'+obj.clase+'[value="'+obj.tecla+'"]').css("background-color","#FF0000");
              });
             $('.'+obj.clase+'[value="'+obj.tecla+'"]').animate({borderRadius: "10px"},100,null,function(){
             $('.'+obj.clase+'[value="'+obj.tecla+'"]').css("background-color",Colorverdadero);
             });
         }
	   };
     ws.onopen= function(evt){ ws.send('{"setID":"minipiano","passwd":"123"}');};
	 
  	function send(TECLA,clase){         
        ws.send('{"to":"minipiano","tecla":"'+TECLA+'","clase":"'+clase+'"}');
    }
	/********************************************************************************/
     $(".white_btn").click(function(){
         send($(this).val(),'white_btn');
         reproducir( $(this).val(),"");
    });
    
   $(".black_btn_first").click(function(){
        send($(this).val(),'black_btn_second');
       reproducir( $(this).val(),"b");

    });
    $(".black_btn_second").click(function(){
        send($(this).val(),'black_btn_second');
           reproducir( $(this).val(),"b");
    });
});
 function reproducir(numero,tipo) {
          SonidoNormal = new Audio("audio/"+tipo+numero+".wav");
          SonidoNormal.play();
        }