using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Aloys.Companion
{
    public partial class frmMain : Form
    {
        string file = @"versions.conf";
        string file2 = @"cdns.conf";
        string file3 = @"certs.conf";
        string config_wtf = String.Empty;
        List<string> config = new List<string>();
        SimpleHTTPServer httpd = new SimpleHTTPServer(@"www", 80);

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            cmbVersion.SelectedIndex = Properties.Settings.Default.game;

            CheckConf();
            txtVersions.Text = File.ReadAllText(file);
            txtCDNS.Text = File.ReadAllText(file2);
            txtCerts.Text = Encoding.UTF8.GetString(Convert.FromBase64String(File.ReadAllText(file3)));

            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVersions.Text.Length <= 36 &&
                txtCDNS.Text.Length <= 32 &&
                txtVersions.Text.Length != 0 &&
                txtCDNS.Text.Length != 0 &&
                txtCerts.Text.Length != 0 &&
                txtPortal.Text.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(file, false))
                {
                    sw.Write(txtVersions.Text);
                }

                using (StreamWriter sw = new StreamWriter(file2, false))
                {
                    sw.Write(txtCDNS.Text);
                }

                using (StreamWriter sw = new StreamWriter(file3, false))
                {
                    sw.Write(Convert.ToBase64String(Encoding.UTF8.GetBytes(txtCerts.Text)));
                }

                for (int i = 0; i < config.Count; i++)
                {
                    if (config[i].Contains("SET portal"))
                    {
                        config[i] = config[i].Replace(config[i], "SET portal \"" + txtPortal.Text + "\"");
                        break;
                    }
                }

                if (!File.Exists(config_wtf))
                {
                    MessageBox.Show("No Config.wtf found!",
                    "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPortal.Text = "";
                }
                else
                    File.WriteAllLines(config_wtf, config);

                MessageBox.Show("New settings saved!",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Values are not correct! Versions only 36 chars and cdns only 32 chars! Portal needs to be set!",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtVersions_TextChanged(object sender, EventArgs e)
        {
            if (txtVersions.Text.Length <= 36 && txtVersions.Text.Length != 0)
                txtVersions.BackColor = Color.SpringGreen;
            else
                txtVersions.BackColor = Color.Tomato;
        }

        private void txtCDNS_TextChanged(object sender, EventArgs e)
        {
            if (txtCDNS.Text.Length <= 32 && txtCDNS.Text.Length != 0)
                txtCDNS.BackColor = Color.SpringGreen;
            else
                txtCDNS.BackColor = Color.Tomato;
        }

        private void txtPortal_TextChanged(object sender, EventArgs e)
        {
            if (txtPortal.Text.Length > 0)
                txtPortal.BackColor = Color.SpringGreen;
            else
                txtPortal.BackColor = Color.Tomato;
        }
        private void CheckConf()
        {
            // prüfen, ob alle confs da. wenn nicht, mit std werten füllen

            if (!File.Exists(file))
            {
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.Write("localhost/retail/versions");
                }
            }

            if (!File.Exists(file2))
            {
                using (StreamWriter sw = File.AppendText(file2))
                {
                    sw.Write("localhost/retail/cdns");
                }
            }

            if (!File.Exists(file3))
            {
                using (StreamWriter sw = File.AppendText(file3))
                {
                    sw.Write("eyJDcmVhdGVkIjoxNDYzNDA3MjM4LCJDZXJ0aWZpY2F0ZXMiOlt7IlVyaSI6IiouKiIsIlNoYUhhc2hQdWJsaWNLZXlJbmZvIjoiRDlDOUVBODcyQjgxQ0U4RkE0MDU1QTQ1NTI3QjA5MzAyQzVDRTEwRDlGOTQwNDMwMENBOTc2NzY0ODA0QUU3RiJ9LHsiVXJpIjoiKi4qIiwiU2hhSGFzaFB1YmxpY0tleUluZm8iOiJCMTI0MUQ4MzE5OTlENEE2N0IwQzZGOUE2ODczMzFDODdGQkE5QjJDREM0Q0FDMzY5NEFEQUQ2MjJGMDE5NTJCIn1dLCJQdWJsaWNLZXlzIjpbeyJVcmkiOiIqLioiLCJTaGFIYXNoUHVibGljS2V5SW5mbyI6IkQ5QzlFQTg3MkI4MUNFOEZBNDA1NUE0NTUyN0IwOTMwMkM1Q0UxMEQ5Rjk0MDQzMDBDQTk3Njc2NDgwNEFFN0YifSx7IlVyaSI6IiouKiIsIlNoYUhhc2hQdWJsaWNLZXlJbmZvIjoiQjEyNDFEODMxOTk5RDRBNjdCMEM2RjlBNjg3MzMxQzg3RkJBOUIyQ0RDNENBQzM2OTRBREFENjIyRjAxOTUyQiJ9XSwiU2lnbmluZ0NlcnRpZmljYXRlcyI6W3siUmF3RGF0YSI6Ii0tLS0tQkVHSU4gQ0VSVElGSUNBVEUtLS0tLU1JSUZ6VENDQTdXZ0F3SUJBZ0lKQU5OcjdsdHVPcnZFTUEwR0NTcUdTSWIzRFFFQkN3VUFNSHd4Q3pBSkJnTlZCQVlUQWtSRk1STXdFUVlEVlFRSURBcFRiMjFsTFZOMFlYUmxNUm93R0FZRFZRUUtEQkZCY21OMGFYVnRJRVZ0ZFd4aGRHbHZiakVkTUJzR0ExVUVDd3dVUVhKamRHbDFiU0JGYlhWc1lYUnBiMjRnUTBFeEhUQWJCZ05WQkFNTUZFRnlZM1JwZFcwZ1JXMTFiR0YwYVc5dUlFTkJNQ0FYRFRFMk1EVXhOakU1TURNek5Gb1lEekl3TlRZd05UQTJNVGt3TXpNMFdqQjhNUXN3Q1FZRFZRUUdFd0pFUlRFVE1CRUdBMVVFQ0F3S1UyOXRaUzFUZEdGMFpURWFNQmdHQTFVRUNnd1JRWEpqZEdsMWJTQkZiWFZzWVhScGIyNHhIVEFiQmdOVkJBc01GRUZ5WTNScGRXMGdSVzExYkdGMGFXOXVJRU5CTVIwd0d3WURWUVFEREJSQmNtTjBhWFZ0SUVWdGRXeGhkR2x2YmlCRFFUQ0NBaUl3RFFZSktvWklodmNOQVFFQkJRQURnZ0lQQURDQ0Fnb0NnZ0lCQUwyekdPL1RpQm04OUtLa1lZeWEyaDJ6UWhLVTA2T2VqT0RrWUMvUEJ0RjlkRFJRL1E3KzRqek4rSnVBK1RsM3RUakNVMTZXSFZYUEtXSXRNN1c1d0N1RlN3ZkdaUkh5cUwvQ0k5dHUyUWFsVVVQUVdBTFJvUE5HUGRDbFdvOUdydHpIaW5kYSs2WnBJQmQxS2RYZUVFbnh0MGl4K0VKRisxWUpveW51dlJyMHlCbzFuUkE3bjY4TzAwZ00wdGhaa0VuUDd1K1UrZWdaWnBTTjU0N01NSVFvMWlqUDk1V2p4d2FBUC9QRzc3NGxnd3V1Q1E1dk5KNUNHaHdPbVIzMFBwUUo3RGRFYjFOUFFDWDRKWkhYa3RnMktrUkt0T09oYjFoN2FvNDNVZzMwUVhKQ0FxQXlmYW0rZkxIVVpmQzVyS1JhYm0xa3FXcVQwTWtXRzArMnpFWWIvYmVqellWZVdRMncySlZod1UzamFmNE8vcEljQTM4eExxelRIQTB1M1hrKzdPcmlIdTFDMWl4a0pqK1ZYczdhOFI2eUMyZE9qbGIxL0Y0MDgrNlFlMFpXTExTSnNDNndWTmoyaDdQMk5tUGg2M0puVmk5M1VnOVFlMUdWM1Rvb2dKVW1DNmpPS2VidXp4ZHpBelZwekhKSU92QzZkeWVjSER4VHZxYVNTRjBxdXo4T2grZHhHYlh3QnlmK2pKQ3c3S0ZFVFB2ci9ya1F2YjJlQkk0aXZjR0lDQWJjMzY3cnJuUTRTV0VlNksrenBNSzd2cWpFSG1LNmVSRjBlN2RMV01UeXpSeHdtV0RCVkJMMEZaME5nQXpMMDF3dlcxWDFVbENvWlJKZVcxYUtYYWVSZEl3UldNWlNFT3hHaUp2b2ZRQkFjTWtsZlU3YmswWUltb2Q1QWdNQkFBR2pVREJPTUIwR0ExVWREZ1FXQkJRdERMaXVIVjJ3MU9xSXFCN294eDRkdjVKSzNUQWZCZ05WSFNNRUdEQVdnQlF0RExpdUhWMncxT3FJcUI3b3h4NGR2NUpLM1RBTUJnTlZIUk1FQlRBREFRSC9NQTBHQ1NxR1NJYjNEUUVCQ3dVQUE0SUNBUUI1ZHJmYnQzZFZWWFljWnA1M0c0TTFiM3NNa1FacGFGZ0tyYXh0R3BGbHdCV0JId2cvSE9zSWNyUUxRbVdFdlFNbmRabFAvdy9PaDVmbXJiSS8wZTl2OTJURHlHL3hOUG9IdXJaa1gxb2xPaWp1YS8vTGxZRXBPSVltR29oMlF2WitiMlZFVnQ2VHZ0d1JqL0xSZVA4SFJaZmNTR05YdVRZL2s3TUZzTUZFeEpqOC9ITXgrclFaRXBPTXF3aVdkM3RVMWZnK25abHFvcUtlM1lsVEhwTXVuN3RQc0ZDMFUwOTc2cmNWNHlobGIyU0t2eHlyS3djK0V5YkF5d0diczBCYktLZFlkOTdGa2Z1NnkwQnF6YmVTM3NmeC9QT3ozVXpBOWJUTStVaksvbVZLZjUxSkdKdEFZdkFFUVJ0Q3YycW1BMERkQVRuM3lFY01mNzhDQysvaWdsL3JzRk95anlDdWdjMHlFNnFRSFZBOWZKSmU3UUgydVJPUVhlWE1kMlNjVVdrTzE0UlFxOGhOUXJaQi92R1RIM2VFY0pxZlg2UlZ6b3p4M2w5bEFMRDZZb2QzUExpcXNnTVE0Y2w3UVRUUlB6SnNRVHBWZFF4RytIR1dXb3h0UTI4ZDkyWFVPRjI2bUJFQ3l5cDArbm5KVmVHYmhtdGRZeUZHREVrcFhIUjYyeWhyNnorRUpVdFNnSGhaeVN2eGk1SXBJRXhTdHZxZVRqNDVWTXJrZ0V2bmxrTU4vZW1hbUlEYTBIVStsV0s5dWJuSGRSV0g1dFZCQUpHNDdlcndKY0NqV1gzUHNWUFhDZUNuQnBUR3IyWWl2SXRTZldJS0VsSG1PTG1QR2FaVzd2OHp5bm1ISFRvUGgvMkRBck9rMWV4V2c1Z3JVeEVnMnZ0QkMyQVR4UT09LS0tLS1FTkQgQ0VSVElGSUNBVEUtLS0tLSJ9LHsiUmF3RGF0YSI6Ii0tLS0tQkVHSU4gQ0VSVElGSUNBVEUtLS0tLU1JSUY1RENDQTh5Z0F3SUJBZ0lKQUlnTHNsd2s0MFh6TUEwR0NTcUdTSWIzRFFFQkN3VUFNSDh4Q3pBSkJnTlZCQVlUQWxWVE1SUXdFZ1lEVlFRS0RBdFVjbWx1YVhSNVEyOXlaVEVxTUNnR0ExVUVDd3doVkhKcGJtbDBlVU52Y21VZ1EyVnlkR2xtYVdOaGRHVWdRWFYwYUc5eWFYUjVNUzR3TEFZRFZRUUREQ1ZVY21sdWFYUjVRMjl5WlNCQ1lYUjBiR1V1Ym1WMElFRjFjbTl5WVNCU2IyOTBJRU5CTUI0WERURTJNREl5T0RFeU5Ea3dPRm9YRFRNMk1ESXlNekV5TkRrd09Gb3dmekVMTUFrR0ExVUVCaE1DVlZNeEZEQVNCZ05WQkFvTUMxUnlhVzVwZEhsRGIzSmxNU293S0FZRFZRUUxEQ0ZVY21sdWFYUjVRMjl5WlNCRFpYSjBhV1pwWTJGMFpTQkJkWFJvYjNKcGRIa3hMakFzQmdOVkJBTU1KVlJ5YVc1cGRIbERiM0psSUVKaGRIUnNaUzV1WlhRZ1FYVnliM0poSUZKdmIzUWdRMEV3Z2dJaU1BMEdDU3FHU0liM0RRRUJBUVVBQTRJQ0R3QXdnZ0lLQW9JQ0FRREdyWVd2UzBtVlBhckpkOTZFNHovcWpDdlc2ZVIwYnVRKytWTkVxVmdlRzE0azRWNDF3a0V6YWtCNG5yMm9HSDEwejlKL2FxTGxXbnhhT2wreUo3QmFvbVVBQU9nSmFDeXFBSjhIYUVVKzdCYkRPNE1aWG10dzFBM1ljSHNCa1Z4NXdHbTN0Y0g1SUVYZlZodk5aRHF3QW1ZSWNtN2dLRmduZHM2UkZKbVJ4RjRXem5XaVJyMk1Ra1NPci9rYzJlUTJWVWc1YWZUbFR4WnZhL21YRVZwU2hpbnZiaGFNU2dGQlcrUWFoQ3dCSlZRYUxoRW4rV2M2WU51SEZtWi9pNzE2eEdiM2N1WXU4OVRGNDZpS1EvOUJtOHlFRkdnOFFBMjhJWlExc1hnVnB6Skk5ZW93RnRxQXdobDY1aXBqR3c0eEgzM29mK1djd0pRTmpGN0hYeW1ScWswV0FhMmp0WE9FaVNoSTNYRGxvYmxYN3ZLYkFlOVJGcGZWSXFUOFVmS1NPSkdRRFZ6dmw0d1NpaElOc2hPN1lnSXFwOTdNR25XdG5sV0NEYjJtY1NqOEpqbnpSakcya1paQ05SLzJsZ2ZDRy8xVkYrUUxoLzN2RDIrTjVZa0pacUJLMUpURkZ4K3A2NmxWUVdmZGgyTVhQbEdqYXQzNDNIWkdtMFlSN25Sam5nTzJqM1l0VG9qZEp4UmZMZ3p0UXY5NGpNdFdQSEUzOHlzVUs3bVM2S0txWVhxeUIxOUlPSEwyUUI4ZmptT04xaENkMHdEVzQyWkIyM3l3TmtBU3c2dUpEUjAyeFhOMndpeW5JSWIzY3o2em91WGQ2MHdDN3V0TVR2ZXE4K3JoRkZnbUZEZEkybzlnd1dRUEEvNDNPWUlsQWRLVmcyTlJoWGIvNmJ6Rmt3SURBUUFCbzJNd1lUQWRCZ05WSFE0RUZnUVVFdDZneGhmbUhFYzdyQk9xSEpFZk5rekd2M013SHdZRFZSMGpCQmd3Rm9BVUV0Nmd4aGZtSEVjN3JCT3FISkVmTmt6R3YzTXdEd1lEVlIwVEFRSC9CQVV3QXdFQi96QU9CZ05WSFE4QkFmOEVCQU1DQVlZd0RRWUpLb1pJaHZjTkFRRUxCUUFEZ2dJQkFGekNKa2NEQ1BWTWFsK1RobGlwMjZMUGtzelo0eldUc05zYlVZbVNlN2gwa21NV3Q0eDNtbVpJVGZ3Yi9leXNZQ25IVGhCVlRqWGo5VldCR2ZiRUNaL3hkeVhDMnVyK3FwME1tN3hIMld1c3dmN3lmUEMrVVNOTzYrL3RGUzI4MkZPL25NMHF1YUtWa25PQzhpb0NvQVNzQklDQjlsd1JvWVJLTkJ3Um4zcGtKcGxIZXBHYWhhSmV6NGVlZHVqTzNkenhEZEQzMnp5Mi9BZmRlRlhUeGhXWThQVGpNQktDMnpwVVFEN0tkdmwrRDhTZklzcTczYjhhOVhtaGROWDdxVGM2TWplY0NEN1dIQVAycnJLN2VwalRhVkpwNCtQWWx3N3FmaXgvTlQxZk5rcTJNYjJFNzdoMmVUb1VHMW1qcy9tdkcvNFdmVkNmTWFCSE9LYXc2ZnlaVUxmMzY2SmJ4MDJyOEswNVA1b3V2UzFaMERlMW1aSnVVRVVZaFRSU3MyUE9JZHJtVnJuOVI4M1k0bDdUS05QSmVscTJ1eUVjNHIrL2ZScmVySWxUNEhWbExQVEMzU2RXOHl0WVNVWlh4KzFOZkpmUWltaWV2ZUl5SWFUT1YzU2ZDNEVmZVh0UHRVcGNWSnZtRlhxVmJuWE9PN2JRVTYzYmZGdXVWU2VVNk9YV2pvRlJWa2RITllUR1VHYjV4ZzRoZ1dxbExXdldnMFdQZ0xMYWJNYmV0clA2YzUvUWhtbC9sMDduSkhlTG9WeGxGdXdzTDhIR2V1MEpXcW5td2FtcDQvbW1ibFJDOVVmeXJJUWVEUzhnc3g4cS90MnpkelQ0YkJwaDBucVlrWlN5aUlvUXpsTXJZZHJXeGVKbTNzUmVSMEczRmx1TCswM1RHSnlwR2Zoci0tLS0tRU5EIENFUlRJRklDQVRFLS0tLS0ifSx7IlJhd0RhdGEiOiItLS0tLUJFR0lOIENFUlRJRklDQVRFLS0tLS1NSUlGMmpDQ0E4S2dBd0lCQWdJQkFUQU5CZ2txaGtpRzl3MEJBUXNGQURCL01Rc3dDUVlEVlFRR0V3SlZVekVVTUJJR0ExVUVDZ3dMVkhKcGJtbDBlVU52Y21VeEtqQW9CZ05WQkFzTUlWUnlhVzVwZEhsRGIzSmxJRU5sY25ScFptbGpZWFJsSUVGMWRHaHZjbWwwZVRFdU1Dd0dBMVVFQXd3bFZISnBibWwwZVVOdmNtVWdRbUYwZEd4bExtNWxkQ0JCZFhKdmNtRWdVbTl2ZENCRFFUQWVGdzB4TmpBeU1qZ3hNekF4TWpKYUZ3MHpOakF5TWpNeE16QXhNakphTUhveEN6QUpCZ05WQkFZVEFsVlRNUlF3RWdZRFZRUUtEQXRVY21sdWFYUjVRMjl5WlRFcU1DZ0dBMVVFQ3d3aFZISnBibWwwZVVOdmNtVWdRMlZ5ZEdsbWFXTmhkR1VnUVhWMGFHOXlhWFI1TVNrd0p3WURWUVFERENCVWNtbHVhWFI1UTI5eVpTQkNZWFIwYkdVdWJtVjBJRUYxY205eVlTQkRRVENDQWlJd0RRWUpLb1pJaHZjTkFRRUJCUUFEZ2dJUEFEQ0NBZ29DZ2dJQkFNT2ltMG9NSjhoZWQyWk8wbjRGU1dDSytBcVRLcU9LRXdrWnptditmMGpkNWRIOUY5RG1sa3FHSlhiMUZXc2QrNXJwNkdiREhvck1zSkRJS0JmV3VOeG9WSHZnU1FVbkJYb3NZL1RUWG42RGJMQ05oWlduZnhBUnpBcDhUL0ZYTC9ybHdoUjFjWWtOK1d1Z0FxNTgvQWEra2hhRzJKTnZTYi9lMXk1S2lKN3dLTjJOYkZMWi9kSXNsQkU1Z0p6Z081aFUxOVdNMHZTWFJsMlB3MGdXQk52dlpVYTRGSDR0Vzk1emRBUnRBeEpQZ2cxZDIxcXRYbmZiRTh4VENMS0U1R0FJbE9LK3I5KzNlbHQ2eStFWmlaOGNxL2IvSmZwKzFHTkJBbFZMbHBQelM3TFFmK0R0VktKNEZUdEFEV21SV0VFeTR2YVVoYmxEZm8ybm9rTmRtY25UeTkzYm1PSHdKbEtrUlpWVC92d2hLbE1TSU50QkVYSmZaUytVTStDdmhJQWhTd1J3U2E5N056OFdFcE52V0p3bC9lVVQzRCtKT0YrYmtsVHZSN1Z3d3d0dVBnSmtzOCthTENqRUMvVDVuN0tvdHhUVjF0VzVPRDNEeTN1ckowMUlOZTBTRUhNTVBWUGoyZWpxSGcybmRHUkZkQzBRbG1JeE5wYVNHcXM1SDEycnhibXd5T3B2MlAwK0VTd2xXQ0puODdXVUpoYnM5ZXozbHI4T3lYQnlNcHZVNXdxSnh6clRNa0oyeEhRcDhYVklKY2xLSHQvaXJFeHJ1L3Y3d1MwNXVzdnI1ZkM0dUNJQ0FxUU81RWQ2T3ZQKy9rclczWU5SLzVVZ3pVcEZ6KzJtZDRBSVh1cjh1VTZxVkVjMzFmS3VmaVRXblZTMmgzdjF0Y2NHc0tnL0FnTUJBQUdqWmpCa01CMEdBMVVkRGdRV0JCU08xd3FjZ3FhODdjRHI4ZlBrdTRQa2wwTGhXVEFmQmdOVkhTTUVHREFXZ0JRUzNxREdGK1ljUnp1c0U2b2NrUjgyVE1hL2N6QVNCZ05WSFJNQkFmOEVDREFHQVFIL0FnRUFNQTRHQTFVZER3RUIvd1FFQXdJQmhqQU5CZ2txaGtpRzl3MEJBUXNGQUFPQ0FnRUF2eG55WE50Um9zTG5yRzRCQ2dyM3p3SHhIMFQ0aDJ5bGxDc3FjTTlERTNkQnp5anRJb29ITElFdHVLNUp0WktRYXdoOTVIZzlZL2UrYWlYUGdpSVp0c29ibUpuOEdvdmpCNkpwVXNpQTVJN05xTmZPZmNzWnUzOS9QWkMyRjBDOHQ3TTFGSG1RcFNFbkw1bTlwR25KNEt6aXkvWno0d29BZVQrdGlwSklTRFBKbldqdkl0UU9TOFd2L21TY2JIYS84WjdvMjFaSVRaTUdSRzhMSW84RnBjK3A4VlQ5eXNKMVd2UC9DYzFnNzAzb2pwZXJBRHNwS3BBL3lBV1NJMFdCcmxOVVVQM3pOL1JOS0pxK3B3S1NhZCszbzMwdFlHRGtmVFVNREZmc0o2OFV3YWxaSFB1d0N1RzVnNFpJaE1Rd3F6ZU9oWDhuVzQwUGNzYzlkUVBJRjJKekZIZlNSdEFVajBKQ2I1ZFMwOEFIN3oyd1FSRUxremVSNXgvNUdCNmI5Zmc5NnhqY0hXVHNmYkg3SzYzZTZMdjQrWkVnZ2ZCaXA1VkNMOXhBeU5LMjJwMVR2WExZNzNWMnp5cUo5ZEgvOGxHV2ZtK092UTFoelFid1BKN0o4QlBJdStmSkphT3plNTU3UUtUbWVIWVB2b2ovcTNYMnhMeU1YVzIzNmZ1NUVCWEsxUmhEZ3JSWHhmNGFIQjBCem43bnF1eVVVOHNwZExHOTdPbGp2R0VpRVNMajlvV1liWEtMbldxejZUV09uQW1UdFJMYUsyaWF1M2lQKzdsd2thb2VRNkRaSERrZ0x0aVR4N1Z3c1NKWlRVNW8rVFBqNHdmalM5SmwzajhQTVZQcGZHNUlGRjNFck9Fc3ovS1B1OU56ajd4L2wrT3RxSHc0UGl0aHVpZz0tLS0tLUVORCBDRVJUSUZJQ0FURS0tLS0tIn1dfQ==");
                }
            }
        }

        private void CheckConfWTF()
        {
            if (!File.Exists(config_wtf))
            {
                MessageBox.Show("No Config.wtf found!",
                "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPortal.Text = "";
            }
            else
            {
                config.Clear();
                config.AddRange(File.ReadAllLines(config_wtf));

                foreach (string str in config)
                {
                    if (str.Contains("SET portal"))
                    {
                        txtPortal.Text = str.Replace("SET portal ", String.Empty).Replace("\"", String.Empty);
                        break;
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (cmbVersion.SelectedIndex)
            {
                case 0:
                    {
                        if (File.Exists(@"Aloys WoW Launcher.exe"))
                        {
                            System.Diagnostics.Process.Start(@"Aloys WoW Launcher.exe");
                        }
                        else
                            MessageBox.Show("Launcher not found! Are Launcher and Companiontool in the same correct (e.g. C:\\World of Warcraft) directory?",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 1:
                    {
                        if (File.Exists(@"Aloys WoW Launcher.exe"))
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo(@"Aloys WoW Launcher.exe");
                            startInfo.WindowStyle = ProcessWindowStyle.Normal;
                            startInfo.Arguments = " --version Classic";
                            Process.Start(startInfo);
                        }
                        else
                            MessageBox.Show("Launcher not found! Are Launcher and Companiontool in the same correct (e.g. C:\\World of Warcraft) directory?",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 2:
                    {
                        if (File.Exists(@"Aloys WoW Launcher.exe"))
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo(@"Aloys WoW Launcher.exe");
                            startInfo.WindowStyle = ProcessWindowStyle.Normal;
                            startInfo.Arguments = " --version ClassicEra";
                            Process.Start(startInfo);
                        }
                        else
                            MessageBox.Show("Launcher not found! Are Launcher and Companiontool in the same correct (e.g. C:\\World of Warcraft) directory?",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }

            
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbVersion.SelectedIndex)
            {
                case 0:
                    {
                        config_wtf = @"_retail_\WTF\Config.wtf";
                        if (!File.Exists(file))
                        {
                            using (StreamWriter sw = File.CreateText(file))
                            {
                                sw.Write("localhost/retail/versions");
                            }
                        }

                        if (!File.Exists(file2))
                        {
                            using (StreamWriter sw = File.CreateText(file2))
                            {
                                sw.Write("localhost/retail/cdns");
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        config_wtf = @"_classic_\WTF\Config.wtf";
                        if (!File.Exists(file))
                        {
                            using (StreamWriter sw = File.CreateText(file))
                            {
                                sw.Write("localhost/classic/versions");
                            }
                        }

                        if (!File.Exists(file2))
                        {
                            using (StreamWriter sw = File.CreateText(file2))
                            {
                                sw.Write("localhost/classic/cdns");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        config_wtf = @"_classic_era\WTF\Config.wtf";
                        if (!File.Exists(file))
                        {
                            using (StreamWriter sw = File.CreateText(file))
                            {
                                sw.Write("localhost/classic_era/versions");
                            }
                        }

                        if (!File.Exists(file2))
                        {
                            using (StreamWriter sw = File.CreateText(file2))
                            {
                                sw.Write("localhost/classic_era/cdns");
                            }
                        }
                        break;
                    }
            }
            txtVersions.Text = File.ReadAllText(file);
            txtCDNS.Text = File.ReadAllText(file2);
            CheckConfWTF();
            Properties.Settings.Default.game = cmbVersion.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Local CDN links:\n\nRetail:\n\"localhost/retail/versions\"\n\"localhost/retail/cdns\"\n\nClassic:\n\"localhost/classic/versions\"\n\"localhost/classic/cdns\"\n\nClassic Era:\n\"localhost/classic_era/versions\"\n\"localhost/classic_era/cdns\"",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
