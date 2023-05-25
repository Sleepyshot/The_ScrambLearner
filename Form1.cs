using System.Diagnostics.Tracing;
using System.Text.Json;

namespace The_ScrambLearner
{
    public partial class Form1 : Form
    {

        string jsonData = File.ReadAllText("WordList.json"); // we are reading the json from our project
        string correctAnswer;
        bool isCorrectAnswer = false;
        int currentWordIndex = 0;
        float currentPoints = 0;
        float originalPointValue;
        ScrambledWord currentWord;
        List<ScrambledWord> wordList;

        public Form1()
        {
            // start initialize all 
            wordList = JsonSerializer.Deserialize<List<ScrambledWord>>(jsonData); // we are parsing the json to the properties of a list of objects
            InitializeComponent();// designer
            currentWord = wordList[currentWordIndex];
            correctAnswer = currentWord.Word;
            ScrambledWordBox.Text = currentWord.WordScramble;
            originalPointValue = currentWord.AttemptPoints;
            // end initialize all
        }


        private void button1_Click(object sender, EventArgs e) //winform event
        {
            
            if (textBoxReply.Text == correctAnswer)
            {
                
                isCorrectAnswer = true;
                textBoxReply.Text = "";// fresh replybox after correct answer
                IncorrectLable.Text = "";// clear incorrect lable
                currentPoints +=  currentWord.AttemptPoints;
                


                HandleNextWord();
            }
            else if (textBoxReply.Text != correctAnswer)
            {
                IncorrectLable.Text = "Incorrect";
                // deduct points from word
                originalPointValue = currentWord.AttemptPoints;
                currentWord.AttemptPoints = currentWord.AttemptPoints  - (originalPointValue * 0.5f);// we are subtracting 50% from the word
                
            }

            progressBar1.Value = ((int)currentPoints);
        }

        void HandleNextWord()// to increment through the word in the list
        {
            if (currentWordIndex < wordList.Count - 1)// -1 keeps us inside the index range
            {
                currentWordIndex++;
                currentWord = wordList[currentWordIndex];
                ScrambledWordBox.Text = currentWord.WordScramble;
                correctAnswer = currentWord.Word;
                currentWord.AttemptPoints = originalPointValue;


            }
            else
            {
                ScrambledWordBox.Text = "You Win The Game"; // show points
                DescriptionLabel.Text = "Congradulations";
            }
        }


        // correct answer moves on and add points of current value to the progress bar
        // if playerResponse = answer
        // Gain Attempt points
        // display the Definition
        // Incriment the word list to provide a new word

        // if playerResponse != answer
        // Decrement the attemptPoints 
        // Decrement numberOfTries
        // If numberOfTries = 0 
        // decrement lifeCounter
        // start next word

        // if lifeCOunter = 0   game over

    }
}