using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotation = 0.3f;
 
    private void Update()
    {
        transform.Rotate(0, _speedRotation, 0);
    }
}
