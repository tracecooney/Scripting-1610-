using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    // Update is called once per frame


    // I did not use a Lamp Assect but the code is complete

    public int A;
    public int b;
    public int c;

    public string Password;
    public bool OnSwitch;
    public Material LampMaterial


    void Update()
    {
        if (OnSwitch)
        {
            LampMaterial.color = Color,white;
        }

        else
        {
            else LampMaterial,color = Color.black
        }

        if (Password == "Ou812")
        {
            print("Correct Password.");
        }

        else
        {
            print("Incorrect Password.");
        }

        if (A + b == c)
        {
            print("A pluse B is equal to C.");
        }

        else
        {
            print("A plus B is not equal to C.")
        }

    }
}
