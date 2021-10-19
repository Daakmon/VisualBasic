Public Class TiroAlPato
    Dim y, x, i, j As Integer
    Dim trayectoriaX, trayectoriaY, trayectoriai, trayectoriaj As Integer
    Dim velocidad, velocidadPesadilla As Integer
    Dim muertes, segundos, rndmbinario As Integer
    Dim demonio1Muerto, demonio2Muerto As Boolean

    Sub PlayLoopingBackgroundSound()
        My.Computer.Audio.Play(My.Resources.Mick_Gordon___The_Only_Thing_They_Fear_Is_You___DOOM_Eternal,
        AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Disparo()
        My.Computer.Audio.Play("C:\Users\daakm\Downloads\2DM3\DdI\Resources\Audio\disparo.wav",
        AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub TMR_Timer_Tick(sender As Object, e As EventArgs) Handles TMR_Timer.Tick
        'No hace falta porque las variables son de clase ya sabe donde esta
        'x = PCB_Pato.Location.X
        'y = PCB_Pato.Location.Y
        'i = PCB_Demon.Location.X
        'j = PCB_Demon.Location.Y

        If CHK_Pesadilla.Checked = True Then
            velocidad = velocidadPesadilla
        End If

        'My.Computer.Audio.Play(My.Resources.disparo, AudioPlayMode.Background)
        'My.Application.Info.DirectoryPath"\Carpeta\disparo.wav"

        Select Case trayectoriaX
            Case 0
                x = PCB_Pato.Location.X + velocidad
            Case 1
                x = PCB_Pato.Location.X - velocidad
        End Select

        Select Case trayectoriaY
            Case 0
                y = PCB_Pato.Location.Y + velocidad
            Case 1
                y = PCB_Pato.Location.Y - velocidad
        End Select


        Select Case trayectoriai
            Case 0
                i = PCB_Demon.Location.X + velocidad
            Case 1
                i = PCB_Demon.Location.X - velocidad
        End Select

        Select Case trayectoriaj
            Case 0
                j = PCB_Demon.Location.Y + velocidad
            Case 1
                j = PCB_Demon.Location.Y - velocidad
        End Select

        'Hasta que no esten los dos fuera del panel no se lanzan
        If (x > PNL_Panel.Width Or y > PNL_Panel.Height Or
           x < 0 Or y < -PCB_Pato.Height) And
           (i > PNL_Panel.Width Or j > PNL_Panel.Height Or
           i < 0 Or j < -PCB_Demon.Height) Then
            LanzaPajaro()
        End If

        PCB_Pato.Location = New Point(x, y)
        PCB_Demon.Location = New Point(i, j)
    End Sub

    Sub TrayectoriaEjeX(trayectoria1 As Integer, trayectoria2 As Integer)

    End Sub

    Sub TrayectoriaEjeY()

    End Sub

    Private Sub LanzaPajaro()
        'PCB_Pato.Location = New Point(0, 0)
        Randomize()
        TMR_Timer.Stop()

        demonio1Muerto = False
        demonio2Muerto = False

        PCB_Pato.Visible = True
        PCB_Demon.Visible = True

        x = Rnd() * (PNL_Panel.Width - PCB_Pato.Width)
        y = Rnd() * (PNL_Panel.Height - PCB_Pato.Height)
        PCB_Pato.Location = New Point(x, y)

        i = Rnd() * (PNL_Panel.Width - PCB_Demon.Width)
        j = Rnd() * (PNL_Panel.Height - PCB_Demon.Height)
        PCB_Demon.Location = New Point(x, y)

        Random()

        TMR_Timer.Start()
    End Sub

    Private Sub Random()
        RndBinario()
        trayectoriaX = rndmbinario
        RndBinario()
        trayectoriaY = rndmbinario
        RndBinario()
        trayectoriai = rndmbinario
        RndBinario()
        trayectoriaj = rndmbinario

        velocidad = Int(Rnd() * 3) + 2
        velocidadPesadilla = Int(Rnd() * 10) + 8
    End Sub

    Private Sub RndBinario()
        rndmbinario = Int(Rnd() * 2) 'Randomiza 0 o 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Iniciar()
    End Sub

    Private Sub Iniciar()
        PlayLoopingBackgroundSound()
        LanzaPajaro()
        LBL_Muertes.Text = ""
        muertes = 0

        LBL_Contador.Text = ""
        segundos = 60
        LBL_Contador.Text = segundos

        TMR_Segundo.Start()
    End Sub

    Private Sub Muerte(sender As Object, e As EventArgs) Handles PCB_Pato.Click, PCB_Demon.Click
        muertes += 1
        LBL_Muertes.Text = muertes

        'StopBackgroundSound()
        'Disparo()
        'PlayLoopingBackgroundSound()

        If sender.Tag = 1 Then
            demonio1Muerto = True
            PCB_Pato.Visible = False
            PCB_Blood.Location = New Point(x, y)
        ElseIf sender.Tag = 2 Then
            PCB_Demon.Visible = False
            demonio2Muerto = True
            PCB_Blood.Location = New Point(i, j)
        End If

        PCB_Blood.Visible = True
        TMR_Muerte.Start()

        If demonio1Muerto = True And demonio2Muerto = True Then
            demonio1Muerto = False
            demonio2Muerto = False
            LanzaPajaro()
        End If
    End Sub

    Private Sub TMR_Muerte_Tick(sender As Object, e As EventArgs) Handles TMR_Muerte.Tick
        PCB_Blood.Visible = False
        TMR_Muerte.Stop()
    End Sub

    Private Sub CHK_Pesadilla_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_Pesadilla.CheckedChanged
        If CHK_Pesadilla.Checked = True Then
            PCB_Pesadilla.Visible = True
            PCB_Ultraviolencia.Visible = False
        Else
            PCB_Pesadilla.Visible = False
            PCB_Ultraviolencia.Visible = True
        End If
    End Sub

    Private Sub TiroAlPato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        PCB_Pesadilla.Visible = False
        PCB_Ultraviolencia.Visible = True

        PCB_Blood.Visible = False

        LBL_Muertes.Text = ""
        muertes = 0

        PCB_Pato.Visible = False
        PCB_Demon.Visible = False
        demonio1Muerto = False
        demonio2Muerto = False

        Dim mira As Icon
        mira = My.Resources.mira
        Me.Cursor = New Cursor(mira.Handle)
    End Sub

    Private Sub TMR_Segundo_Tick(sender As Object, e As EventArgs) Handles TMR_Segundo.Tick
        segundos -= 1
        LBL_Contador.Text = segundos

        If segundos = 0 Then
            TMR_Segundo.Stop()
            'MsgBox("Fin Del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information, "fin")
            MsgBox("Fin Del Juego", vbInformation, "Doom")
            Iniciar()
        End If
    End Sub

    Private Sub BTN_Fin_Click(sender As Object, e As EventArgs) Handles BTN_Fin.Click
        TMR_Timer.Stop()
        TMR_Juego.Stop()
        TMR_Segundo.Stop()

        PCB_Pato.Visible = False
        PCB_Demon.Visible = False

        StopBackgroundSound()
    End Sub

    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub

End Class
