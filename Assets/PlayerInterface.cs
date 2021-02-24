using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    public Slider CarChoice;
    public Sprite RedCar;
    public Sprite BlueCar;
    public Sprite BlackCar;
    public Image Car;

    public void changeCar()
    {

        float newCarValue = CarChoice.value;
        if (newCarValue == 0)
        {
           Car.sprite = BlackCar;

        }
        else if (newCarValue == 1)
        {
            Car.sprite = RedCar;
        }
        else if (newCarValue == 2)
        {
            Car.sprite = BlueCar;
        }
    }
}
