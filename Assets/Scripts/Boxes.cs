using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    private int hP;

    // ENCAPSULATION
    public int HP
    {
        get { return hP; }
        set { hP = Mathf.Max(1, value); }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hP);
        DestroyNoHp();
    }

    // ABSTRACTION
    void DestroyNoHp() 
    {
        if (hP < 1)
        
            Destroy(gameObject);
        }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player"))
        {
            hP--;
        }
    }

}