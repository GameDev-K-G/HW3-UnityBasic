using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 MovementVector;
    [SerializeField] float Period = 2f;
    [Range(0, 1)] [SerializeField] float MovementFactor;
    Vector3 StartingPos;
    void Start()
    {
        StartingPos = transform.position;
    }
 
    void Update()
    {
        if (Period <= Mathf.Epsilon)
        {
            return;
        }
 
        float cycle = Time.time / Period;
 
        const float tau = Mathf.PI * 2f;
        float RawSinWave = Mathf.Sin(cycle * tau);
 
        MovementFactor = RawSinWave / 2f + 0.5f;
        Vector3 Offset = MovementFactor * MovementVector;
        transform.position = StartingPos + Offset;
    }
}
 