using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{
    public string Name;

    public void Call()
    {
        Name = "Bob";
    }

    public void Call(String newName)
    {
        print(newName);
        print(Name);
    }

}
