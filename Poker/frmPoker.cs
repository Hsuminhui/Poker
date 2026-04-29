using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace Poker
{
    public partial class frmPoker : Form
    {
        
        PictureBox[] pic = new PictureBox[5];
        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        string[] colorList = { "黑桃", "紅心", "梅花", "方塊" };
        string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        int[] pokerColor = new int[5];
        int[] pokerPoint = new int[5];

        // 押注相關變數
        int balance = 1000;   // 總資金
        int currentBet = 0;   // 本局押注金額
        string selectedType = ""; // 玩家選擇押注的牌型

        // 賠率表
        Dictionary<string, double> oddsTable = new Dictionary<string, double>()
        {
            {"皇家同花順", 250.0},
            { "同花順", 50.0 },
            { "鐵支",   25.0  },
            { "葫蘆",   9.0  },
            { "同花",   6.0  },
            { "順子",    4.0  },
            { "三條",    3.0  },
            { "兩對",    2.0  },
            { "一對",    1.0  }
        };

        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
            InitializeBetting();
        }

        // 初始化押注介面
        private void InitializeBetting()
        {

            // 初始化下拉選單選項
            cmbPokerType.Items.Clear();
            foreach (var key in oddsTable.Keys)
            {
                cmbPokerType.Items.Add(key);
            }
            cmbPokerType.SelectedIndex = 0;

            UpdateBalanceDisplay();
        }

        private void ResetGame()
        {
            balance = 1000;
            currentBet = 0;

            lblBalance.Text = "總資金：1000 元";
            lblBet.Text = "押注金額：0 元";
            lblWinLoss.Text = "本局輸贏：";
            lblResult.Text = "";

            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetPic("back");
                pic[i].Tag = "back";
                pic[i].Enabled = true;
            }

            btnDealCard.Enabled = true;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;

            btnBet10.Enabled = true;
            btnBet50.Enabled = true;
            btnBet100.Enabled = true;
            btnClearBet.Enabled = true;
            cmbPokerType.Enabled = true;
            cmbPokerType.SelectedIndex = 0;
        }

        // 更新畫面上的金額顯示
        private void UpdateBalanceDisplay()
        {
            lblBalance.Text = "總資金：" + balance + " 元";
            lblBet.Text = "押注金額：" + currentBet + " 元";
            lblWinLoss.Text = "本局輸贏：";
        }

        private void AddBet(int amount)
        {
            if (amount > balance)
            {
                MessageBox.Show("押注金額超過目前餘額！", "提示");
                return;
            }

            balance -= amount;      // 押注時先扣總資金
            currentBet += amount;

            lblBalance.Text = "總資金：" + balance + " 元";
            lblBet.Text = "押注金額：" + currentBet + " 元";
        }

       

        //取得玩家選擇的牌型（去掉賠率說明）
        private string GetSelectedPokerType()
        {
            if (cmbPokerType.SelectedIndex < 0) return "";
            string selected = cmbPokerType.SelectedItem.ToString();
            return selected.Split(' ')[0]; // 取空格前的牌型名稱
        }

        //結算
        private void Settle(string resultType)
        {
            if (currentBet == 0)
            {
                lblWinLoss.Text = "本局輸贏：未押注";
                return;
            }

            selectedType = GetSelectedPokerType();

            if (selectedType == resultType)
            {
                double odds = oddsTable[resultType];

                // 因為本金已經先扣掉，所以押中時要加回：本金 + 獎金
                int winMoney = (int)(currentBet * (odds + 1));

                balance += winMoney;
                lblWinLoss.Text = "本局輸贏：+" + winMoney + " 元 🎉 押中了！";
            }
            else
            {
                // 已經在押注時扣過錢，這裡不要再扣
                lblWinLoss.Text = "本局輸贏：-" + currentBet + " 元";
            }

            lblBalance.Text = "總資金：" + balance + " 元";
            currentBet = 0;
            lblBet.Text = "押注金額：0 元";

            if (balance <= 0)
            {
                MessageBox.Show("你已經破產了！遊戲重新開始。", "Game Over");

                ResetGame();   
                return;       
            }
       
        }

        private Image GetPic(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }

        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = int.Parse(p.Name.Replace("pic", ""));

            if (p.Tag.ToString() == "back")
            {
                p.Tag = "front";
                p.Image = GetPic("pic" + (playerPoker[index] + 1));
            }
            else
            {
                p.Tag = "back";
                p.Image = GetPic("back");
            }
        }

        private void InitializePoker()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetPic("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";

                this.grpButton.Controls.Add(pic[i]);
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[i];
                allPoker[i] = allPoker[r];
                allPoker[r] = temp;
            }
        }

        private void btnDealCard_Click(object sender, EventArgs e)
        {
            if (currentBet == 0)
            {
                MessageBox.Show("請先押注再發牌！", "提示");
                return;
            }

            for (int i = 0; i < 52; i++) allPoker[i] = i;

            Shuffle();

            for (int i = 0; i < 5; i++)
            {
                playerPoker[i] = allPoker[i];
                pic[i].Image = GetPic("back");
                pic[i].Tag = "back";
                pic[i].Enabled = true;
            }

            btnDealCard.Enabled = false;
            btnChangeCard.Enabled = true;
            btnCheck.Enabled = false;
            lblResult.Text = "";

            // 發牌時鎖定押注
            btnBet10.Enabled = false;
            btnBet50.Enabled = false;
            btnBet100.Enabled = false;
            btnClearBet.Enabled = false;
            cmbPokerType.Enabled = false;

            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Image = GetPic("pic" + (playerPoker[i] + 1));
                pic[i].Tag = "front";
            }
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[cardIndex];
                    pic[i].Image = GetPic("pic" + (playerPoker[i] + 1));
                    pic[i].Tag = "front";
                    cardIndex++;
                }
            }

            for (int i = 0; i < pic.Length; i++) pic[i].Enabled = false;

            btnChangeCard.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void AnalyzeCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] / 13;
                pokerPoint[i] = playerPoker[i] % 13;
            }
            btnDealCard.Enabled = true;
        }

        private int[] GetSortedPoints()
        {
            int[] points = new int[5];
            for (int i = 0; i < 5; i++) points[i] = pokerPoint[i];
            Array.Sort(points);
            return points;
        }

        private bool IsFlush()
        {
            for (int i = 1; i < 5; i++)
                if (pokerColor[i] != pokerColor[0]) return false;
            return true;
        }

        private bool IsStraightWithAce(int[] points)
        {
            Array.Sort(points);
            bool normalStraight = true;
            for (int i = 0; i < 4; i++)
            {
                if (points[i] + 1 != points[i + 1]) { normalStraight = false; break; }
            }
            if (normalStraight) return true;

            return (points[0] == 0 && points[1] == 9 &&
                    points[2] == 10 && points[3] == 11 && points[4] == 12);
        }

        private int[] CountPoints()
        {
            int[] count = new int[13];
            for (int i = 0; i < 5; i++) count[pokerPoint[i]]++;
            return count;
        }

        private bool IsRoyalFlush()
        {
            // 要是同一花色
            for (int i = 0; i < 5; i++)
            {

                if (pokerColor[i] != pokerColor[0])
                    return false;
            }

            // 點數必須是 A, 10, J, Q, K
            int[] sorted = GetSortedPoints();
            return sorted[0] == 0 &&
                   sorted[1] == 9 &&
                   sorted[2] == 10 &&
                   sorted[3] == 11 &&
                   sorted[4] == 12;
        }

        private string GetPokerType()
        {
            int[] points = GetSortedPoints();
            int[] count = CountPoints();
            bool flush = IsFlush();
            bool straight = IsStraightWithAce(points);

            int pairCount = 0, threeCount = 0, fourCount = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 2) pairCount++;
                else if (count[i] == 3) threeCount++;
                else if (count[i] == 4) fourCount++;
            }

            if (IsRoyalFlush()) return "皇家同花順";
            if (flush && straight) return "同花順";
            if (fourCount == 1) return "鐵支";
            if (threeCount == 1 && pairCount == 1) return "葫蘆";
            if (flush) return "同花";
            if (straight) return "順子";
            if (threeCount == 1) return "三條";
            if (pairCount == 2) return "兩對";
            if (pairCount == 1) return "一對";
            return "雜牌";
        }

        private string ShowPointCount()
        {
            int[] count = CountPoints();
            string msg = "";
            for (int i = 0; i < count.Length; i++)
                if (count[i] > 0) msg += pointList[i] + ":" + count[i] + " ";
            return msg;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            AnalyzeCards();
            string result = GetPokerType();
            lblResult.Text = "牌型是：" + result + "    " + ShowPointCount();

            // 結算押注
            Settle(result);

            btnCheck.Enabled = false;

            // 解鎖押注控件，讓玩家下一局可以繼續押注
            btnBet10.Enabled = true;
            btnBet50.Enabled = true;
            btnBet100.Enabled = true;
            btnClearBet.Enabled = true;
            cmbPokerType.Enabled = true;
        }

        private void btnBet10_Click_1(object sender, EventArgs e)
        {
            AddBet(10);
        }

        private void btnBet50_Click_1(object sender, EventArgs e)
        {
            AddBet(50);
        }

        private void btnBet100_Click_1(object sender, EventArgs e)
        {
            AddBet(100);
        }

        private void btnClearBet_Click(object sender, EventArgs e)
        {

            balance += currentBet;  // 退回押注金額
            currentBet = 0;

            lblBalance.Text = "總資金：" + balance + " 元";
            lblBet.Text = "押注金額：0 元";
            lblWinLoss.Text = "本局輸贏：";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Allin_Click(object sender, EventArgs e)
        {
            if (balance <= 0)
            {
                MessageBox.Show("你沒有錢可以 All in！", "提示");
                return;
            }

            currentBet += balance;   // 把剩下的錢全部押下去
            balance = 0;             // 餘額歸零（這行你原本沒做）

            lblBet.Text = "押注金額：" + currentBet + " 元";
            lblBalance.Text = "總資金：0 元";

        }
    }
}