var turno="o";
var cantidadOpciones=3;
CrearComponentesJuego();

$( ".pieza" ).click(function() {
    $(this).val(turno);
    cotejar(); 
    turno=(turno=="o")?"x":"o";
    $('#turnoDisplay').val(turno);
});

function cotejar(){
    for(i=1;i<=cantidadOpciones;i++){
	for(j=1;j<=cantidadOpciones;j++){
        fila=i;columna=j;
		
        contadorTotalFilas=1;
		contadorTotalcolumnas=1;
		contadorDiagonal=1;
		contadorDiagonalInversa=1;
		contadorTurnos=0;
        
        $( ".pieza" ).each(function( index ) {
		    elid=$( this ).attr('id');
            
		    if((elid.charAt(0)==fila)&&($( this ).val()==turno)){
                contadorTotalFilas++;	
                if(contadorTotalFilas==(cantidadOpciones+1)){campeon();	}
            }
            
            if((elid.charAt(1)==columna)&&($( this ).val()==turno)){
                contadorTotalcolumnas++;	
                if(contadorTotalcolumnas==(cantidadOpciones+1))	{campeon();}
            }
            if((elid.charAt(1)==elid.charAt(0))&&($( this ).val()==turno)){
                contadorDiagonal++;
			    if(contadorDiagonal==(cantidadOpciones+1)){campeon();}
            }
		  valorTotaldiagonal= parseInt(elid.charAt(1))+parseInt(elid.charAt(0));
		    if(((valorTotaldiagonal)==(cantidadOpciones+1)) &&($( this ).val()==turno)){
			     contadorDiagonalInversa++;
		          if(contadorDiagonalInversa==(cantidadOpciones+1)){campeon();	}
            }
            if($(this).val()!="-"){contadorTurnos++;
                if(contadorTurnos==(cantidadOpciones*cantidadOpciones)){TerminarJuego();}
            }
            
        });
	}}
}
    function TerminarJuego(){
        $("#alertMensaje").html("Juego terminado");
        $(".alert").show('slow');
        $( "#iniciar" ).removeClass( "disabled" );
    }
    function Reiniciar(){
         $(".alert").hide('slow');
        contadorTotalFilas=1;
		contadorTotalcolumnas=1;
		contadorDiagonal=1;
		contadorDiagonalInversa=1;
		contadorTurnos=0;
        $( ".pieza" ).each(function( index ) { $( this ).val('-');});
        $( "#iniciar" ).addClass( "disabled" );        
    }
    function campeon(){
        $("#alertMensaje").html('Ganador <strong><input class="ganador btn btn-primary btn-lg" type="button" value="'+turno+'"></strong>');
        $(".alert").show('slow');
        $( "#iniciar" ).removeClass( "disabled" );
    }
    function cerrarAlert(){
        $(".alert").hide('slow');
        $( "#iniciar" ).removeClass( "disabled" );
        Reiniciar();
    }
function CrearComponentesJuego(){
$("#tictactoe").append('<div class="alert alert-dismissible alert-warning collapse"><button type="button" class="close" onclick="cerrarAlert()">×</button><div id="alertMensaje"></div></div>');
    
    for(i=1;i<=cantidadOpciones;i++){
	for(j=1;j<=cantidadOpciones;j++){
        $("#tictactoe").append( "<input class='pieza btn btn-primary btn-lg' type='button' value='-' id='"+i+j+"'/>" );
	   }
        $("#tictactoe").append( "<hr style='  margin: 7px;'/>" );
    }$("#tictactoe").append('<br/>');
         $("#tictactoe").append('<span class=" well"><strong>Turno:</strong> <input class="btn btn-warning" id="turnoDisplay" type="button" value="o"></span>');
        $("#tictactoe").append('<br/>');
        $("#tictactoe").append('<br/>');
        $("#tictactoe").append('<input type="button" id="iniciar" onclick="Reiniciar()" value="Reiniciar" class="btn btn-danger btn-lg disabled"/>');
        }
    
    