using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sealed Class
public sealed class GameManager 
{
   //How to create a Sealed class - 
   private static GameManager instance;
   private List<GameObject> trashCanPrefabs = new List<GameObject>();

    public List<GameObject> TrashCanPrefabs { get  { return trashCanPrefabs; } }

    public static GameManager Instance 
    { 
        get
        { 
            if (instance == null)
            { 
                instance = new GameManager();
            }
            return instance; 
        } 
    }

    public void AddTrashCan(GameObject  newtrashCan)
    {
        trashCanPrefabs.Add(newtrashCan);
    }
    public void RemoveTrashCan(GameObject removetrashCan)
    {
        //int index = trashCanPrefabs.IndexOf(removetrashCan);
      //  Debug.Log(index);
        trashCanPrefabs.Remove(removetrashCan);
    }




}
