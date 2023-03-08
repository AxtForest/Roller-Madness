using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    ScoreMng DigerSc;
    // Start is called before the first frame update
    private bool isCollided = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isCollided == false)
        {
            GetComponent<MeshRenderer>().material.color = new Color(287, 31, 310);
            DigerSc = FindObjectOfType<ScoreMng>();
            DigerSc.score--; // benim yaptýðým  /more usefull (reusebility)

            //FindObjectOfType<ScoreMng>().score = score -1 
            isCollided = true;
        }

    }
}
