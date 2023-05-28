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
        ScrambledWord lastWord;
        List<ScrambledWord> wordList;
        private Timer timer;
        Random random = new Random();



        public Form1()
        {
            // start initialize all
            wordList = JsonSerializer.Deserialize<List<ScrambledWord>>(jsonData); // we are parsing the json to the properties of a list of objects
            InitializeComponent();// designer
            // TIMER
            timer = new Timer();
            timer.Interval = 1000; // Interval set to 1 second
            timer.Tick += Timer_Tick;  
            //TIMER
            currentWord = wordList[0];
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
                
                 
                int randomNumber = -1;
                ScrambledWord newWord = null;

            while(newWord == null) 
            {
                if (currentPoints <= 250)
            {
            randomNumber = random.Next(1, 51);
            }
            else if (currentPoints > 250 && currentPoints <= 500)
            {
                randomNumber = random.Next(51, 101);
            }
                    // will add below when list is complete
                    /*
                   else if (currentPoints > 500 && currentPoints <= 750)
                   {
                       randomNumber = random.Next(101, 151);
                   }
                   else if (currentPoints > 750 && currentPoints <= 1000)
                   {
                       randomNumber = random.Next(151, 201);
                   }*/

                    // Check if the selected word has been used before
                    if (randomNumber != -1 && !wordList[randomNumber].HasBeenUsed)
            {
                newWord = wordList[randomNumber];
            }
        }

            // Now we have a new word
             currentWord = newWord;
             currentWord.HasBeenUsed = true;
                 
                 



              //  currentWordIndex++;// remove when the random word selector is active
             //   currentWord = wordList[currentWordIndex];// remove as well
                scrambledWordLabel.Text = currentWord.WordScramble;
                levelLabel.Text = $"Difficulty:{currentWord.Difficulty}";
                correctAnswer = currentWord.Word;
                originalPointValue = currentWord.AttemptPoints;
                secondsCounting = 45;
                numberOfTries = 3;

                infoTextBox.Text = currentWord.Definition.ToString();
            
                timer.Start();
            }
            else
            {
                scrambledWordLabel.Text = "Out of Words";
                DescriptionLabel.Text = "Check out how many points you gained";
                timer.Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            

            secondsCounting--;
            if (secondsCounting == 0)
            {
                currentPoints = currentPoints - (originalPointValue * 0.5f);
                secondsCounting = 45;
                numberOfTries--;
            }
            if (numberOfTries <= 0)
            {
                lifeCounter--;
                HandleNextWord();
            }
            if (lifeCounter == 0)
            {
                scrambledWordLabel.Text = "You have run out of lives";
                timer.Stop();
            }
            attemptsLabel.Text = $"Attempts:{numberOfTries.ToString()}";
            timerLabel.Text = secondsCounting.ToString();
            livesLabel.Text = lifeCounter.ToString();
            
        }
    }
}