using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    //==================================================================================================================
    // Variables  
    //==================================================================================================================
    
    //The Score that the player has earned 
    private int _score;
    //The text that displays that score 
    private TextMeshProUGUI _textMeshProGUI;
    
    //==================================================================================================================
    // Base Methods 
    //==================================================================================================================
    
    //Connects the components 
    private void Start()
    {
        _textMeshProGUI = GameObject.Find("Canvas").transform.Find("Score_Number").GetComponent<TextMeshProUGUI>();
        _textMeshProGUI.text = 0.ToString();
    }
    
    //==================================================================================================================
    // External Methods   
    //==================================================================================================================
    
    //Used by End Goal and Bouncers to update the current score value 
    public void ScorePoint(int i)
    {
        // string record = "original: " + _score;
        _score += i;
        _textMeshProGUI.text = _score.ToString();

        // record += " change: " + i + " final: " + _score;

        // Debug.Log(record);
    }
    
    //==================================================================================================================
    // Exit Button
    //==================================================================================================================
    public void GoToScene()
    {
        SceneManager.LoadScene($"Scene_Selector");
    }
    
}
