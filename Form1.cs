using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
public partial class Form1 : Form
{
Mover.Moverd mover;
List movers = new List();
public Form1()
{
InitializeComponent();
}


private void randomBall(object sender, EventArgs e)
{
this.WindowState = FormWindowState.Maximized;
this.DoubleBuffered = true;
Timer timer = new Timer();
timer.Enabled = true;
timer.Interval = 10;
timer.Tick += timerTick;
this.Paint += randomBallPaint;

for (int i=0;i<5;i++)
{
mover = new Mover.Moverd(this.Width, this.Height);
movers.Add(mover);
}
}

private void randomBallPaint(object sender, PaintEventArgs e)
{
foreach (var item in movers)
{
item.Update();
item.Display(e.Graphics);
}
}

private void timerTick(object sender, EventArgs e)
{
Invalidate();
}
}
}
