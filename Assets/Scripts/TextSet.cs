using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextSet : MonoBehaviour
{
    public Board board;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = board.score.ToString();
    }
}
