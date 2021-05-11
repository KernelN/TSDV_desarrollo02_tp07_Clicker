using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winInstructions;
    [SerializeField] TextMeshProUGUI goldCounter;
    [SerializeField] GameObject[] increaseGoldButton = new GameObject[4];

    void Start()
    {
        winInstructions.SetText("Reach " + GoldManager.GoldGoals.GAME_WINNED.ToString("D") + " to win"); //set on screen the gold needed to win
        UpdateGoldCounter(0);
    }

    public void UpdateGoldCounter(int gold)
    {
        goldCounter.SetText("Gold: " + gold.ToString("D")); //update gold counter on screen
    }
    public void EnableGoldIncreaseButtons(GoldManager.GoldGoals goalReached)
    {
        switch (goalReached)
        {
            case GoldManager.GoldGoals.BUTTON_PLUS_2:
			increaseGoldButton[0].SetActive(true);
                break;
            case GoldManager.GoldGoals.BUTTON_PLUS_5:
			increaseGoldButton[1].SetActive(true);
                break;
            case GoldManager.GoldGoals.BUTTON_PLUS_10:
			increaseGoldButton[2].SetActive(true);
                break;
            case GoldManager.GoldGoals.BUTTON_PLUS_50:
			increaseGoldButton[3].SetActive(true);
                break;
            default:
                break;
        }
	}
}
