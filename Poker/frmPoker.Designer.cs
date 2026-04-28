namespace Poker
{
    partial class frmPoker
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoker));
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.grpfunction = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblWinLoss = new System.Windows.Forms.Label();
            this.lblOddsTitle = new System.Windows.Forms.Label();
            this.btnBet10 = new System.Windows.Forms.Button();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.btnBet100 = new System.Windows.Forms.Button();
            this.btnClearBet = new System.Windows.Forms.Button();
            this.cmbPokerType = new System.Windows.Forms.ComboBox();
            this.restart = new System.Windows.Forms.Button();
            this.grpfunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButton
            // 
            this.grpButton.AutoSize = true;
            this.grpButton.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(583, 580);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(485, 160);
            this.grpButton.TabIndex = 0;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "牌桌";
            // 
            // grpfunction
            // 
            this.grpfunction.Controls.Add(this.lblResult);
            this.grpfunction.Controls.Add(this.btnCheck);
            this.grpfunction.Controls.Add(this.btnChangeCard);
            this.grpfunction.Controls.Add(this.btnDealCard);
            this.grpfunction.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpfunction.Location = new System.Drawing.Point(422, 793);
            this.grpfunction.Name = "grpfunction";
            this.grpfunction.Size = new System.Drawing.Size(798, 98);
            this.grpfunction.TabIndex = 1;
            this.grpfunction.TabStop = false;
            this.grpfunction.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(357, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(410, 29);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheck.Location = new System.Drawing.Point(205, 37);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(125, 39);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeCard.Location = new System.Drawing.Point(122, 37);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(77, 39);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDealCard.Location = new System.Drawing.Point(32, 37);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(84, 39);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBalance.Location = new System.Drawing.Point(1138, 85);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(171, 38);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "總資金:";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBet
            // 
            this.lblBet.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBet.Location = new System.Drawing.Point(1138, 154);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(171, 40);
            this.lblBet.TabIndex = 3;
            this.lblBet.Text = "押注金額:";
            this.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinLoss
            // 
            this.lblWinLoss.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWinLoss.Location = new System.Drawing.Point(1138, 223);
            this.lblWinLoss.Name = "lblWinLoss";
            this.lblWinLoss.Size = new System.Drawing.Size(171, 38);
            this.lblWinLoss.TabIndex = 4;
            this.lblWinLoss.Text = "本局輸贏:";
            this.lblWinLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOddsTitle
            // 
            this.lblOddsTitle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOddsTitle.Location = new System.Drawing.Point(1138, 287);
            this.lblOddsTitle.Name = "lblOddsTitle";
            this.lblOddsTitle.Size = new System.Drawing.Size(171, 49);
            this.lblOddsTitle.TabIndex = 5;
            this.lblOddsTitle.Text = "選擇押注牌型:";
            this.lblOddsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBet10
            // 
            this.btnBet10.BackColor = System.Drawing.Color.Orange;
            this.btnBet10.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBet10.Location = new System.Drawing.Point(1195, 378);
            this.btnBet10.Name = "btnBet10";
            this.btnBet10.Size = new System.Drawing.Size(75, 44);
            this.btnBet10.TabIndex = 6;
            this.btnBet10.Text = "10";
            this.btnBet10.UseVisualStyleBackColor = false;
            this.btnBet10.Click += new System.EventHandler(this.btnBet10_Click_1);
            // 
            // btnBet50
            // 
            this.btnBet50.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBet50.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBet50.Location = new System.Drawing.Point(1318, 378);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(75, 44);
            this.btnBet50.TabIndex = 7;
            this.btnBet50.Text = "50";
            this.btnBet50.UseVisualStyleBackColor = false;
            this.btnBet50.Click += new System.EventHandler(this.btnBet50_Click_1);
            // 
            // btnBet100
            // 
            this.btnBet100.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBet100.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBet100.Location = new System.Drawing.Point(1446, 378);
            this.btnBet100.Name = "btnBet100";
            this.btnBet100.Size = new System.Drawing.Size(75, 44);
            this.btnBet100.TabIndex = 8;
            this.btnBet100.Text = "100";
            this.btnBet100.UseVisualStyleBackColor = false;
            this.btnBet100.Click += new System.EventHandler(this.btnBet100_Click_1);
            // 
            // btnClearBet
            // 
            this.btnClearBet.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearBet.Location = new System.Drawing.Point(1214, 455);
            this.btnClearBet.Name = "btnClearBet";
            this.btnClearBet.Size = new System.Drawing.Size(120, 46);
            this.btnClearBet.TabIndex = 9;
            this.btnClearBet.Text = "清除押注";
            this.btnClearBet.UseVisualStyleBackColor = true;
            this.btnClearBet.Click += new System.EventHandler(this.btnClearBet_Click);
            // 
            // cmbPokerType
            // 
            this.cmbPokerType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbPokerType.FormattingEnabled = true;
            this.cmbPokerType.Items.AddRange(new object[] {
            "同花順",
            "鐵支",
            "葫蘆",
            "同花",
            "順子",
            "三條",
            "兩對",
            "一對",
            "雜牌"});
            this.cmbPokerType.Location = new System.Drawing.Point(1339, 298);
            this.cmbPokerType.Name = "cmbPokerType";
            this.cmbPokerType.Size = new System.Drawing.Size(231, 32);
            this.cmbPokerType.TabIndex = 10;
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.restart.Location = new System.Drawing.Point(1367, 455);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(127, 46);
            this.restart.TabIndex = 11;
            this.restart.Text = "重新開始";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // frmPoker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1624, 940);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.cmbPokerType);
            this.Controls.Add(this.btnClearBet);
            this.Controls.Add(this.btnBet100);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnBet10);
            this.Controls.Add(this.lblOddsTitle);
            this.Controls.Add(this.lblWinLoss);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.grpfunction);
            this.Controls.Add(this.grpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmPoker";
            this.Text = "五張撲克牌押注遊戲";
            this.grpfunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.GroupBox grpfunction;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblWinLoss;
        private System.Windows.Forms.Label lblOddsTitle;
        private System.Windows.Forms.Button btnBet10;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Button btnBet100;
        private System.Windows.Forms.Button btnClearBet;
        private System.Windows.Forms.ComboBox cmbPokerType;
        private System.Windows.Forms.Button restart;
    }
}

