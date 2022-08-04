using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopCover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void load()
    {
        this.transform.localScale = new Vector3(1.2F, this.transform.localScale.y, 1f);
    }
}
