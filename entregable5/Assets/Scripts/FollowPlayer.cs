using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset= new Vector3 (50f,4f,21f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //para que siga al player desde una buena distancia
        transform.position = player.transform.position + offset;
    }
}
