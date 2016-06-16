using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MoveObjects : MonoBehaviour
{

    float y;
    float x;
    float z;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

   
    // Update is called once per frame


    void Start() {


    }
    void Update()


    { 

        PictureM();
 
    }


    public void PictureM()
    {
            y += -1f * (int)Time.time;
            x += 2 * (int)Time.time;

            if (y > -5)
            {

                transform.localPosition = new Vector3(0, y, 0);
                transform.localRotation = Quaternion.Euler(x, 0, 0);


                if ((y - 1) == -5)
                {
                    gameObject.AddComponent<AudioSource>();
                    source.clip = audio;
                    source.playOnAwake = false;
                    source.PlayOneShot(audio);
                }
            
        }
    }


    public void DoorsM()
    {
      //  transform.localPosition = new Vector3(5, 0, 0);
        y += 0.01f * (int)Time.time;
        x += -0.1f * (int)Time.time;
        z += -1f * (int)Time.time;

        if (x < -30)
        {
            transform.localPosition = new Vector3(-206.2145f, 0, -238.7241f);
            transform.localRotation = Quaternion.Euler(0, 19.4667f, 0);

          
        }

        if (x > -29) {

            transform.localPosition = new Vector3(0, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        
        
    }
}
