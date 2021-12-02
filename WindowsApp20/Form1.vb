Public Class Form1
    '1~6까지의 주사위 눈 합
    Public Ace As Integer = 0 'Ace(1의 눈 합)
    Public Deuces As Integer = 0 '2 (2의 눈 합)
    Public Threes As Integer = 0 '3 (3의 눈 합)
    Public Fours As Integer = 0 '4 (4의 눈 합)
    Public Fives As Integer = 0 '5 (5의 눈 합)
    Public sixes As Integer = 0 '6 (6의 눈 합)

    'Choice (현재 모든 주사위 눈의 합)
    Public Choice As Integer = 0

    '4 of kinds (주사위 눈 4개이상 똑같을 때)
    Public fourkinds As Integer = 0

    'full house (같은 눈 3개와 같은 눈 2개)
    Public fullhoues As Integer = 0

    'S.straight (주사위 눈 4개 이상이 연속되는 숫자일 때)
    Public sstraight As Integer = 0

    'L.straight (주사위 눈 5개가 연속되는 숫자일 때)
    Public lstraight As Integer = 0

    'Yacht 모든 주사위 눈이 같을때
    Public YachtCnt As Integer = 0

    '주사위 1~5
    Dim DiceOne As Integer '주사위 1
    Dim DiceTwo As Integer '주사위 2
    Dim DiceThree As Integer '주사위 3
    Dim DiceFour As Integer '주사위 4
    Dim DiceFive As Integer '주사위 5

    Public playerturn As Integer = 1
    Public turnCount As Integer = 1
    Public DiceCount As Integer = 0

    Dim RandomNumber As New Random '무작위 숫자

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '턴 제한시간
        Timer1.Enabled = True
        '플레이어 1
        If playerturn Mod 2 = 1 Then
            DiceCount += 1
            Label2.Text = 3 - (DiceCount) '남은 횟수 표시
            If DiceCount >= 3 Then
                MsgBox("더 굴릴 수 없습니다! 점수를 입력해주세요.")
                Button1.Enabled = False
            End If
        End If
        '플레이어 2
        If playerturn Mod 2 = 0 Then
            DiceCount += 1
            Label2.Text = 3 - (DiceCount)
            If DiceCount >= 3 Then
                MsgBox("더 굴릴 수 없습니다! 점수를 입력해주세요.")
                Button1.Enabled = False
            End If
        End If

        '체크되어있지 않다면 주사위를 굴림
        If CheckBox1.Checked = False Then
            If DiceOne = 1 Then '다시 굴릴경우 합계에서 전에 굴렸던 주사위값을 제거
                Ace -= DiceOne
            ElseIf DiceOne = 2 Then
                Deuces -= DiceOne
            ElseIf DiceOne = 3 Then
                Threes -= DiceOne
            ElseIf DiceOne = 4 Then
                Fours -= DiceOne
            ElseIf DiceOne = 5 Then
                Fives -= DiceOne
            ElseIf DiceOne = 6 Then
                sixes -= DiceOne
            End If
            DiceOne = RandomNumber.Next(1, 7) '주사위 숫자 생성
        End If

        If CheckBox2.Checked = False Then
            If DiceTwo = 1 Then
                Ace -= DiceTwo
            ElseIf DiceTwo = 2 Then
                Deuces -= DiceTwo
            ElseIf DiceTwo = 3 Then
                Threes -= DiceTwo
            ElseIf DiceTwo = 4 Then
                Fours -= DiceTwo
            ElseIf DiceTwo = 5 Then
                Fives -= DiceTwo
            ElseIf DiceTwo = 6 Then
                sixes -= DiceTwo
            End If
            DiceTwo = RandomNumber.Next(1, 7)
        End If

        If CheckBox3.Checked = False Then
            If DiceThree = 1 Then
                Ace -= DiceThree
            ElseIf DiceThree = 2 Then
                Deuces -= DiceThree
            ElseIf DiceThree = 3 Then
                Threes -= DiceThree
            ElseIf DiceThree = 4 Then
                Fours -= DiceThree
            ElseIf DiceThree = 5 Then
                Fives -= DiceThree
            ElseIf DiceThree = 6 Then
                sixes -= DiceThree
            End If
            DiceThree = RandomNumber.Next(1, 7)
        End If

        If CheckBox4.Checked = False Then
            If DiceFour = 1 Then
                Ace -= DiceFour
            ElseIf DiceFour = 2 Then
                Deuces -= DiceFour
            ElseIf DiceFour = 3 Then
                Threes -= DiceFour
            ElseIf DiceFour = 4 Then
                Fours -= DiceFour
            ElseIf DiceFour = 5 Then
                Fives -= DiceFour
            ElseIf DiceFour = 6 Then
                sixes -= DiceFour
            End If
            DiceFour = RandomNumber.Next(1, 7)
        End If

        If CheckBox5.Checked = False Then
            If DiceFive = 1 Then
                Ace -= DiceFive
            ElseIf DiceFive = 2 Then
                Deuces -= DiceFive
            ElseIf DiceFive = 3 Then
                Threes -= DiceFive
            ElseIf DiceFive = 4 Then
                Fours -= DiceFive
            ElseIf DiceFive = 5 Then
                Fives -= DiceFive
            ElseIf DiceFive = 6 Then
                sixes -= DiceFive
            End If
            DiceFive = RandomNumber.Next(1, 7)
        End If

        '주사위 1
        If DiceOne = 1 Then
            PictureBox1.Image = My.Resources.diceone '주사위 숫자에 맞는 주사위 이미지를 보여줌
            Ace += DiceOne '1이 나올 경우 Ace(1의 합)에 추가
            If CheckBox1.Checked Then Ace -= DiceOne '만약 체크박스를 체크했다면 값이 늘어나는 것을 막음

        ElseIf DiceOne = 2 Then
            PictureBox1.Image = My.Resources.dicetwo
            Deuces += DiceOne
            If CheckBox1.Checked Then Deuces -= DiceOne

        ElseIf DiceOne = 3 Then
            PictureBox1.Image = My.Resources.dicethree
            Threes += DiceOne
            If CheckBox1.Checked Then Threes -= DiceOne

        ElseIf DiceOne = 4 Then
            PictureBox1.Image = My.Resources.dicefour
            Fours += DiceOne
            If CheckBox1.Checked Then Fours -= DiceOne

        ElseIf DiceOne = 5 Then
            PictureBox1.Image = My.Resources.dicefive
            Fives += DiceOne
            If CheckBox1.Checked Then Fives -= DiceOne

        ElseIf DiceOne = 6 Then
            PictureBox1.Image = My.Resources.dicesix
            sixes += DiceOne
            If CheckBox1.Checked Then sixes -= DiceOne
        End If

        '주사위 2
        If DiceTwo = 1 Then
            PictureBox2.Image = My.Resources.diceone
            Ace += DiceTwo
            If CheckBox2.Checked Then Ace -= DiceTwo

        ElseIf DiceTwo = 2 Then
            PictureBox2.Image = My.Resources.dicetwo
            Deuces += DiceTwo
            If CheckBox2.Checked Then Deuces -= DiceTwo

        ElseIf DiceTwo = 3 Then
            PictureBox2.Image = My.Resources.dicethree
            Threes += DiceTwo
            If CheckBox2.Checked Then Threes -= DiceTwo

        ElseIf DiceTwo = 4 Then
            PictureBox2.Image = My.Resources.dicefour
            Fours += DiceTwo
            If CheckBox2.Checked Then Fours -= DiceTwo

        ElseIf DiceTwo = 5 Then
            PictureBox2.Image = My.Resources.dicefive
            Fives += DiceTwo
            If CheckBox2.Checked Then Fives -= DiceTwo

        ElseIf DiceTwo = 6 Then
            PictureBox2.Image = My.Resources.dicesix
            sixes += DiceTwo
            If CheckBox2.Checked Then sixes -= DiceTwo
        End If

        '주사위3
        If DiceThree = 1 Then
            PictureBox3.Image = My.Resources.diceone
            Ace += DiceThree
            If CheckBox3.Checked Then Ace -= DiceThree

        ElseIf DiceThree = 2 Then
            PictureBox3.Image = My.Resources.dicetwo
            Deuces += DiceThree
            If CheckBox3.Checked Then Deuces -= DiceThree

        ElseIf DiceThree = 3 Then
            PictureBox3.Image = My.Resources.dicethree
            Threes += DiceThree
            If CheckBox3.Checked Then Threes -= DiceThree

        ElseIf DiceThree = 4 Then
            PictureBox3.Image = My.Resources.dicefour
            Fours += DiceThree
            If CheckBox3.Checked Then Fours -= DiceThree

        ElseIf DiceThree = 5 Then
            PictureBox3.Image = My.Resources.dicefive
            Fives += DiceThree
            If CheckBox3.Checked Then Fives -= DiceThree

        ElseIf DiceThree = 6 Then
            PictureBox3.Image = My.Resources.dicesix
            sixes += DiceThree
            If CheckBox3.Checked Then sixes -= DiceThree

        End If

        '주사위4
        If DiceFour = 1 Then
            PictureBox4.Image = My.Resources.diceone
            Ace += DiceFour
            If CheckBox4.Checked Then Ace -= DiceFour

        ElseIf DiceFour = 2 Then
            PictureBox4.Image = My.Resources.dicetwo
            Deuces += DiceFour
            If CheckBox4.Checked Then Deuces -= DiceFour

        ElseIf DiceFour = 3 Then
            PictureBox4.Image = My.Resources.dicethree
            Threes += DiceFour
            If CheckBox4.Checked Then Threes -= DiceFour

        ElseIf DiceFour = 4 Then
            PictureBox4.Image = My.Resources.dicefour
            Fours += DiceFour
            If CheckBox4.Checked Then Fours -= DiceFour

        ElseIf DiceFour = 5 Then
            PictureBox4.Image = My.Resources.dicefive
            Fives += DiceFour
            If CheckBox4.Checked Then Fives -= DiceFour

        ElseIf DiceFour = 6 Then
            PictureBox4.Image = My.Resources.dicesix
            sixes += DiceFour
            If CheckBox4.Checked Then sixes -= DiceFour

        End If

        '주사위5
        If DiceFive = 1 Then
            PictureBox5.Image = My.Resources.diceone
            Ace += DiceFive
            If CheckBox5.Checked Then Ace -= DiceFive

        ElseIf DiceFive = 2 Then
            PictureBox5.Image = My.Resources.dicetwo
            Deuces += DiceFive
            If CheckBox5.Checked Then Deuces -= DiceFive

        ElseIf DiceFive = 3 Then
            PictureBox5.Image = My.Resources.dicethree
            Threes += DiceFive
            If CheckBox5.Checked Then Threes -= DiceFive

        ElseIf DiceFive = 4 Then
            PictureBox5.Image = My.Resources.dicefour
            Fours += DiceFive
            If CheckBox5.Checked Then Fours -= DiceFive

        ElseIf DiceFive = 5 Then
            PictureBox5.Image = My.Resources.dicefive
            Fives += DiceFive
            If CheckBox5.Checked Then Fives -= DiceFive

        ElseIf DiceFive = 6 Then
            PictureBox5.Image = My.Resources.dicesix
            sixes += DiceFive
            If CheckBox5.Checked Then sixes -= DiceFive
        End If

        '주사위 5개가 모두 같으면 yacht 카운트 추가 아닐경우 제거
        If DiceOne = DiceTwo = DiceThree = DiceFour = DiceFive Then
            If YachtCnt >= 0 And YachtCnt <= 1 Then
                YachtCnt = 1
            Else
                YachtCnt = 0
            End If
        End If

        '1~6까지의 눈 미리보기
        Label12.Text = Ace
        Label11.Text = Deuces
        Label10.Text = Threes
        Label9.Text = Fours
        Label8.Text = Fives
        Label7.Text = sixes

        '초이스 = 1~6까지의 합
        Choice = Ace + Deuces + Threes + Fours + Fives + sixes

        '4 of kinds
        If Ace >= 4 Then
            fourkinds = Choice
        ElseIf Deuces >= 8 Then
            fourkinds = Choice
        ElseIf Threes >= 12 Then
            fourkinds = Choice
        ElseIf Fours >= 16 Then
            fourkinds = Choice
        ElseIf Fives >= 20 Then
            fourkinds = Choice
        ElseIf sixes >= 24 Then
            fourkinds = Choice
        Else
            fourkinds = 0
        End If

        '풀하우스
        If Ace = 3 And Deuces = 4 Then
            fullhoues = Choice
        ElseIf Ace = 3 And Threes = 6 Then
            fullhoues = Choice
        ElseIf Ace = 3 And Fours = 8 Then
            fullhoues = Choice
        ElseIf Ace = 3 And Fives = 10 Then
            fullhoues = Choice
        ElseIf Ace = 3 And sixes = 12 Then
            fullhoues = Choice

        ElseIf Deuces = 6 And Ace = 2 Then
            fullhoues = Choice
        ElseIf Deuces = 6 And Threes = 6 Then
            fullhoues = Choice
        ElseIf Deuces = 6 And Fours = 8 Then
            fullhoues = Choice
        ElseIf Deuces = 6 And Fives = 10 Then
            fullhoues = Choice
        ElseIf Deuces = 6 And sixes = 12 Then
            fullhoues = Choice

        ElseIf Threes = 9 And Ace = 2 Then
            fullhoues = Choice
        ElseIf Threes = 9 And Deuces = 4 Then
            fullhoues = Choice
        ElseIf Threes = 9 And Fours = 8 Then
            fullhoues = Choice
        ElseIf Threes = 9 And Fives = 10 Then
            fullhoues = Choice
        ElseIf Threes = 9 And sixes = 12 Then
            fullhoues = Choice

        ElseIf Fours = 12 And Ace = 2 Then
            fullhoues = Choice
        ElseIf Fours = 12 And Deuces = 4 Then
            fullhoues = Choice
        ElseIf Fours = 12 And Threes = 6 Then
            fullhoues = Choice
        ElseIf Fours = 12 And Fives = 10 Then
            fullhoues = Choice
        ElseIf Fours = 12 And sixes = 12 Then
            fullhoues = Choice

        ElseIf Fives = 15 And Ace = 2 Then
            fullhoues = Choice
        ElseIf Fives = 15 And Deuces = 4 Then
            fullhoues = Choice
        ElseIf Fives = 15 And Threes = 6 Then
            fullhoues = Choice
        ElseIf Fives = 15 And Fours = 8 Then
            fullhoues = Choice
        ElseIf Fives = 15 And sixes = 12 Then

        ElseIf sixes = 18 And Ace = 2 Then
            fullhoues = Choice
        ElseIf sixes = 18 And Deuces = 4 Then
            fullhoues = Choice
        ElseIf sixes = 18 And Threes = 6 Then
            fullhoues = Choice
        ElseIf sixes = 18 And Fours = 8 Then
            fullhoues = Choice
        ElseIf sixes = 18 And Fives = 10 Then
            fullhoues = Choice
        Else
            fullhoues = 0
        End If

        '스몰 스트레이트
        If Ace >= 1 And Deuces >= 2 And Threes >= 3 And Fours >= 4 And sstraight = 0 Then
            sstraight = 1

        ElseIf Deuces >= 2 And Threes >= 3 And Fours >= 4 And Fives >= 5 And sstraight = 0 Then
            sstraight = 1

        ElseIf Threes >= 3 And Fours >= 4 And Fives >= 5 And sixes >= 6 And sstraight = 0 Then
            sstraight = 1

        Else
            sstraight = 0
        End If

        '라지 스트레이트
        If Ace >= 1 And Deuces >= 2 And Threes >= 3 And Fours >= 4 And Fives >= 5 And lstraight = 0 Then
            lstraight = 1
        ElseIf Deuces >= 2 And Threes >= 3 And Fours >= 4 And Fives >= 5 And sixes >= 6 And lstraight = 0 Then
            lstraight = 1
        Else
            lstraight = 0
        End If

        'Roll을 누를 때 마다 점수판 갱신
        Form2.Label14.Text = Ace
        Form2.Label16.Text = Deuces
        Form2.Label17.Text = Threes
        Form2.Label18.Text = Fours
        Form2.Label19.Text = Fives
        Form2.Label20.Text = sixes
        Form2.Label25.Text = Choice
        Form2.Label26.Text = fourkinds
        Form2.Label24.Text = fullhoues
        Form2.Label23.Text = sstraight * 15
        Form2.Label22.Text = lstraight * 30
        Form2.Label21.Text = YachtCnt * 50

        Form2.Label41.Text = Ace
        Form2.Label42.Text = Deuces
        Form2.Label40.Text = Threes
        Form2.Label39.Text = Fours
        Form2.Label38.Text = Fives
        Form2.Label37.Text = Ace
        Form2.Label35.Text = Choice
        Form2.Label36.Text = fourkinds
        Form2.Label34.Text = fullhoues
        Form2.Label33.Text = sstraight * 15
        Form2.Label32.Text = lstraight * 30
        Form2.Label31.Text = YachtCnt * 50

    End Sub
    '점수판 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
    '턴 및 플레이어 표시 초기설정
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = Form4.Player1
        Label6.Text = "1 / 12"
    End Sub
    '종료
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
    End Sub
    '시간이 지날 때 마다 프로그래스바 진행, 시간 경과시 주사위 횟수 모두 차감
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        If ProgressBar1.Value >= 150 Then
            Button1.Enabled = False
            Timer1.Enabled = False
            MsgBox("시간 초과!")
        End If
    End Sub
    '프로그램 설명
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
    End Sub
    '점수판 설명
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class
