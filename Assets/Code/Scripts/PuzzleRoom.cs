using System.Collections;
using System.Collections.Generic;
using Code.Scripts;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleRoom : MonoBehaviour{
    [SerializeField] private UnityEvent onCollectedItems;
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
            onCollectedItems?.Invoke(); 
            // Arrow.SetActive(true);
    }

}
