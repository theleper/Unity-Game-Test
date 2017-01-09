using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum bulletType
{
    Simple,
    Shotgun,
    RocketLauncher
}
public class WeaponsManager : MonoBehaviour {

    public bool[] WeaponsArray;
	// Use this for initialization
	void Start () {
        WeaponsArray = new bool[System.Enum.GetValues(typeof(bulletType)).Length];
        WeaponsArray[(int)bulletType.Simple] = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
