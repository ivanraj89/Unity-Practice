using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice2 : MonoBehaviour
{
    [SerializeField]
    private int scoreNumber;
    public class MatchBoard
    {
        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value you entered can't be below zero");
                }
                else
                {
                    score = value;
                }
            }

        }

        public MatchBoard(int score)
        {
            this.Score = score;
        }
    }

    private void Start()
    {
        MatchBoard board = new MatchBoard(scoreNumber);

        Debug.Log("Your score is " + board.Score);
    }

}
