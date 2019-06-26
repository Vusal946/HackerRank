using System.Linq;

namespace Inheritance
{
    class Student : Person
    {
        private int[] _testScores;
        public Student() { }
        public Student(string firstName, string lastName, int id, int[] testScores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this._testScores = testScores;
        }
        /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
        // Write your constructor here

        /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
        // Write your method here

        public char Calculate()
        {
            int average = _testScores.Sum() / _testScores.Length;
            char letter = ' ';
            if (average < 40)
                letter = 'T';
            else if (average < 55)
                letter = 'D';
            else if (average < 70)
                letter = 'P';
            else if (average < 80)
                letter = 'A';
            else if (average < 90)
                letter = 'E';
            else if (average < 100)
                letter = 'O';
            return letter;
        }
    }
}