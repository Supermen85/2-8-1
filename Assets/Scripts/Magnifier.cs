using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale = transform.localScale + Vector3.one * _speed * Time.deltaTime;
    }
}
