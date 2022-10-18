using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class NumberValidator : MonoBehaviour
{
    public UnityEvent<string> onValid;
    
    private TMP_InputField _tmpInputField;

    private void Start()
    {
        _tmpInputField = GetComponent<TMP_InputField>();
    }

    public void Validate(string line)
    {
        if (line.Equals("-"))
        {
            _tmpInputField.text = "1";
            line = "1";
        }
        else
        {
            var number = float.Parse(line);
            if (number <= 0)
            {
                _tmpInputField.text = "1";
                line = "1";
            }
        }
        
        onValid.Invoke(line);
    }
}
