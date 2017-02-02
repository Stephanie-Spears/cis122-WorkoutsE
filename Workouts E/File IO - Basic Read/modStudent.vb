Imports System.IO	'MUST HAVE THIS FOR FILE ACCESS

Module modStudent

	Public Sub RunProject()

		'Name: File IO - Basic Read
		'Purpose: Demonstrates basic file IO
		'Author: CIS 122
		'Date: 11/19/14

		'>>> The purpose of this project is to demonstrate basic file input.  Altho we'll be working with a file, the concepts are similar to working with databases.

		'Constants
		'>>> First, we're setting a constant for the path of input file. If you don't know what a constant is, look it up in our Course Notes. They are in the Variables section (last topic).
		'As I said, we're setting a *path*, not just the filename.  When we tell our program where to look for the input file, it starts by looking in the same folder as the executable, which for us, is in the bin\Debug folder of our project.  I've placed FileIO.txt in that folder.  But if I had placed in the bin folder, we would have to change the line below to "..\FileIO.txt".  Hopefully, you know that those first two dots mean "go to the parent folder".
		'So why are we using a constant instead of just typing the filename directly into our code wherever it's being referenced.  The reason is this: let's propose that we're accessing the file many, many times in our program.  And then we decide to change the name - we would have to change in all those place. But with a constant, we just make the change in ONE place.  Right here. Open the file in Notepad to take a look at the contents. But don't change anything.
		Const c_sInputFilePath As String = "FileIO.txt"

		'Variables
		'>>> To work with a file in the Microsoft world, you need a special variable of type StreamReader.  I'll give it the prefix "file" so we know that's what we're using it for.
		Dim fileInput As StreamReader	'Declare the file variable
		Dim sText As String = ""


		'Begin Code
		SetTitle("File IO - Basic Read")

        '>>> Before you can work with any file (or database table), you must OPEN it first.  Here's how you do that. Notice that, when we call OpenText, we're passing it the file path constant. The function returns a "file handle" to us. The file handle is a reference to the file. Once we have opened the file, we have most likely locked it, which prevents others from using it. Generally, you don't want multiple programs accessing the same file at the same time.  So when we are done using the file, we must close the file, which releases the lock.  You can see that line of code below.
        'It is good practice and highly advised to write the close statement IMMEDIATELY after writing the open statement, so that you don't forget.  Then just put your code in between the two.
        'fileInput = File.OpenText(c_sInputFilePath)

        '>>> Now it's time to read a line from the file.  A line in a file or database table is more correctly called a RECORD.  To read a line from our file, we use the ReadLine function. It will start by reading the very first line from the file and return it to you.  It needs a place to put that text into, so you must put in on right side of an equal sign (assignment operator) and a string variable.
        'sText = fileInput.ReadLine
        '>>> Now sText has our data - the very first line in the file.  Let's display it to be sure.
        '	DisplayLine(sText)

        '>>> Close the file
        'fileInput.Close()
        '>>> Now, run the code.
        '>>> END SECTION


        ''>>> Next - Comment out the previous section and uncomment this one.
        ''That was all well and good, but how do we read EVERY record in the file.  One way is to use a For loop, as you see below.  Run the code.
        'fileInput = File.OpenText(c_sInputFilePath)

        'For i As Integer = 1 To 10
        '	sText = fileInput.ReadLine
        '	DisplayLine(sText)
        'Next

        'fileInput.Close()
        ''If you looked carefully, you saw that we didn't display every record in the file - we missed the last one.  Why?  The For loop is set to read only 10 times, and there are 11 records in the file.  Well, that's not good. We could change the loop from 10 to 11, but that won't help us if someone comes along and adds a 12th record to the file.  The solution lies in using a While loop instead.
        ''>>> END SECTION



        ''>>> Next - Comment out the previous section and uncomment this one.
        fileInput = File.OpenText(c_sInputFilePath)

        ''Exactly the same as above, but instead we're using a While loop.  What's this business with "fileInput.Peek <> -1"?  That's Microsoft's way of telling us that there are still more records to read in the file.  So, the condition reads, "as long as there are more records left to read...".  Run this code and notice that it works regardless of the number of records in the file.
        While fileInput.Peek <> -1
            sText = fileInput.ReadLine
            DisplayLine(sText)
        End While

        fileInput.Close()
        ''>>> END SECTION

    End Sub

End Module