using System; // This is a System namespace
using System.Drawing; // This is a System.Drawing namespace
using System.Windows.Forms.DataVisualization.Charting; // Use this to plot necessary information about MFC

namespace WinFormsApp // This is a namespace named Improved_Workflow_Manager
{

    public class MassFlowController : MassFlowControllerInterface // This is a class named MassFlowController that implements the MassFlowControllerInterface
    {
        

        private string mfcName;                    // This is a private string variable named mfcName
        private string mfcGasName;                 // This is a private string variable named mfcGasName
        private int mfcId;                         // This is a private integer variable named mfcId
        private Color mfcColor;                   // This is a private Color variable named mfcColor
        private double mfcInitialPressure;         // This is a private double variable named mfcInitialPressure
        private bool isConnected;                   // This is a private boolean variable named isConnected
        // Here is important because we cannot set or read mfcFlowRate whenever we want. We need to use the method setMfcFlowRate and readMfcFlowRate using Connection class.
        private double mfcFlowRate;                 // This is a private double variable named mfcFlowRate
        private double minFlowRate;                 // This is a private double variable named minFlowRate
        private double maxFlowRate;                 // This is a private double variable named maxFlowRate
        private string mfcStatus;                   // This is a private string variable named mfcStatus
        private int mfcRegister;                    // This is a private integer variable named mfcRegister
        private Chart mfcChart;                     // This is a chart to plot the necessary data for mfc


        public MassFlowController(string mfcName, string mfcGasName, int mfcId, double minFlowRate, double maxFlowRate,string mfcStatus) // This is a constructor for the MassFlowController class that takes in a string name, a string gasName, an integer id, and a Color color
        {
            this.mfcName = mfcName;                                                         // This sets the mfcName variable to the name parameter
            this.mfcGasName = mfcGasName;                                                   // This sets the mfcColor variable to the color parameter1
            this.mfcId = mfcId;                                                             // This sets the mfcId variable to the id parameter                                                  // This sets the mfcColor variable to the color parameter
            this.minFlowRate = minFlowRate;                                                 // This sets the minFlowRate variable to the minFlowRate parameter
            this.maxFlowRate = maxFlowRate;                                                 // This sets the maxFlowRate variable to the maxFlowRate parameter
            this.mfcStatus = mfcStatus;                                                     // This sets the mfcStatus variable to the status parameter
            this.mfcChart = new Chart();                                                    // Assign new Char a value
        }


        // This is a public method named SetMfcName that takes in a string name
        public void setMfcName(string mfcName) 
        {
            this.mfcName = mfcName; // This sets the mfcName variable to the name parameter
        }

        // This is a public method named GetMfcName that returns a string
        public string getMfcName() 
        {
            return mfcName; // This returns the mfcName variable
        }

        // This is a public method named SetMfcGasName that takes in a string gasName
        public void setMfcGasName(string mfcGasName) 
        {
            this.mfcGasName = mfcGasName; // This sets the mfcGasName variable to the gasName parameter
        }

        // This is a public method named getMfcGasName that returns a string mfcGasName
        public string getMfcGasName()                 
        {
            return this.mfcGasName;
        }

        // This is a public method named setMfcId that takes in an integer id
        public void setMfcId(int mfcId)
        {
            this.mfcId = mfcId; // This sets the mfcId variable to the id parameter
        }
        // This is a public method named getMfcId that returns an integer
        public int getMfcId()
        {
            return mfcId; // This returns the mfcId variable
        }

        // This is a public method named setMfcColor that takes in a Color color
        public void setMfcColor(Color mfcColor)
        {
            this.mfcColor = mfcColor; // This sets the mfcColor variable to the color parameter
        }
        // This is a public method named getMfcColor that returns a Color
        public Color getMfcColor()
        {
            return mfcColor; // This returns the mfcColor variable
        }

        // This is a public method named setMfcInitialPressure that takes in a double initialPressure
        public void setMfcInitialPressure(double mfcInitialPressure)
        {
            this.mfcInitialPressure = mfcInitialPressure; // This sets the mfcInitialPressure variable to the initialPressure parameter
        }
        // This is a public method named getMfcInitialPressure that returns a double
        public double getMfcInitialPressure()
        {
            return mfcInitialPressure; // This returns the mfcInitialPressure variable
        }

        // This is a public method named Connect that sets the isConnected variable to true or false
        public void setIsConnected(bool isConnected)
        {
            this.isConnected = isConnected; // This sets the isConnected variable to the isConnected parameter
        }

        // This is a public method named getIsConnected that returns a boolean
        public bool getIsConnected()
        {
            return isConnected; // This returns the isConnected variable
        }


        /*
         * Below two method very important Here we should use Connection class 
        */
        // This is a public method named setMfcFlowRate that takes in a double flowRate
        public bool setMfcFlowRate(double mfcFlowRate)
        {
            this.mfcFlowRate = mfcFlowRate; // This sets the mfcFlowRate variable to the flowRate parameter
            return false; // This returns false
        }

        // This is a public method named readMfcFlowRate that returns a double
        public double readMfcFlowRate()
        {
            return mfcFlowRate; // This returns the mfcFlowRate variable
        }

        // This is a public method named setMinFlowRate that takes in a double minFlowRate
        public void setMinFlowRate(double minFlowRate)
        {
            this.minFlowRate = minFlowRate; // This sets the minFlowRate variable to the minFlowRate parameter
        }

        // This is a public method named getMinFlowRate that returns a double
        public double getMinFlowRate()
        {
            return minFlowRate; // This returns the minFlowRate variable
        }

        // This is a public method named setMaxFlowRate that takes in a double maxFlowRate
        public void setMaxFlowRate(double maxFlowRate)
        {
            this.maxFlowRate = maxFlowRate; // This sets the maxFlowRate variable to the maxFlowRate parameter
        }

        // This is a public method named getMaxFlowRate that returns a double
        public double getMaxFlowRate()
        {
            return maxFlowRate; // This returns the maxFlowRate variable
        }

        // This is a public method named setMfcStatus that takes in a string status
        public void setMfcStatus(string mfcStatus)
        {
            this.mfcStatus = mfcStatus; // This sets the mfcStatus variable to the status parameter
        }

        // This is a public method named getMfcStatus that returns a string
        public string getMfcStatus()
        {
            return mfcStatus; // This returns the mfcStatus variable
        }

        // This is a public method named setMfcRegister that takes in an integer register
        public void setMfcRegister(int mfcRegister)
        {
            this.mfcRegister = mfcRegister; // This sets the mfcRegister variable to the register parameter
        }

        // This is a public method named getMfcRegister that returns an integer
        public int getMfcRegister()
        {
            return mfcRegister; // This returns the mfcRegister variable
        }

        // This is a public method named setMfcChart that takes in a Chart chart
        public void setMfcChart(Chart mfcChart)
        {
            this.mfcChart = mfcChart; // This sets the mfcChart variable to the chart parameter
        }

        // This is a public method named getMfcChart that returns a Chart
        public Chart getMfcChart()
        {
            return mfcChart; // This returns the mfcChart variable
        }

        
    }
}