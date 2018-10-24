using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

    // Update is called once per frame

    public int A;
    public int b;
    public int c;

    public string Password;
    public bool OnSwitch;

    void Update() {
        if (OnSwitch)
        {
            print("The Light is on");
        }

        if (Password == "Ou812")
        {
            print("Correct Password.");
        }

        if (A + b == c)
        {
            print("A pluse B is equal to C");
        }

	}
}
