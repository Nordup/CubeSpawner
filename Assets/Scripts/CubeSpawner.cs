using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Cube cubePrefab;
    public float cubeSpeed;
    public float cubeDistance;
    public float spawnSpeed;
    
    private float _timePast;
    
    private void Update()
    {
        _timePast += Time.deltaTime;
        if (spawnSpeed == 0 || _timePast < spawnSpeed) return;
        
        SpawnCube();
        _timePast = 0;
    }
    
    private void SpawnCube()
    {
        var cube = Instantiate(cubePrefab, transform);
        cube.speed = cubeSpeed;
        cube.distance = cubeDistance;
        cube.gameObject.SetActive(true);
    }
}
