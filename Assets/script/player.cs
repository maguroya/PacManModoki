using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour


{
    public Text countText;

    private int count;
    // Start is called before the first frame update
    void Start()
    {
       count = 0; 
       SetCount();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    if(Input.GetKey(KeyCode.A))
    {
        this.transform.Translate(-0.1f, 0f, 0f);
    }

    if(Input.GetKey(KeyCode.D))
    {
        this.transform.Translate(0.1f, 0f, 0f);
    }

    if(Input.GetKey(KeyCode.W))
    {
        this.transform.Translate(0f, 0f, 0.1f);
    }

     if(Input.GetKey(KeyCode.S))
    {
        this.transform.Translate(0f, 0f, -0.1f);
    }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            SetCount();

            if(count>=430)
            {
                SceneManager.LoadScene("GameClearScene");
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        
         if(collision.gameObject.tag=="enemy")
        {
            Destroy(gameObject, 0.2f);
        }
    }

    void SetCount()
    {
     countText.text = "HIGH SCORE: "+ count.ToString();
    }
}
