using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private TextAlignment CounterLabel;
    public  float seconds = 1.0f;
    public int numbers = 3;

    IEnumerable Start()
    {
        CounterLabel = GetComponent<Text>();

        while (numbers > 0)
        {
            CounterLabel.Text = number.ToString();
            yield return new WaitForSeconds(seconds);
            numbers--;
        }
        
        CounterLabel.Text = "Go";
        yield return new WaitForSeconds(2);
    }

}
}
