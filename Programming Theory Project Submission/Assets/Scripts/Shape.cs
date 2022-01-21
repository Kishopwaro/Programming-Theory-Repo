using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    private Color color;
    private Text text; 
    private float rotationSpeed;
    private string m_Name = "Shape";
    public string Name
    {
        get { return m_Name; }
        set
        {
            if (value.EndsWith("s") || value.EndsWith("x"))
            {
                Debug.LogError("The shape name must be singular !");
            }
            else
            {
                m_Name = value;
            }
        }
    }

    private void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnMouseOver()
    {
        RotateShape();
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected virtual void DisplayText()
    {
        text.text.Replace(text.text, m_Name);
    }

    protected virtual void RotateShape()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

    protected abstract void SetColor();
}
