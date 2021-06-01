using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;
    public float PlayerSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(direction==Vector3.forward)
            {
                direction=Vector3.left;
            }
            else
            {
                direction=Vector3.forward;
            }
            
        }
        transform.Translate(direction*PlayerSpeed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Pickup")
        {
            other.gameObject.SetActive(false);
        }
    }
}
