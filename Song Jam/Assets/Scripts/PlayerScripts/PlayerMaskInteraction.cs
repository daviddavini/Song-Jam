using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject bindPoint;
    private bool hasMask;
    private bool canAquire;
    private GameObject mask = null;
    
    bool CheckMask()
    {
        return !hasMask && mask == null;
    }
    void AquireMask(GameObject newMask)
    {
        if(canAquire)
        {
            mask = newMask;
            hasMask = true;
        }
    }
    void DropMask()
    {
        if(mask != null)
        {
            // drop mask in random direction
            Vector3 randomVector = new Vector3().RandomVector();
       
            Debug.Log(randomVector);
            mask.GetComponent<Rigidbody2D>().AddForce(randomVector, ForceMode2D.Impulse);

            mask = null;
            hasMask = false;
            
        }
    }
    void MoveMask()
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
        canAquire = true;
        mask = null;
    }

    // Update is called once per frame
    void Update()
    {
        MoveMask();
        DropMask();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided!");

        if(CheckMask() && other.tag == "mask")
        {
            Debug.Log("collided with mask");
            AquireMask(other.gameObject);
        }
    }
}
