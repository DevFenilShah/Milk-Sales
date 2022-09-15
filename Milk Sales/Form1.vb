Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Form1
    Dim c As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("sqlcon").ConnectionString)
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds, ds1 As New DataSet()
    Dim CustDs As New DataSet()
    Dim dr, dr1 As SqlDataReader
    Dim WithEvents aTimer As New System.Windows.Forms.Timer 'could have been done in the Designer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbquantity.SelectedIndex = 0
        cmbtype.SelectedIndex = 0
    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    '    If (TextBox1.Text IsNot "") Then
    '        c.Open()
    '        cmd = New SqlCommand("select * from BarcodeMaster where BValue = '" + TextBox1.Text.Trim() + "'", c)
    '        dr = cmd.ExecuteReader()
    '        If (dr.Read()) Then
    '            dgvdata.Rows.Add(dr(0).ToString, dr(2).ToString, dr(3).ToString, dr(4).ToString)
    '            CalculateAmountandQuantity()
    '            TextBox1.Clear()
    '        Else
    '            MsgBox("There is no data for barcode.")
    '        End If
    '        c.Close()
    '    End If
    'End Sub

    Private Sub CalculateAmountandQuantity()
        Dim i As Integer = 0
        Dim iTotal As Integer = 0
        Dim iQuantity As Integer = 0
        For i = 0 To dgvdata.Rows.Count - 1

            If (dgvdata.Rows(i).Cells(1).Value.ToString().Contains("gm")) Then
                iQuantity += dgvdata.Rows(i).Cells(1).Value.ToString().Split(" ")(0)
            End If

            If (dgvdata.Rows(i).Cells(1).Value.ToString().Contains("ltr")) Then
                iQuantity += dgvdata.Rows(i).Cells(1).Value.ToString().Split(" ")(0) * 1000
            End If

            iTotal += Convert.ToDecimal(dgvdata.Rows(i).Cells(3).Value)
        Next
        lblquantity.Text = iQuantity / 1000 & "L"
        lblamount.Text = iTotal
    End Sub

    Private Sub dgvdata_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvdata.RowsRemoved
        CalculateAmountandQuantity()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        dgvdata.Rows.Clear()
        'TextBox1.Clear()
        lblamount.Text = "0"
        lblquantity.Text = "0"
        cmbquantity.SelectedIndex = 0
        cmbtype.SelectedIndex = 0
        chkcard.Checked = False
        chkcash.Checked = False
        chkdairy.Checked = False
        chkhouse.Checked = False
        chkSunil.Checked = False
        chkGanesh.Checked = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (dgvdata.Rows.Count > 0) Then
            c.Open()
            For i = 0 To dgvdata.Rows.Count - 1
                cmd = New SqlCommand("insert into SalesMaster(SDate,STime,Shift,CowType,Payment,Quantity,Amount) values(@Dt,@ST,@Shift,@CT,@Pay,@Quan,@Amount)", c)
                cmd.Parameters.AddWithValue("@Dt", DateTime.Now.Date.ToShortDateString())
                If (DateTime.Now.ToShortTimeString.Contains("AM")) Then
                    cmd.Parameters.AddWithValue("@Shift", "A")
                Else
                    cmd.Parameters.AddWithValue("@Shift", "P")
                End If
                cmd.Parameters.AddWithValue("@ST", DateTime.Now.ToString())
                cmd.Parameters.AddWithValue("@CT", dgvdata.Rows(i).Cells(0).Value)
                cmd.Parameters.AddWithValue("@Pay", dgvdata.Rows(i).Cells(2).Value)

                Dim iQuantity As Integer
                If (dgvdata.Rows(i).Cells(1).Value.ToString().Contains("gm")) Then
                    iQuantity = dgvdata.Rows(i).Cells(1).Value.ToString().Split(" ")(0)
                End If

                If (dgvdata.Rows(i).Cells(1).Value.ToString().Contains("ltr")) Then
                    iQuantity = dgvdata.Rows(i).Cells(1).Value.ToString().Split(" ")(0) * 1000
                End If

                cmd.Parameters.AddWithValue("@Quan", iQuantity)
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(dgvdata.Rows(i).Cells(3).Value))
                cmd.ExecuteNonQuery()
            Next
            c.Close()
            MsgBox("Data Saved.")
            dgvdata.Rows.Clear()
            'TextBox1.Clear()
            lblamount.Text = "0"
            lblquantity.Text = "0"
            cmbquantity.SelectedIndex = 0
            cmbtype.SelectedIndex = 0
            chkcard.Checked = False
            chkcash.Checked = False
            chkdairy.Checked = False
            chkhouse.Checked = False
            chkSunil.Checked = False
            chkGanesh.Checked = False
        Else
            MsgBox("There is no data to save.")
        End If
    End Sub

    Private Sub btnemail_Click(sender As Object, e As EventArgs) Handles btnemail.Click
        Try
            Cursor = Cursors.WaitCursor
            'Get Count data 
            Dim BodyText As String = "<h1>Please find the report</h1><table border=1 cellspacing=10 cellpadding=10>
                                            <tr align='center'><td>Type</td><td>Amount</td><td>Quantity</td></tr>"

            c.Open()
            cmd = New SqlCommand("GetEmailData", c)
            cmd.CommandType = CommandType.StoredProcedure
            If (DateTime.Now.ToShortTimeString.Contains("AM")) Then
                cmd.Parameters.AddWithValue("@Shift", "A")
            Else
                cmd.Parameters.AddWithValue("@Shift", "p")
            End If
            cmd.Parameters.AddWithValue("@dateValue", DateTime.Now.Date.ToShortDateString)

            da.SelectCommand = cmd
            da.Fill(ds)

            If (ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0) Then
                For Each row As DataRow In ds.Tables(0).Rows
                    If (row(0).ToString() = "Cash" Or row(0).ToString() = "Card" Or
                        row(0).ToString() = "Dairy" Or row(0).ToString() = "House" Or row(0).ToString() = "Sunil" Or row(0).ToString() = "Ganesh") Then
                        BodyText = BodyText & "<tr style='font-weight:bold;font-size:3em;'><td>" _
                            & row(0).ToString() & "</td><td>" & row(1).ToString() & "</td></tr>"
                    Else
                        BodyText = BodyText & "<tr style='font-size:1em;'><td>" & row(0).ToString() & "</td><td>" & row(1).ToString() & "</td><td>" & (Convert.ToInt32(row(2)) / 1000) & "L" & "</td></tr>"
                    End If
                Next
            Else
                MsgBox("There are no sales record.")
                Cursor = Cursors.Default
                Exit Sub
            End If
            ds.Clear()
            da.Dispose()
            c.Close()

            'Mail Preparation
            Dim Mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")

            If (DateTime.Now.ToShortTimeString.Contains("AM")) Then
                Mail.Subject = "Milk Sales Report - " & DateTime.Now.ToShortDateString() & " - Morning "
            Else
                Mail.Subject = "Milk Sales Report - " & DateTime.Now.ToShortDateString() & " - Evening "
            End If

            Mail.From = New MailAddress("milksales7@gmail.com")
            SMTP.Credentials = New System.Net.NetworkCredential("milksales7@gmail.com", "$dyXE2!3") '<-- Password Here

            Mail.To.Add("piyushbhakta1234@yahoo.com") 'I used ByVal here for address
            Mail.To.Add("atit8446@yahoo.in") 'I used ByVal here for address
            Mail.IsBodyHtml = True
            Mail.Body = BodyText

            SMTP.EnableSsl = True
            SMTP.Port = "587"
            SMTP.Send(Mail)
            Cursor = Cursors.Default
            MsgBox("Email Sent.")
            BodyText = String.Empty
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cmbtype.SelectedIndex = -1) Then
            MsgBox("Please select cow type.")
            Exit Sub
        End If

        If (cmbquantity.SelectedIndex = -1) Then
            MsgBox("Please select millk quantity.")
            Exit Sub
        End If

        If (chkcard.Checked = False And chkcash.Checked = False And chkdairy.Checked = False And chkhouse.Checked = False _
            And chkSunil.Checked = False And chkGanesh.Checked = False) Then
            MsgBox("Please select atleast one payment type.")
            Exit Sub
        End If

        c.Open()
        cmd = New SqlCommand("select MoneyValue from PriceMaster where CowType = '" & cmbtype.SelectedItem.ToString() & "'", c)
        dr = cmd.ExecuteReader()
        If (dr.Read()) Then
            Dim quantity As New Integer

            If (cmbquantity.SelectedItem.ToString().Contains("gm")) Then
                quantity = cmbquantity.SelectedItem.ToString().Split(" ")(0)
            End If

            If (cmbquantity.SelectedItem.ToString().Contains("ltr")) Then
                quantity = cmbquantity.SelectedItem.ToString().Split(" ")(0) * 1000
            End If

            Dim Amount As Integer = Math.Ceiling((quantity * Convert.ToInt32(dr(0))) / 1000)
            c.Close()

            If (chkcard.Checked) Then
                dgvdata.Rows.Add(cmbtype.SelectedItem, cmbquantity.SelectedItem, chkcard.Text, Amount)
            End If

            If (chkcash.Checked) Then
                dgvdata.Rows.Add(cmbtype.SelectedItem, cmbquantity.SelectedItem, chkcash.Text, Amount)
            End If

            If (chkdairy.Checked) Then
                dgvdata.Rows.Add(cmbtype.SelectedItem, cmbquantity.SelectedItem, chkdairy.Text, Amount)
            End If

            If (chkhouse.Checked) Then
                dgvdata.Rows.Add(cmbtype.SelectedItem, cmbquantity.SelectedItem, chkhouse.Text, Amount)
            End If

            If (chkSunil.Checked) Then
                dgvdata.Rows.Add(cmbtype.SelectedItem, cmbquantity.SelectedItem, chkSunil.Text, Amount)
            End If

            If (chkGanesh.Checked) Then
                dgvdata.Rows.Add(cmbtype.SelectedItem, cmbquantity.SelectedItem, chkGanesh.Text, Amount)
            End If

            CalculateAmountandQuantity()

            If (dgvdata.Rows.Count() >= 4) Then
                btnsave_Click(Me, New EventArgs())
            End If

            cmbtype.Select()

            cmbquantity.SelectedIndex = 0
            cmbtype.SelectedIndex = 0
            chkcard.Checked = False
            chkcash.Checked = False
            chkdairy.Checked = False
            chkhouse.Checked = False
            chkSunil.Checked = False
            chkGanesh.Checked = False
        End If
    End Sub

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        TImeLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles Me.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub
End Class
