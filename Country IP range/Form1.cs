using Country_IP_range.Home_Modules;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country_IP_range
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region Events
        public event EventHandler<TotalNewRangeEventArg> TotalNewRange;
        protected virtual void OnTotalNewRange(TotalNewRangeEventArg e)
        {
            TotalNewRange?.Invoke(this, e);
        }
        public event EventHandler<ProgressBarEventArg> Percent;
        protected virtual void OnPercent(ProgressBarEventArg e)
        {
            Percent?.Invoke(this, e);
        }
        public event EventHandler<NewIpRangeEventArg> NewRange;
        protected virtual void OnNewRange(NewIpRangeEventArg e)
        {
            NewRange?.Invoke(this, e);
        }
        #endregion
        public bool isPause = false;
        public Scanner scanner = new Scanner();
        public List<IPRanges> listIp = new List<IPRanges>();
        public Form1()
        {
            InitializeComponent();
            LoadListCountries();
            LoadSaveOptions();
            LoadSplitOptions();
            scanner.ipAddress += Scanner_ipAddress;
            scanner.IpRanges += Scanner_IpRanges;
            scanner.IsDone += Scanner_IsDone;
            CheckForIllegalCrossThreadCalls = false;
            this.NewRange += Form1_NewRange;
            this.Percent += Form1_Percent;
            this.TotalNewRange += Form1_TotalNewRange;
            //DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
        }

        private void Form1_TotalNewRange(object sender, TotalNewRangeEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                lblTotalImport.Text = "Status: " + "Running...";
                lblTotalImport.Update();
            }));
        }

        private void Form1_Percent(object sender, ProgressBarEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
             {
                 pgbPercentSplit.Properties.Step = e.Percent;
                 pgbPercentSplit.Properties.PercentView = true;
                 pgbPercentSplit.EditValue = e.Percent;
                 pgbPercentSplit.Update();
             }));
        }

        private void Form1_NewRange(object sender, NewIpRangeEventArg e)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
               {
                   mmSplitRanges.Text += e.NewIpRange + Environment.NewLine;
                   mmSplitRanges.SelectionStart = mmSplitRanges.Text.Length;
                   mmSplitRanges.ScrollToCaret();
               }));
            }
            catch
            {

            }
        }

        private void Scanner_IsDone(object sender, IsDoneScanEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                sbStart.Enabled = sbSave.Enabled = sbClear.Enabled = true;
            }));
        }

        private void Scanner_IpRanges(object sender, TotalRangeEventArg e)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    lblTotalIpRanges.Text = "Total: " + e.TotalRanges.ToString() + " ranges";
                }));
            }
            catch
            {

            }
        }

        private void Scanner_ipAddress(object sender, IPListUpdateEventArg e)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    listIp.Add(e.IPRange);
                    mmIPRange.Text += e.IPRange.IP + Environment.NewLine;
                    mmIPRange.SelectionStart = mmIPRange.Text.Length;
                    mmIPRange.ScrollToCaret();
                }));
            }
            catch
            {

            }
        }

        private void LoadListCountries()
        {
            var countries = Static.GetCountryToList();
            leCountries.Properties.DataSource = countries;
            leCountries.EditValue = countries[0];
        }

        private void LoadSplitOptions()
        {
            var splitOptions = Static.levelSplit;
            leSplitOptions.Properties.DataSource = splitOptions;
            leSplitOptions.Properties.DisplayMember = "Key";
            leSplitOptions.Properties.ValueMember = "Value";
            leSplitOptions.EditValue = splitOptions[0].Value;
            leSplitOptions.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", ""));
        }

        private void LoadSaveOptions()
        {
            var saveOptions = Static.saveOptions;
            leSaveOptions.Properties.DataSource = saveOptions;
            leSaveOptions.Properties.DisplayMember = "Key";
            leSaveOptions.Properties.ValueMember = "Value";
            leSaveOptions.EditValue = saveOptions[0].Value;
            leSaveOptions.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Options"));
        }

        private void sbStart_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                scanner.ScanIpAndWriteInBox(new ScanInfo()
                {
                    CountryName = leCountries.Text.ToLower(),
                });
            })
            { IsBackground = true }.Start();
            sbStart.Enabled = sbSave.Enabled = sbClear.Enabled = false;
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            mmIPRange.Text = string.Empty;
        }

        private void sbPause_Click(object sender, EventArgs e)
        {
            scanner.isPause = isPause;
            if (scanner.isPause == false) sbSave.Enabled = true;
            else
            {
                sbSave.Enabled = false;
            }
            isPause = !isPause;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            if (leSaveOptions.Text == "Text")
            {
                var sfd = new SaveFileDialog();
                sfd.Title = "File Text";
                sfd.Filter = "File Text|*.txt";
                var saveComfirm = XtraMessageBox.Show($"Save text file ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (saveComfirm == DialogResult.Cancel) return;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in listIp)
                    {
                        sb.AppendLine(item.IP);
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString());
                    var openFile = XtraMessageBox.Show("save succeeded! Open file ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (openFile == DialogResult.OK)
                    {
                        Process.Start(sfd.FileName);
                    }
                }
            }
            else if (leSaveOptions.Text == "Excel")
            {
                var sfd = new SaveFileDialog();
                sfd.Title = "File Excel";
                sfd.Filter = "File Excel|*.csv";
                var saveComfirm = XtraMessageBox.Show($"Save excel file ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (saveComfirm == DialogResult.Cancel) return;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in listIp)
                    {
                        sb.AppendLine(item.IP);
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString());
                    var openFile = XtraMessageBox.Show("save succeeded! Open file ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (openFile == DialogResult.OK)
                    {
                        Process.Start(sfd.FileName);
                    }
                }
            }
        }
        public List<string> fileIpRage = new List<string>();
        private void sbLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Text file";
            ofd.Filter = "Text file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] moFile = File.ReadAllLines(ofd.FileName);
                lblFilePath.Text = ofd.FileName.ToString();
                fileIpRage = moFile.ToList();
            }
        }
        public List<string> newIpRanges = new List<string>();
        public Random rand = new Random();
        int pgb = 0;
        private async void sbSplit_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                mmSplitRanges.Text = string.Empty;
                sbSplit.Enabled = leSplitOptions.Enabled = sbCheckDup.Enabled = sbSaveFile.Enabled = false;
                foreach (var item in fileIpRage)
                {
                    Thread.Sleep(1);
                    while (true)
                    {
                        if (isPauseSplit == true)
                        {
                            Thread.Sleep(5);
                        }
                        else
                        {
                            break;
                        }
                    }
                    string leftSide = item.Split('-')[0];
                    string rightSide = item.Split('-')[1];
                    var splitLeftIp = leftSide.Split('.');
                    var splitRightIp = rightSide.Split('.');
                    if (leSplitOptions.EditValue.ToString() == "1")
                    {
                        SplitOption1(splitLeftIp, splitRightIp);
                    }
                    else if (leSplitOptions.EditValue.ToString() == "2")
                    {
                        SplitOption2(splitLeftIp, splitRightIp);
                    }
                    else
                    {
                        SplitOption3(splitLeftIp, splitRightIp);
                    }
                }
                sbSplit.Enabled = leSplitOptions.Enabled = sbCheckDup.Enabled = sbSaveFile.Enabled = true;
                lblTotalImport.Text = "Complete: " + pgb.ToString() + " ranges";
                pgb = 0;
            });

        }

        private void SplitOption3(string[] splitLeftIp, string[] splitRightIp)
        {
            pgbPercentSplit.Properties.Maximum = fileIpRage.Count * 4;
            var newRange1 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{splitLeftIp[2]}.{rand.Next(1, 254)}-{splitRightIp[0]}.{splitRightIp[1]}.{splitRightIp[2]}.{rand.Next(1, 254)}";
            var newRange2 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{rand.Next(1, 254)}.{splitLeftIp[3]}-{splitRightIp[0]}.{splitRightIp[1]}.{rand.Next(1, 254)}.{splitRightIp[3]}";
            var newRange3 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{rand.Next(1, 254)}.{rand.Next(1, 254)}-{splitRightIp[0]}.{splitRightIp[1]}.{rand.Next(1, 254)}.{rand.Next(1, 254)}";
            var newRange4 = $"{splitLeftIp[0]}.{rand.Next(1, 254)}.{rand.Next(1, 254)}.{rand.Next(1, 254)}-{splitRightIp[0]}.{rand.Next(1, 254)}.{rand.Next(1, 254)}.{rand.Next(1, 254)}";
            newIpRanges.AddRange(new List<string> { newRange1, newRange2, newRange3, newRange4 });
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange1,
            });
            pgb++;
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange2,
            });
            pgb++;
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange3,
            });
            pgb++;
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange4,
            });
            pgb++;
            OnPercent(new ProgressBarEventArg()
            {
                Percent = pgb,
            });
            OnTotalNewRange(new TotalNewRangeEventArg()
            {
                TotalNewRanges = pgb,
            });
        }

        private void SplitOption2(string[] splitLeftIp, string[] splitRightIp)
        {
            pgbPercentSplit.Properties.Maximum = fileIpRage.Count * 3;
            var newRange1 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{splitLeftIp[2]}.{rand.Next(1, 254)}-{splitRightIp[0]}.{splitRightIp[1]}.{splitRightIp[2]}.{rand.Next(1, 254)}";
            var newRange2 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{rand.Next(1, 254)}.{splitLeftIp[3]}-{splitRightIp[0]}.{splitRightIp[1]}.{rand.Next(1, 254)}.{splitRightIp[3]}";
            var newRange3 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{rand.Next(1, 254)}.{rand.Next(1, 254)}-{splitRightIp[0]}.{splitRightIp[1]}.{rand.Next(1, 254)}.{rand.Next(1, 254)}";
            newIpRanges.AddRange(new List<string> { newRange1, newRange2, newRange3 });
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange1,
            });
            pgb++;
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange2,
            });
            pgb++;
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange3,
            });
            pgb++;
            OnPercent(new ProgressBarEventArg()
            {
                Percent = pgb,
            });
            OnTotalNewRange(new TotalNewRangeEventArg()
            {
                TotalNewRanges = pgb,
            });
        }

        private void SplitOption1(string[] splitLeftIp, string[] splitRightIp)
        {
            pgbPercentSplit.Properties.Maximum = fileIpRage.Count * 2;
            var newRange1 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{splitLeftIp[2]}.{rand.Next(1, 254)}-{splitRightIp[0]}.{splitRightIp[1]}.{splitRightIp[2]}.{rand.Next(1, 254)}";
            var newRange2 = $"{splitLeftIp[0]}.{splitLeftIp[1]}.{rand.Next(1, 254)}.{splitLeftIp[3]}-{splitRightIp[0]}.{splitRightIp[1]}.{rand.Next(1, 254)}.{splitRightIp[3]}";
            newIpRanges.AddRange(new List<string> { newRange1, newRange2 });
            Thread.Sleep(5);
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange1,
            });
            pgb++;
            OnNewRange(new NewIpRangeEventArg()
            {
                NewIpRange = newRange2,
            });
            pgb++;
            OnPercent(new ProgressBarEventArg()
            {
                Percent = pgb,
            });
            OnTotalNewRange(new TotalNewRangeEventArg()
            {
                TotalNewRanges = pgb,
            });
        }

        private void sbSaveFile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "File Text";
            sfd.Filter = "File Text|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in newIpRanges)
                {
                    sb.AppendLine(item);
                }
                File.WriteAllText(sfd.FileName, sb.ToString());
                var openFile = XtraMessageBox.Show("save succeeded! Open file ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (openFile == DialogResult.OK)
                {
                    Process.Start(sfd.FileName);
                }
            }
        }

        private void sbCheckDup_Click(object sender, EventArgs e)
        {
            newIpRanges = newIpRanges.Distinct().ToList();
            XtraMessageBox.Show($"Removed Duplicate Succeeded!!\n{"Results: "}{newIpRanges.Count} ranges", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool isPauseSplit = false;
        private void sbPauseSplit_Click(object sender, EventArgs e)
        {
            isPauseSplit = !isPauseSplit;
        }
    }
}
