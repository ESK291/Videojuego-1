private var tiempo:float;
var tiempoGUI:GUIText;
var wheel:WheelCollider;
private var terminado:boolean = false;

function Update () {
	var hit:WheelHit;
	
	if(wheel.GetGroundHit(hit)){
		if(hit.collider.gameObject.tag ==("Meta")){
			terminado = true;
		}
	
	}
	if(!terminado){
		tiempo += Time.deltaTime;
	}
	
	
	tiempoGUI.text = tiempo.ToString();
}