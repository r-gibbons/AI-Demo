using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PickMove : MonoBehaviour
{
    //rock =0 paper =1 scissor =2
    [SerializeField]
    Button Rock, Paper, Scissors;
    [SerializeField]
    TextMeshProUGUI displayUChoice, displayAIchoice, displayWinner, displayWins, displayLoses, displayTotal;

    int wins = 0, loses = 0, ties=0;

    string win = "You Win!", lose = "You Lose!", tie = "Tie!";
    
    AIPick AI;


    string[] userChoice = { "Rock", "Paper", "Scissor" };
    int uChoice, aiChoice,lastChoice;

    void Start()
    {
        AI = FindObjectOfType<AIPick>();
    }
    public void pickRock()
    {
        uChoice = 0;
        playMove();
        
    }
    public void pickPaper()
    {
        uChoice = 1;
        playMove();
    }
    public void pickScissor()
    {
        uChoice = 2;
        playMove();
    }
    void playMove()
    {
        
         aiChoice = AI.chooseMove(uChoice);
        
        
        displayAIchoice.text = userChoice[aiChoice];
        displayUChoice.text = userChoice[uChoice];

        if(uChoice ==0 && aiChoice == 1)
        {
            displayWinner.text = lose;
            ++loses;
        }
        else if (uChoice ==0 && aiChoice == 2)
        {
            displayWinner.text = win;
            ++wins;
        }
        else if(uChoice ==0 && aiChoice == 0)
        {
            displayWinner.text = tie;
            ++ties;
        }
        else if(uChoice==1 && aiChoice == 2)
        {
            displayWinner.text = lose;
            ++loses;
        }
        else if(uChoice == 1 && aiChoice == 0)
        {
            displayWinner.text = win;
            ++wins;
        }
        else if(uChoice == 1 && aiChoice == 1)
        {
            displayWinner.text = tie;
            ++ties;
        }
        else if(uChoice == 2 && aiChoice == 0)
        {
            displayWinner.text = lose;
            ++loses;
        }
        else if(uChoice == 2 && aiChoice == 1)
        {
            displayWinner.text = win;
            ++wins;
        }
        else if(uChoice == 2 && aiChoice == 2)
        {
            displayWinner.text = tie;
            ++ties;
        }
        displayLoses.text = loses.ToString();
        displayWins.text = wins.ToString();
        displayTotal.text = (wins+loses+ties).ToString();
        Debug.Log(AI.offset);



    }
}
