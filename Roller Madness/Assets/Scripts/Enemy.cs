using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private bool gameOver = false;
    private float mesafe,DurmaMesafesi = 1.01f;
    private Transform player; //gameobject yaptým
    // private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindWithTag("Player").GetComponent<Transform>();

      //playerTransform = player.GetComponent<Transform>();

      //benim yaptýðým kadar iþleme gerek yokmuþ direk sonuna . koyup devam edebiliriz 
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.LookAt(player);//playertransform dedim

            mesafe = Vector3.Distance(player.position, this.gameObject.transform.position);

            if (mesafe > DurmaMesafesi)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        TimeManager GameOver = FindObjectOfType<TimeManager>();
        GameOver.gameOver = true;
    }
}
