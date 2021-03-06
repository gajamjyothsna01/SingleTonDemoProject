using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject trashCanPreafab;

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
                GameObject tempTrashCan = Instantiate(trashCanPreafab,hitInfo.point, Quaternion.identity);
                //Accessing the Instance from other class
                GameManager.Instance.AddTrashCan(tempTrashCan);
                Debug.Log(GameManager.Instance.TrashCanPrefabs.Count);

               
            }
           
        }
        if(Input.GetMouseButtonDown(1))
        {
            GameManager.Instance.RemoveTrashCan(GameManager.Instance.TrashCanPrefabs[0]);
            Debug.Log(GameManager.Instance.TrashCanPrefabs.Count);
        }
      

    }
}
