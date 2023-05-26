using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Text.Json;
using Timer = System.Windows.Forms.Timer;

namespace The_ScrambLearner
{
    public partial class Form1 : Form
    {

        string jsonData = File.ReadAllText("WordList.json"); // we are reading the json from our project
        string correctAnswer;
        int currentWordIndex = 0;
        int secondsCounting = 45;
        int lifeCounter = 3;
        int numberOfTries;
        float currentPoints = 0;
        float originalPointValue;
        ScrambledWord currentWord;
        List<ScrambledWord> wordList;
        private Timer timer;


        public Form1()
        {
            // start initialize all 
            wordList = JsonSerializer.Deserialize<List<ScrambledWord>>(jsonData); // we are parsing the json to the properties of a list of objects
            InitializeComponent();// designer
            // TIMER
            timer = new Timer();
            timer.Interval = 1000; // Interval set to 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            //TIMER
            currentWord = wordList[currentWordIndex];
            correctAnswer = currentWord.Word;
            scrambledWordLabel.Text = currentWord.WordScramble;
            originalPointValue = currentWord.AttemptPoints;
            pointsLabel.Text = currentPoints.ToString();
            levelLabel.Text = $"Difficulty:{currentWord.Difficulty}";
            numberOfTries = currentWord.NumberOfTries;
            attemptsLabel.Text = $"Attempts:{numberOfTries.ToString()}";
            livesLabel.Text = lifeCounter.ToString();
            // end initialize all
        }
        private void button1_Click(object sender, EventArgs e) //winform event
        {
            secondsCounting = 45;
            if (textBoxReply.Text == correctAnswer)
            {
                textBoxReply.Text = "";// fresh replybox after correct answer
                IncorrectLable.Text = "";// clear incorrect lable
                currentPoints += currentWord.AttemptPoints;

                HandleNextWord();
            }
            else if (textBoxReply.Text != correctAnswer)
            {
                IncorrectLable.Text = "Incorrect";
                // deduct points from word
                currentPoints = currentPoints - (originalPointValue * 0.5f);// we are subtracting 50% from the word
                numberOfTries--;
               
            }
            pointsLabel.Text = currentPoints.ToString();
            attemptsLabel.Text = $"Attempts:{numberOfTries.ToString()}";
            livesLabel.Text = lifeCounter.ToString();

        }
        void HandleNextWord()// to increment through the word in the list
        {
            if (currentWordIndex < wordList.Count - 1)// -1 keeps us inside the index range
            {
                currentWordIndex++;
                currentWord = wordList[currentWordIndex];
                scrambledWordLabel.Text = currentWord.WordScramble;
                levelLabel.Text = $"Difficulty:{currentWord.Difficulty}";
                correctAnswer = currentWord.Word;
                originalPointValue = currentWord.AttemptPoints;
                secondsCounting = 45;
                numberOfTries = 3;
            }
            else
            {
                scrambledWordLabel.Text = "Game Over";
                DescriptionLabel.Text = "Check out how many points you gained";
            }
        }
        // display the Definition
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsCounting--;
            if (secondsCounting == 0)
            {
                currentPoints = currentPoints - (originalPointValue * 0.5f);
                secondsCounting = 45;
                numberOfTries--;  
            }
            if (numberOfTries == 0)
            {
                lifeCounter--;
                HandleNextWord();
            }
            if (lifeCounter == 0)
            {
                scrambledWordLabel.Text = "You have ran out of lives";
                timer.Stop();
            }

            attemptsLabel.Text = $"Attempts:{numberOfTries.ToString()}";
            timerLabel.Text = secondsCounting.ToString();
            livesLabel.Text = lifeCounter.ToString();
        }
        
       


        // if lifeCOunter = 0   game over

    }
}