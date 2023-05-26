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
        int secondsCounting = 0;
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
            ScrambledWordBox.Text = currentWord.WordScramble;
            originalPointValue = currentWord.AttemptPoints;
            pointsLabel.Text = currentPoints.ToString();
            levelLabel.Text = $"Difficulty:{currentWord.Difficulty}";
            numberOfTries = currentWord.NumberOfTries;
            // end initialize all
        }
        private void button1_Click(object sender, EventArgs e) //winform event
        {
            secondsCounting = 0;
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
            }
            pointsLabel.Text = currentPoints.ToString();

        }
        void HandleNextWord()// to increment through the word in the list
        {
            if (currentWordIndex < wordList.Count - 1)// -1 keeps us inside the index range
            {
                currentWordIndex++;
                currentWord = wordList[currentWordIndex];
                ScrambledWordBox.Text = currentWord.WordScramble;
                levelLabel.Text = $"Difficulty:{currentWord.Difficulty}";
                correctAnswer = currentWord.Word;
                originalPointValue = currentWord.AttemptPoints;
                secondsCounting = 0;
                
            }
            else
            {
                ScrambledWordBox.Text = "You Win The Game";
                DescriptionLabel.Text = "Congradulations";
            }
        }
        // display the Definition
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsCounting++;
            if (secondsCounting == 45)
            {
                currentPoints = currentPoints - (originalPointValue * 0.5f);
                secondsCounting = 0;
            }
            

                timerLabel.Text = secondsCounting.ToString();
        }



        // if lifeCOunter = 0   game over

    }
}