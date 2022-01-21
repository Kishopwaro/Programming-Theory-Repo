using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    
    public float m_rotationSpeed = 300;
    public MeshRenderer Renderer;

    // ENCAPSULATION
    private string m_Name = "shape";
    public string Name
    {
        get { return m_Name; }
        set
        {
            if (!(value.Equals("cube") || value.Equals("sphere") || value.Equals("cylinder")))
            {
                Debug.LogError("The shape must have a shape name !");
            }
            else
            {
                m_Name = value;
            }
        }
    }

    // ENCAPSULATION
    private Color m_color;
    public Color color
    {
        get { return m_color; }
        set
        {
            if(value.a != 1)
            {
                Debug.LogError("The color must not be transparent !");
            }
            else
            {
                m_color = value;
            }
        }
    }

    bool isColorSet = false;

    private void OnMouseOver()
    {
        RotateShape();
        if (!isColorSet)
        {
            SetColor();
            isColorSet = true;
        }
    }

    private void OnMouseExit()
    {
        if (isColorSet)
        {
            ResetColor();
            isColorSet = false;
        }
    }

    private void OnMouseDown()
    {        
        DisplayText();
        Debug.Log(m_Name);
    }


    protected abstract void DisplayText();

    // ABSTRACTION
    protected virtual void RotateShape()
    {
        transform.Rotate(Vector3.right * m_rotationSpeed * Time.deltaTime);
    }

    // ABSTRACTION
    private void SetColor()
    {
        Renderer.material.color = m_color;
    }

    // ABSTRACTION
    private void ResetColor()
    {
        Color resetColor = new Color(1, 1, 1);
        Renderer.material.color = resetColor;
    }

}
