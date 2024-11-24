using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    public static UImanager Instance { get; private set; }

    private void Awake()
    {


        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

        _scoreText.text = "Score: 0";
    }


    public void ScoreTextUpdate(int lastScore)
    {
        _scoreText.text=("Score: "+lastScore);



    }

    


}
