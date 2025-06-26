using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SnellenTestEvaluator : MonoBehaviour
{
    public TMP_Dropdown[] dropdowns;
    public Button submitButton;
    public TextMeshProUGUI submitButtonText;

    private int[] correctAnswers = new int[] {
        1, 2, 3, 2, 3, 1, 3, 1, 3, 1, 3
    };

    private string[] visualAcuityScores = new string[] {
        "20/200", "20/100", "20/70", "20/50", "20/40",
        "20/30", "20/25", "20/20", "20/15", "20/13", "20/10"
    };

    void Start()
    {
        submitButton.onClick.AddListener(CheckAnswers);
    }

    void CheckAnswers()
    {
        for (int i = 0; i < dropdowns.Length; i++)
        {
            int selected = dropdowns[i].value;
            if (selected != correctAnswers[i])
            {
                if (i == 0)
                {
                    submitButtonText.text = "Your visual acuity is worse than 20/200";
                }
                else
                {
                    submitButtonText.text = $"Your visual acuity score is {visualAcuityScores[i - 1]}";
                }
                return;
            }
        }

        // All correct
        submitButtonText.text = $"Your visual acuity score is {visualAcuityScores[visualAcuityScores.Length - 1]}";
    }
}
