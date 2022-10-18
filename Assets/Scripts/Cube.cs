using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public float distance;
    
    private Vector3 _startPos;
    
    private void Start()
    {
        _startPos = transform.position;
    }
    
    private void Update()
    {
        if (distance < (transform.position - _startPos).magnitude) DestroySelf();
        transform.Translate(Time.deltaTime * speed * direction);
    }
    
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
