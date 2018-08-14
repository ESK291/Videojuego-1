var persecucion :Camera;
var aerea :Camera;

var cambiocam:boolean = false;

function Awake(){
	persecucion.enabled = true;
	aerea.enabled = false;
}

function Update(){

if(cambiocam== false){
	if(Input.GetKeyDown("c")){
	persecucion.enabled= false;
	aerea.enabled =true;
	cambiocam= true;
				  }
					}
else{
	if(Input.GetKeyDown("c")){
	persecucion.enabled= true;
	aerea.enabled =false;
	cambiocam= false;
	}

}

}