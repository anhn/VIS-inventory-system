Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports Toolkit


Public Class BackupAndRestoreSetting
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFrequency As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBrowseFolder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFolder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRestore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRestoreBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRestore As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBackup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBrowseFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBackup As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnBrowseFolder = New DevExpress.XtraEditors.SimpleButton
        Me.txtFolder = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFrequency = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnRestore = New DevExpress.XtraEditors.SimpleButton
        Me.btnRestoreBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtRestore = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnBackup = New DevExpress.XtraEditors.SimpleButton
        Me.btnBrowseFile = New DevExpress.XtraEditors.SimpleButton
        Me.txtBackup = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFrequency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtRestore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBackup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnBrowseFolder)
        Me.GroupControl1.Controls.Add(Me.txtFolder)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtFrequency)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(412, 93)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Auto Backup Settings"
        '
        'btnBrowseFolder
        '
        Me.btnBrowseFolder.Location = New System.Drawing.Point(365, 53)
        Me.btnBrowseFolder.Name = "btnBrowseFolder"
        Me.btnBrowseFolder.Size = New System.Drawing.Size(35, 23)
        Me.btnBrowseFolder.TabIndex = 3
        Me.btnBrowseFolder.Text = "..."
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(125, 56)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(234, 20)
        Me.txtFolder.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Backup To Folder:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(days)"
        '
        'txtFrequency
        '
        Me.txtFrequency.Location = New System.Drawing.Point(125, 24)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Properties.Mask.EditMask = "d"
        Me.txtFrequency.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFrequency.Size = New System.Drawing.Size(100, 20)
        Me.txtFrequency.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Backup Frequency:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnRestore)
        Me.GroupControl2.Controls.Add(Me.btnRestoreBrowse)
        Me.GroupControl2.Controls.Add(Me.txtRestore)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.btnBackup)
        Me.GroupControl2.Controls.Add(Me.btnBrowseFile)
        Me.GroupControl2.Controls.Add(Me.txtBackup)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 111)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(412, 140)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Manual Backup And Restore"
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(125, 106)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(86, 23)
        Me.btnRestore.TabIndex = 9
        Me.btnRestore.Text = "R&estore"
        '
        'btnRestoreBrowse
        '
        Me.btnRestoreBrowse.Location = New System.Drawing.Point(365, 80)
        Me.btnRestoreBrowse.Name = "btnRestoreBrowse"
        Me.btnRestoreBrowse.Size = New System.Drawing.Size(35, 23)
        Me.btnRestoreBrowse.TabIndex = 8
        Me.btnRestoreBrowse.Text = "..."
        '
        'txtRestore
        '
        Me.txtRestore.Location = New System.Drawing.Point(125, 80)
        Me.txtRestore.Name = "txtRestore"
        Me.txtRestore.Size = New System.Drawing.Size(234, 20)
        Me.txtRestore.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Restore From File:"
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(125, 47)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(86, 23)
        Me.btnBackup.TabIndex = 6
        Me.btnBackup.Text = "&Backup"
        '
        'btnBrowseFile
        '
        Me.btnBrowseFile.Location = New System.Drawing.Point(365, 21)
        Me.btnBrowseFile.Name = "btnBrowseFile"
        Me.btnBrowseFile.Size = New System.Drawing.Size(35, 23)
        Me.btnBrowseFile.TabIndex = 5
        Me.btnBrowseFile.Text = "..."
        '
        'txtBackup
        '
        Me.txtBackup.Location = New System.Drawing.Point(125, 21)
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.Size = New System.Drawing.Size(234, 20)
        Me.txtBackup.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Backup To File:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(285, 269)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(62, 23)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(362, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(62, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFile"
        '
        'BackupAndRestoreSetting
        '
        Me.ClientSize = New System.Drawing.Size(437, 304)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackupAndRestoreSetting"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Backup And Restore"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFrequency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtRestore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBackup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public strCon As String
    Private Function ConvertPath(ByVal local As String) As String
        If local.LastIndexOf("\") < 0 Then Return ""
        Dim Folder As String = local.Substring(0, local.LastIndexOf("\") + 1)
        Dim conName As String = Dns.GetHostName()
        Dim serverName As String = DbManager.strConn
        Dim p As Integer = serverName.IndexOf("=") + 1
        serverName = serverName.Substring(p, serverName.IndexOf(";") - p)
        If (serverName.IndexOf("\") > 0) Then
            serverName = serverName.Substring(0, serverName.IndexOf("\"))
        End If
        If serverName.ToUpper() = conName.ToUpper() Then
            Return Folder
        End If
        Dim ret As String = "\\" + conName + "\"
        If Folder.LastIndexOf("\") = Folder.IndexOf("\") Then
            'get driver name
            Dim DriveLetter As String = Folder(0).ToString()
            ret = ret + Net.GetVolumeName(DriveLetter) + " (" + DriveLetter + ")"
        Else                        
            Folder = Folder.Remove(Folder.Length - 1)
            Dim i As Integer = Folder.LastIndexOf("\") + 1
            ret = ret + Folder.Substring(i, Folder.Length - i)
        End If
        Return ret
    End Function

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Dim path As String = ConvertPath(txtBackup.Text)
        If Not Directory.Exists(path) Then
            MessageBox.Show("This folder does not exitst or does not share, please check it again")
            Return
        End If
        'backup database [vis-pos] to disk='C:\test.bak'
        Dim i As String = txtBackup.Text.LastIndexOf("\")
        Dim f As String = txtBackup.Text.Substring(i, txtBackup.Text.Length - i)
        path = path + f

        If (File.Exists(path)) Then
            If (MessageBox.Show("Backup file already exists, do you want replace it?", "Replace", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK) Then
                Try
                    File.Delete(path)
                Catch
                    MessageBox.Show("Could not delete file")
                    Return
                End Try
            Else
                Return
            End If
        End If

        Dim sql As String = "Backup database [" + DBName() + "] to disk = '" + path + "'"

        DbManager.showMsgWhenError = False
        If DbManager.ExeSQLNoTransaction(sql) = False Then
            MessageBox.Show("Error in backing up, please make sure this folder allow to write.")
        Else
            MessageBox.Show("Backup successed")
        End If
        DbManager.showMsgWhenError = True
    End Sub

    Private Function DBName() As String
        Dim sql As String
        Dim beg As Integer
        Dim iEnd As Integer
        Try
            sql = strCon
            beg = sql.IndexOf("Initial Catalog")
            beg = Math.Max(0, beg)
            beg = sql.IndexOf("Database=", beg) + 9
            iEnd = sql.IndexOf(";", beg)
            Return sql.Substring(beg, iEnd - beg)
        Catch
            Return sql.Substring(beg, iEnd - beg)
        End Try
        Return ""
    End Function



    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        'restore database [vis-pos] from disk='C:\test.bak'
        Dim path As String = ConvertPath(txtRestore.Text)
        If Not Directory.Exists(path) Then
            MessageBox.Show("This folder does not exitst or does not share, please check it again")
            Return
        End If
        'backup database [vis-pos] to disk='C:\test.bak'
        Dim i As String = txtRestore.Text.LastIndexOf("\")
        Dim f As String = txtRestore.Text.Substring(i, txtRestore.Text.Length - i)
        path = path + f

        If (File.Exists(path) = False) Then
            MessageBox.Show("Please enter file name to do this function")
            Return
        End If

        If (File.Exists(Application.StartupPath + "\\Restorer.exe")) Then
            If (MessageBox.Show("The application must be restart to do this. Do you want to restart?", "Restart", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK) Then
                Dim db As String
                Dim file As StreamWriter = New StreamWriter(Application.StartupPath + "\\temp.txt")

                db = DBName()

                file.WriteLine(db)
                file.WriteLine(path)
                file.WriteLine(strCon.Replace(db, "master"))
                file.Flush()
                file.Close()

                Application.Exit()
                System.Diagnostics.Process.Start(Application.StartupPath + "\\Restorer.exe")

            End If
        Else
            MessageBox.Show("Could not found restorer.exe to restore database")

        End If

    End Sub

    Private Sub BackupAndRestoreSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtFrequency.Text = My.MySettings.Default.BAK_FREQ.ToString()
        'txtFolder.Text = My.MySettings.Default.BAK_FOLDER
        DbManager.strConn = strCon
        Dim strSQL As String = "SELECT Value FROM Configs WHERE Name = 'BAK_FREQ'"
        Dim freq As String = "30"

        If DbManager.ExeSQL(strSQL) = False Then
            Return
        End If

        Try
            Dim row As DataRow

            row = DbManager.OpenSqlRetDataTable(strSQL).Rows(0)
            freq = row("Value").ToString
        Catch ex As Exception

        End Try

        txtFrequency.Text = freq

        strSQL = "SELECT Value FROM Configs WHERE Name = 'BAK_FOLDER'"

        If DbManager.ExeSQL(strSQL) = False Then
            Return
        End If

        Try
            Dim row As DataRow

            row = DbManager.OpenSqlRetDataTable(strSQL).Rows(0)
            freq = row("Value").ToString
        Catch ex As Exception

        End Try

        txtFolder.Text = freq
        Console.WriteLine(Dns.GetHostName().ToString())
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If (Integer.Parse(txtFrequency.Text) <= 0) Then
            MessageBox.Show("Auto backup frequency must be greater than 0")
            txtFrequency.Select()

            Return
        End If

        If (Directory.Exists(txtFolder.Text) = False) Then
            MessageBox.Show("Auto backup folder does not exists!")
            txtFolder.Select()
            Return
        End If

        Dim sql As String = "UPDATE Configs Set Value = '" + txtFrequency.Text + "' WHERE Name = 'BAK_FREQ'"
        sql += ";UPDATE Configs Set Value = '" + txtFolder.Text + "' WHERE Name = 'BAK_FOLDER'"

        DbManager.ExeSQL(sql)
        DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub btnBrowseFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFolder.Click
        If (FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK) Then
            txtFolder.Text = FolderBrowser.SelectedPath
        End If
    End Sub

    Private Sub btnBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFile.Click
        If (SaveFile.ShowDialog = Windows.Forms.DialogResult.OK) Then
            txtBackup.Text = SaveFile.FileName
        End If
    End Sub

    Private Sub btnRestoreBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestoreBrowse.Click
        If (OpenFile.ShowDialog = Windows.Forms.DialogResult.OK) Then
            txtRestore.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub
    Private bChanging As Boolean = False
    Private Sub txtBackup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBackup.EditValueChanged

    End Sub
End Class

