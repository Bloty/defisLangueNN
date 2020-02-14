using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject dog;
    public GameObject cat;
    public GameObject bird;
    public GameObject fish;
    public GameObject mouse;
    public float spawnDelay;
    public float timer;
    public int indexList;

    private ArrayList listeMot = new ArrayList();


    void Start()
    {
        timer = spawnDelay;

        //liste de game object
        listeMot.Add(dog);
        listeMot.Add(cat);
        listeMot.Add(bird);
        listeMot.Add(fish);
        listeMot.Add(mouse);

        //timerReduit = DelayTempReduit;
    }

    void Update()
    {
        spawn();
    }

    public void spawn()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            indexList = Random.Range(0, listeMot.Count);
            Instantiate((GameObject)listeMot[indexList], transform.position, transform.rotation);
            timer = spawnDelay;
        }
    }
}