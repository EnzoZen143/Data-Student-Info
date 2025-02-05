using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareNumber : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public Text resultText;

    public void CompareNumbers()
    {
        if (float.TryParse(inputField1.text, out float number1)
            && float.TryParse(inputField2.text, out float number2))
        {
            if (number1 > number2)
            {
                resultText.text = "First Number is Greater.";
            }
            else if (number1 < number2)
            {
                resultText.text = "Second Number is Greater.";
            }
            else
            {
                resultText.text = "Both are equal.";
            }

        }
        else
        {
            resultText.text = "Please Enter Valid Number";
        }
    }
}
