using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float zoomSpeed;
    public float zoomOutMin;
    public float zoomOutMax;
    
    private Camera _camera;
    private Vector3 _touchStart;

    private void Start()
    {
        _camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _touchStart = _camera.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.touchCount == 2)
        {
            var touchZero = Input.GetTouch(0);
            var touchOne = Input.GetTouch(1);

            var touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            var touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            var prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            var currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            var difference = currentMagnitude - prevMagnitude;

            Zoom(difference * zoomSpeed);
        }
        else if (Input.GetMouseButton(0))
        {
            var direction = _touchStart - _camera.ScreenToWorldPoint(Input.mousePosition);
            _camera.transform.position += direction;
        }
        
        Zoom(Input.GetAxis("Mouse ScrollWheel"));
    }

    private void Zoom(float increment){
        _camera.orthographicSize = Mathf.Clamp(_camera.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
