namespace MultiplicationDrill
{
  partial class frmMultGame
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultGame));
      this.btnStart = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.txtAnswer = new System.Windows.Forms.TextBox();
      this.lblFirstNum = new System.Windows.Forms.Label();
      this.lblOperator = new System.Windows.Forms.Label();
      this.lblSecNum = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.grpScoreArea = new System.Windows.Forms.GroupBox();
      this.lblPercent = new System.Windows.Forms.Label();
      this.lblCorrect = new System.Windows.Forms.Label();
      this.lblIncorrect = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.pctSmiley = new System.Windows.Forms.PictureBox();
      this.pctFrown = new System.Windows.Forms.PictureBox();
      this.lblScoreLabel = new System.Windows.Forms.Label();
      this.lblHighScore = new System.Windows.Forms.Label();
      this.radMultiplication = new System.Windows.Forms.RadioButton();
      this.radAddition = new System.Windows.Forms.RadioButton();
      this.grpScoreArea.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctSmiley)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctFrown)).BeginInit();
      this.SuspendLayout();
      // 
      // btnStart
      // 
      this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
      this.btnStart.Location = new System.Drawing.Point(234, 34);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 27);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "&Start";
      this.btnStart.UseVisualStyleBackColor = false;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(234, 226);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(77, 27);
      this.btnExit.TabIndex = 1;
      this.btnExit.Text = "E&xit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // txtAnswer
      // 
      this.txtAnswer.Enabled = false;
      this.txtAnswer.Location = new System.Drawing.Point(155, 38);
      this.txtAnswer.Name = "txtAnswer";
      this.txtAnswer.Size = new System.Drawing.Size(65, 20);
      this.txtAnswer.TabIndex = 2;
      this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
      this.txtAnswer.Leave += new System.EventHandler(this.txtAnswer_Leave);
      // 
      // lblFirstNum
      // 
      this.lblFirstNum.AutoSize = true;
      this.lblFirstNum.Location = new System.Drawing.Point(36, 41);
      this.lblFirstNum.Name = "lblFirstNum";
      this.lblFirstNum.Size = new System.Drawing.Size(13, 13);
      this.lblFirstNum.TabIndex = 3;
      this.lblFirstNum.Text = "?";
      // 
      // lblOperator
      // 
      this.lblOperator.AutoSize = true;
      this.lblOperator.Location = new System.Drawing.Point(70, 41);
      this.lblOperator.Name = "lblOperator";
      this.lblOperator.Size = new System.Drawing.Size(14, 13);
      this.lblOperator.TabIndex = 4;
      this.lblOperator.Text = "X";
      // 
      // lblSecNum
      // 
      this.lblSecNum.AutoSize = true;
      this.lblSecNum.Location = new System.Drawing.Point(105, 41);
      this.lblSecNum.Name = "lblSecNum";
      this.lblSecNum.Size = new System.Drawing.Size(13, 13);
      this.lblSecNum.TabIndex = 5;
      this.lblSecNum.Text = "?";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(136, 41);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(13, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "=";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(289, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "_______________________________________________";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // grpScoreArea
      // 
      this.grpScoreArea.BackColor = System.Drawing.SystemColors.ControlLight;
      this.grpScoreArea.Controls.Add(this.lblPercent);
      this.grpScoreArea.Controls.Add(this.lblCorrect);
      this.grpScoreArea.Controls.Add(this.lblIncorrect);
      this.grpScoreArea.Controls.Add(this.label7);
      this.grpScoreArea.Controls.Add(this.label6);
      this.grpScoreArea.Controls.Add(this.label3);
      this.grpScoreArea.Controls.Add(this.label5);
      this.grpScoreArea.Location = new System.Drawing.Point(39, 105);
      this.grpScoreArea.Name = "grpScoreArea";
      this.grpScoreArea.Size = new System.Drawing.Size(181, 148);
      this.grpScoreArea.TabIndex = 8;
      this.grpScoreArea.TabStop = false;
      // 
      // lblPercent
      // 
      this.lblPercent.AutoSize = true;
      this.lblPercent.Location = new System.Drawing.Point(125, 96);
      this.lblPercent.Name = "lblPercent";
      this.lblPercent.Size = new System.Drawing.Size(13, 13);
      this.lblPercent.TabIndex = 13;
      this.lblPercent.Text = "?";
      // 
      // lblCorrect
      // 
      this.lblCorrect.AutoSize = true;
      this.lblCorrect.Location = new System.Drawing.Point(125, 38);
      this.lblCorrect.Name = "lblCorrect";
      this.lblCorrect.Size = new System.Drawing.Size(13, 13);
      this.lblCorrect.TabIndex = 9;
      this.lblCorrect.Text = "?";
      // 
      // lblIncorrect
      // 
      this.lblIncorrect.AutoSize = true;
      this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
      this.lblIncorrect.Location = new System.Drawing.Point(125, 61);
      this.lblIncorrect.Name = "lblIncorrect";
      this.lblIncorrect.Size = new System.Drawing.Size(13, 13);
      this.lblIncorrect.TabIndex = 10;
      this.lblIncorrect.Text = "?";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(18, 74);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(145, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "_______________________";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(18, 96);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(44, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Percent";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 38);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Correct";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 61);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(49, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Incorrect";
      // 
      // timer1
      // 
      this.timer1.Interval = 60000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // pctSmiley
      // 
      this.pctSmiley.Image = global::MultiplicationDrill.Properties.Resources.smiley;
      this.pctSmiley.Location = new System.Drawing.Point(245, 105);
      this.pctSmiley.Name = "pctSmiley";
      this.pctSmiley.Size = new System.Drawing.Size(75, 66);
      this.pctSmiley.TabIndex = 9;
      this.pctSmiley.TabStop = false;
      this.pctSmiley.Visible = false;
      // 
      // pctFrown
      // 
      this.pctFrown.Image = global::MultiplicationDrill.Properties.Resources.frown;
      this.pctFrown.Location = new System.Drawing.Point(245, 105);
      this.pctFrown.Name = "pctFrown";
      this.pctFrown.Size = new System.Drawing.Size(75, 66);
      this.pctFrown.TabIndex = 10;
      this.pctFrown.TabStop = false;
      this.pctFrown.Visible = false;
      // 
      // lblScoreLabel
      // 
      this.lblScoreLabel.AutoSize = true;
      this.lblScoreLabel.Location = new System.Drawing.Point(36, 89);
      this.lblScoreLabel.Name = "lblScoreLabel";
      this.lblScoreLabel.Size = new System.Drawing.Size(60, 13);
      this.lblScoreLabel.TabIndex = 11;
      this.lblScoreLabel.Text = "High Score";
      // 
      // lblHighScore
      // 
      this.lblHighScore.AutoSize = true;
      this.lblHighScore.Location = new System.Drawing.Point(105, 89);
      this.lblHighScore.Name = "lblHighScore";
      this.lblHighScore.Size = new System.Drawing.Size(13, 13);
      this.lblHighScore.TabIndex = 12;
      this.lblHighScore.Text = "0";
      // 
      // radMultiplication
      // 
      this.radMultiplication.Appearance = System.Windows.Forms.Appearance.Button;
      this.radMultiplication.AutoSize = true;
      this.radMultiplication.Checked = true;
      this.radMultiplication.Location = new System.Drawing.Point(234, 169);
      this.radMultiplication.Name = "radMultiplication";
      this.radMultiplication.Size = new System.Drawing.Size(78, 23);
      this.radMultiplication.TabIndex = 13;
      this.radMultiplication.TabStop = true;
      this.radMultiplication.Text = "&Multiplication";
      this.radMultiplication.UseVisualStyleBackColor = true;
      this.radMultiplication.CheckedChanged += new System.EventHandler(this.radMultiplication_CheckedChanged);
      // 
      // radAddition
      // 
      this.radAddition.Appearance = System.Windows.Forms.Appearance.Button;
      this.radAddition.AutoSize = true;
      this.radAddition.Location = new System.Drawing.Point(233, 196);
      this.radAddition.Name = "radAddition";
      this.radAddition.Size = new System.Drawing.Size(79, 23);
      this.radAddition.TabIndex = 14;
      this.radAddition.Text = "     &Addition   ";
      this.radAddition.UseVisualStyleBackColor = true;
      this.radAddition.CheckedChanged += new System.EventHandler(this.radAddition_CheckedChanged);
      // 
      // frmMultGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.ClientSize = new System.Drawing.Size(329, 275);
      this.Controls.Add(this.radAddition);
      this.Controls.Add(this.radMultiplication);
      this.Controls.Add(this.lblHighScore);
      this.Controls.Add(this.lblScoreLabel);
      this.Controls.Add(this.pctFrown);
      this.Controls.Add(this.pctSmiley);
      this.Controls.Add(this.grpScoreArea);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lblSecNum);
      this.Controls.Add(this.lblOperator);
      this.Controls.Add(this.lblFirstNum);
      this.Controls.Add(this.txtAnswer);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnStart);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "frmMultGame";
      this.Text = "Multiplication Drill";
      this.grpScoreArea.ResumeLayout(false);
      this.grpScoreArea.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pctSmiley)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pctFrown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TextBox txtAnswer;
    private System.Windows.Forms.Label lblFirstNum;
    private System.Windows.Forms.Label lblOperator;
    private System.Windows.Forms.Label lblSecNum;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox grpScoreArea;
    private System.Windows.Forms.Label lblPercent;
    private System.Windows.Forms.Label lblCorrect;
    private System.Windows.Forms.Label lblIncorrect;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.PictureBox pctSmiley;
    private System.Windows.Forms.PictureBox pctFrown;
    private System.Windows.Forms.Label lblScoreLabel;
    private System.Windows.Forms.Label lblHighScore;
    private System.Windows.Forms.RadioButton radMultiplication;
    private System.Windows.Forms.RadioButton radAddition;
  }
}

