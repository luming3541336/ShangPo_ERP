Imports System.Data.SqlClient

Public Class Set_Specification_Form
    Private ID As Integer
    Private mode As Integer
    Private strSpec As String
    Private arrSpec As List(Of String) = New List(Of String)
    Private conDB As Connection = New Connection
    Private otherClassArray As ArrayList = New ArrayList
    Private btn As Button '執行中的Button
    Public strClassName As String = Nothing '將所設定的類別樣式製作成一個字串
    Private selectedClassArray As String() '當按下按鈕選擇類別時會先暫存至此

    Public Sub New(ByVal ID As Integer, ByVal mode As Integer, ByVal strSpec As String)

        ' 設計工具需要此呼叫。

        InitializeComponent()
        Me.mode = mode
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.ID = ID
        Me.strSpec = strSpec
    End Sub
    '讀取產品的規格類別
    '  ↳此方法主要是顯示產品的對應類別，因此在Specification內省略紀錄SuID
    '  ↳OtherClassArray主要提供給ProdDGV內的prodClass顯示用，資料只需暫存，使用完畢即可刪除
    Private Sub LoadOtherClassForProd(ByVal prodID As Integer)
        Dim strSql As String = "Select Specification.SpecID, Specification.ClassName FROM ProdSet,Specification WHERE ProdSet.ProdID = @ProdID AND (ProdSet.SuID = Specification.SuID OR Specification.SuID = 0)"
        strSql = strSql.Replace("@ProdID", prodID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                otherClassArray.Add(New Specification(dataReader("SpecID"), Nothing, dataReader("ClassName")))
            Loop
        End If
        selectedClassArray = New String(otherClassArray.Count) {}
    End Sub
    Private Sub LoadOtherClassForFit(ByVal fitID As Integer)
        Dim strSql As String = "Select Specification.SpecID, Specification.ClassName FROM FittingSet,Specification WHERE FittingSet.FitID = @fitID AND (FittingSet.SuID = Specification.SuID OR Specification.SuID = 0)"
        strSql = strSql.Replace("@fitID", fitID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                otherClassArray.Add(New Specification(dataReader("SpecID"), Nothing, dataReader("ClassName")))
            Loop
        End If
        selectedClassArray = New String(otherClassArray.Count) {}
    End Sub
    Private Function LoadOtherClassDetail(ByVal otherClassID As Integer) As ArrayList
        Dim detailName As ArrayList = New ArrayList
        Dim strSql As String = "SELECT * FROM SpecificationDetail Where SpecID = @SpecID"
        strSql = strSql.Replace("@SpecID", otherClassID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                detailName.Add(dataReader("DetailName"))
            Loop
        End If
        Return detailName
    End Function
    '篩選類別內詳細項目並透過ContextMenuStrip顯示
    Private Sub showDetail(ByRef btn As Button, ByVal otherClassID As Integer)
        Me.btn = btn
        Dim menu As ContextMenuStrip = New ContextMenuStrip
        Dim detailName As ArrayList = LoadOtherClassDetail(otherClassID)
        For Each data As String In detailName
            menu.Items.Add(data)
        Next
        menu.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        AddHandler menu.ItemClicked, AddressOf Menu_itemClick
        menu.Show(Cursor.Position)
    End Sub
    '當類別按鈕按下時執行
    Private Sub Btn_Click(sender As Object, e As EventArgs)
        showDetail(sender, otherClassArray(sender.Name).SpecID)
    End Sub
    '按下ContextMenuStrip 內一個按鈕時執行
    '  ↳按下後會改變button的內容，作為設定用
    Private Sub Menu_itemClick(sender As Object, e As ToolStripItemClickedEventArgs)
        btn.Text = e.ClickedItem.Text + "(已設定)"
        selectedClassArray(btn.Name) = e.ClickedItem.Text
    End Sub
    Private Sub LoadingBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles loadingBackground.DoWork
        If mode = 0 Then
            LoadOtherClassForProd(ID)
        ElseIf mode = 1 Then
            LoadOtherClassForFit(ID)
        End If

    End Sub

    Private Sub loadingBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles loadingBackground.RunWorkerCompleted
        For data As Integer = 0 To otherClassArray.Count - 1
            Dim btn As Button = New Button With {
                .Name = data,
                .Text = otherClassArray(data).ClassName,
                .AutoSize = True
                }
            AddHandler btn.Click, AddressOf Btn_Click
            mainLayout.Controls.Add(btn)
            If arrSpec IsNot Nothing Then
                For Each i As String In arrSpec.ToArray
                    Dim detailName As ArrayList = LoadOtherClassDetail(otherClassArray(data).SpecID)
                    For Each j As String In detailName
                        If i.Equals(j) Then
                            btn.Text = i
                            selectedClassArray(btn.Name) = i
                            arrSpec.RemoveAt(arrSpec.IndexOf(i))
                            Exit For
                        End If
                    Next

                Next
            End If
        Next
        If arrSpec.Count <> 0 Then
            For Each i As String In arrSpec
                customizeText.Text += i & ";"
            Next
            customizeText.Text = customizeText.Text.Substring(0, customizeText.Text.Length - 1)
        End If

    End Sub

    Private Sub SetClassByPurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If strSpec <> Nothing Then
            arrSpec = AnalysisString(strSpec)
        End If
        loadingBackground.RunWorkerAsync()
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        For Each data As String In selectedClassArray
            If data <> Nothing Then
                strClassName += data & ";"
            End If
        Next
        If customizeText.Text <> "" Then
            strClassName += customizeText.Text + ";"
        End If
        If strClassName <> Nothing Then
            strClassName = strClassName.TrimEnd(";")
        End If
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Function AnalysisString(ByVal strSpec As String) As List(Of String)
        Dim arrSpec As List(Of String) = strSpec.Split(";").ToList
        Return arrSpec
    End Function
End Class