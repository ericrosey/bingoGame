using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingoGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        // This next statement does three things.  See if you can figure out what they are
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        int countOfCalledNumbers;
        char nextCalledLetter;
        int nextCalledNumber;

        private InternalCardType2DimArray internalCardRep2DArray =
             new InternalCardType2DimArray(BINGOCARDSIZE);
        private RNGType RNGObj = new RNGType();
        private PlayerType currentPlayer;

        private string bingoLetters = "BINGO";
        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLetsGo_Click(object sender, EventArgs e)
        {
            if (txtNameEntry.Text == "")
            {
                MessageBox.Show("No name was entered.  Try again.", "Missing Name");
                txtNameEntry.Focus();
            }
            else
            {
                lblHowToPlay.Visible = true;
                lblWhatWeDo.Visible = true;
                txtNumberCalled.Visible = true;
                lblBingoCard.Visible = true;
                lblDontHave.Visible = true;
                btnDontHave.Visible = true;

                currentPlayer = new PlayerType(txtNameEntry.Text);

                createBingoCardOnForm();
                
                playTheGame();
            }  // end if
        }   // end btnLetsGo-Click Handler

        public void playTheGame()
        {
            int randomNumber = RNGObj.getNextUniqueRandomValue(1, 75);
            txtNumberCalled.Text = addLetter(randomNumber);
        }
        public String addLetter(int number)
        {
            String numberLetter = "";
            if(number >= 1 && number <= 15)
            {
                numberLetter = "B " + number.ToString();
            }else if(number > 15 && number <= 30)
            {
                numberLetter = "I " + number.ToString();
            }else if(number > 30 && number <= 45)
            {
                numberLetter = "N " + number.ToString();
            }else if(number > 45 && number <= 60)
            {
                numberLetter = "G " + number.ToString();
            }else if(number > 60 && number <= 75)
            {
                numberLetter = "O " + number.ToString();
            }
            return numberLetter;
        }


        // What does this do?
        private void createBingoCardOnForm()
        {
            pnlCard.Visible = true;
            createCard();

        }
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Enabled = true;

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                        newButton[row, col].Enabled = false;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    

                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar



        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCount2D;
            int bingoCountWO2D; int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]); //pass to checkBingo as r
            int colID = convertCharToInt(((Button)sender).Name[4]); //pass to checkBingo as c
            //MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            String givenNumber = txtNumberCalled.Text.Substring(2);
     
            if (((Button)sender).Text == givenNumber)
            {
                ((Button)sender).BackColor = System.Drawing.Color.Orange;// marks the cell
                if(internalCardRep2DArray.checkBingo(rowID, colID) == true) //checks bingo and adds to card
                {
                    MessageBox.Show("Congrats " + currentPlayer.getName() + " \nYou are a CHAMPION");
                    this.Close();
                }
                playTheGame();
            }
            else
            {
                MessageBox.Show("That is not the right number fool");
            }
            // Double check that clicked on button value matches called value
            // You may want more code in here …

        } // end button clickhandler 
          // Convert a charcter to its equivalent integer
        int convertCharToInt(char c)
        {
            return ((int)(c) - (int)('0'));
        } // end convertCharToInt
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDontHave_Click(object sender, EventArgs e)
        {
            string callNum = txtNumberCalled.Text;//makes a string out of the called number
            callNum = callNum.Substring(2);//makes the string just the number
            int keepPlaying = 0;//keeps track if a button had the number called
            for(int i = 0; i < 5; i++)
            {
                for(int k = 0; k < 5; k++)
                {
                    if(newButton[i,k].Text == callNum)
                    {
                        keepPlaying++;
                        MessageBox.Show("Use your eyes! You have that number!");
                    }
                }
            }
            if(keepPlaying == 0)
            {
                playTheGame();
            }
        }
    }
}
