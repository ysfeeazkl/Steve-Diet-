using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayGidis = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 5;
        transform.Translate(yatayGidis, 0, 0);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Translate(-0.3f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.Translate(0.3f, 0, 0);
        }



        //if (Input.GetAxisRaw("Horizontal") == -1)
        //{
        //    transform.rotation = Quaternion.Euler(0, -180, 0);
        //}
        //if (Input.GetAxisRaw("Horizontal") == 1)
        //{
        //    transform.rotation = Quaternion.Euler(0, 0, 0);
        //}
    }
}
