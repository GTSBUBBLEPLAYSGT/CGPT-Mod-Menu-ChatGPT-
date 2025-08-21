using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic; // for InputBox

public class MainForm : Form
{
    private Button btnTeleport;
    private Button btnSpeed;
    private Label lblStatus;

    public MainForm()
    {
        // Form styling
        this.Text = "Mod Menu";
        this.BackColor = Color.Black;
        this.Size = new Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Teleport Button
        btnTeleport = new Button();
        btnTeleport.Text = "Teleport";
        btnTeleport.Size = new Size(120, 50);
        btnTeleport.Location = new Point(30, 30);
        btnTeleport.BackColor = Color.FromArgb(0, 180, 0);   // Green
        btnTeleport.ForeColor = Color.White;
        btnTeleport.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        btnTeleport.FlatStyle = FlatStyle.Flat;
        btnTeleport.FlatAppearance.BorderSize = 0;
        btnTeleport.Click += BtnTeleport_Click;

        // Speed Button
        btnSpeed = new Button();
        btnSpeed.Text = "Set Speed";
        btnSpeed.Size = new Size(120, 50);
        btnSpeed.Location = new Point(30, 100);
        btnSpeed.BackColor = Color.FromArgb(0, 130, 0);  // Darker green
        btnSpeed.ForeColor = Color.White;
        btnSpeed.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        btnSpeed.FlatStyle = FlatStyle.Flat;
        btnSpeed.FlatAppearance.BorderSize = 0;
        btnSpeed.Click += BtnSpeed_Click;

        // Status Label
        lblStatus = new Label();
        lblStatus.Text = "Status: Waiting...";
        lblStatus.AutoSize = true;
        lblStatus.ForeColor = Color.Lime;
        lblStatus.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        lblStatus.Location = new Point(30, 180);

        // Add controls
        Controls.Add(btnTeleport);
        Controls.Add(btnSpeed);
        Controls.Add(lblStatus);
    }

    private void BtnTeleport_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "Teleported!";
    }

    private void BtnSpeed_Click(object sender, EventArgs e)
    {
        string input = Interaction.InputBox("Enter new speed:", "Set Speed", "5");
        if (double.TryParse(input, out double speed))
        {
            lblStatus.Text = $"Speed set to {speed}";
        }
        else
        {
            lblStatus.Text = "Invalid speed!";
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
