// Purpose: This class is used to control the temperature of the system. It is used to set the temperature of the system and to get the temperature of the system. It is also used to plot the temperature of the system.
using System.Windows.Forms.DataVisualization.Charting; // Use this to plot necessary information about TemperatureController
namespace WinFormsApp
{
    // TemperatureController class
    public class TemperatureController : TemperatureControllerInterface
    {
        
        private string temperatureStatus;                                 // This is a private string variable named temperatureStatus
        private Chart temperatureChart;                                   // This is a private Chart variable named temperatureChart
        private int temperatureID;                                        // This is a private integer variable named temperatureID
        private int tempSetRegister;                                      // This is a private integer variable named tempSetRegister
        private int tempReadRegister;                                     // This is a private integer variable named tempReadRegister

        private double tempFlowRate;                                      // This is a private double variable named tempFlowRate

        public TemperatureController(int temperatureID, int tempSetRegister, int tempReadRegister,string temperatureStatus) // This is a constructor for the TemperatureController class that takes in an integer id, an integer setRegister, and an integer readRegister
        {
            this.temperatureID = temperatureID;                         // This sets the temperatureID variable to the id parameter
            this.tempSetRegister = tempSetRegister;                     // This sets the tempSetRegister variable to the setRegister parameter
            this.tempReadRegister = tempReadRegister;                   // This sets the tempReadRegister variable to the readRegister parameter
            this.temperatureChart = new Chart();                        // Assign new Char a value
            this.temperatureStatus = temperatureStatus;                 // This sets the temperatureStatus variable to the status parameter
        }

        // This is a public method named getTemperatureChart that returns a Chart
        public Chart getTemperatureChart()
        {
            return this.temperatureChart;
        }

        // This is a public method named getTemperatureID that returns an integer
        public int getTemperatureID()
        {
            return this.temperatureID;
        }

        // This is a public method named getTemperatureStatus that returns a string
        public string getTemperatureStatus()
        {
            return this.temperatureStatus;
        }

        // This is a public method named getTempFlowRate that returns a double
        public double getTempFlowRate()
        {
            return this.tempFlowRate;
        }

        // This is a public method named getTempReadRegister that returns an integer
        public int getTempReadRegister()
        {
            return this.tempReadRegister;
        }

        // This is a public method named getTempSetRegister that returns an integer
        public int getTempSetRegister()
        {
            return this.tempSetRegister;
        }

        // This is a public method named readTemperature from the device
        public double readTemperature() { 
            return this.tempFlowRate;
        }

        // This is a public method named setTemperature that takes in a double temperature and set device temperature

        public bool setTemperature(double temperature) { 
            this.tempFlowRate = temperature; // This sets the temperature variable to the temperature parameter
            return false;
        }
        // This is a public method named setTemperatureChart that takes in a Chart temperatureChart
        public void setTemperatureChart(Chart temperatureChart)
        {
            this.temperatureChart = temperatureChart;
        }

        // This is a public method named setTemperatureID that takes in an integer temperatureID
        public void setTemperatureID(int temperatureID)
        {
            this.temperatureID= temperatureID;
        }

        // This is a public method named setTemperatureStatus that takes in a string temperatureStatus
        public void setTemperatureStatus(string temperatureStatus)
        {
            this.temperatureStatus  = temperatureStatus;
        }

        // This is a public method named setTempFlowRate that takes in a double tempFloatRate
        public void setTempFlowRate(double tempFloatRate)
        {
            this.tempFlowRate= tempFloatRate;
        }

        // This is a public method named setTempReadRegister that takes in an integer tempReadRegister
        public void setTempReadRegister(int tempReadRegister)
        {
            this.tempReadRegister= tempReadRegister;
        }

        // This is a public method named setTempSetRegister that takes in an integer tempSetRegister
        public void setTempSetRegister(int tempSetRegister)
        {
            this.tempSetRegister= tempSetRegister;
        }

    
    }
}