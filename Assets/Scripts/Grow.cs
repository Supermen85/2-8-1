using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var scale = transform.localScale;

        scale.x += _speed * Time.deltaTime;
        scale.y += _speed * Time.deltaTime;
        scale.z += _speed * Time.deltaTime;

        transform.localScale = scale;
    }
}
