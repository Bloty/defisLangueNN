using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptLectureMot : MonoBehaviour
{
    public InputField motInput;
    public string mot;
    public scriptCol ScriptCol;

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mot = motInput.text;

        if (ScriptCol.estDetruit)
        {
            motInput.text = "";
            ScriptCol.estDetruit = false;

        }
    }
}
