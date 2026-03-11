using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\t\tFScore\tLGrade\tExtra Credit Sum (Points)\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")

        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")

        studentScores = andrewScores;
    else if (currentStudent == "Emma")

        studentScores = emmaScores;
    else if (currentStudent == "Logan")

        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int examScoreSum = 0;

    int extraCreditSum = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            examScoreSum += score;
        else
            extraCreditSum += score;
    }

    decimal examScoreAverage = (decimal)examScoreSum / examAssignments;

    decimal extraCreditPoints = ((decimal)extraCreditSum * 0.1m) / examAssignments;

    decimal finalScore = ((decimal)examScoreSum + (extraCreditSum * 0.1m)) / examAssignments;

    string currentStudentLetterGrade = "";
    if (finalScore >= 97)
        currentStudentLetterGrade = "A+";
    else if (finalScore >= 93)
        currentStudentLetterGrade = "A";
    else if (finalScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (finalScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (finalScore >= 83)
        currentStudentLetterGrade = "B";

    else if (finalScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (finalScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (finalScore >= 73)
        currentStudentLetterGrade = "C";

    else if (finalScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (finalScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (finalScore >= 63)
        currentStudentLetterGrade = "D";

    else if (finalScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{examScoreAverage:F1}\t\t{finalScore:F2}\t{currentStudentLetterGrade}\t{extraCreditSum} ({extraCreditPoints:F2} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
