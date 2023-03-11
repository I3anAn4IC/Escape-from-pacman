using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Vector2 randomPosition;
        
        public float xStart = 0;
        public float xRange = 3f;
        
        public float yStart = 0;
        public float yRange = 3f;
        
        void Start()
        {
            float xPosition = Random.Range (xStart, xRange);
            float yPosition = Random.Range (yStart, yRange);
            
            randomPosition = new Vector2(xPosition, yPosition);
            transform.position = randomPosition;
        }
}
