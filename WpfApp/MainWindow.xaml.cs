using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StartPage.Visibility = Visibility.Visible;
            QuizPage.Visibility = Visibility.Collapsed;

            Questions = new List<Question>
            {
                new Question
                {
                    Text = "Choose incorrect statement about program execution on modern computers: ",
                    FirstAnswer = "All program data is stored in binary form ",
                    SecondAnswer = "User applications don't need any additional software components and can be executed directly on the hardware ",
                    ThirdAnswer = "Program logic is stored in the same memory as the program data ",
                    CorrectAnswer = 2,
                    Topic = "Introduction"
                },
                new Question
                {
                    Text = "Python is a ... language : ",
                    FirstAnswer = "general purpose ",
                    SecondAnswer = "specific purpose ",
                    ThirdAnswer = "low level ",
                    CorrectAnswer = 1,
                    Topic = "Introduction"
                },
                new Question
                {
                    Text = "Which of the following statement evaluates to True if a variable called number is outside of the interval [-10;10]? ",
                    FirstAnswer = "number < 10 and number > -10 ",
                    SecondAnswer = "not (number < -10 or number > 10) ",
                    ThirdAnswer = "not (number >= -10 and number <= 10) ",
                    CorrectAnswer = 3,
                    Topic = "Boolean expressions "
                },
                new Question
                {
                    Text = "result = x ??? y . x and y are both integers. With which of the following operators put instead of ??? the result variable gets a value of a different type (not int)? ",
                    FirstAnswer = "+",
                    SecondAnswer = ">",
                    ThirdAnswer = "**",
                    CorrectAnswer = 2,
                    Topic ="Variables "
                },
                new Question
                {
                    Text = "Which statement  is incorrect regarding the if-elif-else blocks in Python? ",
                    FirstAnswer = "The if line finishes with a colon (:) ",
                    SecondAnswer = "The else line finishes with a colon (:) ",
                    ThirdAnswer = "The else clause is obligatory ",
                    CorrectAnswer = 3,
                    Topic = "Loops"
                },
                new Question
                {
                    Text = "Which of the following statements about the while loop is incorrect? ",
                    FirstAnswer = "In Python it can be used as both a pre-condition and a post-condition loop ",
                    SecondAnswer = "The inner block (after the first line) has to be always indented ",
                    ThirdAnswer = "Its body is always executed at least once ",
                    CorrectAnswer = 3,
                    Topic = "Loops"
                },
                new Question
                {
                    Text = "Which of the following statement is correct regarding functions and their usage in Python ",
                    FirstAnswer = "A function is defined only once but can be called multiple times ",
                    SecondAnswer = "For each call of the same function there has to be a separate function definition ",
                    ThirdAnswer = "A function can have only one parameter ",
                    CorrectAnswer = 1,
                    Topic = "Functions"
                },
                new Question
                {
                    Text = "Which statement is incorrect about the Python list type? ",
                    FirstAnswer = "It can store values of mixed types ",
                    SecondAnswer = "It is efficient for all possible operations on its data ",
                    ThirdAnswer = "It resizes itself automatically as values are added or removed ",
                    CorrectAnswer = 2,
                    Topic = "Collections"
                },
                new Question
                {
                    Text = "Which of the data structures aims at the efficient implementation of two operations at the same time: 1. Get the element with the highest priority 2. Add a new item",
                    FirstAnswer = "list",
                    SecondAnswer = "binary heap",
                    ThirdAnswer = "set",
                    CorrectAnswer = 2,
                    Topic = "Collections"
                },
                new Question
                {
                    Text = "BLbllbls",
                    FirstAnswer = "adf DLS:KFJ",
                    SecondAnswer = "adf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllbls",
                    FirstAnswer = "adf DDLSLS:KFJ",
                    SecondAnswer = "adDLSDLSf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllbls",
                    FirstAnswer = "adf DDLSDLSDLSLS:KFJ",
                    SecondAnswer = "adDLSf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllDLSDLSbls",
                    FirstAnswer = "adf DLS:KFJ",
                    SecondAnswer = "adf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFDLSDLSDLSDLSJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllbDLS DLSDLS bDLSDLSDLS ls",
                    FirstAnswer = "adf DLS:KFJ",
                    SecondAnswer = "adf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllbls",
                    FirstAnswer = "adf DDLSLS:KFJ",
                    SecondAnswer = "adDLSDLSf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllbls",
                    FirstAnswer = "adf DDLSDLSDLSLS:KFJ",
                    SecondAnswer = "adDLSf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllDLSDLSbls",
                    FirstAnswer = "adf DLS:KFJ",
                    SecondAnswer = "adf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFDLSDLSDLSDLSJ",
                    CorrectAnswer = 2
                },
                new Question
                {
                    Text = "BLbllbDLS DLSDLS bDLSDLSDLS ls",
                    FirstAnswer = "adf DLS:KFJ",
                    SecondAnswer = "adf DLS:KFJ",
                    ThirdAnswer = "adf DLS:KFJ",
                    CorrectAnswer = 2
                },
            };

            Items = new List<Border>
            {
                QuizBorder1,
                QuizBorder2,
                QuizBorder3,
                QuizBorder4,
                QuizBorder5,
                QuizBorder6,
                QuizBorder7,
                QuizBorder8,
                QuizBorder9,
                QuizBorder10,
                QuizBorder11,
                QuizBorder12,
                QuizBorder13,
                QuizBorder14,
                QuizBorder15,
                QuizBorder16,
                QuizBorder17,
                QuizBorder18,
                QuizBorder19,
                QuizBorder20,
                QuizBorder21,
                QuizBorder22,
                QuizBorder23,
                QuizBorder24,
                QuizBorder25,
                QuizBorder26,
                QuizBorder27,
                QuizBorder28,
                QuizBorder29,
                QuizBorder30,
                QuizBorder31,
                QuizBorder32,
                QuizBorder33,
                QuizBorder34,
                QuizBorder35,
                QuizBorder36,
            };
        }

        private int _correctPython = 0;
        private int _correctCSharp = 0;

        public int CurrentIndex { get; set; }

        public List<Question> Questions { get; set; }
        public List<Border> Items { get; set; }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            InitStart();

            SetupQuiz(0);
        }

        private void InitStart()
        {
            _correctPython = 0;
            _correctCSharp = 0;
            CurrentIndex = 0;
            StartPage.Visibility = Visibility.Collapsed;
            QuizPage.Visibility = Visibility.Visible;
            StartBorder.Style = null;
        }

        private void SetupQuiz(int index)
        {
            Items[CurrentIndex].Style = null;
            CurrentIndex = index;

            QuizTitle.Text = $"QUIZ #{index + 1}. Topic: #{Questions[index].Topic}";

            var current = Questions[index];
            QuestionBlock.Text = current.Text;
            FirstAnswer.Content = current.FirstAnswer;
            SecondAnswer.Content = current.SecondAnswer;
            ThirdAnswer.Content = current.ThirdAnswer;

            FirstAnswer.IsChecked = false;
            SecondAnswer.IsChecked = false;
            ThirdAnswer.IsChecked = false;

            Items[index].Style = FindResource("Highlighted") as Style;
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var answer = GetSelectedAnswer();

            if (answer < 0)
                return;

            var current = Questions[CurrentIndex];
            if (answer == current.CorrectAnswer)
            {
                if (CurrentIndex < 18)
                {
                    _correctPython++;
                }
                else
                {
                    _correctCSharp++;
                }
            }

            if (CurrentIndex == 8)
            {
                // todo: go to middle python page
            }
            else if (CurrentIndex == 17)
            {
                // todo: calc total python and go to total page or to start
            }
            else if (CurrentIndex == 26)
            {
                // todo: go to middle c#
            }
            else if (CurrentIndex == 35)
            {
                // todo: calc total c# and go to total page or to start
            }
            else
            {
                SetupQuiz(CurrentIndex + 1);
            }
        }

        private int GetSelectedAnswer()
        {
            if (FirstAnswer.IsChecked.HasValue && FirstAnswer.IsChecked.Value)
                return 1;

            if (SecondAnswer.IsChecked.HasValue && SecondAnswer.IsChecked.Value)
                return 2;

            if (ThirdAnswer.IsChecked.HasValue && ThirdAnswer.IsChecked.Value)
                return 3;

            return -1;
        }
    }
}
