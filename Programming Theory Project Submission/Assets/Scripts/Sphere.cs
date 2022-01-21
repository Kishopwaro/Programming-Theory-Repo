using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// INHERITANCE
public class Sphere : Shape
{
    [SerializeField] private TextMeshProUGUI text;

    //POLYMORPHISM
    protected override void DisplayText()
    {
        text.color = Color.green;
        text.SetText("I am a sphere");        
    }

    //POLYMORPHISM
    protected override void RotateShape()
    {
        transform.Rotate(Vector3.forward * -m_rotationSpeed * Time.deltaTime);
    }
}
