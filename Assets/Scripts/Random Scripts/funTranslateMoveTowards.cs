using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funTranslateMoveTowards : MonoBehaviour
{

    public Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(moveDirection, Space.World); // the object will move based on the world axis
        transform.Translate(moveDirection, Space.Self); // the object will move based on the self axis so our rotaition effects where we go
        
    }
}
