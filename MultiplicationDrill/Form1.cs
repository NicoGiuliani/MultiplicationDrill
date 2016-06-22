using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationDrill
{
  public partial class frmMultGame : Form
  {
    private string strMode = "MULTIPLICATION"; // Default game mode
    private int intNum1;
    private int intNum2;
    private int intAnswer;
    private double dblCorrect;
    private double dblIncorrect;
    private int intMultHighScore;
    private int intAddHighScore;


    private void getRan()
    {
      Random myRandom = new Random();
      intNum1 = myRandom.Next(0, 10);
      intNum2 = myRandom.Next(0, 10);
    }


    private void setOperands()
    {
      getRan();
      lblFirstNum.Text = intNum1.ToString();
      lblSecNum.Text = intNum2.ToString();
    }


    private void playDing()
    {
      SoundPlayer ding = new SoundPlayer(@"Ding.wav");
      ding.Play();
    }


    private void playBuzz()
    {
      SoundPlayer buzz = new SoundPlayer(@"Buzz.wav");
      buzz.Play();
    }


    private void updateHighScore(string strMode)
    {
      switch (strMode)
      {
        case "MULTIPLICATION":
          if (dblCorrect > intMultHighScore)
          {
            intMultHighScore = (int)dblCorrect;
            lblHighScore.Text = intMultHighScore.ToString();
          }
          break;
        case "ADDITION":
          if (dblCorrect > intAddHighScore)
          {
            intAddHighScore = (int)dblCorrect;
            lblHighScore.Text = intAddHighScore.ToString();
          }
          break;
      }
    }


    public frmMultGame()
    {
      InitializeComponent();
    }


    private void btnStart_Click(object sender, EventArgs e)
    {
      if (btnStart.Text == "&Start")
      {
        // Disallow user to change modes while timer is running
        radMultiplication.Enabled = false;
        radAddition.Enabled = false;

        lblScoreLabel.Visible = false;
        lblHighScore.Visible = false;

        txtAnswer.Enabled = true;
        setOperands();

        timer1.Enabled = true;
        btnStart.Text = "&Stop";
        dblCorrect = 0;
        dblIncorrect = 0;
        lblCorrect.Text = dblCorrect.ToString();
        lblIncorrect.Text = dblIncorrect.ToString();
        lblPercent.Text = 0.ToString();
        txtAnswer.Focus();
      }
      else
      {
        radMultiplication.Enabled = true;
        radAddition.Enabled = true;
        lblScoreLabel.Visible = true;
        lblHighScore.Visible = true;
        btnStart.Text = "&Start";
        txtAnswer.Enabled = false;
        timer1.Enabled = false;
      }
    }


    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    private void timer1_Tick(object sender, EventArgs e)
    {
      txtAnswer.Text = ""; // To stop intIncorrect from incrementing when time runs out
      txtAnswer.Enabled = false;
      btnStart.Text = "&Start";
      timer1.Enabled = false;
      MessageBox.Show("You're out of time.");

      // Show high score again once game mode has stopped
      lblScoreLabel.Visible = true;
      lblHighScore.Visible = true;

      // Allow user to change game modes
      radMultiplication.Enabled = true;
      radAddition.Enabled = true;
    }


    private void txtAnswer_Leave(object sender, EventArgs e)
    {
      int x; // To prevent characters other than numbers from crashing form
      if (txtAnswer.Text != "" && btnStart.Text == "&Stop" && int.TryParse(txtAnswer.Text, out x))
      {
        switch (strMode)
        {
          case "MULTIPLICATION":
            if (int.Parse(txtAnswer.Text) == intNum1 * intNum2)
            {
              dblCorrect++;
              updateHighScore("MULTIPLICATION");
              lblCorrect.Text = (dblCorrect).ToString();
              pctFrown.Visible = false;
              pctSmiley.Visible = true;
              playDing();
            }
            else
            {
              dblIncorrect++;
              lblIncorrect.Text = (dblIncorrect).ToString();
              pctSmiley.Visible = false;
              pctFrown.Visible = true;
              playBuzz();
            }
            break;
          case "ADDITION":
            if (int.Parse(txtAnswer.Text) == intNum1 + intNum2)
            {
              dblCorrect++;
              updateHighScore("ADDITION");
              lblCorrect.Text = (dblCorrect).ToString();
              pctFrown.Visible = false;
              pctSmiley.Visible = true;
              playDing();
            }
            else
            {
              dblIncorrect++;
              lblIncorrect.Text = (dblIncorrect).ToString();
              pctSmiley.Visible = false;
              pctFrown.Visible = true;
              playBuzz();
            }
            break;
        }
        lblPercent.Text = (dblCorrect/(dblCorrect + dblIncorrect)).ToString("p2");

        setOperands();
        txtAnswer.Text = "";
        txtAnswer.Focus();
      }
      else
      {
        txtAnswer.Text = "";
        txtAnswer.Focus();
      }
    }


    private void radMultiplication_CheckedChanged(object sender, EventArgs e)
    {
      if (radMultiplication.Checked)
      {
        strMode = "MULTIPLICATION";
        lblOperator.Text = "X";
        lblHighScore.Text = intMultHighScore.ToString();
      }
      else
      {
        strMode = "ADDITION";
        lblOperator.Text = "+";
        lblHighScore.Text = intAddHighScore.ToString();
      }
    }


    private void radAddition_CheckedChanged(object sender, EventArgs e)
    {
      if (radAddition.Checked)
      {
        strMode = "ADDITION";
        lblOperator.Text = "+";
        lblHighScore.Text = intAddHighScore.ToString();
      }
      else
      {
        strMode = "MULTIPLICATION";
        lblOperator.Text = "X";
        lblHighScore.Text = intMultHighScore.ToString();
      }
    }



    /***** NOT USED *****/

    private void label1_Click(object sender, EventArgs e){}
    private void txtAnswer_TextChanged(object sender, EventArgs e){}

    /********************/

  }
}
