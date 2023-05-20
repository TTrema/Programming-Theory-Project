using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    private int hP;

    public int HP
    {
        get { return hP; }
        set { hP = Mathf.Max(1, value); }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hP);
        DestroyNoHp();
    }


    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player"))
        {
            hP--;
        }
    }

    void DestroyNoHp() 
    {
        if (hP < 1)
        
            Destroy(gameObject);
        }

}