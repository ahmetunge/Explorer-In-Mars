using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoyagerInMars.Abstract;
using VoyagerInMars.Concrete;

namespace VoyagerInMars
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnMove_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(txtOrder.Text))
                MoveCurious();
            else
                MessageBox.Show("Curious aracının harf katarını giriniz");

            if (!String.IsNullOrWhiteSpace(txtOrderOpr.Text))
                MoveOpportunity();
            else
                MessageBox.Show("Opportunity aracının harf katarını giriniz");
     
        }




        public void MoveCurious()
        {
            int rectangleXCoordinate = (int)nmrRightTopXCoordinate.Value;
            int rectangleYCoordinate = (int)nmrRightTopYCoordinate.Value;

            int robotXLocation = (int)nmrRobotFirstPlaceXCoordinate.Value;
            int robotYLocation = (int)nmrRobotFirstPlaceYCoordinate.Value;

            IPole pole = GetPole();

            if (pole != null)
            {
                XYCoordinate robotLocationcoordinates = new XYCoordinate
                {
                    XCoordinate = robotXLocation,
                    YCoordinate = robotYLocation
                };

                XYCoordinate rectangleCornerCoordinates = new XYCoordinate
                {
                    XCoordinate = rectangleXCoordinate,
                    YCoordinate = rectangleYCoordinate
                };



                Curious curious = new Curious(pole, robotLocationcoordinates, rectangleCornerCoordinates);

                string order = txtOrder.Text;

                curious.Move(order);

                string loc = curious.GetLastLocation();

                lblCuriousResult.Text = loc;
            }
        }


        private void MoveOpportunity()
        {
            int rectangleXCoordinate = (int)nmrRightTopXCoordinateOpr.Value;
            int rectangleYCoordinate = (int)nmrRightTopYCoordinateOpr.Value;

            int robotXLocation = (int)nmrRobotFirstPlaceXCoordinateOpr.Value;
            int robotYLocation = (int)nmrRobotFirstPlaceYCoordinateOpr.Value;

            IPole pole = GetOprPole();

            if (pole != null )
            {
                XYCoordinate oprRobotLocationcoordinates = new XYCoordinate
                {
                    XCoordinate = robotXLocation,
                    YCoordinate = robotYLocation
                };

                XYCoordinate rectangleCornerCoordinates = new XYCoordinate
                {
                    XCoordinate = rectangleXCoordinate,
                    YCoordinate = rectangleYCoordinate
                };



                Opportunity opportunity = new Opportunity(pole, oprRobotLocationcoordinates, rectangleCornerCoordinates);

                string order = txtOrderOpr.Text;

                opportunity.Move(order);

                string loc = opportunity.GetLastLocation();

                lblOprResult.Text = loc;
            }
        }

        private IPole GetPole()
        {
           if(rbEast.Checked && rbEast!=null)
            {
                EastPole eastPole = new EastPole();
                return eastPole;
            }

           else if (rbNorth.Checked && rbNorth != null)
            {
                NorthPole northPole = new NorthPole();
                return northPole;
            }

           else if (rbSouth.Checked && rbSouth != null)
            {
                SouthPole southPole = new SouthPole();
                return southPole;
            }

            else if(rbWest.Checked && rbWest != null)
            {
                WestPole westPole = new WestPole();

                return westPole;
            }

            else
            {

                return null;
            }
        }

        private IPole GetOprPole()
        {
            if (rbEastOpr.Checked && rbEastOpr != null)
            {
                EastPole eastPole = new EastPole();
                return eastPole;
            }

            else if (rbNorthOpr.Checked && rbNorthOpr != null)
            {
                NorthPole northPole = new NorthPole();
                return northPole;
            }

            else if (rbSouthOpr.Checked && rbSouthOpr != null)
            {
                SouthPole southPole = new SouthPole();
                return southPole;
            }

            else if (rbWestOpr.Checked && rbWestOpr != null)
            {
                WestPole westPole = new WestPole();

                return westPole;
            }

            else
            {

                return null;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            txtOrder.Text= txtOrder.Text + "R";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            txtOrder.Text = txtOrder.Text + "L";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtOrder.Text = txtOrder.Text + "M";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtOrder.Text=txtOrder.Text.Remove(txtOrder.Text.Length - 1);
        }

        private void btnRightOpr_Click(object sender, EventArgs e)
        {
            txtOrderOpr.Text = txtOrderOpr.Text + "R";
        }

        private void btnLeftOpr_Click(object sender, EventArgs e)
        {
            txtOrderOpr.Text = txtOrderOpr.Text + "L";
        }

        private void btnGoOpr_Click(object sender, EventArgs e)
        {
            txtOrderOpr.Text = txtOrderOpr.Text + "M";
        }

        private void btnBackOpr_Click(object sender, EventArgs e)
        {
            txtOrderOpr.Text = txtOrderOpr.Text.Remove(txtOrderOpr.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           rbEast.Checked=true;
            rbEastOpr.Checked = true;
            
        }
    }
}
