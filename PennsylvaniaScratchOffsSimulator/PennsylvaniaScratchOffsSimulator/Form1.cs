using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PennsylvaniaScratchOffsSimulator
{
    public partial class Form1 : Form
    {
        //Variables
        List<ScratchOff> ScratchOffs = new List<ScratchOff>();  //The List of scratch offs available
        ScratchOff SelectedScratchOff;
        const int StartingMoney = 500;
        int Money = StartingMoney;
        int TicketsBought = 0;

        public Form1()
        {            
            AddSomeScratchData();
            InitializeComponent();
        }

        //Data input for a couple scratch offs - TODO: Read these tickets from a .json or something similar
        public void AddSomeScratchData() 
        {
            ScratchOff FiveTimesTheMoney = new ScratchOff("5X THE MONEY", 5, "https://www.palottery.state.pa.us/uploadedfiles/PA-1437_5X-the-Money_DATA.pdf");
            FiveTimesTheMoney.PayoutsList.Add(new Payout(5, 9));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(10, 20));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(25, 30));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(50, 55));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(100, 333));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(250, 1600));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(500, 7500));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(1000, 12000));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(5000, 270000));
            FiveTimesTheMoney.PayoutsList.Add(new Payout(100000, 1080000));
            ScratchOffs.Add(FiveTimesTheMoney);

            ScratchOff OhWhatFun = new ScratchOff("Oh, What Fun", 1, "https://www.palottery.state.pa.us/uploadedfiles/PA-1431_Oh-What-Fun_DATA.pdf");
            OhWhatFun.PayoutsList.Add(new Payout(1, 8));
            OhWhatFun.PayoutsList.Add(new Payout(2, 25));
            OhWhatFun.PayoutsList.Add(new Payout(4, 59));
            OhWhatFun.PayoutsList.Add(new Payout(5, 111));
            OhWhatFun.PayoutsList.Add(new Payout(8, 250));
            OhWhatFun.PayoutsList.Add(new Payout(10, 83));
            OhWhatFun.PayoutsList.Add(new Payout(15, 1000));
            OhWhatFun.PayoutsList.Add(new Payout(20, 250));
            OhWhatFun.PayoutsList.Add(new Payout(30, 960));
            OhWhatFun.PayoutsList.Add(new Payout(50, 1500));
            OhWhatFun.PayoutsList.Add(new Payout(60, 12000));
            OhWhatFun.PayoutsList.Add(new Payout(100, 6000));
            OhWhatFun.PayoutsList.Add(new Payout(150, 120000));
            OhWhatFun.PayoutsList.Add(new Payout(300, 690000));
            OhWhatFun.PayoutsList.Add(new Payout(5000, 1380000));
            ScratchOffs.Add(OhWhatFun);

            ScratchOff ThreeMillionLimited = new ScratchOff("$3 Million Limited", 30, "https://www.palottery.state.pa.us/uploadedfiles/PA-1432_$3M-Limited_DATA.pdf");
            ThreeMillionLimited.PayoutsList.Add(new Payout(30, 8));
            ThreeMillionLimited.PayoutsList.Add(new Payout(40, 12));
            ThreeMillionLimited.PayoutsList.Add(new Payout(50, 20));
            ThreeMillionLimited.PayoutsList.Add(new Payout(100, 43));
            ThreeMillionLimited.PayoutsList.Add(new Payout(150, 38));
            ThreeMillionLimited.PayoutsList.Add(new Payout(300, 125));
            ThreeMillionLimited.PayoutsList.Add(new Payout(500, 571));
            ThreeMillionLimited.PayoutsList.Add(new Payout(1000, 1250));
            ThreeMillionLimited.PayoutsList.Add(new Payout(10000, 200000));
            ThreeMillionLimited.PayoutsList.Add(new Payout(300000, 600000));
            ThreeMillionLimited.PayoutsList.Add(new Payout(3000000, 1200000));
            ScratchOffs.Add(ThreeMillionLimited);
        }

        //Updating which scratch off is selected from the drop down
        private void cb_List_SelectedIndexChanged(object sender, EventArgs e) 
        {
            foreach (ScratchOff scratchOff in ScratchOffs)
            {
                if (scratchOff.Name == cb_List.Text) SelectedScratchOff = scratchOff;
            }
            UpdateStatsDisplay();
        }

        //Updating the display for the selected scratch off's stats
        public void UpdateStatsDisplay()    
        {
            rtb_Stats.Clear();

            try
            {
                rtb_Stats.Text += SelectedScratchOff.Name + System.Environment.NewLine;
                rtb_Stats.Text += "Ticket Price: $" + SelectedScratchOff.Price + System.Environment.NewLine;
                rtb_Stats.Text += "==========================" + System.Environment.NewLine;
                foreach (Payout payout in SelectedScratchOff.PayoutsList)
                {
                    rtb_Stats.Text += "$" + String.Format("{0:n0}", payout.PayoutAmmount) + " : 1 in " + String.Format("{0:n0}", payout.Chances) + System.Environment.NewLine;
                }
                rtb_Stats.Text += "==========================" + System.Environment.NewLine;
                rtb_Stats.Text += "Detailed statistics can be found here:" + System.Environment.NewLine;
                rtb_Stats.Text += SelectedScratchOff.StatsURL;
            }
            catch
            {
                rtb_Stats.Text += "Error loading Scratch off stats..." + System.Environment.NewLine;
            }
        }

        //Button for buying a ticket
        private void btn_Buy_Click(object sender, EventArgs e)  
        {
            if (SelectedScratchOff != null)
            {              
                //Checking winnings
                int Winnings = 0;
                var rand = new Random();
                foreach (Payout payout in SelectedScratchOff.PayoutsList)
                {
                    if (rand.Next(1, payout.Chances) == 1) Winnings += payout.PayoutAmmount;
                }

                //Calculating balance change
                Money -= SelectedScratchOff.Price;
                Money += Winnings;
                TicketsBought++;

                //Output for overall ballance
                tb_Balance.Text = "$" + String.Format("{0:n0}", Money);

                //Main output log
                if (Winnings == 0) rtb_Output.Text += "You lost $" + String.Format("{0:n0}", SelectedScratchOff.Price);
                else if (Winnings == SelectedScratchOff.Price) rtb_Output.Text += "You broke even";
                else rtb_Output.Text += "You won $" + String.Format("{0:n0}", Winnings - SelectedScratchOff.Price);
                rtb_Output.Text += System.Environment.NewLine;

                //Output for win/loss tracker
                tb_WinLoss.Text = "$" + String.Format("{0:n0}", Math.Abs((Money - StartingMoney)));
                if ((Money - StartingMoney) > 0)
                {
                    lb_WinLoss.Text = "Total Profit:";
                    tb_WinLoss.BackColor = Color.LightGreen;
                }
                else
                {
                    lb_WinLoss.Text = "Total Loss:";
                    tb_WinLoss.BackColor = Color.LightCoral;
                }

                //Color for current balance
                if (Money > 0) tb_Balance.BackColor = Color.LightGreen; else tb_Balance.BackColor = Color.LightCoral;

                //Tickets bought
                tb_TicketsBought.Text = String.Format("{0:n0}", TicketsBought);
            }
            else rtb_Output.Text += "Error - You need to select a ticket type in the left hand corner drop down." + System.Environment.NewLine;
        }

        //The scratch offs class, for keeping track of each of the types of scratch offs
        public class ScratchOff 
        {
            public string Name;    //The name of the scratch off
            public int Price;      //The price to buy this scratch off
            public string StatsURL; //The statistics the payouts came from
            public List<Payout> PayoutsList = new List<Payout>();  //The list of all the possible payouts, and their prices.

            public ScratchOff(string InputName, int InputPrice, string InputStatsURL)
            {
                Name = InputName;
                Price = InputPrice;
                StatsURL = InputStatsURL;
            }
        }

        //The possible payouts a scratch off could have
        public class Payout 
        {
            public int PayoutAmmount;  //The amount that gets payed if won
            public int Chances;        //The chances of winning. For example, if this int is set to 100, then the chances of winning
                                       //are 1 in 100.

            public Payout(int InputPayoutAmmount, int InputChances)
            {
                PayoutAmmount = InputPayoutAmmount;
                Chances = InputChances;
            }
        }

        //Auto scrolls the output text box to the bottom
        private void rtb_Output_TextChanged(object sender, EventArgs e) 
        {
            rtb_Output.SelectionStart = rtb_Output.Text.Length;
            rtb_Output.ScrollToCaret();
        }

        private void menu_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use this program, left click on the drop down menu on the lefthand side and select a ticket type. Click \"Buy Ticket\" to buy a ticket. Maybe you'll win, but probably not.", "Help");
        }

        private void menu_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made to demonstrate why scratch off lotery tickets are a rip off. While it is possible to win in the short term, it is impossible to win in the long term. The only winning move is not to play.", "About");
        }

        private void menu_Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SirThominickIV?tab=repositories");
        }

        private void rtb_Stats_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
