using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    public static int userScore, dealerScore;
    Random rnd = new Random();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
 
    protected void Deal()
    {
        int card_1 , card_2;
        card_1 = rnd.Next(1, 11);
        card_2 = rnd.Next(1, 11);
        userScore = card_1 + card_2;
        labelUserScore.Text = Convert.ToString("User Score: " + userScore);
    }
    protected void Hit()
    {
        int hitCard ;
        hitCard = rnd.Next(1, 11);
        userScore = userScore + hitCard;
        labelUserScore.Text = Convert.ToString("User Score: " + userScore);

        if (userScore > 21)
        {
            labelResult.Text = "Dealer wins!";
            userScore = 0;
            dealerScore = 0;
        }
    }
    protected void Pass()
    {
        int passCard;
        while (dealerScore < 17)
        {
            passCard = rnd.Next(1, 11);
            dealerScore = dealerScore + passCard;
            labelDealerScore.Text = Convert.ToString("Dealer Score: " + dealerScore);
            if (dealerScore > 21)
            {
                labelResult.Text = "Player wins!";
                userScore = 0;
                dealerScore = 0;
            }
        }

        if (userScore > dealerScore)
        {
            labelResult.Text = "Player Wins!";
        }
        else if (userScore == dealerScore)
        {
            labelResult.Text = "Tie Game!";
        }
        else if (userScore < dealerScore)
        {
            labelResult.Text = "Dealer Wins!";
        }

        userScore = 0;
        dealerScore = 0;
    }
    protected void end_Game()
    {
        labelDealerScore.Text = "";
        labelResult.Text = "";
        labelUserScore.Text = "";

        userScore = 0;
        dealerScore = 0;
    }

    protected void deal_Click(object sender, EventArgs e)
    {
        userScore = 0;
        dealerScore = 0;
        end_Game();
        labelPara.Text = "";
        Deal();
    }

    protected void hit_Click(object sender, EventArgs e)
    {
        labelPara.Text = "";
        Hit();
    }

    protected void pass_Click(object sender, EventArgs e)
    {
        labelPara.Text = "";
        Pass();
    }

    protected void endGame_Click(object sender, EventArgs e)
    {
        labelPara.Text = "Click Deal to start playing the game";
        end_Game();
    }
}