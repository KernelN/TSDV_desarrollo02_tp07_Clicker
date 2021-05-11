using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityIntEvent : UnityEvent<int>{}
public class GoldGoalEvent : UnityEvent<GoldManager.GoldGoals> { }

public class GameManager : MonoBehaviour
{
    public UnityIntEvent goldValueChanged;
    public GoldGoalEvent newGoalReached;

    SceneLoader sceneLoader;
    UIManager ui;
    void Start()
    {
        goldValueChanged = new UnityIntEvent();
        newGoalReached = new GoldGoalEvent();

        sceneLoader = gameObject.GetComponent<SceneLoader>();
        ui = gameObject.GetComponent<UIManager>();
        goldValueChanged.AddListener(ui.UpdateGoldCounter);
        newGoalReached.AddListener(ui.EnableGoldIncreaseButtons);
        newGoalReached.AddListener(playerHasWon);
    }

    void playerHasWon(GoldManager.GoldGoals goalReached)
    {
        if (goalReached == GoldManager.GoldGoals.GAME_WINNED)
        {
            sceneLoader.LoadCreditsScene();
        }
    }
}
