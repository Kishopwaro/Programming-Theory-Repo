using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// INHERITANCE
public class Cube : Shape
{  

    [SerializeField] private TextMeshProUGUI text;

    // POLYMORPHISM
    protected override void DisplayText()
    {
        text.SetText("I am a cube");
    }
}
