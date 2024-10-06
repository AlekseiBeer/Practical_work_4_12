using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField _firstInput;
    [SerializeField] private InputField _secondInput;
    [SerializeField] private Text _textOutput;

    private double _valueA;
    private double _valueB;

    public void NumbersComparer()
    {
        if (TryGetValues())
        {
            if (_valueA == _valueB)
                DisplayMessage("Равны");
            else
                DisplayMessage((_valueA > _valueB ? _valueA : _valueB).ToString());
        }
    }

    private bool TryGetValues()
    {
        bool isValid = double.TryParse(_firstInput.text, out _valueA) && double.TryParse(_secondInput.text, out _valueB);
        if (!isValid)
            _textOutput.text = "Введите корректные значения";
        return isValid;
    }

    private void DisplayMessage(string message)
    {
        _textOutput.text = message;
    }
}
