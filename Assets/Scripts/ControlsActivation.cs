using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsActivation : MonoBehaviour {

	public GameObject xxxName;

	void Start () {
		xxxName.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
	}

}
