using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Cube cubePrefab;
    [HideInInspector] public float cubeSpeed;
    [HideInInspector] public float cubeDistance;
    [HideInInspector] public float spawnSpeed;
    
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
