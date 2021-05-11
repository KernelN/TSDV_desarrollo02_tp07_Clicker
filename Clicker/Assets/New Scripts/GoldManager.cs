using UnityEngine;

public class GoldManager : MonoBehaviour
{
    int gold;
    public enum GoldGoals { NO_GOLD, BUTTON_PLUS_2 = 10, BUTTON_PLUS_5 = 50, BUTTON_PLUS_10 = 100, BUTTON_PLUS_50 = 200, GAME_WINNED = 1000 }
    GoldGoals goalToReach;

    private void Start()
    {
        goalToReach = GoldGoals.BUTTON_PLUS_2;
    }

    public void IncreaseGold(int value)
    {
        gold += value;
        gameObject.GetComponent<GameManager>().goldValueChanged?.Invoke(gold); //invokes the event every time gold increases
        if (gold > (int)goalToReach)
        {
            UpdateGoal();
        }
    }

    void UpdateGoal()//updates currentGoal every time gold changes && a new goal is reached
    {
        gameObject.GetComponent<GameManager>().newGoalReached?.Invoke(goalToReach);//warn the listeners that the goal was reached

        switch ((GoldGoals)goalToReach)//Update goalToReach
        {
            case GoldGoals.NO_GOLD:
                goalToReach = GoldGoals.BUTTON_PLUS_2;
                break;
            case GoldGoals.BUTTON_PLUS_2:
                goalToReach = GoldGoals.BUTTON_PLUS_5;
                break;
            case GoldGoals.BUTTON_PLUS_5:
                goalToReach = GoldGoals.BUTTON_PLUS_10;
                break;
            case GoldGoals.BUTTON_PLUS_10:
                goalToReach = GoldGoals.BUTTON_PLUS_50;
                break;
            case GoldGoals.BUTTON_PLUS_50:
                goalToReach = GoldGoals.GAME_WINNED;
                break;
            case GoldGoals.GAME_WINNED:
                break;
            default:
                break;
        }
    }
}