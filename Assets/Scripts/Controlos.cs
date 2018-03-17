using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlos : MonoBehaviour {

	public Camera cam;

	public float tempSeed;

	public void setCamera(Dropdown camPos){
		if (camPos.value == 0) {
			Debug.Log ("0 - " + cam.transform.position);
			Vector3 vistaTopo = new Vector3 (0, 855, -15);
			cam.transform.position = vistaTopo;
			cam.transform.rotation = Quaternion.Euler (90, 0, 0);
		} else if (camPos.value == 1) {
			Debug.Log ("1 - " + cam.transform.position);
			Vector3 vistaFrente = new Vector3 (0, 290, -470);
			cam.transform.position = vistaFrente;
			cam.transform.rotation = Quaternion.Euler (40, 0, 0);
		} else if (camPos.value == 2) {
			Debug.Log ("3 - " + cam.transform.position);
			Vector3 vistaLado = new Vector3 (-1050, 240, 65);
			cam.transform.position = vistaLado;
			cam.transform.rotation = Quaternion.Euler (40, 90, 0);
		}
	}
	public void setSeedTemp(Slider slide){
		tempSeed= slide.value;
	}
	public void setSeedField(InputField txtSeed){
		txtSeed.text= tempSeed.ToString();
		txtSeed.ActivateInputField();
		txtSeed.ForceLabelUpdate ();
	}
}
