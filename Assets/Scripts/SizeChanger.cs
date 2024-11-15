using UnityEngine;

public class SizeChanger: MonoBehaviour
{
    [SerializeField] private Vector3 _scaleSpeed;

    private void Update()
    {
        transform.localScale += _scaleSpeed * Time.deltaTime;
    }
}
