Public Class Form2
    Dim btnCnt As Integer = 0
    Public p1UpperScore As Integer '서브토탈
    Public p2UpperScore As Integer
    Public p1TotalScore As Integer '총점수
    Public p2TotalScore As Integer
    Dim p1BonusCnt As Integer = 0 '서브토탈 보너스
    Dim p2BonusCnt As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.playerturn Mod 2 = 1 Then '첫턴이 지나기 전까지 2P가 점수 입력 불가능
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            RadioButton5.Visible = False
            RadioButton6.Visible = False
            RadioButton7.Visible = False
            RadioButton8.Visible = False
            RadioButton9.Visible = False
            RadioButton10.Visible = False
            RadioButton11.Visible = False
            RadioButton12.Visible = False
        End If
        Label43.Text = Form4.Player1 '실행 초기에 입력받았던 플레이어 이름
        Label44.Text = Form4.Player2
    End Sub
    '점수 입력과 동시에 턴을 넘김
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnCnt += 1 '버튼 카운트 증가
        Form1.playerturn += 1 '플레이어 턴 증가
        If btnCnt = 2 Then '버튼카운트가 2가 되면 0으로 초기화 후 표시되는 턴수 증가
            Form1.turnCount += 1
            btnCnt = 0
        End If

        If Form1.turnCount >= 13 Then '총 턴수는 12턴이 끝나면 총점으로 승패를 계산
            Form1.Button1.Enabled = False
            If p1TotalScore > p2TotalScore Then
                MsgBox(Form4.Player1 & "가 이겼습니다!")
            ElseIf p2TotalScore > p1TotalScore Then
                MsgBox(Form4.Player2 & "가 이겼습니다!")
            ElseIf p1TotalScore = p2TotalScore Then
                MsgBox("무승부!")
            End If
        End If

        Form1.DiceCount = 0 '턴이 넘어가면서 주사위 횟수도 초기화
        Form1.Button1.Enabled = True 'roll버튼 초기화
        Form1.CheckBox1.CheckState = False '주사위 잠금 해제
        Form1.CheckBox2.CheckState = False
        Form1.CheckBox3.CheckState = False
        Form1.CheckBox4.CheckState = False
        Form1.CheckBox5.CheckState = False

        If Form1.playerturn Mod 2 = 1 Then '플레이어 1 차례일 경우 플레이어 2의 라디오 버튼 숨김
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            RadioButton5.Visible = False
            RadioButton6.Visible = False
            RadioButton7.Visible = False
            RadioButton8.Visible = False
            RadioButton9.Visible = False
            RadioButton10.Visible = False
            RadioButton11.Visible = False
            RadioButton12.Visible = False
            RadioButton13.Visible = True
            RadioButton14.Visible = True
            RadioButton15.Visible = True
            RadioButton16.Visible = True
            RadioButton17.Visible = True
            RadioButton18.Visible = True
            RadioButton19.Visible = True
            RadioButton20.Visible = True
            RadioButton21.Visible = True
            RadioButton22.Visible = True
            RadioButton23.Visible = True
            RadioButton24.Visible = True

        ElseIf Form1.playerturn Mod 2 = 0 Then '플레이어 2 차례때 플레이어 1 라디오 버튼 숨김
            RadioButton13.Visible = False
            RadioButton14.Visible = False
            RadioButton15.Visible = False
            RadioButton16.Visible = False
            RadioButton17.Visible = False
            RadioButton18.Visible = False
            RadioButton19.Visible = False
            RadioButton20.Visible = False
            RadioButton21.Visible = False
            RadioButton22.Visible = False
            RadioButton23.Visible = False
            RadioButton24.Visible = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            RadioButton6.Visible = True
            RadioButton7.Visible = True
            RadioButton8.Visible = True
            RadioButton9.Visible = True
            RadioButton10.Visible = True
            RadioButton11.Visible = True
            RadioButton12.Visible = True
        End If

        If RadioButton24.Checked Then '라디오 버튼을 체크 후 버튼 입력시 
            Label14.Visible = False '그 점수의 레이블 숨김
            RadioButton24.Enabled = False '라디오 버튼 숨김
            Label48.Text = Form1.Ace '옆의 레이블로 점수 이동 및 고정
            p1UpperScore += Form1.Ace '서브토탈에 점수 추가
        End If

        If RadioButton23.Checked Then
            Label16.Visible = False
            RadioButton23.Enabled = False
            Label50.Text = Form1.Deuces
            p1UpperScore += Form1.Deuces
        End If

        If RadioButton22.Checked Then
            Label17.Visible = False
            RadioButton22.Enabled = False
            Label49.Text = Form1.Threes
            p1UpperScore += Form1.Threes
        End If

        If RadioButton21.Checked Then
            Label18.Visible = False
            RadioButton21.Enabled = False
            Label47.Text = Form1.Fours
            p1UpperScore += Form1.Fours
        End If

        If RadioButton20.Checked Then
            Label19.Visible = False
            RadioButton20.Enabled = False
            Label46.Text = Form1.Fives
            p1UpperScore += Form1.Fives
        End If

        If RadioButton19.Checked Then
            Label20.Visible = False
            RadioButton19.Enabled = False
            Label45.Text = Form1.sixes
            p1UpperScore += Form1.sixes
        End If

        If RadioButton18.Checked Then
            Label25.Visible = False
            RadioButton18.Enabled = False
            Label56.Text = Form1.Choice
            p1TotalScore += Form1.Choice '초이스부터는 서브토탈이 아닌 총점수로 점수를 보냄
        End If

        If RadioButton17.Checked Then
            Label26.Visible = False
            RadioButton17.Enabled = False
            Label57.Text = Form1.fourkinds
            p1TotalScore += Form1.fourkinds
        End If

        If RadioButton16.Checked Then
            Label24.Visible = False
            RadioButton16.Enabled = False
            Label55.Text = Form1.fullhoues
            p1TotalScore += Form1.fullhoues
        End If

        If RadioButton15.Checked Then
            Label23.Visible = False
            RadioButton15.Enabled = False
            Label54.Text = Form1.sstraight * 15 '스트레이트는 카운터에 15를 곱함
            p1TotalScore += Form1.sstraight * 15
        End If

        If RadioButton14.Checked Then
            Label22.Visible = False
            RadioButton14.Enabled = False
            Label53.Text = Form1.lstraight * 30 '라지 스트레이트는 30을 곱함 
            p1TotalScore += Form1.lstraight * 30
        End If

        If RadioButton13.Checked Then
            Label21.Visible = False
            RadioButton13.Enabled = False
            Label52.Text = Form1.YachtCnt * 50 'yacht는 50을 곱함
            p1TotalScore += Form1.YachtCnt * 50
        End If

        If RadioButton1.Checked Then
            Label41.Visible = False
            RadioButton1.Enabled = False
            Label68.Text = Form1.Ace
            p2UpperScore += Form1.Ace
        End If

        If RadioButton2.Checked Then
            Label42.Visible = False
            RadioButton2.Enabled = False
            Label69.Text = Form1.Deuces
            p2UpperScore += Form1.Deuces
        End If

        If RadioButton4.Checked Then
            Label40.Visible = False
            RadioButton4.Enabled = False
            Label67.Text = Form1.Threes
            p2UpperScore += Form1.Threes
        End If

        If RadioButton3.Checked Then
            Label39.Visible = False
            RadioButton3.Enabled = False
            Label66.Text = Form1.Fours
            p2UpperScore += Form1.Fours
        End If

        If RadioButton6.Checked Then
            Label38.Visible = False
            RadioButton6.Enabled = False
            Label65.Text = Form1.Fives
            p2UpperScore += Form1.Fives
        End If

        If RadioButton5.Checked Then
            Label37.Visible = False
            RadioButton5.Enabled = False
            Label64.Text = Form1.sixes
            p2UpperScore += Form1.sixes
        End If

        If RadioButton12.Checked Then
            Label35.Visible = False
            RadioButton12.Enabled = False
            Label62.Text = Form1.Choice
            p2TotalScore += Form1.Choice
        End If

        If RadioButton11.Checked Then
            Label36.Visible = False
            RadioButton11.Enabled = False
            Label63.Text = Form1.fourkinds
            p2TotalScore += Form1.fourkinds
        End If

        If RadioButton10.Checked Then
            Label34.Visible = False
            RadioButton10.Enabled = False
            Label61.Text = Form1.fullhoues
            p2TotalScore += Form1.fullhoues
        End If

        If RadioButton9.Checked Then
            Label33.Visible = False
            RadioButton9.Enabled = False
            Label60.Text = Form1.sstraight * 15
            p2TotalScore += Form1.sstraight * 15
        End If

        If RadioButton8.Checked Then
            Label32.Visible = False
            RadioButton8.Enabled = False
            Label59.Text = Form1.lstraight * 30
            p2TotalScore += Form1.lstraight * 30
        End If

        If RadioButton7.Checked Then
            Label34.Visible = False
            RadioButton7.Enabled = False
            Label61.Text = Form1.YachtCnt * 50
            p2TotalScore += Form1.YachtCnt * 50
        End If

        If Form1.playerturn Mod 2 = 1 Then
            Form1.Label5.Text = Form4.Player1
        ElseIf Form1.playerturn Mod 2 = 0 Then
            Form1.Label5.Text = Form4.Player2
        End If
        Form1.Label6.Text = Form1.turnCount & "/ 12"

        If p1UpperScore >= 63 And p1BonusCnt = 0 Then '서브토탈이 63이상일 경우
            p1BonusCnt = 1 '보너스 카운터 추가
        End If

        If p2UpperScore >= 63 And p2BonusCnt = 0 Then
            p1BonusCnt = 1
        End If

        Label27.Text = p1UpperScore '서브토탈
        Label51.Text = p2UpperScore
        Label28.Text = p1TotalScore + p1UpperScore + p1BonusCnt * 35 '총점수: 서브토탈 + (보너스) + 총점수
        Label29.Text = p2TotalScore + p2UpperScore + p2BonusCnt * 35

        Form1.ProgressBar1.Value = 0
    End Sub
End Class