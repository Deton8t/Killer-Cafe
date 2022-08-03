using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour
{
    public int invSlot;
    public bool gotItem;
    public bool isLoaded;


    // Start is called before the first frame update
    void Start()
    {
        if (invSlot == 0)
        {
            gotItem = itemTracker.hasItem1;
        }
        if (invSlot == 1)
        {
            gotItem = itemTracker.hasItem2;
        }
        if (invSlot == 2)
        {
            gotItem = itemTracker.hasItem3;
        }
        if (invSlot == 3)
        {
            gotItem = itemTracker.hasItem4;
        }
        if (gotItem)
        {
            loadItem();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void loadItem()
    {
        this.transform.localScale = new Vector3(1F, 1F, 1F);
        isLoaded = true;
    }
    public void unLoadItem()
    {
        this.transform.localScale = new Vector3(0F, 1F, 1F);
        isLoaded = false;
    }
}
