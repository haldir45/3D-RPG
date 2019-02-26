using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float maxHealthPoints = 100f;

    float currentHealthPoints = 100f;

    public float HealthAsPercentage {
        get {
            return currentHealthPoints / maxHealthPoints;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
