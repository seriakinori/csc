using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20251020;

public partial class Form2 : Form
{
    private BackgroundWorker _worker = new BackgroundWorker();

    public Form2()
    {
        InitializeComponent();
        _worker.DoWork += _worker_DoWork;
        _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
        _worker.ProgressChanged += _worker_ProgressChanged;
        _worker.WorkerReportsProgress = true;
    }

    private void _worker_DoWork(object? sender, DoWorkEventArgs e)
    {
        var collection = Enumerable.Range(1,200).ToArray();
        int count = 0;
        foreach(var n in collection)
        {
            DoWork(n);
            var per = count * 100 / collection.Length;
            _worker.ReportProgress(Math.Min(per, toolStripProgressBar1.Maximum), null);
            count++;
        }
    }

    private void _worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
    {
        toolStripProgressBar1.Value = e.ProgressPercentage;
    }

    private void _worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
    {
        toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
        toolStripStatusLabel1.Text = "completed";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        toolStripStatusLabel1.Text = "";
        _worker.RunWorkerAsync();
    }

    private void DoWork(int n)
    {
        System.Threading.Thread.Sleep(500);
    }
}