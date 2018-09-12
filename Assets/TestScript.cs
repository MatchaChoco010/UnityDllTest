using System.Collections;
using System.Collections.Generic;
using FSharpProject;
using UnityEngine;

public class TestScript : MonoBehaviour {

	void Start () {
		Debug.Log (Test.factorial (5));
	}
}
