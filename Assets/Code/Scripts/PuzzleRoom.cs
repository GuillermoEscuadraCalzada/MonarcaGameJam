using System.Collections;
using System.Collections.Generic;
using Code.Scripts;
using UnityEngine;

public class PuzzleRoom : MonoBehaviour{
    private int CollectedObjects = 0;
    private int TotalCollected = 0;

    public List<InteractableObject> sweepItems;
    public List<InteractableObject> cleaningItems;
    public List<InteractableObject> boxItems;

    public GameObject Arrow;

    private void Start() {
        TotalCollected += sweepItems.Count + cleaningItems.Count + boxItems.Count;
    }

    public void IncreaseCollectedObjects() {
        CollectedObjects += 1;
        if(CollectedObjects >= TotalCollected)
            Arrow.SetActive(true);
    }

}
