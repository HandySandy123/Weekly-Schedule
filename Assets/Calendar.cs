using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Calendar : MonoBehaviour
{
    [SerializeField]
    Dictionary<string, string> DaysCondition = new Dictionary<string, string>();
    // Start is called before the first frame update
    void Start()
    {
        DaysCondition.Add("Monday", "Sunny");
        DaysCondition.Add("Tuesday", "Rainy");
        DaysCondition.Add("Wednesday", "Stormy");
        DaysCondition.Add("Thursday", "Sunny");
        DaysCondition.Add("Friday", "Sunny");
        DaysCondition.Add("Saturday", "Apocalypse");
        DaysCondition.Add("Sunday", "Rainy");
        //DaysCondition.Add("Sunny", "Monday");
        //DaysCondition.Add("Rainy", "Tuesday");
        //DaysCondition.Add("Stormy", "Wednesday");
        //DaysCondition.Add("Sunny", "Thursday");
        //DaysCondition.Add("Sunny", "Friday");
        //DaysCondition.Add("Apocalypse", "Saturday");
        //DaysCondition.Add("Rainy", "Sunday");


        PrintByIfElse();

        PrintBySwitch();
    }

    private void PrintBySwitch()
    {
        foreach (var DayCon in DaysCondition)
        {
            switch (DayCon.Key)
            {
                case "Monday":
                    Debug.Log("Kissing my wife");
                    break;
                case "Tuesday":
                    Debug.Log("Tell my wife I love them");
                    break;
                case "Wednesday":
                    Debug.Log("Make coffee for wife");
                    break;
                case "Thursday":
                    Debug.Log("Tell wife they're pretty");
                    break;
                case "Friday":
                    Debug.Log("Buy roses");
                    break;
                case "Saturday":
                    Debug.Log("Take wife to ballet");
                    break;
                case "Sunday":
                    Debug.Log("End another beautiful week with wife");
                    break;
                default:
                    Debug.Log("Where's my wife? :C");
                    break;

            }
        }
    }

    private void PrintByIfElse()
    {
        foreach (var entry in DaysCondition)
        {
            string Day = entry.Key;
            Day += ": ";
            if (entry.Value == "Rainy" || entry.Value == "Stormy")
            {
                Day += "Run for Cover D:";
            }
            else if (entry.Value == "Sunny")
            {
                Day += "Enjoy the weather today <3";
            }
            else
            {
                Day += "The apocalypse is coming! Pray to the lords above for survival!";
            }
            Debug.Log(Day);
        }
    }
}
