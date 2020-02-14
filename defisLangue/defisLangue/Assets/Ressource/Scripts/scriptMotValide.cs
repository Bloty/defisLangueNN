using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMotValide : MonoBehaviour
{
    public scriptLectureMot lectureMot;
    private string mot;
    public GameObject col;
    
    

    private ArrayList listeMot = new ArrayList();


    void Start()
    {
        col.SetActive(false);

        //liste de game object
        listeMot.Add("dog");
        listeMot.Add("cat");
        listeMot.Add("bird");
        listeMot.Add("fish");
        listeMot.Add("mouse");
    }

    void Update()
    {
        mot = lectureMot.mot;
    
        if (mot == (string)listeMot[0] || mot == (string)listeMot[1] || mot == (string)listeMot[2] || mot == (string)listeMot[3] || mot == (string)listeMot[4])
        {
            col.SetActive(true);         
        }
        else
        {
            col.SetActive(false);
        }      
    }
}
