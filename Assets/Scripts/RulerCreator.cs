using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RulerCreator : MonoBehaviour
{
    public GameObject line;
    public TextMeshPro numberPrefab;

    private readonly List<TextMeshPro> _numbers = new();
    
    public void UpdateLength(int length)
    {
        if (length == _numbers.Count - 1) return;
        
        // Change line length
        var scale = line.transform.localScale;
        var position = line.transform.position;
        line.transform.localScale = new Vector3(length, scale.y, scale.z);
        line.transform.position = new Vector3(length / 2.0f, position.y, position.z);
        
        // Clear numbers
        foreach (var number in _numbers)
        {
            Destroy(number.gameObject);
        }
        _numbers.Clear();
        
        // Create numbers
        for (var i = 0; i <= length; i++)
        {
            var number = Instantiate(numberPrefab, transform);
            number.SetText(i.ToString());
            var pos = number.transform.position;
            number.transform.position = new Vector3(i, pos.y, pos.z);
            
            _numbers.Insert(i, number);
        }
    }
}
