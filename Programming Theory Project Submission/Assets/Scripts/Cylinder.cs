using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//INHERITANCE
public class Cylinder : Shape
{
    [SerializeField] private TextMeshProUGUI text;

    // POLYMORPHISM
    protected override void DisplayText()
    {
        text.color = Color.blue;
        text.SetText("I am a cylinder");
    }

    protected override void RotateShape()
    {        
        base.RotateShape();
        transform.Rotate(Vector3.up * (m_rotationSpeed * 0.5f) * Time.deltaTime);
    }
}
