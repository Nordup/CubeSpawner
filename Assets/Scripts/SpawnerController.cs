using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public CubeSpawner cubeSpawner;
    
    public void SetSpawnSpeed(string line)
    {
        if (float.TryParse(line, out var speed))
        {
            cubeSpawner.spawnSpeed = speed;
        }
    }
    
    public void SetCubeSpeed(string line)
    {
        if (float.TryParse(line, out var speed))
        {
            cubeSpawner.cubeSpeed = speed;
        }
    }
    
    public void SetCubeDistance(string line)
    {
        if (float.TryParse(line, out var distance))
        {
            cubeSpawner.cubeDistance = distance;
        }
    }
}
