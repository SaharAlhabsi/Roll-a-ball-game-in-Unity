#pragma strict
var player : GameObject;
var offset : Vector3;
function Start () {

	this.player = GameObject.Find("Player");
	offset = transform.position - player.transform.position;
//	this.gameObject.AddComponent(SmoothFollow);
//	this.GetComponent(SmoothFollow).target = this.player.transform;
//	this.GetComponent(SmoothFollow).distance = 7.0;
}

function Update () {
	transform.position = player.transform.position + offset;
}
