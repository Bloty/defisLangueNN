using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scriptCol : MonoBehaviour
{
    public scriptLectureMot ScriptLectureMot;
    public string mot;


    public bool estDetruit = false;

    
    void OnTriggerEnter2D(Collider2D col)
    {
        //destruction de l'objet si trigger
        mot = ScriptLectureMot.mot;
        
        if (col.gameObject.CompareTag("Dog") && mot == "dog")
        { 
            Destroy(col.gameObject);
            estDetruit = true;
        }

        if (col.gameObject.CompareTag("Cat") && mot == "cat")
        {
            Destroy(col.gameObject);
            estDetruit = true;
        }

        if (col.gameObject.CompareTag("Bird") && mot == "bird")
        {
            Destroy(col.gameObject);
            estDetruit = true;
        }
        if (col.gameObject.CompareTag("Fish") && mot == "fish")
        {
            Destroy(col.gameObject);
            estDetruit = true;
        }

        if (col.gameObject.CompareTag("Mouse") && mot == "mouse")
        {
            Destroy(col.gameObject);
            estDetruit = true;
        }

        mot = "";
    }
}
