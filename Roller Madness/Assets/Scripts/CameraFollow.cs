using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform PlayerTransform;
    private Vector3 Fark;
    private Vector3 player;
    [SerializeField]
    private float camspeed;

    // Start is called before the first frame update
    void Start()
    {
        Fark = CameraMethod(PlayerTransform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerTransform != null)
        {
            MoveTheCam();
        }
    }
    private void MoveTheCam()
    {
        player = Fark + PlayerTransform.position;

        transform.position = Vector3.Lerp(transform.position, player, camspeed * Time.deltaTime);
        transform.LookAt(PlayerTransform.transform.position);
    }
    private Vector3 CameraMethod(Transform newTarget)
    {
        // Fark = transform.position - PlayerTransform.transform.position;
        //(parametresiz)
        //return Fark;
        //böyle yaptým ki doðru ama adamýn yaptýðý daha doðru (reusebility)

        return transform.position - newTarget.position;
    }
}
