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
                    Text = "Which of the data structures aims at the efficient implementation of two operations at the same time: Get the element with the highest priority + Add a new item ",
                    FirstAnswer = "list",
                    SecondAnswer = "binary heap",
                    ThirdAnswer = "set ",
                    CorrectAnswer = 2,
                    Topic = "Collections"
                },
                new Question
                {
                    Text = "How can list mutability be proved? ",
                    FirstAnswer = "Calling append, remove or pop changes the original list ",
                    SecondAnswer = "It is possible to get an element by its index ",
                    ThirdAnswer = "Most of the list functions accept at least one parameter ",
                    CorrectAnswer = 1,
                    Topic = "Mutability"
                },
                 new Question
                {
                    Text = "Mutability of objects in programming means: ",
                    FirstAnswer = "Ability to change contents of an object in-place ",
                    SecondAnswer = "Ability to change the type of a variable ",
                    ThirdAnswer = "Ability to return a value from a function ",
                    CorrectAnswer = 1,
                    Topic = "Mutability"
                },
                  new Question
                {
                    Text = "Which statement is correct about the Python list type? ",
                    FirstAnswer = "It is an immutable type ",
                    SecondAnswer = "It can store values of mixed types ",
                    ThirdAnswer = "It is efficient for all possible operations on its data ",
                    CorrectAnswer = 2,
                    Topic = "Lists"
                },
                  new Question
                {
                    Text = "What is the main disadvantage of a set? ",
                    FirstAnswer = "Slow item insertion ",
                    SecondAnswer = "Slow item removal   ",
                    ThirdAnswer = "Absence of indexing ",
                    CorrectAnswer = 1,
                    Topic = "Sets"
                },
                  new Question
                {
                    Text = "What is the complexity of finding the minimum value of a square nxn matrix? ",
                    FirstAnswer = "O(logn) ",
                    SecondAnswer = "O(n) ",
                    ThirdAnswer = "O(n^2) ",
                    CorrectAnswer = 3,
                    Topic = "Sorting algorithms"
                },
                  new Question
                {
                    Text = "Amortized complexity of an algorithm is:",
                    FirstAnswer = "Complexity taking the worst-case scenario",
                    SecondAnswer = "Complexity averaged over a series of operations ",
                    ThirdAnswer = "Complexity taking the average between the best and worst case scenarios ",
                    CorrectAnswer = 2,
                    Topic = "Amortized complexity"
                },
                  new Question
                {
                    Text = "Which of the following is NOT true regarding a text file (from the programmatic point of view)?",
                    FirstAnswer = "It can be opened with any text editor that supports the given encoding ",
                    SecondAnswer = "It contains codes of symbols in a certain encoding ",
                    ThirdAnswer = "It always has the .txt extension ",
                    CorrectAnswer = 3,
                    Topic = "Files"
                },
                  new Question
                {
                    Text = "What is the purpose of the with block in Python file input-output? with open('data.txt', 'r' ) as f:",
                    FirstAnswer = "It ensures that the file is always closed at the end ",
                    SecondAnswer = "It catches all possible errors of file IO (missing file, incorrect format, etc.) ",
                    ThirdAnswer = "It improves performance of file input-output ",
                    CorrectAnswer = 1,
                    Topic = "Files"
                },
                  new Question
                {
                    Text = "What is common among the following file formats: CSV, JSON, XML?",
                    FirstAnswer = "They are binary formats",
                    SecondAnswer = "They are text formats ",
                    ThirdAnswer = "They are human-oriented formats with both information and its presentation details",
                    CorrectAnswer = 2,
                    Topic = "Files"
                },
                  new Question
                {
                    Text = "What is the difference between ref and out parameters of C# methods?",
FirstAnswer = "The ref parameter is passed by reference, out is passed by value ",
SecondAnswer = "The ref parameter is passed by value, out is passed by reference",
ThirdAnswer = "The out parameter has to be assigned within a method, the ref parameter can remain unchanged",
CorrectAnswer = 3,
Topic = "Parameters"
                },
                new Question
                {
                    Text = "What is a namespace?",
FirstAnswer = "A type that contains code of the program?",
SecondAnswer = "A container for classes?",
ThirdAnswer = "A deployable unit of an application?",
CorrectAnswer = 2,
Topic = "Fundamentals"
                },
                new Question
                {
                    Text = "The type long in C# is equivalent to which type in .NET framework?",
FirstAnswer = "Long",
SecondAnswer = "Int32",
ThirdAnswer = "Int64",
CorrectAnswer = 3,
Topic = "Primitive Types"
                },
                new Question
                {
                    Text = "What is the correct way to declare an int array?",
FirstAnswer = "int numbers = new int[];",
SecondAnswer = "int[] numbers = new int[]; ",
ThirdAnswer = "int[] numbers = new int[3]; ",
CorrectAnswer = 3,
Topic = "Non-primitive types"
                },
                new Question
                {
                    Text = "How can we access the first element in this array “var numbers = new int[3] { 1, 2, 3 };”? ",
FirstAnswer = "Numbers.First ",
SecondAnswer = "Numbers(0) ",
ThirdAnswer = "Numbers[0] ",
CorrectAnswer = 3,
Topic = "Non-primitive types"
                },
                new Question
                {
                    Text = "The escape character in a string represents:",
FirstAnswer = "A whitespace ",
SecondAnswer = "A line-break ",
ThirdAnswer = "A tab ",
CorrectAnswer = 2,
Topic = "Non-primitive types"
                },
                new Question
                {
                    Text = "What is the correct syntax to declare a rectangular 3x5 array?",
FirstAnswer = "var array = new int[3, 5]; ",
SecondAnswer = "var array = new int[3][5]; ",
ThirdAnswer = "var array = new int[](3, 5); ",
CorrectAnswer = 1,
Topic = "Arrays"
                },
                new Question
                {
                    Text = "What is the difference between arrays and lists? ",
FirstAnswer = "Arrays are faster than lists. ",
SecondAnswer = "There is no difference. Both can be used to store a sequence of objects. ",
ThirdAnswer = "Arrays are fixed in size, lists are dynamic. More items can be added later. ",
CorrectAnswer = 3,
Topic = "Arrays and lists "
                },
                new Question
                {
                    Text = "How can access the last element in a list?",
FirstAnswer = "list.Last ",
SecondAnswer = "list.LastIndexOf() ",
ThirdAnswer = "list[list.Count - 1] ",
CorrectAnswer = 3,
Topic = "Lists"
                },
                new Question
                {
                    Text = "Which of the following can be stored on the stack only? ",
FirstAnswer = "method return points ",
SecondAnswer = "contents of value types ",
ThirdAnswer = "content of objects ",
CorrectAnswer = 1,
Topic = "Stacks"
                },
                 new Question
                {
                    Text = "What is the disadvantage of a dictionary compared to a list? ",
FirstAnswer = "No possibility of getting items by key ",
SecondAnswer = "Slow item removal ",
ThirdAnswer = "Absence of indexing ",
CorrectAnswer = 3,
Topic = "Collections"
                },
                  new Question
                {
                    Text = "How can we get the current date/time? ",
FirstAnswer = "new DateTime() ",
SecondAnswer = "DateTime.Now ",
ThirdAnswer = "DateTime.Current ",
CorrectAnswer = 2,
Topic = "Dates"
                },
                  new Question
                {
                    Text = "Select the best way to create a TimeSpan object to represent 1 hour?",
FirstAnswer = "DateTime.Now.AddHours(1) - DateTime.Now ",
SecondAnswer = "new TimeSpan(1, 0, 0) ",
ThirdAnswer = "TimeSpan.FromHours(1) ",
CorrectAnswer = 3,
Topic = "Dates and Times"
                },
                  new Question
                {
                    Text = "What is common between the string and the DateTime types in .NET?",
FirstAnswer = "Both produce immutable objects",
SecondAnswer = "Both are value types ",
ThirdAnswer = "Both are reference types ",
CorrectAnswer = 1,
Topic = "DateTime and strings"
                },
                  new Question
                {
                   Text = "How can we delete a file in C#? ",
FirstAnswer = "FileInfo.Delete(path); ",
SecondAnswer = "File.Delete(path) ",
ThirdAnswer = "new FileInfo().Delete(path) ",
CorrectAnswer = 2,
Topic = "Files"
                },
                  new Question
                {
                    Text = "Which of the following is the default access specifier of a class member function?",
FirstAnswer = "Private ",
SecondAnswer = "Public",
ThirdAnswer = "Protected",
CorrectAnswer = 1,
Topic = "Access"
                },
                  new Question
                {
                    Text = "Which of the following is correct about nullable types in C#? ",
FirstAnswer = "C# provides a special data types, the nullable types, to which you can assign normal range of values as well as null values ",
SecondAnswer = "You can assign true, false, or null in a Nullable<bool> variable ",
ThirdAnswer = "All of the above ",
CorrectAnswer = 3,
Topic = "Nullable types"
                },
                  new Question
                  {
                      Text = "Which of the following cannot be used to declare an interface correctly? ",
FirstAnswer = "Properties",
SecondAnswer = "Methods",
ThirdAnswer = "Structures",
CorrectAnswer = 3,
Topic = "Interfaces"
                  }


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
                QuizBorder19,
                QuizBorder20,
                QuizBorder21,       
                QuizBorder18,
                QuizBorder19,
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
            if (CurrentIndex == 8 | CurrentIndex == 26)
            {
                StartPage.Visibility = Visibility.Collapsed;
                QuizPage.Visibility = Visibility.Visible;
                SetupQuiz(CurrentIndex + 1);
            }

            if (CurrentIndex == 17)
            {
                CurrentIndex += 1;
                StartPage.Visibility = Visibility.Collapsed;
                QuizPage.Visibility = Visibility.Visible;
                SetupQuiz(18);
            }
            if (CurrentIndex == 100)
            {
                _correctCSharp = 0;
                CurrentIndex = 18;
                StartPage.Visibility = Visibility.Collapsed;
                QuizPage.Visibility = Visibility.Visible;
                SetupQuiz(18);
            }

            if (CurrentIndex == 0)
            {
                InitStart();
                SetupQuiz(0); 
            }


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

            QuizTitle.Text = $"QUIZ №{index + 1}. Topic: {Questions[index].Topic}";

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

        private void MiddleGrade(int points)
        {
            Items[CurrentIndex].Style = null;
            if (CurrentIndex == 8)
            StartTEST.Text = "Midterm Grade for Python";
            else
                StartTEST.Text = "Midterm Grade for C#";
            if (points == 8 | points == 9)
                StartContent.Text = $"Well Done! You have {points} points! Succes: {points * 100 / 9} % ";
            if (points == 6 | points == 7)
                StartContent.Text = $"Good! You have {points} points. Succes: {points * 100 / 9} % ";
            if (points == 4 | points == 5)
                StartContent.Text = $"Of course it's OK, but let's try harder! You have {points} points. Succes: {points * 100 / 9} % ";
            if (points == 1 | points == 2 | points == 3 | points == 0)
                StartContent.Text = $"Try harder otherwise you'll get ICRC! You have {points} points. Succes: {points * 100 / 9} % ";
            StartButton.Content = "Continue";
            StartPage.Visibility = Visibility.Visible;
            QuizPage.Visibility = Visibility.Collapsed;
        }

        private void ExamPython(int points)
           {
            Items[CurrentIndex].Style = null;
            StartTEST.Text = "Python Exam";

            if (points > 8)
            {
                StartContent.Text = $"Congratulations! You've passed Pyton course with grade {points * 10 / 18} ";
            }
            else
            {
                CurrentIndex = 0;
                StartContent.Text = $"GAME OVER. You get ICRC, try again! ";
            }

            StartButton.Content = "OK";
            StartPage.Visibility = Visibility.Visible;
            QuizPage.Visibility = Visibility.Collapsed;
           
        }

        private void ExamCSharp(int _correctPython, int _correctCSharp)
        {
            Items[CurrentIndex].Style = null;
            StartTEST.Text = "C# Exam";
            int PythonGrade = _correctPython * 10 / 18;
            int CSharpGrade = _correctCSharp * 10 / 18;
            int TotalGrade = PythonGrade / 2 + CSharpGrade / 2;
            if (TotalGrade>3)
            {
                StartContent.Text = $"Congratulations! You've passed C# course with grade {TotalGrade} ";
                CurrentIndex = 0;  
            }
            else
            {
                CurrentIndex = 100;
                StartContent.Text = $"GAME OVER. You get ICRC for C#, try again!";
            }

            StartButton.Content = "OK";
            StartPage.Visibility = Visibility.Visible;
            QuizPage.Visibility = Visibility.Collapsed;

        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var answer = GetSelectedAnswer();

            if (answer < 0)
                    return;

            var current = Questions[CurrentIndex];
            if (answer == current.CorrectAnswer)
            {
                if (CurrentIndex < 19)
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
                MiddleGrade(_correctPython);
            }
            else if (CurrentIndex == 17)
            {
                ExamPython(_correctPython);
            }
            else if (CurrentIndex == 26)
            {
                MiddleGrade(_correctCSharp);
            }
            else if (CurrentIndex == 35)
            {
                ExamCSharp(_correctPython, _correctCSharp);
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
