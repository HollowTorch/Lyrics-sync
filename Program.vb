Imports System.Media
Imports System.Threading
Imports System.Runtime.InteropServices

Module Program

    Sub Main()

        Console.WriteLine("Three Days Grace - I Hate Everything About You" & Environment.NewLine)

        Dim times() As Double = {12.32, 17.75, 23.06, 28.48, 33.92, 39.1, 44.53, 49.84, 55.33, 65.38, 70.74, 76.23, 81.45}


        Dim lines() As String = {
            "Every time we lie awake",
            "After every hit we take",
            "Every feeling that I Get",
            "But I haven't missed you yet",
            "Every roommate kept awake",
            "By every sigh and scream we make",
            "All the feelings that I get",
            "But I still don't miss you yet",
            "Only when I stop to think about it",
            "I HATE EVERYTHING ABOUT YOU",
            "WHY DO I LOVE YOU",
             "I HATE EVERYTHING ABOUT YOU",
             "WHY DO I LOVE YOU"}


        Dim isColored() As Boolean = {False, False, False, False, False, False, False, False, False, True, True, True, True}


        If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) Then
            Dim player As New SoundPlayer("C:\Users\user\Downloads\Three Days Grace - I Hate Everything About You.wav")
            player.Play()
        Else
            Console.WriteLine("Audio playback skipped: SoundPlayer is only supported on Windows.")
        End If


        Dim startTime As DateTime = DateTime.Now


        For i As Integer = 0 To lines.Length - 1


            While (DateTime.Now - startTime).TotalSeconds < times(i)
                Thread.Sleep(10)
            End While


            Console.Clear()


            If isColored(i) Then
                Console.ForegroundColor = ConsoleColor.Red
            End If

            Console.WriteLine(lines(i))


            Console.ResetColor()


        Next

        Console.WriteLine("" & Environment.NewLine)

        Console.ReadLine()

    End Sub

End Module
