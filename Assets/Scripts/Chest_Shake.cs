using DG.Tweening;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float shakeSure;
    public float shakeGucu;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOShakeRotation(shakeSure, shakeGucu, fadeOut: true);
            transform.DOShakeRotation(shakeSure, shakeGucu, fadeOut: true);
        }
    }
}
