using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField _firstInput;
    [SerializeField] private InputField _secondInput;
    [SerializeField] private Text _textOutput;

    private double _valueA;
    private double _valueB;

    public void Addition()
    {
        if (TryGetValues())
            DisplayResult(_valueA + _valueB);
    }

    public void Subtraction()
    {
        if (TryGetValues())   
            DisplayResult(_valueA - _valueB);
    }

    public void Division()
    {
        if (TryGetValues())
        {
            if (_valueB == 0)
                _textOutput.text = "На 0 делить нельзя";
            else
                DisplayResult(_valueA / _valueB);
        }
    }

    public void Multiplication()
    {
        if (TryGetValues())
            DisplayResult(_valueA * _valueB);
    }

    private bool TryGetValues()
    {
        bool isValid = double.TryParse(_firstInput.text, out _valueA) && double.TryParse(_secondInput.text, out _valueB);
        if (!isValid)
            _textOutput.text = "Введите корректные значения";
        return isValid;
    }

    private void DisplayResult(double result)
    {
        _textOutput.text = result.ToString("F2");
    }

   /* public void AdditionDelegat()
    {
        PerformOperation((a, b) => a + b);
    }

    private void PerformOperation(Func<double, double, double> Operation)
    {
        if (TryGetValues())
        {
            DisplayResult(Operation(_valueA, _valueB));
        }

    }*/
}
