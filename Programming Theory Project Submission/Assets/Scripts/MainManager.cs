using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    Shape cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube").GetComponent<Cube>();
        cube.color = Color.red;
        cube.Name = "cube";
    }

}