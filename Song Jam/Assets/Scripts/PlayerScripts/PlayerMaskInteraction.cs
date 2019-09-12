using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject bindPoint;
    private bool hasMask;
    private GameObject mask = null;
    void aquireMask(GameObject newMask)
    {
        mask = newMask;
        hasMask = true;
    }
    void moveMask()
    {
        if(mask != null)
        {
            mask.transform.position = gameObject.GetComponent<Transform>().position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hasMask = false;
        mask = null;
    }

    // Update is called once per frame
    void Update()
    {
        moveMask();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!hasMask && mask == null)
        {
            aquireMask(other.gameObject);
        }
    }
}
