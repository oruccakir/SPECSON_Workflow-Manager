using System.Windows.Forms.DataVisualization.Charting; // Use this to plot necessary information about TemperatureController
namespace WinFormsApp
{
    public interface TemperatureControllerInterface
    {
        
        void setTemperatureStatus(string temperatureStatus);
        // This method is used to get the status of the TemperatureController.
        string getTemperatureStatus();
        // This method is used to set the id of the TemperatureController.
        void setTemperatureID(int temperatureID);
        // This method is used to get the id of the TemperatureController.
        int getTemperatureID();
        // This method is used to set the setTempRegister of the TemperatureController.
        void setTempSetRegister(int tempSetRegister);
        // This method is used to get the setTempRegister of the TemperatureController.
        int getTempSetRegister();
        // This method is used to set the tempReadRegister of the TemperatureController.
        void setTempReadRegister(int tempReadRegister);
        // This method is used to get the tempReadRegister of the TemperatureController.
        int getTempReadRegister();

        // This method is used to set the temperature chart of the TemperatureController.
        void setTemperatureChart(Chart temperatureChart);
        // This method is used to get the temperature chart of the TemperatureController.
        Chart getTemperatureChart();

        // This method is used to get the temperature flow rate of the TemperatureController.
        double getTempFlowRate();

        // This method is used to set the temperature flow rate of the TemperatureController.
        void setTempFlowRate(double tempFlowRate);

        // This method is used to read the temperature from the device.
        double readTemperature();

        // This method is used to set the temperature of the TemperatureController.
        bool setTemperature(double temperature);


    }
}