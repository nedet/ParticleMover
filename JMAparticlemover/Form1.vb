Public Class JMAParticleMover
    'programmed by Jeremy Antonuccio in VB
    '04/16/19

    ' use Make Particle button a few times
    ' press STEP button to see them move
    ' only use START button if STEP is working
    ' make up to 50 particles whenever desired

    Dim ballw As Integer = 20           ' each particle is 20 by 20  
    Dim ballh As Integer = ballw

    Dim myParticle As New List(Of PictureBox)   '  holds array of particles
    Dim randbox As New Random
    Dim count As Integer = 0           ' counts particles
    Dim j As Integer

    Dim maxParticles As Integer = 50   'max number of particles

    ' arrays to hold x, y, and velocities for each particle
    Dim x(maxParticles), y(maxParticles) As Integer
    Dim xvel(maxParticles), yvel(maxParticles) As Integer

    Private Sub tmrA_Tick(sender As Object, e As EventArgs) Handles tmrA.Tick

        moveStuff()

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ballw = 10
        ballh = 10

        btnMake_Click(sender, e)    'creates ball 0

        picsquare.Visible = False 'till code is finished
        picBar.Visible = True
    End Sub

    Private Sub btnStep_Click(sender As Object, e As EventArgs) Handles btnStep.Click

        moveStuff()

    End Sub


    Private Sub moveStuff()

        For j = 0 To count - 1
            x(j) = myParticle(j).Location.X + xvel(j)
            y(j) = myParticle(j).Location.Y + yvel(j)



            'make particle bounce off edges
            If x(j) > (PicA.Width - 25) Then
                If xvel(j) > 0 Then ' stop ball from getting stuck on edge
                    xvel(j) *= -1
                End If
            ElseIf x(j) < 1 Then
                If xvel(j) < 0 Then ' stop ball from getting stuck on edge
                    xvel(j) *= -1
                End If
            End If
            If y(j) > (PicA.Height - 28) Then
                If yvel(j) > 0 Then ' stop ball from getting stuck on edge
                    yvel(j) *= -1
                End If
            ElseIf y(j) < 1 Then
                If yvel(j) < 0 Then ' stop ball from getting stuck on edge
                    yvel(j) *= -1
                End If
            End If

            collisionChecker()      ' checks particle j vs particle k

            barchecker()    ' checks if any particle hits bar

            myParticle(j).SetBounds(x(j), y(j), ballw, ballh)
        Next j

    End Sub

    Private Sub Btnstop_Click(sender As Object, e As EventArgs) Handles Btnstop.Click
        tmrA.Stop() 'stops timer

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrA.Start()

    End Sub

    Private Sub collisionChecker()
        Dim j, k, tempVel As Integer   'need local j and k

        ' check each particle against higher numbered ones
        ' if close enough to call a hit, change velocity of both.

        For j = 0 To count - 2
            For k = j + 1 To count - 1

                ' check for collision
                If hit(j, k) Then   ' call function to see if pj hit pk
                    tempVel = xvel(j)
                    xvel(j) = xvel(k)
                    xvel(k) = tempVel
                    '    swap all relevant velocities for pj And pk
                    tempVel = yvel(j)
                    yvel(j) = yvel(k)
                    yvel(k) = tempVel

                End If


            Next k

        Next j

    End Sub

    Private Function hit(jj As Integer, kk As Integer) As Boolean
        ' this function finds distance between particles jj and kk

        Dim distance, xdist, ydist, BGDistance As Single

        ' calculate xdist as x(jj) - x(kk)
        xdist = x(jj) - x(kk)

        ' calulate  ydist as yy(jj) - y(kk)
        ydist = y(jj) - y(kk)
        ' calculate bigdistance as  xdist squared + ydist squared
        BGDistance = xdist ^ 2 + ydist ^ 2
        ' calculate distance as square root of bigdistance
        distance = Math.Sqrt(BGDistance)
        ' fake distance = randbox.Next(20, 100)



        If distance < 20 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub barchecker()
        ' checks if particle hits bar
        Dim j, barleft, barright, bartop, barbottom, fudge As Integer   'need local j 

        fudge = 5
        barleft = picBar.Left - fudge - PicA.Location.X
        barright = barleft + picBar.Width + fudge
        bartop = picBar.Top - fudge - PicA.Location.Y
        barbottom = bartop + picBar.Height + fudge

        For j = 0 To count - 1
            ' see if particle j's x is between bar's left-fudge and right+fudge
            If xvel(j) < 0 Then

                If x(j) > barleft And x(j) < barright Then
                    If y(j) > bartop And y(j) < barbottom Then
                        xvel(j) *= -1
                        'yvel(j) *= -1
                    End If
                End If
            Else
                If x(j) + picBall.Width > barleft And x(j) + picBall.Width < barright Then
                    If y(j) > bartop And y(j) < barbottom Then
                        xvel(j) *= -1
                    End If
                End If

            End If






        Next j


    End Sub


    Private Sub btnMake_Click(sender As Object, e As EventArgs) Handles btnMake.Click
        ' makes new picture of particle and adds to array list

        If count < maxParticles Then ' sets max limit of particles

            Dim tempPicBox As New PictureBox()
            tempPicBox.Parent = PicA

            ' make the left and top values random, so the particles will
            ' likely appear at new locations

            tempPicBox.Left = randbox.Next(40, 600) '300
            tempPicBox.Top = randbox.Next(40, 400) '150

            'DEBUG tempPicBox.Left = randbox.Next(40, 100)
            'DEBUG tempPicBox.Top = 100
            If randbox.Next(1, 3) = 1 Then
                tempPicBox.Image = picBall.Image
            Else
                tempPicBox.Image = PicBall3.Image
            End If
            tempPicBox.SizeMode = PictureBoxSizeMode.StretchImage
            tempPicBox.Visible = True

            tempPicBox.Width = ballw
            tempPicBox.Height = ballh

            myParticle.Add(tempPicBox)    'creates another ball in array

            xvel(count) = randbox.Next(-10, 11) ' random x speeds -- change ??
            yvel(count) = randbox.Next(-5, 6) ' random y speeds

            'DEBUG xvel(count) = randbox.Next(-10, 11) 
            'DEBUG yvel(count) = 0

            count += 1

            LblCount.Text = count


        End If
    End Sub

End Class
