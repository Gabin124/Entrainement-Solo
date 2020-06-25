using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float speed;
    public KeyCode watering_button;

    private bool watering_button_taken;
    // Start is called before the first frame update
    void Start()
    {
        watering_button_taken = false;
    }

    // Update is called once per frame
    void Update()
    {
       // float translation_h = Input.GetAxis("Horizontal") * speed;
        //float translation_v = Input.GetAxis("Vertical") * speed;

        Vector2 translate2d = new Vector2( Input.GetAxis("Horizontal") , Input.GetAxis("Vertical") ) * speed ;
        //Debug.Log(translate2d);

        transform.Translate(new Vector3(translate2d.x,0f,translate2d.y));
        //transform.Translate(Vector3.right * translation_h);
        //transform.Translate(Vector3.forward * translation_v);

        if(Input.GetKeyDown(watering_button))
    
    WateringPlants();
    }

    void WateringPlants()
    {
        
        {
            if(watering_button_taken)
            {

        
            Debug.Log("Glouglou");
            }
        }
    }

    void OnTriggerEnter(Collider inside)
   {
        if(inside.gameObject.tag == "Watering")
        {
            Debug.Log("PAS TOUCHE");
            
            inside.gameObject.GetComponent<AudioSource>().Play();
            watering_button_taken = true;
            Destroy(inside.gameObject, 0.3f);
        }
        
   }



}
