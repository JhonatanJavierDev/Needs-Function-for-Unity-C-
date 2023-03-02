using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    public Slider hungerSlider;
    public Slider thirstSlider;

    private float hunger = 100f;
    private float thirst = 100f;

    private float hungerDecreaseRate = 1f; // 1% cada 15 minutos
    private float thirstDecreaseRate = 1f; // 1% cada 15 minutos
    private float stoppedHungerDecreaseRate = 3f; // 3% cada 15 minutos
    private float stoppedThirstDecreaseRate = 3f; // 3% cada 15 minutos

    private bool playerStopped = false;

    void Start()
    {
        // Inicializar las barras de progreso
        hungerSlider.value = hunger;
        thirstSlider.value = thirst;
    }

    void Update()
    {
        // Decrementar las barras de progreso según la tasa de disminución
        float hungerDecrease = (playerStopped ? stoppedHungerDecreaseRate : hungerDecreaseRate) * Time.deltaTime / 60f;
        float thirstDecrease = (playerStopped ? stoppedThirstDecreaseRate : thirstDecreaseRate) * Time.deltaTime / 60f;
        hunger = Mathf.Max(0f, hunger - hungerDecrease);
        thirst = Mathf.Max(0f, thirst - thirstDecrease);
        hungerSlider.value = hunger;
        thirstSlider.value = thirst;
    }

    public void EatFood(string foodType)
    {
        // Aumentar la barra de progreso de hambre según el tipo de comida
        float hungerIncrease = 0f;
        switch (foodType)
        {
            case "Hamburguesa":
                hungerIncrease = 15f;
                break;
            case "Pizza":
                hungerIncrease = 20f;
                break;
            case "Chocolates":
                hungerIncrease = 5f;
                break;
        }
        if (hunger + hungerIncrease > 100f)
        {
            hunger = 100f;
        }
        else
        {
            hunger += hungerIncrease;
        }
        hungerSlider.value = hunger;
    }

    public void DrinkWater()
    {
        // Aumentar la barra de progreso de sed
        float thirstIncrease = 30f;
        if (thirst + thirstIncrease > 100f)
        {
            thirst = 100f;
        }
        else
        {
            thirst += thirstIncrease;
        }
        thirstSlider.value = thirst;
    }

    public void SetPlayerStopped(bool value)
    {
        playerStopped = value;
    }
}
