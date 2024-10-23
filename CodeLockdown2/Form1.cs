using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeLockdown2 {
    public partial class Form1 : Form {
        private string currentPassword = null;
        private int timeLeft = 5; 
        private bool isGameRunning = false;
        private int roundCount = 0;
        private Random random = new Random(); 
        private Timer incorrectPasswordTimer; 

        public Form1() {
            InitializeComponent();
            gameTimer = new Timer();
            gameTimer.Interval = 1000; 
            gameTimer.Tick += GameTimer_Tick;

            incorrectPasswordTimer = new Timer(); 
            incorrectPasswordTimer.Interval = 1000; 
            incorrectPasswordTimer.Tick += IncorrectPasswordTimer_Tick; 
        }

        private void StartGame(object sender, EventArgs e) {
            if (isGameRunning) {
                
                DialogResult result = MessageBox.Show("The game is already running. Do you want to restart?", "Restart Game", MessageBoxButtons.YesNo);
                gameLabel.Show();
                if (result == DialogResult.No) {
                    return; 
                }
            }

            // start/reset
            isGameRunning = true;
            roundCount = 0; 
            timeLeft = 7; 
            currentPassword = random.Next(1000, 10000).ToString();
            stateLabel.Text = ""; 

            passwordInput.Clear(); 
            passwordInput.Enabled = true; 

            gameTimer.Start(); 
            UpdateGameLabel(); 
        }

        private void GameTimer_Tick(object sender, EventArgs e) {
            if (timeLeft > 0) {
                timeLeft--;
                labelStatus.Text = $"{timeLeft}"; 
            } else if (timeLeft == 0) { 
                gameTimer.Stop();
                isGameRunning = false;
                stateLabel.Text = "You Lose! The robbers have hacked in.";
                stateLabel.ForeColor = Color.Red; 
                labelStatus.Text = ""; 
                stateLabel.Refresh(); 
                passwordInput.Enabled = false; 
            }
        }

        private void UpdateGameLabel() {
            gameLabel.Text = "Change password to: " + currentPassword; 
            
            labelStatus.ForeColor = Color.White;
            gameLabel.ForeColor = Color.White;
        }


        private void passwordInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                stateLabel.Show();
                if (passwordInput.Text == currentPassword) {
                    timeLeft += 3; 
                    roundCount++; 
                    if (roundCount < 8) {
                        GenerateNewPassword(); 
                        UpdateGameLabel();
                    } else {
                        stateLabel.Text = "Congratulations! Your house is safe.";
                        stateLabel.ForeColor = Color.Green;
                        gameLabel.Hide();
                        gameTimer.Stop(); 
                        passwordInput.Enabled = false; 
                    }
                } else {
                    stateLabel.Text = "Incorrect password. Try again!";
                    incorrectPasswordTimer.Start(); 
                }
                passwordInput.Clear();
                e.Handled = true;
            }
        }

        private void IncorrectPasswordTimer_Tick(object sender, EventArgs e) {
            stateLabel.Text = ""; 
            incorrectPasswordTimer.Stop(); 
        }

        private void GenerateNewPassword() {
            currentPassword = random.Next(1000, 10000000).ToString();
        }

        private void RestartGame() {
            
            currentPassword = "1234"; 
            timeLeft = 5; 
            roundCount = 0; 
            isGameRunning = false; 
            stateLabel.Text = "Game reset. Click Start to begin again!";
            passwordInput.Clear(); 
            gameLabel.Text = ""; 
            passwordInput.Enabled = true;
        }

        
    }
}
