Public Class Form1
    Private Sub Gen1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Gen1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PokedexDataDataSet)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Gen1TableAdapter.Fill(Me.PokedexDataDataSet.Gen1)
        PkmnList.SelectedIndex = 0
    End Sub

    Private Sub PkmnList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PkmnList.SelectedIndexChanged
        Try
            Dim elem() As String = {"None", "Bug", "Dragon", "Electric", "Fighting", "Fire", "Flying", "Ghost",
                                "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water"}
            Dim strPkmnAb, pkmnBs1, pkmnBs2 As String
            Dim type1, type2 As Object
            Dim ctchRate As Integer

            strPkmnAb = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(5).Value
            pkmnBs1 = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(7).Value
            pkmnBs2 = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(8).Value
            ctchRate = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(10).Value

            Select Case True
                Case counter(PkmnList.SelectedIndex) + 1
                    txtPkmnName.Text = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(1).Value
                    pctLarge.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Large", counter(PkmnList.SelectedIndex) + 1 & ".png"))
                    pctFeet.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Feet", counter(PkmnList.SelectedIndex) + 1 & ".png"))
                    pctSprite.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sprite", counter(PkmnList.SelectedIndex) + 1 & ".png"))
                    pctMed1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Med1", counter(PkmnList.SelectedIndex) + 1 & ".png"))
                    pctMedB.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MedB", counter(PkmnList.SelectedIndex) + 1 & ".png"))

                    txtCat.Text = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(4).Value
                    txtPkmnDesc.Text = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(6).Value
                    txtPkmnAb.Text = splitterA(strPkmnAb)
                    txtDex.Text = dexNo(Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(0).Value)
                    txtEV.Text = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(9).Value

                    Dim splitA() As String
                    splitA = pkmnBs1.Split(" ")
                    pbHP.Value = CInt(splitA(0))
                    pbAT.Value = CInt(splitA(1))
                    pbDE.Value = CInt(splitA(2))

                    Dim splitB() As String
                    splitB = pkmnBs2.Split(" ")
                    pbSA.Value = CInt(splitB(0))
                    pbSD.Value = CInt(splitB(1))
                    pbSE.Value = CInt(splitB(2))

                    type1 = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(2).Value
                    If type1 = elem(0) Then
                        txtType1.Visible = False
                    Else
                        txtType1.Visible = True
                    End If
                    If type1 = elem(1) Then
                        txtType1.Text = "BUG"
                        txtType1.BackColor = Color.YellowGreen
                        txtType1.ForeColor = Color.Black
                    End If
                    If type1 = elem(2) Then
                        txtType1.Text = "DRAGON"
                        txtType1.BackColor = Color.Indigo
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(3) Then
                        txtType1.Text = "ELECTRIC"
                        txtType1.BackColor = Color.Gold
                        txtType1.ForeColor = Color.Black
                    End If
                    If type1 = elem(4) Then
                        txtType1.Text = "FIGHTING"
                        txtType1.BackColor = Color.Maroon
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(5) Then
                        txtType1.Text = "FIRE"
                        txtType1.BackColor = Color.Red
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(6) Then
                        txtType1.Text = "FLYING"
                        txtType1.BackColor = Color.LightCyan
                        txtType1.ForeColor = Color.Black
                    End If
                    If type1 = elem(7) Then
                        txtType1.Text = "GHOST"
                        txtType1.BackColor = Color.DarkSlateBlue
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(8) Then
                        txtType1.Text = "GRASS"
                        txtType1.BackColor = Color.DarkOliveGreen
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(9) Then
                        txtType1.Text = "GROUND"
                        txtType1.BackColor = Color.Peru
                        txtType1.ForeColor = Color.Black
                    End If
                    If type1 = elem(10) Then
                        txtType1.Text = "ICE"
                        txtType1.BackColor = Color.SkyBlue
                        txtType1.ForeColor = Color.Black
                    End If
                    If type1 = elem(11) Then
                        txtType1.Text = "NORMAL"
                        txtType1.BackColor = Color.Salmon
                        txtType1.ForeColor = Color.Black
                    End If
                    If type1 = elem(12) Then
                        txtType1.Text = "POISON"
                        txtType1.BackColor = Color.DarkMagenta
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(13) Then
                        txtType1.Text = "PSYCHIC"
                        txtType1.BackColor = Color.Orchid
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(14) Then
                        txtType1.Text = "ROCK"
                        txtType1.BackColor = Color.SaddleBrown
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(15) Then
                        txtType1.Text = "STEEL"
                        txtType1.BackColor = Color.DarkCyan
                        txtType1.ForeColor = Color.White
                    End If
                    If type1 = elem(16) Then
                        txtType1.Text = "WATER"
                        txtType1.BackColor = Color.DodgerBlue
                        txtType1.ForeColor = Color.White
                    End If

                    type2 = Gen1DataGridView.Rows.Item(counter(PkmnList.SelectedIndex)).Cells(3).Value
                    If type2 = elem(0) Then
                        txtType2.Visible = False
                    Else
                        txtType2.Visible = True
                    End If
                    If type2 = elem(1) Then
                        txtType2.Text = "BUG"
                        txtType2.BackColor = Color.YellowGreen
                        txtType2.ForeColor = Color.Black
                    End If
                    If type2 = elem(2) Then
                        txtType2.Text = "DRAGON"
                        txtType2.BackColor = Color.Indigo
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(3) Then
                        txtType2.Text = "ELECTRIC"
                        txtType2.BackColor = Color.Gold
                        txtType2.ForeColor = Color.Black
                    End If
                    If type2 = elem(4) Then
                        txtType2.Text = "FIGHTING"
                        txtType2.BackColor = Color.Maroon
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(5) Then
                        txtType2.Text = "FIRE"
                        txtType2.BackColor = Color.Red
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(6) Then
                        txtType2.Text = "FLYING"
                        txtType2.BackColor = Color.LightCyan
                        txtType2.ForeColor = Color.Black
                    End If
                    If type2 = elem(7) Then
                        txtType2.Text = "GHOST"
                        txtType2.BackColor = Color.DarkSlateBlue
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(8) Then
                        txtType2.Text = "GRASS"
                        txtType2.BackColor = Color.DarkOliveGreen
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(9) Then
                        txtType2.Text = "GROUND"
                        txtType2.BackColor = Color.Peru
                        txtType2.ForeColor = Color.Black
                    End If
                    If type2 = elem(10) Then
                        txtType2.Text = "ICE"
                        txtType2.BackColor = Color.SkyBlue
                        txtType2.ForeColor = Color.Black
                    End If
                    If type2 = elem(11) Then
                        txtType2.Text = "NORMAL"
                        txtType2.BackColor = Color.Salmon
                        txtType2.ForeColor = Color.Black
                    End If
                    If type2 = elem(12) Then
                        txtType2.Text = "POISON"
                        txtType2.BackColor = Color.DarkMagenta
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(13) Then
                        txtType2.Text = "PSYCHIC"
                        txtType2.BackColor = Color.Orchid
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(14) Then
                        txtType2.Text = "ROCK"
                        txtType2.BackColor = Color.SaddleBrown
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(15) Then
                        txtType2.Text = "STEEL"
                        txtType2.BackColor = Color.DarkCyan
                        txtType2.ForeColor = Color.White
                    End If
                    If type2 = elem(16) Then
                        txtType2.Text = "WATER"
                        txtType2.BackColor = Color.DodgerBlue
                        txtType2.ForeColor = Color.White
                    End If

                    If ctchRate <= 26 Then
                        txtCR.Text = "EHARD"
                        txtCR.BackColor = Color.Maroon
                    ElseIf ctchRate <= 74 Then
                        txtCR.Text = "HARD"
                        txtCR.BackColor = Color.OrangeRed
                    ElseIf ctchRate <= 180 Then
                        txtCR.Text = "AVERAGE"
                        txtCR.BackColor = Color.Goldenrod
                    ElseIf ctchRate <= 255 Then
                        txtCR.Text = "EASY"
                        txtCR.BackColor = Color.Green
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function counter(x As Integer) As Integer
        x = PkmnList.SelectedIndex()
        Return x
    End Function

    Private Sub txtRand_Click(sender As Object, e As EventArgs) Handles txtRand.Click
        PkmnList.SelectedIndex = (150 * Rnd())
    End Sub

    Public Function dexNo(x As String) As String
        Dim strText As String = x.ToString()
        Dim dN() As Char = strText.ToCharArray()
        x = Nothing
        If UBound(dN) = 0 Then
            x = "#" & vbCrLf & "0" & vbCrLf & "0" & vbCrLf & dN(0)
        ElseIf UBound(dN) = 1 Then
            x = "#" & vbCrLf & "0" & vbCrLf & dN(0) & vbCrLf & dN(1)
        ElseIf UBound(dN) = 2 Then
            x = "#" & vbCrLf & dN(0) & vbCrLf & dN(1) & vbCrLf & dN(2)
        End If
        Return x
    End Function

    Public Function splitterA(z As String)
        Dim split() As String
        Dim temp As String
        If z.Contains(";") Then
            split = z.Split(";")
            z = Nothing
            For i = 0 To UBound(split) Step 1
                temp = split(i)
                If i <> UBound(split) Then
                    temp = temp & vbCrLf
                End If
                z += temp
            Next
        End If
        Return z
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("         A Generation 1 Pokedex" & vbCrLf &
               "        by Thomas Anthony C. Ortiz." & vbCrLf &
               "        All corresponding visuals and data" & vbCrLf &
               "      belongs to Gamefreak and Nintendo." & vbCrLf &
               "      For free and demonstrative use only.")
    End Sub
End Class
