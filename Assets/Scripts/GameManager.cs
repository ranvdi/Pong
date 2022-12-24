using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;
    public GameObject Cyberball;
    public GameObject Catball;
    public GameObject Xpball;
    public GameObject Westball;

    [Header("Themes")]
    public GameObject CyberPong;
    public GameObject CatPong;
    public GameObject XpPong;
    public GameObject WestPong;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2CatPaddle;
    public GameObject player2XpPaddle;
    public GameObject player2WestPaddle;
    public GameObject player2CyberPaddle;
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;
    public GameObject computerText;

    [Header("Computer")]
    public GameObject ComputerCatPaddle;
    public GameObject ComputerXpPaddle;
    public GameObject ComputerWestPaddle;
    public GameObject ComputerCyberPaddle;
    public GameObject ComputerPaddle;
    public GameObject ComputerGoal;

    [Header("Menus")]
    public GameObject MainMenu;
    public GameObject ModMenu;
    public GameObject SkinMenu;
    public GameObject PauseMenu;
    public GameObject OptionsMenu;  

    public int Player1score;
    public int Player2score;
    public string Theme;

    private void Start()
    {
        Time.timeScale= 0f;
        MainMenu.SetActive(true);
        Player1score = 0;
        Player2score = 0;
    }

    public void Playgame()
    {
        SkinMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void ThemeCyber()
    {
        CyberPong.SetActive(true);
        ModMenu.SetActive(true);
        SkinMenu.SetActive(false);
        player2Paddle = player2CyberPaddle;
        ComputerPaddle = ComputerCyberPaddle;
        Theme = "Cyber";
        GameObject.FindObjectOfType<AudioManager>().playsong("Background1");
        Time.timeScale = 1f;
    }
    public void ThemeCat()
    {
        CatPong.SetActive(true);
        ModMenu.SetActive(true);
        SkinMenu.SetActive(false);
        player2Paddle = player2CatPaddle;
        ComputerPaddle = ComputerCatPaddle;
        Theme = "Cat";
        GameObject.FindObjectOfType<AudioManager>().playsong("Background2");
        Time.timeScale = 1f;
    }
    public void ThemeXp()
    {
        XpPong.SetActive(true);
        ModMenu.SetActive(true);
        SkinMenu.SetActive(false);
        player2Paddle = player2XpPaddle;
        ComputerPaddle = ComputerXpPaddle;
        Theme = "Xp";
        GameObject.FindObjectOfType<AudioManager>().playsong("Background4");
        Time.timeScale = 1f;
    }
    public void ThemeWest()
    {
        WestPong.SetActive(true);
        ModMenu.SetActive(true);
        SkinMenu.SetActive(false);
        player2Paddle = player2WestPaddle;
        ComputerPaddle = ComputerWestPaddle;
        Theme = "West";
        GameObject.FindObjectOfType<AudioManager>().playsong("Background3");
        Time.timeScale = 1f;
    }
    public void ModSelectPvE()
    {
        ModMenu.SetActive(false);
        ComputerPaddle.SetActive(true);
    }
    public void ModSelectPvP()
    {
        ModMenu.SetActive(false);
        player2Paddle.SetActive(true);
        ComputerPaddle.SetActive(false);
    }

    public void player1Scored()
    {
        Player1score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1score.ToString();
        resetPosition();
    }
    public void player2Scored()
    {
        Player2score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = Player2score.ToString();
        resetPosition();
    }
    public void resetPosition()
    {
        ball.GetComponent<Ball>().Resett();
        Catball.GetComponent<Ball>().Resett();
        Cyberball.GetComponent<Ball>().Resett();
        Westball.GetComponent<Ball>().Resett();
        Xpball.GetComponent<Ball>().Resett();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
        ComputerPaddle.GetComponent<Computer>().Reset();
    }
    public void PauseGame()
    {
        Time.timeScale= 0f;
        PauseMenu.SetActive(true);
    }
    public void Continue()
    {
        Time.timeScale= 1f;
        PauseMenu.SetActive(false);
    }
    public void MenuReturn()
    {
        PauseMenu.SetActive(false);
        MainMenu.SetActive(true);
        Player1score= 0;
        Player2score= 0;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void OptionsMenuOpen()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void OptionsMenuClose()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
}
