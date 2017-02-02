Imports System.IO	'MUST HAVE THIS FOR FILE ACCESS

Module modStudent

	Public Sub RunProject()

		'Name: File IO - Scores
		'Purpose: Demonstrates file reading
		'Author: CIS 122
		'Date: 11/19/14

		'>>> This project demonstrates reading a file of student scores. It displays the student's name, along with their total points and their average.
		'Take a look at the Scores.txt file. It's located it in the bin\Debug folder. As you can see, it has a name, followed by 5 scores, a name and 5 scores, etc.

		'Constants
		Const sFilePath As String = "Scores.txt"

		'Variables
		Dim fileInput As StreamReader	 'Declare the file variable
		Dim sText As String
		Dim sName As String
		Dim dTotal As Double
		Dim dScore As Double
		Dim dAverage As Double


		'Begin Code
		SetTitle("File IO - Scores")

		fileInput = File.OpenText(sFilePath) '>>> Remember to write the code to close the file immediately after opening the file so that you don't forget

		'To read a file, we need our classic While loop.  Each iteration thru the loop handles ONE student
		While fileInput.Peek <> -1
			'Let's take care of the name first. We read it in and display it:
			sName = fileInput.ReadLine
			DisplayLine("Name: " & sName)

            '>>> Now we handle the 5 scores:
            'dScore = CDbl(fileInput.ReadLine)
            'dTotal = dTotal + dScore

            'dScore = CDbl(fileInput.ReadLine)
            'dTotal = dTotal + dScore

            'dScore = CDbl(fileInput.ReadLine)
            'dTotal = dTotal + dScore

            'dScore = CDbl(fileInput.ReadLine)
            'dTotal = dTotal + dScore

            'dScore = CDbl(fileInput.ReadLine)
            'dTotal = dTotal + dScore


            '>>> END SECTION

            '>>> Run the code.  Well it almost works. The first student data is correct, but from there, things start to go haywire.  Can you figure out why?
            'The problem is that we keep adding to dTotal, but we never reset back to zero when we start a new student.  Let's do that now.
            'Uncomment out the next line of code and move it to right before we start reading the student's scores.
            'dTotal = 0

            '>>> Ok, that works well, but it's grossly inefficient. What if the student had 20 scores - that's a lot of repetition.  And that shd give you a clue to a better solution - a For loop.		
            'Comment out the previous section and uncomment this one. Then run the code.
            dTotal = 0
            For i As Integer = 1 To 5
                dScore = CDbl(fileInput.ReadLine)
                dTotal = dTotal + dScore
                DisplayLine("Total Points: " & dTotal)

                dAverage = dTotal / 5
                DisplayLine("Average: " & dAverage & "%")

            Next
            '>>> END SECTION

            'As you can see, this still works, but with a lot less code.

            DisplayLine()
        End While

        fileInput.Close()

	End Sub

End Module