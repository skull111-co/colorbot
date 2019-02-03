using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PlayerIOClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace COLORBOT
{
	public partial class Form1 : Form
	{
		private Client client;
		private Connection con;
		private bool isConnected;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			toolTip_worldid.SetToolTip(worldid, "It's the Room ID! To get this info, you need to join a world and do: /roomid");
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			int errors = 0;

			if (string.IsNullOrWhiteSpace(combo_Color.Text))
			{
				MessageBox.Show("No. It's not like you will not select the color, and I WILL!", "Error count: " + (errors + 1), MessageBoxButtons.OK, MessageBoxIcon.Error);
				errors++;
			}
			if (string.IsNullOrWhiteSpace(worldid.Text))
			{
				MessageBox.Show("Please tell our destination.", "Error count: " + (errors + 1), MessageBoxButtons.OK, MessageBoxIcon.Error);
				errors++;
			}
			if (string.IsNullOrWhiteSpace(username.Text))
			{
				MessageBox.Show("Who am I?", "Error count: " + (errors + 1), MessageBoxButtons.OK, MessageBoxIcon.Error);
				errors++;
			}
			if (string.IsNullOrWhiteSpace(password.Text))
			{
				MessageBox.Show("Wow. IT'S NOT LIKE I KNOW YOUR PASSWORD.\nI am not a spyware, what did you thought? Go find it yourself.", "Error count: " + (errors + 1), MessageBoxButtons.OK, MessageBoxIcon.Error);
				errors++;
			}

			if (errors == 1)
			{
				MessageBox.Show("Uh, you forgot one thing. If you did that, then it's all ready!");
			}
			else if (errors == 2)
			{
				MessageBox.Show("Did you forgot to set your username and password, or... the other thing? No problem for you, it's just for me.");
			}
			else if (errors == 3)
			{
				MessageBox.Show("Not only the color/world id/username/password! All the other things! Nah, code is not required, only if the owner's here and will give you edit.");
			}
			else if (errors == 4)
			{
				MessageBox.Show("You are lazy.");
			}

			if (errors > 0) return;
			else
			{
				if (!isConnected) MessageBox.Show("Good! All things're ready.");
			}

			if (!isConnected)
			{
				try
				{
					client = PlayerIO.QuickConnect.SimpleConnect("everybody-edits-su9rn58o40itdbnw69plyw", username.Text, password.Text, null);
					con = client.Multiplayer.CreateJoinRoom(worldid.Text, "public", true, new Dictionary<string, string>(), new Dictionary<string, string>());

					con.Send("init");
					con.OnMessage += new MessageReceivedEventHandler(handlemsg);
					isConnected = true;
					btnConnect.Text = "Disconnect";
					combo_Color.Enabled = false;
				}
				catch
				{
					MessageBox.Show("Error! I hope something didn't went wrong.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				con.Send("say", "[COLORBOT] We are going away. The fun time's over!");
				con.Disconnect();
				isConnected = false;
				btnConnect.Text = "Connect";
				combo_Color.Enabled = true;
			}
		}

		private void handlemsg(object sender, PlayerIOClient.Message m)
		{
			if (m.Type == "b")
			{
				int blockid = 0;
				if (combo_Color.Text == "Red") blockid = 70;
				if (combo_Color.Text == "Orange") blockid = 76;
				if (combo_Color.Text == "Yellow") blockid = 75;
				if (combo_Color.Text == "Green") blockid = 74;
				if (combo_Color.Text == "Cyan") blockid = 73;
				if (combo_Color.Text == "Blue") blockid = 72;
				if (combo_Color.Text == "Purple") blockid = 71;

				if (m.GetUInt(3) == 0) return;
				else con.Send("b", m.GetUInt(0), m.GetUInt(1), m.GetUInt(2), blockid);
			}
			else if (m.Type == "init")
			{
				con.Send("say", "[COLORBOT] Hi y'all. I am here just because for fun.");
				Thread.Sleep(500);
				con.Send("say", "[COLORBOT] Oh and also, I am made by skull111. But still, no commands!");
				Thread.Sleep(500);
				con.Send("say", "[COLORBOT] I will try the code if it works. If it does, then I will want from the owner to give edit.");
				Thread.Sleep(500);
				con.Send("say", "[COLORBOT] Current color: " + combo_Color.Text + ".");
				Thread.Sleep(500);
				con.Send("access", code.Text);
			}
		}
	}
}
