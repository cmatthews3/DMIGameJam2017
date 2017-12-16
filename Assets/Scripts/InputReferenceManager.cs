using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Movement
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
}


public class InputReferenceManager : MonoBehaviour {

    public static InputReferenceManager instance;

    public Movement movement;

    // Use this for initialization
    private void Awake()
    {
        if (instance == null) instance = this;
    }


}
