using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text objectDisplay;

    [SerializeField] private string objectiveText = "Base";
    [SerializeField] private string completedText = "Complete";

    public UnityEvent OnCompleteObjective = new UnityEvent();
    private void OnEnable()
    {
        objectDisplay.text = objectiveText;
    }

    public void CompletObjective()
    {
        if (gameObject.activeSelf)
        {
            objectDisplay.text = "";

            OnCompleteObjective.Invoke();

            gameObject.SetActive(false);
        }
    }
}
