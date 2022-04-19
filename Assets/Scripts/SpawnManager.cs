using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject healthCanPreafab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            //Hitting on Screen by Mouse Position.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin,ray.direction,out hitInfo))
            {
                Instantiate(healthCanPreafab,hitInfo.point, Quaternion.identity);
            }
        }
    }
}
