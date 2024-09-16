Public Class Form1
    Dim time As UInt64
    Dim len As UInt64
    Dim hour As Integer
    Dim min As Integer
    Dim sec As Integer
    Dim _event As KeyEventArgs

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        'Code For Caps Lock
        If (My.Computer.Keyboard.CapsLock) Then
            OvalShape1.FillColor = Color.Green
        Else
            OvalShape1.FillColor = Color.Red

        End If


        'code for shift key
        If (My.Computer.Keyboard.ShiftKeyDown) Then
            OvalShape2.FillColor = Color.Green
        Else
            OvalShape2.FillColor = Color.Red

        End If

        'Code For Alphabet keys
        If e.KeyCode = Keys.A Then
            A.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.B Then
            B.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.C Then
            C.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D Then
            D.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.E Then
            EE.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.F Then
            F.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.G Then
            G.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.H Then
            H.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.I Then
            I.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.J Then
            J.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.K Then
            K.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.L Then
            L.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.M Then
            M.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.N Then
            N.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.O Then
            O.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.P Then
            P.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.Q Then
            Q.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.R Then
            R.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.S Then
            S.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.T Then
            T.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.U Then
            U.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.V Then
            V.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.W Then
            W.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.X Then
            X.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.Y Then
            Y.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.Z Then
            Z.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.Back Then
            back_space.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.Space Then
            space.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.Tab Then
            OvalShape3.FillColor = Color.Green

            'code for number keys
        ElseIf e.KeyCode = Keys.D1 Then
            D1.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D2 Then
            D2.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D3 Then
            D3.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D4 Then
            D4.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D5 Then
            D5.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D6 Then
            D6.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D7 Then
            D7.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D8 Then
            D8.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D9 Then
            D9.BackColor = Color.AliceBlue
        ElseIf e.KeyCode = Keys.D0 Then
            D0.BackColor = Color.AliceBlue




        End If
    End Sub

 

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp

        A.BackColor = Color.OrangeRed
        B.BackColor = Color.DarkSeaGreen
        C.BackColor = Color.Brown
        D.BackColor = Color.Brown
        EE.BackColor = Color.Brown
        F.BackColor = Color.DarkSeaGreen
        G.BackColor = Color.DarkSeaGreen
        H.BackColor = Color.Salmon
        I.BackColor = Color.Teal
        J.BackColor = Color.Salmon
        K.BackColor = Color.Teal
        L.BackColor = Color.DimGray
        M.BackColor = Color.Salmon
        N.BackColor = Color.Salmon
        O.BackColor = Color.DimGray
        P.BackColor = Color.Gold
        Q.BackColor = Color.OrangeRed
        R.BackColor = Color.DarkSeaGreen
        S.BackColor = Color.MediumOrchid
        T.BackColor = Color.DarkSeaGreen
        U.BackColor = Color.Salmon
        V.BackColor = Color.DarkSeaGreen
        W.BackColor = Color.MediumOrchid
        X.BackColor = Color.MediumOrchid
        Y.BackColor = Color.Salmon
        Z.BackColor = Color.OrangeRed

        'number keys
        D1.BackColor = Color.OrangeRed
        D2.BackColor = Color.MediumOrchid
        D3.BackColor = Color.Brown
        D4.BackColor = Color.DarkSeaGreen
        D5.BackColor = Color.DarkSeaGreen
        D6.BackColor = Color.Salmon
        D7.BackColor = Color.Salmon
        D8.BackColor = Color.Teal
        D9.BackColor = Color.DimGray
        D0.BackColor = Color.Gold

        back_space.BackColor = Color.Gold
        space.BackColor = Color.MediumBlue
        OvalShape3.FillColor = Color.Red


        If (My.Computer.Keyboard.ShiftKeyDown) Then
            OvalShape2.FillColor = Color.Green
        Else
            OvalShape2.FillColor = Color.Red

        End If



    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        len = TextBox1.Text.Split(" ").Length - 1

        TextBox2.Text = len

        If (My.Computer.Keyboard.CapsLock) Then
            OvalShape1.FillColor = Color.Green
        Else
            OvalShape1.FillColor = Color.Red

        End If

        If (My.Computer.Keyboard.ShiftKeyDown) Then
            OvalShape2.FillColor = Color.Green
        Else
            OvalShape2.FillColor = Color.Red

        End If



    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OvalShape3.FillColor = Color.Red

        If (My.Computer.Keyboard.CapsLock) Then
            OvalShape1.FillColor = Color.Green
        Else
            OvalShape1.FillColor = Color.Red

        End If

        If (My.Computer.Keyboard.ShiftKeyDown) Then
            OvalShape2.FillColor = Color.Green
        Else
            OvalShape2.FillColor = Color.Red

        End If
        time = 0
        Timer1.Start()
        TextBox2.Text = "0"

        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1


        TextBox4.Text = (len / time) * 60

        hour = 0
        min = 0
        sec = time

        If (time > 60) Then
            min = time / 60
            sec = time Mod 60

        End If
        If (min > 60) Then
            min = time Mod 60
            hour = time / 60
        End If

        TextBox3.Clear()

        TextBox3.Text = "Hour:" & hour.ToString() & " Min:" & min.ToString & " Sec:" & sec.ToString



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        time = 0
        hour = 0
        min = 0
        sec = 0
        len = 0
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Timer1.Stop()
        Timer1.Start()
        TextBox1.Focus()

    End Sub
End Class
