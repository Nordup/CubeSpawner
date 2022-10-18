using TMPro;
using UnityEngine;

public class RulerCreator : MonoBehaviour
{
    public int length;
    public GameObject line;
    public TextMeshPro numberPrefab;
    
    private void Start()
    {
        var scale = line.transform.localScale;
        var position = line.transform.position;
        line.transform.localScale = new Vector3(length, scale.y, scale.z);
        line.transform.position = new Vector3(length / 2.0f, position.y, position.z);

        for (var i = 1; i <= length; i++)
        {
            var number = Instantiate(numberPrefab, transform);
            number.SetText(i.ToString());
            var pos = number.transform.position;
            number.transform.position = new Vector3(i, pos.y, pos.z);
        }
    }
}
