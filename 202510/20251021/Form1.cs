namespace _20251021;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        toolStripStatusLabel1.Text = "";
        Task.Run(() => DoSomething());
    }

    private void DoSomething()
    {
        DoLongTimeWork();
        statusStrip1.Invoke((Action)(() =>
        {
            toolStripStatusLabel1.Text = "button1 completed";
        }));
    }

    private void DoLongTimeWork()
    {
        System.Threading.Thread.Sleep(5000);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        toolStripStatusLabel1.Text = "";
        var currentContext = TaskScheduler.FromCurrentSynchronizationContext();
        Task.Run(() =>
        {
            DoSomething();
        })
        .ContinueWith(task =>
        {
            toolStripStatusLabel1.Text = "button2 completed";
        }, currentContext);
    }
}
