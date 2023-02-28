using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrolls : MonoBehaviour
{

    //velocidad del vehiculo
    public float speed = 5.0F;
    //velecidad de giro

    public float turnspeed = 0.0f; 

    public float horizontalinput = 0.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalinput = Input.GetAxis("horizontal");


        //Mover el vehicule hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Modificar el giro
        transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalinput);



    }
}
